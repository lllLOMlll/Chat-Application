Public Class User
    Public Property UserId As Integer
    Public Property Username As String
    Public Property FirstName As String
    Public Property LastName As String
    Public Property DateOfBirth As Date?
    Public Property Address As String
    Public Property Telephone As String
    Public Property School As String
    Public Property Program As String
    Public Property Password As String
    Public Property Avatar As String
    Public Property Status As UserStatus

    Public Enum UserStatus
        Active
        Inactive
    End Enum

    ' Constructor with just username and avatar
    Public Sub New()
    End Sub

    ' Constructor with username, password, and avatar
    Public Sub New(username As String, password As String, avatar As String)
        Me.Username = username
        Me.Password = password
        Me.Avatar = avatar
    End Sub

    ' Constructor with username and password
    Public Sub New(username As String, password As String)
        Me.Username = username
        Me.Password = password
    End Sub

    ' Constructor with all properties
    Public Sub New(userId As Integer, username As String, firstName As String, lastName As String,
                   dateOfBirth As Date?, address As String, telephone As String, school As String,
                   program As String, password As String, avatar As String, status As UserStatus)
        Me.UserId = userId
        Me.Username = username
        Me.FirstName = firstName
        Me.LastName = lastName
        Me.DateOfBirth = dateOfBirth
        Me.Address = address
        Me.Telephone = telephone
        Me.School = school
        Me.Program = program
        Me.Password = password
        Me.Avatar = avatar
        Me.Status = status
    End Sub
End Class

