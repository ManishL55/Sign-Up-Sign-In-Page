<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SignIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SignIn))
        Me.FPassLL = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ShowPassCB = New System.Windows.Forms.CheckBox()
        Me.PromptL = New System.Windows.Forms.Label()
        Me.SignUpLL = New System.Windows.Forms.LinkLabel()
        Me.SignInBtn = New System.Windows.Forms.Button()
        Me.PassTxt = New System.Windows.Forms.TextBox()
        Me.UnameTxt = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Password = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FPassLL
        '
        Me.FPassLL.AutoSize = True
        Me.FPassLL.BackColor = System.Drawing.Color.Transparent
        Me.FPassLL.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FPassLL.ForeColor = System.Drawing.Color.Blue
        Me.FPassLL.Location = New System.Drawing.Point(550, 451)
        Me.FPassLL.Name = "FPassLL"
        Me.FPassLL.Size = New System.Drawing.Size(112, 17)
        Me.FPassLL.TabIndex = 26
        Me.FPassLL.Text = "Forget Password?"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(489, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(20)
        Me.Label7.Size = New System.Drawing.Size(40, 53)
        Me.Label7.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Image = CType(resources.GetObject("Label6.Image"), System.Drawing.Image)
        Me.Label6.Location = New System.Drawing.Point(490, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Padding = New System.Windows.Forms.Padding(20)
        Me.Label6.Size = New System.Drawing.Size(40, 53)
        Me.Label6.TabIndex = 24
        '
        'ShowPassCB
        '
        Me.ShowPassCB.AutoSize = True
        Me.ShowPassCB.BackColor = System.Drawing.Color.Transparent
        Me.ShowPassCB.Font = New System.Drawing.Font("Century Gothic", 8.150944!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassCB.Location = New System.Drawing.Point(493, 334)
        Me.ShowPassCB.Name = "ShowPassCB"
        Me.ShowPassCB.Size = New System.Drawing.Size(110, 20)
        Me.ShowPassCB.TabIndex = 22
        Me.ShowPassCB.Text = "Show Password"
        Me.ShowPassCB.UseVisualStyleBackColor = False
        '
        'PromptL
        '
        Me.PromptL.AutoSize = True
        Me.PromptL.BackColor = System.Drawing.Color.Transparent
        Me.PromptL.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromptL.Location = New System.Drawing.Point(490, 503)
        Me.PromptL.Name = "PromptL"
        Me.PromptL.Size = New System.Drawing.Size(152, 17)
        Me.PromptL.TabIndex = 21
        Me.PromptL.Text = "Don't have an account?"
        '
        'SignUpLL
        '
        Me.SignUpLL.AutoSize = True
        Me.SignUpLL.BackColor = System.Drawing.Color.Transparent
        Me.SignUpLL.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpLL.Location = New System.Drawing.Point(679, 501)
        Me.SignUpLL.Name = "SignUpLL"
        Me.SignUpLL.Size = New System.Drawing.Size(60, 19)
        Me.SignUpLL.TabIndex = 20
        Me.SignUpLL.TabStop = True
        Me.SignUpLL.Text = "Sign Up"
        '
        'SignInBtn
        '
        Me.SignInBtn.BackColor = System.Drawing.SystemColors.WindowText
        Me.SignInBtn.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInBtn.ForeColor = System.Drawing.Color.Transparent
        Me.SignInBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SignInBtn.Location = New System.Drawing.Point(493, 400)
        Me.SignInBtn.Name = "SignInBtn"
        Me.SignInBtn.Size = New System.Drawing.Size(248, 48)
        Me.SignInBtn.TabIndex = 19
        Me.SignInBtn.Text = "Sign In"
        Me.SignInBtn.UseVisualStyleBackColor = False
        '
        'PassTxt
        '
        Me.PassTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.PassTxt.Location = New System.Drawing.Point(491, 302)
        Me.PassTxt.Name = "PassTxt"
        Me.PassTxt.Size = New System.Drawing.Size(248, 26)
        Me.PassTxt.TabIndex = 18
        '
        'UnameTxt
        '
        Me.UnameTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.UnameTxt.Location = New System.Drawing.Point(492, 204)
        Me.UnameTxt.MaximumSize = New System.Drawing.Size(3000, 3000)
        Me.UnameTxt.MinimumSize = New System.Drawing.Size(20, 20)
        Me.UnameTxt.Name = "UnameTxt"
        Me.UnameTxt.Size = New System.Drawing.Size(247, 26)
        Me.UnameTxt.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 25.81132!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(485, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 41)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "SIGN IN"
        '
        'Password
        '
        Me.Password.AutoSize = True
        Me.Password.BackColor = System.Drawing.Color.Transparent
        Me.Password.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Password.Location = New System.Drawing.Point(536, 265)
        Me.Password.Name = "Password"
        Me.Password.Size = New System.Drawing.Size(72, 19)
        Me.Password.TabIndex = 15
        Me.Password.Text = "Password"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.BackColor = System.Drawing.Color.Transparent
        Me.Email.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(536, 168)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(77, 19)
        Me.Email.TabIndex = 14
        Me.Email.Text = "Username"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(42, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(395, 394)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'SignIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(783, 573)
        Me.Controls.Add(Me.FPassLL)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ShowPassCB)
        Me.Controls.Add(Me.PromptL)
        Me.Controls.Add(Me.SignUpLL)
        Me.Controls.Add(Me.SignInBtn)
        Me.Controls.Add(Me.PassTxt)
        Me.Controls.Add(Me.UnameTxt)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Password)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.PictureBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SignIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGN IN"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FPassLL As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ShowPassCB As CheckBox
    Friend WithEvents PromptL As Label
    Friend WithEvents SignUpLL As LinkLabel
    Friend WithEvents SignInBtn As Button
    Friend WithEvents PassTxt As TextBox
    Friend WithEvents UnameTxt As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Password As Label
    Friend WithEvents Email As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
