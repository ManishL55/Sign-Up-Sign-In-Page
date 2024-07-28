<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SIgnUp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SIgnUp))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PromptL = New System.Windows.Forms.Label()
        Me.SignInLL = New System.Windows.Forms.LinkLabel()
        Me.FnameTxt = New System.Windows.Forms.TextBox()
        Me.UnameTxt = New System.Windows.Forms.TextBox()
        Me.PassTxt = New System.Windows.Forms.TextBox()
        Me.SignUpBtn = New System.Windows.Forms.Button()
        Me.ShowPassCB = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 25.81132!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(504, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(153, 41)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SIGN UP"
        '
        'PromptL
        '
        Me.PromptL.AutoSize = True
        Me.PromptL.BackColor = System.Drawing.Color.Transparent
        Me.PromptL.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PromptL.Location = New System.Drawing.Point(518, 549)
        Me.PromptL.Name = "PromptL"
        Me.PromptL.Size = New System.Drawing.Size(167, 17)
        Me.PromptL.TabIndex = 5
        Me.PromptL.Text = "Already have an account?"
        '
        'SignInLL
        '
        Me.SignInLL.AutoSize = True
        Me.SignInLL.Font = New System.Drawing.Font("Century Gothic", 10.18868!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignInLL.Location = New System.Drawing.Point(691, 547)
        Me.SignInLL.Name = "SignInLL"
        Me.SignInLL.Size = New System.Drawing.Size(53, 19)
        Me.SignInLL.TabIndex = 6
        Me.SignInLL.TabStop = True
        Me.SignInLL.Text = "Sign In"
        '
        'FnameTxt
        '
        Me.FnameTxt.BackColor = System.Drawing.SystemColors.Window
        Me.FnameTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FnameTxt.Location = New System.Drawing.Point(511, 185)
        Me.FnameTxt.Name = "FnameTxt"
        Me.FnameTxt.Size = New System.Drawing.Size(247, 26)
        Me.FnameTxt.TabIndex = 8
        '
        'UnameTxt
        '
        Me.UnameTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UnameTxt.Location = New System.Drawing.Point(511, 288)
        Me.UnameTxt.Name = "UnameTxt"
        Me.UnameTxt.Size = New System.Drawing.Size(247, 26)
        Me.UnameTxt.TabIndex = 9
        '
        'PassTxt
        '
        Me.PassTxt.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PassTxt.Location = New System.Drawing.Point(511, 386)
        Me.PassTxt.MaximumSize = New System.Drawing.Size(500, 500)
        Me.PassTxt.MinimumSize = New System.Drawing.Size(20, 20)
        Me.PassTxt.Name = "PassTxt"
        Me.PassTxt.Size = New System.Drawing.Size(247, 26)
        Me.PassTxt.TabIndex = 10
        '
        'SignUpBtn
        '
        Me.SignUpBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.SignUpBtn.Font = New System.Drawing.Font("Century Gothic", 14.26415!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SignUpBtn.ForeColor = System.Drawing.Color.Transparent
        Me.SignUpBtn.Location = New System.Drawing.Point(511, 496)
        Me.SignUpBtn.Name = "SignUpBtn"
        Me.SignUpBtn.Size = New System.Drawing.Size(247, 48)
        Me.SignUpBtn.TabIndex = 11
        Me.SignUpBtn.Text = "Sign Up"
        Me.SignUpBtn.UseVisualStyleBackColor = False
        '
        'ShowPassCB
        '
        Me.ShowPassCB.AutoSize = True
        Me.ShowPassCB.Font = New System.Drawing.Font("Century Gothic", 8.830189!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPassCB.Location = New System.Drawing.Point(511, 423)
        Me.ShowPassCB.Name = "ShowPassCB"
        Me.ShowPassCB.Size = New System.Drawing.Size(117, 21)
        Me.ShowPassCB.TabIndex = 12
        Me.ShowPassCB.Text = "Show Password"
        Me.ShowPassCB.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Image = CType(resources.GetObject("Label7.Image"), System.Drawing.Image)
        Me.Label7.Location = New System.Drawing.Point(518, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Padding = New System.Windows.Forms.Padding(18, 5, 18, 5)
        Me.Label7.Size = New System.Drawing.Size(36, 23)
        Me.Label7.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Image = CType(resources.GetObject("Label8.Image"), System.Drawing.Image)
        Me.Label8.Location = New System.Drawing.Point(518, 242)
        Me.Label8.Name = "Label8"
        Me.Label8.Padding = New System.Windows.Forms.Padding(18, 10, 18, 10)
        Me.Label8.Size = New System.Drawing.Size(36, 33)
        Me.Label8.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Image = CType(resources.GetObject("Label9.Image"), System.Drawing.Image)
        Me.Label9.Location = New System.Drawing.Point(518, 340)
        Me.Label9.Name = "Label9"
        Me.Label9.Padding = New System.Windows.Forms.Padding(15, 10, 15, 10)
        Me.Label9.Size = New System.Drawing.Size(30, 33)
        Me.Label9.TabIndex = 15
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-97, -8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(602, 623)
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(658, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(170, 221)
        Me.PictureBox2.TabIndex = 17
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.18868!)
        Me.Label1.Location = New System.Drawing.Point(560, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Full Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 10.18868!)
        Me.Label3.Location = New System.Drawing.Point(560, 256)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 19)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 10.18868!)
        Me.Label4.Location = New System.Drawing.Point(556, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Password"
        '
        'SIgnUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientSize = New System.Drawing.Size(822, 627)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.ShowPassCB)
        Me.Controls.Add(Me.SignUpBtn)
        Me.Controls.Add(Me.PassTxt)
        Me.Controls.Add(Me.UnameTxt)
        Me.Controls.Add(Me.FnameTxt)
        Me.Controls.Add(Me.SignInLL)
        Me.Controls.Add(Me.PromptL)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SIgnUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGN UP"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PromptL As Label
    Friend WithEvents SignInLL As LinkLabel
    Friend WithEvents FnameTxt As TextBox
    Friend WithEvents UnameTxt As TextBox
    Friend WithEvents PassTxt As TextBox
    Friend WithEvents SignUpBtn As Button
    Friend WithEvents ShowPassCB As CheckBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
