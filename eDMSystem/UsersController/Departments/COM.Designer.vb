<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COM
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ButtonAddVoter = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.StudentDataGridView = New Guna.UI2.WinForms.Guna2DataGridView()
        Me.COMNAMEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COMNOTESDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.HSEQCOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CompaniesDataSet = New eDMSystem.companiesDataSet()
        Me.TextSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.HSEQ_COMTableAdapter = New eDMSystem.companiesDataSetTableAdapters.HSEQ_COMTableAdapter()
        Me.TableAdapterManager = New eDMSystem.companiesDataSetTableAdapters.TableAdapterManager()
        Me.COM_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HSEQCOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CompaniesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.ButtonAddVoter)
        Me.Guna2ShadowPanel1.Controls.Add(Me.StudentDataGridView)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(7, 82)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1024, 581)
        Me.Guna2ShadowPanel1.TabIndex = 7
        '
        'ButtonAddVoter
        '
        Me.ButtonAddVoter.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonAddVoter.Animated = True
        Me.ButtonAddVoter.CheckedState.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.CustomImages.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.FillColor = System.Drawing.Color.FromArgb(CType(CType(81, Byte), Integer), CType(CType(152, Byte), Integer), CType(CType(114, Byte), Integer))
        Me.ButtonAddVoter.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ButtonAddVoter.ForeColor = System.Drawing.Color.White
        Me.ButtonAddVoter.HoverState.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.Image = Global.eDMSystem.My.Resources.Resources.plus_white
        Me.ButtonAddVoter.ImageOffset = New System.Drawing.Point(1, 1)
        Me.ButtonAddVoter.ImageSize = New System.Drawing.Size(25, 25)
        Me.ButtonAddVoter.Location = New System.Drawing.Point(960, 512)
        Me.ButtonAddVoter.Name = "ButtonAddVoter"
        Me.ButtonAddVoter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ButtonAddVoter.ShadowDecoration.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.Size = New System.Drawing.Size(46, 48)
        Me.ButtonAddVoter.TabIndex = 6
        '
        'StudentDataGridView
        '
        Me.StudentDataGridView.AllowUserToAddRows = False
        Me.StudentDataGridView.AllowUserToDeleteRows = False
        Me.StudentDataGridView.AllowUserToOrderColumns = True
        Me.StudentDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.StudentDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.StudentDataGridView.AutoGenerateColumns = False
        Me.StudentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.StudentDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.StudentDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StudentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.StudentDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.StudentDataGridView.ColumnHeadersHeight = 40
        Me.StudentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COMNAMEDataGridViewTextBoxColumn, Me.COMNOTESDataGridViewTextBoxColumn, Me.Column2, Me.Column3})
        Me.StudentDataGridView.DataSource = Me.HSEQCOMBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentDataGridView.DefaultCellStyle = DataGridViewCellStyle3
        Me.StudentDataGridView.EnableHeadersVisualStyles = False
        Me.StudentDataGridView.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StudentDataGridView.Location = New System.Drawing.Point(14, 12)
        Me.StudentDataGridView.MultiSelect = False
        Me.StudentDataGridView.Name = "StudentDataGridView"
        Me.StudentDataGridView.ReadOnly = True
        Me.StudentDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StudentDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(4, 4, 0, 4)
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.StudentDataGridView.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.StudentDataGridView.RowTemplate.Height = 40
        Me.StudentDataGridView.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.StudentDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.StudentDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.StudentDataGridView.Size = New System.Drawing.Size(999, 548)
        Me.StudentDataGridView.TabIndex = 4
        Me.StudentDataGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.WhiteGrid
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty
        Me.StudentDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty
        Me.StudentDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!, System.Drawing.FontStyle.Bold)
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing
        Me.StudentDataGridView.ThemeStyle.HeaderStyle.Height = 40
        Me.StudentDataGridView.ThemeStyle.ReadOnly = True
        Me.StudentDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White
        Me.StudentDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.StudentDataGridView.ThemeStyle.RowsStyle.Font = New System.Drawing.Font("Segoe UI", 10.5!)
        Me.StudentDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black
        Me.StudentDataGridView.ThemeStyle.RowsStyle.Height = 40
        Me.StudentDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.StudentDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black
        '
        'COMNAMEDataGridViewTextBoxColumn
        '
        Me.COMNAMEDataGridViewTextBoxColumn.DataPropertyName = "COM_NAME"
        Me.COMNAMEDataGridViewTextBoxColumn.HeaderText = "الجيهة"
        Me.COMNAMEDataGridViewTextBoxColumn.Name = "COMNAMEDataGridViewTextBoxColumn"
        Me.COMNAMEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'COMNOTESDataGridViewTextBoxColumn
        '
        Me.COMNOTESDataGridViewTextBoxColumn.DataPropertyName = "COM_NOTES"
        Me.COMNOTESDataGridViewTextBoxColumn.HeaderText = "ملاحظات"
        Me.COMNOTESDataGridViewTextBoxColumn.Name = "COMNOTESDataGridViewTextBoxColumn"
        Me.COMNOTESDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.FillWeight = 30.0!
        Me.Column2.HeaderText = ""
        Me.Column2.Image = Global.eDMSystem.My.Resources.Resources.edit
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.FillWeight = 30.0!
        Me.Column3.HeaderText = ""
        Me.Column3.Image = Global.eDMSystem.My.Resources.Resources.delete
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'HSEQCOMBindingSource
        '
        Me.HSEQCOMBindingSource.DataMember = "HSEQ_COM"
        Me.HSEQCOMBindingSource.DataSource = Me.CompaniesDataSet
        '
        'CompaniesDataSet
        '
        Me.CompaniesDataSet.DataSetName = "companiesDataSet"
        Me.CompaniesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextSearch
        '
        Me.TextSearch.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextSearch.Animated = True
        Me.TextSearch.BorderRadius = 8
        Me.TextSearch.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextSearch.DefaultText = ""
        Me.TextSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.TextSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.TextSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextSearch.DisabledState.Parent = Me.TextSearch
        Me.TextSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.TextSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextSearch.FocusedState.Parent = Me.TextSearch
        Me.TextSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.TextSearch.HoverState.Parent = Me.TextSearch
        Me.TextSearch.IconRight = Global.eDMSystem.My.Resources.Resources.search
        Me.TextSearch.Location = New System.Drawing.Point(4, 12)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TextSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextSearch.PlaceholderText = ""
        Me.TextSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextSearch.SelectedText = ""
        Me.TextSearch.ShadowDecoration.Parent = Me.TextSearch
        Me.TextSearch.Size = New System.Drawing.Size(1027, 43)
        Me.TextSearch.TabIndex = 8
        Me.TextSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'HSEQ_COMTableAdapter
        '
        Me.HSEQ_COMTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HSEQ_COMTableAdapter = Me.HSEQ_COMTableAdapter
        Me.TableAdapterManager.UpdateOrder = eDMSystem.companiesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'COM_IDTextBox
        '
        Me.COM_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.HSEQCOMBindingSource, "COM_ID", True))
        Me.COM_IDTextBox.Location = New System.Drawing.Point(388, 22)
        Me.COM_IDTextBox.Multiline = True
        Me.COM_IDTextBox.Name = "COM_IDTextBox"
        Me.COM_IDTextBox.Size = New System.Drawing.Size(5, 5)
        Me.COM_IDTextBox.TabIndex = 9
        '
        'COM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.COM_IDTextBox)
        Me.Name = "COM"
        Me.Size = New System.Drawing.Size(1034, 666)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.StudentDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HSEQCOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CompaniesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents ButtonAddVoter As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents StudentDataGridView As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents TextSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents COMNAMEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents COMNOTESDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents Column3 As DataGridViewImageColumn
    Friend WithEvents HSEQCOMBindingSource As BindingSource
    Friend WithEvents CompaniesDataSet As companiesDataSet
    Friend WithEvents HSEQ_COMTableAdapter As companiesDataSetTableAdapters.HSEQ_COMTableAdapter
    Friend WithEvents TableAdapterManager As companiesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents COM_IDTextBox As TextBox
End Class
