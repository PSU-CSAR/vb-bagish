'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports ESRI.ArcGIS.ArcMapUI
Imports ESRI.ArcGIS.Desktop.AddIns
Imports ESRI.ArcGIS.Framework
Imports System
Imports System.Collections.Generic

Namespace My
    
    '''<summary>
    '''A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    '''</summary>
    Friend Module ThisAddIn
        
        Friend ReadOnly Property Name() As String
            Get
                Return "BAGIS_H"
            End Get
        End Property
        
        Friend ReadOnly Property AddInID() As String
            Get
                Return "{fd496308-7438-4baa-a08e-05ff7656c16c}"
            End Get
        End Property
        
        Friend ReadOnly Property Company() As String
            Get
                Return "Portland State University"
            End Get
        End Property
        
        Friend ReadOnly Property Version() As String
            Get
                Return "1.5.0"
            End Get
        End Property
        
        Friend ReadOnly Property Description() As String
            Get
                Return "Hydrological Response Unit (HRU) Delineation Tool"
            End Get
        End Property
        
        Friend ReadOnly Property Author() As String
            Get
                Return "Lesley Bross, Richa Jain, and Geoffrey Duh"
            End Get
        End Property
        
        Friend ReadOnly Property [Date]() As String
            Get
                Return "2/18/2015"
            End Get
        End Property
        
        <System.Runtime.CompilerServices.ExtensionAttribute()>  _
        Friend Function ToUID(ByVal id As String) As ESRI.ArcGIS.esriSystem.UID
            Dim uid As ESRI.ArcGIS.esriSystem.UID = New ESRI.ArcGIS.esriSystem.UIDClass()
            uid.Value = id
            Return uid
        End Function
        
        '''<summary>
        '''A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        '''</summary>
        Friend Class IDs
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnDefineHruZones', the id declared for Add-in Button class 'BtnDefineHruZones'
            '''</summary>
            Friend Shared ReadOnly Property BtnDefineHruZones() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnDefineHruZones"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnPostProcess', the id declared for Add-in Button class 'BtnPostProcess'
            '''</summary>
            Friend Shared ReadOnly Property BtnPostProcess() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnPostProcess"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_CboSelectedAoi', the id declared for Add-in ComboBox class 'CboSelectedAoi'
            '''</summary>
            Friend Shared ReadOnly Property CboSelectedAoi() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_CboSelectedAoi"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnCookieCut', the id declared for Add-in Button class 'BtnCookieCut'
            '''</summary>
            Friend Shared ReadOnly Property BtnCookieCut() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnCookieCut"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnPrmsRadiation', the id declared for Add-in Button class 'BtnPrmsRadiation'
            '''</summary>
            Friend Shared ReadOnly Property BtnPrmsRadiation() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnPrmsRadiation"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnZonalStats', the id declared for Add-in Button class 'BtnZonalStats'
            '''</summary>
            Friend Shared ReadOnly Property BtnZonalStats() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnZonalStats"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnUseTemplate', the id declared for Add-in Button class 'BtnUseTemplate'
            '''</summary>
            Friend Shared ReadOnly Property BtnUseTemplate() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnUseTemplate"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnVecToRas', the id declared for Add-in Button class 'BtnVecToRas'
            '''</summary>
            Friend Shared ReadOnly Property BtnVecToRas() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnVecToRas"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnEditRule', the id declared for Add-in Button class 'BtnEditRule'
            '''</summary>
            Friend Shared ReadOnly Property BtnEditRule() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnEditRule"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnExportToWeasel', the id declared for Add-in Button class 'BtnExportToWeasel'
            '''</summary>
            Friend Shared ReadOnly Property BtnExportToWeasel() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnExportToWeasel"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnAbout', the id declared for Add-in Button class 'BtnAbout'
            '''</summary>
            Friend Shared ReadOnly Property BtnAbout() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnAbout"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnStamp', the id declared for Add-in Button class 'BtnStamp'
            '''</summary>
            Friend Shared ReadOnly Property BtnStamp() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnStamp"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_MyTool', the id declared for Add-in Tool class 'MyTool'
            '''</summary>
            Friend Shared ReadOnly Property MyTool() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_MyTool"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_PATtool', the id declared for Add-in Tool class 'PATtool'
            '''</summary>
            Friend Shared ReadOnly Property PATtool() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_PATtool"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnEditLulc', the id declared for Add-in Button class 'BtnEditLulc'
            '''</summary>
            Friend Shared ReadOnly Property BtnEditLulc() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnEditLulc"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnEditSlope', the id declared for Add-in Button class 'BtnEditSlope'
            '''</summary>
            Friend Shared ReadOnly Property BtnEditSlope() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnEditSlope"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnEditCanopy', the id declared for Add-in Button class 'BtnEditCanopy'
            '''</summary>
            Friend Shared ReadOnly Property BtnEditCanopy() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnEditCanopy"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnViewAoi', the id declared for Add-in Button class 'BtnViewAoi'
            '''</summary>
            Friend Shared ReadOnly Property BtnViewAoi() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnViewAoi"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnTest', the id declared for Add-in Button class 'BtnTest'
            '''</summary>
            Friend Shared ReadOnly Property BtnTest() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnTest"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_BtnViewLog', the id declared for Add-in Button class 'BtnViewLog'
            '''</summary>
            Friend Shared ReadOnly Property BtnViewLog() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_BtnViewLog"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnExportToGdb', the id declared for Add-in Button class 'BtnExportToGdb'
            '''</summary>
            Friend Shared ReadOnly Property BtnExportToGdb() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnExportToGdb"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnReclassZones', the id declared for Add-in Button class 'BtnReclassZones'
            '''</summary>
            Friend Shared ReadOnly Property BtnReclassZones() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnReclassZones"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_IdentifyTool', the id declared for Add-in Tool class 'IdentifyTool'
            '''</summary>
            Friend Shared ReadOnly Property IdentifyTool() As String
                Get
                    Return "Portland_State_University_BAGIS_H_IdentifyTool"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnFileLocator', the id declared for Add-in Button class 'BtnFileLocator'
            '''</summary>
            Friend Shared ReadOnly Property BtnFileLocator() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnFileLocator"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnSlopeConverter', the id declared for Add-in Button class 'BtnSlopeConverter'
            '''</summary>
            Friend Shared ReadOnly Property BtnSlopeConverter() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnSlopeConverter"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnSequentialId', the id declared for Add-in Button class 'BtnSequentialId'
            '''</summary>
            Friend Shared ReadOnly Property BtnSequentialId() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnSequentialId"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnToolsDataUnits', the id declared for Add-in Button class 'BtnToolsDataUnits'
            '''</summary>
            Friend Shared ReadOnly Property BtnToolsDataUnits() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnToolsDataUnits"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnSnodas', the id declared for Add-in Button class 'BtnSnodas'
            '''</summary>
            Friend Shared ReadOnly Property BtnSnodas() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnSnodas"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnFileModify', the id declared for Add-in Button class 'BtnFileModify'
            '''</summary>
            Friend Shared ReadOnly Property BtnFileModify() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnFileModify"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnWebServices', the id declared for Add-in Button class 'BtnWebServices'
            '''</summary>
            Friend Shared ReadOnly Property BtnWebServices() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnWebServices"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_BtnDownloadAoi', the id declared for Add-in Button class 'BtnDownloadAoi'
            '''</summary>
            Friend Shared ReadOnly Property BtnDownloadAoi() As String
                Get
                    Return "Portland_State_University_BAGIS_H_BtnDownloadAoi"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'ClassLibraryAddin_frmHruZone', the id declared for Add-in DockableWindow class 'frmHruZone+AddinImpl'
            '''</summary>
            Friend Shared ReadOnly Property frmHruZone() As String
                Get
                    Return "ClassLibraryAddin_frmHruZone"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_FrmEliminatePoly', the id declared for Add-in DockableWindow class 'FrmEliminatePoly+AddinImpl'
            '''</summary>
            Friend Shared ReadOnly Property FrmEliminatePoly() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_FrmEliminatePoly"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_FrmZonalStats', the id declared for Add-in DockableWindow class 'FrmZonalStats+AddinImpl'
            '''</summary>
            Friend Shared ReadOnly Property FrmZonalStats() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_FrmZonalStats"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_BAGIS_H_FrmReclassZones', the id declared for Add-in DockableWindow class 'FrmReclassZones+AddinImpl'
            '''</summary>
            Friend Shared ReadOnly Property FrmReclassZones() As String
                Get
                    Return "Portland_State_University_BAGIS_H_FrmReclassZones"
                End Get
            End Property
            
            '''<summary>
            '''Returns 'Portland_State_University_ClassLibraryAddin_HruExtension', the id declared for Add-in Extension class 'HruExtension'
            '''</summary>
            Friend Shared ReadOnly Property HruExtension() As String
                Get
                    Return "Portland_State_University_ClassLibraryAddin_HruExtension"
                End Get
            End Property
        End Class
    End Module
    
