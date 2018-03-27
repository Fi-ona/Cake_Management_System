Imports System.Data
Imports System.Data.SqlClient

Public Class order

    Dim payment, type As String
    Dim date1 As Date = Date.Today
    Dim delivery As String = "No"

    Dim cn As New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\divya\OneDrive\Documents\cake.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")

    Private Sub cancelBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancelBTN.Click
        If Signin.typeCB.SelectedItem = "Admin" Then
            Admin_main.Show()
        ElseIf Signin.typeCB.SelectedItem = "Receptionist" Then
            Receptionist_main.Show()
        End If
        Me.Close()
    End Sub

    Private Sub insertBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles insertBTN.Click
        cn.Open()
        If yesRBTN.Checked = True Then

            'If Signin.typeCB.SelectedItem = "Admin" Then

            Dim cmd As New SqlCommand("insert into order1(c_id, p_type, p_subtype, amt, qty, o_date, delivery, del_date, del_type, del_add, payment_method) values('" & cidTF.Text & "', '" & type1CB.SelectedItem() & "', '" & type2CB.SelectedItem() & "', '" & amtTF.Text & "', '" & qtyTF.Text & "', '" & date1 & "', '" & delivery & "', '" & DTP.Text & "', '" & type & "', '" & addTF.Text & "', '" & payment & "')", cn)
            cmd.ExecuteNonQuery()

        Else
            Dim cmd As New SqlCommand
            cmd.CommandText = "insert into order1(c_id, p_type, p_subtype, amt, qty, o_date, delivery,del_type, payment_method) values('" & cidTF.Text & "', '" & type1CB.SelectedItem & "', '" & type2CB.SelectedItem & "', '" & amtTF.Text & "', '" & qtyTF.Text & "', '" & date1 & "', '" & delivery & "',' NO ', '" & payment & "')"
            cmd.Connection = cn
            cmd.ExecuteNonQuery()

        End If
        MsgBox("Data entered successfully", MsgBoxStyle.Information, "Data inserted") 'inserted
        'cmd.ExecuteNonQuery()
        'Dim update As New SqlCommand("select qty-'" & qtyTF.Text & "' from product where p_type='" & type1CB.SelectedItem() & "' and p_subtype='" & type2CB.SelectedItem() & "' ", cn)
        'update.ExecuteNonQuery()
        'MsgBox("Updated")
        'ElseIf Signin.typeCB.SelectedItem = "Receptionist" Then
        'End If

        'update starts

        'Dim cmd As New SqlCommand
        'cmd.Connection = cn
        'cmd.CommandText = "select qty from poduct where ptype='" & type1CB.SelectedItem & "' and p_subtype = '" & type2CB.SelectedItem & "'"

        'Dim temp As Integer = cmd.ExecuteReader

        'Dim update1 As New SqlCommand("select qty from product where qty is null or qty<'" & qtyTF.Text & "' ", cn)
        'Dim dr As SqlDataReader
        'dr = update1.ExecuteReader()
        'If dr.Read() = 1 Then
        '    MsgBox("Product is over...")
        'Else
        Dim update As New SqlCommand("update product set qty=qty-'" & qtyTF.Text & "' where p_type='" & type1CB.SelectedItem & "' and p_subtype='" & type2CB.SelectedItem & "' ", cn)
        update.ExecuteNonQuery()
        ' End If

        cn.Close()
        grid()
        clear()
    End Sub

    Private Sub type1CB_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles type1CB.SelectedIndexChanged
        type2CB.Visible = True

        If type1CB.SelectedItem = "Cake" Then
            type2CB.Items.Clear()
            type2CB.Items.Add("500 g")
            type2CB.Items.Add("750 g")
            type2CB.Items.Add("1 kg")
            type2CB.Items.Add("2 kg")
        ElseIf type1CB.SelectedItem = "Pastry" Then
            type2CB.Items.Clear()
            type2CB.Items.Add("Black Current")
            type2CB.Items.Add("Chocolate Truffle")
            type2CB.Items.Add("Vanilla")
            type2CB.Items.Add("Strawberry")
        ElseIf type1CB.SelectedItem = "Bar Cake" Then
            type2CB.Items.Clear()
            type2CB.Items.Add("Chocolate")
            type2CB.Items.Add("Vanilla")
        ElseIf type1CB.SelectedItem = "Plum Cake" Then
            type2CB.Items.Clear()
            type2CB.Items.Add("Swiss Roll")
            type2CB.Items.Add("Rich Roll")
        ElseIf type1CB.SelectedItem = "Muffins" Then
            type2CB.Items.Clear()
            type2CB.Items.Add("Chocolate")
            type2CB.Items.Add("Vanilla")
        End If
    End Sub

    Sub grid()
        cn.Open()
        Dim adp As New SqlDataAdapter("select o_id as 'Order ID', c_id as 'Customer ID', p_type as 'Product Type', p_subtype as 'Product SubType', amt as 'Amount', qty as 'Quantity', o_date as 'Order Type', delivery as 'Delivery', del_date as 'Delivery Date', del_type as 'Delivery Type', del_add as 'Delivery Address', payment_method as 'Payment Method' from order1", cn)
        Dim ds As New DataSet
        '  ds.Clear()
        adp.Fill(ds, "order1")
        DGV.DataSource = ds.Tables("order1")
        cn.Close()
    End Sub

    Private Sub order_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grid()
        dateTF.Text = date1
        'Label5.Text = Format(DTP.Value, "dd/mm/yyyy")
        
    End Sub

    Sub clear()
        o_idTF.Text = ""
        cidTF.Text = ""
        amtTF.Text = ""
        qtyTF.Text = ""
        dateTF.Text = ""
        addTF.Text = ""
        type1CB.SelectedItem = Nothing
        type2CB.SelectedItem = Nothing
        yesRBTN.Checked = False
        noRBTN.Checked = False
        homeRBTN.Checked = False
        parcelRBTN.Checked = False
        cardRBTN.Checked = False
        cashRBTN.Checked = False
    End Sub

    Private Sub updateBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles updateBTN.Click
        cn.Open()
        Dim cmd As New SqlCommand("update order1 set p_type='" & type1CB.SelectedItem() & "', p_subtype='" & type2CB.SelectedItem() & "', amt='" & amtTF.Text & "', qty=" & qtyTF.Text & ", o_date='" & date1 & "', delivery='" & delivery & "', del_date='" & DTP.Text & "', del_type='" & type & "', del_add='" & addTF.Text & "', payment_method='" & payment & "' where o_id=" & o_idTF.Text & " ", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Data updated successfully", MsgBoxStyle.Information, "Data updated")
        cn.Close()
        grid()
        clear()
    End Sub

    Private Sub DGV_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGV.CellClick
        o_idTF.Text = DGV.Rows(e.RowIndex).Cells(0).Value 'order id
        cidTF.Text = DGV.Rows(e.RowIndex).Cells(1).Value 'customer id
        type1CB.SelectedItem = DGV.Rows(e.RowIndex).Cells(2).Value 'type1
        type2CB.SelectedItem = DGV.Rows(e.RowIndex).Cells(3).Value 'type2
        amtTF.Text = DGV.Rows(e.RowIndex).Cells(4).Value 'amount
        qtyTF.Text = DGV.Rows(e.RowIndex).Cells(5).Value 'quantity
        dateTF.Text = DGV.Rows(e.RowIndex).Cells(6).Value 'current date
        If DGV.Rows(e.RowIndex).Cells(7).Value = "yes" Then 'yes/no
            yesRBTN.Checked = True
            typeP.Show()
            DTP.Visible = True
            DTP.Text = DGV.Rows(e.RowIndex).Cells(8).Value 'delivery date
            'ElseIf DGV.Rows(e.RowIndex).Cells(9).Value = "No" Then
        Else
            noRBTN.Checked = True
            addTF.Visible = False
            addLBL.Visible = False
        End If
        If DGV.Rows(e.RowIndex).Cells(9).Value = "Home" Then 'home/parcel
            homeRBTN.Checked = True
            addTF.Text = DGV.Rows(e.RowIndex).Cells(10).Value 'address
        ElseIf DGV.Rows(e.RowIndex).Cells(9).Value = "NO" Then
            GoTo ABC
        Else
            parcelRBTN.Checked = True
            addTF.Visible = False
            addLBL.Visible = False
        End If
ABC:
        If DGV.Rows(e.RowIndex).Cells(11).Value = "Card" Then 'card/cash
            cardRBTN.Checked = True
        Else
            cashRBTN.Checked = True
        End If
    End Sub

    Private Sub deleteBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteBTN.Click
        cn.Open()
        Dim cmd As New SqlCommand("delete from order1 where o_id=" & o_idTF.Text & " ", cn)
        cmd.ExecuteNonQuery()
        MsgBox("Data deleted successfully", MsgBoxStyle.Information, "Data deleted")
        cn.Close()
        grid()
        clear()
    End Sub

    Private Sub yesRBTN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles yesRBTN.CheckedChanged
        If yesRBTN.Checked = True Then
            del_dateLBL.Visible = True
            DTP.Visible = True
            typeP.Visible = True
            delivery = "yes"
        Else
            del_dateLBL.Visible = False
            DTP.Visible = False
            typeP.Visible = False
            delivery = "No"
        End If
    End Sub

    Private Sub homeRBTN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles homeRBTN.CheckedChanged
        If homeRBTN.Checked = True Then
            addLBL.Visible = True
            addTF.Visible = True
            type = "Home"
        Else
            addLBL.Visible = False
            addTF.Visible = False
            type = "Parcel"
        End If
    End Sub

    Private Sub noRBTN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles noRBTN.CheckedChanged
        delivery = "No"
    End Sub

    Private Sub parcelRBTN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parcelRBTN.CheckedChanged
        type = "Parcel"
    End Sub

    Private Sub cardRBTN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cardRBTN.CheckedChanged
        payment = "Card"
    End Sub

    Private Sub cashRBTN_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cashRBTN.CheckedChanged
        payment = "Cash"
    End Sub

    Private Sub qtyTF_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles qtyTF.TextChanged

        If type2CB.SelectedItem = "500 g" Then 'Cake
            amtTF.Text = 500 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "750 g" Then
            amtTF.Text = 800 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "1 kg" Then
            amtTF.Text = 1200 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "2 kg" Then
            amtTF.Text = 2000 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Chocolate" Then 'Muffins
            amtTF.Text = 10 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Vanilla" Then
            amtTF.Text = 10 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Chocolate" Then 'Bar Cake
            amtTF.Text = 10 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Vanilla" Then
            amtTF.Text = 10 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Swiss Roll" Then 'Plum Cake
            amtTF.Text = 20 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Rich Roll" Then
            amtTF.Text = 20 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Black Current" Then 'Pastry
            amtTF.Text = 60 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Strawberry" Then
            amtTF.Text = 60 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Vanilla" Then
            amtTF.Text = 60 * Val(qtyTF.Text)
        ElseIf type2CB.SelectedItem = "Chocolate Truffle" Then
            amtTF.Text = 60 * Val(qtyTF.Text)
        End If
    End Sub
End Class