<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.insertBTN = New System.Windows.Forms.Button()
        Me.updateBTN = New System.Windows.Forms.Button()
        Me.deleteBTN = New System.Windows.Forms.Button()
        Me.cancelBTN = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cardRBTN = New System.Windows.Forms.RadioButton()
        Me.cashRBTN = New System.Windows.Forms.RadioButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cidTF = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.type1CB = New System.Windows.Forms.ComboBox()
        Me.type2CB = New System.Windows.Forms.ComboBox()
        Me.dateTF = New System.Windows.Forms.TextBox()
        Me.o_idTF = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.addTF = New System.Windows.Forms.TextBox()
        Me.addLBL = New System.Windows.Forms.Label()
        Me.del_dateLBL = New System.Windows.Forms.Label()
        Me.typeP = New System.Windows.Forms.Panel()
        Me.homeRBTN = New System.Windows.Forms.RadioButton()
        Me.parcelRBTN = New System.Windows.Forms.RadioButton()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.deliveryP = New System.Windows.Forms.Panel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.noRBTN = New System.Windows.Forms.RadioButton()
        Me.yesRBTN = New System.Windows.Forms.RadioButton()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.typeLBL = New System.Windows.Forms.Label()
        Me.qtyTF = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.amtTF = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.typeP.SuspendLayout()
        Me.deliveryP.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(512, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(186, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Ordering List"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(32, 133)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Product Type :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(452, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Date :"
        '
        'DGV
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DGV.DefaultCellStyle = DataGridViewCellStyle2
        Me.DGV.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DGV.Location = New System.Drawing.Point(0, 365)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV.Size = New System.Drawing.Size(1150, 265)
        Me.DGV.TabIndex = 13
        '
        'insertBTN
        '
        Me.insertBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertBTN.Location = New System.Drawing.Point(269, 320)
        Me.insertBTN.Name = "insertBTN"
        Me.insertBTN.Size = New System.Drawing.Size(75, 39)
        Me.insertBTN.TabIndex = 14
        Me.insertBTN.Text = "Insert"
        Me.insertBTN.UseVisualStyleBackColor = True
        '
        'updateBTN
        '
        Me.updateBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBTN.Location = New System.Drawing.Point(386, 320)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Size = New System.Drawing.Size(75, 39)
        Me.updateBTN.TabIndex = 15
        Me.updateBTN.Text = "Update"
        Me.updateBTN.UseVisualStyleBackColor = True
        '
        'deleteBTN
        '
        Me.deleteBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBTN.Location = New System.Drawing.Point(519, 320)
        Me.deleteBTN.Name = "deleteBTN"
        Me.deleteBTN.Size = New System.Drawing.Size(75, 39)
        Me.deleteBTN.TabIndex = 16
        Me.deleteBTN.Text = "Delete"
        Me.deleteBTN.UseVisualStyleBackColor = True
        '
        'cancelBTN
        '
        Me.cancelBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBTN.Location = New System.Drawing.Point(651, 320)
        Me.cancelBTN.Name = "cancelBTN"
        Me.cancelBTN.Size = New System.Drawing.Size(75, 39)
        Me.cancelBTN.TabIndex = 17
        Me.cancelBTN.Text = "Cancel"
        Me.cancelBTN.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(7, 255)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(146, 22)
        Me.Label8.TabIndex = 36
        Me.Label8.Text = "Payment Method :"
        '
        'cardRBTN
        '
        Me.cardRBTN.AutoSize = True
        Me.cardRBTN.Location = New System.Drawing.Point(9, 13)
        Me.cardRBTN.Name = "cardRBTN"
        Me.cardRBTN.Size = New System.Drawing.Size(117, 26)
        Me.cardRBTN.TabIndex = 5
        Me.cardRBTN.TabStop = True
        Me.cardRBTN.Text = "Credit Card"
        Me.cardRBTN.UseVisualStyleBackColor = True
        '
        'cashRBTN
        '
        Me.cashRBTN.AutoSize = True
        Me.cashRBTN.Location = New System.Drawing.Point(132, 13)
        Me.cashRBTN.Name = "cashRBTN"
        Me.cashRBTN.Size = New System.Drawing.Size(65, 26)
        Me.cashRBTN.TabIndex = 6
        Me.cashRBTN.TabStop = True
        Me.cashRBTN.Text = "Cash"
        Me.cashRBTN.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cashRBTN)
        Me.Panel3.Controls.Add(Me.cardRBTN)
        Me.Panel3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(168, 240)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(213, 47)
        Me.Panel3.TabIndex = 42
        '
        'cidTF
        '
        Me.cidTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cidTF.Location = New System.Drawing.Point(165, 77)
        Me.cidTF.Name = "cidTF"
        Me.cidTF.Size = New System.Drawing.Size(57, 29)
        Me.cidTF.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(39, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 22)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Customer Id :"
        '
        'type1CB
        '
        Me.type1CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.type1CB.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type1CB.FormattingEnabled = True
        Me.type1CB.Items.AddRange(New Object() {"Cake", "Pastry", "Bar Cake", "Plum Cake", "Muffins"})
        Me.type1CB.Location = New System.Drawing.Point(165, 130)
        Me.type1CB.Name = "type1CB"
        Me.type1CB.Size = New System.Drawing.Size(121, 30)
        Me.type1CB.TabIndex = 2
        '
        'type2CB
        '
        Me.type2CB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.type2CB.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type2CB.FormattingEnabled = True
        Me.type2CB.Location = New System.Drawing.Point(319, 130)
        Me.type2CB.Name = "type2CB"
        Me.type2CB.Size = New System.Drawing.Size(121, 30)
        Me.type2CB.TabIndex = 3
        Me.type2CB.Visible = False
        '
        'dateTF
        '
        Me.dateTF.Enabled = False
        Me.dateTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateTF.Location = New System.Drawing.Point(519, 76)
        Me.dateTF.Name = "dateTF"
        Me.dateTF.Size = New System.Drawing.Size(100, 29)
        Me.dateTF.TabIndex = 49
        '
        'o_idTF
        '
        Me.o_idTF.Enabled = False
        Me.o_idTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.o_idTF.Location = New System.Drawing.Point(357, 77)
        Me.o_idTF.Name = "o_idTF"
        Me.o_idTF.Size = New System.Drawing.Size(52, 29)
        Me.o_idTF.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(268, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(83, 22)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Order Id :"
        '
        'addTF
        '
        Me.addTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTF.Location = New System.Drawing.Point(914, 202)
        Me.addTF.Multiline = True
        Me.addTF.Name = "addTF"
        Me.addTF.Size = New System.Drawing.Size(200, 75)
        Me.addTF.TabIndex = 57
        Me.addTF.Visible = False
        '
        'addLBL
        '
        Me.addLBL.AutoSize = True
        Me.addLBL.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addLBL.Location = New System.Drawing.Point(911, 177)
        Me.addLBL.Name = "addLBL"
        Me.addLBL.Size = New System.Drawing.Size(79, 22)
        Me.addLBL.TabIndex = 56
        Me.addLBL.Text = "Address :"
        Me.addLBL.Visible = False
        '
        'del_dateLBL
        '
        Me.del_dateLBL.AutoSize = True
        Me.del_dateLBL.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.del_dateLBL.Location = New System.Drawing.Point(911, 69)
        Me.del_dateLBL.Name = "del_dateLBL"
        Me.del_dateLBL.Size = New System.Drawing.Size(121, 22)
        Me.del_dateLBL.TabIndex = 54
        Me.del_dateLBL.Text = "Delivery Date :"
        Me.del_dateLBL.Visible = False
        '
        'typeP
        '
        Me.typeP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.typeP.Controls.Add(Me.homeRBTN)
        Me.typeP.Controls.Add(Me.parcelRBTN)
        Me.typeP.Controls.Add(Me.Label13)
        Me.typeP.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeP.Location = New System.Drawing.Point(708, 186)
        Me.typeP.Name = "typeP"
        Me.typeP.Size = New System.Drawing.Size(184, 90)
        Me.typeP.TabIndex = 53
        Me.typeP.Visible = False
        '
        'homeRBTN
        '
        Me.homeRBTN.AutoSize = True
        Me.homeRBTN.Location = New System.Drawing.Point(9, 30)
        Me.homeRBTN.Name = "homeRBTN"
        Me.homeRBTN.Size = New System.Drawing.Size(73, 26)
        Me.homeRBTN.TabIndex = 3
        Me.homeRBTN.TabStop = True
        Me.homeRBTN.Text = "Home"
        Me.homeRBTN.UseVisualStyleBackColor = True
        '
        'parcelRBTN
        '
        Me.parcelRBTN.AutoSize = True
        Me.parcelRBTN.Location = New System.Drawing.Point(9, 53)
        Me.parcelRBTN.Name = "parcelRBTN"
        Me.parcelRBTN.Size = New System.Drawing.Size(72, 26)
        Me.parcelRBTN.TabIndex = 4
        Me.parcelRBTN.TabStop = True
        Me.parcelRBTN.Text = "Parcel"
        Me.parcelRBTN.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(11, 9)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(140, 22)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "Type of delivery :"
        '
        'deliveryP
        '
        Me.deliveryP.AccessibleName = ""
        Me.deliveryP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.deliveryP.Controls.Add(Me.Label14)
        Me.deliveryP.Controls.Add(Me.noRBTN)
        Me.deliveryP.Controls.Add(Me.yesRBTN)
        Me.deliveryP.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deliveryP.Location = New System.Drawing.Point(708, 75)
        Me.deliveryP.Name = "deliveryP"
        Me.deliveryP.Size = New System.Drawing.Size(184, 86)
        Me.deliveryP.TabIndex = 52
        Me.deliveryP.Tag = ""
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(10, 12)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(158, 22)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Delivery Required ?"
        '
        'noRBTN
        '
        Me.noRBTN.AutoSize = True
        Me.noRBTN.Location = New System.Drawing.Point(13, 51)
        Me.noRBTN.Name = "noRBTN"
        Me.noRBTN.Size = New System.Drawing.Size(50, 26)
        Me.noRBTN.TabIndex = 8
        Me.noRBTN.Text = "No"
        Me.noRBTN.UseVisualStyleBackColor = True
        '
        'yesRBTN
        '
        Me.yesRBTN.AutoSize = True
        Me.yesRBTN.Location = New System.Drawing.Point(13, 28)
        Me.yesRBTN.Name = "yesRBTN"
        Me.yesRBTN.Size = New System.Drawing.Size(53, 26)
        Me.yesRBTN.TabIndex = 7
        Me.yesRBTN.Text = "Yes"
        Me.yesRBTN.UseVisualStyleBackColor = True
        '
        'DTP
        '
        Me.DTP.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(914, 94)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(200, 29)
        Me.DTP.TabIndex = 58
        Me.DTP.Value = New Date(2018, 3, 17, 0, 0, 0, 0)
        Me.DTP.Visible = False
        '
        'typeLBL
        '
        Me.typeLBL.AutoSize = True
        Me.typeLBL.Location = New System.Drawing.Point(556, 306)
        Me.typeLBL.Name = "typeLBL"
        Me.typeLBL.Size = New System.Drawing.Size(0, 13)
        Me.typeLBL.TabIndex = 59
        '
        'qtyTF
        '
        Me.qtyTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyTF.Location = New System.Drawing.Point(165, 189)
        Me.qtyTF.Name = "qtyTF"
        Me.qtyTF.Size = New System.Drawing.Size(100, 29)
        Me.qtyTF.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(76, 189)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 22)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "Quatity :"
        '
        'amtTF
        '
        Me.amtTF.Enabled = False
        Me.amtTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amtTF.Location = New System.Drawing.Point(456, 189)
        Me.amtTF.Name = "amtTF"
        Me.amtTF.Size = New System.Drawing.Size(100, 29)
        Me.amtTF.TabIndex = 65
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(331, 192)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 22)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Total Amount :"
        '
        'order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1150, 630)
        Me.Controls.Add(Me.amtTF)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.qtyTF)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.typeLBL)
        Me.Controls.Add(Me.DTP)
        Me.Controls.Add(Me.addTF)
        Me.Controls.Add(Me.addLBL)
        Me.Controls.Add(Me.del_dateLBL)
        Me.Controls.Add(Me.typeP)
        Me.Controls.Add(Me.deliveryP)
        Me.Controls.Add(Me.o_idTF)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dateTF)
        Me.Controls.Add(Me.type2CB)
        Me.Controls.Add(Me.type1CB)
        Me.Controls.Add(Me.cidTF)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cancelBTN)
        Me.Controls.Add(Me.deleteBTN)
        Me.Controls.Add(Me.updateBTN)
        Me.Controls.Add(Me.insertBTN)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "order"
        Me.Text = "order"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.typeP.ResumeLayout(False)
        Me.typeP.PerformLayout()
        Me.deliveryP.ResumeLayout(False)
        Me.deliveryP.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents insertBTN As System.Windows.Forms.Button
    Friend WithEvents updateBTN As System.Windows.Forms.Button
    Friend WithEvents deleteBTN As System.Windows.Forms.Button
    Friend WithEvents cancelBTN As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cardRBTN As System.Windows.Forms.RadioButton
    Friend WithEvents cashRBTN As System.Windows.Forms.RadioButton
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents cidTF As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents type1CB As System.Windows.Forms.ComboBox
    Friend WithEvents type2CB As System.Windows.Forms.ComboBox
    Friend WithEvents dateTF As System.Windows.Forms.TextBox
    Friend WithEvents o_idTF As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents addTF As System.Windows.Forms.TextBox
    Friend WithEvents addLBL As System.Windows.Forms.Label
    Friend WithEvents del_dateLBL As System.Windows.Forms.Label
    Friend WithEvents typeP As System.Windows.Forms.Panel
    Friend WithEvents homeRBTN As System.Windows.Forms.RadioButton
    Friend WithEvents parcelRBTN As System.Windows.Forms.RadioButton
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents deliveryP As System.Windows.Forms.Panel
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents noRBTN As System.Windows.Forms.RadioButton
    Friend WithEvents yesRBTN As System.Windows.Forms.RadioButton
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents typeLBL As System.Windows.Forms.Label
    Friend WithEvents qtyTF As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents amtTF As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
