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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(recieptform))
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.BtnYes = New System.Windows.Forms.Button()
        Me.LblReceipt = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.SuspendLayout()
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnCancel.Location = New System.Drawing.Point(12, 843)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(105, 44)
        Me.BtnCancel.TabIndex = 1
        Me.BtnCancel.Text = "Cancel order"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'BtnYes
        '
        Me.BtnYes.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.BtnYes.Location = New System.Drawing.Point(123, 843)
        Me.BtnYes.Name = "BtnYes"
        Me.BtnYes.Size = New System.Drawing.Size(111, 44)
        Me.BtnYes.TabIndex = 2
        Me.BtnYes.Text = "Confirm order and print reciept"
        Me.BtnYes.UseVisualStyleBackColor = False
        '
        'LblReceipt
        '
        Me.LblReceipt.Font = New System.Drawing.Font("Lucida Console", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReceipt.Location = New System.Drawing.Point(9, 9)
        Me.LblReceipt.Name = "LblReceipt"
        Me.LblReceipt.Size = New System.Drawing.Size(419, 827)
        Me.LblReceipt.TabIndex = 3
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'recieptform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 892)
        Me.Controls.Add(Me.LblReceipt)
        Me.Controls.Add(Me.BtnYes)
        Me.Controls.Add(Me.BtnCancel)
        Me.Name = "recieptform"
        Me.Text = "recieptform"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BtnCancel As Button
    Friend WithEvents BtnYes As Button
    Friend WithEvents LblReceipt As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PrintDialog1 As PrintDialog
End Class
