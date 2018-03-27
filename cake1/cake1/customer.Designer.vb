<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customer
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cidTF = New System.Windows.Forms.TextBox()
        Me.cnameTF = New System.Windows.Forms.TextBox()
        Me.contactTF = New System.Windows.Forms.TextBox()
        Me.full_payTF = New System.Windows.Forms.TextBox()
        Me.ad_payTF = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DTP = New System.Windows.Forms.DateTimePicker()
        Me.deliveryRBTN = New System.Windows.Forms.RadioButton()
        Me.nodeliveryRBTN = New System.Windows.Forms.RadioButton()
        Me.DGV = New System.Windows.Forms.DataGridView()
        Me.insertBTN = New System.Windows.Forms.Button()
        Me.updateBTN = New System.Windows.Forms.Button()
        Me.deleteBTN = New System.Windows.Forms.Button()
        Me.cancelBTN = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.qtyTF = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.addTF = New System.Windows.Forms.TextBox()
        Me.typeCB = New System.Windows.Forms.ComboBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(81, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Id :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(53, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Customer Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(50, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Contact Number :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(42, 296)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Advance Payment :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(527, 300)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Full Payment :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label6.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(335, 26)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(236, 38)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Customer Details"
        '
        'cidTF
        '
        Me.cidTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cidTF.Location = New System.Drawing.Point(240, 91)
        Me.cidTF.Name = "cidTF"
        Me.cidTF.Size = New System.Drawing.Size(60, 29)
        Me.cidTF.TabIndex = 1
        '
        'cnameTF
        '
        Me.cnameTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cnameTF.Location = New System.Drawing.Point(240, 137)
        Me.cnameTF.Name = "cnameTF"
        Me.cnameTF.Size = New System.Drawing.Size(100, 29)
        Me.cnameTF.TabIndex = 2
        '
        'contactTF
        '
        Me.contactTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactTF.Location = New System.Drawing.Point(240, 191)
        Me.contactTF.Name = "contactTF"
        Me.contactTF.Size = New System.Drawing.Size(100, 29)
        Me.contactTF.TabIndex = 3
        '
        'full_payTF
        '
        Me.full_payTF.Enabled = False
        Me.full_payTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.full_payTF.Location = New System.Drawing.Point(694, 297)
        Me.full_payTF.Name = "full_payTF"
        Me.full_payTF.Size = New System.Drawing.Size(100, 29)
        Me.full_payTF.TabIndex = 9
        '
        'ad_payTF
        '
        Me.ad_payTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ad_payTF.Location = New System.Drawing.Point(240, 293)
        Me.ad_payTF.Name = "ad_payTF"
        Me.ad_payTF.Size = New System.Drawing.Size(100, 29)
        Me.ad_payTF.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DTP)
        Me.Panel1.Controls.Add(Me.deliveryRBTN)
        Me.Panel1.Controls.Add(Me.nodeliveryRBTN)
        Me.Panel1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(546, 95)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(443, 100)
        Me.Panel1.TabIndex = 11
        '
        'DTP
        '
        Me.DTP.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DTP.Location = New System.Drawing.Point(11, 52)
        Me.DTP.Name = "DTP"
        Me.DTP.Size = New System.Drawing.Size(200, 29)
        Me.DTP.TabIndex = 14
        Me.DTP.Value = New Date(2018, 3, 17, 0, 0, 0, 0)
        Me.DTP.Visible = False
        '
        'deliveryRBTN
        '
        Me.deliveryRBTN.AutoSize = True
        Me.deliveryRBTN.Location = New System.Drawing.Point(11, 12)
        Me.deliveryRBTN.Name = "deliveryRBTN"
        Me.deliveryRBTN.Size = New System.Drawing.Size(165, 26)
        Me.deliveryRBTN.TabIndex = 5
        Me.deliveryRBTN.TabStop = True
        Me.deliveryRBTN.Text = "Delivery Required"
        Me.deliveryRBTN.UseVisualStyleBackColor = True
        '
        'nodeliveryRBTN
        '
        Me.nodeliveryRBTN.AutoSize = True
        Me.nodeliveryRBTN.Location = New System.Drawing.Point(212, 12)
        Me.nodeliveryRBTN.Name = "nodeliveryRBTN"
        Me.nodeliveryRBTN.Size = New System.Drawing.Size(197, 26)
        Me.nodeliveryRBTN.TabIndex = 6
        Me.nodeliveryRBTN.TabStop = True
        Me.nodeliveryRBTN.Text = "Delivery Not Required"
        Me.nodeliveryRBTN.UseVisualStyleBackColor = True
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
        Me.DGV.Location = New System.Drawing.Point(0, 389)
        Me.DGV.Name = "DGV"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGV.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DGV.Size = New System.Drawing.Size(1093, 199)
        Me.DGV.TabIndex = 12
        '
        'insertBTN
        '
        Me.insertBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.insertBTN.Location = New System.Drawing.Point(308, 350)
        Me.insertBTN.Name = "insertBTN"
        Me.insertBTN.Size = New System.Drawing.Size(75, 33)
        Me.insertBTN.TabIndex = 10
        Me.insertBTN.Text = "Insert"
        Me.insertBTN.UseVisualStyleBackColor = True
        '
        'updateBTN
        '
        Me.updateBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBTN.Location = New System.Drawing.Point(446, 350)
        Me.updateBTN.Name = "updateBTN"
        Me.updateBTN.Size = New System.Drawing.Size(75, 33)
        Me.updateBTN.TabIndex = 11
        Me.updateBTN.Text = "Update"
        Me.updateBTN.UseVisualStyleBackColor = True
        '
        'deleteBTN
        '
        Me.deleteBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBTN.Location = New System.Drawing.Point(575, 349)
        Me.deleteBTN.Name = "deleteBTN"
        Me.deleteBTN.Size = New System.Drawing.Size(75, 33)
        Me.deleteBTN.TabIndex = 12
        Me.deleteBTN.Text = "Delete"
        Me.deleteBTN.UseVisualStyleBackColor = True
        '
        'cancelBTN
        '
        Me.cancelBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBTN.Location = New System.Drawing.Point(700, 349)
        Me.cancelBTN.Name = "cancelBTN"
        Me.cancelBTN.Size = New System.Drawing.Size(75, 33)
        Me.cancelBTN.TabIndex = 13
        Me.cancelBTN.Text = "Cancel"
        Me.cancelBTN.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(114, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 22)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Address :"
        '
        'qtyTF
        '
        Me.qtyTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.qtyTF.Location = New System.Drawing.Point(694, 254)
        Me.qtyTF.Name = "qtyTF"
        Me.qtyTF.Size = New System.Drawing.Size(100, 29)
        Me.qtyTF.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(558, 257)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(85, 22)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Quantity :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(545, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 22)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Cake Type :"
        '
        'addTF
        '
        Me.addTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addTF.Location = New System.Drawing.Point(240, 236)
        Me.addTF.Multiline = True
        Me.addTF.Name = "addTF"
        Me.addTF.Size = New System.Drawing.Size(173, 51)
        Me.addTF.TabIndex = 4
        '
        'typeCB
        '
        Me.typeCB.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeCB.FormattingEnabled = True
        Me.typeCB.Items.AddRange(New Object() {"500 g", "750 g", "1 kg", "2 kg"})
        Me.typeCB.Location = New System.Drawing.Point(694, 207)
        Me.typeCB.Name = "typeCB"
        Me.typeCB.Size = New System.Drawing.Size(100, 30)
        Me.typeCB.TabIndex = 7
        '
        'customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(1093, 588)
        Me.Controls.Add(Me.typeCB)
        Me.Controls.Add(Me.addTF)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.qtyTF)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cancelBTN)
        Me.Controls.Add(Me.deleteBTN)
        Me.Controls.Add(Me.updateBTN)
        Me.Controls.Add(Me.insertBTN)
        Me.Controls.Add(Me.DGV)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ad_payTF)
        Me.Controls.Add(Me.full_payTF)
        Me.Controls.Add(Me.contactTF)
        Me.Controls.Add(Me.cnameTF)
        Me.Controls.Add(Me.cidTF)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "customer"
        Me.Text = "customer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cidTF As System.Windows.Forms.TextBox
    Friend WithEvents cnameTF As System.Windows.Forms.TextBox
    Friend WithEvents contactTF As System.Windows.Forms.TextBox
    Friend WithEvents full_payTF As System.Windows.Forms.TextBox
    Friend WithEvents ad_payTF As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents deliveryRBTN As System.Windows.Forms.RadioButton
    Friend WithEvents nodeliveryRBTN As System.Windows.Forms.RadioButton
    Friend WithEvents DGV As System.Windows.Forms.DataGridView
    Friend WithEvents insertBTN As System.Windows.Forms.Button
    Friend WithEvents updateBTN As System.Windows.Forms.Button
    Friend WithEvents deleteBTN As System.Windows.Forms.Button
    Friend WithEvents cancelBTN As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents qtyTF As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents addTF As System.Windows.Forms.TextBox
    Friend WithEvents typeCB As System.Windows.Forms.ComboBox
End Class
