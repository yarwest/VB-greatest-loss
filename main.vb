Module VBModule
 
    Sub Main()
        Dim points = New Integer() {100, 200, 300, 150, -100, -500, -200, -300, -200, -50, 200, -50, -200, -50, 200, 300, 400, 300}
        Dim highest As Integer = points(0)
        Dim maxLoss As Integer = 0
        For Each point As Integer In points
            If point > highest Then
                highest = point
            End If
            If highest - point > maxLoss Then
                maxLoss = highest - point
            End If
        Next
        Console.WriteLine("The maximum loss is " & maxLoss)
    End Sub
  
End Module
