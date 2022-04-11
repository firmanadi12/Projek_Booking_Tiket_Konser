Imports MySql.Data.MySqlClient
Module Module1
    Public Conn As MySqlConnection
    Public cmd As MySqlCommand
    Public ds As DataSet
    Public da As MySqlDataAdapter
    Public rdr As MySqlDataReader
    Public db As String


    Public Sub Koneksi()
        db = "Server=localhost;user id=root;password=;database=db_sistemtiket;Convert Zero Datetime=true"
        Conn = New MySqlConnection(db)


    End Sub

    Public Function SQLTable(ByVal Source As String) As DataTable
        Dim dtb As DataTable
        Try
            Dim adp As New MySqlDataAdapter(Source, Conn)
            dtb = New DataTable
            adp.Fill(dtb)
            SQLTable = dtb
        Catch ex As MySqlException
            MsgBox(ex.Message)
            SQLTable = Nothing
        End Try
    End Function


End Module
