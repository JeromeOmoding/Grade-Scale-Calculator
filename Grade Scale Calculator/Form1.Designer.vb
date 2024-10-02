<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        lblGrade = New Label()
        lblEnterMarks = New Label()
        txtEnterMarks = New TextBox()
        txtGrade = New TextBox()
        btnEvaluate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(249, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(187, 25)
        Label1.TabIndex = 0
        Label1.Text = "Grade Scale Calculator"
        ' 
        ' lblGrade
        ' 
        lblGrade.AutoSize = True
        lblGrade.Location = New Point(53, 176)
        lblGrade.Name = "lblGrade"
        lblGrade.Size = New Size(59, 25)
        lblGrade.TabIndex = 1
        lblGrade.Text = "Grade"
        ' 
        ' lblEnterMarks
        ' 
        lblEnterMarks.AutoSize = True
        lblEnterMarks.Location = New Point(44, 93)
        lblEnterMarks.Name = "lblEnterMarks"
        lblEnterMarks.Size = New Size(105, 25)
        lblEnterMarks.TabIndex = 2
        lblEnterMarks.Text = "Enter Marks"
        ' 
        ' txtEnterMarks
        ' 
        txtEnterMarks.Location = New Point(206, 102)
        txtEnterMarks.Name = "txtEnterMarks"
        txtEnterMarks.Size = New Size(247, 31)
        txtEnterMarks.TabIndex = 3
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(213, 185)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(251, 31)
        txtGrade.TabIndex = 4
        ' 
        ' btnEvaluate
        ' 
        btnEvaluate.Location = New Point(211, 273)
        btnEvaluate.Name = "btnEvaluate"
        btnEvaluate.Size = New Size(395, 79)
        btnEvaluate.TabIndex = 5
        btnEvaluate.Text = "Evaluate"
        btnEvaluate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Highlight
        ClientSize = New Size(800, 450)
        Controls.Add(btnEvaluate)
        Controls.Add(txtGrade)
        Controls.Add(txtEnterMarks)
        Controls.Add(lblEnterMarks)
        Controls.Add(lblGrade)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Omoding Jerome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblGrade As Label
    Friend WithEvents lblEnterMarks As Label
    Friend WithEvents txtEnterMarks As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnEvaluate As Button

End Class
