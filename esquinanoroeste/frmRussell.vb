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

Public Class frmRussell

    Dim vmayor1 As Integer 'obtiene el valor menor de columna o fila
    Dim vmayor2 As Integer 'obtiene el valor menor de columna o fila
    Dim vmayor As Integer ' se utiliza en la funcion oferta y demanda
    Dim vmenor As Integer ' almacena el valor menor de la columna Z de la matriz Cij
    Dim vpivote As Integer 'da el valor del pibote de la matriz
    Dim vpivote2 As Integer 'da el valor del pibote de la matriz
    Dim vmenor3 As Integer ' se utiliza en la funcion ofertademanda
    Dim resmayor As Integer 'resultado de la resta de los numeros menores de la matriz oferta y demanda
    Dim x, y, x2, y2 As Integer 'coordenadas para las matrices
    Dim coordX, coordY As Integer 'variables que almacenan la coordenada del valor menor de las matrices secundarias (pivote)
    Dim num As Integer 
    Dim numenor As Integer
    Dim zij As Integer
    Dim uvmenor As Integer
    Dim demanda As Integer
    Dim oferta As Integer
    Dim i, j, k, l As Integer 'contadores
    Dim tabla(,) As Integer 'tabla principal matriz n*n
    Dim tablaUj(,) As Integer 'tabla secundaria matriz n*n demanda denominada Uj
    Dim tablaVj(,) As Integer 'tabla tercera matriz n*n oferta denominada Vj
    Dim tablasecundaria(,) As Integer
    Dim tablaFinalizar(,) As Integer
    Dim tablaCij(,) As Integer
    Dim nfilas As Integer 'numero de filas total de la matriz
    Dim nfilasCij As Integer 'numero de filas de la matriz Cij
    Dim ncolumnas As Integer 'numero de columnas total de la matriz con la columna de oferta
    Dim cadena As String
    Dim z, s, colCij As Integer

    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        VaciarDgv()
        VaciarDgvdemandaUj()
        VaciarDgvOfertaVj()
        VaciarDgvCij()
        s = 0
        Me.txtColumnas.Enabled = True
        Me.txtFilas.Enabled = True
        Me.txtColumnas.Text = ""
        Me.txtFilas.Text = ""
        Me.lbldescripcion.Text = ""
        Me.lblnotas.Items.Clear()
        Me.lblResultado.Text = ""
        Me.txtColumnas.Focus()
        Me.btnsiguiente.Enabled = False
        Me.btnIniciar.Enabled = True
        Me.btnNueva.Enabled = False
    End Sub
    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        If Me.txtColumnas.Text = "" Or Not IsNumeric(Me.txtColumnas.Text) Or Me.txtFilas.Text = "" Or Not IsNumeric(Me.txtFilas.Text) Then
            MsgBox("Favor ingrese un numero valido de filas o columnas", MsgBoxStyle.Critical, "Método de Russell")

        Else
            ncolumnas = Val(Me.txtColumnas.Text) + 1
            nfilas = Val(Me.txtFilas.Text) + 1
            ReDim tabla(nfilas, ncolumnas)
            ReDim tablasecundaria(nfilas, ncolumnas) 'arreglo para anular datos ya operados
            ReDim tablaFinalizar(nfilas, ncolumnas) 'arreglo para anular datos ya operados
            ReDim tablaVj(nfilas - 1, 0) 'arreglo para la fila Vj (oferta)
            ReDim tablaUj(0, ncolumnas - 1) 'arreglo para la fila Uj (demanda)
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
                        tablaFinalizar(x, y) = num 'carga el valor a la matriz secundaria en x,y
                    End If

                Next

            Next
            LlenarDgv()
            Me.lblnotas.Items.Clear()
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

    Private Sub vmayorUj() 'funcion para obtener los valores menores de la columna de la matriz principal
        nfilas = Val(Me.txtFilas.Text)
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        vmayor1 = 0
        coordX = 0
        coordY = 0
        For y = 1 To ncolumnas - 1
            For x = 0 To nfilas - 1
                'valor mayor de la tabla
                If tablasecundaria(x, y) > vmayor1 And tablasecundaria(x, y) > 0 Then
                    vmayor1 = tablasecundaria(x, y)
                    coordX = x
                    coordY = y
                End If
            Next
            resmayor = vmayor1 'valor mayor de Uj
            tablaUj(0, y) = resmayor 'agrega la resultante a la primera fila de la tabla Uj
            If x = nfilas Then
                vmayor1 = 0
                tablasecundaria(coordX, coordY) = 0
            End If
        Next

    End Sub
    Private Sub vmayorVj()
        nfilas = Val(Me.txtFilas.Text)
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        vmayor2 = 0
        coordX = 0
        coordY = 0
        For x = 0 To nfilas - 1
            For y = 1 To ncolumnas - 1
                'primer valor mayor de la tabla
                If tablasecundaria(x, y) > vmayor2 And tablasecundaria(x, y) > 0 Then
                    vmayor2 = tablasecundaria(x, y)
                    coordX = x
                    coordY = y
                End If
            Next
            resmayor = vmayor2 'resultado de restar los 2 valores menores
            tablaVj(x, 0) = resmayor 'agrega la resultante a la primera fila de la tabla demanda
            If y = ncolumnas Then
                vmayor2 = 0
                tablasecundaria(coordX, coordY) = 0
            End If
        Next
    End Sub
    Private Sub MatrizCij()
        nfilas = Val(Me.txtFilas.Text)
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        nfilasCij = 0
        vmenor = 0
        vpivote = 0
        colCij = 0

        'CUENTA EL NUMERO DE FILAS QUE TENDRÁ LA MATRIZ CIJ LO ALMACENA EN NFILASCIJ
        For y = 1 To ncolumnas - 1
            For x = 0 To nfilas - 1
                If tablasecundaria(x, y) > 0 Then
                    nfilasCij = nfilasCij + 1
                End If
            Next
        Next

        If nfilasCij > 0 Then

            'redimenciona el array Cij con la cantidad de filas necesarias y 5 columnas
            ReDim tablaCij(nfilasCij - 1, 4) 'arreglo para la tabla Cij
            'agrega el correlativo numerico de la primer columna
            For x = 0 To nfilasCij - 1
                tablaCij(x, 0) = x + 1
            Next
            For y = 1 To ncolumnas - 1
                For x = 0 To nfilas - 1
                    If tablasecundaria(x, y) > 0 Then
                        coordX = x
                        coordY = y
                        colCij = colCij + 1
                        AgregarCij()
                    End If
                Next
            Next

            'ENCONTRAR EL VALOR MENOR DEL RESULTADO DE LA FORMULA Z=Cij-Uij-Vij
            'tambien almacena el valor del pivote en la variable vpivote
            For x = 0 To nfilasCij - 1
                If tablaCij(x, 4) < vmenor Then
                    vmenor = tablaCij(x, 4)
                    vpivote = tablaCij(x, 1)
                End If
            Next
            'ENCUENTRA LAS COORDENADAS DEL PIVOTE PARA VER LA DEMANDA Y OFERTA
            For y = 1 To ncolumnas - 1
                For x = 0 To nfilas - 1
                    If tablasecundaria(x, y) = vpivote Then
                        coordX = x
                        coordY = y
                    End If
                Next
            Next
            x = coordX 'devuelve las coordenadas de X a las variables correspondientes
            y = coordY 'devuelve las coordenadas de Y a las variables correspondientes

        Else
            TerminarRussell()

        End If
    End Sub

    Private Sub AgregarCij()
        tablaCij(colCij - 1, 1) = tablasecundaria(coordX, coordY)
        tablaCij(colCij - 1, 2) = tablaUj(0, coordY)
        tablaCij(colCij - 1, 3) = tablaVj(coordX, 0)
        zij = (tablaCij(colCij - 1, 1)) - (tablaCij(colCij - 1, 2)) - (tablaCij(colCij - 1, 3))
        tablaCij(colCij - 1, 4) = zij
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
            tablaFinalizar(nfilas, y) = Math.Abs(vmayor - vmenor3)
            vpivote2 = tabla(x, y)
            coordX = x
            coordY = y
            For j = 0 To nfilas - 1
                tablasecundaria(x, j) = 0
                tablaFinalizar(x, y) = 0
            Next
            s = 0

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
                tablaFinalizar(x, ncolumnas) = 0
                TerminarRussell()
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
                tablaFinalizar(x, ncolumnas) = Math.Abs(vmayor - vmenor3)
                vpivote2 = tabla(x, y)
                coordX = x
                coordY = y
                For j = 0 To ncolumnas - 1
                    tablasecundaria(j, y) = 0
                    tablaFinalizar(j, y) = 0
                Next
                s = 0
            End If

        End If
        cadena = cadena & "(" & tabla(x, y) & "*" & vmenor3 & ")+"
        Me.lblnotas.Items.Add("Se añadió el valor menor entre la oferta(" & oferta & ") y demanda(" & demanda & ") al " & tabla(x, y) & " y se restó el valor añadido menor")

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
    End Sub
    Private Sub LlenarDgvdemandaUj() 'añadir los datos de la matriz al data grid view      
        'esto es para ver si las columnas del dgv ya fueron llenads
        ncolumnas = Val(Me.txtColumnas.Text)
        l = dgvdemandaUj.Columns.Count - 1    'cuenta el numero de filas-1
        If l <= 0 Then
            j = 0
            k = 0
            'Agregar las columnas al datagridview
            For j = 0 To ncolumnas
                If j = 0 Then
                    dgvdemandaUj.Columns.Add(" ", " ")     'añade nuevas columnas
                Else
                    dgvdemandaUj.Columns.Add("Uj" + Str(j), "Uj" + Str(j))     'añade nuevas columnas
                End If
            Next j
            'Agregar las Filas al datagridview

            Me.dgvdemandaUj.Rows.Add()      'añade nuevas filas

        End If
        'codigo que agrega los datos de la matriz al datagridview
        j = 0
        k = 0

        For Each row As DataGridViewRow In dgvdemandaUj.Rows

            For Each col As DataGridViewColumn In Me.dgvdemandaUj.Columns
                If k <= ncolumnas Then
                    If k = 0 Then
                        row.Cells(col.Index).Value = Str(tabla(j, k))
                    Else
                        row.Cells(col.Index).Value = Str(tablaUj(j, k))
                    End If
                End If
                k = k + 1
            Next
            j = j + 1
            k = 0
        Next

    End Sub
    Private Sub LlenarDgvOfertaVj() 'añadir los datos de la matriz al data grid view
        nfilas = Val(Me.txtFilas.Text) - 1
        ncolumnas = Val(Me.txtColumnas.Text) + 2

        'esto es para ver si las columnas del dgv ya fueron llenads
        l = dgvofertaVj.Columns.Count - 1    'cuenta el numero de filas-1
        If l <= 0 Then
            j = 0
            k = 0
            'Agregar las columnas al datagridview

            dgvofertaVj.Columns.Add("Vj", "Vj")     'añade nuevas columnas

            'Agregar las Filas al datagridview
            For k = 1 To nfilas + 1
                Me.dgvofertaVj.Rows.Add()      'añade nuevas filas
            Next k

        End If
        'codigo que agrega los datos de la matriz al datagridview
        j = 0
        k = 0

        For Each row As DataGridViewRow In dgvofertaVj.Rows

            For Each col As DataGridViewColumn In Me.dgvofertaVj.Columns
                If k <= 1 Then
                    row.Cells(col.Index).Value = Str(tablaVj(j, k))
                End If
                k = k + 1
            Next
            j = j + 1
            k = 0
        Next
    End Sub
    Private Sub LlenarDgvCij() 'añadir los datos de la matriz al data grid view
        'esto es para ver si las columnas del dgv ya fueron llenads
        l = dgvCij.Columns.Count - 1    'cuenta el numero de filas-1
        If l <= 0 Then
            j = 0
            k = 0
            'Agregar las columnas al datagridview
            For j = 0 To 4
                Select Case j
                    Case 0
                        dgvCij.Columns.Add("No.", "No.")     'añade nuevas columnas
                    Case 1
                        dgvCij.Columns.Add("Cij" + Str(j), "Cij" + Str(j)) 'añade nuevas columnas
                    Case 2
                        dgvCij.Columns.Add("Uij" + Str(j), "Uij" + Str(j))     'añade nuevas columnas
                    Case 3
                        dgvCij.Columns.Add("Vij" + Str(j), "Vij" + Str(j))     'añade nuevas columnas
                    Case 4
                        dgvCij.Columns.Add("Zij" + Str(j), "Zij" + Str(j))     'añade nuevas columnas
                End Select
            Next j
            'Agregar las Filas al datagridview
            For k = 0 To nfilasCij - 1
                Me.dgvCij.Rows.Add()      'añade nuevas filas
            Next k

        End If
        'codigo que agrega los datos de la matriz al datagridview
        j = 0
        k = 0

        For Each row As DataGridViewRow In dgvCij.Rows

            For Each col As DataGridViewColumn In Me.dgvCij.Columns
                If k <= 4 Then
                    row.Cells(col.Index).Value = Str(tablaCij(j, k))
                End If
                k = k + 1
            Next
            j = j + 1
            k = 0
        Next
    End Sub
    Private Sub VaciarDgvCij()
        On Error GoTo err
        'limpiar datos del datagridview
        i = 0
        l = 0
        l = dgvCij.Columns.Count - 1    'cuenta el numero de filas-1
        If l >= 0 Then
            For i = 0 To 4
                Select Case i
                    Case 0
                        dgvCij.Columns.Remove("No.")    'borra las columnas anteriores
                    Case 1
                        dgvCij.Columns.Remove("Cij" + Str(i))    'borra las columnas anteriores
                    Case 2
                        dgvCij.Columns.Remove("Uij" + Str(i))    'borra las columnas anteriores
                    Case 3
                        dgvCij.Columns.Remove("Vij" + Str(i))    'borra las columnas anteriores
                    Case 4
                        dgvCij.Columns.Remove("Zij" + Str(i))    'borra las columnas anteriores
                End Select
            Next i
        End If

