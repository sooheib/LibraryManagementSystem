Imports MySql.Data.MySqlClient
Public Class index
    Dim db_cnx As New cl_conn
    Dim pb As New DataSet
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        dt.Text = System.DateTime.Now
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If DialogResult.OK = MessageBox.Show("Voulez Vous Quitter l'application", "Fermeture En Cours ...", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) Then
            Application.Exit()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Dim f2 As New cnx()
        f2.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Dim f1 As New inscription()
        f1.ShowDialog()
    End Sub

    Private Sub index_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim nb_livre As Integer = get_nblivre()
        nb1.Text = nb_livre.ToString
    End Sub
    Private Function get_nblivre() As Integer
        Dim nb As Integer
        db_cnx.Myreq = "select * from ouvrage"
        db_cnx.Connecting_in_base()
        Dim dr As New MySqlDataAdapter(db_cnx.cmd)
        db_cnx.Disconnecting_in_base()
        dr.Fill(pb, "ouvrage")
        nb = pb.Tables("ouvrage").Rows.Count()
        Return nb
    End Function
End Class