Public Class FrmTelaPrincipal05
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        Dim investimento As Double = Val(TxtPrincipal.Text)
        Dim rendimento As Double = Val(TxtRendimento.Text)

        investimento = (investimento + (investimento * (rendimento / 100)))
        MsgBox("O valor do investimento é : " & investimento)
    End Sub
End Class