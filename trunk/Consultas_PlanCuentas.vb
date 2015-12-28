Imports MySql.Data.MySqlClient

Public Class Consultas_PlanCuentas

    Private Sub Consultas_PlanCuentas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sql As New MySQL
        Dim Dt1
        DGView_Consulta.Rows.Clear()

        Dt1 = sql.LEER("SELECT id_plan, Clave_Contable, Descripcion, Imputable FROM plan_cuentas ORDER BY Clave_Contable")
        If Dt1.Rows.Count = 0 Then
            MsgBox("NO HAY REGISTROS PARA CONSULTAR")
            Exit Sub
        Else
            For i As Integer = 0 To Dt1.Rows.Count - 1
                DGView_Consulta.Rows.Add(1)
                DGView_Consulta.Item(0, i).Value = Dt1.Rows(i).Item("id_Plan")
                DGView_Consulta.Item(1, i).Value = Dt1.Rows(i).Item("Clave_Contable")
                DGView_Consulta.Item(2, i).Value = Dt1.Rows(i).Item("Descripcion")
                If Dt1.Rows(i).Item("Imputable") = "N" Then
                    DGView_Consulta.Rows(i).DefaultCellStyle.BackColor = TxtReferencia.BackColor
                    'Color.Beige


                End If
            Next
        End If

    End Sub
End Class