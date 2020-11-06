<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MarquesForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarquesForm))
        Dim BorderEdges1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties1 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges2 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges3 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties5 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties6 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim BorderEdges4 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges()
        Dim StateProperties7 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Dim StateProperties8 As Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties = New Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties()
        Me.DGVMarques = New System.Windows.Forms.DataGridView()
        Me.btnExit = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnDelete = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnEdit = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.btnAdd = New Bunifu.UI.WinForms.BunifuButton.BunifuButton()
        Me.txtMarque = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGVMarques, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVMarques
        '
        Me.DGVMarques.AllowUserToAddRows = False
        Me.DGVMarques.AllowUserToDeleteRows = False
        Me.DGVMarques.AllowUserToResizeColumns = False
        Me.DGVMarques.AllowUserToResizeRows = False
        Me.DGVMarques.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DGVMarques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMarques.BackgroundColor = System.Drawing.Color.DodgerBlue
        Me.DGVMarques.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.DodgerBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DGVMarques.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVMarques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMarques.Location = New System.Drawing.Point(2, 191)
        Me.DGVMarques.Name = "DGVMarques"
        Me.DGVMarques.ReadOnly = True
        Me.DGVMarques.RowHeadersVisible = False
        Me.DGVMarques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGVMarques.Size = New System.Drawing.Size(882, 314)
        Me.DGVMarques.TabIndex = 14
        '
        'btnExit
        '
        Me.btnExit.AllowToggling = False
        Me.btnExit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnExit.AnimationSpeed = 200
        Me.btnExit.AutoGenerateColors = False
        Me.btnExit.BackColor = System.Drawing.Color.Transparent
        Me.btnExit.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnExit.BackgroundImage = CType(resources.GetObject("btnExit.BackgroundImage"), System.Drawing.Image)
        Me.btnExit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnExit.ButtonText = "Fermer"
        Me.btnExit.ButtonTextMarginLeft = 0
        Me.btnExit.ColorContrastOnClick = 45
        Me.btnExit.ColorContrastOnHover = 45
        Me.btnExit.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges1.BottomLeft = True
        BorderEdges1.BottomRight = True
        BorderEdges1.TopLeft = True
        BorderEdges1.TopRight = True
        Me.btnExit.CustomizableEdges = BorderEdges1
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnExit.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnExit.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnExit.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnExit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnExit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.IconMarginLeft = 11
        Me.btnExit.IconPadding = 10
        Me.btnExit.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnExit.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.IdleBorderRadius = 25
        Me.btnExit.IdleBorderThickness = 1
        Me.btnExit.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnExit.IdleIconLeftImage = Nothing
        Me.btnExit.IdleIconRightImage = Nothing
        Me.btnExit.IndicateFocus = False
        Me.btnExit.Location = New System.Drawing.Point(631, 140)
        Me.btnExit.Name = "btnExit"
        StateProperties1.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.BorderRadius = 25
        StateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties1.BorderThickness = 1
        StateProperties1.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties1.ForeColor = System.Drawing.Color.White
        StateProperties1.IconLeftImage = Nothing
        StateProperties1.IconRightImage = Nothing
        Me.btnExit.onHoverState = StateProperties1
        StateProperties2.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.BorderRadius = 25
        StateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties2.BorderThickness = 1
        StateProperties2.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties2.ForeColor = System.Drawing.Color.White
        StateProperties2.IconLeftImage = Nothing
        StateProperties2.IconRightImage = Nothing
        Me.btnExit.OnPressedState = StateProperties2
        Me.btnExit.Size = New System.Drawing.Size(150, 45)
        Me.btnExit.TabIndex = 10
        Me.btnExit.TabStop = False
        Me.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnExit.TextMarginLeft = 0
        Me.btnExit.UseDefaultRadiusAndThickness = True
        '
        'btnDelete
        '
        Me.btnDelete.AllowToggling = False
        Me.btnDelete.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnDelete.AnimationSpeed = 200
        Me.btnDelete.AutoGenerateColors = False
        Me.btnDelete.BackColor = System.Drawing.Color.Transparent
        Me.btnDelete.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnDelete.BackgroundImage = CType(resources.GetObject("btnDelete.BackgroundImage"), System.Drawing.Image)
        Me.btnDelete.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnDelete.ButtonText = "Supprimer"
        Me.btnDelete.ButtonTextMarginLeft = 0
        Me.btnDelete.ColorContrastOnClick = 45
        Me.btnDelete.ColorContrastOnHover = 45
        Me.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges2.BottomLeft = True
        BorderEdges2.BottomRight = True
        BorderEdges2.TopLeft = True
        BorderEdges2.TopRight = True
        Me.btnDelete.CustomizableEdges = BorderEdges2
        Me.btnDelete.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnDelete.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnDelete.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnDelete.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnDelete.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnDelete.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.ForeColor = System.Drawing.Color.White
        Me.btnDelete.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.IconMarginLeft = 11
        Me.btnDelete.IconPadding = 10
        Me.btnDelete.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnDelete.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnDelete.IdleBorderRadius = 25
        Me.btnDelete.IdleBorderThickness = 1
        Me.btnDelete.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnDelete.IdleIconLeftImage = Nothing
        Me.btnDelete.IdleIconRightImage = Nothing
        Me.btnDelete.IndicateFocus = False
        Me.btnDelete.Location = New System.Drawing.Point(457, 140)
        Me.btnDelete.Name = "btnDelete"
        StateProperties3.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.BorderRadius = 25
        StateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties3.BorderThickness = 1
        StateProperties3.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties3.ForeColor = System.Drawing.Color.White
        StateProperties3.IconLeftImage = Nothing
        StateProperties3.IconRightImage = Nothing
        Me.btnDelete.onHoverState = StateProperties3
        StateProperties4.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.BorderRadius = 25
        StateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties4.BorderThickness = 1
        StateProperties4.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties4.ForeColor = System.Drawing.Color.White
        StateProperties4.IconLeftImage = Nothing
        StateProperties4.IconRightImage = Nothing
        Me.btnDelete.OnPressedState = StateProperties4
        Me.btnDelete.Size = New System.Drawing.Size(150, 45)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.TabStop = False
        Me.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnDelete.TextMarginLeft = 0
        Me.btnDelete.UseDefaultRadiusAndThickness = True
        '
        'btnEdit
        '
        Me.btnEdit.AllowToggling = False
        Me.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnEdit.AnimationSpeed = 200
        Me.btnEdit.AutoGenerateColors = False
        Me.btnEdit.BackColor = System.Drawing.Color.Transparent
        Me.btnEdit.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnEdit.BackgroundImage = CType(resources.GetObject("btnEdit.BackgroundImage"), System.Drawing.Image)
        Me.btnEdit.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnEdit.ButtonText = "Modifier"
        Me.btnEdit.ButtonTextMarginLeft = 0
        Me.btnEdit.ColorContrastOnClick = 45
        Me.btnEdit.ColorContrastOnHover = 45
        Me.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges3.BottomLeft = True
        BorderEdges3.BottomRight = True
        BorderEdges3.TopLeft = True
        BorderEdges3.TopRight = True
        Me.btnEdit.CustomizableEdges = BorderEdges3
        Me.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnEdit.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnEdit.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnEdit.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnEdit.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnEdit.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.ForeColor = System.Drawing.Color.White
        Me.btnEdit.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.IconMarginLeft = 11
        Me.btnEdit.IconPadding = 10
        Me.btnEdit.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnEdit.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnEdit.IdleBorderRadius = 25
        Me.btnEdit.IdleBorderThickness = 1
        Me.btnEdit.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnEdit.IdleIconLeftImage = Nothing
        Me.btnEdit.IdleIconRightImage = Nothing
        Me.btnEdit.IndicateFocus = False
        Me.btnEdit.Location = New System.Drawing.Point(274, 140)
        Me.btnEdit.Name = "btnEdit"
        StateProperties5.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties5.BorderRadius = 25
        StateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties5.BorderThickness = 1
        StateProperties5.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties5.ForeColor = System.Drawing.Color.White
        StateProperties5.IconLeftImage = Nothing
        StateProperties5.IconRightImage = Nothing
        Me.btnEdit.onHoverState = StateProperties5
        StateProperties6.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.BorderRadius = 25
        StateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties6.BorderThickness = 1
        StateProperties6.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties6.ForeColor = System.Drawing.Color.White
        StateProperties6.IconLeftImage = Nothing
        StateProperties6.IconRightImage = Nothing
        Me.btnEdit.OnPressedState = StateProperties6
        Me.btnEdit.Size = New System.Drawing.Size(150, 45)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.TabStop = False
        Me.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnEdit.TextMarginLeft = 0
        Me.btnEdit.UseDefaultRadiusAndThickness = True
        '
        'btnAdd
        '
        Me.btnAdd.AllowToggling = False
        Me.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btnAdd.AnimationSpeed = 200
        Me.btnAdd.AutoGenerateColors = False
        Me.btnAdd.BackColor = System.Drawing.Color.Transparent
        Me.btnAdd.BackColor1 = System.Drawing.Color.DodgerBlue
        Me.btnAdd.BackgroundImage = CType(resources.GetObject("btnAdd.BackgroundImage"), System.Drawing.Image)
        Me.btnAdd.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        Me.btnAdd.ButtonText = "Ajouter"
        Me.btnAdd.ButtonTextMarginLeft = 0
        Me.btnAdd.ColorContrastOnClick = 45
        Me.btnAdd.ColorContrastOnHover = 45
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        BorderEdges4.BottomLeft = True
        BorderEdges4.BottomRight = True
        BorderEdges4.TopLeft = True
        BorderEdges4.TopRight = True
        Me.btnAdd.CustomizableEdges = BorderEdges4
        Me.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnAdd.DisabledBorderColor = System.Drawing.Color.FromArgb(CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer), CType(CType(191, Byte), Integer))
        Me.btnAdd.DisabledFillColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.btnAdd.DisabledForecolor = System.Drawing.Color.FromArgb(CType(CType(168, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(168, Byte), Integer))
        Me.btnAdd.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed
        Me.btnAdd.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.White
        Me.btnAdd.IconLeftCursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.IconMarginLeft = 11
        Me.btnAdd.IconPadding = 10
        Me.btnAdd.IconRightCursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.IdleBorderColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd.IdleBorderRadius = 25
        Me.btnAdd.IdleBorderThickness = 1
        Me.btnAdd.IdleFillColor = System.Drawing.Color.DodgerBlue
        Me.btnAdd.IdleIconLeftImage = Nothing
        Me.btnAdd.IdleIconRightImage = Nothing
        Me.btnAdd.IndicateFocus = False
        Me.btnAdd.Location = New System.Drawing.Point(93, 140)
        Me.btnAdd.Name = "btnAdd"
        StateProperties7.BorderColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.BorderRadius = 25
        StateProperties7.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties7.BorderThickness = 1
        StateProperties7.FillColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(181, Byte), Integer), CType(CType(255, Byte), Integer))
        StateProperties7.ForeColor = System.Drawing.Color.White
        StateProperties7.IconLeftImage = Nothing
        StateProperties7.IconRightImage = Nothing
        Me.btnAdd.onHoverState = StateProperties7
        StateProperties8.BorderColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties8.BorderRadius = 25
        StateProperties8.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid
        StateProperties8.BorderThickness = 1
        StateProperties8.FillColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(96, Byte), Integer), CType(CType(144, Byte), Integer))
        StateProperties8.ForeColor = System.Drawing.Color.White
        StateProperties8.IconLeftImage = Nothing
        StateProperties8.IconRightImage = Nothing
        Me.btnAdd.OnPressedState = StateProperties8
        Me.btnAdd.Size = New System.Drawing.Size(150, 45)
        Me.btnAdd.TabIndex = 13
        Me.btnAdd.TabStop = False
        Me.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.btnAdd.TextMarginLeft = 0
        Me.btnAdd.UseDefaultRadiusAndThickness = True
        '
        'txtMarque
        '
        Me.txtMarque.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtMarque.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMarque.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarque.Location = New System.Drawing.Point(385, 71)
        Me.txtMarque.Name = "txtMarque"
        Me.txtMarque.Size = New System.Drawing.Size(200, 16)
        Me.txtMarque.TabIndex = 17
        Me.txtMarque.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Location = New System.Drawing.Point(385, 87)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 3)
        Me.Panel1.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(308, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Marque : "
        '
        'MarquesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(886, 508)
        Me.Controls.Add(Me.txtMarque)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVMarques)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "MarquesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MarquesForm"
        CType(Me.DGVMarques, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVMarques As DataGridView
    Friend WithEvents btnExit As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnDelete As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnEdit As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents btnAdd As Bunifu.UI.WinForms.BunifuButton.BunifuButton
    Friend WithEvents txtMarque As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
