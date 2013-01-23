'*************************************************************************************************
'*Este es un programa para resolver problemas de transporte de Investigación de Operaciones ******
'*con el Método de Voguel         ****************************************************************
'*************************************************************************************************
'*******Autor: Ricardo Fernando Marroquín Gramajo   **********************************************
'****** UMG Quetzaltenango Guatemala C.A.*********************************************************
'****** Coatepeque, 03 de Noviembre de 2,009    **************************************************
'*******e-mail: ferskato986@hotmail.com         **************************************************
'*******e-mail2: rmarroquin@sc.com.gt           **************************************************
'*******Colaboración: http://forums.microsoft.com/MSDN-ES con el manejo del datagridview *********
'*******              Chamorro Avendaño, Juan Marcelo - Perú con codigo de cuadros magicos *******
'*******Compartí y usa este código pero que se te olvide mencionarme gracias  ********************
'************************************good byte****************************************************
'*************************************************************************************************

Public Class frmVoguel

    Dim vmayor1 As Integer 'obtiene el valor menor de columna o fila
    Dim vmayor2 As Integer ' obtiene el segundo valor menor de la fila o columna
    Dim vmayor As Integer ' se utiliza en la funcion oferta y demanda
    Dim vmayordem, vmayorofe As Integer  'obtiene el valor menor de la matriz pivote oferta o demanda
    Dim vmenor As Integer ' almacena el valor menor de la fila o columna pivote
    Dim vmenor1 As Integer ' obtiene el segundo valor menor de la fila o columna
    Dim vmenor2 As Integer ' obtiene el segundo valor menor de la fila o columna
    Dim vmenor3 As Integer ' se utiliza en la funcion ofertademanda
    Dim resmenor As Integer 'resultado de la resta de los numeros menores de la matriz oferta y demanda
    Dim x, y, x2, y2 As Integer 'coordenadas para las matrices
    Dim coordX, coordY As Integer 'variables que almacenan la coordenada del valor menor de las matrices secundarias (pivote)
    Dim num As Integer
    Dim numenor As Integer
    Dim uvmenor As Integer
    Dim demanda As Integer
    Dim oferta As Integer
    Dim s As Integer = 0 'contador de procemiento de busqueda
    Dim i, j, k, l As Integer 'contadores
    Dim tabla(,) As Integer 'tabla principal matriz n*n
    Dim tabladem(,) As Integer 'tabla secundaria matriz n*n demanda
    Dim tablaofe(,) As Integer 'tabla tercera matriz n*n oferta
    Dim tablasecundaria(,) As Integer
    Dim nfilas As Integer 'numero de filas total de la matriz
    Dim ncolumnas As Integer 'numero de columnas total de la matriz con la columna de oferta
    Dim hacer As Boolean
    Dim cadena As String
    Dim z As Integer
    Dim nsuma1, nsuma2 As Integer
    Dim switch As Boolean 'variable para eliminar error de pivote inicial menor
    Private Sub vmenorcoldemanda() 'funcion para obtener los valores menores de la columna de la matriz principal
        nfilas = Val(Me.txtFilas.Text)
        ncolumnas = Val(Me.txtColumnas.Text) + 1

        For y = 1 To ncolumnas - 1
            If tabla(nfilas, y) = 0 Then 'si el valor de la demanda es 0 agrega 0 a la tabla demanda
                tabladem(s, y) = 0
            Else
                vmenor1 = tablasecundaria(0, y)
                If vmenor1 = 0 Then
                    vmenor1 = 1000
                End If
                vmenor2 = vmenor1
                For x = 0 To nfilas - 1
                    'primer valor menor de la tabla
                    If tablasecundaria(x, y) < vmenor1 And tablasecundaria(x, y) > 0 Then
                        vmenor1 = tablasecundaria(x, y)
                    End If
                Next
                If vmenor2 = vmenor1 Then
                    vmenor2 = 1000
                    For x = 0 To nfilas - 1
                        ' segundo valor menor de la tabla
                        If tablasecundaria(x, y) > vmenor1 And tablasecundaria(x, y) < vmenor2 Then
                            vmenor2 = tablasecundaria(x, y)
                        End If
                    Next
                Else
                    For x = 0 To nfilas - 1
                        ' segundo valor menor de la tabla
                        If tablasecundaria(x, y) > vmenor1 And tablasecundaria(x, y) < vmenor2 Then
                            vmenor2 = tablasecundaria(x, y)
                        End If
                    Next
                End If

                resmenor = Math.Abs(vmenor1 - vmenor2) 'resultado de restar los 2 valores menores
                tabladem(s, y) = resmenor 'agrega la resultante a la primera fila de la tabla demanda
            End If
        Next
    End Sub
    Private Sub vmenorfiloferta()
        nfilas = Val(Me.txtFilas.Text)
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        vmenor1 = 0
        vmenor2 = 0


        For x = 0 To nfilas - 1
            If tabla(x, ncolumnas) = 0 Then 'si el valor de la oferta es 0 agrega 0 a la tabla demanda
                tablaofe(x, s) = 0
            Else
                vmenor1 = tablasecundaria(x, 1)
                If vmenor1 = 0 Then
                    vmenor1 = 1000
                End If
                vmenor2 = vmenor1
                For y = 1 To ncolumnas - 1
                    'primer valor menor de la tabla
                    If tablasecundaria(x, y) < vmenor1 And tablasecundaria(x, y) > 0 Then
                        vmenor1 = tablasecundaria(x, y)
                    End If
                Next
                If vmenor2 = vmenor1 Then
                    vmenor2 = 1000
                    For y = 1 To ncolumnas - 1
                        ' segundo valor menor de la tabla
                        If tablasecundaria(x, y) > vmenor1 And tablasecundaria(x, y) < vmenor2 Then
                            vmenor2 = tablasecundaria(x, y)
                        End If
                    Next
                Else
                    For y = 1 To ncolumnas - 1
                        ' segundo valor menor de la tabla
                        If tablasecundaria(x, y) > vmenor1 And tablasecundaria(x, y) < vmenor2 Then
                            vmenor2 = tablasecundaria(x, y)
                        End If
                    Next
                End If

                resmenor = Math.Abs(vmenor1 - vmenor2) 'resultado de restar los 2 valores menores
                tablaofe(x, s) = resmenor 'agrega la resultante a la primera fila de la tabla demanda
            End If
        Next
    End Sub
    Private Sub vmayormatriz() ' funcion para encontrar los valores mayores de las filas en la matriz principal
        '       If hacer = True Then ' si hacer es verdadero indica que debe hacer la funcion presente
        nfilas = Val(Me.txtFilas.Text)
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        vmayor1 = 0
        vmayor2 = 0

        'reconoce el valor mayor de la fila de la matriz demanda
        vmayor1 = tabladem(s, 1)
        coordY = 1
        coordX = s
        hacer = False
        For y = 1 To ncolumnas - 1
            If tabladem(s, y) > vmayor1 Then
                vmayordem = tabladem(s, y)
                vmayor1 = vmayordem
                coordY = y 'toma la coordenada de y para trabajar la matriz principal
                coordX = s
                hacer = False 'si hacer es falso el valor menor cae en una columna
            End If
        Next

        'reconoce el valor menor de la columna de la matriz oferta
        vmayor2 = vmayor1
        For x = 0 To nfilas - 1
            If tablaofe(x, s) > vmayor2 Then
                vmayorofe = tablaofe(x, s)
                vmayor2 = vmayorofe
                coordX = x ' toma la coordenada de X para trabajar la matriz principal
                coordY = s + 1
                If coordY > ncolumnas Then
                    coordY = coordY - 1
                End If
                hacer = True 'si hacer es verdadero el valor menor cae en una fila
            End If
        Next
        Me.lblnotas.Items.Add("De los datos obtenidos, el mayor es:" & vmayor2)
    End Sub
    Private Sub vmenorpivote()
        'If hacer = True Then ' si hacer es verdadero indica que debe hacer la funcion presente
        nfilas = Val(Me.txtFilas.Text)
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        x = coordX
        y = coordY
        j = 0
        k = 0
        If hacer = True Then 'si el caso de x=0 es porque el pivote cayó en fila k contador que identifica X
            If tablasecundaria(nfilas, 1) = 0 Then
                vmenor = 10000
                coordX = x
                coordY = 1
            Else
                vmenor = tablasecundaria(x, 1)
                coordX = x
                coordY = 1
            End If


            If vmenor = 0 Then 'si el valor del pivote inicial es 0 no lo tomara encuenta por lo que se le valua como 1000 para encontrar un valor menor
                vmenor = 10000
            End If
            For k = 1 To ncolumnas - 1
                If tabla(nfilas, k) = 0 Then
                    tablasecundaria(x, k) = 0
                    If tablasecundaria(x, k) < vmenor And tablasecundaria(x, k) > 0 Then
                        vmenor = tablasecundaria(x, k)
                        coordX = x 'obtiene la coordenada de x de la fila pivote con el valor menor encontrado
                        coordY = k 'obtiene la coordenada de x de la fila pivote con el valor menor encontrado
                    End If
                Else
                    If tablasecundaria(x, k) < vmenor And tablasecundaria(x, k) > 0 Then
                        vmenor = tablasecundaria(x, k)
                        coordX = x 'obtiene la coordenada de x de la fila pivote con el valor menor encontrado
                        coordY = k 'obtiene la coordenada de x de la fila pivote con el valor menor encontrado
                    End If
                End If
            Next
        Else
            'en otro caso si x<>0 es porque el pivote cayó en columna k contador que identifica Y
            If tablasecundaria(0, ncolumnas) = 0 Then
                vmenor = 1000
                coordX = 0
                coordY = y
            Else
                vmenor = tablasecundaria(0, y)
                coordX = 0 'al estar en 0 el valor inicial debe de dar las coordenadas del pivote en la tabla principal
                coordY = y
            End If
            
            If vmenor = 0 Then 'si el valor del pivote inicial es 0 no lo tomara encuenta por lo que se le valua como 1000 para encontrar un valor menor
                vmenor = 10000
            End If
            For j = 0 To nfilas - 1
                If tabla(j, ncolumnas) = 0 Then
                    tablasecundaria(j, y) = 0
                    If tablasecundaria(j, y) < vmenor And tablasecundaria(j, y) > 0 Then
                        vmenor = tablasecundaria(j, y)
                        coordX = j 'obtiene la coordenada de x de la columna pivote con el valor menor encontrado
                        coordY = y 'obtiene la coordenada de Y de la columna pivote con el valor menor encontrado
                    End If
                Else
                    If tablasecundaria(j, y) < vmenor And tablasecundaria(j, y) > 0 Then
                        vmenor = tablasecundaria(j, y)
                        coordX = j 'obtiene la coordenada de x de la columna pivote con el valor menor encontrado
                        coordY = y 'obtiene la coordenada de Y de la columna pivote con el valor menor encontrado
                    End If
                End If

            Next
        End If
        x = coordX
        y = coordY
        Select Case hacer
            Case True
                Me.lblnotas.Items.Add("Del valor mayor de la matriz que cayo en fila el valor menor de la matriz inicial es:" & tabla(x, y))
            Case False
                Me.lblnotas.Items.Add("Del valor mayor de la matriz que cayo en columna el valor menor de la matriz inicial es:" & tabla(x, y))
        End Select
        vOfertaDemanda()
    End Sub
    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        If Me.txtColumnas.Text = "" Or Me.txtFilas.Text = "" Then
            MsgBox("Favor ingrese un numero valido de filas o columnas", MsgBoxStyle.Critical, "Método de Voguel")

        Else
            ncolumnas = Val(Me.txtColumnas.Text) + 1
            nfilas = Val(Me.txtFilas.Text) + 1
            ReDim tabla(nfilas, ncolumnas)
            ReDim tablasecundaria(nfilas, ncolumnas)
            ReDim tablaofe(nfilas - 1, ncolumnas + 1)
            ReDim tabladem(nfilas + 2, ncolumnas - 1)
            VaciarDgv()

            'Agregar las columnas al datagridview
            j = 0
            k = 0

            For j = 0 To ncolumnas
                If j = 0 Then
                    dgvtabla.Columns.Add(" ", " ")     'añade nuevas columnas
                Else
                    If j = ncolumnas Then
                        dgvtabla.Columns.Add("OFERTA", "OFERTA")     'añade nuevas columnas
                    Else
                        dgvtabla.Columns.Add("X" + Str(j), "X" + Str(j))     'añade nuevas columnas
                    End If
                End If
            Next j

            'Agregar las Filas al datagridview
            For k = 1 To nfilas
                Me.dgvtabla.Rows.Add()      'añade nuevas filas
            Next k
            MsgBox("Importante: La tabla principal no admite variables no numéricas", , "Restricción de mi sistema x falta de tiempo para admitirlo")
            nfilas = Val(Me.txtFilas.Text)
            ncolumnas = Val(Me.txtColumnas.Text) + 1
            'llenar la matriz con los valores
            For x = 0 To nfilas
                For y = 0 To ncolumnas
                    'llenar los titulos de la primera columna mientras y=0
                    If y = 0 Then
                        For i = 0 To nfilas
                            If i = nfilas Then 'si el valor de la fila es la ultima en la primer columna coloca 0
                                tabla(i, y) = 0
                                tablasecundaria(i, y) = 0
                            Else
                                tabla(i, y) = i + 1
                                tablasecundaria(i, y) = i + 1
                            End If
                        Next
                        y = y + 1 'pasa el foco a la primera columna para ingresar datos de y1
                    End If
                    'si la matriz se encuentra en (nfilas,ncolumas) agrega el valor 0 a la matriz
                    If x = nfilas And y = ncolumnas Then
                        tabla(x, y) = 0
                        tablasecundaria(x, y) = 0
                    Else
                        'de lo contrario solicita el valor con el input
                        num = Val(InputBox("Ingrese el Valor de X " & x & "  Y " & y))
                        tabla(x, y) = num 'carga el valor a la matriz en x,y
                        tablasecundaria(x, y) = num 'carga el valor a la matriz secundaria en x,y
                    End If

                Next

            Next
            LlenarDgv()
            Me.lbldescripcion.Text = "Tabla Inicial"
            Me.lblnotas.Items.Add("Se agregaron los datos a la tabla inicial")
            Me.btnIniciar.Enabled = False
            Me.btnsiguiente.Enabled = True
            Me.btnNueva.Enabled = True
            Me.txtColumnas.Enabled = False
            Me.txtFilas.Enabled = False
            Me.btnsiguiente.Focus()

        End If
        s = 0
    End Sub
    Private Sub LlenarDgv() 'añadir los datos de la matriz al data grid view
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        nfilas = Val(Me.txtFilas.Text)
        'esto es para ver si las columnas del dgv ya fueron llenads
        l = dgvtabla.Columns.Count - 1    'cuenta el numero de filas-1
        If l <= 0 Then
            j = 0
            k = 0
            'Agregar las columnas al datagridview
            For j = 0 To ncolumnas
                If j = 0 Then
                    dgvtabla.Columns.Add(" ", " ")     'añade nuevas columnas
                Else
                    If j = ncolumnas Then
                        dgvtabla.Columns.Add("OFERTA", "OFERTA")     'añade nuevas columnas
                    Else
                        dgvtabla.Columns.Add("X" + Str(j), "X" + Str(j))     'añade nuevas columnas
                    End If
                End If
            Next j
            'Agregar las Filas al datagridview
            For k = 1 To nfilas + 1
                Me.dgvtabla.Rows.Add()      'añade nuevas filas
            Next k

        End If
        'codigo que agrega los datos de la matriz al datagridview
        j = 0
        k = 0

        For Each row As DataGridViewRow In dgvtabla.Rows

            For Each col As DataGridViewColumn In Me.dgvtabla.Columns
                If k <= ncolumnas Then
                    If j = nfilas And k = 0 Then  ' agrega DEMANDA A LA ULTIMA FILA x0y0
                        row.Cells(col.Index).Value = "DEMANDA"
                    Else
                        If j = x And k = y Then
                            row.Cells(col.Index).Value = Str(tabla(j, k)) & "/" & uvmenor
                        Else
                            row.Cells(col.Index).Value = Str(tabla(j, k))
                        End If
                    End If
                End If
                k = k + 1
            Next
            j = j + 1
            k = 0
        Next
        'LlenarDgvdemanda()
    End Sub

    Private Sub LlenarDgvdemanda() 'añadir los datos de la matriz al data grid view
        nfilas = Val(Me.txtFilas.Text) + 2
        ncolumnas = Val(Me.txtColumnas.Text)

        'esto es para ver si las columnas del dgv ya fueron llenads
        l = dgvdemanda.Columns.Count - 1    'cuenta el numero de filas-1
        If l <= 0 Then
            j = 0
            k = 0
            'Agregar las columnas al datagridview
            For j = 0 To ncolumnas
                If j = 0 Then
                    dgvdemanda.Columns.Add(" ", " ")     'añade nuevas columnas
                Else
                    dgvdemanda.Columns.Add("X" + Str(j), "X" + Str(j))     'añade nuevas columnas
                End If
            Next j
            'Agregar las Filas al datagridview
            For k = 1 To nfilas
                Me.dgvdemanda.Rows.Add()      'añade nuevas filas
            Next k

        End If
        'codigo que agrega los datos de la matriz al datagridview
        j = 0
        k = 0

        For Each row As DataGridViewRow In dgvdemanda.Rows

            For Each col As DataGridViewColumn In Me.dgvdemanda.Columns
                If k <= ncolumnas Then
                    If k = 0 Then
                        row.Cells(col.Index).Value = Str(tabla(j, k))
                    Else
                        row.Cells(col.Index).Value = Str(tabladem(j, k))
                    End If
                End If
                k = k + 1
            Next
            j = j + 1
            k = 0
        Next
        'LlenarDgvOferta()
    End Sub
    Private Sub LlenarDgvOferta() 'añadir los datos de la matriz al data grid view
        nfilas = Val(Me.txtFilas.Text) - 1
        ncolumnas = Val(Me.txtColumnas.Text) + 2

        'esto es para ver si las columnas del dgv ya fueron llenads
        l = dgvoferta.Columns.Count - 1    'cuenta el numero de filas-1
        If l <= 0 Then
            j = 0
            k = 0
            'Agregar las columnas al datagridview
            For j = 0 To ncolumnas
                dgvoferta.Columns.Add("X" + Str(j), "X" + Str(j))     'añade nuevas columnas
            Next j
            'Agregar las Filas al datagridview
            For k = 1 To nfilas + 1
                Me.dgvoferta.Rows.Add()      'añade nuevas filas
            Next k

        End If
        'codigo que agrega los datos de la matriz al datagridview
        j = 0
        k = 0

        For Each row As DataGridViewRow In dgvoferta.Rows

            For Each col As DataGridViewColumn In Me.dgvoferta.Columns
                If k <= ncolumnas Then
                    row.Cells(col.Index).Value = Str(tablaofe(j, k))
                End If
                k = k + 1
            Next
            j = j + 1
            k = 0
        Next
    End Sub

    Private Sub VaciarDgv()
        On Error GoTo err
        ncolumnas = Val(Me.txtColumnas.Text) + 1

        'limpiar datos del datagridview
        i = 0
        l = 0
        l = dgvtabla.Columns.Count - 1    'cuenta el numero de filas-1
        If l >= 0 Then
            For i = 0 To ncolumnas
                Select Case i
                    Case 0
                        dgvtabla.Columns.Remove(" ")    'borra las columnas anteriores
                    Case ncolumnas
                        dgvtabla.Columns.Remove("OFERTA")    'borra las columnas anteriores
                    Case Else
                        dgvtabla.Columns.Remove("X" + Str(i))    'borra las columnas anteriores

                End Select
            Next i
        End If
        'VaciarDgvdemanda()
