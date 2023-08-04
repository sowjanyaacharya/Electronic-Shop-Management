Public Class Deleteltems

Dim cnn As OleDb.OleDbConnection 
Dim cmd As OleDb.OleDbCommand 
Dim dr As OleDb.OleDbDataReader 
Dim da As OleDb.OleDbDataAdapter
Dim ds As DataSet

Private Sub Deleteitems_Load(ByVal System.EventArgs) Handles MyBase.Load

    ComboBox1.Refresh()
    спп =  New OleDb.OleDbConnection("Provider=Microsoft ACE OLEDB: 12.0:Data Source=D:\project2021\project21.accdb")
    cnn.Open()
    cmd = New OleDb.OleDbCommand("select distinct(item_id) from items", cnn)
    dr= cmd.ExecuteReader

    While dr.Read()

    ComboBox1.Items.Add(dr(0))

    End While

    dr.Close()

End Sub

Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    If Len(ComboBox1.Text) = 0 Then 
     MsgBox("Please Select the Item Id")

     ComboBox1.Focus() 
     Exit Sub

    End If

Dim str As String

str = "delete from items where Item_id = "& ComboBox1.SelectedItem &"" 
cmd = New OleDb.OleDbCommand(str, cnn) 
 

MsgBox(cmd.ExecuteNonQuery() & "Record deleted")
ComboBox1.Refresh()

cnn.Close() 
End Sub

Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click 
ComboBox1.Refresh() 
ComboBox1.Text = ""
ComboBox1.Focus() 
ComboBox1.Items.Remove(ComboBox1.SelectedItem)

End Sub

Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

Me.Hide()

items.Show()

End Sub

End Class






