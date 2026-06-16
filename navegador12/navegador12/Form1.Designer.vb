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
        Panel1 = New Panel()
        Panel2 = New Panel()
        TextBox1 = New TextBox()
        Button3 = New Button()
        Button1 = New Button()
        Button4 = New Button()
        Button2 = New Button()
        Button5 = New Button()
        TabControl1 = New TabControl()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Panel2)
        Panel1.Controls.Add(Button3)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Button4)
        Panel1.Controls.Add(Button2)
        Panel1.Controls.Add(Button5)
        Panel1.Dock = DockStyle.Bottom
        Panel1.Location = New Point(0, 395)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 55)
        Panel1.TabIndex = 4
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ActiveCaptionText
        Panel2.Controls.Add(TextBox1)
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(70, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(564, 55)
        Panel2.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.Cursor = Cursors.IBeam
        TextBox1.Dock = DockStyle.Fill
        TextBox1.Font = New Font("Microsoft Sans Serif", 8.25F)
        TextBox1.ForeColor = SystemColors.Desktop
        TextBox1.Location = New Point(0, 0)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(564, 55)
        TextBox1.TabIndex = 2
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.ActiveCaptionText
        Button3.Cursor = Cursors.Hand
        Button3.Dock = DockStyle.Right
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Snap ITC", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.ForeColor = Color.Red
        Button3.Location = New Point(634, 0)
        Button3.Name = "Button3"
        Button3.Size = New Size(55, 55)
        Button3.TabIndex = 11
        Button3.Text = "x"
        Button3.TextAlign = ContentAlignment.TopRight
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaptionText
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Right
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.ButtonHighlight
        Button1.Location = New Point(689, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(57, 55)
        Button1.TabIndex = 10
        Button1.Text = "🔍"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button4
        ' 
        Button4.BackColor = SystemColors.ActiveCaptionText
        Button4.Dock = DockStyle.Left
        Button4.FlatAppearance.BorderColor = Color.Silver
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Snap ITC", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.Location = New Point(36, 0)
        Button4.Name = "Button4"
        Button4.Size = New Size(34, 55)
        Button4.TabIndex = 9
        Button4.Text = ">"
        Button4.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaptionText
        Button2.Cursor = Cursors.Hand
        Button2.Dock = DockStyle.Left
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Snap ITC", 16.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.ButtonHighlight
        Button2.Location = New Point(0, 0)
        Button2.Name = "Button2"
        Button2.Size = New Size(36, 55)
        Button2.TabIndex = 8
        Button2.Text = "<"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button5
        ' 
        Button5.BackColor = SystemColors.ActiveCaptionText
        Button5.Dock = DockStyle.Right
        Button5.FlatAppearance.BorderSize = 0
        Button5.FlatStyle = FlatStyle.Flat
        Button5.Font = New Font("Snap ITC", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button5.ForeColor = SystemColors.ButtonHighlight
        Button5.Location = New Point(746, 0)
        Button5.Name = "Button5"
        Button5.Size = New Size(54, 55)
        Button5.TabIndex = 7
        Button5.Text = "🏠"
        Button5.UseVisualStyleBackColor = False
        ' 
        ' TabControl1
        ' 
        TabControl1.Dock = DockStyle.Fill
        TabControl1.Location = New Point(0, 0)
        TabControl1.Name = "TabControl1"
        TabControl1.SelectedIndex = 0
        TabControl1.Size = New Size(800, 450)
        TabControl1.TabIndex = 5
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(TabControl1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabControl1 As TabControl

End Class
