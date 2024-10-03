Imports MySql.Data.MySqlClient

Public Class Form1
    Private connectionString As String = "Server=localhost;Database=registropersonas;Uid=root;Pwd=;"
    Private connection As MySqlConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarComunas()
    End Sub

    Private Sub CargarComunas()
        connection = New MySqlConnection(connectionString)
        Dim command As MySqlCommand = New MySqlCommand("SELECT NombreComuna FROM comuna", connection)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()

            While reader.Read()
                cmbComuna.Items.Add(reader("NombreComuna").ToString())
            End While
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al cargar comunas: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Sub btnGuardarMySQL_Click(sender As Object, e As EventArgs) Handles btnGuardarMySQL.Click
        If ValidarCampos() Then
            Dim sexo As String = If(RadioButton1.Checked, "Masculino", If(RadioButton2.Checked, "Femenino", "No especifica"))
            Dim command As MySqlCommand = New MySqlCommand("INSERT INTO Personas (RUT, Nombre, Apellido, Sexo, Comuna, Ciudad, Observacion) VALUES (@RUT, @Nombre, @Apellido, @Sexo, @Comuna, @Ciudad, @Observacion)", connection)

            command.Parameters.AddWithValue("@RUT", tbxRut.Text)
            command.Parameters.AddWithValue("@Nombre", tbxNombres.Text)
            command.Parameters.AddWithValue("@Apellido", tbxApellidos.Text)
            command.Parameters.AddWithValue("@Sexo", sexo)
            command.Parameters.AddWithValue("@Comuna", cmbComuna.SelectedItem.ToString())
            command.Parameters.AddWithValue("@Ciudad", tbxCiudad.Text)
            command.Parameters.AddWithValue("@Observacion", tbxObservacion.Text)

            Try
                connection.Open()
                command.ExecuteNonQuery()
                MessageBox.Show("Datos guardados exitosamente.")
                LimpiarFormulario()
                tbxRut.Focus() ' Enfocar en el campo RUT después de limpiar el formulario
            Catch ex As Exception
                MessageBox.Show("Error al guardar datos: " & ex.Message)
            Finally
                connection.Close()
            End Try
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim command As MySqlCommand = New MySqlCommand("SELECT * FROM Personas WHERE RUT = @RUT", connection)
        command.Parameters.AddWithValue("@RUT", tbxRut.Text)

        Try
            connection.Open()
            Dim reader As MySqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                tbxNombres.Text = reader("Nombre").ToString()
                tbxApellidos.Text = reader("Apellido").ToString()
                If reader("Sexo").ToString() = "Masculino" Then
                    RadioButton1.Checked = True
                ElseIf reader("Sexo").ToString() = "Femenino" Then
                    RadioButton2.Checked = True
                Else
                    RadioButton3.Checked = True
                End If
                cmbComuna.SelectedItem = reader("Comuna").ToString()
                tbxCiudad.Text = reader("Ciudad").ToString()
                tbxObservacion.Text = reader("Observacion").ToString() ' Cambiado a "Observacion"
            Else
                MessageBox.Show("RUT no encontrado.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error al buscar datos: " & ex.Message)
        Finally
            connection.Close()
        End Try
    End Sub

    Private Function ValidarCampos() As Boolean
        If String.IsNullOrWhiteSpace(tbxRut.Text) OrElse
           String.IsNullOrWhiteSpace(tbxNombres.Text) OrElse
           String.IsNullOrWhiteSpace(tbxApellidos.Text) OrElse
           cmbComuna.SelectedIndex = -1 Then
            MessageBox.Show("Por favor, complete todos los campos obligatorios.")
            Return False
        End If
        Return True
    End Function

    Private Sub LimpiarFormulario()
        tbxRut.Clear()
        tbxNombres.Clear()
        tbxApellidos.Clear()
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        cmbComuna.SelectedIndex = -1
        tbxCiudad.Clear()
        tbxObservacion.Clear()
        tbxRut.Focus()
    End Sub
End Class