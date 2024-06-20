Public Class aceform

    Private Sub ace1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ace1.CheckedChanged
        If ace1.Checked = True Then
            MsgBox("You have selected Red !!")
            BackColor = Color.Red
            ace1.BackColor = Color.Red
            Exit Sub
        End If
    End Sub

    Private Sub ace3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ace3.CheckedChanged
        If ace3.Checked = True Then
            MsgBox("You have selected Blue !!")
            BackColor = Color.Blue
            ace3.BackColor = Color.Blue
            Exit Sub
        End If
    End Sub

    Private Sub ace5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ace5.CheckedChanged
        If ace5.Checked = True Then
            MsgBox("You have selected Yellow !!")
            BackColor = Color.Yellow
            ace5.BackColor = Color.Yellow
            Exit Sub
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim msg As String = ""
        If acecheck1.Checked = True Then
            msg = "net-informations.com"
        End If
        If acecheck2.Checked = True Then
            msg = "vb.net-informations.com"
        End If
        If acecheck3.Checked = True Then
            msg = "csharp.net-informations.com"
        End If
        If msg.Length > 0 Then
            MsgBox(msg & "selected")
        Else
            MsgBox("No CheckBox Selected.")
        End If
        acecheck1.ThreeState = True
    End Sub

    Private Sub ace2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ace2.CheckedChanged
        If ace2.Checked = True Then
            MsgBox("You have selected Green !!")
            BackColor = Color.Green
            ace2.BackColor = Color.Green
            Exit Sub
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub ace4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ace4.CheckedChanged
        If ace4.Checked = True Then
            MsgBox("You have selected Pink !!")
            BackColor = Color.Pink
            ace4.BackColor = Color.Pink
            Exit Sub
        End If
    End Sub
End Class
