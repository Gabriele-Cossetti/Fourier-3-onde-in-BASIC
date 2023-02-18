<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGrafico
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
        Me.picPianoCart = New System.Windows.Forms.PictureBox()
        Me.btnFine = New System.Windows.Forms.Button()
        Me.btnCancella = New System.Windows.Forms.Button()
        Me.btnDisegna = New System.Windows.Forms.Button()
        Me.chkFunz0 = New System.Windows.Forms.CheckBox()
        Me.chkFunz1 = New System.Windows.Forms.CheckBox()
        Me.chkFunz2 = New System.Windows.Forms.CheckBox()
        Me.chkFunz3 = New System.Windows.Forms.CheckBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MenùToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UscitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picPianoCart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'picPianoCart
        '
        Me.picPianoCart.BackColor = System.Drawing.SystemColors.Info
        Me.picPianoCart.Location = New System.Drawing.Point(285, 33)
        Me.picPianoCart.Name = "picPianoCart"
        Me.picPianoCart.Size = New System.Drawing.Size(894, 722)
        Me.picPianoCart.TabIndex = 0
        Me.picPianoCart.TabStop = False
        '
        'btnFine
        '
        Me.btnFine.Location = New System.Drawing.Point(83, 678)
        Me.btnFine.Name = "btnFine"
        Me.btnFine.Size = New System.Drawing.Size(112, 34)
        Me.btnFine.TabIndex = 1
        Me.btnFine.Text = "Fine"
        Me.btnFine.UseVisualStyleBackColor = True
        '
        'btnCancella
        '
        Me.btnCancella.Location = New System.Drawing.Point(83, 615)
        Me.btnCancella.Name = "btnCancella"
        Me.btnCancella.Size = New System.Drawing.Size(112, 34)
        Me.btnCancella.TabIndex = 2
        Me.btnCancella.Text = "Cancella"
        Me.btnCancella.UseVisualStyleBackColor = True
        '
        'btnDisegna
        '
        Me.btnDisegna.Location = New System.Drawing.Point(83, 546)
        Me.btnDisegna.Name = "btnDisegna"
        Me.btnDisegna.Size = New System.Drawing.Size(112, 34)
        Me.btnDisegna.TabIndex = 3
        Me.btnDisegna.Text = "Disegna"
        Me.btnDisegna.UseVisualStyleBackColor = True
        '
        'chkFunz0
        '
        Me.chkFunz0.AutoSize = True
        Me.chkFunz0.ForeColor = System.Drawing.Color.Blue
        Me.chkFunz0.Location = New System.Drawing.Point(64, 171)
        Me.chkFunz0.Name = "chkFunz0"
        Me.chkFunz0.Size = New System.Drawing.Size(171, 29)
        Me.chkFunz0.TabIndex = 4
        Me.chkFunz0.Text = "x1(t)=A1sin(2πft)"
        Me.chkFunz0.UseVisualStyleBackColor = True
        '
        'chkFunz1
        '
        Me.chkFunz1.AutoSize = True
        Me.chkFunz1.ForeColor = System.Drawing.Color.Red
        Me.chkFunz1.Location = New System.Drawing.Point(64, 244)
        Me.chkFunz1.Name = "chkFunz1"
        Me.chkFunz1.Size = New System.Drawing.Size(171, 29)
        Me.chkFunz1.TabIndex = 5
        Me.chkFunz1.Text = "x2(t)=A1sin(2πft)"
        Me.chkFunz1.UseVisualStyleBackColor = True
        '
        'chkFunz2
        '
        Me.chkFunz2.AutoSize = True
        Me.chkFunz2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkFunz2.Location = New System.Drawing.Point(64, 315)
        Me.chkFunz2.Name = "chkFunz2"
        Me.chkFunz2.Size = New System.Drawing.Size(171, 29)
        Me.chkFunz2.TabIndex = 6
        Me.chkFunz2.Text = "x3(t)=A1sin(2πft)"
        Me.chkFunz2.UseVisualStyleBackColor = True
        '
        'chkFunz3
        '
        Me.chkFunz3.AutoSize = True
        Me.chkFunz3.ForeColor = System.Drawing.Color.Black
        Me.chkFunz3.Location = New System.Drawing.Point(64, 389)
        Me.chkFunz3.Name = "chkFunz3"
        Me.chkFunz3.Size = New System.Drawing.Size(184, 29)
        Me.chkFunz3.TabIndex = 7
        Me.chkFunz3.Text = "x1(t) + x2(t) + x3(t)"
        Me.chkFunz3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenùToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1191, 33)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MenùToolStripMenuItem
        '
        Me.MenùToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem, Me.UscitaToolStripMenuItem})
        Me.MenùToolStripMenuItem.Name = "MenùToolStripMenuItem"
        Me.MenùToolStripMenuItem.Size = New System.Drawing.Size(73, 29)
        Me.MenùToolStripMenuItem.Text = "Menù"
        '
        'ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem
        '
        Me.ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem.Name = "ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem"
        Me.ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem.Size = New System.Drawing.Size(430, 34)
        Me.ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem.Text = "Immissione Ampiezza, Frequenza e Fase"
        '
        'UscitaToolStripMenuItem
        '
        Me.UscitaToolStripMenuItem.Name = "UscitaToolStripMenuItem"
        Me.UscitaToolStripMenuItem.Size = New System.Drawing.Size(430, 34)
        Me.UscitaToolStripMenuItem.Text = "Uscita"
        '
        'frmGrafico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1191, 767)
        Me.Controls.Add(Me.chkFunz3)
        Me.Controls.Add(Me.chkFunz2)
        Me.Controls.Add(Me.chkFunz1)
        Me.Controls.Add(Me.chkFunz0)
        Me.Controls.Add(Me.btnDisegna)
        Me.Controls.Add(Me.btnCancella)
        Me.Controls.Add(Me.btnFine)
        Me.Controls.Add(Me.picPianoCart)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmGrafico"
        Me.Text = "Grafici"
        CType(Me.picPianoCart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picPianoCart As PictureBox
    Friend WithEvents btnFine As Button
    Friend WithEvents btnCancella As Button
    Friend WithEvents btnDisegna As Button
    Friend WithEvents chkFunz0 As CheckBox
    Friend WithEvents chkFunz1 As CheckBox
    Friend WithEvents chkFunz2 As CheckBox
    Friend WithEvents chkFunz3 As CheckBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents MenùToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UscitaToolStripMenuItem As ToolStripMenuItem
End Class
