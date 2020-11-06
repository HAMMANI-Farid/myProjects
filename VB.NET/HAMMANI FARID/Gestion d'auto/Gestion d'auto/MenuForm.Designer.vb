<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MarquesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VéhiculesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatistiquesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(784, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarquesToolStripMenuItem, Me.VéhiculesToolStripMenuItem, Me.StatistiquesToolStripMenuItem, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(54, 20)
        Me.FichierToolStripMenuItem.Text = "Fichier"
        '
        'MarquesToolStripMenuItem
        '
        Me.MarquesToolStripMenuItem.Name = "MarquesToolStripMenuItem"
        Me.MarquesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.MarquesToolStripMenuItem.Text = "Marques"
        '
        'VéhiculesToolStripMenuItem
        '
        Me.VéhiculesToolStripMenuItem.Name = "VéhiculesToolStripMenuItem"
        Me.VéhiculesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.VéhiculesToolStripMenuItem.Text = "Véhicules"
        '
        'StatistiquesToolStripMenuItem
        '
        Me.StatistiquesToolStripMenuItem.Name = "StatistiquesToolStripMenuItem"
        Me.StatistiquesToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.StatistiquesToolStripMenuItem.Text = "Statistiques"
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(141, 22)
        Me.QuitterToolStripMenuItem.Text = "Déconnecter"
        '
        'MenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(784, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FichierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MarquesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VéhiculesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatistiquesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As ToolStripMenuItem
End Class
