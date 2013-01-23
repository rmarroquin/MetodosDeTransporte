'*************************************************************************************************
'*Este es un programa para resolver problemas de transporte de Investigación de Operaciones ******
'*con el Método de Esquina Nor-Oeste    **********************************************************
'*************************************************************************************************
'*******Autor: Ricardo Fernando Marroquín Gramajo   **********************************************
'****** UMG Quetzaltenango Guatemala C.A.*********************************************************
'****** Coatepeque, 28 de Octubre de 2,009    ****************************************************
'*******e-mail: ferskato986@hotmail.com         **************************************************
'*******e-mail2: rmarroquin@sc.com.gt           **************************************************
'*******Colaboración: http://forums.microsoft.com/MSDN-ES con el manejo del datagridview *********
'*******              Chamorro Avendaño, Juan Marcelo - Perú con codigo de cuadros magicos *******
'*******Compartí y usa este código pero que se te olvide mencionarme gracias  ********************
'************************************good byte****************************************************
'*************************************************************************************************

Public Class frmEsquinaNorOeste
    Dim tabla(,) As Integer 'arreglo para ingresar datos a la tabla
    Dim x, y As Integer   'variables para indices de la matriz
    Dim i As Integer = 0 'contador para rotular los valores de la primer columna
    Dim j As Integer = 0 'contador para agregar filas de titulos en el dgv
    Dim k, l As Integer 'contador para agregar filas al dgv
    Dim z As Integer = 0 'valor del resultado
    Dim Oferta, Demanda As Integer ' valores para la oferta y demanda
    Dim nColumnas As Integer 'numero de columnas
    Dim nFilas As Integer ' numero de filas
    Dim num As Integer 'variables de numero a ingresar en la tabla
    Dim vmenor As Integer = 100000 'variable para capturar valor menor de oferta y demanda
    Dim vmayor As Integer ' variable que captura valor mayor de oferta y demanda
    Dim switch As Boolean = False 'variable que indica el inicio del método
    Dim cadena As String = ""



    Private Sub btnIniciar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIniciar.Click
        If Me.txtColumnas.Text = "" Or Me.txtFilas.Text = "" Then
            MsgBox("Favor ingrese un numero valido de filas o columnas", MsgBoxStyle.Critical, "Método Esquina Nor-Oeste")

        Else
            nColumnas = Val(Me.txtColumnas.Text) + 1
            nFilas = Val(Me.txtFilas.Text) + 1
            ReDim tabla(nFilas, nColumnas)
            VaciarDgv()
            Me.lstnotas.Items.Clear()

            'Agregar las columnas al datagridview

            For j = 0 To nColumnas
                If j = 0 Then
                    dgvtabla.Columns.Add(" ", " ")     'añade nuevas columnas
                Else
                    If j = nColumnas Then
                        dgvtabla.Columns.Add("OFERTA", "OFERTA")     'añade nuevas columnas
                    Else
                        dgvtabla.Columns.Add("X" + Str(j), "X" + Str(j))     'añade nuevas columnas
                    End If
                End If
            Next j

            'Agregar las Filas al datagridview
            For k = 1 To nFilas
                Me.dgvtabla.Rows.Add()      'añade nuevas filas

            Next k
            'MsgBox("Importante: La tabla principal no admite variables no numéricas", , "Restricción de mi sistema x falta de tiempo para admitirlo")
            nFilas = Val(Me.txtFilas.Text)
            nColumnas = Val(Me.txtColumnas.Text) + 1
            'llenar la matriz con los valores
            For x = 0 To nFilas
                For y = 0 To nColumnas
                    'llenar los titulos de la primera columna mientras y=0
                    If y = 0 Then
                        For i = 0 To nFilas
                            If i = nFilas Then 'si el valor de la fila es la ultima en la primer columna coloca 0
                                tabla(i, y) = 0
                            Else
                                tabla(i, y) = i + 1
                            End If
                        Next
                        y = y + 1 'pasa el foco a la primera columna para ingresar datos de y1
                    End If
                    'si la matriz se encuentra en (nfilas,ncolumas) agrega el valor 0 a la matriz
                    If x = nFilas And y = nColumnas Then
                        tabla(x, y) = 0
                    Else

                        'de lo contrario solicita el valor con el input
                        num = (InputBox("Ingrese el Valor de X" & x & "Y" & y))
                        tabla(x, y) = num 'carga el valor a la matriz en x,y

                    End If

                Next

            Next
            LlenarDgv()
            Me.lbldescripcion.Text = "Tabla Inicial"
            Me.lstnotas.Items.Add("Se agregaron los datos a la tabla inicial")
            Me.btnIniciar.Enabled = False
            Me.btnsiguiente.Enabled = True
            Me.btnNueva.Enabled = True
            Me.txtColumnas.Enabled = False
            Me.txtFilas.Enabled = False
            Me.btnsiguiente.Focus()
            switch = True
        End If
    End Sub
    Private Sub LlenarDgv() 'añadir los datos de la matriz al data grid view

        'esto es para ver si las columnas del dgv ya fueron llenads
        l = dgvtabla.Columns.Count - 1    'cuenta el numero de filas-1
        If l <= 0 Then
            j = 0
            k = 0
            'Agregar las columnas al datagridview
            For j = 0 To nColumnas
                If j = 0 Then
                    dgvtabla.Columns.Add(" ", " ")     'añade nuevas columnas
                Else
                    If j = nColumnas Then
                        dgvtabla.Columns.Add("OFERTA", "OFERTA")     'añade nuevas columnas
                    Else
                        dgvtabla.Columns.Add("X" + Str(j), "X" + Str(j))     'añade nuevas columnas
                    End If
                End If
            Next j
            'Agregar las Filas al datagridview
            For k = 1 To nFilas + 1
                Me.dgvtabla.Rows.Add()      'añade nuevas filas
            Next k

        End If
        'codigo que agrega los datos de la matriz al datagridview
        j = 0
        k = 0

        For Each row As DataGridViewRow In dgvtabla.Rows

            For Each col As DataGridViewColumn In Me.dgvtabla.Columns
                If k <= nColumnas + 1 Then
                    If j = nFilas And k = 0 Then  ' agrega DEMANDA A LA ULTIMA FILA x0y0
                        row.Cells(col.Index).Value = "DEMANDA"
                    Else

                        'en este codigo analiza el nuevo valor menor entre la oferta o demanda
                        'y lo visualiza en el dgv si el contador va en las posiciones de x, y
                        If j = x And k = y Then
                            Demanda = tabla(nFilas, y)
                            Oferta = tabla(x, nColumnas)
                            If Demanda > Oferta Then
                                vmenor = Oferta
                                vmayor = Demanda
                            Else
                                vmenor = Demanda
                                vmayor = Oferta
                            End If

                            row.Cells(col.Index).Value = Str(tabla(j, k)) & "/" & vmenor
                        Else
                            'de lo contrario coloca el valor de la matriz correspondiente
                            row.Cells(col.Index).Value = Str(tabla(j, k))
                            'If j = 1 And k = 1 Then
                            '    row.Cells(col.Index).Value = cadena
                            'End If
                        End If

                    End If
                End If
                k = k + 1
            Next
            j = j + 1
            k = 0
        Next
    End Sub
    Private Sub VaciarDgv()
        On Error GoTo err
        nColumnas = Val(Me.txtColumnas.Text) + 1

        'limpiar datos del datagridview
        i = 0
        l = 0
        l = dgvtabla.Columns.Count - 1    'cuenta el numero de filas-1
        If l >= 0 Then
            For i = 0 To nColumnas
                Select Case i
                    Case 0
                        dgvtabla.Columns.Remove(" ")    'borra las columnas anteriores
                    Case nColumnas
                        dgvtabla.Columns.Remove("OFERTA")    'borra las columnas anteriores
                    Case Else
                        dgvtabla.Columns.Remove("X" + Str(i))    'borra las columnas anteriores

                End Select
            Next i
        End If