Friend Module ArcMap
  Private s_app As ESRI.ArcGIS.Framework.IApplication
  Private s_docEvent As ESRI.ArcGIS.ArcMapUI.IDocumentEvents_Event

  Public ReadOnly Property Application() As ESRI.ArcGIS.Framework.IApplication
    Get
      If s_app Is Nothing Then
        s_app = TryCast(Internal.AddInStartupObject.GetHook(Of ESRI.ArcGIS.ArcMapUI.IMxApplication)(), ESRI.ArcGIS.Framework.IApplication)
      End If

      Return s_app
    End Get
  End Property

  Public ReadOnly Property Document() As ESRI.ArcGIS.ArcMapUI.IMxDocument
    Get
      If Application IsNot Nothing Then
        Return TryCast(Application.Document, ESRI.ArcGIS.ArcMapUI.IMxDocument)
      End If

      Return Nothing
    End Get
  End Property
  Public ReadOnly Property ThisApplication() As ESRI.ArcGIS.ArcMapUI.IMxApplication
    Get
      Return TryCast(Application, ESRI.ArcGIS.ArcMapUI.IMxApplication)
    End Get
  End Property
  Public ReadOnly Property DockableWindowManager() As ESRI.ArcGIS.Framework.IDockableWindowManager
    Get
      Return TryCast(Application, ESRI.ArcGIS.Framework.IDockableWindowManager)
    End Get
  End Property

  Public ReadOnly Property Events() As ESRI.ArcGIS.ArcMapUI.IDocumentEvents_Event
    Get
      s_docEvent = TryCast(Document, ESRI.ArcGIS.ArcMapUI.IDocumentEvents_Event)
      Return s_docEvent
    End Get
  End Property
