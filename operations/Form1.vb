Public Class Form1

    Private Sub txtNumber1_TextChanged(sender As Object, e As EventArgs) Handles txtNumber1.TextChanged
        Me.lblTextResult.Text = ""
    End Sub

    Private Sub txtNumber2_TextChanged(sender As Object, e As EventArgs) Handles txtNumber2.TextChanged
        Me.lblTextResult.Text = ""
    End Sub

    Private Sub lblResult_Click(sender As Object, e As EventArgs) Handles lblResult.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Me.lblTextResult.Text = "Result"
        '1) Declare variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intAnswer As Integer

        '2) Set values
        intNum1 = Val(txtNumber1.Text)
        intNum2 = Val(txtNumber2.Text)

        '3) Calculate
        intAnswer = intNum1 + intNum2

        '4) Display
        lblResult.Text = "= " & intAnswer
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        Me.lblTextResult.Text = "Result"
        '1) Declare variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intAnswer As Integer

        '2) Set values
        intNum1 = Val(txtNumber1.Text)
        intNum2 = Val(txtNumber2.Text)

        '3) Calculate
        intAnswer = intNum1 - intNum2

        '4) Display
        lblResult.Text = "= " & intAnswer

    End Sub

    Private Sub btnMult_Click(sender As Object, e As EventArgs) Handles btnMult.Click
        Me.lblTextResult.Text = "Result"
        '1) Declare variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intAnswer As Integer

        '2) Set values
        intNum1 = Val(txtNumber1.Text)
        intNum2 = Val(txtNumber2.Text)

        '3) Calculate
        intAnswer = intNum1 * intNum2

        '4) Display
        lblResult.Text = "= " & intAnswer

    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        Me.lblTextResult.Text = "Result"
        '1) Declare variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intAnswer As Integer

        '2) Set values
        intNum1 = Val(txtNumber1.Text)
        intNum2 = Val(txtNumber2.Text)

        '3) Calculate
        intAnswer = intNum1 / intNum2

        '4) Display
        lblResult.Text = "= " & intAnswer

    End Sub

    Private Sub btnIntDiv_Click(sender As Object, e As EventArgs) Handles btnIntDiv.Click
        Me.lblTextResult.Text = "Result"
        '1) Declare variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intAnswer As Integer

        '2) Set values
        intNum1 = Val(txtNumber1.Text)
        intNum2 = Val(txtNumber2.Text)

        '3) Calculate
        intAnswer = intNum1 \ intNum2

        '4) Display
        lblResult.Text = "= " & intAnswer

    End Sub

    Private Sub btnPow_Click(sender As Object, e As EventArgs) Handles btnPow.Click
        Me.lblTextResult.Text = "Result"
        '1) Declare variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intAnswer As Integer

        '2) Set values
        intNum1 = Val(txtNumber1.Text)
        intNum2 = Val(txtNumber2.Text)

        '3) Calculate
        intAnswer = intNum1 ^ intNum2

        '4) Display
        lblResult.Text = "= " & intAnswer

    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        Me.lblTextResult.Text = "Result"
        '1) Declare variables
        Dim intNum1 As Integer
        Dim intNum2 As Integer
        Dim intAnswer As Integer

        '2) Set values
        intNum1 = Val(txtNumber1.Text)
        intNum2 = Val(txtNumber2.Text)

        '3) Calculate
        intAnswer = intNum1 Mod intNum2

        '4) Display
        lblResult.Text = "= " & intAnswer

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
