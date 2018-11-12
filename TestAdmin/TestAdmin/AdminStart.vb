Public Class AdminStart

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            Dim frm As New Function1
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            Dim frm As New Function2
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try

            Dim frm As New Function3
            frm.ShowDialog()
        Catch ex As Exception
            MsgBox(Err.Description)
        End Try
    End Sub

   
End Class
