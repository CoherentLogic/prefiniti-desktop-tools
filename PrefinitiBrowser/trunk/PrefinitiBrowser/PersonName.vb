'
' $Id$
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
Public Class PersonName
    Private szFirstName As String
    Private szMiddleInitial As String
    Private szLastName As String
    Private szNickname As String

    Public Sub New(ByVal FirstName As String, ByVal MiddleInitial As String, ByVal LastName As String)
        With Me
            .szFirstName = FirstName
            .szMiddleInitial = MiddleInitial
            .szLastName = LastName
        End With
    End Sub

    Public Sub New(ByVal FirstName As String, ByVal LastName As String)
        With Me
            .szFirstName = FirstName
            .szLastName = LastName
        End With
    End Sub

    Public Overrides Function ToString() As String
        If Me.szMiddleInitial.Length > 0 Then
            Return Me.szFirstName + " " + Me.szMiddleInitial + ". " + Me.szLastName
        Else
            Return Me.szFirstName + " " + Me.szLastName
        End If
    End Function

    Public ReadOnly Property FirstName() As String
        Get
            Return Me.szFirstName
        End Get
    End Property

    Public ReadOnly Property LastName() As String
        Get
            Return Me.szLastName
        End Get
    End Property

    Public ReadOnly Property MiddleInitial() As String
        Get
            Return Me.szMiddleInitial
        End Get
    End Property
End Class
