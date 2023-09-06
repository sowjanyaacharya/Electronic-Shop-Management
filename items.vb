'This is the window once you click on items it transfers you to this form to make some CRUD operations 
Public Class items
'here button1 to add items
Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click 
 Additems.Show() 
End Sub
'button2 to delete items
Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

 Deleteitems.Show()
End Sub
'button3 to delete items
Private Sub Button3_Click(ByVal sender As System Object, ByVal e As System.EventArgs) Handles Button3.Click

 Updateitem.Show()

End Sub
'button4 to viewitems
Private Sub Button4_Click(ByVal sender As System.Object, ByVal System.EventArgs) Handles Button4.Click

 Viewitems.Show()

End Sub
'button5 to close the form
Private Sub ButtonS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

 Me.Hide()

 Form1.Show()

End Sub

End Class



