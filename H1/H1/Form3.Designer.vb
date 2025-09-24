<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Txtmatkhaudangki = New System.Windows.Forms.TextBox()
        Me.Txttendangki = New System.Windows.Forms.TextBox()
        Me.Btdangki2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Txtmatkhaudangki
        '
        Me.Txtmatkhaudangki.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Txtmatkhaudangki.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txtmatkhaudangki.Location = New System.Drawing.Point(165, 78)
        Me.Txtmatkhaudangki.Name = "Txtmatkhaudangki"
        Me.Txtmatkhaudangki.Size = New System.Drawing.Size(117, 20)
        Me.Txtmatkhaudangki.TabIndex = 6
        Me.Txtmatkhaudangki.Text = " "
        '
        'Txttendangki
        '
        Me.Txttendangki.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Txttendangki.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Txttendangki.Location = New System.Drawing.Point(165, 29)
        Me.Txttendangki.Name = "Txttendangki"
        Me.Txttendangki.Size = New System.Drawing.Size(117, 20)
        Me.Txttendangki.TabIndex = 5
        '
        'Btdangki2
        '
        Me.Btdangki2.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btdangki2.Location = New System.Drawing.Point(78, 130)
        Me.Btdangki2.Name = "Btdangki2"
        Me.Btdangki2.Size = New System.Drawing.Size(204, 30)
        Me.Btdangki2.TabIndex = 4
        Me.Btdangki2.Text = "ĐĂNG KÍ "
        Me.Btdangki2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(84, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Mật khẩu:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cooper Black", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(70, 33)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Tên đăng kí:"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(362, 187)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Txtmatkhaudangki)
        Me.Controls.Add(Me.Txttendangki)
        Me.Controls.Add(Me.Btdangki2)
        Me.Name = "Form3"
        Me.Text = "ĐĂNG KÍ "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txtmatkhaudangki As TextBox
    Friend WithEvents Txttendangki As TextBox
    Friend WithEvents Btdangki2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
