Imports System.Text
Imports System.Security.Cryptography

<Assembly: ArmDot.Client.ObfuscateNames>
<Assembly: ArmDot.Client.HideStrings>
<Assembly: ArmDot.Client.ObfuscateControlFlow>
<Assembly: ArmDot.Client.ProtectEmbeddedResources>

Public Class Form1
    <ArmDot.Client.VirtualizeCode>
    Private Sub ButtonCheckPassword_Click(sender As Object, e As EventArgs) Handles ButtonCheckPassword.Click
        Dim hash As Byte() = (New SHA256Managed()).ComputeHash(Encoding.Unicode.GetBytes(TextBoxPassword.Text))

        If hash(0) = 81 And hash(1) = 96 And hash(2) = 9 And hash(3) = 150 And
        hash(4) = 45 And hash(5) = 146 And hash(6) = 51 And hash(7) = 201 And
        hash(8) = 238 And hash(9) = 22 And hash(10) = 103 And hash(11) = 233 And
        hash(12) = 209 And hash(13) = 135 And hash(14) = 107 And hash(15) = 39 And
        hash(16) = 228 And hash(17) = 171 And hash(18) = 22 And hash(19) = 78 And
        hash(20) = 218 And hash(21) = 213 And hash(22) = 11 And hash(23) = 131 And
        hash(24) = 71 And hash(25) = 17 And hash(26) = 241 And hash(27) = 180 And
        hash(28) = 118 And hash(29) = 9 And hash(30) = 163 And hash(31) = 249 Then
            MessageBox.Show("The password is correct")
        Else
            MessageBox.Show("The password is wrong")
        End If
    End Sub
End Class
