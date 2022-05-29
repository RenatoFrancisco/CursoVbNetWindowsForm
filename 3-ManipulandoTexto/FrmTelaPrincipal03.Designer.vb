<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelaPrincipal03
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer


    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.BtnPrincipal = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnChar = New System.Windows.Forms.Button()
        Me.TxtNumeroChar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnAdicionar = New System.Windows.Forms.Button()
        Me.TxtLista = New System.Windows.Forms.TextBox()
        Me.TxtCurso = New System.Windows.Forms.TextBox()
        Me.BtnExibirLista = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BtnPrincipal
        '
        Me.BtnPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrincipal.Location = New System.Drawing.Point(24, 86)
        Me.BtnPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrincipal.Name = "BtnPrincipal"
        Me.BtnPrincipal.Size = New System.Drawing.Size(200, 131)
        Me.BtnPrincipal.TabIndex = 0
        Me.BtnPrincipal.Text = "Clique para ver os resultados"
        Me.BtnPrincipal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "3-Manipulando Textos"
        '
        'BtnChar
        '
        Me.BtnChar.Location = New System.Drawing.Point(326, 173)
        Me.BtnChar.Name = "BtnChar"
        Me.BtnChar.Size = New System.Drawing.Size(100, 33)
        Me.BtnChar.TabIndex = 2
        Me.BtnChar.Text = "Obter o char"
        Me.BtnChar.UseVisualStyleBackColor = True
        '
        'TxtNumeroChar
        '
        Me.TxtNumeroChar.Location = New System.Drawing.Point(326, 138)
        Me.TxtNumeroChar.Name = "TxtNumeroChar"
        Me.TxtNumeroChar.Size = New System.Drawing.Size(100, 20)
        Me.TxtNumeroChar.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Digite seu curso favorito"
        '
        'BtnAdicionar
        '
        Me.BtnAdicionar.Location = New System.Drawing.Point(300, 240)
        Me.BtnAdicionar.Name = "BtnAdicionar"
        Me.BtnAdicionar.Size = New System.Drawing.Size(126, 23)
        Me.BtnAdicionar.TabIndex = 5
        Me.BtnAdicionar.Text = "Adicionar Curso"
        Me.BtnAdicionar.UseVisualStyleBackColor = True
        '
        'TxtLista
        '
        Me.TxtLista.Location = New System.Drawing.Point(24, 269)
        Me.TxtLista.Multiline = True
        Me.TxtLista.Name = "TxtLista"
        Me.TxtLista.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtLista.Size = New System.Drawing.Size(262, 126)
        Me.TxtLista.TabIndex = 6
        '
        'TxtCurso
        '
        Me.TxtCurso.Location = New System.Drawing.Point(148, 243)
        Me.TxtCurso.Name = "TxtCurso"
        Me.TxtCurso.Size = New System.Drawing.Size(138, 20)
        Me.TxtCurso.TabIndex = 7
        '
        'BtnExibirLista
        '
        Me.BtnExibirLista.Location = New System.Drawing.Point(300, 287)
        Me.BtnExibirLista.Name = "BtnExibirLista"
        Me.BtnExibirLista.Size = New System.Drawing.Size(126, 23)
        Me.BtnExibirLista.TabIndex = 8
        Me.BtnExibirLista.Text = "Exibir Lista Atual"
        Me.BtnExibirLista.UseVisualStyleBackColor = True
        '
        'FrmTelaPrincipal03
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 419)
        Me.Controls.Add(Me.BtnExibirLista)
        Me.Controls.Add(Me.TxtCurso)
        Me.Controls.Add(Me.TxtLista)
        Me.Controls.Add(Me.BtnAdicionar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNumeroChar)
        Me.Controls.Add(Me.BtnChar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPrincipal)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmTelaPrincipal03"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "03 - Manipulando Texto"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnChar As Button
    Friend WithEvents TxtNumeroChar As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnAdicionar As Button
    Friend WithEvents TxtLista As TextBox
    Friend WithEvents TxtCurso As TextBox
    Friend WithEvents BtnExibirLista As Button
End Class