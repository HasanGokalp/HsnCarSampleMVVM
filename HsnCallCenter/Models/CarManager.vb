Imports System.Collections.ObjectModel

Public Class CarManager
    Public ReadOnly Property Cars As ObservableCollection(Of Car) = New ObservableCollection(Of Car) From {
            New Car With {.Address = "Kayseri", .Id = 1, .Name = "Hasan"},
            New Car With {.Address = "Çorum", .Id = 2, .Name = "Sefa"}
    }
    Public Function GetCars() As ObservableCollection(Of Car)
        Return Cars
    End Function

    Public Sub AddCars(car As Car)
        Cars.Add(car)
    End Sub

End Class
