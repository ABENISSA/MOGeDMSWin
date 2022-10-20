Module Module2
    Dim _USERID As String
    Dim _DOCID As Integer

    Public Property Number() As String
        Get
            Return _USERID
        End Get
        Set(ByVal value As String)
            _USERID = value
        End Set
    End Property

    Public Property DocID() As Integer
        Get
            Return _DOCID
        End Get
        Set(ByVal v As Integer)
            _DOCID = v
        End Set
    End Property
End Module
