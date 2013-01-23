<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuPrincipal))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AbrirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MetodoEsquinaNorOesteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MetodoCostoMínimoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MetodoDeVoguelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MetododeRussellToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AcercaDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AbrirToolStripMenuItem, Me.AyudaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AbrirToolStripMenuItem
        '
        Me.AbrirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MetodoEsquinaNorOesteToolStripMenuItem, Me.MetodoCostoMínimoToolStripMenuItem, Me.MetodoDeVoguelToolStripMenuItem, Me.MetododeRussellToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.AbrirToolStripMenuItem.Name = "AbrirToolStripMenuItem"
        Me.AbrirToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.AbrirToolStripMenuItem.Text = "Abrir"
        '
        'MetodoEsquinaNorOesteToolStripMenuItem
        '
        Me.MetodoEsquinaNorOesteToolStripMenuItem.Name = "MetodoEsquinaNorOesteToolStripMenuItem"
        Me.MetodoEsquinaNorOesteToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.MetodoEsquinaNorOesteToolStripMenuItem.Text = "Método Esquina Nor-Oeste"
        '
        'MetodoCostoMínimoToolStripMenuItem
        '
        Me.MetodoCostoMínimoToolStripMenuItem.Name = "MetodoCostoMínimoToolStripMenuItem"
        Me.MetodoCostoMínimoToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.MetodoCostoMínimoToolStripMenuItem.Text = "Método Costo Mínimo"
        '
        'MetodoDeVoguelToolStripMenuItem
        '
        Me.MetodoDeVoguelToolStripMenuItem.Name = "MetodoDeVoguelToolStripMenuItem"
        Me.MetodoDeVoguelToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.MetodoDeVoguelToolStripMenuItem.Text = "Método de Voguel"
        '
        'MetododeRussellToolStripMenuItem
        '
        Me.MetododeRussellToolStripMenuItem.Name = "MetododeRussellToolStripMenuItem"
        Me.MetododeRussellToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.MetododeRussellToolStripMenuItem.Text = "Método de Russell"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AcercaDeToolStripMenuItem})
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'AcercaDeToolStripMenuItem
        '
        Me.AcercaDeToolStripMenuItem.Name = "AcercaDeToolStripMenuItem"
        Me.AcercaDeToolStripMenuItem.Size = New System.Drawing.Size(133, 22)
        Me.AcercaDeToolStripMenuItem.Text = "Acerca de"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(784, 494)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'MenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 518)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu Principal - Investigacion de Operaciones - Métodos de Transporte"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AbrirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetodoEsquinaNorOesteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetodoCostoMínimoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetodoDeVoguelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetododeRussellToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AcercaDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
