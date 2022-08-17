Public Class frmWeightConfig

    Public ReadOnly Property WeightMode()
        Get
            Return _WeightMode
        End Get
    End Property

    Private _WeightMode As String = ""


    Private Sub cmdNominal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNominal.Click
        _WeightMode = "CHRONO"
        Me.Close()

    End Sub

    Private Sub cmdUserWeight_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUserWeight.Click
        _WeightMode = "USER"
        Me.Close()

    End Sub
End Class