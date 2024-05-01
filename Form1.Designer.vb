<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        lstitems = New ListBox()
        ListViewData = New ListView()
        ColumnHeader1 = New ColumnHeader()
        ColumnHeader2 = New ColumnHeader()
        ColumnHeader3 = New ColumnHeader()
        Label1 = New Label()
        txtDescription = New TextBox()
        btnSave = New Button()
        btnRemove = New Button()
        lblCount = New Label()
        lblTotal = New Label()
        btnExport = New Button()
        SuspendLayout()
        ' 
        ' lstitems
        ' 
        lstitems.FormattingEnabled = True
        lstitems.Location = New Point(12, 143)
        lstitems.Name = "lstitems"
        lstitems.Size = New Size(213, 184)
        lstitems.TabIndex = 0
        ' 
        ' ListViewData
        ' 
        ListViewData.Columns.AddRange(New ColumnHeader() {ColumnHeader1, ColumnHeader2, ColumnHeader3})
        ListViewData.Location = New Point(298, 112)
        ListViewData.Name = "ListViewData"
        ListViewData.Size = New Size(478, 313)
        ListViewData.TabIndex = 1
        ListViewData.UseCompatibleStateImageBehavior = False
        ListViewData.View = View.Details
        ' 
        ' ColumnHeader1
        ' 
        ColumnHeader1.Text = "ID"
        ColumnHeader1.Width = 90
        ' 
        ' ColumnHeader2
        ' 
        ColumnHeader2.Text = "Description"
        ColumnHeader2.Width = 90
        ' 
        ' ColumnHeader3
        ' 
        ColumnHeader3.Text = "Price"
        ColumnHeader3.Width = 90
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 39)
        Label1.Name = "Label1"
        Label1.Size = New Size(121, 28)
        Label1.TabIndex = 2
        Label1.Text = "Description"
        ' 
        ' txtDescription
        ' 
        txtDescription.Location = New Point(149, 43)
        txtDescription.Name = "txtDescription"
        txtDescription.Size = New Size(156, 27)
        txtDescription.TabIndex = 3
        ' 
        ' btnSave
        ' 
        btnSave.Font = New Font("Segoe UI", 12F)
        btnSave.Location = New Point(394, 39)
        btnSave.Name = "btnSave"
        btnSave.Size = New Size(125, 53)
        btnSave.TabIndex = 4
        btnSave.Text = "Save"
        btnSave.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Font = New Font("Segoe UI", 12F)
        btnRemove.Location = New Point(627, 43)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(106, 49)
        btnRemove.TabIndex = 5
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' lblCount
        ' 
        lblCount.AutoSize = True
        lblCount.Font = New Font("Segoe UI", 16.2F)
        lblCount.Location = New Point(298, 447)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(35, 38)
        lblCount.TabIndex = 6
        lblCount.Text = "..."
        ' 
        ' lblTotal
        ' 
        lblTotal.AutoSize = True
        lblTotal.Font = New Font("Segoe UI", 16.2F)
        lblTotal.Location = New Point(697, 447)
        lblTotal.Name = "lblTotal"
        lblTotal.Size = New Size(35, 38)
        lblTotal.TabIndex = 7
        lblTotal.Text = "..."
        ' 
        ' btnExport
        ' 
        btnExport.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnExport.Location = New Point(12, 405)
        btnExport.Name = "btnExport"
        btnExport.Size = New Size(154, 70)
        btnExport.TabIndex = 8
        btnExport.Text = "Export"
        btnExport.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.RoyalBlue
        ClientSize = New Size(800, 500)
        Controls.Add(btnExport)
        Controls.Add(lblTotal)
        Controls.Add(lblCount)
        Controls.Add(btnRemove)
        Controls.Add(btnSave)
        Controls.Add(txtDescription)
        Controls.Add(Label1)
        Controls.Add(ListViewData)
        Controls.Add(lstitems)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lstitems As ListBox
    Friend WithEvents ListViewData As ListView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents lblCount As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnExport As Button

End Class
