Imports MySql.Data.MySqlClient
Public Class cl_conn
    Public mycon As MySqlConnection
    Public strcon As String
    Public rdr As MySqlDataReader
    Public Myreq As String
    Public cmd As MySqlCommand
    Public Sub Connecting_in_base()
        Try
            strcon = "server=localhost;user id=root;password=;database=biblio"
            mycon = New MySqlConnection(strcon)
            mycon.Open()
            cmd = New MySqlCommand(Myreq, mycon)
            rdr = cmd.ExecuteReader
        Catch ex As MySqlException
            Console.WriteLine(ex.Message)
        End Try
        
    End Sub
    Public Sub Disconnecting_in_base()
        rdr.Close()
        mycon.Close()
    End Sub
End Class
