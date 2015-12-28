Public Class Asientos_Contables

    Dim Dt As System.Data.DataTable
    Dim sql As New MySQL
    Dim i As Integer
    Dim TotalDebito
    Dim TotalCredito

    'CARGAR EL COMBO
    Private Sub Cargar_combo(ByVal Combo As System.Object, ByVal Texto As String, ByVal Clave As String)
        Combo.Items.Add(New MiComboBox(Texto, Clave))
    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub


    Private Sub BtnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevo.Click
        PDetalle.Enabled = True
        BtGuardar.Enabled = True
        BtnCancelar.Enabled = True
        DataGridView1.Enabled = True
        TxtMotivo.Enabled = True
        BtnNuevo.Enabled = False

        Dt = sql.LEER("SELECT pc.Id_Plan, pc.clave_contable, pc.descripcion FROM plan_cuentas pc WHERE (pc.baja = 'N') and (pc.imputable = 'S')")

        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CBoxCuentas, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Id_Plan").ToString())
            End If
        Next i
    End Sub

    Private Sub BtnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAgregar.Click
        Dim id_plan As Integer

        If (Trim(txtDebe.Text) = "") And (Trim(txtHaber.Text) = "") Then
            MsgBox("Debe Ingresar el importe en El DEBE o el Haber, VERIFIQUE")
        Else
            id_plan = CBoxCuentas.Items(CBoxCuentas.SelectedIndex).itemdata()

            Dt = sql.LEER("SELECT pc.Id_Plan, pc.clave_contable, pc.descripcion FROM plan_cuentas pc WHERE (pc.Id_Plan = '" & id_plan & "') ")

            DataGridView1.Rows.Add(1)
            DataGridView1.Item(0, i).Value = Dt.Rows(0).Item("Id_Plan").ToString()
            DataGridView1.Item(1, i).Value = Dt.Rows(0).Item("clave_contable").ToString()
            DataGridView1.Item(2, i).Value = Dt.Rows(0).Item("descripcion").ToString()

            TotalDebito = TotalDebito + Val(txtDebe.Text)
            TotalCredito = TotalCredito + Val(txtHaber.Text)

            lblDatos.Text = "Total Debe:   $" + TotalDebito.ToString + "   Total Haber:   $" + TotalCredito.ToString + "   Diferencia DEBE/HABER:   $" + (TotalDebito - TotalCredito).ToString

            DataGridView1.Item(3, i).Value = coma_punto(Format(Val(txtDebe.Text), "#,###,###,##0.00"))
            DataGridView1.Item(4, i).Value = coma_punto(Format(Val(txtHaber.Text), "#,###,###,##0.00"))

            i = i + 1

            txtDebe.Clear()
            txtHaber.Clear()
        End If
    End Sub

    Private Sub BtAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtGuardar.Click
        Dim id_plan As String
        Dim debito As Double
        Dim credito As Double
        Dim id_asiento_contable_cabecera

        If Trim(TxtMotivo.Text) = "" Then
            MsgBox("Debe Cargar un Motivo, VERIFIQUE")
            TxtMotivo.Focus()
            Exit Sub
        End If

        If TotalDebito <> TotalCredito Then
            MsgBox("Verifique que su cuenta se encuentre balanceada")
            CBoxCuentas.Focus()
            Exit Sub
        End If

        sql.INSERT_UPDATE_DELETE("Insert into asiento_contable_cabecera(fecha, motivo) values('2011-08-01' ,'" & TxtMotivo.Text & "')")

        For i As Integer = 0 To (DataGridView1.Rows.Count - 2)
            If DataGridView1.Item(0, i).Value <> "" Then

                If DataGridView1.Item(3, i).Value = "" Then
                    debito = 0
                Else
                    debito = CDbl(coma_punto(DataGridView1.Item(3, i).Value))
                End If

                If DataGridView1.Item(4, i).Value = "" Then
                    credito = 0
                Else
                    credito = CDbl(coma_punto(DataGridView1.Item(4, i).Value))
                End If

                id_plan = DataGridView1.Item(0, i).Value

                Dt = sql.LEER("SELECT acc.Id_asiento_contable_cabecera FROM asiento_contable_cabecera acc order by acc.Id_asiento_contable_cabecera desc")

                id_asiento_contable_cabecera = Dt.Rows(0).Item("Id_asiento_contable_cabecera").ToString()
                sql.INSERT_UPDATE_DELETE("Insert into asientos_contables(id_plan, debito, credito, id_asiento_contable_cabecera) values('" & id_plan & "','" & debito & "', '" & credito & "', '" & id_asiento_contable_cabecera & "')")

            End If
        Next

        MsgBox("Los Datos Se cargaron con Exito")
        DataGridView1.Rows.Clear()
        TxtMotivo.Clear()
        CBoxCuentas.Items.Clear()
        PDetalle.Enabled = False
        BtGuardar.Enabled = False
        BtnCancelar.Enabled = False
        DataGridView1.Enabled = False
        TxtMotivo.Enabled = False
        BtnNuevo.Enabled = True
        lblDatos.Text = ""
        i = 0
    End Sub

    Private Sub BtnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancelar.Click
        DataGridView1.Rows.Clear()
        TxtMotivo.Clear()
        PDetalle.Enabled = False
        BtGuardar.Enabled = False
        BtnCancelar.Enabled = False
        DataGridView1.Enabled = False
        TxtMotivo.Enabled = False
        BtnNuevo.Enabled = True
        CBoxCuentas.Items.Clear()
        lblDatos.Text = ""
        i = 0
    End Sub


    Private Sub BtnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnQuitar.Click
        Dim debito As Double
        Dim credito As Double
        Dim fila As Integer

        fila = DataGridView1.CurrentRow.Index

        If DataGridView1.Item(0, fila).Value <> "" Then

            If DataGridView1.Item(3, fila).Value = "" Then
                debito = 0
            Else
                debito = CDbl(coma_punto(DataGridView1.Item(3, fila).Value))
            End If

            If DataGridView1.Item(4, fila).Value = "" Then
                credito = 0
            Else
                credito = CDbl(coma_punto(DataGridView1.Item(4, fila).Value))
            End If

            TotalDebito = TotalDebito - debito
            TotalCredito = TotalCredito - credito

            lblDatos.Text = "Total Debe:   $" + TotalDebito.ToString + "   Total Haber:   $" + TotalCredito.ToString + "   Diferencia DEBE/HABER:   $" + (TotalDebito - TotalCredito).ToString
            i = i - 1
            DataGridView1.Rows.Remove(DataGridView1.CurrentRow)
        End If
    End Sub
End Class