'This form is for login page 
Public Class login
'The form is having a login button which is button1
Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
'checking whether textbox1 is equal to those login credintials if yes success shows the next form else error msg..
 'It also checks for form validation
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
'once you login it makes the boxes clear
    TextBox1.Focus()

End If

End Sub
'Here button2 is used to logout it closes the form
Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
 MsgBox("Logged Out Successfully")
 Me.Close()

End Sub
'when first the form is loaded the textbox1 is made to be on focus
Private Sub login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  TextBox1.Focus()

End Sub

End Class
