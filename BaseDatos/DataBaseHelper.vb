Public Class DataBaseHelper
    Private ReadOnly ConectionString As String = CofigurationManager.ConnectionStrings("II-46ConnectionString").ConnectionString
    Public Function create() As String
        Try
            Dim sql As String = ""
            Dim Parametros As String = ""

            Using connection As New SqlConnection(ConectionString)
                Using command As New SqlCommand(sql, connection)
                    command.Parameters.AddWithValue("@Nombre", "Juan")
                    command.Parameters.AddWithValue("@Apellido", "Perez")
                    command.Parameters.AddWithValue("@Edad", 30)
                    command.ExecuteNonQuery()
                End Using
            End Using

        Catch ex As Exception

        End Try
        Return "Persona_Creada"
    End Function


End Class
