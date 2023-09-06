'Once you login you are redirected to this form where you can move to items ,stockhand, billing windows
Public Class Form1
'here buttton1 for items form
Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

 Items.Show() End Sub
'here buttton3 for stock in hand report form
Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click 
 stockhand.Show()

End Sub
'here button2 for billing form 
Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

 bill.Show()
End Sub
'here button4 for go back to previous form that is login form 
Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

  Me.Hide() 
  login.Show()

End Sub

