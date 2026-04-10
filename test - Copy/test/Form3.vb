Imports System.Data.OleDb
Imports System.IO

Public Class Form3
    Dim conn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\test1.accdb")
    Dim dr As OleDbDataReader
    Dim i As Integer
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conn.Open()
            lbl_connection.Text = "DONE"
            lbl_connection.ForeColor = Color.Lime
            Button1.BackColor = Color.LimeGreen
        Catch ex As Exception
            lbl_connection.Text = "EXIT"
            lbl_connection.ForeColor = Color.Red
        End Try
        conn.Close()

        loadingDatagridView()
    End Sub

    Sub loadingDatagridView()
        Try
            DataGridView1.Rows.Clear()
            conn.Open()
            Dim cmd As New OleDb.OleDbCommand("Select * from Otbl", conn)
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
        txt_rcv.Clear()
    End Sub

    Sub save()
        Try
            conn.Open()
            If MsgBox("Are you want to add this?", vbQuestion + vbYesNo) = vbYes Then
                Dim sql As String = "Insert into Otbl (OrderAmount) values (@OrderAmount)"
                Dim cmd As New OleDb.OleDbCommand(sql, conn)
                cmd.Parameters.Clear()
                cmd.Parameters.AddWithValue("@OrderAmount", txt_rcv.Text)
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
End Class