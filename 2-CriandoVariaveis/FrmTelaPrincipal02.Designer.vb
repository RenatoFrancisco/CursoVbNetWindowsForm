<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelaPrincipal02
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
        Me.BtnNumerosInteiros = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPontoFlutuante = New System.Windows.Forms.Button()
        Me.BtnConversaoNumeros = New System.Windows.Forms.Button()
        Me.TxtNumerador = New System.Windows.Forms.TextBox()
        Me.TxtDenominador = New System.Windows.Forms.TextBox()
        Me.BtnResultado = New System.Windows.Forms.Button()
        Me.TxtResultadoDecimal = New System.Windows.Forms.TextBox()
        Me.TxtResultadoDouble = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'BtnNumerosInteiros
        '
        Me.BtnNumerosInteiros.Location = New System.Drawing.Point(25, 62)
        Me.BtnNumerosInteiros.Name = "BtnNumerosInteiros"
        Me.BtnNumerosInteiros.Size = New System.Drawing.Size(239, 117)
        Me.BtnNumerosInteiros.TabIndex = 0
        Me.BtnNumerosInteiros.Text = "Exemplos Números Interiros"
        Me.BtnNumerosInteiros.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 18)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "2 - Criando Variáveis"
        '
        'BtnPontoFlutuante
        '
        Me.BtnPontoFlutuante.Location = New System.Drawing.Point(25, 185)
        Me.BtnPontoFlutuante.Name = "BtnPontoFlutuante"
        Me.BtnPontoFlutuante.Size = New System.Drawing.Size(239, 117)
        Me.BtnPontoFlutuante.TabIndex = 0
        Me.BtnPontoFlutuante.Text = "Exemplos Números Flutuantes"
        Me.BtnPontoFlutuante.UseVisualStyleBackColor = True
        '
        'BtnConversaoNumeros
        '
        Me.BtnConversaoNumeros.Location = New System.Drawing.Point(25, 308)
        Me.BtnConversaoNumeros.Name = "BtnConversaoNumeros"
        Me.BtnConversaoNumeros.Size = New System.Drawing.Size(239, 117)
        Me.BtnConversaoNumeros.TabIndex = 0
        Me.BtnConversaoNumeros.Text = "Exemplos Conversão Números "
        Me.BtnConversaoNumeros.UseVisualStyleBackColor = True
        '
        'TxtNumerador
        '
        Me.TxtNumerador.Location = New System.Drawing.Point(387, 62)
        Me.TxtNumerador.Name = "TxtNumerador"
        Me.TxtNumerador.Size = New System.Drawing.Size(212, 22)
        Me.TxtNumerador.TabIndex = 3
        '
        'TxtDenominador
        '
        Me.TxtDenominador.Location = New System.Drawing.Point(387, 92)
        Me.TxtDenominador.Name = "TxtDenominador"
        Me.TxtDenominador.Size = New System.Drawing.Size(212, 22)
        Me.TxtDenominador.TabIndex = 4
        '
        'BtnResultado
        '
        Me.BtnResultado.Location = New System.Drawing.Point(387, 130)
        Me.BtnResultado.Name = "BtnResultado"
        Me.BtnResultado.Size = New System.Drawing.Size(212, 30)
        Me.BtnResultado.TabIndex = 5
        Me.BtnResultado.Text = "Resultado"
        Me.BtnResultado.UseVisualStyleBackColor = True
        '
        'TxtResultadoDecimal
        '
        Me.TxtResultadoDecimal.Location = New System.Drawing.Point(387, 192)
        Me.TxtResultadoDecimal.Name = "TxtResultadoDecimal"
        Me.TxtResultadoDecimal.Size = New System.Drawing.Size(340, 22)
        Me.TxtResultadoDecimal.TabIndex = 3
        '
        'TxtResultadoDouble
        '
        Me.TxtResultadoDouble.Location = New System.Drawing.Point(387, 222)
        Me.TxtResultadoDouble.Name = "TxtResultadoDouble"
        Me.TxtResultadoDouble.Size = New System.Drawing.Size(340, 22)
        Me.TxtResultadoDouble.TabIndex = 3
        '
        'FrmTelaPrincipal02
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.Controls.Add(Me.BtnResultado)
        Me.Controls.Add(Me.TxtDenominador)
        Me.Controls.Add(Me.TxtResultadoDouble)
        Me.Controls.Add(Me.TxtResultadoDecimal)
        Me.Controls.Add(Me.TxtNumerador)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnConversaoNumeros)
        Me.Controls.Add(Me.BtnPontoFlutuante)
        Me.Controls.Add(Me.BtnNumerosInteiros)
        Me.Name = "FrmTelaPrincipal02"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Alô Mundo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnNumerosInteiros As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnPontoFlutuante As Button
    Friend WithEvents BtnConversaoNumeros As Button
    Friend WithEvents TxtNumerador As TextBox
    Friend WithEvents TxtDenominador As TextBox
    Friend WithEvents BtnResultado As Button
    Friend WithEvents TxtResultadoDecimal As TextBox
    Friend WithEvents TxtResultadoDouble As TextBox
End Class
