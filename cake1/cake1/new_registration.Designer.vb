<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class new_registration
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
        Me.passTF = New System.Windows.Forms.TextBox()
        Me.unameTF = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cancelBTN = New System.Windows.Forms.Button()
        Me.signinBTN = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.conpassTF = New System.Windows.Forms.TextBox()
        Me.typeCB = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'passTF
        '
        Me.passTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passTF.Location = New System.Drawing.Point(170, 172)
        Me.passTF.Name = "passTF"
        Me.passTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passTF.Size = New System.Drawing.Size(100, 29)
        Me.passTF.TabIndex = 3
        '
        'unameTF
        '
        Me.unameTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.unameTF.Location = New System.Drawing.Point(170, 126)
        Me.unameTF.Name = "unameTF"
        Me.unameTF.Size = New System.Drawing.Size(100, 29)
        Me.unameTF.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label4.Font = New System.Drawing.Font("Script MT Bold", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(53, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(245, 38)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "New Registration"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(65, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(54, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "User Name :"
        '
        'cancelBTN
        '
        Me.cancelBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBTN.Location = New System.Drawing.Point(208, 277)
        Me.cancelBTN.Name = "cancelBTN"
        Me.cancelBTN.Size = New System.Drawing.Size(75, 38)
        Me.cancelBTN.TabIndex = 6
        Me.cancelBTN.Text = "Cancel"
        Me.cancelBTN.UseVisualStyleBackColor = True
        '
        'signinBTN
        '
        Me.signinBTN.Font = New System.Drawing.Font("Lobster Two", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signinBTN.Location = New System.Drawing.Point(57, 277)
        Me.signinBTN.Name = "signinBTN"
        Me.signinBTN.Size = New System.Drawing.Size(75, 38)
        Me.signinBTN.TabIndex = 5
        Me.signinBTN.Text = "Sign In"
        Me.signinBTN.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-2, 226)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(156, 22)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Confirm Password :"
        '
        'conpassTF
        '
        Me.conpassTF.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.conpassTF.Location = New System.Drawing.Point(170, 223)
        Me.conpassTF.Name = "conpassTF"
        Me.conpassTF.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.conpassTF.Size = New System.Drawing.Size(100, 29)
        Me.conpassTF.TabIndex = 4
        '
        'typeCB
        '
        Me.typeCB.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeCB.FormattingEnabled = True
        Me.typeCB.Items.AddRange(New Object() {"Admin", "Receptionist"})
        Me.typeCB.Location = New System.Drawing.Point(165, 80)
        Me.typeCB.Name = "typeCB"
        Me.typeCB.Size = New System.Drawing.Size(121, 30)
        Me.typeCB.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Palatino Linotype", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 22)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "User type :"
        '
        'new_registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LemonChiffon
        Me.ClientSize = New System.Drawing.Size(355, 398)
        Me.Controls.Add(Me.typeCB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.conpassTF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.passTF)
        Me.Controls.Add(Me.unameTF)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cancelBTN)
        Me.Controls.Add(Me.signinBTN)
        Me.Name = "new_registration"
        Me.Text = "new_registration"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents passTF As System.Windows.Forms.TextBox
    Friend WithEvents unameTF As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cancelBTN As System.Windows.Forms.Button
    Friend WithEvents signinBTN As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents conpassTF As System.Windows.Forms.TextBox
    Friend WithEvents typeCB As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
