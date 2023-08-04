Public Class print Dim str As String

Dim cnn As OleDb.OleDbConnection
Dim cmd As OleDb.OleDbCommand
Dim dr As OleDb.OleDbDataReader
Dim da As OleDb.OleDbDataAdapter
Dim ds As DataSet
Dim item_name, description, brand As String
Dim qty As Integer 
Dim price, Total, Grand_total As Double
Dim i As Integer = 1

Private Sub print_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
TextBox2.Text = (bill1.TextBox2.Text) 
TextBox1.Text = Val(bill1.TextBox1.Text)
RichTextBox1.Text = bill1.RichTextBox1.Text 
DataGridView1.Visible = True 
cnn = New OleDb.OleDbConnection("Provider=MiosotACE.CLED8.12.0;DataSource:\project2021\project21") 

cnn.Open()

str="select Item name,Brand, Description Quantity, Price, Total, Grand_Total from billing where Bill_no="&bill1.TextBox1.Text &"" 

cmd = OleDb.OleDbCommand(str,cnn)

qty = Val(bill1.TextBox.Text)

dr = cmd.ExecuteReader

While (dr.Read)

item_name = dr(0) 
brand = dr(1)
description = dr(2)
qty = dr(3)
price = dr(4)
Total = dr(5)
Grand_total = Grand_total + Total
Dim row As String() = New String() {item name, brand, description, qty, price,Total}

DataGridView1.Rows.Add(row)

End While

TextBox3.Text = Val(Grand_total)

End Sub

End Class


