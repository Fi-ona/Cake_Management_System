<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Signin
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
        Me.signinBTN = New System.Windows.Forms.Button()
        Me.cancelBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.typeCB = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.unameTF = New System.Windows.Forms.TextBox()
        Me.passTF = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'signinBTN
        '
        Me.signinBTN.BackColor = System.Drawing.SystemColors.Control
        Me.signinBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signinBTN.ForeColor = System.Drawing.SystemColors.InfoText
        Me.signinBTN.Location = New System.Drawing.Point(80, 316)
        Me.signinBTN.Name = "signinBTN"
        Me.signinBTN.Size = New System.Drawing.Size(103, 30)
        Me.signinBTN.TabIndex = 0
        Me.signinBTN.Text = "Sign Up"
        Me.signinBTN.UseVisualStyleBackColor = False
        '
        'cancelBTN
        '
        Me.cancelBTN.BackColor = System.Drawing.SystemColors.Control
        Me.cancelBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBTN.ForeColor = System.Drawing.SystemColors.InfoText
        Me.cancelBTN.Location = New System.Drawing.Point(269, 316)
        Me.cancelBTN.Name = "cancelBTN"
        Me.cancelBTN.Size = New System.Drawing.Size(87, 30)
        Me.cancelBTN.TabIndex = 1
        Me.cancelBTN.Text = "Cancel"
        Me.cancelBTN.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(77, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User type :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 186)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "User Name :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.LemonChiffon
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(77, 236)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password :"
        '
        'typeCB
        '
        Me.typeCB.BackColor = System.Drawing.SystemColors.Control
        Me.typeCB.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeCB.FormattingEnabled = True
        Me.typeCB.Items.AddRange(New Object() {"Admin", "Receptionist"})
        Me.typeCB.Location = New System.Drawing.Point(187, 140)
        Me.typeCB.Name = "typeCB"
        Me.typeCB.Size = New System.Drawing.Size(116, 25)
        Me.typeCB.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(133, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 40)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Sign In"
        '
        'unameTF
        '
        Me.unameTF.BackColor = System.Drawing.SystemColors.Control
        Me.unameTF.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unameTF.Location = New System.Drawing.Point(187, 187)
        Me.unameTF.Name = "unameTF"
        Me.unameTF.Size = New System.Drawing.Size(116, 24)
        Me.unameTF.TabIndex = 7
        '
        'passTF
        '
        Me.passTF.BackColor = System.Drawing.SystemColors.Control
        Me.passTF.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passTF.Location = New System.Drawing.Point(187, 237)
        Me.passTF.Name = "passTF"
        Me.passTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTF.Size = New System.Drawing.Size(116, 24)
        Me.passTF.TabIndex = 8
        '
        'Signin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(425, 406)
        Me.Controls.Add(Me.passTF)
        Me.Controls.Add(Me.unameTF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.typeCB)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelBTN)
        Me.Controls.Add(Me.signinBTN)
        Me.Font = New System.Drawing.Font("Script MT Bold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "Signin"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents signinBTN As System.Windows.Forms.Button
    Friend WithEvents cancelBTN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents typeCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents unameTF As System.Windows.Forms.TextBox
    Friend WithEvents passTF As System.Windows.Forms.TextBox

End Class
