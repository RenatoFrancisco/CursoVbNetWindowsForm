Public Class FrmTelaPrincipal03

    Dim ListaCurso As String

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

    Private Sub BtnAdicionar_Click(sender As Object, e As EventArgs) Handles BtnAdicionar.Click
        Dim cursoDigitado As String = TxtCurso.Text

        ListaCurso = ListaCurso + cursoDigitado + vbCrLf
        TxtLista.Text = ListaCurso
        TxtCurso.Text = String.Empty

    End Sub

    Private Sub BtnExibirLista_Click(sender As Object, e As EventArgs) Handles BtnExibirLista.Click
        MsgBox(ListaCurso)
    End Sub
End Class