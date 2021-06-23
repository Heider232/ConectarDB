Imports System.Data.SqlClient
Public Class Form1
    '===================================================CONEXION====================================================

    Dim Conexion = New SqlConnection("Data Source=LAPTOP-BP7IHP5Q\SQLEXPRESS;Initial Catalog=Personal;Persist Security Info=True;User ID=sa;Password=Alnoisa$2021")
    '======================================================================================================================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarDatos()
    End Sub
    '======================================INSERTAR DATOS================================================
    Public Function InsertarDatos(Nombre As String, Apellido As String, Identificacion As String) As Boolean

        Dim DatosPersona As New DataSet()
        Try
            Dim Commando As New SqlCommand("SPInsertarPersona", Conexion)
            Commando.CommandType = CommandType.StoredProcedure
            Commando.Parameters.Add(New SqlParameter("@nombre", Nombre))
            Commando.Parameters.Add(New SqlParameter("@apellido", Apellido))
            Commando.Parameters.Add(New SqlParameter("@identificacion", Identificacion))
            Dim Adaptador As New SqlDataAdapter()
            Conexion.Open()
            Adaptador.SelectCommand = Commando
            Adaptador.Fill(DatosPersona)
            Conexion.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
    '======================================ACTUALIZAR DATOS================================================
    Public Function ActualizarDatos(ID As Integer, Nombre As String, Apellido As String, Identificacion As String) As Boolean

        Dim DatosPersona As New DataSet()
        Try
            Dim Commando As New SqlCommand("SPActualizarPersona", Conexion)
            Commando.CommandType = CommandType.StoredProcedure
            Commando.Parameters.Add(New SqlParameter("@ID", ID))
            Commando.Parameters.Add(New SqlParameter("@nombre", Nombre))
            Commando.Parameters.Add(New SqlParameter("@apellido", Apellido))
            Commando.Parameters.Add(New SqlParameter("@identificacion", Identificacion))
            Dim Adaptador As New SqlDataAdapter()
            Conexion.Open()
            Adaptador.SelectCommand = Commando
            Adaptador.Fill(DatosPersona)
            Conexion.Close()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    '====================================== SELECCIONAR DATOS================================================
    Public Function SelectDatosDB() As DataSet
        Dim DatosPersona As New DataSet()
        Try
            Dim Commando As New SqlCommand("SPSelectPersonas", Conexion)
            Commando.CommandType = CommandType.StoredProcedure
            Dim Adaptador As New SqlDataAdapter()
            Conexion.Open()
            Adaptador.SelectCommand = Commando
            Adaptador.Fill(DatosPersona)
            Conexion.Close()

            Return DatosPersona

        Catch ex As Exception
            Return DatosPersona
        End Try
    End Function
    '======================================SELECT X ID DATOS================================================
    Public Function SelectDatosPersona(Id As Integer) As DataSet
        Dim DatosPersona As New DataSet()
        Try
            Dim Commando As New SqlCommand("SPSelectPersonaXID", Conexion)
            Commando.CommandType = CommandType.StoredProcedure
            Commando.Parameters.Add(New SqlParameter("@ID", Id))
            Dim Adaptador As New SqlDataAdapter()
            Conexion.Open()
            Adaptador.SelectCommand = Commando
            Adaptador.Fill(DatosPersona)
            Conexion.Close()

            Return DatosPersona

        Catch ex As Exception
            Return DatosPersona
        End Try
    End Function
    '==================================Eliminar datos========================================
    Public Function EliminarDato(IDc As Integer) As Boolean
        Dim DatosPersona As New DataSet()
        Try
            Dim Commando As New SqlCommand("SPEliminardato", Conexion)
            Commando.CommandType = CommandType.StoredProcedure
            Commando.Parameters.Add(New SqlParameter("@ID", IDc))
            Dim Adaptador As New SqlDataAdapter()
            Conexion.Open()
            Adaptador.SelectCommand = Commando
            Adaptador.Fill(DatosPersona)
            Conexion.Close()
            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function
    '====================================== VALIDACION DATOS================================================
    Public Function CargarDatos()

        Dim DatosPersonas As New DataSet()

        DatosPersonas = SelectDatosDB()

        If DatosPersonas.Tables.Count > 0 Then
            If DatosPersonas.Tables(0).Rows.Count > 0 Then
                dgvPersonas.AutoGenerateColumns = False
                dgvPersonas.DataSource = DatosPersonas.Tables(0)
            End If
        End If

    End Function
    '======================================DATASET DATAGRD================================================
    Public Function CargarDatosPersona(ID As Integer)

        Dim DatosPersonas As New DataSet()


        DatosPersonas = SelectDatosPersona(ID)

        If DatosPersonas.Tables.Count > 0 Then
            If DatosPersonas.Tables(0).Rows.Count > 0 Then
                txtNombre.Text = DatosPersonas.Tables(0).Rows(0)("Nombre").ToString()
                txtApellido.Text = DatosPersonas.Tables(0).Rows(0)("Apellido").ToString()
                txtIdentifiacion.Text = DatosPersonas.Tables(0).Rows(0)("Identificacion").ToString()
                txtID.Text = DatosPersonas.Tables(0).Rows(0)("ID").ToString()
            End If
        End If


    End Function
    '====================================== BOTON CARGAR DATA A TEXT ================================================
    Private Sub btn_Cargar_Click(sender As Object, e As EventArgs) Handles btn_Cargar.Click
        Dim Nombre As String = ""
        Dim Apellido As String = ""
        Dim Identificacion As String = ""

        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        Identificacion = txtIdentifiacion.Text

        If InsertarDatos(Nombre, Apellido, Identificacion) Then
            limpiarTextos()
            MessageBox.Show("Insercion exitosa")
        Else
            MessageBox.Show("Insercion Fallida")
        End If

        CargarDatos()

    End Sub

    Private Sub dgvPersonas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvPersonas.CellClick
        Dim Fila As Integer = e.RowIndex
        Dim Columna As Integer = e.ColumnIndex
        Dim ID As Integer = Convert.ToInt32(dgvPersonas.Rows(Fila).Cells("ID").Value.ToString())
        CargarDatosPersona(ID)
    End Sub
    '====================================== BOTON ACTUALIZAR DATA A TEXT ================================================
    Private Sub btn_Actualizar_Click(sender As Object, e As EventArgs) Handles btn_Actualizar.Click
        Dim Nombre As String = ""
        Dim Apellido As String = ""
        Dim Identificacion As String = ""
        Dim ID As Integer = Convert.ToInt32(txtID.Text)

        Nombre = txtNombre.Text
        Apellido = txtApellido.Text
        Identificacion = txtIdentifiacion.Text

        If ActualizarDatos(ID, Nombre, Apellido, Identificacion) Then


            limpiarTextos()
            MessageBox.Show("Actualizacion exitosa")
        Else
            MessageBox.Show("Actualizacion Fallida")
        End If

        CargarDatos()
    End Sub
    '=============================================LIMPIAR TXY====================================================
    Function limpiarTextos()
        txtNombre.Text = ""
        txtApellido.Text = ""
        txtIdentifiacion.Text = ""
        txtID.Text = ""
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_Eliminar.Click
        Dim IDc As Integer = Convert.ToInt32(txtID.Text)
        EliminarDato(IDc)
        CargarDatos()



    End Sub

End Class
