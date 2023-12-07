Public Class Post
    ' Properties
    Public Property PostId As Integer
    Public Property UserId As Integer
    Public Property Content As String
    Public Property TimePublished As DateTime

    ' Constructor with all properties
    Public Sub New(postId As Integer, userId As Integer, content As String, timePublished As DateTime)
        Me.PostId = postId
        Me.UserId = userId
        Me.Content = content
        Me.TimePublished = timePublished
    End Sub

    ' Parameterless constructor
    Public Sub New()
    End Sub

    ' Constructor without PostId, as it's auto-incremented in the database
    Public Sub New(userId As Integer, content As String, timePublished As DateTime)
        Me.UserId = userId
        Me.Content = content
        Me.TimePublished = timePublished
    End Sub


End Class

