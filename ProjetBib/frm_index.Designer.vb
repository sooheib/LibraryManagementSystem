<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_index
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_index))
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.btn_dem = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(12, 4)
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(662, 20)
        Me.pb.TabIndex = 4
        Me.pb.Visible = False
        '
        'btn_dem
        '
        Me.btn_dem.BackColor = System.Drawing.Color.Navy
        Me.btn_dem.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_dem.ForeColor = System.Drawing.Color.White
        Me.btn_dem.Location = New System.Drawing.Point(290, 30)
        Me.btn_dem.Name = "btn_dem"
        Me.btn_dem.Size = New System.Drawing.Size(129, 30)
        Me.btn_dem.TabIndex = 3
        Me.btn_dem.Text = "Go!"
        Me.btn_dem.UseVisualStyleBackColor = False
        '
        'frm_index
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(684, 72)
        Me.Controls.Add(Me.pb)
        Me.Controls.Add(Me.btn_dem)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_index"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Démarrage Application"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pb As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_dem As System.Windows.Forms.Button
End Class
