Public Class Form1
    Private Sub rdbmon_CheckedChanged(sender As Object, e As EventArgs) Handles rdbmon.CheckedChanged
        grbmetodo.Enabled = True : grbanterior.Enabled = True
    End Sub

    Private Sub rdbmonPremiere_CheckedChanged(sender As Object, e As EventArgs) Handles rdbmonPremiere.CheckedChanged
        grbmetodo.Enabled = True : grbanterior.Enabled = True
    End Sub

    Private Sub rdbahorro_CheckedChanged(sender As Object, e As EventArgs) Handles rdbahorro.CheckedChanged
        grbmetodo.Enabled = True : grbanterior.Enabled = True
    End Sub

    Private Sub chbchqpropio_CheckedChanged(sender As Object, e As EventArgs) Handles chbchqpropio.CheckedChanged
        If (rdbmon.Checked = True Or rdbmonPremiere.Checked = True Or rdbahorro.Checked = True) And chbchqpropio.Checked = True Then
            txtchqPropio.Enabled = True
        Else
            txtchqPropio.Enabled = False
        End If
    End Sub

    Private Sub chbchqOtro_CheckedChanged(sender As Object, e As EventArgs) Handles chbchqOtro.CheckedChanged
        If (rdbmon.Checked = True Or rdbmonPremiere.Checked = True Or rdbahorro.Checked = True) And chbchqOtro.Checked = True Then
            txtchqOtro.Enabled = True
        Else
            txtchqOtro.Enabled = False
        End If
    End Sub

    Private Sub chbefectivo_CheckedChanged(sender As Object, e As EventArgs) Handles chbefectivo.CheckedChanged
        If (rdbmon.Checked = True Or rdbmonPremiere.Checked = True Or rdbahorro.Checked = True) And chbefectivo.Checked = True Then
            txtefectivo.Enabled = True
        Else
            txtefectivo.Enabled = False
        End If
    End Sub

    Private Sub btncalcular_Click(sender As Object, e As EventArgs) Handles btncalcular.Click
        saldoAnterior = Val(txtsaldoAnterior.Text)
        totalDeposito = Val(txtchqOtro.Text) + Val(txtchqPropio.Text) + Val(txtefectivo.Text)
        saldoAcumulado = totalDeposito + saldoAnterior
        If rdbahorro.Checked = True Then
            Select Case saldoAcumulado
                Case 1.01 To 1000.99
                    iAhorro = iAhorroA / 100
                Case 1001 To 5000.99
                    iAhorro = iAhorroB / 100
                Case 5001 To 15000.99
                    iAhorro = iAhorroC / 100
                Case Is >= 15001
                    iAhorro = iAhorroD / 100
                Case Else
                    iAhorro = 0
            End Select
        Else
            iAhorro = 0
        End If
        If rdbmonPremiere.Checked = True Then
            Select Case saldoAnterior
                Case 1.01 To 10000.99
                    iPremiere = iPremiereA / 100
                Case 10001 To 15000.99
                    iPremiere = iPremiereB / 100
                Case Is >= 15001
                    iPremiere = iPremiereC / 100
                Case Else
                    iPremiere = 0
            End Select
        Else
            iPremiere = 0
        End If
        saldoNuevo = saldoAcumulado + saldoAcumulado * iAhorro + saldoAnterior * iPremiere

        lblsaldoAnterior.Text = saldoAnterior
        lblinterespremiere.Text = Str(iPremiere * 100) + "%"
        lbltotalDeposito.Text = Str(totalDeposito)
        lblsaldoAcumulado.Text = Str(saldoAcumulado)
        lblinteresAhorro.Text = Str(iAhorro * 100) + "%"
        lblsaldoNuevo.Text = Str(saldoNuevo)

    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        'condicionante para ejecutar la limpieza de datos con MsgBox
        If MsgBox("¿Desea limpiar los datos?", vbQuestion + vbYesNo, "LIMPIEZA DE DATOS") = vbYes Then
            'Limpieza de todos los datos
            rdbmon.Checked = False
            rdbmonPremiere.Checked = False
            rdbahorro.Checked = False
            grbmetodo.Enabled = False
            chbchqpropio.Checked = False
            chbchqOtro.Checked = False
            chbefectivo.Checked = False
            txtchqPropio.Clear()
            txtchqOtro.Clear()
            txtefectivo.Clear()
            grbanterior.Enabled = False
            txtsaldoAnterior.Clear()
            lblsaldoAnterior.Text = ""
            lblinterespremiere.Text = ""
            lbltotalDeposito.Text = ""
            lblsaldoAcumulado.Text = ""
            lblinteresAhorro.Text = ""
            lblsaldoNuevo.Text = ""

        End If
    End Sub

    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        'condicionante para ejecutar el cierre del programa con MsgBox
        If MsgBox("¿DESEA SALIR?", vbQuestion + vbYesNo, "SALIR DEL PROGRAMA") = vbYes Then
            'Cierre del programa
            Me.Close()
        End If
    End Sub


End Class
