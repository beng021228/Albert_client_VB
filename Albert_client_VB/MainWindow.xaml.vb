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
        debug_textbox.Text += vbCrLf & "fwd button clicked"
    End Sub


    Private Sub Dirfwd_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirfwd.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "driving forward"
    End Sub

    Private Sub Dirfwd_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirfwd.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
    End Sub

    Private Sub Dirleft_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirleft.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "turning left"
    End Sub

    Private Sub Dirleft_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirleft.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
    End Sub



    Private Sub Dirright_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirright.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "turning right"
    End Sub

    Private Sub Dirright_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirright.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
    End Sub

    Private Sub Dirbck_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirbck.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "going backward"
    End Sub

    Private Sub Dirbck_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirbck.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
    End Sub
End Class
