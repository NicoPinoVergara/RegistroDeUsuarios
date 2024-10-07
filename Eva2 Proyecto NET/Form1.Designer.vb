<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
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
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
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
        tbxApellidos.Location = New Point(125, 137)
        tbxApellidos.Name = "tbxApellidos"
        tbxApellidos.Size = New Size(376, 27)
        tbxApellidos.TabIndex = 14
        ' 
        ' tbxNombres
        ' 
        tbxNombres.Location = New Point(125, 92)
        tbxNombres.Name = "tbxNombres"
        tbxNombres.Size = New Size(376, 27)
        tbxNombres.TabIndex = 13
        ' 
        ' tbxRut
        ' 
        tbxRut.Location = New Point(125, 45)
        tbxRut.Name = "tbxRut"
        tbxRut.Size = New Size(202, 27)
        tbxRut.TabIndex = 12
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
        Panel1.Controls.Add(RadioButton3)
        Panel1.Controls.Add(RadioButton2)
        Panel1.Controls.Add(RadioButton1)
        Panel1.Location = New Point(43, 198)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(458, 114)
        Panel1.TabIndex = 15
        ' 
        ' lbSexo
        ' 
        lbSexo.AutoSize = True
        lbSexo.Location = New Point(24, 9)
        lbSexo.Name = "lbSexo"
        lbSexo.Size = New Size(41, 20)
        lbSexo.TabIndex = 21
        lbSexo.Text = "Sexo"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(285, 58)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(120, 24)
        RadioButton3.TabIndex = 20
        RadioButton3.TabStop = True
        RadioButton3.Text = "No especifica"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(173, 58)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(68, 24)
        RadioButton2.TabIndex = 19
        RadioButton2.TabStop = True
        RadioButton2.Text = "Mujer"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(24, 58)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(85, 24)
        RadioButton1.TabIndex = 18
        RadioButton1.TabStop = True
        RadioButton1.Text = "Hombre"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' lbComuna
        ' 
        lbComuna.AutoSize = True
        lbComuna.Location = New Point(43, 336)
        lbComuna.Name = "lbComuna"
        lbComuna.Size = New Size(64, 20)
        lbComuna.TabIndex = 16
        lbComuna.Text = "Comuna"
        ' 
        ' lbCiudad
        ' 
        lbCiudad.AutoSize = True
        lbCiudad.Location = New Point(43, 381)
        lbCiudad.Name = "lbCiudad"
        lbCiudad.Size = New Size(56, 20)
        lbCiudad.TabIndex = 17
        lbCiudad.Text = "Ciudad"
        ' 
        ' lbObservacion
        ' 
        lbObservacion.AutoSize = True
        lbObservacion.Location = New Point(43, 420)
        lbObservacion.Name = "lbObservacion"
        lbObservacion.Size = New Size(91, 20)
        lbObservacion.TabIndex = 18
        lbObservacion.Text = "Observacion"
        ' 
        ' tbxCiudad
        ' 
        tbxCiudad.Location = New Point(159, 378)
        tbxCiudad.Name = "tbxCiudad"
        tbxCiudad.Size = New Size(342, 27)
        tbxCiudad.TabIndex = 20
        ' 
        ' tbxObservacion
        ' 
        tbxObservacion.Location = New Point(159, 420)
        tbxObservacion.Name = "tbxObservacion"
        tbxObservacion.Size = New Size(342, 27)
        tbxObservacion.TabIndex = 21
        ' 
        ' btnGuardarMySQL
        ' 
        btnGuardarMySQL.Location = New Point(93, 470)
        btnGuardarMySQL.Name = "btnGuardarMySQL"
        btnGuardarMySQL.Size = New Size(137, 49)
        btnGuardarMySQL.TabIndex = 22
        btnGuardarMySQL.Text = "Guardar My SQL"
        btnGuardarMySQL.UseVisualStyleBackColor = True
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Location = New Point(354, 45)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(147, 29)
        btnBuscar.TabIndex = 23
        btnBuscar.Text = "Buscar"
        btnBuscar.UseVisualStyleBackColor = True
        ' 
        ' cmbComuna
        ' 
        cmbComuna.FormattingEnabled = True
        cmbComuna.Location = New Point(159, 336)
        cmbComuna.Name = "cmbComuna"
        cmbComuna.Size = New Size(342, 28)
        cmbComuna.TabIndex = 24
        ' 
        ' btnEliminar
        ' 
        btnEliminar.Location = New Point(107, 545)
        btnEliminar.Name = "btnEliminar"
        btnEliminar.Size = New Size(136, 49)
        btnEliminar.TabIndex = 25
        btnEliminar.Text = "Eliminiar"
        btnEliminar.UseVisualStyleBackColor = True
        ' 
        ' btnActualizar
        ' 
        btnActualizar.Location = New Point(348, 470)
        btnActualizar.Name = "btnActualizar"
        btnActualizar.Size = New Size(153, 49)
        btnActualizar.TabIndex = 26
        btnActualizar.Text = "Actualizar"
        btnActualizar.UseVisualStyleBackColor = True
        ' 
        ' btnVerDatos
        ' 
        btnVerDatos.Location = New Point(348, 545)
        btnVerDatos.Name = "btnVerDatos"
        btnVerDatos.Size = New Size(153, 49)
        btnVerDatos.TabIndex = 27
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
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents tbxApellidos As TextBox
    Friend WithEvents tbxNombres As TextBox
    Friend WithEvents tbxRut As TextBox
    Friend WithEvents lbApellidos As Label
    Friend WithEvents lbNombres As Label
    Friend WithEvents lbRut As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents lbSexo As Label
    Friend WithEvents lbComuna As Label
    Friend WithEvents lbCiudad As Label
    Friend WithEvents lbObservacion As Label
    Friend WithEvents tbxCiudad As TextBox
    Friend WithEvents tbxObservacion As TextBox
    Friend WithEvents btnGuardarMySQL As Button
    Friend WithEvents btnBuscar As Button
    Friend WithEvents cmbComuna As ComboBox
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnActualizar As Button
    Friend WithEvents btnVerDatos As Button

End Class
