<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class recieptform
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
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.LblReceipt = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnCancel.Location = New System.Drawing.Point(12, 753)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(145, 44)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel order"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnYes
        '
        Me.BtnYes.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnYes.Location = New System.Drawing.Point(170, 753)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(183, 44)
        Me.BtnYes.TabIndex = 2
        Me.BtnYes.Text = "Confirm order and print reciept"
        Me.BtnYes.UseVisualStyleBackColor = False
        '
        'LblReceipt
        '
        Me.LblReceipt.Location = New System.Drawing.Point(9, 13)
        Me.LblReceipt.Name = "LblReceipt"
        Me.LblReceipt.Size = New System.Drawing.Size(509, 737)
        Me.LblReceipt.TabIndex = 3
        '
        'recieptform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 805)
        Me.Controls.Add(Me.LblReceipt)
        Me.Controls.Add(Me.BtnYes)
        Me.Controls.Add(Me.BtnCancel)
        Me.Name = "recieptform"
        Me.Text = "recieptform"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnYes As Button
    Friend WithEvents LblReceipt As Label
End Class
