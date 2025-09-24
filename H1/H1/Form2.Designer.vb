<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Cbdoan = New System.Windows.Forms.ComboBox()
        Me.Cbdoankem = New System.Windows.Forms.ComboBox()
        Me.Txtsoluongmonchinh = New System.Windows.Forms.TextBox()
        Me.Txtsoluongmonphu = New System.Windows.Forms.TextBox()
        Me.Txtten = New System.Windows.Forms.TextBox()
        Me.Btxacnhan = New System.Windows.Forms.Button()
        Me.Btthaydoi = New System.Windows.Forms.Button()
        Me.Btthoat = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtThantien = New System.Windows.Forms.TextBox()
        Me.BtXoa = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.Lbdem = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Cbdoan
        '
        Me.Cbdoan.FormattingEnabled = True
        Me.Cbdoan.Items.AddRange(New Object() {"Cơm tấm", "Xôi mặn", "Cơm chiên dương châu ", "Phở xào"})
        Me.Cbdoan.Location = New System.Drawing.Point(345, 46)
        Me.Cbdoan.Name = "Cbdoan"
        Me.Cbdoan.Size = New System.Drawing.Size(141, 21)
        Me.Cbdoan.TabIndex = 1
        '
        'Cbdoankem
        '
        Me.Cbdoankem.FormattingEnabled = True
        Me.Cbdoankem.Items.AddRange(New Object() {"Rau muống ", "Trứng tráng", "Thịt ba rọi nướng", "Thịt sườn nướng "})
        Me.Cbdoankem.Location = New System.Drawing.Point(345, 116)
        Me.Cbdoankem.Name = "Cbdoankem"
        Me.Cbdoankem.Size = New System.Drawing.Size(141, 21)
        Me.Cbdoankem.TabIndex = 2
        '
        'Txtsoluongmonchinh
        '
        Me.Txtsoluongmonchinh.Location = New System.Drawing.Point(345, 84)
        Me.Txtsoluongmonchinh.Name = "Txtsoluongmonchinh"
        Me.Txtsoluongmonchinh.Size = New System.Drawing.Size(141, 20)
        Me.Txtsoluongmonchinh.TabIndex = 3
        '
        'Txtsoluongmonphu
        '
        Me.Txtsoluongmonphu.Location = New System.Drawing.Point(345, 149)
        Me.Txtsoluongmonphu.Name = "Txtsoluongmonphu"
        Me.Txtsoluongmonphu.Size = New System.Drawing.Size(141, 20)
        Me.Txtsoluongmonphu.TabIndex = 4
        '
        'Txtten
        '
        Me.Txtten.Location = New System.Drawing.Point(345, 12)
        Me.Txtten.Name = "Txtten"
        Me.Txtten.Size = New System.Drawing.Size(141, 20)
        Me.Txtten.TabIndex = 5
        '
        'Btxacnhan
        '
        Me.Btxacnhan.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btxacnhan.ForeColor = System.Drawing.Color.Lime
        Me.Btxacnhan.Location = New System.Drawing.Point(228, 229)
        Me.Btxacnhan.Name = "Btxacnhan"
        Me.Btxacnhan.Size = New System.Drawing.Size(83, 23)
        Me.Btxacnhan.TabIndex = 6
        Me.Btxacnhan.Text = "XÁC NHẬN"
        Me.Btxacnhan.UseVisualStyleBackColor = True
        '
        'Btthaydoi
        '
        Me.Btthaydoi.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btthaydoi.ForeColor = System.Drawing.Color.Red
        Me.Btthaydoi.Location = New System.Drawing.Point(326, 243)
        Me.Btthaydoi.Name = "Btthaydoi"
        Me.Btthaydoi.Size = New System.Drawing.Size(83, 23)
        Me.Btthaydoi.TabIndex = 7
        Me.Btthaydoi.Text = "THAY ĐỔI "
        Me.Btthaydoi.UseVisualStyleBackColor = True
        '
        'Btthoat
        '
        Me.Btthoat.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btthoat.ForeColor = System.Drawing.Color.Black
        Me.Btthoat.Location = New System.Drawing.Point(429, 229)
        Me.Btthoat.Name = "Btthoat"
        Me.Btthoat.Size = New System.Drawing.Size(83, 23)
        Me.Btthoat.TabIndex = 8
        Me.Btthoat.Text = "THOÁT"
        Me.Btthoat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(247, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Họ và tên:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(242, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Món chính:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(242, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Số lượng:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(242, 153)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Số lượng :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(241, 120)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Món phụ:"
        '
        'TxtThantien
        '
        Me.TxtThantien.Location = New System.Drawing.Point(345, 179)
        Me.TxtThantien.Name = "TxtThantien"
        Me.TxtThantien.Size = New System.Drawing.Size(141, 20)
        Me.TxtThantien.TabIndex = 15
        '
        'BtXoa
        '
        Me.BtXoa.Font = New System.Drawing.Font("Agency FB", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtXoa.ForeColor = System.Drawing.Color.Red
        Me.BtXoa.Location = New System.Drawing.Point(326, 214)
        Me.BtXoa.Name = "BtXoa"
        Me.BtXoa.Size = New System.Drawing.Size(83, 23)
        Me.BtXoa.TabIndex = 17
        Me.BtXoa.Text = "XÓA"
        Me.BtXoa.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(21, 9)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(192, 257)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        '
        'Lbdem
        '
        Me.Lbdem.AutoSize = True
        Me.Lbdem.BackColor = System.Drawing.Color.Transparent
        Me.Lbdem.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbdem.ForeColor = System.Drawing.Color.Lime
        Me.Lbdem.Location = New System.Drawing.Point(104, 271)
        Me.Lbdem.Name = "Lbdem"
        Me.Lbdem.Size = New System.Drawing.Size(25, 17)
        Me.Lbdem.TabIndex = 19
        Me.Lbdem.Text = "0/0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(242, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Thành tiền:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(524, 297)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbdem)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtXoa)
        Me.Controls.Add(Me.TxtThantien)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Btthoat)
        Me.Controls.Add(Me.Btthaydoi)
        Me.Controls.Add(Me.Btxacnhan)
        Me.Controls.Add(Me.Txtten)
        Me.Controls.Add(Me.Txtsoluongmonphu)
        Me.Controls.Add(Me.Txtsoluongmonchinh)
        Me.Controls.Add(Me.Cbdoankem)
        Me.Controls.Add(Me.Cbdoan)
        Me.Name = "Form2"
        Me.Text = "CÁC MÓN ĂN "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Cbdoan As ComboBox
    Friend WithEvents Cbdoankem As ComboBox
    Friend WithEvents Txtsoluongmonchinh As TextBox
    Friend WithEvents Txtsoluongmonphu As TextBox
    Friend WithEvents Txtten As TextBox
    Friend WithEvents Btxacnhan As Button
    Friend WithEvents Btthaydoi As Button
    Friend WithEvents Btthoat As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtThantien As TextBox
    Friend WithEvents BtXoa As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents Lbdem As Label
    Friend WithEvents Label1 As Label
End Class
