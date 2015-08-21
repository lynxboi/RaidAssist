Public Class Form1


    ' Fill it with your path to your gore folder/kkk songs etc
    Dim killingniggers As String = "z:\CSCHS\killingniggs.wav"
    Dim kkk As String = "z:\CSCHS\kkk.wav"
    Dim gorepath As String = "D:\Final\"
    Dim none As String = "C:\nofile"
    ' AUDIO MUST BE WAV 
    ' C:\nofile must not exist in order to stop the audio



    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label2.Text = DateTime.UtcNow.ToString("MM/dd/yyyy HH:mm:ss.ff") & " MM/DD/YYYY HH:MM:SS.ff UTC"
    End Sub
    Dim xuri, xkey As String

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        fetch()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Hide()
        PictureBox2.Hide()
        fetch()
        Me.TopMost = True
        Me.TopLevel = True
    End Sub

    Private Sub Label1_TextChanged(
ByVal sender As System.Object,
ByVal e As System.EventArgs) _
Handles Label1.TextChanged

        Dim f As Font
        Dim g As Graphics
        Dim s As SizeF
        Dim Faktor, FaktorX, FaktorY As Single

        If Label1.Text.Length = 0 Then Return

        g = Me.Label1.CreateGraphics
        s = g.MeasureString(Label1.Text, Label1.Font)
        g.Dispose()

        FaktorX = Label1.Width / s.Width
        FaktorY = Label1.Height / s.Height

        If FaktorX > FaktorY Then
            Faktor = FaktorY
        Else
            Faktor = FaktorX
        End If

        f = Label1.Font
        Label1.Font = New Font(f.Name, f.SizeInPoints * Faktor)

        Me.Text = Label1.Font.SizeInPoints.ToString
        Label1.Text = Label1.Text

    End Sub

    Sub spinn()
        If showspin Then
            showspin = False
            PictureBox1.Hide()
            PictureBox2.Hide()
        Else
            showspin = True
            PictureBox1.Show()
            PictureBox2.Show()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Try
            My.Computer.Audio.Play(kkk)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Try
            My.Computer.Audio.Play(killingniggers)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Try
            My.Computer.Audio.Play(none)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Process.Start("https://www.e621.net/post/")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Process.Start("http://www.bestgore.com/all-the-gore/")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start("http://www.xnxx.com")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Process.Start("http://www.raidforums.com")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("http://www.soldaten.cc")
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Process.Start(gorepath) ' 
    End Sub
    Dim showspin As Boolean = False
    Dim momin As Boolean = False
    Dim l1s As String
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If CheckBox1.Checked Then
            CheckBox1.Checked = False
            Button6_Click(Nothing, Nothing)
            PictureBox1.Hide()
            PictureBox2.Hide()

            If momin Then
                momin = False
                Me.BackColor = Color.Fuchsia
                Label1.Text = l1s
                CheckBox1.Checked = True
            Else
                momin = True
                l1s = Label1.Text
                Me.BackColor = Color.Gray
                Label1.Text = "mom"
            End If
        End If

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.FormBorderStyle = FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.FormBorderStyle = FormBorderStyle.Sizable
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        If Panel2.Visible = True Then
            Panel2.Visible = False
            Button13.Text = "V"
        Else
            Panel2.Visible = True
            Button13.Text = "/\"
        End If
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        If CheckBox1.Checked = False Then
            Me.Close()
        End If
    End Sub

    Sub fetch()
        Try
            Dim s() As String = Split(My.Computer.Clipboard.GetText, ";")
            xuri = s(0)
            xkey = s(1)
            Me.Text = xuri
            Label3.Text = xkey
        Catch ex As Exception
            Me.Text = "Fetching failed. "

        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label1.Text = InputBox("Autosize", "Edit Text", Label1.Text)
    End Sub

    Private Sub Button14_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles Button14.MouseDoubleClick

    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        spinn()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Process.Start("https://e621.net/post/show/663873")
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Process.Start("https://e621.net/post/show/707571")
    End Sub

    Private Sub Label3_MouseClick(sender As Object, e As MouseEventArgs) Handles Label3.MouseClick
        If e.Button = MouseButtons.Right Then
            Label3.Text = InputBox("Fixed Size", "Edit Text/Enter Streamkey", Label3.Text)
        End If

    End Sub
End Class