err:

    End Sub
    Private Sub VaciarDgvdemanda()
        On Error GoTo err
        ncolumnas = Val(Me.txtColumnas.Text)
        'ncolumnas = Val(Me.txtColumnas.Text) + 1

        'limpiar datos del datagridview
        i = 0
        l = 0
        l = dgvdemanda.Columns.Count - 1    'cuenta el numero de filas-1
        If l >= 0 Then
            For i = 0 To ncolumnas
                If i = 0 Then
                    dgvdemanda.Columns.Remove(" ")    'borra las columnas anteriores
                Else
                    dgvdemanda.Columns.Remove("X" + Str(i))    'borra las columnas anteriores
                End If
            Next i
        End If
        'VaciarDgvOferta()
err:

    End Sub
    Private Sub VaciarDgvOferta()
        On Error GoTo err
        ncolumnas = Val(Me.txtColumnas.Text) + 2

        'limpiar datos del datagridview
        i = 0
        l = 0
        l = dgvoferta.Columns.Count - 1    'cuenta el numero de filas-1
        If l >= 0 Then
            For i = 0 To ncolumnas
                dgvoferta.Columns.Remove("X" + Str(i))    'borra las columnas anteriores
            Next i
        End If

err:

    End Sub

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        VaciarDgv()
        VaciarDgvdemanda()
        VaciarDgvOferta()

        Me.txtColumnas.Enabled = True
        Me.txtFilas.Enabled = True
        Me.txtColumnas.Text = ""
        Me.txtFilas.Text = ""
        Me.lbldescripcion.Text = ""
        Me.lblnotas.Text = ""
        Me.lblResultado.Text = ""
        Me.txtColumnas.Focus()
        Me.btnsiguiente.Enabled = False
        Me.btnIniciar.Enabled = True
        Me.btnNueva.Enabled = False
    End Sub
    Private Sub btnsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        nfilas = Val(Me.txtFilas.Text)
        Me.lblnotas.Items.Clear()
        i = 0
        j = 0
        nsuma1 = 0
        nsuma2 = 0
        For i = 0 To ncolumnas - 1
            nsuma1 = nsuma1 + tabla(nfilas, i)
        Next
        For j = 0 To nfilas - 1
            nsuma2 = nsuma2 + tabla(j, ncolumnas)
        Next
        If s > nfilas + 2 Then
            TerminarVoguel()
        End If
        If nsuma1 = 0 And nsuma2 = 0 Or (nsuma1 > 0 And nsuma2 = 0) Then
            'x = 0
            'y = 0
            TerminarVoguel()
        Else

            vmenorcoldemanda()
            vmenorfiloferta()
            Me.lblnotas.Items.Add("Se restaron los 2 valores menores de filas y columnas en la matriz")
            vmayormatriz()
            vmenorpivote()
            VaciarDgv()
            VaciarDgvdemanda()
            VaciarDgvOferta()
            LlenarDgv()
            LlenarDgvdemanda()
            LlenarDgvOferta()
            Me.lblnotas.Items.Add("Cuando los valores de la oferta o demanda quedan a 0 ya no se toma encuenta la fila o columna para el siguiente paso")
            Me.lblResultado.Text = "Sumatoria Z=" & cadena
            Me.tslresultado.Text = "Z=" & z
            s = s + 1
        End If

    End Sub
    Private Sub TerminarVoguel()
        Me.btnIniciar.Enabled = False
        Me.lblResultado.Text = "Sumatoria Z=" & cadena
        MsgBox("El método ha terminado, el resultado es Z=" & cadena & " = " & z, MsgBoxStyle.Information, "Método de Voguel")
        Me.lblnotas.Items.Add("El Método de voguel ha terminado la sumatoria es Z=" & z)
        Me.btnsiguiente.Enabled = False
        Me.btnIniciar.Enabled = False
        Me.btnNueva.Enabled = True
        Me.btnNueva.Focus()
    End Sub
    Private Sub vOfertaDemanda()
        '***************BUSCA VALOR MENOR ENTRE LA DEMANDA Y LA OFERTA**************************
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        nfilas = Val(Me.txtFilas.Text)

        demanda = tablasecundaria(nfilas, y)
        oferta = tablasecundaria(x, ncolumnas)

        If demanda > oferta Then
            vmenor3 = oferta
            vmayor = demanda
            uvmenor = vmenor3
            z = z + (tabla(x, y) * vmenor3) 'suma el valor de z
            tablasecundaria(x, y) = 0
            tabla(x, ncolumnas) = 0
            tablasecundaria(x, ncolumnas) = 0
            tabla(nfilas, y) = Math.Abs(vmayor - vmenor3)
            tablasecundaria(nfilas, y) = Math.Abs(vmayor - vmenor3)

        Else
            If demanda = oferta Then
                vmenor3 = oferta
                vmayor = demanda
                uvmenor = vmenor3
                z = z + (tabla(x, y) * vmenor3)
                tablasecundaria(x, y) = 0
                tabla(nfilas, y) = 0
                tabla(x, ncolumnas) = 0
                tablasecundaria(nfilas, y) = 0
                tablasecundaria(x, ncolumnas) = 0
            Else
                vmenor3 = demanda
                vmayor = oferta
                uvmenor = vmenor3
                z = z + (tabla(x, y) * vmenor3)
                tablasecundaria(x, y) = 0
                tabla(nfilas, y) = 0
                tablasecundaria(nfilas, y) = 0
                tabla(x, ncolumnas) = Math.Abs(vmayor - vmenor3)
                tablasecundaria(x, ncolumnas) = Math.Abs(vmayor - vmenor3)
            End If

        End If
        cadena = cadena & "+(" & tabla(x, y) & "*" & vmenor3 & ")"
        Me.lblnotas.Items.Add("Se añadió el valor menor entre la oferta(" & oferta & ") y demanda(" & demanda & ") al " & tabla(x, y) & " y se restó el valor añadido menor")

    End Sub

    Private Sub frmVoguel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnIniciar.Enabled = True
        Me.btnsiguiente.Enabled = False
        Me.btnNueva.Enabled = False
        Me.txtColumnas.Text = ""
        Me.txtFilas.Text = ""
        Me.txtColumnas.Focus()
    End Sub
    Private Sub AcercaDeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        ActiveForm.SendToBack()
        Dim voguel As New AcercadeVoguel
        voguel.ShowDialog()
    End Sub
End Class