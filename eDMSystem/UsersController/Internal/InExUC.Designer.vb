<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InExUC
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InExUC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.DOCREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCSUBJECTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SENTTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Print = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.VINEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_INEX = New eDMSystem.V_INEX()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
        Me.Guna2Button6 = New Guna.UI2.WinForms.Guna2Button()
        Me.V_INEXTableAdapter = New eDMSystem.V_INEXTableAdapters.V_INEXTableAdapter()
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.TableAdapterManager = New eDMSystem.V_INEXTableAdapters.TableAdapterManager()
        Me.IDTextBox1 = New System.Windows.Forms.TextBox()
        Me.ButtonAddVoter = New Guna.UI2.WinForms.Guna2CircleButton()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VINEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_INEX, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Ubuntu Arabic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label1.Location = New System.Drawing.Point(354, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 29)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "بحث"
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
        Me.TextSearch.Location = New System.Drawing.Point(3, 3)
        Me.TextSearch.Name = "TextSearch"
        Me.TextSearch.Padding = New System.Windows.Forms.Padding(10, 0, 0, 0)
        Me.TextSearch.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TextSearch.PlaceholderText = ""
        Me.TextSearch.SelectedText = ""
        Me.TextSearch.ShadowDecoration.Parent = Me.TextSearch
        Me.TextSearch.Size = New System.Drawing.Size(345, 31)
        Me.TextSearch.TabIndex = 21
        Me.TextSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(333, 10)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(10, 20)
        Me.IDTextBox.TabIndex = 23
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Ubuntu Arabic", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Ubuntu Arabic", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgv.ColumnHeadersHeight = 34
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DOCREFDataGridViewTextBoxColumn, Me.YearNumberDataGridViewTextBoxColumn, Me.DOCSUBJECTDataGridViewTextBoxColumn, Me.DOCDATEDataGridViewTextBoxColumn, Me.SENTTODataGridViewTextBoxColumn, Me.CATDataGridViewTextBoxColumn, Me.Print, Me.Column1, Me.Column2})
        Me.dgv.DataSource = Me.VINEXBindingSource
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Ubuntu Arabic", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(3, 42)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Ubuntu Arabic", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgv.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.dgv.RowTemplate.DefaultCellStyle.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!)
        Me.dgv.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.dgv.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv.RowTemplate.DefaultCellStyle.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.RowTemplate.Height = 30
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1172, 665)
        Me.dgv.TabIndex = 24
        Me.dgv.Tag = ""
        '
        'DOCREFDataGridViewTextBoxColumn
        '
        Me.DOCREFDataGridViewTextBoxColumn.DataPropertyName = "DOC_REF"
        Me.DOCREFDataGridViewTextBoxColumn.HeaderText = "رقم الاشاري"
        Me.DOCREFDataGridViewTextBoxColumn.Name = "DOCREFDataGridViewTextBoxColumn"
        Me.DOCREFDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOCREFDataGridViewTextBoxColumn.Width = 95
        '
        'YearNumberDataGridViewTextBoxColumn
        '
        Me.YearNumberDataGridViewTextBoxColumn.DataPropertyName = "YearNumber"
        Me.YearNumberDataGridViewTextBoxColumn.HeaderText = "السنة"
        Me.YearNumberDataGridViewTextBoxColumn.Name = "YearNumberDataGridViewTextBoxColumn"
        Me.YearNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.YearNumberDataGridViewTextBoxColumn.Width = 95
        '
        'DOCSUBJECTDataGridViewTextBoxColumn
        '
        Me.DOCSUBJECTDataGridViewTextBoxColumn.DataPropertyName = "DOC_SUBJECT"
        Me.DOCSUBJECTDataGridViewTextBoxColumn.HeaderText = "العنوان"
        Me.DOCSUBJECTDataGridViewTextBoxColumn.Name = "DOCSUBJECTDataGridViewTextBoxColumn"
        Me.DOCSUBJECTDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOCSUBJECTDataGridViewTextBoxColumn.Width = 350
        '
        'DOCDATEDataGridViewTextBoxColumn
        '
        Me.DOCDATEDataGridViewTextBoxColumn.DataPropertyName = "DOC_DATE"
        Me.DOCDATEDataGridViewTextBoxColumn.HeaderText = "تاريخ الرسالة"
        Me.DOCDATEDataGridViewTextBoxColumn.Name = "DOCDATEDataGridViewTextBoxColumn"
        Me.DOCDATEDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SENTTODataGridViewTextBoxColumn
        '
        Me.SENTTODataGridViewTextBoxColumn.DataPropertyName = "SENT_TO"
        Me.SENTTODataGridViewTextBoxColumn.HeaderText = "جهة الاتصال"
        Me.SENTTODataGridViewTextBoxColumn.Name = "SENTTODataGridViewTextBoxColumn"
        Me.SENTTODataGridViewTextBoxColumn.ReadOnly = True
        Me.SENTTODataGridViewTextBoxColumn.Width = 150
        '
        'CATDataGridViewTextBoxColumn
        '
        Me.CATDataGridViewTextBoxColumn.DataPropertyName = "CAT"
        Me.CATDataGridViewTextBoxColumn.HeaderText = "فئة الرسالة"
        Me.CATDataGridViewTextBoxColumn.Name = "CATDataGridViewTextBoxColumn"
        Me.CATDataGridViewTextBoxColumn.ReadOnly = True
        Me.CATDataGridViewTextBoxColumn.Width = 120
        '
        'Print
        '
        Me.Print.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Print.HeaderText = ""
        Me.Print.Image = Global.eDMSystem.My.Resources.Resources.eye
        Me.Print.Name = "Print"
        Me.Print.ReadOnly = True
        Me.Print.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Print.Width = 55
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column1.HeaderText = ""
        Me.Column1.Image = Global.eDMSystem.My.Resources.Resources.edit1
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column1.Width = 55
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.Column2.HeaderText = ""
        Me.Column2.Image = Global.eDMSystem.My.Resources.Resources.delete1
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.Column2.Width = 55
        '
        'VINEXBindingSource
        '
        Me.VINEXBindingSource.DataMember = "V_INEX"
        Me.VINEXBindingSource.DataSource = Me.V_INEX
        '
        'V_INEX
        '
        Me.V_INEX.DataSetName = "V_INEX"
        Me.V_INEX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Ubuntu Arabic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(879, 1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(184, 34)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "صادر للمراسلات الداخلية"
        '
        'Guna2Button1
        '
        Me.Guna2Button1.Animated = True
        Me.Guna2Button1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.BorderRadius = 10
        Me.Guna2Button1.CheckedState.Parent = Me.Guna2Button1
        Me.Guna2Button1.CustomImages.Parent = Me.Guna2Button1
        Me.Guna2Button1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Button1.HoverState.Parent = Me.Guna2Button1
        Me.Guna2Button1.Image = Global.eDMSystem.My.Resources.Resources.letter1
        Me.Guna2Button1.ImageSize = New System.Drawing.Size(35, 35)
        Me.Guna2Button1.Location = New System.Drawing.Point(1135, 0)
        Me.Guna2Button1.Name = "Guna2Button1"
        Me.Guna2Button1.ShadowDecoration.Parent = Me.Guna2Button1
        Me.Guna2Button1.Size = New System.Drawing.Size(33, 40)
        Me.Guna2Button1.TabIndex = 70
        '
        'Guna2Button6
        '
        Me.Guna2Button6.Animated = True
        Me.Guna2Button6.BackColor = System.Drawing.Color.Transparent
        Me.Guna2Button6.BorderRadius = 10
        Me.Guna2Button6.CheckedState.Parent = Me.Guna2Button6
        Me.Guna2Button6.CustomImages.Parent = Me.Guna2Button6
        Me.Guna2Button6.FillColor = System.Drawing.Color.Transparent
        Me.Guna2Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Guna2Button6.ForeColor = System.Drawing.Color.Transparent
        Me.Guna2Button6.HoverState.Parent = Me.Guna2Button6
        Me.Guna2Button6.Image = Global.eDMSystem.My.Resources.Resources.left_arrow
        Me.Guna2Button6.ImageSize = New System.Drawing.Size(35, 35)
        Me.Guna2Button6.Location = New System.Drawing.Point(1069, 0)
        Me.Guna2Button6.Name = "Guna2Button6"
        Me.Guna2Button6.ShadowDecoration.Parent = Me.Guna2Button6
        Me.Guna2Button6.Size = New System.Drawing.Size(42, 34)
        Me.Guna2Button6.TabIndex = 69
        '
        'V_INEXTableAdapter
        '
        Me.V_INEXTableAdapter.ClearBeforeFill = True
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "إشعار"
        Me.NotifyIcon1.Visible = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = eDMSystem.V_INEXTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox1
        '
        Me.IDTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VINEXBindingSource, "ID", True))
        Me.IDTextBox1.Location = New System.Drawing.Point(87, 9)
        Me.IDTextBox1.Name = "IDTextBox1"
        Me.IDTextBox1.Size = New System.Drawing.Size(18, 20)
        Me.IDTextBox1.TabIndex = 72
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
        Me.ButtonAddVoter.Location = New System.Drawing.Point(1129, 659)
        Me.ButtonAddVoter.Name = "ButtonAddVoter"
        Me.ButtonAddVoter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ButtonAddVoter.ShadowDecoration.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.Size = New System.Drawing.Size(46, 48)
        Me.ButtonAddVoter.TabIndex = 73
        '
        'InExUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ButtonAddVoter)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2Button1)
        Me.Controls.Add(Me.Guna2Button6)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextSearch)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.IDTextBox1)
        Me.Name = "InExUC"
        Me.Size = New System.Drawing.Size(1178, 712)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VINEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_INEX, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents dgv As DataGridView
    Friend WithEvents DOCREFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOCSUBJECTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOCDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SENTTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Print As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents VINEXBindingSource As BindingSource
    Friend WithEvents V_INEX As V_INEX
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2Button6 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents V_INEXTableAdapter As V_INEXTableAdapters.V_INEXTableAdapter
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents TableAdapterManager As V_INEXTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox1 As TextBox
    Friend WithEvents ButtonAddVoter As Guna.UI2.WinForms.Guna2CircleButton
End Class
