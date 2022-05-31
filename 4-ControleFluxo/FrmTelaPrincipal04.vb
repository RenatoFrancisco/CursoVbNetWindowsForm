Public Class FrmTelaPrincipal04
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub BtnPrincipal_Click(sender As Object, e As EventArgs) Handles BtnPrincipal.Click
        TxtResultado.Text = String.Empty

        Dim idade As Integer
        idade = TxtIdade.Text

        Dim acompanhadoPais As String
        If RdbSim.Checked Then
            acompanhadoPais = "S"
        Else
            acompanhadoPais = "N"
        End If

        If idade >= 18 Then
            TxtResultado.ForeColor = Color.Green
            TxtResultado.Text = "A pessoa tem mais de 18 anos. Pode entrar."
        Else
            If idade < 16 Then
                TxtResultado.ForeColor = Color.Red
                TxtResultado.Text = "A pessoa tem menos de 16 anos e por isso não pode assistir à peça."
            Else
                If acompanhadoPais.ToUpper = "S" Then
                    TxtResultado.ForeColor = Color.Green
                    TxtResultado.Text = "A pessoa tem entre 16 e 18 e está acompanhada dos pais. Pode entrar."
                Else
                    TxtResultado.ForeColor = Color.Red
                    TxtResultado.Text = "A pessoa tem entre 16 e 18, mas NÃO está acompanhada dos pais. NÃO pode entrar."
                End If
            End If
        End If

    End Sub
End Class