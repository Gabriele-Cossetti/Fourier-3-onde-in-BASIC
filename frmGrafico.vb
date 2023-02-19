Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Public Class frmGrafico
    ' inizializzazione variabili ed estremi del piano cartesiano
    Public Ampiezza1 As Single = 1.0
    Public Ampiezza2 As Single = 1.0
    Public Ampiezza3 As Single = 1.0
    Public Frequenza1 As Single = 1.0
    Public Frequenza2 As Single = 2.0
    Public Frequenza3 As Single = 3.0
    Public Fase1 As Single = 0.0
    Public Fase2 As Single = 0.0
    Public Fase3 As Single = 0.0
    '--------------------------------------------------------------
    Public minX As Single = -2
    Public maxX As Single = 2
    Public minY As Single = -8
    Public maxY As Single = 8
    ' Larghezza (= altezza) dell'area del grafico
    Dim l, h As Short
    ' Unità di misura in pixel
    Dim u As Single
    ' Coordinate di un punto
    Dim X0, Y0 As Integer
    Dim X1, Y1, X2, Y2 As Double
    ' Oggetto grafico
    Dim Piano As Graphics
    ' Grafici selezionati
    Dim GrafSel(3) As Boolean
    Private Sub frmGrafico_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Piano = picPianoCart.CreateGraphics()
        ' Dimensioni del PictureBox
        l = picPianoCart.Size.Width
        h = picPianoCart.Size.Height
        ' Unità di misura
        u = l / (maxX - minX)
        h = h / (maxY - minY)
        ' Origine
        X0 = picPianoCart.Size.Width / 2  'u
        Y0 = picPianoCart.Size.Height / 2 'maxY * u
    End Sub
    Private Sub btnDisegna_Click(sender As Object, e As EventArgs) Handles btnDisegna.Click
        Piano.Clear(picPianoCart.BackColor)
        ControllaSelezione()
        DisegnaAssi()
        Dim x As Single
        Dim j As Integer
        For x = minX To maxX Step 0.01
            For j = 0 To 3
                If GrafSel(j) Then
                    X1 = X0 + x * u
                    Y1 = Y0 - F(x, j) * h
                    X2 = X0 + (x + 0.01) * u
                    Y2 = Y0 - F(x + 0.01, j) * h
                    Segmento(j, X1, Y1, X2, Y2)
                End If
            Next j
        Next x
    End Sub
    Private Sub btnCancella_Click(sender As Object, e As EventArgs) Handles btnCancella.Click
        Piano.Clear(picPianoCart.BackColor)
    End Sub
    Private Sub btnFine_Click(sender As Object, e As EventArgs) Handles btnFine.Click
        Piano.Dispose()
        End
    End Sub
    Public Sub ControllaSelezione()
        If chkFunz0.Checked Then
            GrafSel(0) = True
        Else
            GrafSel(0) = False
        End If
        If chkFunz1.Checked Then
            GrafSel(1) = True
        Else
            GrafSel(1) = False
        End If
        If chkFunz2.Checked Then
            GrafSel(2) = True
        Else
            GrafSel(2) = False
        End If
        If chkFunz3.Checked Then
            GrafSel(3) = True
        Else
            GrafSel(3) = False
        End If
    End Sub
    Public Sub DisegnaAssi()
        Dim pen As New Pen(Color.MediumVioletRed, 1)
        'Asse x
        X1 = X0 + minX * u
        Y1 = Y0
        X2 = X0 + maxX * u
        Y2 = Y0
        Piano.DrawLine(pen, CInt(X1), CInt(Y1), CInt(X2), CInt(Y2))
        'Asse y
        X1 = X0
        Y1 = Y0 - minY * h
        X2 = X0
        Y2 = Y0 - maxY * h
        Piano.DrawLine(pen, CInt(X1), CInt(Y1), CInt(X2), CInt(Y2))
        pen.Dispose()
    End Sub

    Public Sub Segmento(ByVal nf As Integer, ByVal a As Double, ByVal b As Double, ByVal c As Double, ByVal d As Double)
        Dim col As Color
        Select Case nf
            Case 0
                col = Color.Blue
            Case 1
                col = Color.Red
            Case 2
                col = Color.Green
            Case 3
                col = Color.Black
        End Select
        Dim pen As New Pen(col, 1)
        Piano.DrawLine(pen, CInt(a), CInt(b), CInt(c), CInt(d))
        pen.Dispose()
    End Sub

    Public Function F(ByVal i As Single, ByVal nf As Integer) As Double
        Select Case nf
            Case 0
                F = Ampiezza1 * Math.Sin(2 * 3.14 * Frequenza1 * i + Fase1)
            Case 1
                F = Ampiezza2 * Math.Sin(2 * 3.14 * Frequenza2 * i + Fase2)
            Case 2
                F = Ampiezza3 * Math.Sin(2 * 3.14 * Frequenza3 * i + Fase3)
            Case 3
                F = Ampiezza1 * Math.Sin(2 * 3.14 * Frequenza1 * i + Fase1) + Ampiezza2 * Math.Sin(2 * 3.14 * Frequenza2 * i + Fase2) + Ampiezza3 * Math.Sin(2 * 3.14 * Frequenza3 * i + Fase3)
        End Select
        Return (F)
    End Function
    Private Sub ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImmissioneAmpiezzaFrequenzaEFaseToolStripMenuItem.Click
        Form2.ShowDialog()
        maxX = 0
        maxY = 0
        Ampiezza1 = CSng(Form2.TextBox1.Text)
        Ampiezza2 = CSng(Form2.TextBox2.Text)
        Ampiezza3 = CSng(Form2.TextBox3.Text)
        Frequenza1 = CSng(Form2.TextBox4.Text)
        Frequenza2 = CSng(Form2.TextBox5.Text)
        Frequenza3 = CSng(Form2.TextBox6.Text)
        Fase1 = CSng(Form2.TextBox7.Text)
        Fase2 = CSng(Form2.TextBox8.Text)
        Fase3 = CSng(Form2.TextBox9.Text)
If maxX < Frequenza1 + Frequenza2 + Frequenza3 Then maxX = 2 'Frequenza1 + Frequenza2 + Frequenza3
        If maxY < Ampiezza1 + Ampiezza2 + Ampiezza3 Then maxY = Ampiezza1 + Ampiezza2 + Ampiezza3
        minX = -maxX
        minY = -maxY
        l = picPianoCart.Size.Width
        h = picPianoCart.Size.Height
        u = l / (maxX - minX)
        h = h / (maxY - minY)
        X0 = picPianoCart.Size.Width / 2
        Y0 = picPianoCart.Size.Height / 2
        Me.Update()
    End Sub
    Private Sub UscitaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UscitaToolStripMenuItem.Click
        End
    End Sub
End Class
