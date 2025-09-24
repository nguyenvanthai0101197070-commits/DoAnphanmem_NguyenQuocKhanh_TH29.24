Public Class Form2
    Private Sua As String
    Private records As New List(Of String)
    Private index As Integer = 0
    Private Sub UpdateLable()
        Dim Tong_Luong As Double = 0
        If index >= ListView1.Items.Count Then
            index = ListView1.Items.Count - 1
        End If
        If ListView1.Items.Count > 0 And index >= 0 Then
            Lbdem.Text = $"{index + 1}/{ListView1.Items.Count}"
        Else
            Lbdem.Text = "0/0"
        End If

    End Sub

    Private Sub Btthoat_Click(sender As Object, e As EventArgs) Handles Btthoat.Click
        Dim Thoat As String
        Thoat = MsgBox("Bạn có muốn thoát không ?", vbYesNo)
        If Thoat = vbYes Then
            Close()
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateLable()
        ListView1.View = View.Details
        ListView1.Columns.Add("Ho va ten", 80, HorizontalAlignment.Center)
        ListView1.Columns.Add("Mon chinh", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("So luong", 50, HorizontalAlignment.Center)
        ListView1.Columns.Add("Mon phu", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("So luong", 100, HorizontalAlignment.Center)
        ListView1.Columns.Add("Thanh tien", 80, HorizontalAlignment.Center)

    End Sub

    Private Sub Btxacnhan_Click(sender As Object, e As EventArgs) Handles Btxacnhan.Click
        Dim Hovaten As String = Txtten.Text.Trim()
        Dim Monchinh As String = Cbdoan.Text.Trim()
        Dim Soluong1 As String = Txtsoluongmonchinh.Text.Trim()
        Dim Monphu As String = Cbdoankem.Text.Trim()
        Dim Soluong2 As String = Txtsoluongmonphu.Text.Trim()
        Dim ThanhTien As String = TxtThantien.Text.Trim()
        If Hovaten = "" Then
            MessageBox.Show("Tên không được để trống", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim item As New ListViewItem(Hovaten)
        item.SubItems.Add(Monchinh)
        item.SubItems.Add(Soluong1)
        item.SubItems.Add(Monphu)
        item.SubItems.Add(Soluong2)
        item.SubItems.Add(ThanhTien)
        ListView1.Items.Add(item)
        MessageBox.Show("Đã xác nhận thành công", "Thông báo!!!", MessageBoxButtons.OK, MessageBoxIcon.Information)
        records.Add("Bản ghi" & (records.Count + 1))
        index = records.Count - 1
        UpdateLable()
        Txtten.Clear()
        Cbdoan.Text = ""
        Txtsoluongmonchinh.Clear()
        Cbdoankem.Text = ""
        Txtsoluongmonphu.Clear()
        TxtThantien.Clear()

    End Sub


    Private Sub Cbdoan_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbdoan.SelectedIndexChanged
        Dim Monanchinh As String
        Monanchinh = Cbdoan.Text
        Select Case Monanchinh
            Case "Cơm tấm"
                Cbdoan.Tag = 20000
            Case "Xôi mặn"
                Cbdoan.Tag = 15000
            Case "Cơm chiên dương châu"
                Cbdoan.Tag = 20000
            Case "Phở xào"
                Cbdoan.Tag = 20000
        End Select
        TinhThanhTien()

    End Sub

    Private Sub Cbdoankem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Cbdoankem.SelectedIndexChanged
        Dim Monanphu As String
        Monanphu = Cbdoankem.Text
        Select Case Monanphu

            Case "Rau muống"
                Cbdoankem.Tag = 5000
            Case "Trứng tráng"
                Cbdoankem.Tag = 5000
            Case "Thịt ba rọi nướng"
                Cbdoankem.Tag = 10000
            Case "Thịt sườn nướng"
                Cbdoankem.Tag = 10000
        End Select
        TinhThanhTien()
    End Sub

    Private Sub Btthaydoi_Click(sender As Object, e As EventArgs) Handles Btthaydoi.Click
        Sua = InputBox("Mời nhập tên cần sửa:", "Thay đổi món")
        If String.IsNullOrWhiteSpace(Sua) Then
            MessageBox.Show("Nhập tên cần sửa!!!!", "lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Dim Ten_Tk As Boolean = False
        For Each item As ListViewItem In ListView1.Items
            If item.Text = Sua Then
                Sua = True
                Cbdoan.Text = item.SubItems(1).Text
                Txtsoluongmonchinh.Text = item.SubItems(2).Text
                Cbdoankem.Text = item.SubItems(3).Text
                Txtsoluongmonphu.Text = item.SubItems(4).Text
                TxtThantien.Text = item.SubItems(5).Text
            End If
        Next
    End Sub

    Private Sub BtXoa_Click(sender As Object, e As EventArgs) Handles BtXoa.Click
        Dim recordten As String
        recordten = InputBox("Nhập tên cần xóa:", "Xóa bản ghi")
        If recordten <> "" Then
            For Each Item As ListViewItem In ListView1.Items
                If Item.Text = recordten Then
                    ListView1.Items.Remove(Item)
                    UpdateLable()
                    MsgBox("Bản ghi" & recordten & "đã được xóa!", vbInformation)
                    Exit Sub
                End If
            Next
            MsgBox("Không tìm thấy tên " & recordten & "!", vbExclamation)
        Else
            MsgBox("Bạn chưa đăng nhập tên.", vbExclamation)
        End If
    End Sub


    Private Sub TinhThanhTien()
        ' Khai báo và khởi tạo biến
        Dim giaMonChinh As Double = 0
        Dim soLuongMonChinh As Double = 0
        Dim giaMonPhu As Double = 0
        Dim soLuongMonPhu As Double = 0

        ' Chuyển đổi giá trị từ ComboBox và TextBox sang kiểu Double
        Double.TryParse(Cbdoan.Tag, giaMonChinh)
        Double.TryParse(Txtsoluongmonchinh.Text, soLuongMonChinh)
        Double.TryParse(Cbdoankem.Tag, giaMonPhu)
        Double.TryParse(Txtsoluongmonphu.Text, soLuongMonPhu)

        ' Tính tổng thành tiền
        Dim tongThanhTien As Double = (giaMonChinh * soLuongMonChinh) + (giaMonPhu * soLuongMonPhu)

        ' Gán kết quả vào TextBox TxtThantien
        TxtThantien.Text = tongThanhTien.ToString()
    End Sub


    ' 3. Txtsoluongmonchinh_TextChanged
    Private Sub Txtsoluongmonchinh_TextChanged(sender As Object, e As EventArgs) Handles Txtsoluongmonchinh.TextChanged
        TinhThanhTien()
    End Sub

    ' 4. Txtsoluongmonphu_TextChanged
    Private Sub Txtsoluongmonphu_TextChanged(sender As Object, e As EventArgs) Handles Txtsoluongmonphu.TextChanged
        TinhThanhTien()
    End Sub

End Class