Imports System.Data.SqlClient
Public Class Form3
    Dim KetNoi As SqlConnection
    Private Sub Load_Dulieu()
        Dim Da As New SqlDataAdapter("SELECT*FORM DNHAP", KetNoi)
    End Sub

    Private Sub Btdangki2_Click(sender As Object, e As EventArgs) Handles Btdangki2.Click
        KetNoi = New SqlConnection("Data Source=USER-PC\SQLEXPRESS;Initial Catalog=Quanr lý bán đồ ăn;Integrated Security=True")
        KetNoi.Open()
        Dim Dangki As New SqlCommand("INSERT INTO DNHAP (TenDangNhap,MatKhau) VALUES (@TenDangNhap,@MatKhau)", KetNoi)
        Dangki.Parameters.AddWithValue("@TenDangNhap", Txttendangki.Text.Trim())
        Dangki.Parameters.AddWithValue("@MatKhau", Txtmatkhaudangki.Text)
        Dangki.ExecuteNonQuery()
        Load_Dulieu()
        Txtmatkhaudangki.Clear()
        Txttendangki.Clear()
        Txttendangki.Focus()
        Try
            If KetNoi.State = ConnectionState.Closed Then
                KetNoi.Open()
            End If
        Catch ex As Exception
            MsgBox("Loi SQL:" & ex.Message, vbYes, "Loi")
        Finally
            KetNoi.Close()
        End Try
        MsgBox("Dang ky thanh cong", vbYes, "Chu y")
        Me.Hide()
        Form1.Show()

    End Sub

End Class