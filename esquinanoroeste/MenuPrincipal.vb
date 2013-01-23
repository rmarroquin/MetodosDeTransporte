Public Class MenuPrincipal

    Private Sub MetodoEsquinaNorOesteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetodoEsquinaNorOesteToolStripMenuItem.Click
        ActiveForm.SendToBack()
        Dim frmesquina As New frmEsquinaNorOeste
        frmesquina.ShowDialog()


    End Sub

    Private Sub MetodoCostoMínimoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetodoCostoMínimoToolStripMenuItem.Click
        ActiveForm.SendToBack()
        Dim frmcosto As New frmCostoMinimo
        frmcosto.ShowDialog()

    End Sub

    Private Sub MetodoDeVoguelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetodoDeVoguelToolStripMenuItem.Click
        ActiveForm.SendToBack()
        Dim frmvoguel2 As New frmVoguel
        frmvoguel2.ShowDialog()
    End Sub


    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        ActiveForm.SendToBack()
        Dim frmacercamenu As New AcercadeMetodosdeTransporte
        frmacercamenu.ShowDialog()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        ActiveForm.Close()
    End Sub

    Private Sub MetododeRussellToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetododeRussellToolStripMenuItem.Click
        ActiveForm.SendToBack()
        Dim frmrussell As New frmRussell
        frmrussell.ShowDialog()
    End Sub
End Class