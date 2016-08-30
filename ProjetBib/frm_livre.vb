Imports MySql.Data.MySqlClient
Public Class frm_livre
    Dim db_cnx As New cl_conn
    Dim pb As New DataSet
    Dim cmd As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim con As New MySqlConnection("server=localhost;user id=root;password=;database=biblio")
    Private Sub btn_enreg_Click(sender As System.Object, e As System.EventArgs) Handles btn_enreg.Click
        Mettre_a_blanc()
    End Sub
    Public Sub Mettre_a_blanc()
        'initialiser les champs
        txt1.Text = ""
        txt2.Text = ""
        txt3.Text = ""
        txt4.SelectedIndex = 0
        txt5.Text = ""
    End Sub

    Private Sub frm_livre_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'charger au démarrage de l'application le combobox avec mot informatique par défaut
        txt4.SelectedIndex = 0
        charger_grid2()
    End Sub

    Private Sub btn_retour_Click(sender As System.Object, e As System.EventArgs) Handles btn_retour.Click
        Me.Dispose() 'libérer les ressources
    End Sub
    'charger la liste 
    Public Sub charger_la_liste()
        db_cnx.Myreq = "Select titre from ouvrage"
        db_cnx.Connecting_in_base()
        Me.liste1.Items.Clear()
        Do While db_cnx.rdr.Read
            Me.liste1.Items.Add(db_cnx.rdr(0).ToString)
        Loop
        db_cnx.Disconnecting_in_base()
    End Sub

    Private Sub btn_aff_Click(sender As System.Object, e As System.EventArgs) Handles btn_aff.Click
        charger_la_liste()

    End Sub

    Private Sub liste1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles liste1.SelectedIndexChanged
        db_cnx.Myreq = "Select * from ouvrage where titre='" & liste1.SelectedItem & "'"
        db_cnx.Connecting_in_base()
        Do While db_cnx.rdr.Read
            txt1.Text = db_cnx.rdr(0).ToString
            txt2.Text = db_cnx.rdr(1).ToString
            txt3.Text = db_cnx.rdr(2).ToString
            txt4.Text = db_cnx.rdr(3).ToString
            txt5.Text = db_cnx.rdr(4).ToString
        Loop
        db_cnx.Disconnecting_in_base()
    End Sub

    Private Sub btn_ajout_Click(sender As System.Object, e As System.EventArgs) Handles btn_ajout.Click
        verif_livre()
        charger_grid()
        liste1.Items.Clear()
        Me.charger_la_liste()
        Mettre_a_blanc()
    End Sub
    'verifier l'existance de ce livre dans la base avant de l'insérer
    Private Sub verif_livre()
        Dim sql As String
        Dim pb1 As New DataTable
        sql = "select * from ouvrage where isbn ='" & txt1.Text & "' or titre = '" & txt2.Text & "'"
        With cmd
            .Connection = con
            .CommandText = sql
        End With
        da.SelectCommand = cmd
        da.Fill(pb1)
        If pb1.Rows.Count > 0 Then
            MessageBox.Show("Ouvrage Existant", "Profil existant", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            add_livre()
            da.Dispose()
        End If
    End Sub
    Private Sub charger_grid()
        Try
            con.Open()
            Dim Requete As String = "SELECT * from ouvrage"
            Dim Commande As New MySqlCommand(Requete, con)
            Dim Adaptateur As New MySqlDataAdapter(Commande)
            Dim ds As New DataSet
            Try
                Adaptateur.Fill(ds, "ouvrage")
                grid.DataSource = ds.Tables("ouvrage")
                con.Close()
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub charger_grid2()
        db_cnx.Myreq = "SELECT * from ouvrage"
        db_cnx.Connecting_in_base()
        Dim dr As New MySqlDataAdapter(db_cnx.cmd)
        db_cnx.Disconnecting_in_base()
        dr.Fill(pb, "ouvrage")
        grid.DataSource = pb.Tables("ouvrage")
        db_cnx.Disconnecting_in_base()
    End Sub
    Private Sub add_livre()
        Try
            Dim Query As String
            Query = "Insert Into ouvrage(isbn,titre,auteur,type,nb_exp)values('" & txt1.Text & "','" & txt2.Text & "','" & txt3.Text & "','" & txt4.Text & "'," & txt5.Text & ")"
            con.Open()
                Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If (i > 0) Then
                MessageBox.Show("Enregistrement Reussie!")
                End If
            con.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub update_livre()
        Try
            Dim Query As String
            Query = "UPDATE ouvrage SET titre='" & txt2.Text & "',auteur='" & txt3.Text & "',type='" & txt4.Text & "',nb_exp=" & txt5.Text & " where isbn='" & txt1.Text & "'"
            con.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("Modification Reussie!")
            End If
            con.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub delete_livre()
        Try
            Dim Query As String
            Query = "DELETE FROM ouvrage WHERE isbn = '" & txt1.Text & "'"
            con.Open()
            Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("Suppression Reussie!")
            End If
            con.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
     
    Private Sub btn_supp_Click(sender As System.Object, e As System.EventArgs) Handles btn_supp.Click
        delete_livre()
        charger_grid()
        liste1.Items.Clear()
        Me.charger_la_liste()
        Mettre_a_blanc()
    End Sub

    Private Sub btn_mod_Click(sender As System.Object, e As System.EventArgs) Handles btn_mod.Click
        update_livre()
        charger_grid()
        liste1.Items.Clear()
        Me.charger_la_liste()
        Mettre_a_blanc()
    End Sub
End Class