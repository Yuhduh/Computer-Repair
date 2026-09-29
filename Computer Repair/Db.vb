Imports MySql.Data.MySqlClient
Imports System.Data

Friend Module Db
    Private Const ConnectionText As String = "Server=localhost;Database=computer_repair;Uid=root;Pwd=carl;SslMode=None;AllowUserVariables=True;"

    Public Function OpenConnection() As MySqlConnection
        Dim connection As New MySqlConnection(ConnectionText)
        connection.Open()
        Return connection
    End Function

    Public Function GetTable(sql As String, ParamArray values() As Object) As DataTable
        Using connection As MySqlConnection = OpenConnection()
            Using command As MySqlCommand = CreateCommand(connection, sql, values)
                Dim table As New DataTable()

                Using adapter As New MySqlDataAdapter(command)
                    adapter.Fill(table)
                End Using

                Return table
            End Using
        End Using
    End Function

    Public Function Execute(sql As String, ParamArray values() As Object) As Integer
        Using connection As MySqlConnection = OpenConnection()
            Using command As MySqlCommand = CreateCommand(connection, sql, values)
                Return command.ExecuteNonQuery()
            End Using
        End Using
    End Function

    Public Function GetValue(sql As String, ParamArray values() As Object) As Object
        Using connection As MySqlConnection = OpenConnection()
            Using command As MySqlCommand = CreateCommand(connection, sql, values)
                Return command.ExecuteScalar()
            End Using
        End Using
    End Function

    Public Function CreateCommand(connection As MySqlConnection, sql As String, values() As Object,
                                  Optional transaction As MySqlTransaction = Nothing) As MySqlCommand
        Dim command As New MySqlCommand(sql, connection, transaction)
        For index As Integer = 0 To values.Length - 1
            command.Parameters.AddWithValue("@p" & index, If(values(index), DBNull.Value))
        Next
        Return command
    End Function

    Public Function NullIfBlank(text As String) As Object
        Dim value As String = text.Trim()

        If value = "" Then
            Return DBNull.Value
        End If

        Return value
    End Function
End Module
