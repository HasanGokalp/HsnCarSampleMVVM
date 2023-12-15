Public Class GetAllCars
    Public Sub New()

        ' Bu çağrı tasarımcı için gerekli.
        InitializeComponent()
        Dim win As MainWindowViewModel = New MainWindowViewModel
        Me.DataContext = win
        ' InitializeComponent() çağrısından sonra başlangıç değer ekleyin.

    End Sub
End Class
