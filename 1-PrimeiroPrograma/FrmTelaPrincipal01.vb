Public Class FrmTelaPrincipal01
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        MsgBox("Olá Mundo!", MsgBoxStyle.Critical, "Mensagem")
    End Sub
End Class
