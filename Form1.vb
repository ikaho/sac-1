Public Class Form1







    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label13.Text = 13



    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If TextBox20.Text = Label8.Text Then
            If TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox1.Text)
            ElseIf TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox12.Text)
            ElseIf TextBox19.Text = (label9.Text) Then
                Label12.Text = (TextBox12.Text)
            End If

        ElseIf TextBox20.Text = Label6.Text Then
            If TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox7.Text)
            ElseIf TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox2.Text)
            ElseIf TextBox19.Text = (Label9.Text) Then
                Label12.Text = (TextBox13.Text)
            End If

        ElseIf TextBox20.Text = Label5.Text Then
            If TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox6.Text)
            ElseIf TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox8.Text)
            ElseIf TextBox19.Text = (Label9.Text) Then
                Label12.Text = (TextBox14.Text)
            End If

        ElseIf TextBox20.Text = Label4.Text Then
            If TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox5.Text)
            ElseIf TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox9.Text)
            ElseIf TextBox19.Text = (Label9.Text) Then
                Label12.Text = (TextBox15.Text)
            End If

        ElseIf TextBox20.Text = Label3.Text Then
            If TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox4.Text)
            ElseIf TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox10.Text)
            ElseIf TextBox19.Text = (Label9.Text) Then
                Label12.Text = (TextBox16.Text)
            End If

        ElseIf TextBox20.Text = Label2.Text Then
            If TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox3.Text)
            ElseIf TextBox19.Text = Label1.Text Then
                Label12.Text = (TextBox11.Text)
            ElseIf TextBox19.Text = (Label9.Text) Then
                Label12.Text = (TextBox17.Text)
            End If

        Else Label12.Text = ("input not recognised")

        End If



    End Sub
End Class
