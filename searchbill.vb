'search bill is used to search the bill
Public Class still 
Dim cnn As OleDb.OleDbConnection
Dim cmd As OleDb.OleDbCommand 
Dim dr As OleDb.OleDbDataReader
Dim da As OleDb.OleDbDataAdapter 
Dim ds As DataSet 
Dim qty As Integer
Dim Grand_Total, Total, price As Double



Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click 

cnn = New OleDb.OleDbConnection("Provider=Microsoft ACE.OLEDB 12.0;Data Source=D:\project2021\project21.accdb")
cnn.open()
'extracting the datas from the billing table
cmd= New OleDb.OleDbCommand("select Item_id,Item_name,Bill_date,Brand,Description,Quantity Price, Total from billing where bill_no = " & TextBox1.Text & "")

cmd.Connection = cnn

da = New OleDb.OleDbDataAdapter 

ds= New DataSet

da.Fill(ds, "billing")

DataGridView1.DataSource = ds.Tables("billing") 
cmd = New OleDb.OleDbCommand("select Quantity, Price, Cust_name, Cust_address from billing where bill_no = " & TextBox1.Text & "")

cmd.Connection = cnn 
dr = cmd.ExecuteReader

While (dr.Read)

qty = dr(0)

price = dr(1)

TextBox3.Text = dr(2)

RichTextBox1.Text = dr(3)

Total = qty*price

Grand_Total = Grand_Total + Total 
TextBox2.Text = Val(Grand_Total)

End While

End Sub
Private Sub Button2 Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
Me.Hide() 
bill.Show()

End Sub

Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click 
TextBox1.Text=""
TextBox2.Text =""
TextBox3.Text = ""

RichTextBox1.Text ="" 
DataGridView1.Rows.Clear() 
End Sub

End Class




