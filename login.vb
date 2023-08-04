Public Class login

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

 If (TextBox1.Text = "eshop" And TextBox2.Text "eshop@123") Then 
   MsgBox("Login Successfull")

   Form1.Show()

Elself TextBox1.Text = "" Then 
   MsgBox("Enter Your UserName") 
Elself TextBox2.Text Then 
   MsgBox("Enter Your Password")

Else

   MsgBox("Incorrect Username Or Password") 
   TextBox1.Clear()

   TextBox2.Clear()

    TextBox1.Focus()

End If

End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
 MsgBox("Logged Out Successfully")
 Me.Close()

End Sub

Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  TextBox1.Focus()

End Sub

End Class