Imports Microsoft.VisualBasic
Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label4.Click, Label5.Click, Label6.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim loanAmount As Double
        Dim annualRate, monthlyRate As Double
        Dim loanTermYears, loanTermMonths As Integer
        Dim monthlyPayment As Double

        ' Get user input
        If Not Double.TryParse(txtLoanAmount.Text, loanAmount) Then
            MessageBox.Show("Please enter a valid loan amount")
            Return
        End If

        If Not Double.TryParse(txtInterestRate.Text, annualRate) Then
            MessageBox.Show("Please enter a valid interest rate")
            Return
        End If

        If Not Integer.TryParse(txtLoanTerm.Text, loanTermYears) Then
            MessageBox.Show("Please enter a valid loan term")
            Return
        End If

        ' Calculate monthly values
        monthlyRate = annualRate / 100 / 12
        loanTermMonths = loanTermYears * 12

        ' Calculate payment using Financial.Pmt method
        monthlyPayment = Pmt(monthlyRate, loanTermMonths, -loanAmount)

        ' Display result
        lblMonthlyPayment.Text = monthlyPayment.ToString("C")

        ' Calculate and display amortization details
        CalculateAmortization(loanAmount, monthlyRate, loanTermMonths, monthlyPayment)
    End Sub

    Private Sub CalculateAmortization(amount As Double, rate As Double,
                                   periods As Integer, payment As Double)
        Dim balance As Double = amount
        Dim interest, principal As Double

        ' Calculate total interest and principal
        Dim totalInterest As Double = 0

        For period As Integer = 1 To periods
            interest = Math.Round(balance * rate, 2)
            principal = Math.Round(payment - interest, 2)
            balance = Math.Round(balance - principal, 2)
            totalInterest += interest
        Next

        ' Display summary
        lblTotalInterest.Text = totalInterest.ToString("C")
        lblTotalPayment.Text = (amount + totalInterest).ToString("C")
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class
