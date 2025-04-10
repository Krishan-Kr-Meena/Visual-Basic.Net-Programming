<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        MenuStrip1 = New MenuStrip()
        FileToolStripMenuItem = New ToolStripMenuItem()
        NewTabToolStripMenuItem = New ToolStripMenuItem()
        OpenToolStripMenuItem = New ToolStripMenuItem()
        SaveToolStripMenuItem = New ToolStripMenuItem()
        CloseToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem = New ToolStripMenuItem()
        ExitToolStripMenuItem1 = New ToolStripMenuItem()
        EditToolStripMenuItem = New ToolStripMenuItem()
        UndoToolStripMenuItem = New ToolStripMenuItem()
        RedoToolStripMenuItem = New ToolStripMenuItem()
        CutToolStripMenuItem = New ToolStripMenuItem()
        CopyToolStripMenuItem = New ToolStripMenuItem()
        PasteToolStripMenuItem = New ToolStripMenuItem()
        SelectAllToolStripMenuItem = New ToolStripMenuItem()
        FindToolStripMenuItem = New ToolStripMenuItem()
        ViewToolStripMenuItem = New ToolStripMenuItem()
        ZoomToolStripMenuItem = New ToolStripMenuItem()
        ZoomInToolStripMenuItem = New ToolStripMenuItem()
        ZoomOutToolStripMenuItem = New ToolStripMenuItem()
        RestoreToolStripMenuItem = New ToolStripMenuItem()
        FormatToolStripMenuItem = New ToolStripMenuItem()
        FontToolStripMenuItem = New ToolStripMenuItem()
        FontColorToolStripMenuItem = New ToolStripMenuItem()
        BackgroundColorToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem = New ToolStripMenuItem()
        HelpToolStripMenuItem1 = New ToolStripMenuItem()
        RichTextBox1 = New RichTextBox()
        SaveFileDialog1 = New SaveFileDialog()
        OpenFileDialog1 = New OpenFileDialog()
        PrintDialog1 = New PrintDialog()
        FontDialog1 = New FontDialog()
        ColorDialog1 = New ColorDialog()
        TextBoxFind = New TextBox()
        ButtonOk = New Button()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.BackColor = SystemColors.ScrollBar
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {FileToolStripMenuItem, EditToolStripMenuItem, ViewToolStripMenuItem, FormatToolStripMenuItem, HelpToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1405, 28)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' FileToolStripMenuItem
        ' 
        FileToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {NewTabToolStripMenuItem, OpenToolStripMenuItem, SaveToolStripMenuItem, CloseToolStripMenuItem, ExitToolStripMenuItem, ExitToolStripMenuItem1})
        FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        FileToolStripMenuItem.Size = New Size(46, 24)
        FileToolStripMenuItem.Text = "File"
        ' 
        ' NewTabToolStripMenuItem
        ' 
        NewTabToolStripMenuItem.Name = "NewTabToolStripMenuItem"
        NewTabToolStripMenuItem.Size = New Size(149, 26)
        NewTabToolStripMenuItem.Text = "New Tab"
        ' 
        ' OpenToolStripMenuItem
        ' 
        OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        OpenToolStripMenuItem.Size = New Size(149, 26)
        OpenToolStripMenuItem.Text = "Open"
        ' 
        ' SaveToolStripMenuItem
        ' 
        SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        SaveToolStripMenuItem.Size = New Size(149, 26)
        SaveToolStripMenuItem.Text = "Save"
        ' 
        ' CloseToolStripMenuItem
        ' 
        CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        CloseToolStripMenuItem.Size = New Size(149, 26)
        CloseToolStripMenuItem.Text = "Close"
        ' 
        ' ExitToolStripMenuItem
        ' 
        ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        ExitToolStripMenuItem.Size = New Size(149, 26)
        ExitToolStripMenuItem.Text = "Print"
        ' 
        ' ExitToolStripMenuItem1
        ' 
        ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        ExitToolStripMenuItem1.Size = New Size(149, 26)
        ExitToolStripMenuItem1.Text = "Exit"
        ' 
        ' EditToolStripMenuItem
        ' 
        EditToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {UndoToolStripMenuItem, RedoToolStripMenuItem, CutToolStripMenuItem, CopyToolStripMenuItem, PasteToolStripMenuItem, SelectAllToolStripMenuItem, FindToolStripMenuItem})
        EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        EditToolStripMenuItem.Size = New Size(49, 24)
        EditToolStripMenuItem.Text = "Edit"
        ' 
        ' UndoToolStripMenuItem
        ' 
        UndoToolStripMenuItem.Name = "UndoToolStripMenuItem"
        UndoToolStripMenuItem.Size = New Size(154, 26)
        UndoToolStripMenuItem.Text = "Undo"
        ' 
        ' RedoToolStripMenuItem
        ' 
        RedoToolStripMenuItem.Name = "RedoToolStripMenuItem"
        RedoToolStripMenuItem.Size = New Size(154, 26)
        RedoToolStripMenuItem.Text = "Redo"
        ' 
        ' CutToolStripMenuItem
        ' 
        CutToolStripMenuItem.Name = "CutToolStripMenuItem"
        CutToolStripMenuItem.Size = New Size(154, 26)
        CutToolStripMenuItem.Text = "Cut"
        ' 
        ' CopyToolStripMenuItem
        ' 
        CopyToolStripMenuItem.Name = "CopyToolStripMenuItem"
        CopyToolStripMenuItem.Size = New Size(154, 26)
        CopyToolStripMenuItem.Text = "Copy"
        ' 
        ' PasteToolStripMenuItem
        ' 
        PasteToolStripMenuItem.Name = "PasteToolStripMenuItem"
        PasteToolStripMenuItem.Size = New Size(154, 26)
        PasteToolStripMenuItem.Text = "Paste"
        ' 
        ' SelectAllToolStripMenuItem
        ' 
        SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem"
        SelectAllToolStripMenuItem.Size = New Size(154, 26)
        SelectAllToolStripMenuItem.Text = "Select All"
        ' 
        ' FindToolStripMenuItem
        ' 
        FindToolStripMenuItem.Name = "FindToolStripMenuItem"
        FindToolStripMenuItem.Size = New Size(154, 26)
        FindToolStripMenuItem.Text = "Find"
        ' 
        ' ViewToolStripMenuItem
        ' 
        ViewToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ZoomToolStripMenuItem})
        ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        ViewToolStripMenuItem.Size = New Size(55, 24)
        ViewToolStripMenuItem.Text = "View"
        ' 
        ' ZoomToolStripMenuItem
        ' 
        ZoomToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {ZoomInToolStripMenuItem, ZoomOutToolStripMenuItem, RestoreToolStripMenuItem})
        ZoomToolStripMenuItem.Name = "ZoomToolStripMenuItem"
        ZoomToolStripMenuItem.Size = New Size(132, 26)
        ZoomToolStripMenuItem.Text = "Zoom"
        ' 
        ' ZoomInToolStripMenuItem
        ' 
        ZoomInToolStripMenuItem.Name = "ZoomInToolStripMenuItem"
        ZoomInToolStripMenuItem.Size = New Size(243, 26)
        ZoomInToolStripMenuItem.Text = "Zoom In"
        ' 
        ' ZoomOutToolStripMenuItem
        ' 
        ZoomOutToolStripMenuItem.Name = "ZoomOutToolStripMenuItem"
        ZoomOutToolStripMenuItem.Size = New Size(243, 26)
        ZoomOutToolStripMenuItem.Text = "Zoom Out"
        ' 
        ' RestoreToolStripMenuItem
        ' 
        RestoreToolStripMenuItem.Name = "RestoreToolStripMenuItem"
        RestoreToolStripMenuItem.Size = New Size(243, 26)
        RestoreToolStripMenuItem.Text = " Restore Default Zoom"
        ' 
        ' FormatToolStripMenuItem
        ' 
        FormatToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {FontToolStripMenuItem, FontColorToolStripMenuItem, BackgroundColorToolStripMenuItem})
        FormatToolStripMenuItem.Name = "FormatToolStripMenuItem"
        FormatToolStripMenuItem.Size = New Size(70, 24)
        FormatToolStripMenuItem.Text = "Format"
        ' 
        ' FontToolStripMenuItem
        ' 
        FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        FontToolStripMenuItem.Size = New Size(211, 26)
        FontToolStripMenuItem.Text = "Font Size/Style"
        ' 
        ' FontColorToolStripMenuItem
        ' 
        FontColorToolStripMenuItem.Name = "FontColorToolStripMenuItem"
        FontColorToolStripMenuItem.Size = New Size(211, 26)
        FontColorToolStripMenuItem.Text = "Font Color"
        ' 
        ' BackgroundColorToolStripMenuItem
        ' 
        BackgroundColorToolStripMenuItem.Name = "BackgroundColorToolStripMenuItem"
        BackgroundColorToolStripMenuItem.Size = New Size(211, 26)
        BackgroundColorToolStripMenuItem.Text = "Background Color"
        ' 
        ' HelpToolStripMenuItem
        ' 
        HelpToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {HelpToolStripMenuItem1})
        HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        HelpToolStripMenuItem.Size = New Size(55, 24)
        HelpToolStripMenuItem.Text = "Help"
        ' 
        ' HelpToolStripMenuItem1
        ' 
        HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        HelpToolStripMenuItem1.Size = New Size(133, 26)
        HelpToolStripMenuItem1.Text = "About"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        RichTextBox1.Location = New Point(0, 31)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(1405, 591)
        RichTextBox1.TabIndex = 1
        RichTextBox1.Text = ""
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' PrintDialog1
        ' 
        PrintDialog1.UseEXDialog = True
        ' 
        ' TextBoxFind
        ' 
        TextBoxFind.Location = New Point(1095, 49)
        TextBoxFind.Multiline = True
        TextBoxFind.Name = "TextBoxFind"
        TextBoxFind.Size = New Size(298, 41)
        TextBoxFind.TabIndex = 2
        ' 
        ' ButtonOk
        ' 
        ButtonOk.Location = New Point(1095, 96)
        ButtonOk.Name = "ButtonOk"
        ButtonOk.Size = New Size(298, 29)
        ButtonOk.TabIndex = 3
        ButtonOk.Text = "Ok"
        ButtonOk.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1405, 623)
        Controls.Add(ButtonOk)
        Controls.Add(TextBoxFind)
        Controls.Add(RichTextBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form1"
        Text = "Notpad"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewTabToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents UndoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RedoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CopyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SelectAllToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormatToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BackgroundColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ZoomToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ZoomOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestoreToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FindToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextBoxFind As TextBox
    Friend WithEvents ButtonOk As Button

End Class
