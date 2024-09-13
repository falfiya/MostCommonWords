Imports System.Windows.Forms.Design

Public Class frmResults
    Public Sub giveMeTheBlood(theBlood As String)
        Dim words = theBlood.Split()
        Dim wordCounts As New Dictionary(Of String, UInteger)
        For Each word In words
            If word = "" Then
                Continue For
            End If
            If wordCounts.ContainsKey(word) Then
                wordCounts(word) += 1
            Else
                wordCounts(word) = 1
            End If
        Next
        Dim ss As New SortedSet(Of WordAndCount)
        For Each kvp In wordCounts
            ss.Add(New WordAndCount(kvp.Key, kvp.Value))
        Next

        Dim table As New DataTable
        table.Columns.Add("Count")
        table.Columns.Add("Word")
        For Each wc In ss
            table.Rows.Add(wc.Count, wc.Word)
        Next

        tblData.DataSource = table
        tblData.Update()
        tblData.Refresh()
    End Sub
End Class