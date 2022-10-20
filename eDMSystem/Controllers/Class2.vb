Public Class Class2
    Private _USERID As String

    Public Property Number() As String
        Get
            Return _USERID
        End Get
        Set(ByVal value As String)
            _USERID = value
        End Set
    End Property
End Class
