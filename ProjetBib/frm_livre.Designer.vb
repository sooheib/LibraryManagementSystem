<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_livre
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_livre))
        Me.btn_aff = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.liste1 = New System.Windows.Forms.ListBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txt5 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt = New System.Windows.Forms.Label()
        Me.txt3 = New System.Windows.Forms.TextBox()
        Me.txt4 = New System.Windows.Forms.ComboBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_retour = New System.Windows.Forms.Button()
        Me.btn_mod = New System.Windows.Forms.Button()
        Me.btn_supp = New System.Windows.Forms.Button()
        Me.btn_enreg = New System.Windows.Forms.Button()
        Me.btn_ajout = New System.Windows.Forms.Button()
        Me.grid = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.txt5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_aff
        '
        Me.btn_aff.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_aff.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_aff.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_aff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_aff.Location = New System.Drawing.Point(396, 22)
        Me.btn_aff.Name = "btn_aff"
        Me.btn_aff.Size = New System.Drawing.Size(123, 36)
        Me.btn_aff.TabIndex = 4
        Me.btn_aff.Text = "&Affi&chez"
        Me.btn_aff.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Location = New System.Drawing.Point(198, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 21)
        Me.Label4.TabIndex = 10
        '
        'liste1
        '
        Me.liste1.BackColor = System.Drawing.SystemColors.MenuText
        Me.liste1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.liste1.FormattingEnabled = True
        Me.liste1.ItemHeight = 21
        Me.liste1.Location = New System.Drawing.Point(20, 3)
        Me.liste1.Name = "liste1"
        Me.liste1.Size = New System.Drawing.Size(176, 298)
        Me.liste1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txt5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txt)
        Me.Panel1.Controls.Add(Me.txt3)
        Me.Panel1.Controls.Add(Me.txt4)
        Me.Panel1.Controls.Add(Me.txt2)
        Me.Panel1.Controls.Add(Me.txt1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Location = New System.Drawing.Point(12, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(340, 220)
        Me.Panel1.TabIndex = 6
        '
        'txt5
        '
        Me.txt5.Location = New System.Drawing.Point(117, 166)
        Me.txt5.Name = "txt5"
        Me.txt5.ReadOnly = True
        Me.txt5.Size = New System.Drawing.Size(204, 29)
        Me.txt5.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 168)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Exemplaire"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(3, 134)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 21)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Type"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 21)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Auteur"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 21)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Titre"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt
        '
        Me.txt.AutoSize = True
        Me.txt.Location = New System.Drawing.Point(3, 27)
        Me.txt.Name = "txt"
        Me.txt.Size = New System.Drawing.Size(53, 21)
        Me.txt.TabIndex = 9
        Me.txt.Text = "ISBN"
        Me.txt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt3
        '
        Me.txt3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt3.Location = New System.Drawing.Point(117, 96)
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(204, 29)
        Me.txt3.TabIndex = 8
        '
        'txt4
        '
        Me.txt4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txt4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txt4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt4.Items.AddRange(New Object() {"Informatique", "Comédie", "Théatre", "Sciences & Vie", "Mathématiques", "Physique", "Dramatique"})
        Me.txt4.Location = New System.Drawing.Point(117, 131)
        Me.txt4.Name = "txt4"
        Me.txt4.Size = New System.Drawing.Size(204, 29)
        Me.txt4.TabIndex = 2
        '
        'txt2
        '
        Me.txt2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt2.Location = New System.Drawing.Point(117, 60)
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(204, 29)
        Me.txt2.TabIndex = 1
        '
        'txt1
        '
        Me.txt1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txt1.Location = New System.Drawing.Point(117, 25)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(204, 29)
        Me.txt1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.liste1)
        Me.Panel3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel3.Location = New System.Drawing.Point(582, 22)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(210, 305)
        Me.Panel3.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_retour)
        Me.Panel2.Controls.Add(Me.btn_mod)
        Me.Panel2.Controls.Add(Me.btn_supp)
        Me.Panel2.Controls.Add(Me.btn_enreg)
        Me.Panel2.Controls.Add(Me.btn_ajout)
        Me.Panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel2.Location = New System.Drawing.Point(375, 75)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(158, 233)
        Me.Panel2.TabIndex = 7
        '
        'btn_retour
        '
        Me.btn_retour.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_retour.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_retour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_retour.Image = Global.ProjetBib.My.Resources.Resources._1393035400_sign_in
        Me.btn_retour.Location = New System.Drawing.Point(21, 176)
        Me.btn_retour.Name = "btn_retour"
        Me.btn_retour.Size = New System.Drawing.Size(123, 36)
        Me.btn_retour.TabIndex = 3
        Me.btn_retour.UseVisualStyleBackColor = True
        '
        'btn_mod
        '
        Me.btn_mod.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_mod.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_mod.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_mod.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_mod.Image = Global.ProjetBib.My.Resources.Resources._1392521763_172618
        Me.btn_mod.Location = New System.Drawing.Point(21, 134)
        Me.btn_mod.Name = "btn_mod"
        Me.btn_mod.Size = New System.Drawing.Size(123, 36)
        Me.btn_mod.TabIndex = 5
        Me.btn_mod.UseVisualStyleBackColor = True
        '
        'btn_supp
        '
        Me.btn_supp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_supp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_supp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_supp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_supp.Image = Global.ProjetBib.My.Resources.Resources._1392521672_address_book2_delete
        Me.btn_supp.Location = New System.Drawing.Point(21, 89)
        Me.btn_supp.Name = "btn_supp"
        Me.btn_supp.Size = New System.Drawing.Size(123, 36)
        Me.btn_supp.TabIndex = 2
        Me.btn_supp.UseVisualStyleBackColor = True
        '
        'btn_enreg
        '
        Me.btn_enreg.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enreg.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_enreg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_enreg.Image = Global.ProjetBib.My.Resources.Resources._1392521914_Sync
        Me.btn_enreg.Location = New System.Drawing.Point(21, 3)
        Me.btn_enreg.Name = "btn_enreg"
        Me.btn_enreg.Size = New System.Drawing.Size(123, 36)
        Me.btn_enreg.TabIndex = 1
        Me.btn_enreg.UseVisualStyleBackColor = True
        '
        'btn_ajout
        '
        Me.btn_ajout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ajout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_ajout.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ajout.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btn_ajout.Image = Global.ProjetBib.My.Resources.Resources._1392521633_24_book_red_add
        Me.btn_ajout.Location = New System.Drawing.Point(21, 45)
        Me.btn_ajout.Name = "btn_ajout"
        Me.btn_ajout.Size = New System.Drawing.Size(123, 36)
        Me.btn_ajout.TabIndex = 0
        Me.btn_ajout.UseVisualStyleBackColor = True
        '
        'grid
        '
        Me.grid.BackgroundColor = System.Drawing.Color.White
        Me.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid.Location = New System.Drawing.Point(12, 333)
        Me.grid.Name = "grid"
        Me.grid.Size = New System.Drawing.Size(780, 200)
        Me.grid.TabIndex = 11
        '
        'frm_livre
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.ProjetBib.My.Resources.Resources.logo_biblio_poly_0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(804, 545)
        Me.Controls.Add(Me.btn_aff)
        Me.Controls.Add(Me.grid)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Garamond", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frm_livre"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Paramétrage Ouvrage"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txt5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_retour As System.Windows.Forms.Button
    Friend WithEvents btn_supp As System.Windows.Forms.Button
    Friend WithEvents btn_enreg As System.Windows.Forms.Button
    Friend WithEvents btn_ajout As System.Windows.Forms.Button
    Friend WithEvents btn_aff As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents liste1 As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txt4 As System.Windows.Forms.ComboBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents btn_mod As System.Windows.Forms.Button
    Friend WithEvents txt5 As System.Windows.Forms.NumericUpDown
    Friend WithEvents grid As System.Windows.Forms.DataGridView
End Class
