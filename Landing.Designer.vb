<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Landing
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
        Me.btn_continue = New System.Windows.Forms.Button()
        Me.pic_logo = New System.Windows.Forms.PictureBox()
        Me.pic_side = New System.Windows.Forms.PictureBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_welcome = New System.Windows.Forms.Label()
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_side, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_continue
        '
        Me.btn_continue.Location = New System.Drawing.Point(642, 340)
        Me.btn_continue.Name = "btn_continue"
        Me.btn_continue.Size = New System.Drawing.Size(140, 40)
        Me.btn_continue.TabIndex = 0
        Me.btn_continue.Text = "Entrar"
        Me.btn_continue.UseVisualStyleBackColor = True
        '
        'pic_logo
        '
        Me.pic_logo.Image = Global.Quiniela.My.Resources.Resources.logo
        Me.pic_logo.Location = New System.Drawing.Point(29, 27)
        Me.pic_logo.Name = "pic_logo"
        Me.pic_logo.Size = New System.Drawing.Size(397, 403)
        Me.pic_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_logo.TabIndex = 1
        Me.pic_logo.TabStop = False
        '
        'pic_side
        '
        Me.pic_side.Image = Global.Quiniela.My.Resources.Resources.top_img
        Me.pic_side.Location = New System.Drawing.Point(456, 27)
        Me.pic_side.Name = "pic_side"
        Me.pic_side.Size = New System.Drawing.Size(356, 158)
        Me.pic_side.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_side.TabIndex = 2
        Me.pic_side.TabStop = False
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(482, 340)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(140, 40)
        Me.btn_exit.TabIndex = 3
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lbl_welcome
        '
        Me.lbl_welcome.AutoSize = True
        Me.lbl_welcome.Font = New System.Drawing.Font("Comic Sans MS", 16.0!)
        Me.lbl_welcome.Location = New System.Drawing.Point(516, 241)
        Me.lbl_welcome.Name = "lbl_welcome"
        Me.lbl_welcome.Size = New System.Drawing.Size(236, 60)
        Me.lbl_welcome.TabIndex = 4
        Me.lbl_welcome.Text = "Bienvenido al Sistema" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "de Quiniela Gol"
        Me.lbl_welcome.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Landing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 464)
        Me.Controls.Add(Me.lbl_welcome)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.pic_side)
        Me.Controls.Add(Me.pic_logo)
        Me.Controls.Add(Me.btn_continue)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Landing"
        Me.Text = "Bienvenido"
        CType(Me.pic_logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_side, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_continue As Button
    Friend WithEvents pic_logo As PictureBox
    Friend WithEvents pic_side As PictureBox
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_welcome As Label
End Class
