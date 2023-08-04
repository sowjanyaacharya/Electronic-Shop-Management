Public Class stockhand 
Dim cnn As OleDb.OleDbConnection
Dim cmd As OleDb.OleDbCommand 
Dim dr As OleDb.OleDbDataReader
Dim da As OleDb.OleDbDataAdapter 
Dim ds As DataSet

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

cnn = New OleDb.OleDbConnection("Provider=Microsoft ACE OLEDB 12.0;DataSource=D:\project2021\project21.accdb")

cnn.Open()

If Len(ComboBox1.Text) = 0 Then 
MsgBox("Please Select the Item_name")

ComboBox1.Focus()

Exit Sub

End If
cmd = New OleDb.OleDbCommand("Select item_id,item_name,Brand Description Price Quantity from items where item name='" & ComboBox1.Text & "'") 
cmd.Connection = cnn
da = New OleDb.OleDbDataAdapter

da.SelectCommand = cmd

ds = New DataSet

da.Fill(ds, "items")

DataGridView1.DataSource= ds.Tables("items")

End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

Me.Hide()

Form1.Show()

End Sub

End Class
