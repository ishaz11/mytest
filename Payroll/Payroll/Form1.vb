Imports ArnexLibrary.DBUtil
Imports ArnexLibrary.TextUtil

Public Class Form1

    Property ID As Integer
    Property Mode As Cmode
    Dim MyContext As New Model1
    Dim _User As User

    Sub LoadUser()
        Dim _Load = MyContext.Users.Select(Function(s) New With {s.UserID, .First_Name = s.Fname, s.Lname, s.Username, s.Password}).ToList
        FillDGV(dtgUser, _Load)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Mode = Cmode._ADD Then
            _User = New User
            With _User
                .Fname = GetText(tbxFname)
                .Lname = GetText(tbxFname)
                .Username = GetText(tbxUsername)
                .Password = GetText(tbxPassword)
            End With
            MyContext.Users.Add(_User)
            MyContext.SaveChanges()
            LoadUser()
        ElseIf Mode = Cmode._EDIT Then
            MyContext.Users.Find(ID)
            With _User
                .Fname = GetText(tbxFname)
                .Lname = GetText(tbxLname)
                .Username = GetText(tbxUsername)
                .Password = GetText(tbxPassword)
            End With
            MyContext.SaveChanges()
            LoadUser()
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadUser()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        ID = GetVal(dtgUser, 0)
        If ID = 0 Then
            MessageBox.Show("No row has been selected.")
        Else
            _User = MyContext.Users.Find(ID)
            With _User
                tbxFname.Text = .Fname
                tbxLname.Text = .Lname
                tbxUsername.Text = .Username
                tbxPassword.Text = .Password
            End With
            Mode = Cmode._EDIT

        End If
    End Sub

    Private Sub dtgUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dtgUser.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
End Class
