Imports System.IO
Imports System.Drawing.Image
Imports AcroPDFLib
Imports AxAcroPDFLib
Imports System.IO.FileAccess
Imports System.IO.FileMode
Imports System.IO.StreamReader
Imports System.IO.BinaryReader
Imports System.IO.File
Imports System.IO.FileStream
Imports System.IO.Stream
Public Class showPDF
    Dim f As String = Nothing
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
    Private Sub showPDF_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            Dim path6 As String = f
            AxAcroPDF1.src = (path6 + ".pdf")
        Catch ex As Exception
            MessageBox.Show(ex.Message & " - " & ex.Source)
            Exit Sub
        End Try
    End Sub
    Public Sub getValue(pp As String)
        f = pp
    End Sub
End Class