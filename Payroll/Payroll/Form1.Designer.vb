<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.tbxUsername = New System.Windows.Forms.TextBox()
        Me.tbxPassword = New System.Windows.Forms.TextBox()
        Me.tbxFname = New System.Windows.Forms.TextBox()
        Me.tbxLname = New System.Windows.Forms.TextBox()
        Me.dtgUser = New System.Windows.Forms.DataGridView()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.dtgUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(222, 22)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Login"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'tbxUsername
        '
        Me.tbxUsername.Location = New System.Drawing.Point(79, 25)
        Me.tbxUsername.Name = "tbxUsername"
        Me.tbxUsername.Size = New System.Drawing.Size(100, 20)
        Me.tbxUsername.TabIndex = 1
        '
        'tbxPassword
        '
        Me.tbxPassword.Location = New System.Drawing.Point(79, 65)
        Me.tbxPassword.Name = "tbxPassword"
        Me.tbxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbxPassword.Size = New System.Drawing.Size(100, 20)
        Me.tbxPassword.TabIndex = 2
        '
        'tbxFname
        '
        Me.tbxFname.Location = New System.Drawing.Point(79, 110)
        Me.tbxFname.Name = "tbxFname"
        Me.tbxFname.Size = New System.Drawing.Size(100, 20)
        Me.tbxFname.TabIndex = 3
        '
        'tbxLname
        '
        Me.tbxLname.Location = New System.Drawing.Point(79, 156)
        Me.tbxLname.Name = "tbxLname"
        Me.tbxLname.Size = New System.Drawing.Size(100, 20)
        Me.tbxLname.TabIndex = 4
        '
        'dtgUser
        '
        Me.dtgUser.AllowUserToAddRows = False
        Me.dtgUser.AllowUserToDeleteRows = False
        Me.dtgUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUser.Location = New System.Drawing.Point(79, 202)
        Me.dtgUser.Name = "dtgUser"
        Me.dtgUser.ReadOnly = True
        Me.dtgUser.Size = New System.Drawing.Size(343, 150)
        Me.dtgUser.TabIndex = 5
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(222, 65)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(213, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Delete"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(267, 172)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(634, 364)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.dtgUser)
        Me.Controls.Add(Me.tbxLname)
        Me.Controls.Add(Me.tbxFname)
        Me.Controls.Add(Me.tbxPassword)
        Me.Controls.Add(Me.tbxUsername)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.dtgUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents tbxUsername As TextBox
    Friend WithEvents tbxPassword As TextBox
    Friend WithEvents tbxFname As TextBox
    Friend WithEvents tbxLname As TextBox
    Friend WithEvents dtgUser As DataGridView
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
End Class
