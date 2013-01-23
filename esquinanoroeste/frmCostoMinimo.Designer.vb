<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCostoMinimo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCostoMinimo))
        Me.lblResultado = New System.Windows.Forms.Label
        Me.lblnotas = New System.Windows.Forms.Label
        Me.lbldescripcion = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtColumnas = New System.Windows.Forms.TextBox
        Me.txtFilas = New System.Windows.Forms.TextBox
        Me.dgvtabla = New System.Windows.Forms.DataGridView
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnNueva = New System.Windows.Forms.Button
        Me.btnsiguiente = New System.Windows.Forms.Button
        Me.btnIniciar = New System.Windows.Forms.Button
        Me.lstnotas = New System.Windows.Forms.ListBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblResultado
        '
        Me.lblResultado.AutoSize = True
        Me.lblResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultado.ForeColor = System.Drawing.Color.Red
        Me.lblResultado.Location = New System.Drawing.Point(286, 488)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(0, 15)
        Me.lblResultado.TabIndex = 20
        '
        'lblnotas
        '
        Me.lblnotas.AutoSize = True
        Me.lblnotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnotas.ForeColor = System.Drawing.Color.Red
        Me.lblnotas.Location = New System.Drawing.Point(12, 491)
        Me.lblnotas.Name = "lblnotas"
        Me.lblnotas.Size = New System.Drawing.Size(0, 15)
        Me.lblnotas.TabIndex = 19
        '
        'lbldescripcion
        '
        Me.lbldescripcion.AutoSize = True
        Me.lbldescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldescripcion.ForeColor = System.Drawing.Color.Red
        Me.lbldescripcion.Location = New System.Drawing.Point(12, 145)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(0, 15)
        Me.lbldescripcion.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtColumnas)
        Me.GroupBox1.Controls.Add(Me.txtFilas)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(296, 98)
        Me.GroupBox1.TabIndex = 17
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
        Me.txtColumnas.Size = New System.Drawing.Size(118, 21)
        Me.txtColumnas.TabIndex = 0
        '
        'txtFilas
        '
        Me.txtFilas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFilas.Location = New System.Drawing.Point(156, 61)
        Me.txtFilas.Name = "txtFilas"
        Me.txtFilas.Size = New System.Drawing.Size(118, 21)
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
        Me.dgvtabla.Location = New System.Drawing.Point(12, 165)
        Me.dgvtabla.MultiSelect = False
        Me.dgvtabla.Name = "dgvtabla"
        Me.dgvtabla.Size = New System.Drawing.Size(567, 212)
        Me.dgvtabla.TabIndex = 16
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(593, 24)
        Me.MenuStrip1.TabIndex = 21
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
        'btnNueva
        '
        Me.btnNueva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNueva.Image = CType(resources.GetObject("btnNueva.Image"), System.Drawing.Image)
        Me.btnNueva.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnNueva.Location = New System.Drawing.Point(498, 48)
        Me.btnNueva.Name = "btnNueva"
        Me.btnNueva.Size = New System.Drawing.Size(83, 65)
        Me.btnNueva.TabIndex = 27
        Me.btnNueva.Text = "&Nueva tabla"
        Me.btnNueva.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnNueva.UseVisualStyleBackColor = True
        '
        'btnsiguiente
        '
        Me.btnsiguiente.Image = CType(resources.GetObject("btnsiguiente.Image"), System.Drawing.Image)
        Me.btnsiguiente.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnsiguiente.Location = New System.Drawing.Point(406, 49)
        Me.btnsiguiente.Name = "btnsiguiente"
        Me.btnsiguiente.Size = New System.Drawing.Size(86, 64)
        Me.btnsiguiente.TabIndex = 26
        Me.btnsiguiente.Text = "&Siguiente Paso"
        Me.btnsiguiente.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnsiguiente.UseVisualStyleBackColor = True
        '
        'btnIniciar
        '
        Me.btnIniciar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIniciar.Image = CType(resources.GetObject("btnIniciar.Image"), System.Drawing.Image)
        Me.btnIniciar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIniciar.Location = New System.Drawing.Point(313, 50)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(87, 64)
        Me.btnIniciar.TabIndex = 25
        Me.btnIniciar.Text = "&Iniciar Método"
        Me.btnIniciar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'lstnotas
        '
        Me.lstnotas.FormattingEnabled = True
        Me.lstnotas.HorizontalScrollbar = True
        Me.lstnotas.Location = New System.Drawing.Point(15, 403)
        Me.lstnotas.Name = "lstnotas"
        Me.lstnotas.Size = New System.Drawing.Size(563, 82)
        Me.lstnotas.TabIndex = 28
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(12, 385)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 15)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Observaciones:"
        '
        'frmCostoMinimo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(593, 515)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lstnotas)
        Me.Controls.Add(Me.btnNueva)
        Me.Controls.Add(Me.btnsiguiente)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.lblResultado)
        Me.Controls.Add(Me.lblnotas)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgvtabla)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCostoMinimo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Método de Costo Minimo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvtabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblResultado As System.Windows.Forms.Label
    Friend WithEvents lblnotas As System.Windows.Forms.Label
    Friend WithEvents lbldescripcion As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtColumnas As System.Windows.Forms.TextBox
    Friend WithEvents txtFilas As System.Windows.Forms.TextBox
    Friend WithEvents dgvtabla As System.Windows.Forms.DataGridView
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnNueva As System.Windows.Forms.Button
    Friend WithEvents btnsiguiente As System.Windows.Forms.Button
    Friend WithEvents btnIniciar As System.Windows.Forms.Button
    Friend WithEvents lstnotas As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