err:


    End Sub


    Private Sub btnNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNueva.Click
        VaciarDgv()

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
        switch = False
    End Sub
    Private Sub btnsiguiente_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsiguiente.Click
        nColumnas = Val(Me.txtColumnas.Text) + 1
        nFilas = Val(Me.txtFilas.Text)


        If switch = True Then 'inicio del metodo activado inicia en X1Y1

            '***************BUSCA VALOR INICIAL MENOR ENTRE LA DEMANDA Y LA OFERTA**************************
            x = 0
            y = 1
            Demanda = tabla(nFilas, y)
            Oferta = tabla(x, nColumnas)
            If Demanda > Oferta Then
                vmenor = Oferta
                vmayor = Demanda
                z = z + (tabla(x, y) * vmenor) 'suma el valor de z
                tabla(x, nColumnas) = 0
                tabla(nFilas, y) = Math.Abs(vmayor - vmenor)

            Else
                vmenor = Demanda
                vmayor = Oferta
                z = z + (tabla(x, y) * vmenor)
                tabla(nFilas, y) = 0
                tabla(x, nColumnas) = Math.Abs(vmayor - vmenor)
            End If
            switch = False 'indica que se tiene que buscar un nuevo valor Nor-oeste

            '**************************************************************************************
            cadena = "(" & tabla(x, y) & "*" & vmenor & ")"
            buscarEsquinaNorOeste()
            VaciarDgv()
            LlenarDgv()
        Else
            vOfertaDemanda()
            buscarEsquinaNorOeste()
            VaciarDgv()
            LlenarDgv()
        End If
        Me.lblnotas.Text = "Buscar la esquina Nor-Oeste"

        Me.btnIniciar.Enabled = False
        Me.lblResultado.Text = "Sumatoria Z=" & z

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.btnIniciar.Enabled = True
        Me.btnsiguiente.Enabled = False
        Me.btnNueva.Enabled = False
        Me.txtColumnas.Text = ""
        Me.txtFilas.Text = ""
        Me.txtColumnas.Focus()

    End Sub
    Private Sub buscarEsquinaNorOeste()
        If vmenor = Oferta Then
            x = x + 1
            y = y
        Else
            If vmenor = Demanda Then
                x = x
                y = y + 1
            End If
        End If
    End Sub
    Private Sub vOfertaDemanda()
        '***************BUSCA VALOR MENOR ENTRE LA DEMANDA Y LA OFERTA**************************

        nColumnas = Val(Me.txtColumnas.Text) + 1
        nFilas = Val(Me.txtFilas.Text)

        If x <= nFilas - 1 And y <= nColumnas - 1 Then
            Demanda = tabla(nFilas, y)
            Oferta = tabla(x, nColumnas)
            If Demanda > Oferta Then
                vmenor = Oferta
                vmayor = Demanda
                z = z + (tabla(x, y) * vmenor) 'suma el valor de z
                tabla(x, nColumnas) = 0
                tabla(nFilas, y) = Math.Abs(vmayor - vmenor)

            Else
                vmenor = Demanda
                vmayor = Oferta
                z = z + (tabla(x, y) * vmenor)
                tabla(nFilas, y) = 0
                tabla(x, nColumnas) = Math.Abs(vmayor - vmenor)
            End If
            cadena = cadena & "+(" & tabla(x, y) & "*" & vmenor & ")"
            Me.lstnotas.Items.Add("Se añadió el valor menor entre la oferta(" & Oferta & ") y demanda(" & Demanda & ") al " & tabla(x, y) & " y se restó el valor añadido menor")
            VaciarDgv()
            LlenarDgv()
            Me.lstnotas.Items.Add("Cuando los valores de la oferta o demanda quedan a 0 ya no se toma encuenta la fila o columna para el siguiente paso")
            '**************************************************************************************
        Else
            MsgBox("El método ha terminado, el resultado es Z=" & cadena & " = " & z, MsgBoxStyle.Information, "Método Esquina Nor-Oeste")
            Me.lstnotas.Items.Add("El Método Esquina Nor-Oeste ha terminado La sumatoria total es Z=" & cadena & "=" & z)
            Me.btnsiguiente.Enabled = False
            Me.btnIniciar.Enabled = False
            Me.btnNueva.Enabled = True
            Me.btnNueva.Focus()

        End If


    End Sub

    Private Sub AcercaDeToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem1.Click
        ActiveForm.SendToBack()
        Dim acercade1 As New InvestigaciondeOperaciones.AcercadeEsquinaNorOeste
        acercade1.ShowDialog()
    End Sub

    
End Class
