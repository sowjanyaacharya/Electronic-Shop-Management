'This form focuses on deleting the items
Public Class Deleteltems
'declaring the data variables using the Dim
Dim cnn As OleDb.OleDbConnection 
Dim cmd As OleDb.OleDbCommand 
Dim dr As OleDb.OleDbDataReader 
Dim da As OleDb.OleDbDataAdapter
Dim ds As DataSet
'when clicking on the form it generates automaticaly the code
Private Sub Deleteitems_Load(ByVal System.EventArgs) Handles MyBase.Load

    ComboBox1.Refresh()
        'Establishing the connection by providing the database path
    спп =  New OleDb.OleDbConnection("Provider=Microsoft ACE OLEDB: 12.0:Data Source=D:\project2021\project21.accdb")
        'opening the connection
    cnn.Open()
    cmd = New OleDb.OleDbCommand("select distinct(item_id) from items", cnn)
    dr= cmd.ExecuteReader

    While dr.Read()

    ComboBox1.Items.Add(dr(0))

    End While

    dr.Close()

End Sub
'while clicking on the button1 which is named as delete
Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    If Len(ComboBox1.Text) = 0 Then 
     MsgBox("Please Select the Item Id")

     ComboBox1.Focus() 
     Exit Sub

    End If

Dim str As String
'it is the query to delete the items using item_id
str = "delete from items where Item_id = "& ComboBox1.SelectedItem &"" 
cmd = New OleDb.OleDbCommand(str, cnn) 
 

MsgBox(cmd.ExecuteNonQuery() & "Record deleted")
ComboBox1.Refresh()

cnn.Close() 
End Sub
'once we delete the items we are clearing the boxes
Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click 
ComboBox1.Refresh() 
ComboBox1.Text = ""
ComboBox1.Focus() 
ComboBox1.Items.Remove(ComboBox1.SelectedItem)

End Sub
'then by clicking the back button it moves backward to the items form
Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

Me.Hide()

items.Show()

End Sub

End Class






