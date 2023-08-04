Public Class Viewitems

Dim cnn As OleDb.OleDbConnection 
Dim cmd As OleDb.OleDbCommand 
Dim dr As OleDb.OleDbDataReader
 Dim da As OleDb.OleDbDataAdapter

Dim ds As DataSet 

Private Sub view_Click(ByVal sender As System.EventArgs) Handles view.Click

System.Object, ByVal e As

cnn = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0:Data Source D:\project2021\project21.accdb")

cnn.Open()

cmd = New OleDb.OleDbCommand("select from items")

cmd.Connection = cnn

da = New OleDb.OleDbDataAdapter

da.SelectCommand = cmd

ds= New DataSet

da.Fill(ds, "items")

DataGridView1.DataSource = ds.Tables("items")

End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

Me.Hide()

items.Show() 
End Sub

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

End Sub

End Class



