<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Result
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
        Me.lbl_data_holder = New System.Windows.Forms.Label()
        Me.pic_top = New System.Windows.Forms.PictureBox()
        Me.pic_result = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.lbl_result = New System.Windows.Forms.Label()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.lbl_data = New System.Windows.Forms.Label()
        CType(Me.pic_top, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_result, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_data_holder
        '
        Me.lbl_data_holder.AutoSize = True
        Me.lbl_data_holder.Location = New System.Drawing.Point(84, 274)
        Me.lbl_data_holder.Name = "lbl_data_holder"
        Me.lbl_data_holder.Size = New System.Drawing.Size(78, 69)
        Me.lbl_data_holder.TabIndex = 0
        Me.lbl_data_holder.Text = "Aciertos:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Premio:"
        '
        'pic_top
        '
        Me.pic_top.Image = Global.Quiniela.My.Resources.Resources.top_img
        Me.pic_top.Location = New System.Drawing.Point(27, 12)
        Me.pic_top.Name = "pic_top"
        Me.pic_top.Size = New System.Drawing.Size(197, 188)
        Me.pic_top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_top.TabIndex = 1
        Me.pic_top.TabStop = False
        '
        'pic_result
        '
        Me.pic_result.Location = New System.Drawing.Point(359, 206)
        Me.pic_result.Name = "pic_result"
        Me.pic_result.Size = New System.Drawing.Size(283, 216)
        Me.pic_result.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pic_result.TabIndex = 2
        Me.pic_result.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Quiniela.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(433, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 188)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Quiniela.My.Resources.Resources.side_img
        Me.PictureBox3.Location = New System.Drawing.Point(230, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(197, 188)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'lbl_result
        '
        Me.lbl_result.AutoSize = True
        Me.lbl_result.Font = New System.Drawing.Font("Comic Sans MS", 14.0!)
        Me.lbl_result.Location = New System.Drawing.Point(142, 223)
        Me.lbl_result.Name = "lbl_result"
        Me.lbl_result.Size = New System.Drawing.Size(67, 26)
        Me.lbl_result.TabIndex = 5
        Me.lbl_result.Text = "Label1"
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(147, 377)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(140, 40)
        Me.btn_exit.TabIndex = 6
        Me.btn_exit.Text = "Salir"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'lbl_data
        '
        Me.lbl_data.AutoSize = True
        Me.lbl_data.Location = New System.Drawing.Point(168, 274)
        Me.lbl_data.Name = "lbl_data"
        Me.lbl_data.Size = New System.Drawing.Size(57, 23)
        Me.lbl_data.TabIndex = 7
        Me.lbl_data.Text = "Label1"
        '
        'Result
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 434)
        Me.Controls.Add(Me.lbl_data)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.lbl_result)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.pic_result)
        Me.Controls.Add(Me.pic_top)
        Me.Controls.Add(Me.lbl_data_holder)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 12.0!)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "Result"
        Me.Text = "Resultado"
        CType(Me.pic_top, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_result, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_data_holder As Label
    Friend WithEvents pic_top As PictureBox
    Friend WithEvents pic_result As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents lbl_result As Label
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_data As Label
End Class
