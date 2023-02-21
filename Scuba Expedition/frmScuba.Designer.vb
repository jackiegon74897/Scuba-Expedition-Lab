<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScuba
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
        Me.pnlScuba = New System.Windows.Forms.Panel()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblScubaDive = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnDiveCost = New System.Windows.Forms.Button()
        Me.lstDive = New System.Windows.Forms.ListBox()
        Me.lblSelect = New System.Windows.Forms.Label()
        Me.txtTeam = New System.Windows.Forms.TextBox()
        Me.lblTeam = New System.Windows.Forms.Label()
        Me.cboComboBox = New System.Windows.Forms.ComboBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.pnlScuba.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlScuba
        '
        Me.pnlScuba.BackColor = System.Drawing.Color.Transparent
        Me.pnlScuba.Controls.Add(Me.lblLength)
        Me.pnlScuba.Controls.Add(Me.lblScubaDive)
        Me.pnlScuba.Controls.Add(Me.lblCost)
        Me.pnlScuba.Controls.Add(Me.btnClear)
        Me.pnlScuba.Controls.Add(Me.btnDiveCost)
        Me.pnlScuba.Controls.Add(Me.lstDive)
        Me.pnlScuba.Controls.Add(Me.lblSelect)
        Me.pnlScuba.Controls.Add(Me.txtTeam)
        Me.pnlScuba.Controls.Add(Me.lblTeam)
        Me.pnlScuba.Controls.Add(Me.cboComboBox)
        Me.pnlScuba.Controls.Add(Me.lblTitle)
        Me.pnlScuba.Location = New System.Drawing.Point(435, 1)
        Me.pnlScuba.Name = "pnlScuba"
        Me.pnlScuba.Size = New System.Drawing.Size(414, 438)
        Me.pnlScuba.TabIndex = 0
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.Location = New System.Drawing.Point(107, 392)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(242, 32)
        Me.lblLength.TabIndex = 9
        Me.lblLength.Text = "XXXXXXXXXXXX"
        Me.lblLength.Visible = False
        '
        'lblScubaDive
        '
        Me.lblScubaDive.AutoSize = True
        Me.lblScubaDive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScubaDive.Location = New System.Drawing.Point(107, 312)
        Me.lblScubaDive.Name = "lblScubaDive"
        Me.lblScubaDive.Size = New System.Drawing.Size(242, 32)
        Me.lblScubaDive.TabIndex = 8
        Me.lblScubaDive.Text = "XXXXXXXXXXXX"
        Me.lblScubaDive.Visible = False
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(107, 354)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(242, 32)
        Me.lblCost.TabIndex = 7
        Me.lblCost.Text = "XXXXXXXXXXXX"
        Me.lblCost.Visible = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.ForeColor = System.Drawing.Color.White
        Me.btnClear.Location = New System.Drawing.Point(223, 262)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 34)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        Me.btnClear.Visible = False
        '
        'btnDiveCost
        '
        Me.btnDiveCost.BackColor = System.Drawing.Color.MidnightBlue
        Me.btnDiveCost.ForeColor = System.Drawing.Color.White
        Me.btnDiveCost.Location = New System.Drawing.Point(104, 262)
        Me.btnDiveCost.Name = "btnDiveCost"
        Me.btnDiveCost.Size = New System.Drawing.Size(100, 34)
        Me.btnDiveCost.TabIndex = 5
        Me.btnDiveCost.Text = "Dive Cost"
        Me.btnDiveCost.UseVisualStyleBackColor = False
        Me.btnDiveCost.Visible = False
        '
        'lstDive
        '
        Me.lstDive.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDive.FormattingEnabled = True
        Me.lstDive.ItemHeight = 32
        Me.lstDive.Location = New System.Drawing.Point(123, 188)
        Me.lstDive.Name = "lstDive"
        Me.lstDive.Size = New System.Drawing.Size(200, 68)
        Me.lstDive.TabIndex = 4
        Me.lstDive.Visible = False
        '
        'lblSelect
        '
        Me.lblSelect.AutoSize = True
        Me.lblSelect.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelect.Location = New System.Drawing.Point(98, 141)
        Me.lblSelect.Name = "lblSelect"
        Me.lblSelect.Size = New System.Drawing.Size(246, 32)
        Me.lblSelect.TabIndex = 1
        Me.lblSelect.Text = "Select Scuba Dive"
        Me.lblSelect.Visible = False
        '
        'txtTeam
        '
        Me.txtTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTeam.Location = New System.Drawing.Point(311, 90)
        Me.txtTeam.MaxLength = 2
        Me.txtTeam.Name = "txtTeam"
        Me.txtTeam.Size = New System.Drawing.Size(67, 39)
        Me.txtTeam.TabIndex = 3
        Me.txtTeam.Visible = False
        '
        'lblTeam
        '
        Me.lblTeam.AutoSize = True
        Me.lblTeam.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTeam.Location = New System.Drawing.Point(3, 97)
        Me.lblTeam.Name = "lblTeam"
        Me.lblTeam.Size = New System.Drawing.Size(287, 32)
        Me.lblTeam.TabIndex = 2
        Me.lblTeam.Text = "Number in Dive Team"
        Me.lblTeam.Visible = False
        '
        'cboComboBox
        '
        Me.cboComboBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboComboBox.FormattingEnabled = True
        Me.cboComboBox.Items.AddRange(New Object() {"Australia", "Belize", "Fiji"})
        Me.cboComboBox.Location = New System.Drawing.Point(113, 44)
        Me.cboComboBox.Name = "cboComboBox"
        Me.cboComboBox.Size = New System.Drawing.Size(232, 40)
        Me.cboComboBox.TabIndex = 1
        Me.cboComboBox.Text = "Select Location"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Stencil", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(5, 8)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(406, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Oceanic Scuba Expeditions"
        '
        'frmScuba
        '
        Me.AcceptButton = Me.btnDiveCost
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Scuba_Expedition.My.Resources.Resources.scuba
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(848, 434)
        Me.Controls.Add(Me.pnlScuba)
        Me.Name = "frmScuba"
        Me.Text = "Scuba Expeditions"
        Me.pnlScuba.ResumeLayout(False)
        Me.pnlScuba.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlScuba As Panel
    Friend WithEvents lblTitle As Label
    Friend WithEvents cboComboBox As ComboBox
    Friend WithEvents lstDive As ListBox
    Friend WithEvents lblSelect As Label
    Friend WithEvents txtTeam As TextBox
    Friend WithEvents lblTeam As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents btnDiveCost As Button
    Friend WithEvents lblLength As Label
    Friend WithEvents lblScubaDive As Label
End Class
