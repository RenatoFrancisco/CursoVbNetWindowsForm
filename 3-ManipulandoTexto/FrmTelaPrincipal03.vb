Public Class FrmTelaPrincipal03
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        Dim primeiraLetra As Char = "a"
        MsgBox("O caracter da variável Primeira Letra é " & primeiraLetra)

        Dim segundaLetra As Char = Chr(65)
        MsgBox("O Caracter número 65 é " & segundaLetra)

        Dim numeroChar As Integer = 65
        Dim TerceiraLetra As Char = Chr(numeroChar)

        numeroChar = numeroChar + 1
        Dim quartaLetra = Chr(numeroChar)
        MsgBox("O caracter número 65 é " & TerceiraLetra & " e o carater número 66 é " & quartaLetra)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnChar.Click
        Dim valorChar As Integer = Val(TxtNumeroChar.Text)
        Dim quintaLetra As Char = Chr(valorChar)

        MsgBox("O caracter para o número é " & valorChar & " é " & quintaLetra)
    End Sub
End Class