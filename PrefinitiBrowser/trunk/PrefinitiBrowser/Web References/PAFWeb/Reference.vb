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
Namespace PAFWeb
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="WebResource.cfcSoapBinding", [Namespace]:="http://DefaultNamespace")>  _
    Partial Public Class WebResource
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private CollectOperationCompleted As System.Threading.SendOrPostCallback
        
        Private RateOperationCompleted As System.Threading.SendOrPostCallback
        
        Private ShareOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetAverageRatingOperationCompleted As System.Threading.SendOrPostCallback
        
        Private GetMyRatingOperationCompleted As System.Threading.SendOrPostCallback
        
        Private RatingExistsOperationCompleted As System.Threading.SendOrPostCallback
        
        Private IsEnhancedOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.PrefinitiBrowser.My.MySettings.Default.PrefinitiBrowser_PAFWeb_WebResource
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
        Public Event CollectCompleted As CollectCompletedEventHandler
        
        '''<remarks/>
        Public Event RateCompleted As RateCompletedEventHandler
        
        '''<remarks/>
        Public Event ShareCompleted As ShareCompletedEventHandler
        
        '''<remarks/>
        Public Event GetAverageRatingCompleted As GetAverageRatingCompletedEventHandler
        
        '''<remarks/>
        Public Event GetMyRatingCompleted As GetMyRatingCompletedEventHandler
        
        '''<remarks/>
        Public Event RatingExistsCompleted As RatingExistsCompletedEventHandler
        
        '''<remarks/>
        Public Event IsEnhancedCompleted As IsEnhancedCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Sub Collect(ByVal key As String, ByVal url As String)
            Me.Invoke("Collect", New Object() {key, url})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CollectAsync(ByVal key As String, ByVal url As String)
            Me.CollectAsync(key, url, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub CollectAsync(ByVal key As String, ByVal url As String, ByVal userState As Object)
            If (Me.CollectOperationCompleted Is Nothing) Then
                Me.CollectOperationCompleted = AddressOf Me.OnCollectOperationCompleted
            End If
            Me.InvokeAsync("Collect", New Object() {key, url}, Me.CollectOperationCompleted, userState)
        End Sub
        
        Private Sub OnCollectOperationCompleted(ByVal arg As Object)
            If (Not (Me.CollectCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent CollectCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Sub Rate(ByVal key As String, ByVal url As String, ByVal category As String, ByVal rating As Double)
            Me.Invoke("Rate", New Object() {key, url, category, rating})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RateAsync(ByVal key As String, ByVal url As String, ByVal category As String, ByVal rating As Double)
            Me.RateAsync(key, url, category, rating, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RateAsync(ByVal key As String, ByVal url As String, ByVal category As String, ByVal rating As Double, ByVal userState As Object)
            If (Me.RateOperationCompleted Is Nothing) Then
                Me.RateOperationCompleted = AddressOf Me.OnRateOperationCompleted
            End If
            Me.InvokeAsync("Rate", New Object() {key, url, category, rating}, Me.RateOperationCompleted, userState)
        End Sub
        
        Private Sub OnRateOperationCompleted(ByVal arg As Object)
            If (Not (Me.RateCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RateCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Sub Share(ByVal key As String)
            Me.Invoke("Share", New Object() {key})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ShareAsync(ByVal key As String)
            Me.ShareAsync(key, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ShareAsync(ByVal key As String, ByVal userState As Object)
            If (Me.ShareOperationCompleted Is Nothing) Then
                Me.ShareOperationCompleted = AddressOf Me.OnShareOperationCompleted
            End If
            Me.InvokeAsync("Share", New Object() {key}, Me.ShareOperationCompleted, userState)
        End Sub
        
        Private Sub OnShareOperationCompleted(ByVal arg As Object)
            If (Not (Me.ShareCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ShareCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function GetAverageRating(ByVal key As String, ByVal url As String, ByVal category As String) As <System.Xml.Serialization.SoapElementAttribute("GetAverageRatingReturn")> String
            Dim results() As Object = Me.Invoke("GetAverageRating", New Object() {key, url, category})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetAverageRatingAsync(ByVal key As String, ByVal url As String, ByVal category As String)
            Me.GetAverageRatingAsync(key, url, category, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetAverageRatingAsync(ByVal key As String, ByVal url As String, ByVal category As String, ByVal userState As Object)
            If (Me.GetAverageRatingOperationCompleted Is Nothing) Then
                Me.GetAverageRatingOperationCompleted = AddressOf Me.OnGetAverageRatingOperationCompleted
            End If
            Me.InvokeAsync("GetAverageRating", New Object() {key, url, category}, Me.GetAverageRatingOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetAverageRatingOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetAverageRatingCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetAverageRatingCompleted(Me, New GetAverageRatingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function GetMyRating(ByVal key As String, ByVal url As String, ByVal category As String) As <System.Xml.Serialization.SoapElementAttribute("GetMyRatingReturn")> String
            Dim results() As Object = Me.Invoke("GetMyRating", New Object() {key, url, category})
            Return CType(results(0),String)
        End Function
        
        '''<remarks/>
        Public Overloads Sub GetMyRatingAsync(ByVal key As String, ByVal url As String, ByVal category As String)
            Me.GetMyRatingAsync(key, url, category, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub GetMyRatingAsync(ByVal key As String, ByVal url As String, ByVal category As String, ByVal userState As Object)
            If (Me.GetMyRatingOperationCompleted Is Nothing) Then
                Me.GetMyRatingOperationCompleted = AddressOf Me.OnGetMyRatingOperationCompleted
            End If
            Me.InvokeAsync("GetMyRating", New Object() {key, url, category}, Me.GetMyRatingOperationCompleted, userState)
        End Sub
        
        Private Sub OnGetMyRatingOperationCompleted(ByVal arg As Object)
            If (Not (Me.GetMyRatingCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent GetMyRatingCompleted(Me, New GetMyRatingCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function RatingExists(ByVal key As String, ByVal url As String, ByVal category As String) As <System.Xml.Serialization.SoapElementAttribute("RatingExistsReturn")> Boolean
            Dim results() As Object = Me.Invoke("RatingExists", New Object() {key, url, category})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub RatingExistsAsync(ByVal key As String, ByVal url As String, ByVal category As String)
            Me.RatingExistsAsync(key, url, category, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub RatingExistsAsync(ByVal key As String, ByVal url As String, ByVal category As String, ByVal userState As Object)
            If (Me.RatingExistsOperationCompleted Is Nothing) Then
                Me.RatingExistsOperationCompleted = AddressOf Me.OnRatingExistsOperationCompleted
            End If
            Me.InvokeAsync("RatingExists", New Object() {key, url, category}, Me.RatingExistsOperationCompleted, userState)
        End Sub
        
        Private Sub OnRatingExistsOperationCompleted(ByVal arg As Object)
            If (Not (Me.RatingExistsCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent RatingExistsCompleted(Me, New RatingExistsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace:="http://DefaultNamespace", ResponseNamespace:="http://DefaultNamespace")>  _
        Public Function IsEnhanced(ByVal url As String) As <System.Xml.Serialization.SoapElementAttribute("IsEnhancedReturn")> Boolean
            Dim results() As Object = Me.Invoke("IsEnhanced", New Object() {url})
            Return CType(results(0),Boolean)
        End Function
        
        '''<remarks/>
        Public Overloads Sub IsEnhancedAsync(ByVal url As String)
            Me.IsEnhancedAsync(url, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub IsEnhancedAsync(ByVal url As String, ByVal userState As Object)
            If (Me.IsEnhancedOperationCompleted Is Nothing) Then
                Me.IsEnhancedOperationCompleted = AddressOf Me.OnIsEnhancedOperationCompleted
            End If
            Me.InvokeAsync("IsEnhanced", New Object() {url}, Me.IsEnhancedOperationCompleted, userState)
        End Sub
        
        Private Sub OnIsEnhancedOperationCompleted(ByVal arg As Object)
            If (Not (Me.IsEnhancedCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent IsEnhancedCompleted(Me, New IsEnhancedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub CollectCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub RateCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub ShareCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420")>  _
    Public Delegate Sub GetAverageRatingCompletedEventHandler(ByVal sender As Object, ByVal e As GetAverageRatingCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetAverageRatingCompletedEventArgs
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
    Public Delegate Sub GetMyRatingCompletedEventHandler(ByVal sender As Object, ByVal e As GetMyRatingCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class GetMyRatingCompletedEventArgs
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
    Public Delegate Sub RatingExistsCompletedEventHandler(ByVal sender As Object, ByVal e As RatingExistsCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class RatingExistsCompletedEventArgs
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
    Public Delegate Sub IsEnhancedCompletedEventHandler(ByVal sender As Object, ByVal e As IsEnhancedCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "2.0.50727.5420"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class IsEnhancedCompletedEventArgs
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
End Namespace
