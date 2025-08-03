<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnCalculate = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        lblMonthlyPayment = New Label()
        lblTotalInterest = New Label()
        lblTotalPayment = New Label()
        Label4 = New Label()
        txtLoanAmount = New TextBox()
        txtInterestRate = New TextBox()
        Label5 = New Label()
        Label6 = New Label()
        txtLoanTerm = New TextBox()
        SuspendLayout()
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalculate.Location = New Point(218, 352)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(274, 49)
        btnCalculate.TabIndex = 0
        btnCalculate.Text = "Calculate Loan"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(152, 199)
        Label1.Name = "Label1"
        Label1.Size = New Size(164, 25)
        Label1.TabIndex = 1
        Label1.Text = "Monthly Payment"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(152, 243)
        Label2.Name = "Label2"
        Label2.Size = New Size(125, 25)
        Label2.TabIndex = 1
        Label2.Text = "Total Interest"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(152, 287)
        Label3.Name = "Label3"
        Label3.Size = New Size(134, 25)
        Label3.TabIndex = 1
        Label3.Text = "Total Payment"
        ' 
        ' lblMonthlyPayment
        ' 
        lblMonthlyPayment.BackColor = Color.White
        lblMonthlyPayment.BorderStyle = BorderStyle.FixedSingle
        lblMonthlyPayment.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblMonthlyPayment.Location = New Point(353, 199)
        lblMonthlyPayment.Name = "lblMonthlyPayment"
        lblMonthlyPayment.Size = New Size(164, 25)
        lblMonthlyPayment.TabIndex = 1
        ' 
        ' lblTotalInterest
        ' 
        lblTotalInterest.BackColor = Color.White
        lblTotalInterest.BorderStyle = BorderStyle.FixedSingle
        lblTotalInterest.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalInterest.Location = New Point(353, 243)
        lblTotalInterest.Name = "lblTotalInterest"
        lblTotalInterest.Size = New Size(164, 25)
        lblTotalInterest.TabIndex = 1
        ' 
        ' lblTotalPayment
        ' 
        lblTotalPayment.BackColor = Color.White
        lblTotalPayment.BorderStyle = BorderStyle.FixedSingle
        lblTotalPayment.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblTotalPayment.Location = New Point(353, 287)
        lblTotalPayment.Name = "lblTotalPayment"
        lblTotalPayment.Size = New Size(164, 25)
        lblTotalPayment.TabIndex = 1
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(152, 58)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 25)
        Label4.TabIndex = 1
        Label4.Text = "Loan Amount"
        ' 
        ' txtLoanAmount
        ' 
        txtLoanAmount.Location = New Point(354, 59)
        txtLoanAmount.Name = "txtLoanAmount"
        txtLoanAmount.Size = New Size(172, 27)
        txtLoanAmount.TabIndex = 2
        ' 
        ' txtInterestRate
        ' 
        txtInterestRate.Location = New Point(354, 94)
        txtInterestRate.Name = "txtInterestRate"
        txtInterestRate.Size = New Size(172, 27)
        txtInterestRate.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(152, 93)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 25)
        Label5.TabIndex = 1
        Label5.Text = "Interest"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(152, 130)
        Label6.Name = "Label6"
        Label6.Size = New Size(100, 25)
        Label6.TabIndex = 1
        Label6.Text = "Loan Term"
        ' 
        ' txtLoanTerm
        ' 
        txtLoanTerm.Location = New Point(354, 127)
        txtLoanTerm.Name = "txtLoanTerm"
        txtLoanTerm.Size = New Size(172, 27)
        txtLoanTerm.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtLoanTerm)
        Controls.Add(txtInterestRate)
        Controls.Add(txtLoanAmount)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblTotalPayment)
        Controls.Add(lblTotalInterest)
        Controls.Add(lblMonthlyPayment)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label1)
        Controls.Add(btnCalculate)
        Name = "Form1"
        Text = "Loan Caculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblMonthlyPayment As Label
    Friend WithEvents lblTotalInterest As Label
    Friend WithEvents lblTotalPayment As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtLoanTerm As TextBox

End Class
