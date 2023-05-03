Imports System.Data.SqlClient
Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ConnectionState.Open Then
            a.Close()
        End If
        a.Open()
        Dim usercmd1 As New SqlCommand
        Dim usestmt1 As String
        Dim total1 As String


        usestmt1 = "select count(*) from books"
        usercmd1 = New SqlCommand(usestmt1, a)
        total1 = usercmd1.ExecuteScalar

        Label2.Text = total1


        Dim usercmd2 As New SqlCommand
        Dim usestmt2 As String
        Dim total2 As String


        usestmt2 = "select count(*) from studentinfo"
        usercmd2 = New SqlCommand(usestmt2, a)
        total2 = usercmd2.ExecuteScalar

        Label3.Text = total2
        a.Close()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
        Me.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
        Form6.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Me.Close()
        Form7.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class