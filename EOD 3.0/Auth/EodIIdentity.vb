Imports System.Data.OleDb
Imports EOD.datasetEOD
Imports EOD.datasetEODTableAdapters

Public Class EodIIdentity
    Implements System.Security.Principal.IIdentity

    Private nameValue As String
    Private authenticatedValue As Boolean
    Private roleValue As ApplicationServices.BuiltInRole

    Public ReadOnly Property AuthenticationType() As String Implements System.Security.Principal.IIdentity.AuthenticationType
        Get
            Return "AccessDatabase"
        End Get
    End Property

    Public ReadOnly Property IsAuthenticated() As Boolean Implements System.Security.Principal.IIdentity.IsAuthenticated
        Get
            Return authenticatedValue
        End Get
    End Property

    Public ReadOnly Property Name() As String Implements System.Security.Principal.IIdentity.Name
        Get
            Return nameValue
        End Get
    End Property

    Public ReadOnly Property Role() As ApplicationServices.BuiltInRole
        Get
            Return roleValue
        End Get
    End Property

    Public Sub New(ByVal name As String, ByVal password As String)
        ' The name is not case sensitive, but the password is.


        If loginValido(name, password) Then
            nameValue = My.Settings.NombreUsuario & " " & My.Settings.ApellidoUsuario
            authenticatedValue = True
            Select Case My.Settings.RolUsuario
                Case 1
                    'Encuestador
                    roleValue = ApplicationServices.BuiltInRole.User
                Case 2
                    'Supervisor
                    roleValue = ApplicationServices.BuiltInRole.SystemOperator
                Case 3
                    'Administrador'
                    roleValue = ApplicationServices.BuiltInRole.Administrator
            End Select
        Else
            nameValue = ""
            authenticatedValue = False
            roleValue = ApplicationServices.BuiltInRole.Guest
        End If

    End Sub

    Private Function loginValido(
        ByVal username As String,
        ByVal password As String) As Boolean

        Dim dataset As datasetEOD = New datasetEOD
        Dim tableAdapter As UsuarioTableAdapter = New UsuarioTableAdapter
        tableAdapter.Fill(dataset.Usuario)

        Dim usuario As UsuarioRow = Nothing
        Try
            usuario = dataset.Usuario.Select("rut = '" & username & "'")(0)
        Catch ex As Exception
        End Try

        If usuario IsNot Nothing Then
            If usuario.pwd = password Then
                My.Settings.NombreUsuario = usuario.Nombre
                My.Settings.ApellidoUsuario = usuario.Apellidos
                My.Settings.IdUsuario = usuario.ID
                My.Settings.RolUsuario = usuario.rol
                Return True
            Else
                Return False
            End If
        Else
            Return False
        End If

        Return False
    End Function

    Private Function IsValidNameAndPassword(
        ByVal username As String,
        ByVal password As String) As Boolean

        ' Look up the stored hashed password and salt for the username.
        Dim storedHashedPW As String = GetHashedPassword(username)
        Dim salt As String = GetSalt(username)

        'Create the salted hash.
        Dim rawSalted As String = salt & Trim(password)
        Dim saltedPwBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(rawSalted)
        Dim sha1 As New System.Security.Cryptography.
            SHA1CryptoServiceProvider
        Dim hashedPwBytes() As Byte = sha1.ComputeHash(saltedPwBytes)
        Dim hashedPw As String = Convert.ToBase64String(hashedPwBytes)

        ' Compare the hashed password with the stored password.
        Return hashedPw = storedHashedPW
    End Function

    Private Function GetHashedPassword(ByVal username As String) As String
        ' Code that gets the user's hashed password goes here.
        ' This example uses a hard-coded hashed passcode.
        ' In general, the hashed passcode should be stored 
        ' outside of the application.
        If Trim(username).ToLower = "testuser" Then
            Return "ZFFzgfsGjgtmExzWBRmZI5S4w6o="
        Else
            Return ""
        End If
    End Function

    Private Function GetSalt(ByVal username As String) As String
        ' Code that gets the user's salt goes here.
        ' This example uses a hard-coded salt.
        ' In general, the salt should be stored 
        ' outside of the application.
        If Trim(username).ToLower = "testuser" Then
            Return "Should be a different random value for each user"
        Else
            Return ""
        End If
    End Function
End Class
