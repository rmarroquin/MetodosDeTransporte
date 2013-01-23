<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVoguel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmVoguel))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblResultado = New System.Windows.Forms.Label
        Me.btnNueva = New System.Windows.Forms.Button
        Me.btnsiguiente = New System.Windows.Forms.Button
        Me.lbldescripcion = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtColumnas = New System.Windows.Forms.TextBox
        Me.txtFilas = New System.Windows.Forms.TextBox
        Me.dgvtabla = New System.Windows.Forms.DataGridView
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.tslresultado = New System.Windows.Forms.ToolStripStatusLabel
        Me.dgvoferta = New System.Windows.Forms.DataGridView
        Me.dgvdemanda = New System.Windows.Forms.DataGridView
        Me.lblnotas = New System.Windows.Forms.ListBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgvoferta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvdemanda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.ForeColor = System.Drawing.Color.Red
        Me.lblResultado.Location = New System.Drawing.Point(14, 463)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 18)
        Me.lblResultado.TabIndex = 29
        '
        'btnNueva
        '
        Me.btnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.Location = New System.Drawing.Point(588, 39)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(85, 65)
        Me.btnNueva.TabIndex = 4
        Me.btnNueva.Text = "&Nueva tabla"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnNueva, "Crear Nueva tabla")
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Image = CType(resources.GetObject("btnsiguiente.Image"), System.Drawing.Image)
        Me.btnsiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsiguiente.Location = New System.Drawing.Point(474, 39)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(92, 65)
        Me.btnsiguiente.TabIndex = 3
        Me.btnsiguiente.Text = "&Siguiente Paso"
        Me.btnsiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnsiguiente, "Mostrar siguiente paso de Voguel")
        Me.btnsiguiente.UseVisualStyleBackColor = True
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.ForeColor = System.Drawing.Color.Red
        Me.lbldescripcion.Location = New System.Drawing.Point(12, 126)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(0, 16)
        Me.lbldescripcion.TabIndex = 27
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtColumnas)
        Me.GroupBox1.Controls.Add(Me.txtFilas)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 98)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Elementos de la Tabla Inicial"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label2.Location = New System.Drawing.Point(20, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Número de Columnas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(20, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Número de Filas:"
        '
        'txtColumnas
        '
        Me.txtColumnas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtColumnas.Location = New System.Drawing.Point(156, 28)
        Me.txtColumnas.Name = "txtColumnas"
        Me.txtColumnas.Size = New System.Drawing.Size(147, 21)
        Me.txtColumnas.TabIndex = 0
        '
        'txtFilas
        '
        Me.txtFilas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilas.Location = New System.Drawing.Point(156, 61)
        Me.txtFilas.Name = "txtFilas"
        Me.txtFilas.Size = New System.Drawing.Size(147, 21)
        Me.txtFilas.TabIndex = 1
        '
        'dgvtabla
        '
        Me.dgvtabla.AllowUserToAddRows = False
        Me.dgvtabla.AllowUserToDeleteRows = False
        Me.dgvtabla.AllowUserToResizeColumns = False
        Me.dgvtabla.AllowUserToResizeRows = False
        Me.dgvtabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvtabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvtabla.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvtabla.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvtabla.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvtabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvtabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvtabla.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvtabla.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvtabla.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvtabla.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgvtabla.Location = New System.Drawing.Point(8, 155)
        Me.dgvtabla.MultiSelect = False
        Me.dgvtabla.Name = "dgvtabla"
        Me.dgvtabla.Size = New System.Drawing.Size(384, 168)
        Me.dgvtabla.TabIndex = 25
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Image = CType(resources.GetObject("btnIniciar.Image"), System.Drawing.Image)
        Me.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIniciar.Location = New System.Drawing.Point(360, 41)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(94, 63)
        Me.btnIniciar.TabIndex = 2
        Me.btnIniciar.Text = "&Iniciar Método"
        Me.btnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ToolTip1.SetToolTip(Me.btnIniciar, "Ingresar datos a la tabla")
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(714, 24)
        Me.MenuStrip1.TabIndex = 30
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem1})
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AcercaDeToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem1
        '
        Me.AcercaDeToolStripMenuItem1.Name = "AcercaDeToolStripMenuItem1"
        Me.AcercaDeToolStripMenuItem1.Size = New System.Drawing.Size(133, 22)
        Me.AcercaDeToolStripMenuItem1.Text = "Acerca de"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tslresultado})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 482)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(714, 22)
        Me.StatusStrip1.TabIndex = 31
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tslresultado
        '
        Me.tslresultado.Name = "tslresultado"
        Me.tslresultado.Size = New System.Drawing.Size(22, 17)
        Me.tslresultado.Text = "res"
        Me.tslresultado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvoferta
        '
        Me.dgvoferta.AllowUserToAddRows = False
        Me.dgvoferta.AllowUserToDeleteRows = False
        Me.dgvoferta.AllowUserToResizeColumns = False
        Me.dgvoferta.AllowUserToResizeRows = False
        Me.dgvoferta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvoferta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvoferta.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvoferta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvoferta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvoferta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvoferta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvoferta.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvoferta.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgvoferta.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvoferta.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgvoferta.Location = New System.Drawing.Point(398, 155)
        Me.dgvoferta.MultiSelect = False
        Me.dgvoferta.Name = "dgvoferta"
        Me.dgvoferta.RowHeadersVisible = False
        Me.dgvoferta.Size = New System.Drawing.Size(304, 168)
        Me.dgvoferta.TabIndex = 32
        '
        'dgvdemanda
        '
        Me.dgvdemanda.AllowUserToAddRows = False
        Me.dgvdemanda.AllowUserToDeleteRows = False
        Me.dgvdemanda.AllowUserToResizeColumns = False
        Me.dgvdemanda.AllowUserToResizeRows = False
        Me.dgvdemanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvdemanda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvdemanda.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.dgvdemanda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvdemanda.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.Red
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvdemanda.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvdemanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdemanda.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvdemanda.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgvdemanda.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke
        Me.dgvdemanda.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.dgvdemanda.Location = New System.Drawing.Point(8, 348)
        Me.dgvdemanda.MultiSelect = False
        Me.dgvdemanda.Name = "dgvdemanda"
        Me.dgvdemanda.Size = New System.Drawing.Size(384, 109)
        Me.dgvdemanda.TabIndex = 33
        '
        'lblnotas
        '
        Me.lblnotas.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblnotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotas.ForeColor = System.Drawing.Color.Red
        Me.lblnotas.FormattingEnabled = True
        Me.lblnotas.HorizontalScrollbar = True
        Me.lblnotas.ItemHeight = 15
        Me.lblnotas.Location = New System.Drawing.Point(398, 348)
        Me.lblnotas.Name = "lblnotas"
        Me.lblnotas.ScrollAlwaysVisible = True
        Me.lblnotas.Size = New System.Drawing.Size(304, 109)
        Me.lblnotas.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(401, 136)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 16)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Tabla Oferta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(5, 329)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 16)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Tabla Demanda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(395, 329)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Observaciones:"
        '
        'frmVoguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 504)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblnotas)
        Me.Controls.Add(Me.dgvdemanda)
        Me.Controls.Add(Me.dgvoferta)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvtabla)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.MenuStrip1)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmVoguel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Método de Voguel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgvoferta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvdemanda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtColumnas As System.Windows.Forms.TextBox
    Friend WithEvents txtFilas As System.Windows.Forms.TextBox
    Friend WithEvents dgvtabla As System.Windows.Forms.DataGridView
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tslresultado As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents dgvoferta As System.Windows.Forms.DataGridView
    Friend WithEvents dgvdemanda As System.Windows.Forms.DataGridView
    Friend WithEvents lblnotas As System.Windows.Forms.ListBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ToolTip2 As System.Windows.Forms.ToolTip
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
