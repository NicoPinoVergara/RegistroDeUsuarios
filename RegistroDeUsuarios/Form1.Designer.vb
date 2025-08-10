<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Las anulaciones de formulario eliminan la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de formularios de Windows
    Private components As System.ComponentModel.IContainer

    'NOTA: El siguiente procedimiento es requerido por el Diseñador de formularios de Windows
    'Se puede modificar utilizando el Diseñador de formularios de Windows.
    'No modifique esto utilizando el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        tbxApellidos = New TextBox()
        tbxNombres = New TextBox()
        tbxRut = New TextBox()
        lbApellidos = New Label()
        lbNombres = New Label()
        lbRut = New Label()
        Panel1 = New Panel()
        lbSexo = New Label()
        rbNoEspecifica = New RadioButton()
        rbMujer = New RadioButton()
        rbHombre = New RadioButton()
        lbComuna = New Label()
        lbCiudad = New Label()
        lbObservacion = New Label()
        tbxCiudad = New TextBox()
        tbxObservacion = New TextBox()
        btnGuardarMySQL = New Button()
        btnBuscar = New Button()
        cmbComuna = New ComboBox()
        btnEliminar = New Button()
        btnActualizar = New Button()
        btnVerDatos = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' tbxApellidos
        ' 
        tbxApellidos.AccessibleDescription = "Ingrese los apellidos"
        tbxApellidos.AccessibleName = "Apellidos"
        tbxApellidos.Location = New Point(125, 137)
        tbxApellidos.Name = "tbxApellidos"
        tbxApellidos.Size = New Size(376, 27)
        tbxApellidos.TabIndex = 1
        ' 
        ' tbxNombres
        ' 
        tbxNombres.AccessibleDescription = "Ingrese los nombres"
        tbxNombres.AccessibleName = "Nombres"
        tbxNombres.Location = New Point(125, 92)
        tbxNombres.Name = "tbxNombres"
        tbxNombres.Size = New Size(376, 27)
        tbxNombres.TabIndex = 2
        ' 
        ' tbxRut
        ' 
        tbxRut.AccessibleDescription = "Ingrese el RUT"
        tbxRut.AccessibleName = "Rut"
        tbxRut.Location = New Point(125, 45)
        tbxRut.Name = "tbxRut"
        tbxRut.Size = New Size(202, 27)
        tbxRut.TabIndex = 0
        ' 
        ' lbApellidos
        ' 
        lbApellidos.AutoSize = True
        lbApellidos.Location = New Point(43, 137)
        lbApellidos.Name = "lbApellidos"
        lbApellidos.Size = New Size(72, 20)
        lbApellidos.TabIndex = 11
        lbApellidos.Text = "Apellidos"
        ' 
        ' lbNombres
        ' 
        lbNombres.AutoSize = True
        lbNombres.Location = New Point(43, 92)
        lbNombres.Name = "lbNombres"
        lbNombres.Size = New Size(70, 20)
        lbNombres.TabIndex = 10
        lbNombres.Text = "Nombres"
        ' 
        ' lbRut
        ' 
        lbRut.AutoSize = True
        lbRut.Location = New Point(43, 45)
        lbRut.Name = "lbRut"
        lbRut.Size = New Size(31, 20)
        lbRut.TabIndex = 9
        lbRut.Text = "Rut"
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(lbSexo)
        Panel1.Controls.Add(rbNoEspecifica)
        Panel1.Controls.Add(rbMujer)
        Panel1.Controls.Add(rbHombre)
        Panel1.Location = New Point(43, 179)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(495, 102)
        Panel1.TabIndex = 3
        ' 
        ' lbSexo
        ' 
        lbSexo.AutoSize = True
        lbSexo.Location = New Point(3, 16)
        lbSexo.Name = "lbSexo"
        lbSexo.Size = New Size(41, 20)
        lbSexo.TabIndex = 4
        lbSexo.Text = "Sexo"
        ' 
        ' rbNoEspecifica
        ' 
        rbNoEspecifica.AccessibleDescription = "Sexo no especificado"
        rbNoEspecifica.AccessibleName = "No especifica"
        rbNoEspecifica.AutoSize = True
        rbNoEspecifica.Location = New Point(338, 50)
        rbNoEspecifica.Name = "rbNoEspecifica"
        rbNoEspecifica.Size = New Size(120, 24)
        rbNoEspecifica.TabIndex = 7
        rbNoEspecifica.TabStop = True
        rbNoEspecifica.Text = "No especifica"
        rbNoEspecifica.UseVisualStyleBackColor = True
        ' 
        ' rbMujer
        ' 
        rbMujer.AccessibleDescription = "Sexo femenino"
        rbMujer.AccessibleName = "Mujer"
        rbMujer.AutoSize = True
        rbMujer.Location = New Point(186, 50)
        rbMujer.Name = "rbMujer"
        rbMujer.Size = New Size(68, 24)
        rbMujer.TabIndex = 6
        rbMujer.TabStop = True
        rbMujer.Text = "Mujer"
        rbMujer.UseVisualStyleBackColor = True
        ' 
        ' rbHombre
        ' 
        rbHombre.AccessibleDescription = "Sexo masculino"
        rbHombre.AccessibleName = "Hombre"
        rbHombre.AutoSize = True
        rbHombre.Location = New Point(23, 50)
        rbHombre.Name = "rbHombre"
        rbHombre.Size = New Size(85, 24)
        rbHombre.TabIndex = 5
        rbHombre.TabStop = True
        rbHombre.Text = "Hombre"
        rbHombre.UseVisualStyleBackColor = True
        ' 
        ' lbComuna
        ' 
        lbComuna.AutoSize = True
        lbComuna.Location = New Point(43, 336)
        lbComuna.Name = "lbComuna"
        lbComuna.Size = New Size(64, 20)
        lbComuna.TabIndex = 8
        lbComuna.Text = "Comuna"
        ' 
        ' lbCiudad
        ' 
        lbCiudad.AutoSize = True
        lbCiudad.Location = New Point(43, 381)
        lbCiudad.Name = "lbCiudad"
        lbCiudad.Size = New Size(56, 20)
        lbCiudad.TabIndex = 9
        lbCiudad.Text = "Ciudad"
        ' 
        ' lbObservacion
        ' 
        lbObservacion.AutoSize = True
        lbObservacion.Location = New Point(43, 420)
        lbObservacion.Name = "lbObservacion"
        lbObservacion.Size = New Size(91, 20)
        lbObservacion.TabIndex = 10
        lbObservacion.Text = "Observacion"
        ' 
        ' tbxCiudad
        ' 
        tbxCiudad.AccessibleDescription = "Ingrese la ciudad"
        tbxCiudad.AccessibleName = "Ciudad"
        tbxCiudad.Location = New Point(159, 378)
        tbxCiudad.Name = "tbxCiudad"
        tbxCiudad.Size = New Size(342, 27)
        tbxCiudad.TabIndex = 11
        ' 
        ' tbxObservacion
        ' 
        tbxObservacion.AccessibleDescription = "Ingrese observaciones"
        tbxObservacion.AccessibleName = "Observacion"
        tbxObservacion.Location = New Point(159, 420)
        tbxObservacion.Name = "tbxObservacion"
        tbxObservacion.Size = New Size(342, 27)
        tbxObservacion.TabIndex = 12
        ' 
        ' btnGuardarMySQL
        ' 
        btnGuardarMySQL.AccessibleDescription = "Guarda los datos en MySQL"
        btnGuardarMySQL.AccessibleName = "Guardar MySQL"
        btnGuardarMySQL.Location = New Point(47, 470)
        btnGuardarMySQL.Name = "btnGuardarMySQL"
        btnGuardarMySQL.Size = New Size(137, 49)
        btnGuardarMySQL.TabIndex = 14
        btnGuardarMySQL.Text = "Guardar My SQL"
        btnGuardarMySQL.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.AccessibleDescription = "Busca datos por RUT"
        btnBuscar.AccessibleName = "Buscar"
        btnBuscar.Location = New Point(354, 45)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(147, 29)
        btnBuscar.TabIndex = 15
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' cmbComuna
        ' 
        cmbComuna.AccessibleDescription = "Seleccione la comuna"
        cmbComuna.AccessibleName = "Comuna"
        cmbComuna.FormattingEnabled = True
        cmbComuna.Location = New Point(159, 336)
        cmbComuna.Name = "cmbComuna"
        cmbComuna.Size = New Size(342, 28)
        cmbComuna.TabIndex = 13
        ' 
        ' btnEliminar
        ' 
        btnEliminar.AccessibleDescription = "Elimina los datos seleccionados"
        btnEliminar.AccessibleName = "Eliminar"
        btnEliminar.Location = New Point(47, 545)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(136, 49)
        btnEliminar.TabIndex = 16
        btnEliminar.Text = "Eliminar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.AccessibleDescription = "Actualiza los datos seleccionados"
        btnActualizar.AccessibleName = "Actualizar"
        btnActualizar.Location = New Point(354, 470)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(153, 49)
        btnActualizar.TabIndex = 17
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnVerDatos
        ' 
        btnVerDatos.AccessibleDescription = "Muestra los datos de la base de datos"
        btnVerDatos.AccessibleName = "Ver datos BD"
        btnVerDatos.Location = New Point(354, 545)
        btnVerDatos.Name = "btnVerDatos"
        btnVerDatos.Size = New Size(153, 49)
        btnVerDatos.TabIndex = 18
        btnVerDatos.Text = "Ver datos BD"
        btnVerDatos.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(585, 606)
        Controls.Add(btnVerDatos)
        Controls.Add(btnActualizar)
        Controls.Add(btnEliminar)
        Controls.Add(cmbComuna)
        Controls.Add(btnBuscar)
        Controls.Add(btnGuardarMySQL)
        Controls.Add(tbxObservacion)
        Controls.Add(tbxCiudad)
        Controls.Add(lbObservacion)
        Controls.Add(lbCiudad)
        Controls.Add(lbComuna)
        Controls.Add(Panel1)
        Controls.Add(tbxApellidos)
        Controls.Add(tbxNombres)
        Controls.Add(tbxRut)
        Controls.Add(lbApellidos)
        Controls.Add(lbNombres)
        Controls.Add(lbRut)
        Name = "Form1"
        Text = "Registro de usuarios"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    ' Mejoras: nombres descriptivos, accesibilidad, comentarios, orden de tabulación
    ' Grupo de datos personales
    Friend WithEvents tbxApellidos As TextBox
    Friend WithEvents tbxNombres As TextBox
    Friend WithEvents tbxRut As TextBox
    Friend WithEvents lbApellidos As Label
    Friend WithEvents lbNombres As Label
    Friend WithEvents lbRut As Label
    ' Grupo de sexo
    Friend WithEvents Panel1 As Panel
    Friend WithEvents rbNoEspecifica As RadioButton ' No especifica
    Friend WithEvents rbMujer As RadioButton ' Mujer
    Friend WithEvents rbHombre As RadioButton ' Hombre
    Friend WithEvents lbSexo As Label
    ' Grupo de ubicación
    Friend WithEvents lbComuna As Label
    Friend WithEvents lbCiudad As Label
    Friend WithEvents lbObservacion As Label
    Friend WithEvents tbxCiudad As TextBox
    Friend WithEvents tbxObservacion As TextBox
    Friend WithEvents cmbComuna As ComboBox
    ' Grupo de acciones
    Friend WithEvents btnGuardarMySQL As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnVerDatos As Button

End Class
