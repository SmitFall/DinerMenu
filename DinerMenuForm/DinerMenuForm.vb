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
        DisplaySpecialLabel.Text = "Tuscan Potato Soup  $12.50 " & vbNewLine _
            & "Made from locally grown potatoes. It has some of the best hand picked ingredients. " & vbNewLine _
            & "It has a great source of protein and vegatebles." & vbNewLine _
            & "Rumors say some of the mystery meat in the soup is made out of people who tried to not pay for the meal"
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click

    End Sub

    Private Sub FIshButton_Click(sender As Object, e As EventArgs) Handles FIshButton.Click

    End Sub

    Private Sub DisplaySpecialLabel_Click(sender As Object, e As EventArgs) Handles DisplaySpecialLabel.Click

    End Sub
End Class
