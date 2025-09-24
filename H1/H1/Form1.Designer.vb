Imports System.Data.SqlClient
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Btdangki = New System.Windows.Forms.Button()
        Me.Btdangnhap = New System.Windows.Forms.Button()
        Me.Txttendangnhap = New System.Windows.Forms.TextBox()
        Me.Txtmatkhau = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Btdangki
        '
        Me.Btdangki.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btdangki.Location = New System.Drawing.Point(25, 183)
        Me.Btdangki.Name = "Btdangki"
        Me.Btdangki.Size = New System.Drawing.Size(91, 30)
        Me.Btdangki.TabIndex = 0
        Me.Btdangki.Text = "ĐĂNG KÍ "
        Me.Btdangki.UseVisualStyleBackColor = True
        '
        'Btdangnhap
        '
        Me.Btdangnhap.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btdangnhap.Location = New System.Drawing.Point(137, 183)
        Me.Btdangnhap.Name = "Btdangnhap"
        Me.Btdangnhap.Size = New System.Drawing.Size(95, 30)
        Me.Btdangnhap.TabIndex = 1
        Me.Btdangnhap.Text = "ĐĂNG NHẬP"
        Me.Btdangnhap.UseVisualStyleBackColor = True
        '
        'Txttendangnhap
        '
        Me.Txttendangnhap.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Txttendangnhap.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txttendangnhap.Location = New System.Drawing.Point(124, 60)
        Me.Txttendangnhap.Name = "Txttendangnhap"
        Me.Txttendangnhap.Size = New System.Drawing.Size(108, 20)
        Me.Txttendangnhap.TabIndex = 2
        '
        'Txtmatkhau
        '
        Me.Txtmatkhau.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Txtmatkhau.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txtmatkhau.Location = New System.Drawing.Point(124, 109)
        Me.Txtmatkhau.Name = "Txtmatkhau"
        Me.Txtmatkhau.Size = New System.Drawing.Size(108, 20)
        Me.Txtmatkhau.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(50, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Mật khẩu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(22, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Tên đăng nhập:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(256, 239)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtmatkhau)
        Me.Controls.Add(Me.Txttendangnhap)
        Me.Controls.Add(Me.Btdangnhap)
        Me.Controls.Add(Me.Btdangki)
        Me.Name = "Form1"
        Me.Text = "ĐĂNG NHẬP VÀ ĐĂNG KÍ "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btdangki As Button
    Friend WithEvents Btdangnhap As Button
    Friend WithEvents Txttendangnhap As TextBox
    Friend WithEvents Txtmatkhau As TextBox


    Dim KetNoi As SqlConnection
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KetNoi = New SqlConnection("Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Quanr lý bán đồ ăn;Integrated Security=True")
        KetNoi.Open()
    End Sub

    Private Sub Btdangnhap_Click(sender As Object, e As EventArgs) Handles Btdangnhap.Click
        If Txttendangnhap.Text.Trim() = "" Then
            MsgBox(" Tên đăng nập không được để trống !")
            Exit Sub
        End If
        Dim SQL As New SqlDataAdapter("SELECT*FROM DNHAP WHERE TenDangNhap=@TenDangNhap AND MatKhau=@MatKhau", KetNoi)
        SQL.SelectCommand.Parameters.AddWithValue("@TenDangNhap", Txttendangnhap.Text.Trim())
        SQL.SelectCommand.Parameters.AddWithValue("@MatKhau", Txtmatkhau.Text)
        Dim Db As New DataTable
        SQL.Fill(Db)
        If Db.Rows.Count > 0 Then
            MsgBox("Đăng nhập thành công!")
            Form2.Show()
            Me.Hide()
        Else
            MsgBox("Sau tên đăng nhập hoặc mật khẩu")
        End If
    End Sub

    Private Sub Btdangki_Click(sender As Object, e As EventArgs) Handles Btdangki.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
