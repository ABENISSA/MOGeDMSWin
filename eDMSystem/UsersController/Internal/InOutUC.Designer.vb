<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InOutUC
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
        Me.TextSearch = New Guna.UI2.WinForms.Guna2TextBox()
        Me.Guna2CustomRadioButton5 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Guna2CustomRadioButton4 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Guna2CustomRadioButton3 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Guna2CustomRadioButton2 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Guna2CustomRadioButton1 = New Guna.UI2.WinForms.Guna2CustomRadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Guna2ShadowPanel1 = New Guna.UI2.WinForms.Guna2ShadowPanel()
        Me.ButtonAddVoter = New Guna.UI2.WinForms.Guna2CircleButton()
        Me.HSEQINTERNALOUTGOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.INOUT = New eDMSystem.INOUT()
        Me.HSEQ_INTERNAL_OUTGOTableAdapter = New eDMSystem.INOUTTableAdapters.HSEQ_INTERNAL_OUTGOTableAdapter()
        Me.TableAdapterManager = New eDMSystem.INOUTTableAdapters.TableAdapterManager()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.VCR_ININ = New eDMSystem.VCR_ININ()
        Me.V_CRININBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_CRININTableAdapter = New eDMSystem.VCR_ININTableAdapters.V_CRININTableAdapter()
        Me.TableAdapterManager1 = New eDMSystem.VCR_ININTableAdapters.TableAdapterManager()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.V_CRINEX = New eDMSystem.V_CRINEX()
        Me.VCRINEXBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.V_CRINEXTableAdapter = New eDMSystem.V_CRINEXTableAdapters.V_CRINEXTableAdapter()
        Me.DOCREFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YearNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCSUBJECTDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOCDATEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SENTTODataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CATDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Print = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Guna2ShadowPanel1.SuspendLayout()
        CType(Me.HSEQINTERNALOUTGOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.INOUT, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VCR_ININ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_CRININBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.V_CRINEX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VCRINEXBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TextSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextSearch.SelectedText = ""
        Me.TextSearch.ShadowDecoration.Parent = Me.TextSearch
        Me.TextSearch.Size = New System.Drawing.Size(365, 31)
        Me.TextSearch.TabIndex = 8
        Me.TextSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Guna2CustomRadioButton5
        '
        Me.Guna2CustomRadioButton5.Animated = True
        Me.Guna2CustomRadioButton5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton5.CheckedState.BorderThickness = 0
        Me.Guna2CustomRadioButton5.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton5.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2CustomRadioButton5.CheckedState.Parent = Me.Guna2CustomRadioButton5
        Me.Guna2CustomRadioButton5.Location = New System.Drawing.Point(716, 11)
        Me.Guna2CustomRadioButton5.Name = "Guna2CustomRadioButton5"
        Me.Guna2CustomRadioButton5.ShadowDecoration.Parent = Me.Guna2CustomRadioButton5
        Me.Guna2CustomRadioButton5.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CustomRadioButton5.TabIndex = 29
        Me.Guna2CustomRadioButton5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CustomRadioButton5.UncheckedState.BorderThickness = 2
        Me.Guna2CustomRadioButton5.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton5.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton5.UncheckedState.Parent = Me.Guna2CustomRadioButton5
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!)
        Me.Label5.Location = New System.Drawing.Point(646, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "حالة الرسالة"
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Guna2CustomRadioButton4
        '
        Me.Guna2CustomRadioButton4.Animated = True
        Me.Guna2CustomRadioButton4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton4.CheckedState.BorderThickness = 0
        Me.Guna2CustomRadioButton4.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton4.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2CustomRadioButton4.CheckedState.Parent = Me.Guna2CustomRadioButton4
        Me.Guna2CustomRadioButton4.Location = New System.Drawing.Point(780, 11)
        Me.Guna2CustomRadioButton4.Name = "Guna2CustomRadioButton4"
        Me.Guna2CustomRadioButton4.ShadowDecoration.Parent = Me.Guna2CustomRadioButton4
        Me.Guna2CustomRadioButton4.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CustomRadioButton4.TabIndex = 27
        Me.Guna2CustomRadioButton4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CustomRadioButton4.UncheckedState.BorderThickness = 2
        Me.Guna2CustomRadioButton4.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton4.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton4.UncheckedState.Parent = Me.Guna2CustomRadioButton4
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!)
        Me.Label4.Location = New System.Drawing.Point(742, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(32, 20)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "ادارة"
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Guna2CustomRadioButton3
        '
        Me.Guna2CustomRadioButton3.Animated = True
        Me.Guna2CustomRadioButton3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton3.CheckedState.BorderThickness = 0
        Me.Guna2CustomRadioButton3.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton3.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2CustomRadioButton3.CheckedState.Parent = Me.Guna2CustomRadioButton3
        Me.Guna2CustomRadioButton3.Location = New System.Drawing.Point(872, 11)
        Me.Guna2CustomRadioButton3.Name = "Guna2CustomRadioButton3"
        Me.Guna2CustomRadioButton3.ShadowDecoration.Parent = Me.Guna2CustomRadioButton3
        Me.Guna2CustomRadioButton3.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CustomRadioButton3.TabIndex = 25
        Me.Guna2CustomRadioButton3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CustomRadioButton3.UncheckedState.BorderThickness = 2
        Me.Guna2CustomRadioButton3.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton3.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton3.UncheckedState.Parent = Me.Guna2CustomRadioButton3
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!)
        Me.Label3.Location = New System.Drawing.Point(810, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(56, 20)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "فئة الرسالة"
        Me.Label3.UseCompatibleTextRendering = True
        '
        'Guna2CustomRadioButton2
        '
        Me.Guna2CustomRadioButton2.Animated = True
        Me.Guna2CustomRadioButton2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton2.CheckedState.BorderThickness = 0
        Me.Guna2CustomRadioButton2.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton2.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2CustomRadioButton2.CheckedState.Parent = Me.Guna2CustomRadioButton2
        Me.Guna2CustomRadioButton2.Location = New System.Drawing.Point(988, 11)
        Me.Guna2CustomRadioButton2.Name = "Guna2CustomRadioButton2"
        Me.Guna2CustomRadioButton2.ShadowDecoration.Parent = Me.Guna2CustomRadioButton2
        Me.Guna2CustomRadioButton2.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CustomRadioButton2.TabIndex = 23
        Me.Guna2CustomRadioButton2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CustomRadioButton2.UncheckedState.BorderThickness = 2
        Me.Guna2CustomRadioButton2.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton2.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton2.UncheckedState.Parent = Me.Guna2CustomRadioButton2
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(897, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(85, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "موضوع الرسالة"
        Me.Label2.UseCompatibleTextRendering = True
        '
        'Guna2CustomRadioButton1
        '
        Me.Guna2CustomRadioButton1.Animated = True
        Me.Guna2CustomRadioButton1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton1.CheckedState.BorderThickness = 0
        Me.Guna2CustomRadioButton1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(9, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(69, Byte), Integer))
        Me.Guna2CustomRadioButton1.CheckedState.InnerColor = System.Drawing.Color.White
        Me.Guna2CustomRadioButton1.CheckedState.Parent = Me.Guna2CustomRadioButton1
        Me.Guna2CustomRadioButton1.Location = New System.Drawing.Point(1086, 11)
        Me.Guna2CustomRadioButton1.Name = "Guna2CustomRadioButton1"
        Me.Guna2CustomRadioButton1.ShadowDecoration.Parent = Me.Guna2CustomRadioButton1
        Me.Guna2CustomRadioButton1.Size = New System.Drawing.Size(20, 20)
        Me.Guna2CustomRadioButton1.TabIndex = 19
        Me.Guna2CustomRadioButton1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2CustomRadioButton1.UncheckedState.BorderThickness = 2
        Me.Guna2CustomRadioButton1.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton1.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        Me.Guna2CustomRadioButton1.UncheckedState.Parent = Me.Guna2CustomRadioButton1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Emoji", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(1016, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "رقم الاشاري"
        Me.Label1.UseCompatibleTextRendering = True
        '
        'Guna2ShadowPanel1
        '
        Me.Guna2ShadowPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ShadowPanel1.Controls.Add(Me.dgv)
        Me.Guna2ShadowPanel1.Controls.Add(Me.ButtonAddVoter)
        Me.Guna2ShadowPanel1.FillColor = System.Drawing.Color.White
        Me.Guna2ShadowPanel1.Location = New System.Drawing.Point(6, 40)
        Me.Guna2ShadowPanel1.Name = "Guna2ShadowPanel1"
        Me.Guna2ShadowPanel1.Radius = 10
        Me.Guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.Guna2ShadowPanel1.Size = New System.Drawing.Size(1171, 651)
        Me.Guna2ShadowPanel1.TabIndex = 21
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
        Me.ButtonAddVoter.Location = New System.Drawing.Point(1105, 587)
        Me.ButtonAddVoter.Name = "ButtonAddVoter"
        Me.ButtonAddVoter.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle
        Me.ButtonAddVoter.ShadowDecoration.Parent = Me.ButtonAddVoter
        Me.ButtonAddVoter.Size = New System.Drawing.Size(46, 45)
        Me.ButtonAddVoter.TabIndex = 6
        '
        'HSEQINTERNALOUTGOBindingSource
        '
        Me.HSEQINTERNALOUTGOBindingSource.DataMember = "HSEQ_INTERNAL_OUTGO"
        Me.HSEQINTERNALOUTGOBindingSource.DataSource = Me.INOUT
        '
        'INOUT
        '
        Me.INOUT.DataSetName = "INOUT"
        Me.INOUT.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'HSEQ_INTERNAL_OUTGOTableAdapter
        '
        Me.HSEQ_INTERNAL_OUTGOTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.HSEQ_INTERNAL_OUTGOTableAdapter = Me.HSEQ_INTERNAL_OUTGOTableAdapter
        Me.TableAdapterManager.UpdateOrder = eDMSystem.INOUTTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(251, Byte), Integer), CType(CType(252, Byte), Integer), CType(CType(253, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Ubuntu Arabic", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dgv.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv.AutoGenerateColumns = False
        Me.dgv.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgv.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgv.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.dgv.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Gainsboro
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Ubuntu Arabic", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.ColumnHeadersHeight = 34
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DOCREFDataGridViewTextBoxColumn, Me.YearNumberDataGridViewTextBoxColumn, Me.DOCSUBJECTDataGridViewTextBoxColumn, Me.DOCDATEDataGridViewTextBoxColumn, Me.SENTTODataGridViewTextBoxColumn, Me.CATDataGridViewTextBoxColumn, Me.Print, Me.Column1, Me.Column2})
        Me.dgv.DataSource = Me.VCRINEXBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Ubuntu Arabic", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer), CType(CType(246, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.EnableHeadersVisualStyles = False
        Me.dgv.GridColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(236, Byte), Integer), CType(CType(241, Byte), Integer))
        Me.dgv.Location = New System.Drawing.Point(8, 11)
        Me.dgv.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgv.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Ubuntu Arabic", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
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
        Me.dgv.Size = New System.Drawing.Size(1153, 690)
        Me.dgv.TabIndex = 15
        Me.dgv.Tag = ""
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 40
        Me.Guna2Elipse1.TargetControl = Me.dgv
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Ubuntu Arabic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
        Me.Label6.Location = New System.Drawing.Point(388, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 29)
        Me.Label6.TabIndex = 31
        Me.Label6.Text = "بحث"
        '
        'VCR_ININ
        '
        Me.VCR_ININ.DataSetName = "VCR_ININ"
        Me.VCR_ININ.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'V_CRININBindingSource
        '
        Me.V_CRININBindingSource.DataMember = "V_CRININ"
        Me.V_CRININBindingSource.DataSource = Me.VCR_ININ
        '
        'V_CRININTableAdapter
        '
        Me.V_CRININTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Connection = Nothing
        Me.TableAdapterManager1.UpdateOrder = eDMSystem.VCR_ININTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.V_CRININBindingSource, "ID", True))
        Me.IDTextBox.Location = New System.Drawing.Point(480, 11)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IDTextBox.TabIndex = 32
        '
        'V_CRINEX
        '
        Me.V_CRINEX.DataSetName = "V_CRINEX"
        Me.V_CRINEX.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VCRINEXBindingSource
        '
        Me.VCRINEXBindingSource.DataMember = "V_CRINEX"
        Me.VCRINEXBindingSource.DataSource = Me.V_CRINEX
        '
        'V_CRINEXTableAdapter
        '
        Me.V_CRINEXTableAdapter.ClearBeforeFill = True
        '
        'DOCREFDataGridViewTextBoxColumn
        '
        Me.DOCREFDataGridViewTextBoxColumn.DataPropertyName = "DOC_REF"
        Me.DOCREFDataGridViewTextBoxColumn.HeaderText = "رقم الاشاري"
        Me.DOCREFDataGridViewTextBoxColumn.Name = "DOCREFDataGridViewTextBoxColumn"
        Me.DOCREFDataGridViewTextBoxColumn.ReadOnly = True
        Me.DOCREFDataGridViewTextBoxColumn.Width = 80
        '
        'YearNumberDataGridViewTextBoxColumn
        '
        Me.YearNumberDataGridViewTextBoxColumn.DataPropertyName = "YearNumber"
        Me.YearNumberDataGridViewTextBoxColumn.HeaderText = "السنة"
        Me.YearNumberDataGridViewTextBoxColumn.Name = "YearNumberDataGridViewTextBoxColumn"
        Me.YearNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.YearNumberDataGridViewTextBoxColumn.Width = 90
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
        Me.CATDataGridViewTextBoxColumn.Width = 90
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
        'InOutUC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Guna2CustomRadioButton5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Guna2CustomRadioButton4)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Guna2CustomRadioButton3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Guna2CustomRadioButton2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Guna2CustomRadioButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Guna2ShadowPanel1)
        Me.Controls.Add(Me.TextSearch)
        Me.Name = "InOutUC"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Size = New System.Drawing.Size(1181, 694)
        Me.Guna2ShadowPanel1.ResumeLayout(False)
        CType(Me.HSEQINTERNALOUTGOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.INOUT, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VCR_ININ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_CRININBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.V_CRINEX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VCRINEXBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2CustomRadioButton5 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Guna2CustomRadioButton4 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents Guna2CustomRadioButton3 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Guna2CustomRadioButton2 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Guna2CustomRadioButton1 As Guna.UI2.WinForms.Guna2CustomRadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Guna2ShadowPanel1 As Guna.UI2.WinForms.Guna2ShadowPanel
    Friend WithEvents ButtonAddVoter As Guna.UI2.WinForms.Guna2CircleButton
    Friend WithEvents HSEQINTERNALOUTGOBindingSource As BindingSource
    Friend WithEvents INOUT As INOUT
    Friend WithEvents HSEQ_INTERNAL_OUTGOTableAdapter As INOUTTableAdapters.HSEQ_INTERNAL_OUTGOTableAdapter
    Friend WithEvents TableAdapterManager As INOUTTableAdapters.TableAdapterManager
    Friend WithEvents dgv As DataGridView
    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents DOCREFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YearNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOCSUBJECTDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DOCDATEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SENTTODataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CATDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Print As DataGridViewImageColumn
    Friend WithEvents Column1 As DataGridViewImageColumn
    Friend WithEvents Column2 As DataGridViewImageColumn
    Friend WithEvents VCRINEXBindingSource As BindingSource
    Friend WithEvents V_CRINEX As V_CRINEX
    Friend WithEvents Label6 As Label
    Friend WithEvents VCR_ININ As VCR_ININ
    Friend WithEvents V_CRININBindingSource As BindingSource
    Friend WithEvents V_CRININTableAdapter As VCR_ININTableAdapters.V_CRININTableAdapter
    Friend WithEvents TableAdapterManager1 As VCR_ININTableAdapters.TableAdapterManager
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents V_CRINEXTableAdapter As V_CRINEXTableAdapters.V_CRINEXTableAdapter
End Class
