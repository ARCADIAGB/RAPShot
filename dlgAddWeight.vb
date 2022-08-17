Imports System.Windows.Forms

Public Class dlgAddWeight

    Private _PellWeight As Single
    Private _PellSpeed As String

    Public ReadOnly Property PelletWeight() As Single
        Get
            Return FormatNumber(_PellWeight, 2, TriState.False, TriState.False, TriState.False)

        End Get
    End Property

    Public WriteOnly Property PelletSpeed() As String
        Set(ByVal value As String)
            _PellSpeed = value
        End Set
    End Property

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Try
            _PellWeight = CDbl(txtWeight.Text)
        Catch ex As Exception

        End Try
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        txtWeight.AppendText("1")
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        txtWeight.AppendText("2")
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        txtWeight.AppendText("3")
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        txtWeight.AppendText("4")
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        txtWeight.AppendText("6")
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        txtWeight.AppendText("7")
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        txtWeight.AppendText("8")
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        txtWeight.AppendText("9")
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        txtWeight.Text = ""
    End Sub

    Private Sub ButtonDot_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDot.Click
        txtWeight.AppendText(".")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        txtWeight.AppendText("0")
    End Sub

    Private Sub dlgAddWeight_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblPellSpeed.Text = _PellSpeed

    End Sub

    Private Sub dlgAddWeight_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Me.TopMost = True
        txtWeight.Focus()

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        txtWeight.AppendText("5")

    End Sub


End Class
