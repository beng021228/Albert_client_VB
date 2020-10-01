
Imports Microsoft.Xna.Framework
Imports Microsoft.Xna.Framework.Input

Class MainWindow
    Friend mypad As GamePadState = GamePad.GetState(PlayerIndex.One)
    'Important!!!



    Private Sub buttonRtsp_Click(sender As Object, e As RoutedEventArgs)


    End Sub           'Set the vlc plugins directory path

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)

        'AddHandler CompositionTarget.Rendering, AddressOf CompositionTarget_Rendering



        Dim mygamepadstate As GamePadState = GamePad.GetState(PlayerIndex.One)
        debug_textbox.Text = mygamepadstate.ThumbSticks.Left.ToString

    End Sub

    Private Sub MainWindowOnClosing(sender As Object, e As RoutedEventArgs)



    End Sub

    Private Sub MediaOnParsedChanged(sender As Vlc.DotNet.Core.VlcMedia, e As Vlc.DotNet.Core.VlcMediaFreedEventArgs)


    End Sub

    Private Sub Dirfwd_Click(sender As Object, e As RoutedEventArgs) Handles dirfwd.Click
        debug_textbox.Text += vbCrLf & "fwd button clicked"
        debug_textbox.ScrollToEnd()

    End Sub


    Private Sub Dirfwd_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirfwd.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "driving forward"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Dirfwd_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirfwd.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Dirleft_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirleft.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "turning left"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Dirleft_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirleft.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
        debug_textbox.ScrollToEnd()
    End Sub



    Private Sub Dirright_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirright.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "turning right"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Dirright_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirright.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Dirbck_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles dirbck.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "going backward"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Dirbck_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles dirbck.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
        debug_textbox.ScrollToEnd()
    End Sub

    Protected Sub CompositionTarget_Rendering(sender As Object, e As EventArgs)



        mypad = GamePad.GetState(PlayerIndex.One)



        debug_textbox.Text = mypad.ThumbSticks.Left.ToString
        debug_textbox.Text += mypad.ThumbSticks.Right.ToString

        ''myballs.Margin = New Thickness(mygamepadstate.ThumbSticks.Right.X, 0, 0, 0)







    End Sub

    Private Sub clearbutton_Click(sender As Object, e As RoutedEventArgs) Handles clearbutton.Click
        debug_textbox.Text = ""
    End Sub

    Private Sub Panleft_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles panleft.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "panning left"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Panleft_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles panleft.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Panup_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles panup.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "panning up"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Panup_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles panup.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Panright_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles panright.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "panning right"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Panright_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles panright.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Pandown_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles pandown.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "panning down"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Pandown_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles pandown.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "stopping"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Center_button_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles center_button.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "centering"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Laserbtn_PreviewMouseLeftButtonDown(sender As Object, e As MouseButtonEventArgs) Handles laserbtn.PreviewMouseLeftButtonDown
        debug_textbox.Text += vbCrLf & "turning on laser"
        debug_textbox.ScrollToEnd()
    End Sub

    Private Sub Laserbtn_PreviewMouseLeftButtonUp(sender As Object, e As MouseButtonEventArgs) Handles laserbtn.PreviewMouseLeftButtonUp
        debug_textbox.Text += vbCrLf & "turning off laser"
        debug_textbox.ScrollToEnd()
    End Sub
End Class
