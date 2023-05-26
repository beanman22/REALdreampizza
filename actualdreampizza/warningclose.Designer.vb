<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class warningclose
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
        Me.components = New System.ComponentModel.Container()
        Me.LblContinue = New System.Windows.Forms.Button()
        Me.LblWarning = New System.Windows.Forms.Label()
        Me.LblCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.PbWarning = New System.Windows.Forms.PictureBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PbWarning, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblContinue
        '
        Me.LblContinue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblContinue.Location = New System.Drawing.Point(143, 91)
        Me.LblContinue.Name = "LblContinue"
        Me.LblContinue.Size = New System.Drawing.Size(128, 32)
        Me.LblContinue.TabIndex = 1
        Me.LblContinue.Text = "Exit form"
        Me.LblContinue.UseVisualStyleBackColor = True
        '
        'LblWarning
        '
        Me.LblWarning.AutoSize = True
        Me.LblWarning.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWarning.Location = New System.Drawing.Point(105, 28)
        Me.LblWarning.Name = "LblWarning"
        Me.LblWarning.Size = New System.Drawing.Size(64, 16)
        Me.LblWarning.TabIndex = 2
        Me.LblWarning.Text = "Exit form?"
        '
        'LblCancel
        '
        Me.LblCancel.BackColor = System.Drawing.Color.Transparent
        Me.LblCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCancel.ForeColor = System.Drawing.Color.Black
        Me.LblCancel.Location = New System.Drawing.Point(12, 91)
        Me.LblCancel.Name = "LblCancel"
        Me.LblCancel.Size = New System.Drawing.Size(125, 32)
        Me.LblCancel.TabIndex = 3
        Me.LblCancel.Text = "Cancel"
        Me.LblCancel.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(229, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Changes you made will not be saved."
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'PbWarning
        '
        Me.PbWarning.Image = Global.actualdreampizza.My.Resources.Resources.png_clipart_scalable_graphics_computer_icons_warning_sign_warning_icon_cdr_angle
        Me.PbWarning.Location = New System.Drawing.Point(33, 7)
        Me.PbWarning.Name = "PbWarning"
        Me.PbWarning.Size = New System.Drawing.Size(61, 42)
        Me.PbWarning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PbWarning.TabIndex = 5
        Me.PbWarning.TabStop = False
        '
        'warningclose
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(285, 133)
        Me.Controls.Add(Me.PbWarning)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LblCancel)
        Me.Controls.Add(Me.LblWarning)
        Me.Controls.Add(Me.LblContinue)
        Me.Name = "warningclose"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "warningclose"
        Me.TopMost = True
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PbWarning, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblContinue As Button
    Friend WithEvents LblWarning As Label
    Friend WithEvents LblCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents PbWarning As PictureBox
End Class