End Module

Namespace Internal
  <ESRI.ArcGIS.Desktop.AddIns.StartupObjectAttribute(), _
   Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), _
   Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()> _
  Partial Public Class AddInStartupObject
    Inherits ESRI.ArcGIS.Desktop.AddIns.AddInEntryPoint

    Private m_addinHooks As List(Of Object)
    Private Shared _sAddInHostManager As AddInStartupObject

    Public Sub New()

    End Sub

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Protected Overrides Function Initialize(ByVal hook As Object) As Boolean
      Dim createSingleton As Boolean = _sAddInHostManager Is Nothing
      If createSingleton Then
        _sAddInHostManager = Me
        m_addinHooks = New List(Of Object)
        m_addinHooks.Add(hook)
      ElseIf Not _sAddInHostManager.m_addinHooks.Contains(hook) Then
        _sAddInHostManager.m_addinHooks.Add(hook)
      End If

      Return createSingleton
    End Function

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Protected Overrides Sub Shutdown()
      _sAddInHostManager = Nothing
      m_addinHooks = Nothing
    End Sub

    <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
    Friend Shared Function GetHook(Of T As Class)() As T
      If _sAddInHostManager IsNot Nothing Then
        For Each o As Object In _sAddInHostManager.m_addinHooks
          If TypeOf o Is T Then
            Return DirectCast(o, T)
          End If
        Next
      End If

      Return Nothing
    End Function

    ''' <summary>
    ''' Expose this instance of Add-in class externally
    ''' </summary>
    Public Shared Function GetThis() As AddInStartupObject
      Return _sAddInHostManager
    End Function

  End Class
End Namespace

End Namespace
