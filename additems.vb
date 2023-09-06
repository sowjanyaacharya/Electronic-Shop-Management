'this form is for adding items to the database which is MS.Access 2007
Public Class Additems
'this is to declare the connection variables using string
Dim cnn As OleDb.OleDbConnection 
Dim cmd As OleDb.OleDbCommand 
Dim dr As OleDb.OleDbDataReader 
Dim da As OleDb.OleDbDataAdapter
Dim ds As DataSet
'this will be automatically opens code window when you click on the form
Private Sub Additems_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'Establishing the database connection
 cnn = New OleDb.OleDbConnection("Provider=Microsoft ACE, OLED6,120,DataSource=D:\project2021\project21.accdb")
'opening the connection
 cnn.Open()
 cmd = New OleDb.OleDbCommand("select MAX(Item_id) from items",cnn)

 dr= cmd.ExecuteReader
  While dr.Read() 
    TextBox1.Text = dr(0)

  End While
   TextBox1.Text = (TextBox1.Text+1).ToString

  dr.Close()

  TextBox2.Focus() 
End Sub
'This is to add items 
Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

  If Len(TextBox2.Text) = 0 Then 
   MsgBox("Please enter the itemname") 
   TextBox1.Focus()

    Exit Sub

   End If

  If Len(TextBox3.Text) = 0 Then 
    MsgBox("Please enter the brand")
    TextBox3.Focus()

   Exit Sub

  End If

   If Len(TextBox4.Text) = 0 Then 
     MsgBox("Please enter the description") 
     TextBox4.Focus()

    Exit Sub

   End If

    If Len(TextBox6.Text) = 0 Then 
       MsgBox("Please enter the price") 
       TextBox6.Focus()

     Exit Sub

    End If

    If Len(TextBox7.Text) = 0 Then
      MsgBox("Please enter the quantity")
      TextBox7.Focus() Exit Sub

    End If
'Declaring str variable and assigning the insert query which contains those values which are extracted from the textboxes
    Dim str As String 
    str = "insert into items(Item_id,Item name,Brand, Description Purchased date Price,Quantity)values("& TextBox1.Text & ",'"& TextBox2.Text &"','"&TextBox3.Text &"','"& TextBox4.Text &"',#"& DateTimePicker1.Text & "#, "& TextBox6.Text & "," & TextBox7.Text & ")"
   
'then passing to the command that query
    cmd =  New OleDb.OleDbCommand(str) 

    cmd.Connection = спn
       'executing the query
    cmd.ExecuteNonQuery()

    MsgBox("one row inserted") 
    TextBox2.Text = ""

    TextBox3.Text = ""
     cmd = New OleDb.OleDbCommand("select MAX(Item_id) from items",cnn)

    dr = cmd.ExecuteReader

    While dr.Read()

    TextBox1.Text = dr(0)

    End While

    TextBox1.Text = (TextBox1.Text + 1).ToString

    dr.Close()

    TextBox6.Text = ""

    TextBox7.Text = ""

    TextBox2.Focus()

    Deleteitems.ComboBox1.Refresh()

End Sub
'once the datas are inserted making the boxes clear and first box to focus
Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    TextBox2.Text = "" 
    TextBox3.Text = ""
    TextBox4.Text = ""
    TextBox6.Text = ""
    TextBox7.Text = "" 
    TextBox2.Focus()

End Sub

Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click 
    Me.Hide() 
    Items.Show()

End Sub

End Class



