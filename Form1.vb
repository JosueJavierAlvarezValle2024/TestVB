Imports System.Drawing.Text
Imports System.Security.Cryptography
Imports System.IO
Imports ClosedXML.Excel

Public Class Form1

    Dim id As Integer

    Public Sub New()
        InitializeComponent()
        id = 0
        ListViewData.FullRowSelect = True
    End Sub


    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim x As MyItem

        Dim description As String = txtDescription.Text
        id = id + 1
        Dim Price As Random = New Random()

        x = New MyItem(id, description, Math.Round(Price.NextDouble() * 1000, 2))
        lstitems.Items.Add(x.ToString())


        For i = 1 To 100
            Dim row As ListViewItem = New ListViewItem(x.Id.ToString())
            row.SubItems.Add(x.Description)
            row.SubItems.Add(x.Price.ToString("F2"))
            ListViewData.Items.Add(row)
            x.Id = x.Id + 1
            x.Price = Math.Round(Price.NextDouble() * 1000, 2)
        Next

        UpdateLabel()
        UpdateTotal()
    End Sub


    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If ListViewData.SelectedItems.Count = 0 Then
            Return
        End If

        For Each item As ListViewItem In ListViewData.SelectedItems
            ListViewData.Items.Remove(item)
        Next
        UpdateLabel()
        UpdateTotal()
    End Sub


    Sub UpdateLabel()
        lblCount.Text = ListViewData.Items.Count.ToString()
    End Sub


    Sub UpdateTotal()
        Dim Total As Decimal = 0
        For Each item As ListViewItem In ListViewData.Items
            Total += Decimal.Parse(item.SubItems(2).Text)
        Next
        lblTotal.Text = Total.ToString("F2")
    End Sub


    Private Sub ExportListViewToExcel(filePath As String)
        Using workbook As New XLWorkbook()
            Dim worksheet = workbook.Worksheets.Add("Data")


            worksheet.Cell(1, 1).Value = "ID"
            worksheet.Cell(1, 2).Value = "Descripction"
            worksheet.Cell(1, 3).Value = "Price"


            For rowIndex As Integer = 0 To ListViewData.Items.Count - 1
                Dim item = ListViewData.Items(rowIndex)
                worksheet.Cell(rowIndex + 2, 1).Value = item.SubItems(0).Text
                worksheet.Cell(rowIndex + 2, 2).Value = item.SubItems(1).Text
                worksheet.Cell(rowIndex + 2, 3).Value = item.SubItems(2).Text
            Next


            workbook.SaveAs(filePath)
        End Using
    End Sub


    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        Dim saveFileDialog = New SaveFileDialog() With {
          .Filter = "Excel Files (*.xlsx)|*.xlsx",
          .Title = "Save as"
        }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            ExportListViewToExcel(saveFileDialog.FileName)
        End If
    End Sub
End Class
