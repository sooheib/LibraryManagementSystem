<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class inscription
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(inscription))
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.dt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.insc = New System.Windows.Forms.Button()
        Me.type = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mail = New System.Windows.Forms.TextBox()
        Me.passe = New System.Windows.Forms.TextBox()
        Me.pseudo = New System.Windows.Forms.TextBox()
        Me.identite = New System.Windows.Forms.TextBox()
        Me.nom = New System.Windows.Forms.TextBox()
        Me.civ = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.StatusStrip1.Font = New System.Drawing.Font("High Tower Text", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.dt})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 421)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(2, 0, 28, 0)
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(478, 32)
        Me.StatusStrip1.TabIndex = 1
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
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.insc)
        Me.Panel1.Controls.Add(Me.type)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.mail)
        Me.Panel1.Controls.Add(Me.passe)
        Me.Panel1.Controls.Add(Me.pseudo)
        Me.Panel1.Controls.Add(Me.identite)
        Me.Panel1.Controls.Add(Me.nom)
        Me.Panel1.Controls.Add(Me.civ)
        Me.Panel1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!)
        Me.Panel1.Location = New System.Drawing.Point(12, 104)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(444, 263)
        Me.Panel1.TabIndex = 11
        '
        'insc
        '
        Me.insc.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.insc.FlatAppearance.BorderSize = 0
        Me.insc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.insc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.insc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.insc.Image = Global.ProjetBib.My.Resources.Resources._1390669295_103747
        Me.insc.Location = New System.Drawing.Point(142, 213)
        Me.insc.Name = "insc"
        Me.insc.Size = New System.Drawing.Size(288, 37)
        Me.insc.TabIndex = 11
        Me.insc.UseVisualStyleBackColor = True
        '
        'type
        '
        Me.type.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.type.Location = New System.Drawing.Point(142, 178)
        Me.type.Name = "type"
        Me.type.Size = New System.Drawing.Size(288, 29)
        Me.type.TabIndex = 10
        Me.type.Text = "User"
        Me.type.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 22)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Mail"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 22)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Pseudonyme"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Num.Identité"
        '
        'mail
        '
        Me.mail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mail.Location = New System.Drawing.Point(142, 145)
        Me.mail.Name = "mail"
        Me.mail.Size = New System.Drawing.Size(288, 29)
        Me.mail.TabIndex = 5
        '
        'passe
        '
        Me.passe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.passe.Location = New System.Drawing.Point(142, 112)
        Me.passe.Name = "passe"
        Me.passe.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passe.Size = New System.Drawing.Size(288, 29)
        Me.passe.TabIndex = 4
        Me.passe.UseSystemPasswordChar = True
        '
        'pseudo
        '
        Me.pseudo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pseudo.Location = New System.Drawing.Point(142, 79)
        Me.pseudo.Name = "pseudo"
        Me.pseudo.Size = New System.Drawing.Size(288, 29)
        Me.pseudo.TabIndex = 3
        '
        'identite
        '
        Me.identite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.identite.Location = New System.Drawing.Point(142, 46)
        Me.identite.Name = "identite"
        Me.identite.Size = New System.Drawing.Size(288, 29)
        Me.identite.TabIndex = 2
        '
        'nom
        '
        Me.nom.BackColor = System.Drawing.Color.White
        Me.nom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.nom.Location = New System.Drawing.Point(142, 13)
        Me.nom.Name = "nom"
        Me.nom.Size = New System.Drawing.Size(288, 29)
        Me.nom.TabIndex = 1
        '
        'civ
        '
        Me.civ.BackColor = System.Drawing.Color.Snow
        Me.civ.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.civ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.civ.FormattingEnabled = True
        Me.civ.Items.AddRange(New Object() {"Mr", "Mme", "Mlle"})
        Me.civ.Location = New System.Drawing.Point(15, 14)
        Me.civ.Name = "civ"
        Me.civ.Size = New System.Drawing.Size(121, 30)
        Me.civ.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.ProjetBib.My.Resources.Resources._1390669339_69542
        Me.Button1.Location = New System.Drawing.Point(12, 369)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(444, 49)
        Me.Button1.TabIndex = 13
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.ProjetBib.My.Resources.Resources.logo_biblio_poly_0
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.PictureBox1.Location = New System.Drawing.Point(12, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(444, 87)
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(478, 453)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6, 5, 6, 5)
        Me.Name = "inscription"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ">> Formulaire d'inscription"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents dt As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents type As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mail As System.Windows.Forms.TextBox
    Friend WithEvents passe As System.Windows.Forms.TextBox
    Friend WithEvents nom As System.Windows.Forms.TextBox
    Friend WithEvents civ As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents insc As System.Windows.Forms.Button
    Private WithEvents pseudo As System.Windows.Forms.TextBox
    Private WithEvents identite As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
