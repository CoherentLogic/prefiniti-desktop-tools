﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.5444
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'This source code was auto-generated by Microsoft.VSDesigner, Version 2.0.50727.5444.
'
Namespace PAFUser
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="UserResource.cfcSoapBinding", [Namespace]:="http://DefaultNamespace"),  _
     System.Xml.Serialization.SoapIncludeAttribute(GetType(Map)),  _
     System.Xml.Serialization.SoapIncludeAttribute(GetType(QueryBean)),  _
     System.Xml.Serialization.SoapIncludeAttribute(GetType(CFCInvocationException))>  _
    Partial Public Class UserResource
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private LoadOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UserIDFromUsernameOperationCompleted As System.Threading.SendOrPostCallback
        
        Private UsernameFromUserIDOperationCompleted As System.Threading.SendOrPostCallback
        
        Private IsOnlineOperationCompleted As System.Threading.SendOrPostCallback
        
        Private SigninDateOperationCompleted As System.Threading.SendOrPostCallback
        
        Private LastSeenOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.PrefinitiBrowser.My.MySettings.Default.PrefinitiBrowser_PAFUser_UserResource
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event LoadCompleted As LoadCompletedEventHandler
        
        '''<remarks/>
        Public Event UserIDFromUsernameCompleted As UserIDFromUsernameCompletedEventHandler
        
        '''<remarks/>
        Public Event UsernameFromUserIDCompleted As UsernameFromUserIDCompletedEventHandler
        
        '''<remarks/>
        Public Event IsOnlineCompleted As IsOnlineCompletedEventHandler
        
        '''<remarks/>
        Public Event SigninDateCompleted As SigninDateCompletedEventHandler
        
        '''<remarks/>
        Public Event LastSeenCompleted As LastSeenCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function Load(ByVal UserName As String) As <System.Xml.Serialization.SoapElementAttribute("LoadReturn")> Object()
            Dim results() As Object = Me.Invoke("Load", New Object() {UserName})
            Return CType(results(0),Object())
        End Function
        
        '''<remarks/>
        Public Overloads Sub LoadAsync(ByVal UserName As String)
            Me.LoadAsync(UserName, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub LoadAsync(ByVal UserName As String, ByVal userState As Object)
            If (Me.LoadOperationCompleted Is Nothing) Then
                Me.LoadOperationCompleted = AddressOf Me.OnLoadOperationCompleted
            End If
            Me.InvokeAsync("Load", New Object() {UserName}, Me.LoadOperationCompleted, userState)
        End Sub
        
        Private Sub OnLoadOperationCompleted(ByVal arg As Object)
            If (Not (Me.LoadCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LoadCompleted(Me, New LoadCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function UserIDFromUsername(ByVal Username As String) As <System.Xml.Serialization.SoapElementAttribute("UserIDFromUsernameReturn")> Double
            Dim results() As Object = Me.Invoke("UserIDFromUsername", New Object() {Username})
            Return CType(results(0),Double)
        End Function
        
        '''<remarks/>
        Public Overloads Sub UserIDFromUsernameAsync(ByVal Username As String)
            Me.UserIDFromUsernameAsync(Username, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UserIDFromUsernameAsync(ByVal Username As String, ByVal userState As Object)
            If (Me.UserIDFromUsernameOperationCompleted Is Nothing) Then
                Me.UserIDFromUsernameOperationCompleted = AddressOf Me.OnUserIDFromUsernameOperationCompleted
            End If
            Me.InvokeAsync("UserIDFromUsername", New Object() {Username}, Me.UserIDFromUsernameOperationCompleted, userState)
        End Sub
        
        Private Sub OnUserIDFromUsernameOperationCompleted(ByVal arg As Object)
            If (Not (Me.UserIDFromUsernameCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UserIDFromUsernameCompleted(Me, New UserIDFromUsernameCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function UsernameFromUserID(ByVal UserID As Double) As <System.Xml.Serialization.SoapElementAttribute("UsernameFromUserIDReturn")> String
            Dim results() As Object = Me.Invoke("UsernameFromUserID", New Object() {UserID})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub UsernameFromUserIDAsync(ByVal UserID As Double)
            Me.UsernameFromUserIDAsync(UserID, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub UsernameFromUserIDAsync(ByVal UserID As Double, ByVal userState As Object)
            If (Me.UsernameFromUserIDOperationCompleted Is Nothing) Then
                Me.UsernameFromUserIDOperationCompleted = AddressOf Me.OnUsernameFromUserIDOperationCompleted
            End If
            Me.InvokeAsync("UsernameFromUserID", New Object() {UserID}, Me.UsernameFromUserIDOperationCompleted, userState)
        End Sub
        
        Private Sub OnUsernameFromUserIDOperationCompleted(ByVal arg As Object)
            If (Not (Me.UsernameFromUserIDCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent UsernameFromUserIDCompleted(Me, New UsernameFromUserIDCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function IsOnline(ByVal Username As String) As <System.Xml.Serialization.SoapElementAttribute("IsOnlineReturn")> Boolean
            Dim results() As Object = Me.Invoke("IsOnline", New Object() {Username})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub IsOnlineAsync(ByVal Username As String)
            Me.IsOnlineAsync(Username, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub IsOnlineAsync(ByVal Username As String, ByVal userState As Object)
            If (Me.IsOnlineOperationCompleted Is Nothing) Then
                Me.IsOnlineOperationCompleted = AddressOf Me.OnIsOnlineOperationCompleted
            End If
            Me.InvokeAsync("IsOnline", New Object() {Username}, Me.IsOnlineOperationCompleted, userState)
        End Sub
        
        Private Sub OnIsOnlineOperationCompleted(ByVal arg As Object)
            If (Not (Me.IsOnlineCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent IsOnlineCompleted(Me, New IsOnlineCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function SigninDate(ByVal Username As String) As <System.Xml.Serialization.SoapElementAttribute("SigninDateReturn")> String
            Dim results() As Object = Me.Invoke("SigninDate", New Object() {Username})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub SigninDateAsync(ByVal Username As String)
            Me.SigninDateAsync(Username, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub SigninDateAsync(ByVal Username As String, ByVal userState As Object)
            If (Me.SigninDateOperationCompleted Is Nothing) Then
                Me.SigninDateOperationCompleted = AddressOf Me.OnSigninDateOperationCompleted
            End If
            Me.InvokeAsync("SigninDate", New Object() {Username}, Me.SigninDateOperationCompleted, userState)
        End Sub
        
        Private Sub OnSigninDateOperationCompleted(ByVal arg As Object)
            If (Not (Me.SigninDateCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent SigninDateCompleted(Me, New SigninDateCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function LastSeen(ByVal Username As String) As <System.Xml.Serialization.SoapElementAttribute("LastSeenReturn")> String
            Dim results() As Object = Me.Invoke("LastSeen", New Object() {Username})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub LastSeenAsync(ByVal Username As String)
            Me.LastSeenAsync(Username, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub LastSeenAsync(ByVal Username As String, ByVal userState As Object)
            If (Me.LastSeenOperationCompleted Is Nothing) Then
                Me.LastSeenOperationCompleted = AddressOf Me.OnLastSeenOperationCompleted
            End If
            Me.InvokeAsync("LastSeen", New Object() {Username}, Me.LastSeenOperationCompleted, userState)
        End Sub
        
        Private Sub OnLastSeenOperationCompleted(ByVal arg As Object)
            If (Not (Me.LastSeenCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent LastSeenCompleted(Me, New LastSeenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.SoapTypeAttribute([Namespace]:="http://xml.apache.org/xml-soap")>  _
    Partial Public Class Map
        
        Private itemField() As mapItem
        
        '''<remarks/>
        Public Property item() As mapItem()
            Get
                Return Me.itemField
            End Get
            Set
                Me.itemField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.SoapTypeAttribute([Namespace]:="http://xml.apache.org/xml-soap")>  _
    Partial Public Class mapItem
        
        Private keyField As Object
        
        Private valueField As Object
        
        '''<remarks/>
        <System.Xml.Serialization.SoapElementAttribute(IsNullable:=true)>  _
        Public Property key() As Object
            Get
                Return Me.keyField
            End Get
            Set
                Me.keyField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.SoapElementAttribute(IsNullable:=true)>  _
        Public Property value() As Object
            Get
                Return Me.valueField
            End Get
            Set
                Me.valueField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.SoapTypeAttribute([Namespace]:="http://rpc.xml.coldfusion")>  _
    Partial Public Class QueryBean
        
        Private columnListField() As String
        
        Private dataField() As Object
        
        '''<remarks/>
        <System.Xml.Serialization.SoapElementAttribute(IsNullable:=true)>  _
        Public Property columnList() As String()
            Get
                Return Me.columnListField
            End Get
            Set
                Me.columnListField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.SoapElementAttribute(IsNullable:=true)>  _
        Public Property data() As Object()
            Get
                Return Me.dataField
            End Get
            Set
                Me.dataField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "2.0.50727.5420"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.SoapTypeAttribute([Namespace]:="http://rpc.xml.coldfusion")>  _
    Partial Public Class CFCInvocationException
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub LoadCompletedEventHandler(ByVal sender As Object, ByVal e As LoadCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class LoadCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Object()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Object())
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub UserIDFromUsernameCompletedEventHandler(ByVal sender As Object, ByVal e As UserIDFromUsernameCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UserIDFromUsernameCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Double
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Double)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub UsernameFromUserIDCompletedEventHandler(ByVal sender As Object, ByVal e As UsernameFromUserIDCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class UsernameFromUserIDCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub IsOnlineCompletedEventHandler(ByVal sender As Object, ByVal e As IsOnlineCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class IsOnlineCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Boolean
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Boolean)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub SigninDateCompletedEventHandler(ByVal sender As Object, ByVal e As SigninDateCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class SigninDateCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub LastSeenCompletedEventHandler(ByVal sender As Object, ByVal e As LastSeenCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class LastSeenCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As String
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),String)
            End Get
        End Property
    End Class
End Namespace
