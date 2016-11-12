Public Class Tiempo
    Private horas As Integer
    Private minutos As Integer
    Private segundos As Integer

    Sub New(h As Integer, m As Integer, s As Integer)
        horas = h
        minutos = m
        segundos = s
    End Sub
    Sub New()
        horas = 0
        minutos = 0
        segundos = 0
    End Sub

    Public Function Imprimir() As String
        Return horas & ":" & minutos & ":" & segundos
    End Function

    Public Sub Sumar(ho1 As Integer, min1 As Integer, seg1 As Integer, ho2 As Integer, min2 As Integer, seg2 As Integer)
        Dim totalseg1 As Integer
        totalseg1 = ho1 * 3600 + min1 * 60 + seg1
        Dim totalseg2 As Integer
        totalseg2 = ho2 * 3600 + min2 * 60 + seg2
        Dim totalseg As Integer
        totalseg = totalseg1 + totalseg2
        horas = totalseg \ 3600
        totalseg = totalseg Mod 3600
        minutos = totalseg \ 60
        segundos = totalseg Mod 60
    End Sub
End Class
