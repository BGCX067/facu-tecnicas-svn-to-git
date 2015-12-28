Public Class Libro_Mayor

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
        Dim varaux
        Dim SaldoFinal
        Dim SaldoAnterior

        GrillaLibroMayor.Rows.Clear()

        Dt2 = sql.LEER("select ac.Id_plan , SUM(ac.debito -  ac.credito) as saldo_anterior from asientos_contables ac inner join asiento_contable_cabecera acc on (ac.Id_asiento_contable_cabecera = acc.Id_asiento_contable_cabecera) where (acc.fecha <= '" & txtfechaDesde.Text & "') group by ac.Id_plan ")

        If Dt2.Rows.Count <> 0 Then
            i = 0
            SaldoAnterior = Dt2.Rows(i).Item("saldo_anterior")
        Else
            SaldoAnterior = 0
        End If


        Dt = sql.LEER(ConsultaSQL)

        If Dt.Rows.Count <> 0 Then
            varaux = Dt.Rows(0).Item("id_plan")
        End If


        For x = 0 To Dt.Rows.Count - 1

            If varaux <> Dt.Rows(x).Item("id_plan") Then

                GrillaLibroMayor.Rows.Add(1)
                Y = GrillaLibroMayor.Rows.Count - 2
                GrillaLibroMayor.Item(0, Y).Value = "-----"
                GrillaLibroMayor.Item(1, Y).Value = "-----"
                GrillaLibroMayor.Item(2, Y).Value = "-----"
                GrillaLibroMayor.Item(3, Y).Value = "-----"
                GrillaLibroMayor.Item(4, Y).Value = "-----"
                GrillaLibroMayor.Item(5, Y).Value = "-----"
                GrillaLibroMayor.Item(6, Y).Value = "-----"
                GrillaLibroMayor.Item(7, Y).Value = "-----"

                'GrillaLibroMayor.Item(7, Y - 1).Value = coma_punto(Format(SaldoFinal, "#,###,###,##0.00"))
                SaldoFinal = 0


                If Dt2.Rows.Count <> 0 Then
                    i = 0
                    SaldoAnterior = Dt2.Rows(i + 1).Item("saldo_anterior")
                Else
                    SaldoAnterior = 0
                End If

            End If


            GrillaLibroMayor.Rows.Add(1)
            Y = GrillaLibroMayor.Rows.Count - 2
            GrillaLibroMayor.Item(0, Y).Value = Dt.Rows(x).Item("id_plan")
            GrillaLibroMayor.Item(1, Y).Value = Dt.Rows(x).Item("descripcion")
            GrillaLibroMayor.Item(2, Y).Value = Dt.Rows(x).Item("Id_asiento_contable_cabecera")
            GrillaLibroMayor.Item(3, Y).Value = Format(Dt.Rows(x).Item("fecha"), "dd/MM/yyyy")

            GrillaLibroMayor.Item(4, Y).Value = coma_punto(Format(SaldoAnterior, "#,###,###,##0.00"))

            If Dt.Rows(x).Item("debito") <> 0 Then
                GrillaLibroMayor.Item(5, Y).Value = coma_punto(Format(Val(Dt.Rows(x).Item("debito")), "#,###,###,##0.00"))
                SaldoFinal = SaldoAnterior + Val(Dt.Rows(x).Item("debito"))
                SaldoAnterior = SaldoFinal
            Else
                GrillaLibroMayor.Item(5, Y).Value = ""
            End If

            If Dt.Rows(x).Item("credito") <> 0 Then
                GrillaLibroMayor.Item(6, Y).Value = coma_punto(Format(Val(Dt.Rows(x).Item("credito")), "#,###,###,##0.00"))
                SaldoFinal = SaldoAnterior - Val(Dt.Rows(x).Item("credito"))
                SaldoAnterior = SaldoFinal
            Else
                GrillaLibroMayor.Item(6, Y).Value = ""
            End If

            GrillaLibroMayor.Item(7, Y).Value = coma_punto(Format(SaldoFinal, "#,###,###,##0.00"))
            varaux = Dt.Rows(x).Item("id_plan")
        Next

        GrillaLibroMayor.Item(7, Y).Value = coma_punto(Format(SaldoFinal, "#,###,###,##0.00"))
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
            CargarGrillaLibroMayor("select pc.id_plan, pc.descripcion, acc.Id_asiento_contable_cabecera, acc.fecha, ac.debito, ac.credito from asientos_contables ac inner join asiento_contable_cabecera acc on (ac.Id_asiento_contable_cabecera = acc.Id_asiento_contable_cabecera) inner join plan_cuentas pc on (ac.id_plan = pc.id_plan) where (acc.fecha >= '" & txtfechaDesde.Text & "') and (acc.fecha <= '" & txtfechaHasta.Text & "') order by pc.descripcion, ac.debito desc, ac.credito desc, acc.fecha asc")
        Else
            CargarGrillaLibroMayor("select pc.id_plan, pc.descripcion, acc.Id_asiento_contable_cabecera, acc.fecha, ac.debito, ac.credito from asientos_contables ac inner join asiento_contable_cabecera acc on (ac.Id_asiento_contable_cabecera = acc.Id_asiento_contable_cabecera) inner join plan_cuentas pc on (ac.id_plan = pc.id_plan) where ((acc.fecha >= '" & txtfechaDesde.Text & "') and (acc.fecha <= '" & txtfechaHasta.Text & "')) and (ac.id_plan = '" & CBoxCuentas.Items(CBoxCuentas.SelectedIndex).itemdata() & "') order by pc.descripcion, ac.debito desc, ac.credito desc, acc.fecha asc")
        End If

    End Sub

    Private Sub btsalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btsalir.Click
        Me.Close()
    End Sub


    Private Sub Libro_Mayor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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