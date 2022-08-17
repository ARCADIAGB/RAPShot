<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWeightConfig
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdNominal = New System.Windows.Forms.Button
        Me.cmdUserWeight = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(233, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(252, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pellet Weight Handling"
        '
        'cmdNominal
        '
        Me.cmdNominal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdNominal.Location = New System.Drawing.Point(455, 108)
        Me.cmdNominal.Name = "cmdNominal"
        Me.cmdNominal.Size = New System.Drawing.Size(174, 81)
        Me.cmdNominal.TabIndex = 1
        Me.cmdNominal.Text = "Select this"
        Me.cmdNominal.UseVisualStyleBackColor = True
        '
        'cmdUserWeight
        '
        Me.cmdUserWeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdUserWeight.Location = New System.Drawing.Point(455, 257)
        Me.cmdUserWeight.Name = "cmdUserWeight"
        Me.cmdUserWeight.Size = New System.Drawing.Size(174, 81)
        Me.cmdUserWeight.TabIndex = 2
        Me.cmdUserWeight.Text = "Select this"
        Me.cmdUserWeight.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(26, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(371, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Use nonimal pellet weight encoded by chronoscope"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(64, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(321, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Request weight measurement for every shot" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-2, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(695, 45)
        Me.Panel1.TabIndex = 5
        '
        'frmWeightConfig
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 386)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmdUserWeight)
        Me.Controls.Add(Me.cmdNominal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "frmWeightConfig"
        Me.Text = "Select weight handling option"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdNominal As System.Windows.Forms.Button
    Friend WithEvents cmdUserWeight As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
