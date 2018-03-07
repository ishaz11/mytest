Imports System.ComponentModel.DataAnnotations

Public Class User
    <Key>
    Property UserID As Integer
    Property Username As String
    Property Password As String
    Property Fname As String
    Property Lname As String
    Property Status As Boolean
End Class
