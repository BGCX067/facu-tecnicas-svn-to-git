Module Utilidades
    Public Function coma_punto(ByVal numero As String) As String
        For i As Integer = 1 To numero.Length
            If Mid(numero, i, 1) = "," Then
                Mid(numero, i, 1) = "."
            Else
                If Mid(numero, i, 1) = "." Then
                    Mid(numero, i, 1) = ","
                End If
            End If
        Next
        coma_punto = numero
    End Function

    Public Function InList(ByVal Valor As Object, ByVal ParamArray Lista() As Object) As Boolean
        Dim a As Integer
        InList = False
        For a = 0 To UBound(Lista)
            If Valor = Lista(A) Then
                InList = True
                Exit Function
            End If
        Next a
    End Function
End Module
