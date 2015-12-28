Public Class Imprime_PlanCuentas

    Dim s As New Impresion()
    Public sql As New MySQL
    Dim Contador As Integer = 0
    Dim total As Integer
    Dim Ch As Integer = 0
    Dim Dt, Dt1 As System.Data.DataTable


    Private Sub ImprimeDocumento()
        Dim niv As Integer
        For a As Integer = 1 To 67
            If Contador < Dt1.Rows.Count Then
                s.X = 120
                s.ImprimirTab(Dt1.Rows(Contador).Item("id_Plan").ToString, True)
                If Val(Mid(Dt1.Rows(Contador).Item("Clave_Contable").ToString(), 1, 1)) > 0 Then
                    s.ResetCols()
                    s.X = 170
                    niv = 1
                End If
                If Val(Mid(Dt1.Rows(Contador).Item("Clave_Contable").ToString(), 3, 2)) > 0 Then
                    s.ResetCols()
                    s.X = 180
                    niv = 2
                End If
                If Val(Mid(Dt1.Rows(Contador).Item("Clave_Contable").ToString(), 6, 3)) > 0 Then
                    s.ResetCols()
                    s.X = 190
                    niv = 3
                End If
                If Val(Mid(Dt1.Rows(Contador).Item("Clave_Contable").ToString(), 10, 3)) > 0 Then
                    s.ResetCols()
                    s.X = 200
                    niv = 4
                End If
                If Val(Mid(Dt1.Rows(Contador).Item("Clave_Contable").ToString(), 14, 3)) > 0 Then
                    s.ResetCols()
                    s.X = 210
                    niv = 5
                End If

                Select Case niv
                    Case 1
                        Dt = sql.LEER("select * from plan_cuentas where left(Clave_Contable,1) = left('" & Dt1.Rows(Contador).Item("clave_contable") & "',1) and mid(clave_contable,3,2) > '00' and mid(clave_contable,6,3) > '000' and mid(clave_contable,10,3) > '000' and mid(clave_contable,14,3) > '000' ")
                        Sumador()
                    Case 2
                        Dt = sql.LEER("select * from plan_cuentas where left(Clave_Contable,5) = left('" & Dt1.Rows(Contador).Item("clave_contable") & "',5) and mid(clave_contable,6,3) > '000' and mid(clave_contable,10,3) > '000' and mid(clave_contable,14,3) > '000' ")
                        Sumador()
                    Case 3
                        Dt = sql.LEER("select * from plan_cuentas where left(Clave_Contable,9) = left('" & Dt1.Rows(Contador).Item("clave_contable") & "',9) and mid(clave_contable,10,3) > '000' and mid(clave_contable,14,3) > '000' ")
                        Sumador()
                    Case 4
                        Dt = sql.LEER("select * from plan_cuentas where left(Clave_Contable,13) = left('" & Dt1.Rows(Contador).Item("clave_contable") & "',13) and mid(clave_contable,14,3) > '000' ")
                        Sumador()
                    Case 5
                        Dt = sql.LEER("select * from plan_cuentas where left(Clave_Contable,16) = left('" & Dt1.Rows(Contador).Item("clave_contable") & "',16) ")
                        Sumador()
                End Select
                s.Fuente("Arial", 8, FontStyle.Regular)
                s.DefCol(50, ContentAlignment.MiddleLeft)
                s.DefCol(300, ContentAlignment.MiddleLeft)
                s.DefCol(150, ContentAlignment.MiddleLeft)
                s.DefCol(200, ContentAlignment.MiddleLeft)
                s.ImprimirTab(Dt1.Rows(Contador).Item("Descripcion").ToString(), True)
                s.ImprimirTab(total)
                Contador += 1
                total = 0
            End If
        Next
        s.MasDatos = Contador < Dt1.Rows.Count
    End Sub

    Private Sub Titulos()
        Ch += 1
        s.Fuente("Arial", 8, FontStyle.Regular)
        s.Y = 30
        s.X = 670
        s.Imprimir("Hoja: " & Format(Ch, "00"))
        s.Fuente("Arial", 12, FontStyle.Bold)
        s.Y = 30
        s.X = 120
        's.Marco = True
        s.Imprimir("Empresa XX SA")
        's.Marco = False

        s.Fuente("Arial", 14, FontStyle.Bold)
        s.X = 250
        s.Y = 80
        s.Imprimir("Listado del Plan de Cuentas")

        s.Fuente("Arial", 14, FontStyle.Regular)
        s.X = 250
        s.Imprimir("De Fecha: " & Format(Now, "dd/MM/yyyy"))

        s.Imprimir("")
        s.Fuente("Arial", 6, FontStyle.Bold)
        s.X = 120
        s.Y = 160
        s.LineaL(1)
        s.ResetCols()
        s.DefCol(50, ContentAlignment.MiddleLeft)
        s.DefCol(300, ContentAlignment.MiddleLeft)
        s.DefCol(150, ContentAlignment.MiddleLeft)
        s.DefCol(200, ContentAlignment.MiddleLeft)
        s.ImprimirTab("Id.", "Clave Contable", "Descripción", "Aj.Inflación")
        s.LineaL(1)
        s.Y = 200
    End Sub

    Private Sub btImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtImprimir.Click
        Dt1 = sql.LEER("SELECT * FROM plan_cuentas ORDER BY Clave_Contable")
        If Dt1.Rows.Count = 0 Then
            MsgBox("NO HAY REGISTROS")
            Exit Sub
        End If
        'Llamado a la impresion
        Ch = 0
        Contador = 0
        AddHandler s.InicioImpresion, AddressOf InicioListado
        AddHandler s.Titulos, AddressOf Titulos
        AddHandler s.Cuerpo, AddressOf ImprimeDocumento
        s.GenerarReporte(False, "A4")
        RemoveHandler s.Cuerpo, AddressOf ImprimeDocumento
        RemoveHandler s.Titulos, AddressOf Titulos
        RemoveHandler s.InicioImpresion, AddressOf InicioListado
        Me.Cursor = Cursors.Default
        Me.Close()
    End Sub

    Private Sub InicioListado()
        Ch = 0
        Contador = 0
    End Sub

    Public Sub Sumador()
        'Dim Df As System.Data.DataTable
        'For y = 0 To Dt1.Rows.Count - 1
        'Df = sql.LEER("Select * from asientos_contables WHERE Id_Plan = '" & Dt.Rows(y).Item("Id_Plan") & "' ORDER BY Id_plan ")
        'If Df.Rows.Count = 0 Then
        'Else
        '    For x = 0 To Df.Rows.Count - 1
        '        If Df.Rows(x).Item("Debe_Haber").ToString = "D" Then
        '            total = total + Df.Rows(x).Item("Monto_Asiento")
        '        Else
        '            total = total - Df.Rows(x).Item("Monto_Asiento")
        '        End If
        '    Next x
        'End If
        'Next y
    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtSalir.Click
        Me.Close()
    End Sub
End Class
