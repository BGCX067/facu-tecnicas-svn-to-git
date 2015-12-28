Public Class Consulta_Asientos_Contables
    Dim Dt As System.Data.DataTable
    Dim sql As New MySQL

    Private Sub CargarGrilla(ByVal Consulta As String)
        Dim TotalDebito
        Dim TotalCredito
        Dim varaux
        Dim i

        TotalDebito = 0
        TotalCredito = 0

        Dt = sql.LEER(Consulta)

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

            lblDatos.Text = "Total Debe:   $" + TotalDebito.ToString + "   Total Haber:   $" + TotalCredito.ToString + "   Diferencia DEBE/HABER:   $" + (TotalDebito - TotalCredito).ToString

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

        If CboxTipoBuscar.Text = "Fecha de Asiento" Then

            If (txtFechadesde.Text = "    /  /") Or (txtfechahasta.Text = "    /  /") Then
                MsgBox("Debe ingresar Fecha Desde y Fecha Hasta. VERIFIQUE")
                txtFechadesde.Focus()
                Exit Sub
            End If

            CargarGrilla("select ac.id_asiento_contable_cabecera ,ac.motivo, ac.fecha , pc.clave_contable,a.debito, a.credito, pc.descripcion as cuenta from asiento_contable_cabecera ac left join asientos_contables a on (ac.id_asiento_contable_cabecera = a.id_asiento_contable_cabecera) left join plan_cuentas pc on (a.id_plan = pc.id_plan) where ((ac.fecha >= '" & txtFechadesde.Text & "')and (ac.fecha <= '" & txtfechahasta.Text & "'))order BY ac.id_asiento_contable_cabecera, ac.fecha, a.debito desc")
        Else
            If CboxTipoBuscar.Text = "Nro. de Asiento" Then

                If (txtnroAsiento.Text = "") Then
                    MsgBox("Debe un nro de asiento. VERIFIQUE")
                    txtFechadesde.Focus()
                    Exit Sub
                End If

                CargarGrilla("select ac.id_asiento_contable_cabecera ,ac.motivo, ac.fecha , pc.clave_contable,a.debito, a.credito, pc.descripcion as cuenta from asiento_contable_cabecera ac left join asientos_contables a on (ac.id_asiento_contable_cabecera = a.id_asiento_contable_cabecera) left join plan_cuentas pc on (a.id_plan = pc.id_plan) where (ac.id_asiento_contable_cabecera = '" & txtnroAsiento.Text & "')order BY ac.id_asiento_contable_cabecera, ac.fecha, a.debito desc")
            End If
        End If

    End Sub


    Private Sub Consulta_asientos_Contables_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarGrilla("select ac.id_asiento_contable_cabecera ,ac.motivo, ac.fecha , pc.clave_contable,a.debito, a.credito, pc.descripcion as cuenta from asiento_contable_cabecera ac left join asientos_contables a on (ac.id_asiento_contable_cabecera = a.id_asiento_contable_cabecera) left join plan_cuentas pc on (a.id_plan = pc.id_plan) where ((ac.fecha >= '1900/01/01')and (ac.fecha <= '3000/01/01'))order BY ac.id_asiento_contable_cabecera, ac.fecha, a.debito desc")
    End Sub


    Private Sub BtnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub


    Private Sub DataGridView1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        TxtMotivo.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
        LFechaAsiento.Text = "Fecha Asiento: " + DataGridView1.CurrentRow.Cells.Item(6).Value
    End Sub

    Private Sub btContra_asiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btContra_asiento.Click
        Dim Motivo
        Dim Debito
        Dim Credito
        Dim id_asiento_contable_cabecera
        Dim Id_asiento_old
        Dim Id_plan
        Dim Fecha
        Dim response As MsgBoxResult

        Fecha = Format(Now, "yyyy/MM/dd")

        response = MsgBox("Esta seguro de Realizar un Contrasiento", MsgBoxStyle.YesNo)
        If response = MsgBoxResult.Yes Then

            Id_asiento_old = DataGridView1.CurrentRow.Cells.Item(0).Value

            Dt = sql.LEER("select ac.id_asiento_contable_cabecera ,ac.motivo, ac.fecha , pc.clave_contable, a.id_plan,a.debito, a.credito, pc.descripcion as cuenta from asiento_contable_cabecera ac left join asientos_contables a on (ac.id_asiento_contable_cabecera = a.id_asiento_contable_cabecera) left join plan_cuentas pc on (a.id_plan = pc.id_plan) where (ac.id_asiento_contable_cabecera = '" & Id_asiento_old & "' )order BY ac.id_asiento_contable_cabecera, ac.fecha, a.debito desc")

            Motivo = "Por Contrasiento Nro: " + Id_asiento_old + " de la fecha: " + Dt.Rows(0).Item("Fecha").ToString()

            sql.INSERT_UPDATE_DELETE("Insert into asiento_contable_cabecera(fecha, motivo) values('" & Fecha & "' ,'" & Motivo & "')")

            Dt = sql.LEER("SELECT acc.Id_asiento_contable_cabecera FROM asiento_contable_cabecera acc order by acc.Id_asiento_contable_cabecera desc")
            id_asiento_contable_cabecera = Dt.Rows(0).Item("Id_asiento_contable_cabecera").ToString()

            Dt = sql.LEER("select ac.id_asiento_contable_cabecera ,ac.motivo, ac.fecha , pc.clave_contable, a.id_plan,a.debito, a.credito, pc.descripcion as cuenta from asiento_contable_cabecera ac left join asientos_contables a on (ac.id_asiento_contable_cabecera = a.id_asiento_contable_cabecera) left join plan_cuentas pc on (a.id_plan = pc.id_plan) where (ac.id_asiento_contable_cabecera = '" & Id_asiento_old & "' )order BY ac.id_asiento_contable_cabecera, ac.fecha, a.debito desc")

            For i As Integer = 0 To Dt.Rows.Count - 1
                Id_plan = Dt.Rows(i).Item("id_plan").ToString()

                If Val(Dt.Rows(i).Item("debito").ToString()) = 0 Then
                    Credito = 0
                Else
                    Credito = Dt.Rows(i).Item("debito").ToString()
                End If

                If Val(Dt.Rows(i).Item("credito").ToString()) = 0 Then
                    Debito = 0
                Else
                    Debito = Dt.Rows(i).Item("credito").ToString()
                End If

                sql.INSERT_UPDATE_DELETE("Insert into asientos_contables(id_plan, debito, credito, id_asiento_contable_cabecera) values('" & Id_plan & "','" & Debito & "', '" & Credito & "', '" & id_asiento_contable_cabecera & "')")
            Next

            MsgBox("El contrasiento se guardo con exito!")
            DataGridView1.Rows.Clear()
            CargarGrilla("select ac.id_asiento_contable_cabecera ,ac.motivo, ac.fecha , pc.clave_contable,a.debito, a.credito, pc.descripcion as cuenta from asiento_contable_cabecera ac left join asientos_contables a on (ac.id_asiento_contable_cabecera = a.id_asiento_contable_cabecera) left join plan_cuentas pc on (a.id_plan = pc.id_plan) where ((ac.fecha >= '1900/01/01')and (ac.fecha <= '3000/01/01'))order BY ac.id_asiento_contable_cabecera, ac.fecha, a.debito desc")
        End If

    End Sub

    Private Sub btborrarFiltros_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btborrarFiltros.Click
        DataGridView1.Rows.Clear()
        CargarGrilla("select ac.id_asiento_contable_cabecera ,ac.motivo, ac.fecha , pc.clave_contable,a.debito, a.credito, pc.descripcion as cuenta from asiento_contable_cabecera ac left join asientos_contables a on (ac.id_asiento_contable_cabecera = a.id_asiento_contable_cabecera) left join plan_cuentas pc on (a.id_plan = pc.id_plan) where ((ac.fecha >= '1900/01/01')and (ac.fecha <= '3000/01/01'))order BY ac.id_asiento_contable_cabecera, ac.fecha, a.debito desc")
    End Sub

    Private Sub DataGridView1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DataGridView1.KeyPress
        If e.KeyChar = Chr(13) Then
            TxtMotivo.Text = DataGridView1.CurrentRow.Cells.Item(5).Value
            LFechaAsiento.Text = "Fecha Asiento: " + DataGridView1.CurrentRow.Cells.Item(6).Value
        End If

    End Sub

End Class