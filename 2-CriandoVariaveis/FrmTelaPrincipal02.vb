Public Class FrmTelaPrincipal02
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnNumerosInteiros.Click
        Dim idade As Integer
        idade = 12
        MsgBox("O valor da idade é: " & idade.ToString, MsgBoxStyle.Critical)

        idade = 12 * 5
        MsgBox("O valor da idade multiplicado por 5 é: " & idade, MsgBoxStyle.Critical)


        idade = 12 * 5 + 10
        MsgBox("O valor da idade multiplicado por 5 e somado com 10 é: " & idade, MsgBoxStyle.Critical)
    End Sub

    Private Sub BtnPontoFlutuante_Click(sender As Object, e As EventArgs) Handles BtnPontoFlutuante.Click
        Dim valor As Double
        valor = 9.7
        MsgBox("A variável valor é igual a: " & valor, MsgBoxStyle.Critical)

        valor = 5 / 2
        MsgBox("O valor de 5 / 2 é: " & valor, MsgBoxStyle.Critical)

        Dim numerador As Integer = 5
        Dim denominador As Integer = 2

        valor = numerador / denominador
        MsgBox("O valor de 5 / 2 é: " & valor, MsgBoxStyle.Critical)

    End Sub
End Class