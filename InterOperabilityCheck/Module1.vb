
Imports PGDAC_SharedDll
Module Module1

    Sub Main()
        Dim ob As New SharedLib()
        ob.Display()
        ob.Show()
        Dim calc As New Calculator()
        Console.WriteLine(calc.Add(40, 20, 30))
    End Sub

End Module
