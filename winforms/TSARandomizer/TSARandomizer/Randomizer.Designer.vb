<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Randomizer
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.arrowPb = New System.Windows.Forms.PictureBox()
        Me.fadeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.arrowPb, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DimGray
        Me.Label1.Location = New System.Drawing.Point(50, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(378, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Click the center to generate a direction."
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'arrowPb
        '
        Me.arrowPb.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.arrowPb.BackColor = System.Drawing.Color.Transparent
        Me.arrowPb.Location = New System.Drawing.Point(137, 53)
        Me.arrowPb.Name = "arrowPb"
        Me.arrowPb.Size = New System.Drawing.Size(96, 96)
        Me.arrowPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.arrowPb.TabIndex = 1
        Me.arrowPb.TabStop = False
        '
        'fadeTimer
        '
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.arrowPb)
        Me.Panel1.Location = New System.Drawing.Point(55, 81)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(373, 201)
        Me.Panel1.TabIndex = 2
        '
        'Randomizer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 311)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Name = "Randomizer"
        Me.ShowIcon = False
        Me.Text = "TSA Randomizer"
        CType(Me.arrowPb, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents arrowPb As System.Windows.Forms.PictureBox
    Friend WithEvents fadeTimer As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
