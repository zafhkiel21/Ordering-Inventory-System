Imports System.Data.OleDb
Imports System.IO

Public Class Form3
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\test1.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conn.Close()

        loadingDatagridView()
    End Sub

    Sub loadingDatagridView()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from InventoryTbl", conn)
            dr = cmd.ExecuteReader
            While dr.Read
                DataGridView1.Rows.Add(dr.Item("OrderID"), dr.Item("OrderAmount"), dr.Item("Date"))
            End While
            dr.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

    Sub clear()
        txt_order.Clear()
    End Sub

    Sub save()
        Try
            conn.Open()
            If MsgBox("Are you want to add this?", vbQuestion + vbYesNo) = vbYes Then
<<<<<<< Updated upstream
                Dim sql As String = "Insert into Otbl (OrderAmount) values (@OrderAmount)"

=======
                Dim sql As String = "Insert into InventoryTbl (OrderAmount) values (@OrderAmount)"
>>>>>>> Stashed changes
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@OrderAmount", txt_order.Text)
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

    Public Shadows Sub update()
        Try
            conn.Open()
            If MsgBox("Are you want to Update this?", vbQuestion + vbYesNo) = vbYes Then
                Dim sql As String = "UPDATE InventoryTbl SET OrderAmount = @OrderAmount Where OrderID = @OrderID"
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@OrderAmount", CInt(txt_order.Text))
                cmd.Parameters.AddWithValue("@OrderID", CInt(Label3.Text))
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Update Successful", vbInformation)
                Else
                    MsgBox("Failed to Update", vbCritical)
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
    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

    End Sub

    Private Sub Record_Click(sender As Object, e As EventArgs) Handles Record.Click
        Records.Show()
=======
    Private Sub txt_rcv_TextChanged(sender As Object, e As EventArgs) Handles txt_order.TextChanged

    End Sub

    Sub Delete()
        Try
            conn.Open()
            If MsgBox("Are you want to Delete this?", vbQuestion + vbYesNo) = vbYes Then
                Dim sql As String = "DELETE FROM InventoryTbl Where OrderID = @OrderID"
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@OrderID", CInt(Label3.Text))
                i = cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Successful Deleted", vbInformation)
                Else
                    MsgBox("Failed To Delete Record", vbCritical)
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
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            Dim clickedID As String = selectedRow.Cells("OrderID").Value.ToString()
            Label3.Text = clickedID

            Label3.Text = selectedRow.Cells("OrderID").Value.ToString()
        End If
    End Sub


    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        update()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Delete()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim Form4 As New Form4
        Form4.Show()
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Form4 As New Form4
        Form4.Show()
>>>>>>> Stashed changes
    End Sub
End Class