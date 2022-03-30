'Fallon Smith
'RCEt0265
'Spring 2022
'Diner Menu Program
'

Public Class DinerMenuForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        DisplaySpecialLabel.Text = "~Soup of the day~" & vbNewLine _
            & "Tuscan Potato Soup  $12.50 "
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        DisplaySpecialLabel.Text = "~Chef's Special~" & vbNewLine _
          & "Mexican Watermelon Salad  $10 " & vbNewLine _
          & " It has some of the best hand picked ingredients. " & vbNewLine _
          & "It has a great source of vegatebles." & vbNewLine _
          & "A great sweet and spicy taste. Authentic Mexican Salad."
    End Sub

    Private Sub FIshButton_Click(sender As Object, e As EventArgs) Handles FIshButton.Click
        DisplaySpecialLabel.Text = "Norwegian Lutfisk $15 " & vbNewLine _
          & " Made from dried white cod fresh from the icy cold seas " & vbNewLine _
          & "It has a strong smell but a great taste "
    End Sub
End Class