err:

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
    Private Sub VaciarDgvdemandaUj()
        On Error GoTo err
        ncolumnas = Val(Me.txtColumnas.Text)
        'ncolumnas = Val(Me.txtColumnas.Text) + 1

        'limpiar datos del datagridview
        i = 0
        l = 0
        l = dgvdemandaUj.Columns.Count - 1    'cuenta el numero de filas-1
        If l >= 0 Then
            For i = 0 To ncolumnas
                If i = 0 Then
                    dgvdemandaUj.Columns.Remove(" ")    'borra las columnas anteriores
                Else
                    dgvdemandaUj.Columns.Remove("Uj" + Str(i))    'borra las columnas anteriores
                End If
            Next i
        End If

err:

    End Sub
    Private Sub VaciarDgvOfertaVj()
        On Error GoTo err
        ncolumnas = Val(Me.txtColumnas.Text) + 2

        'limpiar datos del datagridview
        i = 0
        l = 0
        l = dgvofertaVj.Columns.Count - 1    'cuenta el numero de filas-1
        If l >= 0 Then
            dgvofertaVj.Columns.Remove("Vj")    'borra las columnas anteriores

        End If

err:

    End Sub
  
    Private Sub btnsiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        nfilas = Val(Me.txtFilas.Text)


        Select Case s
            Case 0
                vmayorUj()
                vmayorVj()
                VaciarDgvdemandaUj()
                VaciarDgvOfertaVj()
                LlenarDgvdemandaUj()
                LlenarDgvOfertaVj()
                Me.lblnotas.Items.Add("Se agregaron los valores mayores de filas y columnas en la matriz Vj y Uj respectivamente")
            Case 1
                Me.lblnotas.Items.Clear()
                MatrizCij()
                VaciarDgvCij()
                LlenarDgvCij()
                Me.lblnotas.Items.Add("Se tomaron los valores de la matriz Cij")
                Me.lblnotas.Items.Add("El valor menor de la matriz Cij es: " & vmenor)
                Me.lblnotas.Items.Add("El valor correspondiente de Cij de la tabla principal es: " & vpivote)
            Case 2
                vOfertaDemanda()
                VaciarDgv()
                LlenarDgv()
                Me.lblnotas.Items.Add("Cuando los valores de la oferta o demanda quedan a 0 ya no se toma encuenta la fila o columna para el siguiente paso")
                Me.lblResultado.Text = "Sumatoria Z=" & cadena
        End Select
        s = s + 1
        Me.tslresultado.Text = "Z=" & cadena & "=" & z


    End Sub
    Private Sub TerminarRussell()
        nfilas = Val(Me.txtFilas.Text)
        ncolumnas = Val(Me.txtColumnas.Text) + 1
        vmayor1 = 0
        x = coordX
        y = coordY
        tablaFinalizar(x, y) = 0

        For j = 0 To nfilas - 1
            If tablaFinalizar(j, y) > vmayor1 And tablaFinalizar(j, y) > 0 Then
                vmayor1 = tablaFinalizar(j, y)
                coordX = j
                coordY = y
            End If
        Next
        If vmayor1 = 0 Then
            Me.btnIniciar.Enabled = False
            Me.lblResultado.Text = "Sumatoria Z=" & cadena
            MsgBox("El método ha terminado, el resultado es Z=" & cadena & " = " & z, MsgBoxStyle.Information, "Método de Russell")
            Me.lblnotas.Items.Add("El método de Russell ha terminado la sumatoria es Z=" & z)
            Me.btnsiguiente.Enabled = False
            Me.btnIniciar.Enabled = False
            Me.btnNueva.Enabled = True
            Me.btnNueva.Focus()
        Else
            x = coordX
            y = coordY
            vOfertaDemanda2()
            VaciarDgv()
            LlenarDgv()
            Me.lblnotas.Items.Add("Se tomaron los valores restantes")
            Me.lblnotas.Items.Add("El valor menor de la matriz inicial es: " & vmayor1)

        End If

    End Sub
    Private Sub vOfertaDemanda2()
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
            tablaFinalizar(x, y) = 0
            tabla(x, ncolumnas) = 0
            tablasecundaria(x, ncolumnas) = 0
            tabla(nfilas, y) = Math.Abs(vmayor - vmenor3)
            tablasecundaria(nfilas, y) = Math.Abs(vmayor - vmenor3)
            coordX = x
            coordY = y
            s = 0
        Else
            If demanda = oferta Then
                vmenor3 = oferta
                vmayor = demanda
                uvmenor = vmenor3
                z = z + (tabla(x, y) * vmenor3)
                tablasecundaria(x, y) = 0
                tablaFinalizar(x, y) = 0
                tabla(nfilas, y) = 0
                tabla(x, ncolumnas) = 0
                tablasecundaria(nfilas, y) = 0
                tablasecundaria(x, ncolumnas) = 0
                TerminarRussell()
            Else
                vmenor3 = demanda
                vmayor = oferta
                uvmenor = vmenor3
                z = z + (tabla(x, y) * vmenor3)
                tablasecundaria(x, y) = 0
                tablaFinalizar(x, y) = 0
                tabla(nfilas, y) = 0
                tablasecundaria(nfilas, y) = 0
                tabla(x, ncolumnas) = Math.Abs(vmayor - vmenor3)
                tablasecundaria(x, ncolumnas) = Math.Abs(vmayor - vmenor3)
                coordX = x
                coordY = y
                s = 0
            End If

        End If
        cadena = cadena & "(" & tabla(x, y) & "*" & vmenor3 & ")+"
        Me.lblnotas.Items.Add("Se añadió el valor menor entre la oferta(" & oferta & ") y demanda(" & demanda & ") al " & tabla(x, y) & " y se restó el valor añadido menor")

    End Sub

    Private Sub frmRussell_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnIniciar.Enabled = True
        Me.btnsiguiente.Enabled = False
        Me.btnNueva.Enabled = False
        Me.txtColumnas.Text = ""
        Me.txtFilas.Text = ""
        Me.txtColumnas.Focus()
    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        Dim acercarussell As New AcercadeRussell
        acercarussell.ShowDialog()
    End Sub

End Class