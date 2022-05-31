<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmTelaPrincipal04
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
        Me.TxtIdade = New System.Windows.Forms.TextBox()
        Me.TxtResultado = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpPais = New System.Windows.Forms.GroupBox()
        Me.RdbSim = New System.Windows.Forms.RadioButton()
        Me.RdbNao = New System.Windows.Forms.RadioButton()
        Me.GrpPais.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnPrincipal
        '
        Me.BtnPrincipal.Location = New System.Drawing.Point(24, 96)
        Me.BtnPrincipal.Margin = New System.Windows.Forms.Padding(2)
        Me.BtnPrincipal.Name = "BtnPrincipal"
        Me.BtnPrincipal.Size = New System.Drawing.Size(222, 41)
        Me.BtnPrincipal.TabIndex = 0
        Me.BtnPrincipal.Text = "Checagem da Permissão de Entrada"
        Me.BtnPrincipal.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 31)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "4-Controle de Fluxo"
        '
        'TxtIdade
        '
        Me.TxtIdade.Location = New System.Drawing.Point(24, 61)
        Me.TxtIdade.Name = "TxtIdade"
        Me.TxtIdade.Size = New System.Drawing.Size(130, 20)
        Me.TxtIdade.TabIndex = 2
        '
        'TxtResultado
        '
        Me.TxtResultado.Location = New System.Drawing.Point(24, 182)
        Me.TxtResultado.Name = "TxtResultado"
        Me.TxtResultado.Size = New System.Drawing.Size(564, 20)
        Me.TxtResultado.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 158)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Resultado"
        '
        'GrpPais
        '
        Me.GrpPais.Controls.Add(Me.RdbNao)
        Me.GrpPais.Controls.Add(Me.RdbSim)
        Me.GrpPais.Location = New System.Drawing.Point(180, 5)
        Me.GrpPais.Name = "GrpPais"
        Me.GrpPais.Size = New System.Drawing.Size(200, 76)
        Me.GrpPais.TabIndex = 3
        Me.GrpPais.TabStop = False
        Me.GrpPais.Text = "Acompanhado dos pais?"
        '
        'RdbSim
        '
        Me.RdbSim.AutoSize = True
        Me.RdbSim.Location = New System.Drawing.Point(18, 36)
        Me.RdbSim.Name = "RdbSim"
        Me.RdbSim.Size = New System.Drawing.Size(42, 17)
        Me.RdbSim.TabIndex = 0
        Me.RdbSim.TabStop = True
        Me.RdbSim.Text = "Sim"
        Me.RdbSim.UseVisualStyleBackColor = True
        '
        'RdbNao
        '
        Me.RdbNao.AutoSize = True
        Me.RdbNao.Location = New System.Drawing.Point(91, 36)
        Me.RdbNao.Name = "RdbNao"
        Me.RdbNao.Size = New System.Drawing.Size(45, 17)
        Me.RdbNao.TabIndex = 0
        Me.RdbNao.TabStop = True
        Me.RdbNao.Text = "Não"
        Me.RdbNao.UseVisualStyleBackColor = True
        '
        'FrmTelaPrincipal04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(600, 366)
        Me.Controls.Add(Me.GrpPais)
        Me.Controls.Add(Me.TxtResultado)
        Me.Controls.Add(Me.TxtIdade)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnPrincipal)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FrmTelaPrincipal04"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplicação Alô Mundo"
        Me.GrpPais.ResumeLayout(False)
        Me.GrpPais.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnPrincipal As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdade As TextBox
    Friend WithEvents TxtResultado As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GrpPais As GroupBox
    Friend WithEvents RdbSim As RadioButton
    Friend WithEvents RdbNao As RadioButton
End Class
