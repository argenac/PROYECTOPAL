Imports System.Data.SqlClient
Imports System.Data
Imports System.Drawing.Printing
Module Config
    Public connsql As SqlConnection
    Public Sub Iniciarconexion()
        connsql = New SqlConnection("Data Source=LAPTOP-E3PVP85P\SQLEXPRESS;Initial Catalog=NAMING;Integrated Security=True")
        connsql.Open()
    End Sub
End Module
