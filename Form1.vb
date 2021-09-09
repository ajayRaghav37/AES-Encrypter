Imports System
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text

Public Class Form1
    Dim IV As Byte() = Encoding.Unicode.GetBytes("£♥3b !R☼") 'Convert.FromBase64String("vm5Qj4/r1vy4SSADO6xzkw==")
    Dim SaltValue As Byte() = Encoding.Unicode.GetBytes("S@lt v@lu3")
    Dim password As Rfc2898DeriveBytes
    Dim Key As Byte()
    Private Function EncryptString(plainText As String) As String
        On Error GoTo EncryptFailed
        Dim encrypted() As Byte
        Using aesAlg As New AesManaged()
            aesAlg.Key = Key
            aesAlg.IV = IV
            Dim encryptor As ICryptoTransform = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
            Using msEncrypt As New MemoryStream()
                Using csEncrypt As New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    Using swEncrypt As New StreamWriter(csEncrypt)
                        swEncrypt.Write(plainText)
                    End Using
                    encrypted = msEncrypt.ToArray()
                End Using
            End Using
        End Using
        Return Convert.ToBase64String(encrypted)
EncryptFailed:
        Return ""
    End Function
    Private Function DecryptString(cipherText As String) As String
        On Error GoTo DecryptFailed
        Dim cipherBytes As Byte() = Convert.FromBase64String(cipherText)
        Dim plaintext As String = Nothing
        Using aesAlg As New AesManaged
            aesAlg.Key = Key
            aesAlg.IV = IV
            Dim decryptor As ICryptoTransform = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV)
            Using msDecrypt As New MemoryStream(cipherBytes)

                Using csDecrypt As New CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)

                    Using srDecrypt As New StreamReader(csDecrypt)
                        plaintext = srDecrypt.ReadToEnd()
                    End Using
                End Using
            End Using
        End Using
        Return plaintext
DecryptFailed:
        Return ""
    End Function

    Private Sub btnSwap_Click(sender As Object, e As EventArgs) Handles btnSwap.Click
        txtInput.Text = txtOutput.Text
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        lblInput.Text = "Input" & vbNewLine & "(" & txtInput.Text.Length & ")"
        If optEncrypt.Checked Then
            EncryptInput(sender, e)
        Else
            DecryptInput(sender, e)
        End If
    End Sub

    Private Sub EncryptInput(sender As Object, e As EventArgs) Handles optEncrypt.CheckedChanged
        Dim original As String = txtInput.Text
        Dim encrypted As String = EncryptString(original)
        txtOutput.Text = encrypted
        lblOutput.Text = "Output" & vbNewLine & "(" & txtOutput.Text.Length & ")"
        lblRatio.Text = "Ratio" & vbNewLine & "(" & Math.Round(txtOutput.Text.Length / txtInput.Text.Length, 3) & ")"
    End Sub

    Private Sub DecryptInput(sender As Object, e As EventArgs) Handles optDecrypt.CheckedChanged
        Dim encrypted As String = txtInput.Text
        Dim roundtrip As String = DecryptString(encrypted)
        txtOutput.Text = roundtrip
        lblOutput.Text = "Output" & vbNewLine & "(" & txtOutput.Text.Length & ")"
        lblRatio.Text = "Ratio" & vbNewLine & "(" & Math.Round(txtInput.Text.Length / txtOutput.Text.Length, 3) & ")"
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        lblPassword.Text = "Password" & vbNewLine & "(" & txtPassword.Text.Length & ")"
        password = New Rfc2898DeriveBytes(txtPassword.Text, SaltValue)
        Key = password.GetBytes(32)
        If optEncrypt.Checked Then
            EncryptInput(sender, e)
        Else
            DecryptInput(sender, e)
        End If
    End Sub
End Class
