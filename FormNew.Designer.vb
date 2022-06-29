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
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabProductList = New System.Windows.Forms.TabPage()
        Me.dgvProductList = New System.Windows.Forms.DataGridView()
        Me.tabReceipt = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAmountPayable = New System.Windows.Forms.TextBox()
        Me.txtVat = New System.Windows.Forms.TextBox()
        Me.txtAmountTaxable = New System.Windows.Forms.TextBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.txtTotalAmount = New System.Windows.Forms.TextBox()
        Me.dgvReceipt = New System.Windows.Forms.DataGridView()
        Me.productNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiptproductID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receiptProductName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.receiptProductPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RemoveSelectedProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GoToListOfProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Issuance = New System.Windows.Forms.TabPage()
        Me.Contacts = New System.Windows.Forms.TabPage()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportFromExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAsPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExportAsExcelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.productID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductQuantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.productPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductStockDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfPurchase = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductType = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OldStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NewStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Department = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Location = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FaultStock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1.SuspendLayout()
        Me.tabProductList.SuspendLayout()
        CType(Me.dgvProductList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReceipt.SuspendLayout()
        CType(Me.dgvReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabProductList)
        Me.TabControl1.Controls.Add(Me.tabReceipt)
        Me.TabControl1.Controls.Add(Me.Issuance)
        Me.TabControl1.Controls.Add(Me.Contacts)
        Me.TabControl1.Location = New System.Drawing.Point(0, 27)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(880, 535)
        Me.TabControl1.TabIndex = 0
        '
        'tabProductList
        '
        Me.tabProductList.AutoScroll = True
        Me.tabProductList.Controls.Add(Me.dgvProductList)
        Me.tabProductList.Location = New System.Drawing.Point(4, 24)
        Me.tabProductList.Name = "tabProductList"
        Me.tabProductList.Padding = New System.Windows.Forms.Padding(3)
        Me.tabProductList.Size = New System.Drawing.Size(872, 507)
        Me.tabProductList.TabIndex = 0
        Me.tabProductList.Text = "Product List"
        Me.tabProductList.UseVisualStyleBackColor = True
        '
        'dgvProductList
        '
        Me.dgvProductList.AllowUserToOrderColumns = True
        Me.dgvProductList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProductList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProductList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productID, Me.productName, Me.ProductQuantity, Me.productPrice, Me.ProductStockDate, Me.DateOfPurchase, Me.CurrentDate, Me.ProductType, Me.OldStock, Me.NewStock, Me.TotalStock, Me.Department, Me.Location, Me.FaultStock, Me.ProductCategory})
        Me.dgvProductList.Location = New System.Drawing.Point(-4, 0)
        Me.dgvProductList.Margin = New System.Windows.Forms.Padding(0)
        Me.dgvProductList.Name = "dgvProductList"
        Me.dgvProductList.RowHeadersVisible = False
        Me.dgvProductList.RowTemplate.Height = 25
        Me.dgvProductList.Size = New System.Drawing.Size(871, 468)
        Me.dgvProductList.TabIndex = 0
        '
        'tabReceipt
        '
        Me.tabReceipt.Controls.Add(Me.Label5)
        Me.tabReceipt.Controls.Add(Me.Label4)
        Me.tabReceipt.Controls.Add(Me.Label3)
        Me.tabReceipt.Controls.Add(Me.Label2)
        Me.tabReceipt.Controls.Add(Me.Label1)
        Me.tabReceipt.Controls.Add(Me.txtAmountPayable)
        Me.tabReceipt.Controls.Add(Me.txtVat)
        Me.tabReceipt.Controls.Add(Me.txtAmountTaxable)
        Me.tabReceipt.Controls.Add(Me.txtDiscount)
        Me.tabReceipt.Controls.Add(Me.txtTotalAmount)
        Me.tabReceipt.Controls.Add(Me.dgvReceipt)
        Me.tabReceipt.Location = New System.Drawing.Point(4, 24)
        Me.tabReceipt.Name = "tabReceipt"
        Me.tabReceipt.Padding = New System.Windows.Forms.Padding(3)
        Me.tabReceipt.Size = New System.Drawing.Size(1318, 666)
        Me.tabReceipt.TabIndex = 1
        Me.tabReceipt.Text = "Receipt"
        Me.tabReceipt.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(581, 407)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Amount Payable"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(581, 378)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "VAT(12%)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(581, 349)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Amount Taxable"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(581, 320)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Discount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(581, 296)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 15)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Total Amount"
        '
        'txtAmountPayable
        '
        Me.txtAmountPayable.Location = New System.Drawing.Point(715, 404)
        Me.txtAmountPayable.Name = "txtAmountPayable"
        Me.txtAmountPayable.ReadOnly = True
        Me.txtAmountPayable.Size = New System.Drawing.Size(86, 23)
        Me.txtAmountPayable.TabIndex = 3
        '
        'txtVat
        '
        Me.txtVat.Location = New System.Drawing.Point(715, 375)
        Me.txtVat.Name = "txtVat"
        Me.txtVat.ReadOnly = True
        Me.txtVat.Size = New System.Drawing.Size(86, 23)
        Me.txtVat.TabIndex = 3
        '
        'txtAmountTaxable
        '
        Me.txtAmountTaxable.Location = New System.Drawing.Point(715, 346)
        Me.txtAmountTaxable.Name = "txtAmountTaxable"
        Me.txtAmountTaxable.ReadOnly = True
        Me.txtAmountTaxable.Size = New System.Drawing.Size(86, 23)
        Me.txtAmountTaxable.TabIndex = 3
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(715, 317)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(86, 23)
        Me.txtDiscount.TabIndex = 3
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.Location = New System.Drawing.Point(715, 288)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(86, 23)
        Me.txtTotalAmount.TabIndex = 3
        '
        'dgvReceipt
        '
        Me.dgvReceipt.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvReceipt.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvReceipt.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReceipt.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.productNumber, Me.ReceiptproductID, Me.receiptProductName, Me.quantity, Me.receiptProductPrice, Me.productTotal})
        Me.dgvReceipt.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvReceipt.Location = New System.Drawing.Point(6, 6)
        Me.dgvReceipt.Name = "dgvReceipt"
        Me.dgvReceipt.RowTemplate.Height = 25
        Me.dgvReceipt.Size = New System.Drawing.Size(828, 276)
        Me.dgvReceipt.TabIndex = 0
        '
        'productNumber
        '
        Me.productNumber.HeaderText = "Number"
        Me.productNumber.Name = "productNumber"
        '
        'ReceiptproductID
        '
        Me.ReceiptproductID.HeaderText = "Product ID"
        Me.ReceiptproductID.Name = "ReceiptproductID"
        '
        'receiptProductName
        '
        Me.receiptProductName.HeaderText = "Product Name"
        Me.receiptProductName.Name = "receiptProductName"
        '
        'quantity
        '
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        '
        'receiptProductPrice
        '
        Me.receiptProductPrice.HeaderText = "Price"
        Me.receiptProductPrice.Name = "receiptProductPrice"
        '
        'productTotal
        '
        Me.productTotal.HeaderText = "Total"
        Me.productTotal.Name = "productTotal"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RemoveSelectedProductToolStripMenuItem, Me.ClearProductsToolStripMenuItem, Me.GoToListOfProductToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(210, 70)
        '
        'RemoveSelectedProductToolStripMenuItem
        '
        Me.RemoveSelectedProductToolStripMenuItem.Name = "RemoveSelectedProductToolStripMenuItem"
        Me.RemoveSelectedProductToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.RemoveSelectedProductToolStripMenuItem.Text = "Remove Selected Product"
        '
        'ClearProductsToolStripMenuItem
        '
        Me.ClearProductsToolStripMenuItem.Name = "ClearProductsToolStripMenuItem"
        Me.ClearProductsToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.ClearProductsToolStripMenuItem.Text = "Clear Products"
        '
        'GoToListOfProductToolStripMenuItem
        '
        Me.GoToListOfProductToolStripMenuItem.Name = "GoToListOfProductToolStripMenuItem"
        Me.GoToListOfProductToolStripMenuItem.Size = New System.Drawing.Size(209, 22)
        Me.GoToListOfProductToolStripMenuItem.Text = "Go to List of Product"
        '
        'Issuance
        '
        Me.Issuance.Location = New System.Drawing.Point(4, 24)
        Me.Issuance.Name = "Issuance"
        Me.Issuance.Padding = New System.Windows.Forms.Padding(3)
        Me.Issuance.Size = New System.Drawing.Size(1318, 666)
        Me.Issuance.TabIndex = 2
        Me.Issuance.Text = "Issuance"
        Me.Issuance.UseVisualStyleBackColor = True
        '
        'Contacts
        '
        Me.Contacts.Location = New System.Drawing.Point(4, 24)
        Me.Contacts.Name = "Contacts"
        Me.Contacts.Padding = New System.Windows.Forms.Padding(3)
        Me.Contacts.Size = New System.Drawing.Size(1318, 666)
        Me.Contacts.TabIndex = 3
        Me.Contacts.Text = "Contacts"
        Me.Contacts.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ActionToolStripMenuItem, Me.ImportToolStripMenuItem, Me.ExportToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.SaveToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'ActionToolStripMenuItem
        '
        Me.ActionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.ActionToolStripMenuItem.Name = "ActionToolStripMenuItem"
        Me.ActionToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.ActionToolStripMenuItem.Text = "Action"
        '
        'AddToolStripMenuItem
        '
        Me.AddToolStripMenuItem.Name = "AddToolStripMenuItem"
        Me.AddToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.AddToolStripMenuItem.Text = "Add"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'ImportToolStripMenuItem
        '
        Me.ImportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportFromPDFToolStripMenuItem, Me.ImportFromExcelToolStripMenuItem})
        Me.ImportToolStripMenuItem.Name = "ImportToolStripMenuItem"
        Me.ImportToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.ImportToolStripMenuItem.Text = "Import"
        '
        'ImportFromPDFToolStripMenuItem
        '
        Me.ImportFromPDFToolStripMenuItem.Name = "ImportFromPDFToolStripMenuItem"
        Me.ImportFromPDFToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ImportFromPDFToolStripMenuItem.Text = "Import From PDF"
        '
        'ImportFromExcelToolStripMenuItem
        '
        Me.ImportFromExcelToolStripMenuItem.Name = "ImportFromExcelToolStripMenuItem"
        Me.ImportFromExcelToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ImportFromExcelToolStripMenuItem.Text = "Import From Excel"
        '
        'ExportToolStripMenuItem
        '
        Me.ExportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExportAsPDFToolStripMenuItem, Me.ExportAsExcelToolStripMenuItem})
        Me.ExportToolStripMenuItem.Name = "ExportToolStripMenuItem"
        Me.ExportToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ExportToolStripMenuItem.Text = "Export"
        '
        'ExportAsPDFToolStripMenuItem
        '
        Me.ExportAsPDFToolStripMenuItem.Name = "ExportAsPDFToolStripMenuItem"
        Me.ExportAsPDFToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExportAsPDFToolStripMenuItem.Text = "Export As PDF"
        '
        'ExportAsExcelToolStripMenuItem
        '
        Me.ExportAsExcelToolStripMenuItem.Name = "ExportAsExcelToolStripMenuItem"
        Me.ExportAsExcelToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.ExportAsExcelToolStripMenuItem.Text = "Export As Excel"
        '
        'productID
        '
        Me.productID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.productID.HeaderText = "S/N"
        Me.productID.Name = "productID"
        Me.productID.Width = 52
        '
        'productName
        '
        Me.productName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.productName.HeaderText = "Name"
        Me.productName.Name = "productName"
        Me.productName.Width = 64
        '
        'ProductQuantity
        '
        Me.ProductQuantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.ProductQuantity.HeaderText = "Quantity"
        Me.ProductQuantity.Name = "ProductQuantity"
        Me.ProductQuantity.Width = 60
        '
        'productPrice
        '
        Me.productPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.productPrice.HeaderText = "Last Issue Date"
        Me.productPrice.Name = "productPrice"
        '
        'ProductStockDate
        '
        Me.ProductStockDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductStockDate.HeaderText = "Start Date"
        Me.ProductStockDate.Name = "ProductStockDate"
        Me.ProductStockDate.ReadOnly = True
        '
        'DateOfPurchase
        '
        Me.DateOfPurchase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.DateOfPurchase.HeaderText = "Days in Stock"
        Me.DateOfPurchase.Name = "DateOfPurchase"
        Me.DateOfPurchase.Width = 60
        '
        'CurrentDate
        '
        Me.CurrentDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.CurrentDate.HeaderText = "Unit Price"
        Me.CurrentDate.Name = "CurrentDate"
        Me.CurrentDate.Width = 60
        '
        'ProductType
        '
        Me.ProductType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductType.HeaderText = "Product Type"
        Me.ProductType.Name = "ProductType"
        '
        'OldStock
        '
        Me.OldStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.OldStock.HeaderText = "Old Stock"
        Me.OldStock.Name = "OldStock"
        '
        'NewStock
        '
        Me.NewStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.NewStock.HeaderText = "New Stock"
        Me.NewStock.Name = "NewStock"
        '
        'TotalStock
        '
        Me.TotalStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TotalStock.HeaderText = "Total in Stock"
        Me.TotalStock.Name = "TotalStock"
        '
        'Department
        '
        Me.Department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Department.HeaderText = "Department"
        Me.Department.Name = "Department"
        '
        'Location
        '
        Me.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Location.HeaderText = "Location"
        Me.Location.Name = "Location"
        '
        'FaultStock
        '
        Me.FaultStock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.FaultStock.HeaderText = "Fault Stock"
        Me.FaultStock.Name = "FaultStock"
        '
        'ProductCategory
        '
        Me.ProductCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ProductCategory.HeaderText = "Product Category"
        Me.ProductCategory.Name = "ProductCategory"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(880, 517)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Invertory"
        Me.TabControl1.ResumeLayout(False)
        Me.tabProductList.ResumeLayout(False)
        CType(Me.dgvProductList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReceipt.ResumeLayout(False)
        Me.tabReceipt.PerformLayout()
        CType(Me.dgvReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents tabProductList As TabPage
    Friend WithEvents dgvProductList As DataGridView
    Friend WithEvents tabReceipt As TabPage
    Friend WithEvents txtTotalAmount As TextBox
    Friend WithEvents dgvReceipt As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtAmountPayable As TextBox
    Friend WithEvents txtVat As TextBox
    Friend WithEvents txtAmountTaxable As TextBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents RemoveSelectedProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GoToListOfProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents productNumber As DataGridViewTextBoxColumn
    Friend WithEvents ReceiptproductID As DataGridViewTextBoxColumn
    Friend WithEvents receiptProductName As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents receiptProductPrice As DataGridViewTextBoxColumn
    Friend WithEvents productTotal As DataGridViewTextBoxColumn
    Friend WithEvents Issuance As TabPage
    Friend WithEvents Contacts As TabPage
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportFromPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImportFromExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportAsPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExportAsExcelToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents productID As DataGridViewTextBoxColumn
    Friend WithEvents productName As DataGridViewTextBoxColumn
    Friend WithEvents ProductQuantity As DataGridViewTextBoxColumn
    Friend WithEvents productPrice As DataGridViewTextBoxColumn
    Friend WithEvents ProductStockDate As DataGridViewTextBoxColumn
    Friend WithEvents DateOfPurchase As DataGridViewTextBoxColumn
    Friend WithEvents CurrentDate As DataGridViewTextBoxColumn
    Friend WithEvents ProductType As DataGridViewTextBoxColumn
    Friend WithEvents OldStock As DataGridViewTextBoxColumn
    Friend WithEvents NewStock As DataGridViewTextBoxColumn
    Friend WithEvents TotalStock As DataGridViewTextBoxColumn
    Friend WithEvents Department As DataGridViewTextBoxColumn
    Friend WithEvents Location As DataGridViewTextBoxColumn
    Friend WithEvents FaultStock As DataGridViewTextBoxColumn
    Friend WithEvents ProductCategory As DataGridViewTextBoxColumn
End Class
