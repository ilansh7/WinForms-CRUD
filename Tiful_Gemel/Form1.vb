'Option Strict On
'Option Explicit On

Imports System.Data.SqlClient
Imports System.IO

Public Class Form1 : Implements IDisposable
    Dim conn As New SqlConnection("Data Source=.;Initial Catalog=TifulGemel;Integrated Security=True")
    Dim formIsValid As Boolean = True
    Dim errMsg As String = ""

    Private Sub btnApplyDeposit_Click(sender As Object, e As EventArgs) Handles btnApplyDeposit.Click
        Dim CustomerId As String = txtIDNumber.Text
        Dim CustomerBirthDay As DateTime = dtBitrhDay.Value
        Dim DepositDate As DateTime = dtDepositDate.Value
        Dim Amount As Decimal = 0 'txtAmount.Text

        txtAmount.BackColor = System.Drawing.SystemColors.Window
        dtDepositDate.CalendarMonthBackground = System.Drawing.SystemColors.Window
        dtBitrhDay.CalendarMonthBackground = System.Drawing.SystemColors.Window
        txtIDNumber.BackColor = System.Drawing.SystemColors.Window

        ' Validations
        Dim dblAmount As Double = 0.0
        If Double.TryParse(txtAmount.Text, dblAmount) Then
            Amount = dblAmount
        Else
            errMsg = "הסכום אינו תקין."
            txtAmount.BackColor = Color.Pink
            formIsValid = False
        End If
        If dtDepositDate.Text = " " Then
            errMsg = "שדה תאריך הפקדה הוא חובה."
            dtDepositDate.CalendarMonthBackground = Color.Pink
            formIsValid = False
        End If
        If dtBitrhDay.Text = " " Then
            errMsg = "שדה תאריך לידה הוא חובה."
            dtBitrhDay.CalendarMonthBackground = Color.Pink
            formIsValid = False
        End If
        If String.IsNullOrEmpty(txtIDNumber.Text) Then
            errMsg = "שדה מזהה לקוח הוא חובה."
            txtIDNumber.BackColor = Color.Pink
            formIsValid = False
        End If
        If formIsValid Then
            conn.Open()
            Dim cmd As New SqlCommand("insert into [dbo].[Deposits] values ('" & CustomerId & "','" & CustomerBirthDay & "','" & DepositDate & "','" & Amount & "')", conn)
            cmd.ExecuteNonQuery()
            'MessageBox.Show("רשומה התווספה בהצלחה.")
            conn.Close()
            GetDepositDetails(False)
        Else
            MessageBox.Show("שגיאה בהזנת המידע : " & errMsg)
        End If
        conn.Close()

        'StatusStrip1.Text = ""

        'conn.Dispose()
        'Dispose()

    End Sub
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

    Private Sub btnViewDeposit_Click(sender As Object, e As EventArgs) Handles btnViewDeposit.Click
        GetDepositDetails(True)
    End Sub

    Private Sub btnClearForm_Click(sender As Object, e As EventArgs) Handles btnClearForm.Click
        txtAmount.BackColor = System.Drawing.SystemColors.Window
        dtDepositDate.CalendarMonthBackground = System.Drawing.SystemColors.Window
        dtBitrhDay.CalendarMonthBackground = System.Drawing.SystemColors.Window
        txtIDNumber.BackColor = System.Drawing.SystemColors.Window
        txtDepositID.Text = ""
        txtIDNumber.Text = ""
        dtBitrhDay.CustomFormat = " "  'An empty SPACE
        dtBitrhDay.Format = DateTimePickerFormat.Custom
        dtDepositDate.CustomFormat = " "  'An empty SPACE
        dtDepositDate.Format = DateTimePickerFormat.Custom
        txtAmount.Text = ""
        dgTiful.DataSource = ""

    End Sub

    Private Sub dtDepositDate_ValueChanged(sender As Object, e As EventArgs) Handles dtDepositDate.ValueChanged
        dtDepositDate.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub dtBitrhDay_ValueChanged(sender As Object, e As EventArgs) Handles dtBitrhDay.ValueChanged
        dtBitrhDay.CustomFormat = "dd/MM/yyyy"
    End Sub

    Private Sub btnUpdateDeposit_Click(sender As Object, e As EventArgs) Handles btnUpdateDeposit.Click
        Dim Amount As Decimal = 0
        ' Validations
        Dim dblAmount As Double = 0.0
        If Double.TryParse(txtAmount.Text, dblAmount) Then
            Amount = dblAmount
        Else
            errMsg = "הסכום אינו תקין."
            formIsValid = False
        End If
        If String.IsNullOrEmpty(txtDepositID.Text) Then
            errMsg = "שדה מזהה הפקדה הוא חובה."
            formIsValid = False
        End If

        If formIsValid Then
            conn.Open()
            Dim cmd As New SqlCommand("update [dbo].[Deposits] set Amount = '" & Amount & "' where DepositId = " & txtDepositID.Text, conn)
            cmd.ExecuteNonQuery()
            'MessageBox.Show("רשומה התווספה בהצלחה.")
            conn.Close()
            GetDepositDetails(False)
        Else
            MessageBox.Show("שגיאה בהזנת המידע : " & errMsg)
        End If
        conn.Close()

        GetDepositDetails(False)
    End Sub

    Private Sub btnDeleteDeposit_Click(sender As Object, e As EventArgs) Handles btnDeleteDeposit.Click
        ' Validations
        If String.IsNullOrEmpty(txtDepositID.Text) Then
            errMsg = "שדה מזהה הפקדה הוא חובה."
            formIsValid = False
        End If

        If formIsValid Then
            Dim result = MessageBox.Show("האם את/ה בטוח ?", "מחיקת הפקדה מס' " & txtDepositID.Text, MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                conn.Open()
                Dim cmd As New SqlCommand("delete from [dbo].[Deposits] where DepositId = " & txtDepositID.Text, conn)
                cmd.ExecuteNonQuery()
                'MessageBox.Show("רשומה התווספה בהצלחה.")
                conn.Close()
                GetDepositDetails(False)
            End If
        Else
            MessageBox.Show("שגיאה בהזנת המידע : " & errMsg)
        End If
        conn.Close()
        GetDepositDetails(False)
    End Sub
End Class
