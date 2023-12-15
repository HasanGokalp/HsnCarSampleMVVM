Imports System.Collections.ObjectModel

Public Class MainWindowViewModel

    Public Property Cars As ObservableCollection(Of Car)
    Public Property ShowWindowCommand As ICommand

    Public Sub New()
        Cars = New CarManager().GetCars

        ShowWindowCommand = New RelayCommand(AddressOf ShowWindow, AddressOf CanShowWindow)
    End Sub

    Private Sub ShowWindow(obj As Object)
        Dim win As Window = obj
        Dim cars As GetAllCars = New GetAllCars
        cars.WindowStartupLocation = WindowStartupLocation.CenterScreen
        cars.Owner = win
        cars.Show()
    End Sub

    Private Function CanShowWindow(obj As Object) As Boolean
        Return True
    End Function

End Class
