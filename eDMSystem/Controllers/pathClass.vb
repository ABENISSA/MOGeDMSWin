Public Class pathClass
    Public Function getPath(p As Integer) As String

        Dim path As String = Nothing

        If p = 1 Then
            path = "\\tip-app-db\MDS\ICT_Docs\IN_IN\"
        ElseIf p = 2 Then
            path = "\\tip-app-db\MDS\ICT_Docs\IN_OUT\"
        ElseIf p = 3 Then
            path = "\\tip-app-db\MDS\ICT_Docs\EX_IN\"
        ElseIf p = 4 Then
            path = "\\tip-app-db\MDS\ICT_Docs\EX_OUT\"
        ElseIf p = 5 Then
            path = "\\tip-app-db\MDS\ICT_Docs\EMPLOYEES\"
        End If

        Return path
    End Function
End Class
