Public Class WordAndCount
    Implements IComparable

    Public Word As String
    Public Count As UInteger

    Public Sub New(word As String, count As UInteger)
        Me.Word = word
        Me.Count = count
    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim other As WordAndCount = TryCast(obj, WordAndCount)
        If other Is Nothing Then
            Throw New ArgumentException("Cannot compare WordAndCount to other object!")
        End If
        REM we want higher numbers to come first!
        Dim countCmp = -Count.CompareTo(other.Count)
        If countCmp <> 0 Then
            Return countCmp
        End If
        Return Word.CompareTo(other.Word)
    End Function
End Class
