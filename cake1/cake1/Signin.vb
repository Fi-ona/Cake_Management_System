Imports System.Data
Imports System.Data.SqlClient

Public Class Signin

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\divya\OneDrive\Documents\cake.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub signinBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles signinBTN.Click
        cn.Open()
        Dim cmd As New SqlCommand("select u_type, u_name, password from signin where u_type='" & typeCB.Text & "'and u_name='" & unameTF.Text & "' and password='" & passTF.Text & "' ", cn)
        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If dr.Read = True Then
            MsgBox("Sign In Done Successfully", MsgBoxStyle.Information, "Signed In")
            If typeCB.SelectedItem = "Admin" Then
                Admin_main.Show()
                Me.Hide()
            ElseIf typeCB.SelectedItem = "Receptionist" Then
                Receptionist_main.Show()
                Me.Hide()
            End If
        Else
            If unameTF.Text = "" Or passTF.Text = "" Then
                MsgBox("Please fill the details given", MsgBoxStyle.OkCancel, "Blank field/s")
            Else
                MsgBox("Enter proper Username or password", MsgBoxStyle.OkCancel, "Improper Data Entered")
            End If
        End If
        unameTF.Text = ""
        passTF.Text = ""
        cn.Close()
    End Sub

    Private Sub cancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBTN.Click
        Me.Close()
    End Sub
End Class
