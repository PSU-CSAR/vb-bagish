﻿Public Class BtnDownloadAoi
  Inherits ESRI.ArcGIS.Desktop.AddIns.Button

  Public Sub New()

  End Sub

  Protected Overrides Sub OnClick()
        'Dim dForm As FrmDownloadAoiMenu = New FrmDownloadAoiMenu()
        'dForm.ShowDialog()
        Dim uForm As FrmUploadAoi = New FrmUploadAoi()
        uForm.ShowDialog()
  End Sub

  Protected Overrides Sub OnUpdate()

  End Sub
End Class
