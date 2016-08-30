<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cnx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cnx))
        Me.passe = New System.Windows.Forms.TextBox()
        Me.pseudo = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btcnx = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'passe
        '
        Me.passe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passe.Location = New System.Drawing.Point(171, 88)
        Me.passe.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.passe.Name = "passe"
        Me.passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passe.Size = New System.Drawing.Size(220, 31)
        Me.passe.TabIndex = 13
        Me.passe.UseSystemPasswordChar = True
        '
        'pseudo
        '
        Me.pseudo.BackColor = System.Drawing.Color.White
        Me.pseudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pseudo.Location = New System.Drawing.Point(171, 47)
        Me.pseudo.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.pseudo.Name = "pseudo"
        Me.pseudo.Size = New System.Drawing.Size(220, 31)
        Me.pseudo.TabIndex = 12
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StatusStrip1.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 235)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(4, 0, 56, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(732, 32)
        Me.StatusStrip1.TabIndex = 15
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'dt
        '
        Me.dt.Font = New System.Drawing.Font("Kristen ITC", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dt.Image = Global.ProjetBib.My.Resources.Resources._1382724660_Calender
        Me.dt.Name = "dt"
        Me.dt.Size = New System.Drawing.Size(238, 27)
        Me.dt.Text = "ToolStripStatusLabel1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(130, 23)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Pseudonyme"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Mot de Passe"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pseudo)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btcnx)
        Me.GroupBox1.Controls.Add(Me.passe)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Location = New System.Drawing.Point(120, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(498, 143)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Authentification"
        '
        'btcnx
        '
        Me.btcnx.BackgroundImage = Global.ProjetBib.My.Resources.Resources._1392521813_60081
        Me.btcnx.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btcnx.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btcnx.FlatAppearance.BorderSize = 0
        Me.btcnx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btcnx.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btcnx.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btcnx.Location = New System.Drawing.Point(403, 75)
        Me.btcnx.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.btcnx.Name = "btcnx"
        Me.btcnx.Size = New System.Drawing.Size(74, 27)
        Me.btcnx.TabIndex = 14
        Me.btcnx.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.ProjetBib.My.Resources.Resources._1390669339_69542
        Me.Button1.Location = New System.Drawing.Point(120, 161)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(498, 52)
        Me.Button1.TabIndex = 19
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cnx
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(732, 267)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "cnx"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btcnx As System.Windows.Forms.Button
    Private WithEvents passe As System.Windows.Forms.TextBox
    Friend WithEvents pseudo As System.Windows.Forms.TextBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents dt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
