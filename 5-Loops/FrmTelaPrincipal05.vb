Public Class FrmTelaPrincipal05
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        Dim investimento As Double = Val(TxtPrincipal.Text)
        Dim rendimento As Double = Val(TxtRendimento.Text)
        Dim periodos As Integer = Val(TxtPeriodos.Text)
        Dim contador As Integer = 1
        Dim extrato As String = String.Empty

        While contador <= periodos
            investimento = (investimento + (investimento * (rendimento / 100)))
            extrato += "O saldo do investimento ao mês " & contador.ToString & " é " + investimento.ToString
            contador += 1
        End While

        TxtExtrato.Text = extrato
        MsgBox("O valor do investimento é : " & investimento)
    End Sub
End Class