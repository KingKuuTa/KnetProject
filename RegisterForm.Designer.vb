<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxFirstname = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.ButtonRegister = New System.Windows.Forms.Button()
        Me.LabelGoToSignIn = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxLastname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBoxConfirmPassword = New System.Windows.Forms.TextBox()
        Me.ButtonClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FirstName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(298, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Password"
        '
        'TextBoxFirstname
        '
        Me.TextBoxFirstname.Location = New System.Drawing.Point(62, 68)
        Me.TextBoxFirstname.Name = "TextBoxFirstname"
        Me.TextBoxFirstname.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxFirstname.TabIndex = 2
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(298, 68)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxPassword.TabIndex = 3
        '
        'ButtonRegister
        '
        Me.ButtonRegister.Location = New System.Drawing.Point(298, 295)
        Me.ButtonRegister.Name = "ButtonRegister"
        Me.ButtonRegister.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRegister.TabIndex = 6
        Me.ButtonRegister.Text = "Sign Up"
        Me.ButtonRegister.UseVisualStyleBackColor = True
        '
        'LabelGoToSignIn
        '
        Me.LabelGoToSignIn.AutoSize = True
        Me.LabelGoToSignIn.Location = New System.Drawing.Point(332, 391)
        Me.LabelGoToSignIn.Name = "LabelGoToSignIn"
        Me.LabelGoToSignIn.Size = New System.Drawing.Size(227, 15)
        Me.LabelGoToSignIn.TabIndex = 1
        Me.LabelGoToSignIn.Text = "Click Here if you already have an Account"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(62, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "LastName"
        '
        'TextBoxLastname
        '
        Me.TextBoxLastname.Location = New System.Drawing.Point(62, 139)
        Me.TextBoxLastname.Name = "TextBoxLastname"
        Me.TextBoxLastname.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxLastname.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Username"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(62, 221)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxUsername.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 280)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 15)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Email"
        '
        'TextBoxEmail
        '
        Me.TextBoxEmail.Location = New System.Drawing.Point(62, 310)
        Me.TextBoxEmail.Name = "TextBoxEmail"
        Me.TextBoxEmail.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxEmail.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(298, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(104, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Confirm Password"
        '
        'TextBoxConfirmPassword
        '
        Me.TextBoxConfirmPassword.Location = New System.Drawing.Point(298, 149)
        Me.TextBoxConfirmPassword.Name = "TextBoxConfirmPassword"
        Me.TextBoxConfirmPassword.Size = New System.Drawing.Size(100, 23)
        Me.TextBoxConfirmPassword.TabIndex = 3
        '
        'ButtonClose
        '
        Me.ButtonClose.Location = New System.Drawing.Point(625, 38)
        Me.ButtonClose.Name = "ButtonClose"
        Me.ButtonClose.Size = New System.Drawing.Size(82, 48)
        Me.ButtonClose.TabIndex = 6
        Me.ButtonClose.Text = "Close"
        Me.ButtonClose.UseVisualStyleBackColor = True
        '
        'RegisterForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonClose)
        Me.Controls.Add(Me.ButtonRegister)
        Me.Controls.Add(Me.TextBoxConfirmPassword)
        Me.Controls.Add(Me.TextBoxPassword)
        Me.Controls.Add(Me.TextBoxEmail)
        Me.Controls.Add(Me.TextBoxUsername)
        Me.Controls.Add(Me.TextBoxLastname)
        Me.Controls.Add(Me.TextBoxFirstname)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.LabelGoToSignIn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegisterForm"
        Me.Text = "RegisterForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxFirstname As TextBox
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents ButtonRegister As Button
    Friend WithEvents LabelGoToSignIn As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxLastname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxConfirmPassword As TextBox
    Friend WithEvents ButtonClose As Button
End Class
