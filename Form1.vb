Public Class Form1


    Dim nasigoreng, okana, okanaspesial As Integer '= 10000,20000,500000
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum As Double = 0
        For Each textbox In Panel1.Controls.OfType(Of TextBox)()

            sum += CDbl(textbox.Text)
        Next
        Dim sumx As Double

        For Each minuman In Panel2.Controls.OfType(Of TextBox)()
            sumx += CDbl(minuman.Text)
        Next
        total.Text = sum
        TextBox13.Text = sumx
        TextBox14.Text = ""
        'total.Text = Val(TextBox4.Text) + Val(TextBox5.Text) + Val(TextBox6.Text)
        'If CheckBox1.Checked = True Then
        ' total.Text = Val(total.Text) + Val(TextBox4.Text)
        '  End If
        '  If CheckBox2.Checked = True Then
        '   total.Text = Val(total.Text) + Val(TextBox5.Text) '* 10000
        '  End If
        '  If CheckBox3.Checked = True Then
        '  total.Text = Val(total.Text) + Val(TextBox6.Text) '* 500000
        '  End If
        '   If CheckBox4.Checked = True Then
        '   TextBox13.Text = Val(TextBox13.Text) + Val(TextBox10.Text) '* 500000
        '    End If
        '    If CheckBox5.Checked = True Then
        '    TextBox13.Text = Val(TextBox13.Text) + Val(TextBox11.Text) '* 500000
        '    End If
        '    If CheckBox6.Checked = True Then
        '   TextBox13.Text = Val(TextBox13.Text) + Val(TextBox12.Text) '* 500000
        '    End If
        '   'total.text itu textbox untuk total harga makanan, textbox13.text adalah total harga minuman dan textbox14.text adalah total semua belanjaan kita, makanan dan minuman
        TextBox14.Text = Val(TextBox13.Text) + Val(total.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "" Then
            TextBox1.Text = ""
            TextBox4.Text = 0
        Else

            CheckBox1.Checked = True
            TextBox4.Text = TextBox1.Text * 20000
        End If
    End Sub

    Private Sub TextBox14_TextChanged(sender As Object, e As EventArgs) Handles TextBox14.TextChanged
        TextBox14.Text = Val(total.Text) + Val(TextBox13.Text)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "" Then
            TextBox2.Text = ""
            TextBox5.Text = 0

        Else CheckBox2.Checked = True

            TextBox5.Text = TextBox2.Text * 10000


        End If
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "" Then
            TextBox3.Text = ""
            TextBox6.Text = ""

        Else CheckBox3.Checked = True 
            TextBox6.Text = TextBox3.Text * 500000
        End If
    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "" Then
            TextBox10.Text = ""
            TextBox7.Text = ""
        Else CheckBox4.Checked = True 
            TextBox10.Text = Double.Parse(TextBox7.Text * 123000) '= TextBox10.Text = TextBox7.Text * 125000
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim lol As Double
        lol = TextBox14.Text
        Select Case lol
            Case < 20000
                TextBox15.Text = 0
            Case 20000 To 50000
                TextBox15.Text = (Val(TextBox14.Text) * 0.05)
            Case 50001 To 120000
                TextBox15.Text = (Val(TextBox14.Text) * 0.1)
            Case > 120001
                TextBox15.Text = Val(TextBox14.Text) * 0.2
        End Select
        TextBox16.Text = Val(TextBox14.Text) - Val(TextBox15.Text)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox17.Text > TextBox16.Text Then
            TextBox18.Text = Val(TextBox17.Text) - Val(TextBox16.Text)
        ElseIf TextBox17.Text < TextBox16.Text Then
            MessageBox.Show("uangnya kurang njing")
        ElseIf TextBox17.Text = TextBox16.Text Then
            TextBox18.Text = "tak ada kembalian untuk kau kimak"
        End If
    End Sub

    Private Sub TextBox17_TextChanged(sender As Object, e As EventArgs) Handles TextBox17.TextChanged
        If TextBox17.Text > TextBox16.Text Then
            TextBox18.Text = Val(TextBox17.Text) - Val(TextBox16.Text)
        ElseIf TextBox17.Text < TextBox16.Text Then
            TextBox18.Text = Val(TextBox17.Text) - Val(TextBox16.Text)
        ElseIf TextBox17.Text = TextBox16.Text Then
            TextBox18.Text = 0
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        For Each textbox In GroupBox1.Controls.OfType(Of TextBox)
            textbox.Clear()
        Next
        For Each Textminum In GroupBox2.Controls.OfType(Of TextBox)
            Textminum.Clear()
        Next
        For Each check1 In GroupBox1.Controls.OfType(Of CheckBox)
            check1.Checked = False
        Next
        For Each check2 In GroupBox2.Controls.OfType(Of CheckBox)
            check2.Checked = False
        Next
        For Each box In Panel1.Controls.OfType(Of TextBox)
            box.Clear()
        Next
        For Each boxes In Panel2.Controls.OfType(Of TextBox)
            boxes.Clear()
        Next

    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = "" Then
            TextBox11.Text = 0
        Else
            CheckBox5.Checked = True
            TextBox11.Text = TextBox8.Text * 5000
        End If
    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = "" Then

            TextBox12.Text = 0
        Else
            CheckBox6.Checked = True
            TextBox12.Text = TextBox9.Text * 12000
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class
