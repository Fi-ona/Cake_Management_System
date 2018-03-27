Imports System.Data
Imports System.Data.SqlClient

Public Class sales

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\divya\OneDrive\Documents\cake.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub DateTimePicker2_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker2.ValueChanged
        If DateTimePicker2.Value <= DateTimePicker1.Value Then
            MsgBox("Invalid date")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cn.Open()
        Dim cmd As New SqlCommand("select p_type, p_subtype, qty, o_date from order1 where (o_date BETWEEN '" & DateTimePicker1.Text & "' AND '" & DateTimePicker2.Text & "') ", cn)

        Dim dr As SqlDataReader
        dr = cmd.ExecuteReader()
        If dr.Read() = True Then
            grid()
        Else
            Me.Close()
        End If
        cn.Close()
    End Sub

    Sub grid()
        cn.Close()
        cn.Open()
        Dim adp As New SqlDataAdapter("select o_date as 'Order Date', p_type as 'Product Type',p_subtype as 'Product Subtype', qty as 'Quantity' from order1", cn)
        Dim ds As New DataSet
        adp.Fill(ds, "order1")
        DataGridView1.DataSource = ds.Tables("order1")
        cn.Close()
    End Sub

    Private Sub sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grid()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Signin.typeCB.SelectedItem = "Admin" Then
            Admin_main.Show()
        ElseIf Signin.typeCB.SelectedItem = "Receptionist" Then
            Receptionist_main.Show()
        End If
        Me.Close()
    End Sub
End Class