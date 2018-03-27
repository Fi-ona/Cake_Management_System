Imports System.Data
Imports System.Data.SqlClient   'radio button are not being selected when grid view is clicked...... no delivery must come in grid view

Public Class customer

    Dim delivery As String
    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\divya\OneDrive\Documents\cake.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub cancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBTN.Click
        Admin_main.Show()
        Me.Close()
    End Sub

    Private Sub insertBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertBTN.Click
        If ad_payTF.Text >= full_payTF.Text Then
            MsgBox("Advance payment cannot be more than full payment.", MsgBoxStyle.OkCancel, "Payment")
        Else
            cn.Open()
            If deliveryRBTN.Checked = True Then
                Dim cmd As New SqlCommand("insert into customer(c_id, c_name, contact, delivery, delivery_date, ad_payment, full_payment, qty, address, p_type) values(" & cidTF.Text & ", '" & cnameTF.Text & "', " & contactTF.Text & ", 'Yes', '" & DTP.Value & "', " & ad_payTF.Text & ", " & full_payTF.Text & ", " & qtyTF.Text & ", '" & addTF.Text & "', '" & typeCB.SelectedItem() & "')", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Data entered successfully", MsgBoxStyle.Information, "Data inserted")
            Else
                Dim cmd As New SqlCommand("insert into customer(c_id, c_name, contact, delivery, ad_payment, full_payment, qty, address, p_type) values(" & cidTF.Text & ", '" & cnameTF.Text & "', " & contactTF.Text & ", 'No', " & ad_payTF.Text & ", " & full_payTF.Text & ", " & qtyTF.Text & ", '" & addTF.Text & "', '" & typeCB.SelectedItem() & "')", cn)
                cmd.ExecuteNonQuery()
                MsgBox("Data entered successfully", MsgBoxStyle.Information, "Data inserted")
            End If
            'Dim cmd As New SqlCommand("insert into customer values(" & cidTF.Text & ", '" & cnameTF.Text & "', " & contactTF.Text & ", '" & delivery & "', " & ad_payTF.Text & ", " & full_payTF.Text & ", " & qtyTF.Text & ", '" & addTF.Text & "', '" & typeCB.SelectedItem() & "')", cn)
            'cmd.ExecuteNonQuery()
            'MsgBox("Data entered successfully", MsgBoxStyle.Information, "Data inserted")
            cn.Close()
        End If
        grid()
        clear()
    End Sub

    Private Sub updateBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateBTN.Click
        cn.Open()
        Dim cmd As New SqlCommand("update customer set c_name='" & cnameTF.Text & "', contact=" & contactTF.Text & ", delivery_date='" & DTP.Text & "', ad_payment=" & ad_payTF.Text & ", full_payment=" & full_payTF.Text & ", qty=" & qtyTF.Text & ", address='" & addTF.Text & "', p_type='" & typeCB.SelectedItem() & "' where c_id=" & cidTF.Text & " ", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Data updated successfully", MsgBoxStyle.Information, "Data updated")
        cn.Close()
        grid()
        clear()
    End Sub

    Private Sub deleteBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBTN.Click
        cn.Open()
        Dim cmd As New SqlCommand("delete from customer where c_id=" & cidTF.Text & " ", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Data deleted successfully", MsgBoxStyle.Information, "Data deleted")
        cn.Close()
        grid()
        clear()
    End Sub

    Private Sub deliveryRBTN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deliveryRBTN.CheckedChanged
        DTP.Visible() = True
    End Sub

    Private Sub nodeliveryRBTN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nodeliveryRBTN.CheckedChanged
        DTP.Visible() = False
    End Sub

    Sub grid()
        cn.Open()
        Dim adp As New SqlDataAdapter("select c_id as 'Customer ID', c_name as 'Customer Name', contact as 'Contact',delivery as 'Delivery Reguired?', delivery_date as 'Delivery Date', ad_payment as 'Advance Payment', full_payment as 'Full Payment', qty as 'Quantity', address as 'Address', p_type as 'Product Type' from customer", cn)
        Dim ds As New DataSet
        ds.Clear()
        adp.Fill(ds, "customer")
        DGV.DataSource = ds.Tables("customer")
        cn.Close()
    End Sub

    Private Sub customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grid()
    End Sub


    Private Sub DGV_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        cidTF.Text = DGV.Rows(e.RowIndex).Cells(0).Value
        cnameTF.Text = DGV.Rows(e.RowIndex).Cells(1).Value
        contactTF.Text = DGV.Rows(e.RowIndex).Cells(2).Value
        If DGV.Rows(e.RowIndex).Cells(3).Value = "No" Then 'home/parcel
            nodeliveryRBTN.Checked = True
        Else
            DTP.Text = DGV.Rows(e.RowIndex).Cells(4).Value
            deliveryRBTN.Checked = True
        End If
        ad_payTF.Text = DGV.Rows(e.RowIndex).Cells(5).Value
        full_payTF.Text = DGV.Rows(e.RowIndex).Cells(6).Value
        qtyTF.Text = DGV.Rows(e.RowIndex).Cells(7).Value
        addTF.Text = DGV.Rows(e.RowIndex).Cells(8).Value
        typeCB.SelectedItem() = DGV.Rows(e.RowIndex).Cells(9).Value
    End Sub

    Sub clear()
        cidTF.Text = ""
        cnameTF.Text = ""
        contactTF.Text = ""
        deliveryRBTN.Checked = False
        nodeliveryRBTN.Checked = False
        ad_payTF.Text = ""
        full_payTF.Text = ""
        qtyTF.Text = ""
        addTF.Text = ""
        typeCB.SelectedItem() = Nothing
        DTP.Visible = False
    End Sub

    Private Sub qtyTF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qtyTF.TextChanged
        If typeCB.SelectedItem = "500 g" Then 'Cake
            full_payTF.Text = 500 * Val(qtyTF.Text)
        ElseIf typeCB.SelectedItem = "750 g" Then
            full_payTF.Text = 800 * Val(qtyTF.Text)
        ElseIf typeCB.SelectedItem = "1 kg" Then
            full_payTF.Text = 1200 * Val(qtyTF.Text)
        ElseIf typeCB.SelectedItem = "2 kg" Then
            full_payTF.Text = 2000 * Val(qtyTF.Text)
        End If
    End Sub

End Class