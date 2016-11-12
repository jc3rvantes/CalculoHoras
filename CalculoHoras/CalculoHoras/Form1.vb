Public Class Form1
    Public Property MessageBox As Object

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtHora1.Text.Length = 0 Then
            MessageBox.Show("Ingrese hora 1", "Mensaje")
            txtHora1.Focus()
        End If
        If txtMinutos1.Text.Length = 0 Then
            MessageBox.Show("Ingrese minutos 1", "Mensaje")
            txtMinutos1.Focus()
        End If
        If txtSegundos1.Text.Length = 0 Then
            MessageBox.Show("Ingrese segundos 1", "Mensaje")
            txtSegundos1.Focus()
        End If
        If txtHoras2.Text.Length = 0 Then
            MessageBox.Show("Ingrese hora 2", "Mensaje")
            txtHoras2.Focus()
        End If
        If txtMinutos2.Text.Length = 0 Then
            MessageBox.Show("Ingrese minutos 2", "Mensaje")
            txtMinutos2.Focus()
        End If
        If txtSegundos2.Text.Length = 0 Then
            MessageBox.Show("Ingrese segundos 2", "Mensaje")
            txtSegundos2.Focus()
        End If
        Dim hora1, hora2, minutos1, minutos2, segundos1, segundos2 As Integer
        hora1 = txtHora1.Text
        minutos1 = txtMinutos1.Text
        segundos1 = txtSegundos1.Text
        hora2 = txtHoras2.Text
        minutos2 = txtMinutos2.Text
        segundos2 = txtSegundos2.Text
        Dim nuevotiempo As New Tiempo()

        nuevotiempo.Sumar(hora1, minutos1, segundos1, hora2, minutos2, segundos2)
        txtResultado.Text = nuevotiempo.Imprimir

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtHora1.Clear()
        txtMinutos1.Clear()
        txtSegundos1.Clear()
        txtHoras2.Clear()
        txtSegundos2.Clear()
        txtMinutos2.Clear()
        txtResultado.Clear()
        REM txtHora1.Focus()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub
End Class