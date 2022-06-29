Imports System.Drawing.Printing
Imports System.Data.DataTable
Imports Excel = Microsoft.Office
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.IO


Public Class Form1


    Private arrayProductID() As String = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14"}
    Private arrayProductName() As String = {"Gearbox oil", "Engine Oil", "Fan Belt", "Windscreen", "Bostic", "Wiper Blades", "Coolent", "Gearbox oil", "Engine Oil", "Fan Belt", "Windscreen", "Bostic", "Wiper Blades", "Coolent"}
    Private arrayPrice() As Double = {123, 124, 123, 345, 453, 321, 532, 123, 124, 123, 345, 453, 321, 532}
    Private arrayQuantity() As Integer = {1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 6, 7}
    Private arrayDate() As Date = {#6/30/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #6/30/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #6/30/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #6/30/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#}
    Private arrayEnd() As Date = {#6/30/2023#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #6/30/2023#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #6/30/2023#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #6/30/2023#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#, #06/06/2022#}
    Private arrayProductType() As String = {"Primary Product", "Secondary Product", "Tertiary Product", "Primary Product", "Secondary Product", "Tertiary Product", "Primary Product", "Secondary Product", "Tertiary Product", "Primary Product", "Secondary Product", "Tertiary Product", "Secondary Product", "Tertiary Product"}
    Private arrayDep() As String = {"IT", "Social Sciences", "Political Science", "IT", "Social Sciences", "Political Science", "IT", "Social Sciences", "Political Science", "IT", "Social Sciences", "Political Science", "Social Sciences", "Political Science"}
    Private arrayLoc() As String = {"Accra", "Kumasi", "Osu", "Accra", "Kumasi", "Osu", "Accra", "Kumasi", "Osu", "Accra", "Kumasi", "Osu", "Kumasi", "Osu"}
    Private arrayTotalStock() As Double = {123, 124, 123, 345, 453, 321, 532, 123, 124, 123, 345, 453, 321, 532}
    Private arrayOldStock() As Double = {123, 124, 123, 345, 453, 321, 532, 123, 124, 123, 345, 453, 321, 532}
    Private arrayNewStock() As Double = {123, 124, 123, 345, 453, 321, 532, 123, 124, 123, 345, 453, 321, 532}





    Private index As Integer
    Dim newIndex As Integer = 1
    Dim totalAmount, discountAmount, taxableAmount, taxAmount, payableAmount As Double



    Private Sub AddToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToolStripMenuItem.Click
        '  For index = 0 To arrayProductID.Length - 1
        Dim newArraySize As Integer = arrayProductID.Length
        ReDim Preserve arrayProductID(newArraySize)
        ReDim Preserve arrayProductName(newArraySize)
        ReDim Preserve arrayPrice(newArraySize)
        ReDim Preserve arrayQuantity(newArraySize)
        arrayProductID(index) = InputBox("Please enter an ID for the product", "Product ID Entry Box", "1").ToString.ToUpper
        arrayProductName(index) = InputBox("Please Enter the name of the product with ID= " & arrayProductID(index), "Product Name Entry Box", "Gearbox oil")
        arrayPrice(index) = CDbl(InputBox("Please Enter the Price of the product with ID= " & arrayProductID(index) & ":" & arrayProductName(index), "Product Price Entry Box", "$120"))
        arrayQuantity(index) = CInt(InputBox("Please Enter the Quantity of the product with ID= " & arrayProductID(index) & ":" & arrayProductName(index), "Product Quantity Entry Box", "12"))
        arrayEnd(index) = CDate(InputBox("Please Enter the End Date Of the Purchased Product" & arrayProductID(index) & ":" & arrayProductName(index), "Product End Date Entry Box", "120"))
        arrayDate(index) = CDate(InputBox("Please Enter the Start Date Of the Purchased Product" & arrayProductID(index) & ":" & arrayProductName(index), "Product Start Date Entry Box", "120"))
        arrayProductType(index) = (InputBox("Please Enter the Product Type of the product with ID= " & arrayProductID(index) & ":" & arrayProductName(index), "Product Type Entry Box", "Primay Product"))
        arrayDep(index) = (InputBox("Please Enter the Department of the product with ID= " & arrayProductID(index) & ":" & arrayProductName(index), "Product Department Entry Box", "Social Science"))
        arrayLoc(index) = (InputBox("Please Enter the Location of the product with ID= " & arrayProductID(index) & ":" & arrayProductName(index), "Product Location Entry Box", "Kumasi"))
        arrayTotalStock(index) = (InputBox("Please Enter the Product Type of the product with ID= " & arrayProductID(index) & ":" & arrayProductName(index), "Product Type Entry Box", "Primay Product"))
        arrayOldStock(index) = (InputBox("Please Enter the Product Type of the product with ID= " & arrayProductID(index) & ":" & arrayProductName(index), "Product Type Entry Box", "Primay Product"))
        arrayNewStock(index) = (InputBox("Please Enter the Product Type of the product with ID= " & arrayProductID(index) & ":" & arrayProductName(index), "Product Type Entry Box", "Primay Product"))
        dgvProductList.Rows.Add(arrayProductID(index), arrayProductName(index), arrayQuantity(index), arrayEnd(index), arrayDate(index), (Math.Floor((arrayEnd(index) - arrayDate(index)).TotalDays)), arrayPrice(index).ToString("C2"), arrayProductType(index), arrayTotalStock(index), arrayOldStock(index), arrayNewStock(index), arrayDep(index), arrayLoc(index))

        ' Next

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For index = 0 To arrayProductID.Length - 1
            dgvProductList.Rows.Add(arrayProductID(index), arrayProductName(index), arrayQuantity(index), arrayEnd(index), arrayDate(index), (Math.Floor((arrayEnd(index) - arrayDate(index)).TotalDays)), arrayPrice(index).ToString("C2"), arrayProductType(index), arrayTotalStock(index), arrayOldStock(index), arrayNewStock(index), arrayDep(index), arrayLoc(index))
        Next

    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Dim searchInput As String
        Dim isFound As Boolean
        searchInput = CInt(InputBox("Please Enter a Product ID and Select OK to search", "Product Search Box", "ABCD003").ToUpper)

        For index = 0 To arrayProductID.Length - 1
            If searchInput = CInt(arrayProductID(index)) Then
                isFound = True
                Exit For
            End If
        Next

        If isFound = True Then
            dgvProductList.ClearSelection()
            dgvProductList.Rows(index).Selected = True

        Else
            MessageBox.Show("The product ID was not found. Please Try again")
        End If
        'For Each row As DataGridViewRow In dgvProductList.Rows
        'Dim expdate As Date = row.Cells("exp_date").Value
        'Dim calcdays_v As Integer = DateDiff(DateInterval.Day, Date.Now, expdate)
        'row.Cells("rdays").Value = calcdays_v
        'Next


    End Sub

    Private Sub RemoveSelectedProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveSelectedProductToolStripMenuItem.Click
        Dim effect As Double
        If dgvReceipt.Rows.Count > 1 Then
            index = dgvReceipt.CurrentRow.Index
            effect = dgvReceipt.Rows(index).Cells(5).Value
            dgvReceipt.Rows.Remove(dgvReceipt.CurrentRow)
            totalAmount = totalAmount - effect
            discountAmount = calculateDiscount(totalAmount)
            taxableAmount = totalAmount - discountAmount
            taxAmount = calculateTax(taxableAmount)
            payableAmount = taxableAmount + taxAmount
            displayResults()
        End If
    End Sub

    Private Sub ClearControls()
        totalAmount = 0.0
        newIndex = 1
        dgvReceipt.Rows.Clear()
        txtTotalAmount.Text = ""
        txtDiscount.Text = ""
        txtAmountTaxable.Text = ""
        txtVat.Text = ""
        txtAmountPayable.Text = ""
    End Sub
    Private Sub ClearProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearProductsToolStripMenuItem.Click
        ClearControls()
    End Sub

    Private Sub GoToListOfProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoToListOfProductToolStripMenuItem.Click
        TabControl1.SelectedTab = tabProductList
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveToExcel()
    End Sub
    Private Sub SaveToExcel()

        Dim excel As Microsoft.Office.Interop.Excel._Application = New Microsoft.Office.Interop.Excel.Application()
        Dim workbook As Microsoft.Office.Interop.Excel._Workbook = excel.Workbooks.Add(Type.Missing)
        Dim worksheet As Microsoft.Office.Interop.Excel._Worksheet = Nothing

        Try

            worksheet = workbook.ActiveSheet

            worksheet.Name = "ExportedFromDataGrid"

            Dim cellRowIndex As Integer = 1
            Dim cellColumnIndex As Integer = 1

            For j As Integer = 0 To dgvProductList.Columns.Count = 1
                worksheet.Cells(cellRowIndex, cellColumnIndex) = dgvProductList.Columns(j).HeaderText
                cellColumnIndex += 1
            Next

            cellColumnIndex = 1
            cellRowIndex += 1


            For i As Integer = 0 To dgvProductList.Rows.Count - 2
                For j As Integer = 0 To dgvProductList.Columns.Count - 1
                    worksheet.Cells(cellRowIndex, cellColumnIndex) = dgvProductList.Rows(i).Cells(j).Value.ToString()
                    cellColumnIndex += 1
                Next
                cellColumnIndex = 1
                cellRowIndex += 1
            Next

            Dim saveDialog As New SaveFileDialog()
            saveDialog.Filter = "Excel files(*.xlsx)|*.xlsx|All files (*.*)|*.*"
            saveDialog.FilterIndex = 2

            If saveDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                workbook.SaveAs(saveDialog.FileName)
                MessageBox.Show("Export Successful")
            End If

        Catch ex As System.Exception
            MessageBox.Show(ex.Message)
        Finally
            excel.Quit()
            workbook = Nothing
            excel = Nothing
        End Try



    End Sub



    Private Sub ExportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExportToolStripMenuItem.Click

    End Sub

    Private Sub dgvProductList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProductList.CellContentClick
        Static total As Double
        Dim quantity As Integer
        If e.ColumnIndex = 3 Then
            index = e.RowIndex
            quantity = CDbl(InputBox("Please enter the quantity of you indent to Purchase", "Quantity Input box"))
            total = quantity * arrayPrice(index)
            dgvReceipt.Rows.Add(newIndex, arrayProductID(index), arrayProductName(index), quantity, arrayPrice(index).ToString("C2"), total.ToString("C2"))
            newIndex += 1
            totalAmount = totalAmount + total
            TabControl1.SelectedTab = tabReceipt
        End If
        discountAmount = calculateDiscount(totalAmount)
        taxableAmount = totalAmount - discountAmount
        taxAmount = calculateTax(taxableAmount)
        payableAmount = taxableAmount + taxAmount
        displayResults()
    End Sub

    Private Function calculateDiscount(ByVal receiptTotal As Double) As Double
        Dim discount As Double
        If receiptTotal <= 200 Then
            discount = 0.02 * receiptTotal
        ElseIf receiptTotal <= 100 Then
            discount = 0.05 * receiptTotal
        ElseIf receiptTotal > 100 Then
            discount = 0.1 * receiptTotal
        End If
        Return discount
    End Function



    Private Function calculateTax(ByVal taxable As Double) As Double
        Dim taxAmount As Double
        taxAmount = 0.12 * taxable
        Return taxAmount
    End Function

    Private Sub displayResults()
        txtTotalAmount.Text = totalAmount.ToString("C2")
        txtDiscount.Text = discountAmount.ToString("C2")
        txtAmountTaxable.Text = taxableAmount.ToString("C2")
        txtVat.Text = taxAmount.ToString("C2")
        txtAmountPayable.Text = payableAmount.ToString("C2")
    End Sub


End Class

