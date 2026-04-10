Imports System.Data.OleDb
Imports System.IO

Public Class Form2
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\test1.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.Close()

        loadingDatagridView()
    End Sub

    Sub loadingDatagridView()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
<<<<<<< Updated upstream
            Dim cmd As New OleDb.OleDbCommand("Select * from testtbl", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("Received"), dr.Item("DateRcv"))
=======
            Dim cmd As New OleDb.OleDbCommand("Select * from InventoryTbl", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("OrderID"), dr.Item("Received"), dr.Item("DateReceived"))
>>>>>>> Stashed changes
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub clear()
        txt_rcv.Clear()
    End Sub

    Sub save()
        Try
            conn.Open()
            If MsgBox("Are you want to add this?", vbQuestion + vbYesNo) = vbYes Then
<<<<<<< Updated upstream
                Dim sql As String = "Insert into testtbl (Received) values (@Received)"
=======
                Dim sql As String = "Update InventoryTbl SET Received = @Received Where OrderID = @OrderID"
>>>>>>> Stashed changes
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@Received", CInt(txt_rcv.Text))
                cmd.Parameters.AddWithValue("@OrderID", CInt(Label3.Text))
                cmd.Parameters.AddWithValue("@DateReceived", DateTime.Now)
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Successful Record", vbInformation)
                Else
                    MsgBox("Failed Record", vbCritical)
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            conn.Close()
        End Try
        loadingDatagridView()
        clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        save()
    End Sub
<<<<<<< Updated upstream
=======

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim clickedID As String = selectedRow.Cells("OrderID").Value.ToString()
            Label3.Text = clickedID

            Label3.Text = selectedRow.Cells("OrderID").Value.ToString()
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
>>>>>>> Stashed changes
End Class