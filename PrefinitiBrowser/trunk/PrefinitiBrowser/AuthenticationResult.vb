'
' $Id$
'
' 
' Copyright (C) 2011 John Willis
' 
' This file is part of Prefiniti.

' Prefiniti is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.

' Prefiniti is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License
' along with Prefiniti.  If not, see <http://www.gnu.org/licenses/>.
'
Public Class AuthenticationResult
    Private bSuccess As Boolean
    Private bFatal As Boolean
    Private szMessage As String

    Public ReadOnly Property Fatal() As Boolean
        Get
            Return Me.bFatal
        End Get
    End Property
    Public ReadOnly Property Success() As Boolean
        Get
            Return Me.bSuccess
        End Get
    End Property

    Public ReadOnly Property Message() As String
        Get
            Return Me.szMessage
        End Get
    End Property
    Public Sub New(ByVal Success As Boolean, ByVal Fatal As Boolean, ByVal Message As String)
        With Me
            .bSuccess = Success
            .bFatal = Fatal
            .szMessage = Message
        End With
    End Sub

End Class
