<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtFatherName = New System.Windows.Forms.TextBox()
        Me.txtMilitaryUnit = New System.Windows.Forms.TextBox()
        Me.txtMilitaryRank = New System.Windows.Forms.TextBox()
        Me.txtDiagnosis = New System.Windows.Forms.TextBox()
        Me.txtDoctorComment = New System.Windows.Forms.TextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.dtpDOMilitary = New System.Windows.Forms.DateTimePicker()
        Me.dtpCheckByMinistry = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "სახელი:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "გვარი:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "მამის სახელი:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 18)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "სამხედრო ნაწილი:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 18)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "სამხედრო წოდება:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 249)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 18)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "დიაგნოზი:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(380, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "დაბადების თარიღი:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(380, 93)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(118, 18)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "გაწვევის თარიღი:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(380, 168)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(223, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "შემოწმებულია სამინისტროს მიერ:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 311)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(122, 18)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "ექიმის კომენტარი:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(180, 22)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(164, 25)
        Me.txtFirstName.TabIndex = 0
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(180, 62)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(164, 25)
        Me.txtLastName.TabIndex = 1
        '
        'txtFatherName
        '
        Me.txtFatherName.Location = New System.Drawing.Point(180, 104)
        Me.txtFatherName.Name = "txtFatherName"
        Me.txtFatherName.Size = New System.Drawing.Size(164, 25)
        Me.txtFatherName.TabIndex = 2
        '
        'txtMilitaryUnit
        '
        Me.txtMilitaryUnit.Location = New System.Drawing.Point(180, 168)
        Me.txtMilitaryUnit.Name = "txtMilitaryUnit"
        Me.txtMilitaryUnit.Size = New System.Drawing.Size(164, 25)
        Me.txtMilitaryUnit.TabIndex = 3
        '
        'txtMilitaryRank
        '
        Me.txtMilitaryRank.Location = New System.Drawing.Point(180, 209)
        Me.txtMilitaryRank.Name = "txtMilitaryRank"
        Me.txtMilitaryRank.Size = New System.Drawing.Size(164, 25)
        Me.txtMilitaryRank.TabIndex = 4
        '
        'txtDiagnosis
        '
        Me.txtDiagnosis.Location = New System.Drawing.Point(180, 249)
        Me.txtDiagnosis.Name = "txtDiagnosis"
        Me.txtDiagnosis.Size = New System.Drawing.Size(164, 25)
        Me.txtDiagnosis.TabIndex = 5
        '
        'txtDoctorComment
        '
        Me.txtDoctorComment.Location = New System.Drawing.Point(28, 345)
        Me.txtDoctorComment.Multiline = True
        Me.txtDoctorComment.Name = "txtDoctorComment"
        Me.txtDoctorComment.Size = New System.Drawing.Size(575, 78)
        Me.txtDoctorComment.TabIndex = 9
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.Green
        Me.btnSave.Font = New System.Drawing.Font("Sylfaen", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(28, 445)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(575, 57)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "შენახვა"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd-MM-yyyy HH:mm"
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOB.Location = New System.Drawing.Point(383, 55)
        Me.dtpDOB.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(200, 25)
        Me.dtpDOB.TabIndex = 6
        '
        'dtpDOMilitary
        '
        Me.dtpDOMilitary.CustomFormat = "dd-MM-yyyy HH:mm"
        Me.dtpDOMilitary.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpDOMilitary.Location = New System.Drawing.Point(383, 129)
        Me.dtpDOMilitary.Name = "dtpDOMilitary"
        Me.dtpDOMilitary.Size = New System.Drawing.Size(200, 25)
        Me.dtpDOMilitary.TabIndex = 7
        '
        'dtpCheckByMinistry
        '
        Me.dtpCheckByMinistry.CustomFormat = "dd-MM-yyyy HH:mm"
        Me.dtpCheckByMinistry.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpCheckByMinistry.Location = New System.Drawing.Point(383, 209)
        Me.dtpCheckByMinistry.Name = "dtpCheckByMinistry"
        Me.dtpCheckByMinistry.Size = New System.Drawing.Size(200, 25)
        Me.dtpCheckByMinistry.TabIndex = 8
        '
        'AddForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 514)
        Me.Controls.Add(Me.dtpCheckByMinistry)
        Me.Controls.Add(Me.dtpDOMilitary)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.txtDoctorComment)
        Me.Controls.Add(Me.txtDiagnosis)
        Me.Controls.Add(Me.txtMilitaryRank)
        Me.Controls.Add(Me.txtMilitaryUnit)
        Me.Controls.Add(Me.txtFatherName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Sylfaen", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "AddForm"
        Me.Text = "პერსონალის დამატება"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtFatherName As TextBox
    Friend WithEvents txtMilitaryUnit As TextBox
    Friend WithEvents txtMilitaryRank As TextBox
    Friend WithEvents txtDiagnosis As TextBox
    Friend WithEvents txtDoctorComment As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents dtpDOB As DateTimePicker
    Friend WithEvents dtpDOMilitary As DateTimePicker
    Friend WithEvents dtpCheckByMinistry As DateTimePicker
End Class
