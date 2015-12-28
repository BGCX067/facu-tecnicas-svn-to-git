Public Class Libro_Mayor_Resumen

    Dim Dt As System.Data.DataTable
    Dim Dt2 As System.Data.DataTable
    Dim sql As New MySQL

    'CARGAR EL COMBO
    Private Sub Cargar_combo(ByVal Combo As System.Object, ByVal Texto As String, ByVal Clave As String)
        Combo.Items.Add(New MiComboBox(Texto, Clave))
    End Sub

    Private Sub CargarGrillaLibroMayor(ByVal ConsultaSQL As String)
        Dim Y
        Dim x
        Dim i
        Dim SaldoFinal
        Dim SaldoAnterior

        GrillaLibroMayor.Rows.Clear()

        Dt2 = sql.LEER("select ac.Id_plan , SUM(ac.debito -  ac.credito) as saldo_anterior from asientos_contables ac inner join asiento_contable_cabecera acc on (ac.Id_asiento_contable_cabecera = acc.Id_asiento_contable_cabecera) where (acc.fecha <= '" & txtfechaDesde.Text & "') group by ac.Id_plan ")

        Dt = sql.LEER(ConsultaSQL)


        For x = 0 To Dt.Rows.Count - 1

            If Dt2.Rows.Count <> 0 Then
                SaldoAnterior = Dt2.Rows(x).Item("saldo_anterior")
            Else
                SaldoAnterior = 0
            End If

            GrillaLibroMayor.Rows.Add(1)
            Y = GrillaLibroMayor.Rows.Count - 2
            GrillaLibroMayor.Item(0, Y).Value = Dt.Rows(x).Item("id_plan")
            GrillaLibroMayor.Item(1, Y).Value = Dt.Rows(x).Item("descripcion")

            GrillaLibroMayor.Item(2, Y).Value = coma_punto(Format(SaldoAnterior, "#,###,###,##0.00"))

            If Dt.Rows(x).Item("debito") <> 0 Then
                GrillaLibroMayor.Item(3, Y).Value = coma_punto(Format(Val(Dt.Rows(x).Item("debito")), "#,###,###,##0.00"))
                SaldoFinal = SaldoAnterior + Val(Dt.Rows(x).Item("debito"))
                SaldoAnterior = SaldoFinal
            Else
                GrillaLibroMayor.Item(3, Y).Value = ""
            End If

            If Dt.Rows(x).Item("credito") <> 0 Then
                GrillaLibroMayor.Item(4, Y).Value = coma_punto(Format(Val(Dt.Rows(x).Item("credito")), "#,###,###,##0.00"))
                SaldoFinal = SaldoAnterior - Val(Dt.Rows(x).Item("credito"))
                SaldoAnterior = SaldoFinal
            Else
                GrillaLibroMayor.Item(4, Y).Value = ""
            End If

            GrillaLibroMayor.Item(5, Y).Value = coma_punto(Format(SaldoFinal, "#,###,###,##0.00"))
            SaldoFinal = 0
        Next
    End Sub

    Private Sub btBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btBuscar.Click
        Dim fechaD As Date 'variables Fecha para controlar que no carguen una fecha vacia
        Dim fechaH As Date

        Try
            fechaD = txtfechaDesde.Text
            fechaH = txtfechaHasta.Text
        Catch ex As Exception
            MsgBox("Las Fechas se encuentran mal cargadas. VERIFIQUE")
            Exit Sub
        End Try

        If CBoxCuentas.Text = "" Then
            CargarGrillaLibroMayor("select pc.id_plan, pc.descripcion, sum(ac.debito) as debito, sum(ac.credito) as credito from asientos_contables ac inner join asiento_contable_cabecera acc on (ac.Id_asiento_contable_cabecera = acc.Id_asiento_contable_cabecera) inner join plan_cuentas pc on (ac.id_plan = pc.id_plan) where (acc.fecha >= '" & txtfechaDesde.Text & "') and (acc.fecha <= '" & txtfechaHasta.Text & "') group by pc.id_plan ,pc.descripcion")
        Else
            CargarGrillaLibroMayor("select pc.id_plan, pc.descripcion, sum(ac.debito) as debito, sum(ac.credito) as credito from asientos_contables ac inner join asiento_contable_cabecera acc on (ac.Id_asiento_contable_cabecera = acc.Id_asiento_contable_cabecera) inner join plan_cuentas pc on (ac.id_plan = pc.id_plan) where (acc.fecha >= '" & txtfechaDesde.Text & "') and (acc.fecha <= '" & txtfechaHasta.Text & "') and (ac.id_plan = '" & CBoxCuentas.Items(CBoxCuentas.SelectedIndex).itemdata() & "') group by pc.id_plan ,pc.descripcion")
        End If
    End Sub

    Private Sub btsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub

    Private Sub Libro_Mayor_Resumen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dt = sql.LEER("SELECT pc.Id_Plan, pc.clave_contable, pc.descripcion FROM plan_cuentas pc WHERE (pc.baja = 'N') and (pc.imputable = 'S')")

        For i As Integer = 0 To Dt.Rows.Count - 1
            If Dt.Rows.Count = 0 Then
                MsgBox("NO HAY REGISTROS PARA CONSULTAR")
                Exit Sub
            Else
                Cargar_combo(CBoxCuentas, Dt.Rows(i).Item("Descripcion").ToString(), Dt.Rows(i).Item("Id_Plan").ToString())
            End If
        Next i

        txtfechaHasta.Text = Format(Now, "yyyy/MM/dd")
        txtfechaDesde.Text = Format(Now, "yyyy")
        txtfechaDesde.Focus()

    End Sub
End Class