Imports System.Data
Imports System.Data.SqlClient

Public Class new_registration

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\divya\OneDrive\Documents\cake.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub signinBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signinBTN.Click

        cn.Open()
        Dim cmd As New SqlCommand
        cmd.Connection = cn
        cmd.CommandText = "select count(*) from signin where u_name='" & unameTF.Text & "' "
        Dim temp As Integer = cmd.ExecuteScalar
        If temp = 1 Then
            MsgBox("UserName Already Exists", MsgBoxStyle.Information, "User Exists")

        Else

            If passTF.Text = conpassTF.Text Then
                cmd.CommandText = "insert into signin(u_type, u_name, password) values('" & typeCB.Text & "', '" & unameTF.Text & "', '" & passTF.Text & "')"
                cmd.Connection = cn
                cmd.ExecuteNonQuery()

                MsgBox("Welcome, " & unameTF.Text & " !", MsgBoxStyle.Information, "User Created Successfully")
            Else
                MsgBox("Password and Confirm Password doesn't match", MsgBoxStyle.Critical, "Wrong Password!")
            End If
        End If
        cn.Close()
        clear()
    End Sub

    Sub clear()
        typeCB.SelectedItem = False
        unameTF.Text = ""
        passTF.Text = ""
        conpassTF.Text = ""
    End Sub

    Private Sub cancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBTN.Click
        Me.Close()
        Admin_main.Show()
    End Sub
End Class