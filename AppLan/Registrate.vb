'Public Event Resize As EventHandler
Public Class Registrate

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" OrElse TextBox1.Text.ToUpper <> "USUARIO" Then
            TextBox1.BackColor = Color.FromArgb(255, 192, 192)
        End If
        If TextBox2.Text = "" OrElse TextBox2.Text.ToUpper <> "1234" Then
            TextBox2.BackColor = Color.FromArgb(255, 192, 192)
        End If
        TextBox1.Text = ""
        TextBox2.Text = ""

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = True
        Panel2.Visible = False
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim seleccionado As String = ComboBox1.SelectedItem
        If seleccionado.ToUpper = "EMPRESA" Then
            Dim frmEmp As New Empresa
            frmEmp.ShowDialog()
        Else
            Dim frmAlu As New Alumno
            frmAlu.ShowDialog()
        End If
    End Sub

    Private Sub Registrate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Panel2.Location.X & " " & Label1.Location.X & " " & PictureBox1.Location.X
    End Sub
    'Private Sub Registrate_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
    '    TextBox1.Text = Panel2.Location.X & " " & Label1.Location.X & " " & PictureBox1.Location.X

    '    'Dim w As Integer = Registrate.ActiveForm.Width
    '    'Dim myControl As Control
    '    'myControl = sender

    '    '' Ensure the Form remains square (Height = Width).
    '    'If myControl.Size.Height <> myControl.Size.Width Then
    '    '    myControl.Size = New Size(myControl.Size.Width, myControl.Size.Width)
    '    'End If
    'End Sub

End Class
