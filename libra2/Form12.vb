﻿Imports System.Data.SqlClient

Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet8.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter1.Fill(Me.Database1DataSet8.books)
        'TODO: This line of code loads data into the 'Database1DataSet7.books' table. You can move, or remove it, as needed.
        Me.BooksTableAdapter.Fill(Me.Database1DataSet7.books)
        disp_data()
    End Sub
    Public Sub disp_data()
        If ConnectionState.Open Then
            a.Close()
        End If
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from books where Availability = 'Available'"
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        DataGridView2.DataSource = dt
        a.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        disp_data()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a.Open()
        b = a.CreateCommand()
        b.CommandType = CommandType.Text
        b.CommandText = "select * from books where Tittle = '" + TextBox1.Text + "'"
        b.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(b)
        da.Fill(dt)
        DataGridView2.DataSource = dt
        a.Close()
    End Sub
End Class