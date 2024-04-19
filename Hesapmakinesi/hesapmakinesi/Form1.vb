Public Class Form1
    Dim sayi1, sayi2 As Integer

    'Label3.Text = TextBox1.Text + TextBox2.Text yan yana ekler'
    'Eğer aksi bildirilmemişse değişenlerin değeri string dir'
    'Değişkenler sayı ile başlamaz'
    'Değişkenleri main'nin içine yazdık ki diğerlerine bir daha yazmak zorunda kalmayak'

    Private Sub Topla_Click(sender As Object, e As EventArgs) Handles Topla.Click
        Try
            sayi1 = TextBox1.Text
            sayi2 = TextBox2.Text
            Label3.Text = "Toplam sonucu:" & sayi1 + sayi2
        Catch ex As Exception
            MsgBox("Geçerli bir sayı gir") 'try catch ile yaptık giren düzgün sayı girene kadar denesin diyes'
        End Try
    End Sub

    Private Sub carp_Click(sender As Object, e As EventArgs) Handles carp.Click
        Try
            sayi1 = TextBox1.Text
            sayi2 = TextBox2.Text
            Label3.Text = "Çarpım sonucu:" & sayi1 * sayi2
        Catch ex As Exception
            MsgBox("Geçerli bir sayı gir")
        End Try
    End Sub

    Private Sub bol_Click(sender As Object, e As EventArgs) Handles bol.Click
        Try
            sayi1 = TextBox1.Text
            sayi2 = TextBox2.Text
            Label3.Text = "Bölüm sonucu:" & sayi1 / sayi2
        Catch ex As Exception
            MsgBox("Geçerli bir sayı gir")
        End Try
    End Sub

    Private Sub cıkar_Click(sender As Object, e As EventArgs) Handles cıkar.Click
        Try
            sayi1 = TextBox1.Text
            sayi2 = TextBox2.Text
            Label3.Text = "Çıkarma sonucu:" & sayi1 - sayi2
        Catch ex As Exception
            MsgBox("Geçerli bir sayı gir")
        End Try
    End Sub
End Class
