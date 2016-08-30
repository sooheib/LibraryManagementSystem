Imports MySql.Data.MySqlClient
Public Class cnx
    Dim db_cnx As New cl_conn
    Dim pb As New DataSet
    Private Sub btcnx_Click(sender As System.Object, e As System.EventArgs) Handles btcnx.Click
        reconnecter()
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        dt.Text = System.DateTime.Now
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f1 As New index()
        f1.ShowDialog()
    End Sub
    Private Sub reconnecter()
        If pseudo.Text = "" Or passe.Text = "" Then
            MsgBox("CHAMPS MANQUANTS")
        Else
            db_cnx.Myreq = "select * from accounts where pseudo_user ='" & pseudo.Text & "' and passe_user = '" & passe.Text & "'"
            db_cnx.Connecting_in_base()
            Dim dr As New MySqlDataAdapter(db_cnx.cmd)
            db_cnx.Disconnecting_in_base()
            dr.Fill(pb, "accounts")
            If pb.Tables("accounts").Rows.Count > 0 Then
                Dim user_type, name, id As String
                user_type = pb.Tables("accounts").Rows(0).Item(6).ToString
                name = pb.Tables("accounts").Rows(0).Item(1).ToString
                id = pb.Tables("accounts").Rows(0).Item(2).ToString
                If user_type = "Admin" Then
                    Me.Hide()
                    MsgBox("Welcome " & name & " you login as administrator ")
                    Dim myForm1 As New ProfilAdmin()
                    myForm1.Show()
                    myForm1.zone.Text = pseudo.Text
                Else
                    MsgBox("Welcome " & name & " you login as User ")
                    Me.Hide()
                    Dim myForm2 As New ProfilUser()
                    myForm2.Show()
                    myForm2.zone.Text = pseudo.Text
                    myForm2.id_user.Text = id
                End If
            Else
                MsgBox("Veuillez s'enregistrer svp")
                pseudo.Text = ""
                passe.Text = ""
            End If
        End If
    End Sub
End Class