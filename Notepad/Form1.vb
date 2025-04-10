Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar

Public Class Form1
    Private Sub NewTabToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewTabToolStripMenuItem.Click
        RichTextBox1.Visible = True
        If Not RichTextBox1.Text = "" Then
            Dim result As DialogResult
            result = MsgBox("Do you want to save File/Changes?", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                SaveFileDialog1.ShowDialog()
                Me.Close()
            ElseIf result = DialogResult.No Then
                Me.Close()
            ElseIf result = DialogResult.Cancel Then
                ' Do nothing, just return and keep the form open
                Return
            End If
        Else
            Me.Close()
        End If
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        SaveFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        RichTextBox1.Visible = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        End
    End Sub

    Private Sub UndoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UndoToolStripMenuItem.Click
        RichTextBox1.Undo()
    End Sub

    Private Sub RedoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedoToolStripMenuItem.Click
        RichTextBox1.Redo()
    End Sub

    Private Sub CutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CutToolStripMenuItem.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CopyToolStripMenuItem.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasteToolStripMenuItem.Click
        RichTextBox1.Paste()
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        RichTextBox1.SelectionFont = FontDialog1.Font
    End Sub

    Private Sub FontColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.SelectionColor = ColorDialog1.Color
    End Sub

    Private Sub BackgroundColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        RichTextBox1.BackColor = ColorDialog1.Color
    End Sub

    Private Sub HelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles HelpToolStripMenuItem1.Click
        AboutBox1.Show()
    End Sub

    Private Const DefaultZoomFactor As Single = 1.0F
    Private CurrentZoomFactor As Single = DefaultZoomFactor

    Private Sub Form1_Load1(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.ZoomFactor = DefaultZoomFactor
    End Sub

    ' Zoom In Button
    Private Sub ZoomInToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomInToolStripMenuItem.Click
        If CurrentZoomFactor < 5.0F Then ' Maximum zoom level
            CurrentZoomFactor += 0.1F
            RichTextBox1.ZoomFactor = CurrentZoomFactor
        End If
    End Sub

    ' Zoom Out Button
    Private Sub ZoomOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ZoomOutToolStripMenuItem.Click
        If CurrentZoomFactor > 0.2F Then ' Minimum zoom level
            CurrentZoomFactor -= 0.1F
            RichTextBox1.ZoomFactor = CurrentZoomFactor
        End If
    End Sub

    ' Restore Default Zoom Button
    Private Sub RestoreZoomToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestoreToolStripMenuItem.Click
        CurrentZoomFactor = DefaultZoomFactor
        RichTextBox1.ZoomFactor = DefaultZoomFactor
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBoxFind.Visible = False
        ButtonOk.Visible = False
    End Sub

    Private Sub FindToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindToolStripMenuItem.Click
        TextBoxFind.Visible = True
        ButtonOK.Visible = True
        TextBoxFind.Focus()
    End Sub

    Private Sub ButtonOk_Click(sender As Object, e As EventArgs) Handles ButtonOk.Click
        Dim searchText As String = TextBoxFind.Text
        Dim startIndex As Integer = RichTextBox1.Find(searchText)

        If searchText = "" Then
            MessageBox.Show("Please enter a word or sentence to find.", "Find", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf startIndex <> -1 Then
            RichTextBox1.Select(startIndex, searchText.Length)
            RichTextBox1.ScrollToCaret()
            RichTextBox1.Focus()
        Else
            MessageBox.Show("Text not found!", "Find", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        ' Optional: hide the find box after search
        TextBoxFind.Visible = False
        ButtonOk.Visible = False
    End Sub
End Class