'updating the items in the database
Public Class Updateitem
'declaring the variables using the dim
Dim cnn As OleDb.OleDbConnection
Dim cnn1 As OleDb.OleDbConnection
Dim cmd As OleDb.OleDbCommand 
Dim cmd1 As OleDb.OleDbCommand
Dim dr As OleDb.OleDbDataReader 
Dim dri As OleDb.OleDbDataReader

Private Sub Updateltem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load 
  'open the connection
cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB. 12.0,Da Source=D:\project2021\project21.accdb")
cnn.Open()

cmd= New OleDb.OleDbCommand("select * from items", cnn)
cmd.ExecuteReader()

While dr.Read()
 ComboBox1.Items.Add(dr(0))

End While

End Sub

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click 
If Len(ComboBox1.Text) = 0 Then

MsgBox("Please Select the Item_id")

ComboBox1.Focus()

Exit Sub

End If

If Len(TextBox2.Text) = 0 Then

MsgBox("Please Enter the quantity")

TextBox2.Focus()

Exit Sub

End If

cnn New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB:12.0)DataSource=D:\project2021\project21.accdb") 
cnn.Open()
'using the update query
Dim sql As String 
sql = "Update items set Quantity = " & TextBox2.Text &" where Item_id=" & ComboBox1.Text &""

cmd = New OleDb.OleDbCommand(sql, cnn)

cmd.ExecuteNonQuery()
MsgBox("Record updated")

End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click 
ComboBox1.Text = ""

TextBox2.Text =""

End Sub

Private Sub Button3 Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button).Click

Me.Hide()

items.Show()

End Sub

End Class

 

