﻿Imports System.Net
Imports System.Text
Imports System.IO
Imports BAGIS_ClassLibrary

Public Class SecurityHelper

    Public Shared Function BA_GetStoredToken() As String
        Return My.Settings.GoldenTicket
    End Function

    Private Shared Sub StoreToken(ByVal aToken As BagisToken)
        My.Settings.GoldenTicket = aToken.token
        My.Settings.Save()
    End Sub

    Public Shared Function GetServerToken(ByVal userName As String, ByVal password As String, ByVal url As String) As String
        Dim reqT As HttpWebRequest
        Dim resT As HttpWebResponse
        reqT = WebRequest.Create(url)
        'Needs to be a POST request to get a token
        reqT.Method = "POST"

        'These are the field/value pairs that would be on an html form
        Dim Data As String = "username=" & userName & "&password=" & password
        'Encode them to Byte format to include with the request
        Dim credArray As Byte() = Encoding.UTF8.GetBytes(Data)
        'We are sending a form
        reqT.ContentType = "application/x-www-form-urlencoded"
        reqT.ContentLength = credArray.Length

        '@ToDo: Workaround for certificate error; This should come out when the certificate issue is fixed
        'ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)

        Try
            'Intercept the httpRequest so we can add the user name/password
            Dim dataStreamT As System.IO.Stream = reqT.GetRequestStream()
            dataStreamT.Write(credArray, 0, credArray.Length)
            dataStreamT.Close()
            'Send the request and wait for response
            resT = CType(reqT.GetResponse(), HttpWebResponse)
            'Convert the JSON response to a BagisToken object
            Dim aToken As BagisToken = New BagisToken
            Dim ser As System.Runtime.Serialization.Json.DataContractJsonSerializer = New System.Runtime.Serialization.Json.DataContractJsonSerializer(aToken.[GetType]())
            'Store token in user settings
            aToken = CType(ser.ReadObject(resT.GetResponseStream), BagisToken)
            StoreToken(aToken)
            Return aToken.token
        Catch ex As WebException
            Debug.Print("GetServerToken Exception" & ex.Message)
            Return Nothing
        End Try
    End Function

    Public Shared Function IsTokenValid(ByVal testUrl As String, ByVal strToken As String) As Boolean
        Dim reqT As HttpWebRequest
        Dim resT As HttpWebResponse
        'The end point for getting a token for the web service
        reqT = WebRequest.Create(testUrl)
        'This is a GET request
        reqT.Method = "GET"

        'Retrieve the token and format it for the header; Token comes from caller
        Dim cred As String = String.Format("{0} {1}", "Token", strToken)
        'Put token in header
        reqT.Headers(HttpRequestHeader.Authorization) = cred

        '@ToDo: Workaround for certificate error; This should come out when the certificate issue is fixed
        'ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf AcceptAllCertifications)

        Try
            resT = CType(reqT.GetResponse(), HttpWebResponse)
            'Printing the response to the Console for testing
            'Using SReader As System.IO.StreamReader = New System.IO.StreamReader(resT.GetResponseStream)
            '    Debug.Print(SReader.ReadToEnd())
            'End Using
            'If we didn't get an exception, the token is valid
            Return True
        Catch ex As WebException
            'Catch exception and return false; Token is not valid
            Return False
        End Try
    End Function

    Protected Shared Function AcceptAllCertifications(ByVal sender As Object, ByVal certification As System.Security.Cryptography.X509Certificates.X509Certificate, ByVal chain As System.Security.Cryptography.X509Certificates.X509Chain, ByVal sslPolicyErrors As System.Net.Security.SslPolicyErrors) As Boolean
        Return True
    End Function

    Public Shared Function IsPathWritable(ByVal strPath) As Boolean
        'http://www.vbdotnetforums.com/vb-net-general-discussion/57111-how-get-simple-yes-no-if-user-has-read-write-permission-directory.html
        IsPathWritable = True
        If Not Directory.Exists(strPath) Then
            IsPathWritable = False
        Else
            Try
                Dim fs As FileStream = File.Create(strPath & "\WriteTest.txt", 5, FileOptions.DeleteOnClose)
                fs.Close()
            Catch ex As IOException
                IsPathWritable = False
            End Try
        End If
    End Function

    Public Shared Function GenerateToken(ByVal validateUrl As String, ByVal tokenUrl As String) As BA_ReturnCode
        'Set reference to HruExtension
        Dim hruExt As HruExtension = HruExtension.GetExtension
        If hruExt.EbagisToken Is Nothing Then  '1. look for token in extension
            Dim strToken As String = SecurityHelper.BA_GetStoredToken() '2. if not, check to see if token is stored
            If Not String.IsNullOrEmpty(strToken) Then
                Dim isValid As Boolean = SecurityHelper.IsTokenValid(validateUrl, strToken)
                If isValid = True Then      '3. If stored token valid, store in extension
                    Dim newToken As BagisToken = New BagisToken
                    newToken.token = strToken
                    hruExt.EbagisToken = newToken
                    Return BA_ReturnCode.Success
                End If
            End If
            ' 4. Otherwise use get user name and password for token
            Dim passwordForm As FrmPassword = New FrmPassword(tokenUrl)
            passwordForm.ShowDialog()
            If hruExt.EbagisToken Is Nothing Then   '5. The form puts the token in hruExt if it's successful
                Return BA_ReturnCode.OtherError
            Else
                Return BA_ReturnCode.Success
            End If
        Else
            Return BA_ReturnCode.Success
        End If
    End Function

End Class
