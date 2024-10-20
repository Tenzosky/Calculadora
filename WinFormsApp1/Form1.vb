Public Class Calculadora

    'Variables'
    Private operacion As String = ""
    Private primer_numero As Double = 0
    Private segundo_numero As Double = 0
    Private Sub Calculadora(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Number_Click(sender As Object, e As EventArgs) Handles Numero0.Click, Numero1.Click, Numero2.Click, Numero3.Click, Numero4.Click, Numero5.Click, Numero6.Click, Numero7.Click, Numero8.Click, Numero9.Click
        Dim Numero As Button = CType(sender, Button)
        If operaciones.Text = "0" Then
            operaciones.Text = Numero.Text
        Else
            operaciones.Text &= Numero.Text
        End If
    End Sub

    Private Sub Operacion_Click(sender As Object, e As EventArgs) Handles Division.Click, Multiplicacion.Click, Resta.Click, Suma.Click
        Dim Numnero As Button = CType(sender, Button)
        primer_numero = Double.Parse(operaciones.Text)
        operacion = Numnero.Text
        operaciones.Text = "0"
    End Sub
    Private Sub Botn_Igual(sender As Object, e As EventArgs) Handles Igual.Click
        segundo_numero = Double.Parse(operaciones.Text)
        Select Case operacion
            Case "+"
                operaciones.Text = (primer_numero + segundo_numero).ToString()
            Case "-"
                operaciones.Text = (primer_numero - segundo_numero).ToString()
            Case "X"
                operaciones.Text = (primer_numero * segundo_numero).ToString()
            Case "/"
                If segundo_numero <> 0 Then
                    operaciones.Text = (primer_numero / segundo_numero).ToString()
                Else
                    operaciones.Text = "Error"
                End If
        End Select
    End Sub

    Private Sub Borrar_Click(sender As Object, e As EventArgs) Handles Borrar.Click
        operaciones.Text = "0"
        primer_numero = 0
        segundo_numero = 0
        operacion = ""
    End Sub
End Class
