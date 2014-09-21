Public Class ClsInvoice

    Public Property RoomID As String
    Public Property RoomType As String
    Public Property Duration As String
    Public Property TimeIn As String
    Public Property TimeOut As String
    Public Property Price As String
    Public Property Discount As String
    Public Property Amount As String
    Public Property Username As String

    Public Sub New()

    End Sub

    Public Sub New(RoomID As String, RoomType As String, Duration As String, TimeIn As String, TimeOut As String, Price As String, Discount As String, Amount As String, Username As String)
        Me.RoomID = RoomID
        Me.RoomType = RoomType
        Me.Duration = Duration
        Me.TimeOut = TimeOut
        Me.TimeIn = TimeIn
        Me.Price = Price
        Me.Discount = Discount
        Me.Amount = Amount
        Me.Username = Username
    End Sub

End Class
