Imports System.Text.RegularExpressions
Imports MySql.Data.MySqlClient
Public Class inscription
    Dim cmd As New MySqlCommand
    Dim cmd2 As New MySqlCommand
    Dim da As New MySqlDataAdapter
    Dim con As New MySqlConnection("server=localhost;user id=root;password=;database=biblio")

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        dt.Text = System.DateTime.Now
    End Sub
    Private Sub inscription_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        civ.SelectedIndex = 0
    End Sub
    Function verif_mail(ByVal emailAddress As String) As Boolean
        Dim pattern As String = "^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
        Dim emailAddressMatch As Match = Regex.Match(emailAddress, pattern)
        If emailAddressMatch.Success Then
            verif_mail = True
        Else
            verif_mail = False
        End If
    End Function
    Private Sub add()
        Try
            Dim Query As String
            Query = "INSERT INTO accounts(civ_user,coordonnees_user,identite_user,pseudo_user,passe_user,mail_user,type_user)VALUES('" + civ.Text + "','" + nom.Text + "','" + identite.Text + "','" + pseudo.Text + "','" + passe.Text + "','" + mail.Text + "','" + type.Text + "')"
            con.Open()
            Dim val As Boolean = verif_mail(mail.Text)
            If val = True Then
                Dim cmd As MySqlCommand = New MySqlCommand(Query, con)
                Dim i As Integer = cmd.ExecuteNonQuery()
                If (i > 0) Then
                    MessageBox.Show("Inscription avec succés", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    etablir_champs()
                End If
            Else
                MessageBox.Show("Format Mail Incorrect", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            con.Close()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Private Sub verif_user()
        Dim sql As String
        Dim publictable As New DataTable
        sql = "select * from accounts where identite_user ='" & identite.Text & "' or pseudo_user = '" & pseudo.Text & "'"
        With cmd2
            .Connection = con
            .CommandText = sql
        End With
        da.SelectCommand = cmd2
        da.Fill(publictable)
        If publictable.Rows.Count > 0 Then
            MessageBox.Show("Utilisateur Existant", "Profil existant", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            add()
            da.Dispose()
        End If
    End Sub
    Private Sub etablir_champs()
        civ.SelectedIndex = 0
        nom.Text = ""
        identite.Text = ""
        pseudo.Text = ""
        passe.Text = ""
        mail.Text = ""
        type.Text = "User"
    End Sub

    Private Sub insc_Click(sender As System.Object, e As System.EventArgs) Handles insc.Click
        If nom.Text = "" Or pseudo.Text = "" Or passe.Text = "" Or identite.Text = "" Then
            MessageBox.Show("Champ Manquant", "Erreur Saisie", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            verif_user()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Dim f1 As New index()
        f1.ShowDialog()
    End Sub
End Class
