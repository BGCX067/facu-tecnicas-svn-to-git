Public Class Libro_Diario
    Dim Dt As System.Data.DataTable
    Dim sql As New MySQL

    Private Sub CargarGrilla(ByVal Consulta As String)
        Dim TotalDebito
        Dim TotalCredito
        Dim varaux
        Dim i

        TotalDebito = 0
        TotalCredito = 0

        Dt = Sql.LEER(Consulta)

        If Dt.Rows.Count = 0 Then
            MsgBox("No se encontro ningun registro")
            Exit Sub
        End If

        varaux = Dt.Rows(0).Item("id_asiento_contable_cabecera")

        For x = 0 To Dt.Rows.Count - 1

            If varaux <> Dt.Rows(x).Item("id_asiento_contable_cabecera") Then

                DataGridView1.Rows.Add(1)
                i = DataGridView1.Rows.Count - 2
                DataGridView1.Item(0, i).Value = "-----"
                DataGridView1.Item(1, i).Value = "-----"
                DataGridView1.Item(2, i).Value = "-----"
                DataGridView1.Item(3, i).Value = "-----"
                DataGridView1.Item(4, i).Value = "-----"
                DataGridView1.Item(5, i).Value = "-----"
                DataGridView1.Item(6, i).Value = "-----"
            End If



            DataGridView1.Rows.Add(1)
            i = DataGridView1.Rows.Count - 2
            DataGridView1.Item(0, i).Value = Dt.Rows(x).Item("id_asiento_contable_cabecera").ToString()
            DataGridView1.Item(1, i).Value = Dt.Rows(x).Item("clave_contable").ToString()
            DataGridView1.Item(2, i).Value = Dt.Rows(x).Item("cuenta").ToString()

            TotalDebito = TotalDebito + Val(Dt.Rows(x).Item("debito").ToString())
            TotalCredito = TotalCredito + Val(Dt.Rows(x).Item("credito").ToString())

            lblDatos.Text = "TOTALES DE CONTROL:    Total Debe:   $" + TotalDebito.ToString + "   Total Haber:   $" + TotalCredito.ToString + "   Diferencia DEBE/HABER:   $" + (TotalDebito - TotalCredito).ToString

            If Val(Dt.Rows(x).Item("debito").ToString()) = 0 Then
                DataGridView1.Item(3, i).Value = ""
            Else
                DataGridView1.Item(3, i).Value = coma_punto(Format(Val(Dt.Rows(x).Item("debito").ToString()), "#,###,###,##0.00"))
            End If

            If Val(Dt.Rows(x).Item("credito").ToString()) = 0 Then
                DataGridView1.Item(4, i).Value = ""
            Else
                DataGridView1.Item(4, i).Value = coma_punto(Format(Val(Dt.Rows(x).Item("credito").ToString()), "#,###,###,##0.00"))
            End If

            DataGridView1.Item(5, i).Value = Dt.Rows(x).Item("motivo").ToString()
            DataGridView1.Item(6, i).Value = Dt.Rows(x).Item("fecha").ToString()

            TxtMotivo.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
            LFechaAsiento.Text = "Fecha Asiento: " + DataGridView1.CurrentRow.Cells.Item(6).Value

            varaux = Dt.Rows(x).Item("id_asiento_contable_cabecera")
        Next
    End Sub

    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click
        DataGridView1.Rows.Clear()

        If (txtfechaDesde.Text = "    /  /") Or (txtfechaHasta.Text = "    /  /") Then
            MsgBox("Debe ingresar Fecha Desde y Fecha Hasta. VERIFIQUE")
            txtfechaDesde.Focus()
            Exit Sub
        End If

        CargarGrilla("select ac.id_asiento_contable_cabecera ,ac.motivo, ac.fecha , pc.clave_contable,a.debito, a.credito, pc.descripcion as cuenta from asiento_contable_cabecera ac left join asientos_contables a on (ac.id_asiento_contable_cabecera = a.id_asiento_contable_cabecera) left join plan_cuentas pc on (a.id_plan = pc.id_plan) where ((ac.fecha >= '" & txtfechaDesde.Text & "')and (ac.fecha <= '" & txtfechaHasta.Text & "'))order BY ac.id_asiento_contable_cabecera, ac.fecha, a.debito desc")

    End Sub


    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Close()
    End Sub

    Private Sub DataGridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtMotivo.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
            LFechaAsiento.Text = "Fecha Asiento: " + DataGridView1.CurrentRow.Cells.Item(6).Value
        End If

    End Sub

    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        TxtMotivo.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
        LFechaAsiento.Text = "Fecha Asiento: " + DataGridView1.CurrentRow.Cells.Item(6).Value
    End Sub
End Class