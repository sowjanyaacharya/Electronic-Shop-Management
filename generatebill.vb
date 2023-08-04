Public Class bill1

Dim cnn As OleDb.OleDbConnection 
Dim cmd As OleDb.OleDbCommand 
Dim dr As OleDb.OleDbDataReader 
Dim da As OleDb.OleDbDataAdapter

Dim ds As DataSet 
Dim price, Total As Double 
Dim Grand total As Double

Dim i As Integer = 1 
Dim item_name, description, brand As String

Dim qty As Integer

Private Sub bill1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

Grand_total = 0

cnn = New OleDb.OleDbConnection("Provider=Microsoft ACE, OLED6,120,DataSource=D:\project2021\project21.accdb")


cnn.Open()

cmd = New OleDb.OleDbCommand("select distinct (item_id) from items", cnn)

dr = cmd.ExecuteReader

While dr.Read()

ComboBox1.Items.Add(dr(0))

End While

dr.Close()

cmd = New OleDb.OleDbCommand("select MAX(Bill_no)from billing", cnn)

dr = cmd.ExecuteReader

While dr.Read() 
TextBox1.Text = dr(0)

End While

TextBox1.Text = (TextBox1.Text + 1).ToString
dr.Close()

TextBox2.Focus() 
End Sub

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click 
If Len(TextBox2.Text) = 0 Then

MsgBox("Please Enter the customer name")

TextBox2.Focus()

Exit Sub

End If

If Len(RichTextBox1.Text) = 0 Then
 MsgBox("Please Enter the customer address")

 RichTextBox1.Focus()

 Exit Sub

End If

If Len(TextBox6.Text) = 0 Then 
 MsgBox("Please Enter the quantity") 
 TextBox6.Focus() 
 Exit Sub

End If

DataGridView1.Refresh()

Dim str As String

str = "select Quantity from items where item_id="& ComboBox1.Text & ""

cmd = New OleDb.OleDbCommand(str, cnn)

Dim dr As OleDb.OleDbDataReader

dr = cmd.ExecuteReader

Dim available_qty As Integer

While dr.Read() 
available_qty = dr(0)

Exit While
End While
If available_qty<Val(TextBox6.Text) Then 
 MsgBox("Insufficient Stock")

End If

Exit Sub

str = "select Item_id,Item_name,Brand Description, Price, Quantity from items where Item_id=" & ComboBox1.Text &""

cmd = New OleDb.OleDbCommand(str, cnn)



qty= Val(TextBox6.Text) 
Dim main_qty As Double 
dr = cmd.ExecuteReader

While (dr.Read) 
item_name = dr(1)

main_qty = dr(5)

price = dr(4)
brand = dr(2)

End While

description = dr(3)

Total = qty * price

Grand_total = Grand_total + Total

Dim row As String() = New String() {i, ComboBox1.Text, TextBox3.Text. TextBox4.Text, TextBox5.Text, qty, price, total}
 DataGridView1.Rows.Add(row)

i=i+1

Dim rqty As Double = main_qty - qty

str = "update items set quantity = "&rqty&" where item_id = " & ComboBox1.Text & ""



cmd = New OleDb.OleDbCommand(str, cnn)

cmd.ExecuteNonQuery()

str = "insert into billing (Bill_no, Cust_name, Cust_address, Item_id, Item_name, Brand, Description, Quantity, Bill date, Price, Total,Grand Total) values (" &TextBox1.Text & ",'" & TextBox2.Text & "','" & RichTextBox1.Text & "',"& ComboBox1.Text & ",'" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox5.Text &"',"& TextBox6.Text & ",#"&DateTimePicker1.Text&"#,"& price &","& Total & "," & Grand_total &")"
cmd = New OleDb.OleDbCommand(str,cnn)

MsgBox(cmd.ExecuteNonQuery().ToString & "Record Inserted ")

TextBox3.Text = ""
ComboBox1.Text = "" 
TextBox4.Text = ""
TextBox5.Text = ""
TextBox6.Text = ""

dr.Close()

TextBox2.Focus() 
End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click 
If Len(ComboBox1.Text) = 0 Then 
MsgBox("Please Select the Item Id")

ComboBox1.Focus()

Exit Sub

End If

If Len(TextBox2.Text) = 0 Then

MsgBox("Please Enter the customer name") 
Exit Sub

TextBox2.Focus()

End If

If Len(RichTextBox1.Text) = 0 Then 
MsgBox("Please Enter the customer address")

RichTextBox1.Focus()

Exit Sub

End If
cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\project2021\project1.accdb")
cnn.Open()
cmd = New OleDb.OleDbCommand("select Item_name,Brand,Description from items where Item_id= "& ComboBox1.SelectedItem"") 

cmd.Connection = cnn 
dr = cmd.ExecuteReader()

While (dr.Read()) 
TextBox3.Text = dr(0)

TextBox4.Text = dr(1) 
TextBox5.Text = dr(2)
Exit While

End While 
End Sub

Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click 
Dim row1 As String() = New String() {"","","Grand total", Grand total} 
DataGridView1.Rows.Add(row)

End Sub

Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

print.Show()
End Sub

Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click

Me.Hide() 
bill.Show()

End Sub

Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click 

cmd = New OleDb.OleDbCommand("select MAX(Bill_no)from billing", cnn)

dr = cmd.ExecuteReader

While dr.Read()

TextBox1.Text = dr(0)

End While 
TextBox2.Text = ""

TextBox3.Text = ""
ComboBox1.Text = ""
cmd = New OleDb.OleDbCommand("select MAX(Bill_no)from billing",cnn)

dr = cmd.ExecuteReader
While dr.Read()
TextBox1.Text = dr(0)
End While

TextBox1.Text = (TextBox1.Text +1).ToString
DataGridView1.Refresh() 
TextBox4.Text =""
TextBox5.Text =""
TextBox6.Text = ""

DataGridView1.Rows.Clear() 
RichTextBox1.Text =""

End Sub

End Class







