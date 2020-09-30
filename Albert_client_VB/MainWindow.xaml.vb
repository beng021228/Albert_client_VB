Class MainWindow

    'Important!!!


    Private Sub buttonRtsp_Click(sender As Object, e As RoutedEventArgs)


    End Sub           'Set the vlc plugins directory path

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)



    End Sub

    Private Sub MainWindowOnClosing(sender As Object, e As RoutedEventArgs)



    End Sub

    Private Sub MediaOnParsedChanged(sender As Vlc.DotNet.Core.VlcMedia, e As Vlc.DotNet.Core.VlcMediaFreedEventArgs)


    End Sub

    Private Sub Dirfwd_Click(sender As Object, e As RoutedEventArgs) Handles dirfwd.Click
        textblock_1.Text += vbCrLf & "fwd button clicked"
    End Sub





    Private Sub Dirfwd_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirfwd.PreviewMouseLeftButtonDown
        textblock_1.Text += vbCrLf & "driving forward"
    End Sub

    Private Sub Dirfwd_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirfwd.PreviewMouseLeftButtonUp
        textblock_1.Text += vbCrLf & "stopping"
    End Sub

    Private Sub Dirleft_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirleft.PreviewMouseLeftButtonDown
        textblock_1.Text += vbCrLf & "turning left"
    End Sub

    Private Sub Dirleft_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirleft.PreviewMouseLeftButtonUp
        textblock_1.Text += vbCrLf & "stopping"
    End Sub
End Class
