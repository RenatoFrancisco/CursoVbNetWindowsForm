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

    Private Sub BtnConversaoNumeros_Click(sender As Object, e As EventArgs) Handles BtnConversaoNumeros.Click
        Dim salario As Double
        salario = 1300.45

        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("O valor do salário é: " & salario & " e do salario inteiro é: " & salarioInteiro)

        Dim salarioGrande As Long
        salarioGrande = 1000000000000000000
        MsgBox("O valor do salário longo é: " & salarioGrande)

        Dim salarioPequeno As Short
        salarioPequeno = 10000
        MsgBox("O valor do salário pequeno é: " & salarioPequeno)

        Dim salarioMinusculo As SByte
        salarioMinusculo = 100
        MsgBox("O valor do salário minúsculo é: " & salarioMinusculo)

        Dim valorDouble As Double
        valorDouble = 9.36553255
        MsgBox("O valor da variável double é: " & valorDouble)

        Dim valorDecimal As Decimal
        valorDecimal = 9.36553255
        MsgBox("O valor da variável decimal é: " & valorDecimal)

    End Sub

    Private Sub BtnResultado_Click(sender As Object, e As EventArgs) Handles BtnResultado.Click
        Dim numerador As Double
        Dim denominador As Double
        Dim resultadoDecimal As Decimal
        Dim resultadoDouble As Double

        numerador = TxtNumerador.Text
        denominador = TxtDenominador.Text
        resultadoDecimal = numerador / denominador

        MsgBox("O resultado (Decimal) entre a divisão de " & numerador & " por " &
               denominador & " é: " & resultadoDecimal)


        resultadoDouble = numerador / denominador
        MsgBox("O resultado (Double) entre a divisão de " & numerador & " por " &
               denominador & " é: " & resultadoDouble)

        TxtResultadoDecimal.Text = resultadoDecimal
        TxtResultadoDouble.Text = resultadoDouble

    End Sub
End Class