<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmTelaPrincipal05
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.BtnWhile = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblPrincipal = New System.Windows.Forms.Label()
        Me.LblRendimento = New System.Windows.Forms.Label()
        Me.TxtPrincipal = New System.Windows.Forms.TextBox()
        Me.TxtRendimento = New System.Windows.Forms.TextBox()
        Me.LblPeridos = New System.Windows.Forms.Label()
        Me.TxtPeriodos = New System.Windows.Forms.TextBox()
        Me.TxtExtratoWhile = New System.Windows.Forms.TextBox()
        Me.BtnFor = New System.Windows.Forms.Button()
        Me.TxtExtratoFor = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnWhile
        '
        Me.BtnWhile.Location = New System.Drawing.Point(27, 174)
        Me.BtnWhile.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnWhile.Name = "BtnWhile"
        Me.BtnWhile.Size = New System.Drawing.Size(141, 33)
        Me.BtnWhile.TabIndex = 0
        Me.BtnWhile.Text = "Calcular Valor com WHILE"
        Me.BtnWhile.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "5 - Loops"
        '
        'LblPrincipal
        '
        Me.LblPrincipal.AutoSize = True
        Me.LblPrincipal.Location = New System.Drawing.Point(24, 93)
        Me.LblPrincipal.Name = "LblPrincipal"
        Me.LblPrincipal.Size = New System.Drawing.Size(77, 13)
        Me.LblPrincipal.TabIndex = 2
        Me.LblPrincipal.Text = "Valor Investido"
        '
        'LblRendimento
        '
        Me.LblRendimento.AutoSize = True
        Me.LblRendimento.Location = New System.Drawing.Point(172, 93)
        Me.LblRendimento.Name = "LblRendimento"
        Me.LblRendimento.Size = New System.Drawing.Size(49, 13)
        Me.LblRendimento.TabIndex = 2
        Me.LblRendimento.Text = "Juros (%)"
        '
        'TxtPrincipal
        '
        Me.TxtPrincipal.Location = New System.Drawing.Point(24, 129)
        Me.TxtPrincipal.Name = "TxtPrincipal"
        Me.TxtPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrincipal.TabIndex = 3
        '
        'TxtRendimento
        '
        Me.TxtRendimento.Location = New System.Drawing.Point(175, 129)
        Me.TxtRendimento.Name = "TxtRendimento"
        Me.TxtRendimento.Size = New System.Drawing.Size(100, 20)
        Me.TxtRendimento.TabIndex = 3
        '
        'LblPeridos
        '
        Me.LblPeridos.AutoSize = True
        Me.LblPeridos.Location = New System.Drawing.Point(305, 93)
        Me.LblPeridos.Name = "LblPeridos"
        Me.LblPeridos.Size = New System.Drawing.Size(50, 13)
        Me.LblPeridos.TabIndex = 2
        Me.LblPeridos.Text = "Períodos"
        '
        'TxtPeriodos
        '
        Me.TxtPeriodos.Location = New System.Drawing.Point(308, 129)
        Me.TxtPeriodos.Name = "TxtPeriodos"
        Me.TxtPeriodos.Size = New System.Drawing.Size(100, 20)
        Me.TxtPeriodos.TabIndex = 3
        '
        'TxtExtratoWhile
        '
        Me.TxtExtratoWhile.Location = New System.Drawing.Point(24, 231)
        Me.TxtExtratoWhile.Multiline = True
        Me.TxtExtratoWhile.Name = "TxtExtratoWhile"
        Me.TxtExtratoWhile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtExtratoWhile.Size = New System.Drawing.Size(412, 162)
        Me.TxtExtratoWhile.TabIndex = 3
        '
        'BtnFor
        '
        Me.BtnFor.Location = New System.Drawing.Point(456, 174)
        Me.BtnFor.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnFor.Name = "BtnFor"
        Me.BtnFor.Size = New System.Drawing.Size(126, 33)
        Me.BtnFor.TabIndex = 0
        Me.BtnFor.Text = "Calcular Valor co FOR"
        Me.BtnFor.UseVisualStyleBackColor = True
        '
        'TxtExtratoFor
        '
        Me.TxtExtratoFor.Location = New System.Drawing.Point(456, 231)
        Me.TxtExtratoFor.Multiline = True
        Me.TxtExtratoFor.Name = "TxtExtratoFor"
        Me.TxtExtratoFor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtExtratoFor.Size = New System.Drawing.Size(412, 162)
        Me.TxtExtratoFor.TabIndex = 3
        '
        'FrmTelaPrincipal05
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(882, 424)
        Me.Controls.Add(Me.TxtPeriodos)
        Me.Controls.Add(Me.TxtRendimento)
        Me.Controls.Add(Me.TxtExtratoFor)
        Me.Controls.Add(Me.TxtExtratoWhile)
        Me.Controls.Add(Me.TxtPrincipal)
        Me.Controls.Add(Me.LblPeridos)
        Me.Controls.Add(Me.LblRendimento)
        Me.Controls.Add(Me.LblPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnFor)
        Me.Controls.Add(Me.BtnWhile)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmTelaPrincipal05"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Alô Mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnWhile As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblPrincipal As Label
    Friend WithEvents LblRendimento As Label
    Friend WithEvents TxtPrincipal As TextBox
    Friend WithEvents TxtRendimento As TextBox
    Friend WithEvents LblPeridos As Label
    Friend WithEvents TxtPeriodos As TextBox
    Friend WithEvents TxtExtratoWhile As TextBox
    Friend WithEvents BtnFor As Button
    Friend WithEvents TxtExtratoFor As TextBox
End Class
