'Option Strict On
'Option Explicit On

Imports System.Data.SqlClient
Imports System.IO


Public Class Form1 : Implements IDisposable
    Dim conn As New SqlConnection("Data Source=.;Initial Catalog=TifulGemel;Integrated Security=True")
    Dim formIsValid As Boolean = True
    Dim clearDataGridFlag As Boolean = False
    Dim errMsg As String = ""

    Private Sub GetDepositDetails(CreteriaByFields As Boolean)
        ' the parameter is for reload data after add/modify without using parameters for select statement.
        conn.Open()
        Dim sqlCommand As String = "select * from [dbo].[Deposits]"
        If CreteriaByFields Then
            Dim strAnd = "", strWhere = ""
            If Not String.IsNullOrEmpty(txtIDNumber.Text) Then
                strWhere = "where"
                sqlCommand += " " + strWhere + " " + strAnd + " " + "IDNumber = '" & txtIDNumber.Text & "'"
            End If
            If Not String.IsNullOrEmpty((dtBitrhDay.Value).ToString) And Not dtBitrhDay.Text = " " Then
                If String.IsNullOrEmpty(strWhere) Then
                    strWhere = "where"
                Else
                    strAnd = "and"
                    strWhere = ""
                End If
                sqlCommand += " " + strWhere + " " + strAnd + " " + "CONVERT(VARCHAR(10), BirthDay, 103) = '" & dtBitrhDay.Value.ToString("dd/MM/yyyy") & "'"
            End If
            If Not String.IsNullOrEmpty((dtDepositDate.Value).ToString) And Not dtDepositDate.Text = " " Then
                If String.IsNullOrEmpty(strWhere) Then
                    strWhere = "where"
                Else
                    strAnd = "and"
                    strWhere = ""
                End If
                sqlCommand += " " + strWhere + " " + strAnd + " " + "CONVERT(VARCHAR(10), DepositDate, 103) = '" & dtDepositDate.Value.ToString("dd/MM/yyyy") & "'" 'ToShortDateString & "'"
            End If
        End If
        sqlCommand += " order by DepositDate desc"
        Dim cmd As New SqlCommand(sqlCommand, conn)
        Dim sqlDA As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        sqlDA.Fill(dt)
        Dim i As Integer = dt.Rows.Count
        Dim amount As Decimal
        Dim birthDay As DateTime
        For i = 0 To dt.Rows.Count - 1 Step 1
            'birthDay = Convert.ToDateTime(dt.Rows(i).Item(2))
            birthDay = dt.Rows(i).Item(2)
            amount = dt.Rows(i).Item(4)
            'dt.Rows(i).Item(2) = birthDay.ToString("dd/MM/yyyy")
            dt.Rows(i).Item(2) = birthDay.ToShortDateString()
            dt.Rows(i).Item(4) = amount.ToString("N2")
        Next
        dgTiful.DataSource = dt
        formIsValid = True

        conn.Close()
    End Sub

    Private Sub SetDeposit(Mode As String)
        Dim CustomerId As String = txtIDNumber.Text
        Dim CustomerBirthDay As DateTime = dtBitrhDay.Value
        Dim DepositDate As DateTime = dtDepositDate.Value
        Dim Amount As Decimal = 0 'txtAmount.Text

        txtAmount.BackColor = System.Drawing.SystemColors.Window
        dtDepositDate.CalendarMonthBackground = System.Drawing.SystemColors.Window
        dtBitrhDay.CalendarMonthBackground = System.Drawing.SystemColors.Window
        txtIDNumber.BackColor = System.Drawing.SystemColors.Window

        formIsValid = True
        errMsg = ""
        Validation(Mode)

        Dim cmd As New SqlCommand()
        If formIsValid Then
            Dim dblAmount As Double = 0.0
            If Double.TryParse(txtAmount.Text, dblAmount) Then
                Amount = dblAmount
            End If

            cmd.Connection = conn
            Select Case Mode
                Case "I"
                    cmd.CommandText = "insert into [dbo].[Deposits] values (N'" & CustomerId & "','" & CustomerBirthDay & "','" & DepositDate & "','" & Amount & "')"
                Case "U"
                    cmd.CommandText = "update [dbo].[Deposits] set Amount = '" & Amount & "' where DepositId = " & txtDepositID.Text
                Case "D"
                    cmd.CommandText = "delete from [dbo].[Deposits] where DepositId = " & txtDepositID.Text
                Case Else
                    formIsValid = False
                    errMsg = "סוג פעולה שנבחר אינו מוכר."
            End Select
        End If

        If formIsValid Then
            conn.Open()
            cmd.ExecuteNonQuery()
            'MessageBox.Show("רשומה התווספה בהצלחה.")
            conn.Close()
            ClearForm()
            GetDepositDetails(False)
        Else
            MessageBox.Show("שגיאה בהזנת המידע : " & errMsg)
            formIsValid = True
        End If
        'conn.Close()
    End Sub

    Private Sub Validation(Mode As String)
        Dim Amount As Decimal = 0 'txtAmount.Text

        txtAmount.BackColor = System.Drawing.SystemColors.Window
        dtDepositDate.CalendarMonthBackground = System.Drawing.SystemColors.Window
        dtBitrhDay.CalendarMonthBackground = System.Drawing.SystemColors.Window
        txtIDNumber.BackColor = System.Drawing.SystemColors.Window

        formIsValid = True
        ' Validations
        Dim dblAmount As Double = 0.0
        If Mode = "U" Or Mode = "D" Then
            If String.IsNullOrEmpty(txtDepositID.Text) Then
                errMsg = "שדה מזהה הפקדה הוא חובה."
                txtDepositID.BackColor = Color.Pink
                formIsValid = False
                Exit Sub
            End If
        End If
        If Mode = "I" Then
            If String.IsNullOrEmpty(txtIDNumber.Text) Then
                errMsg = "שדה מזהה לקוח הוא חובה."
                txtIDNumber.BackColor = Color.Pink
                formIsValid = False
                Exit Sub
            End If
            If dtBitrhDay.Text = " " Then
                errMsg = "שדה תאריך לידה הוא חובה."
                dtBitrhDay.CalendarMonthBackground = Color.Pink
                formIsValid = False
                Exit Sub
            End If
            If dtDepositDate.Text = " " Then
                errMsg = "שדה תאריך הפקדה הוא חובה."
                dtDepositDate.CalendarMonthBackground = Color.Pink
                formIsValid = False
                Exit Sub
            End If
        End If
        If Mode = "I" Or Mode = "D" Then
            If Double.TryParse(txtAmount.Text, dblAmount) Then
                Amount = dblAmount
            Else
                errMsg = "הסכום אינו תקין."
                txtAmount.BackColor = Color.Pink
                formIsValid = False
                Exit Sub
            End If
        End If
    End Sub

    Private Sub ClearForm()
        txtAmount.BackColor = System.Drawing.SystemColors.Window
        dtDepositDate.CalendarMonthBackground = System.Drawing.SystemColors.Window
        dtBitrhDay.CalendarMonthBackground = System.Drawing.SystemColors.Window
        txtIDNumber.BackColor = System.Drawing.SystemColors.Window
        txtDepositID.BackColor = System.Drawing.SystemColors.Window
        txtDepositID.Text = ""
        txtIDNumber.Text = ""
        dtBitrhDay.CustomFormat = " "  'An empty SPACE
        dtBitrhDay.Format = DateTimePickerFormat.Custom
        dtDepositDate.CustomFormat = " "  'An empty SPACE
        dtDepositDate.Format = DateTimePickerFormat.Custom
        txtAmount.Text = ""
        If clearDataGridFlag Then
            dgTiful.DataSource = ""
        End If
        clearDataGridFlag = False
        'MessageBox.Show("hey you")
    End Sub

    Private Sub btnViewDeposit_Click(sender As Object, e As EventArgs) Handles btnViewDeposit.Click
        GetDepositDetails(True)
    End Sub

    Private Sub btnApplyDeposit_Click(sender As Object, e As EventArgs) Handles btnApplyDeposit.Click
        SetDeposit("I")
    End Sub

    Private Sub btnUpdateDeposit_Click(sender As Object, e As EventArgs) Handles btnUpdateDeposit.Click
        SetDeposit("U")
    End Sub

    Private Sub btnDeleteDeposit_Click(sender As Object, e As EventArgs) Handles btnDeleteDeposit.Click
        Dim result = MessageBox.Show("האם את/ה בטוח ?", "מחיקת הפקדה מס' " & txtDepositID.Text, MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            SetDeposit("D")
        End If
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        clearDataGridFlag = True
        ClearForm()
    End Sub

    Private Sub dtDepositDate_ValueChanged(sender As Object, e As EventArgs) Handles dtDepositDate.ValueChanged
        dtDepositDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtBitrhDay_ValueChanged(sender As Object, e As EventArgs) Handles dtBitrhDay.ValueChanged
        dtBitrhDay.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dgTiful_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgTiful.CellMouseClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgTiful.Rows(e.RowIndex)
            txtDepositID.Text = row.Cells(0).Value.ToString
            txtAmount.Text = row.Cells(4).Value.ToString
            'txtCountry.Text = row.Cells(2).Value.ToString
        End If
    End Sub
End Class
