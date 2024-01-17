Imports System.Management.Instrumentation

Class MainWindow
    Dim index As Integer
    Dim slideImages As New SlideImages
    Sub New()
        InitializeComponent()
        slideImages.AddImage("moon.jfif")
        slideImages.AddImage("mars.jfif")
        slideImages.AddImage("space.jpg")

        imgSlide.Source = New BitmapImage(New Uri(slideImages.imgList(0), UriKind.Relative))
    End Sub
    Private Sub btnPrevImage_Click(sender As Object, e As RoutedEventArgs) Handles btnPrevImage.Click
        If index > 0 Then
            index -= 1
            'Console.WriteLine(index.ToString)
            imgSlide.Source = New BitmapImage(New Uri(slideImages.imgList(index), UriKind.Relative))
        End If
    End Sub

    Private Sub btnNextImage_Click(sender As Object, e As RoutedEventArgs) Handles btnNextImage.Click
        If index < slideImages.imgList.Count - 1 Then
            index += 1
            'Console.WriteLine(index.ToString)
            imgSlide.Source = New BitmapImage(New Uri(slideImages.imgList(index), UriKind.Relative))
        End If
    End Sub
End Class

Class SlideImages
    Private url As String
    Public imgList As New List(Of String)

    Public Sub AddImage(imgName As String)
        url = "images/" + imgName
        imgList.Add(url)
    End Sub
End Class