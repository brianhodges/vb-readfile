Public Class Team
    Private title As String
    Private wins As Integer

    Public Sub New(ByVal Name As String, SuperBowlWins As Integer)
        Me.Name = Name
        Me.SuperBowlWins = SuperBowlWins
    End Sub

    Public Property Name() As String
        Get
            Return title
        End Get
        Set(ByVal Value As String)
            title = Value
        End Set
    End Property

    Public Property SuperBowlWins() As Integer
        Get
            Return wins
        End Get
        Set(ByVal Value As Integer)
            wins = Value
        End Set
    End Property
End Class
