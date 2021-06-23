<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtIdentifiacion = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvPersonas = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Identificacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_Cargar = New System.Windows.Forms.Button()
        Me.btn_Actualizar = New System.Windows.Forms.Button()
        Me.txtID = New System.Windows.Forms.Label()
        Me.btn_Eliminar = New System.Windows.Forms.Button()
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(201, 45)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(326, 27)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(201, 78)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(326, 27)
        Me.txtApellido.TabIndex = 1
        '
        'txtIdentifiacion
        '
        Me.txtIdentifiacion.Location = New System.Drawing.Point(201, 111)
        Me.txtIdentifiacion.Name = "txtIdentifiacion"
        Me.txtIdentifiacion.Size = New System.Drawing.Size(326, 27)
        Me.txtIdentifiacion.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(96, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(96, 85)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Apellido"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Identificacion"
        '
        'dgvPersonas
        '
        Me.dgvPersonas.AllowUserToAddRows = False
        Me.dgvPersonas.AllowUserToDeleteRows = False
        Me.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPersonas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Nombre, Me.Apellido, Me.Identificacion})
        Me.dgvPersonas.Location = New System.Drawing.Point(96, 149)
        Me.dgvPersonas.Name = "dgvPersonas"
        Me.dgvPersonas.ReadOnly = True
        Me.dgvPersonas.RowHeadersWidth = 51
        Me.dgvPersonas.RowTemplate.Height = 29
        Me.dgvPersonas.Size = New System.Drawing.Size(431, 158)
        Me.dgvPersonas.TabIndex = 6
        '
        'ID
        '
        Me.ID.DataPropertyName = "ID"
        Me.ID.HeaderText = "ID"
        Me.ID.MinimumWidth = 6
        Me.ID.Name = "ID"
        Me.ID.ReadOnly = True
        Me.ID.Visible = False
        Me.ID.Width = 125
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.MinimumWidth = 6
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 125
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.MinimumWidth = 6
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 125
        '
        'Identificacion
        '
        Me.Identificacion.DataPropertyName = "Identificacion"
        Me.Identificacion.HeaderText = "Identificacion"
        Me.Identificacion.MinimumWidth = 6
        Me.Identificacion.Name = "Identificacion"
        Me.Identificacion.ReadOnly = True
        Me.Identificacion.Width = 125
        '
        'btn_Cargar
        '
        Me.btn_Cargar.Location = New System.Drawing.Point(96, 313)
        Me.btn_Cargar.Name = "btn_Cargar"
        Me.btn_Cargar.Size = New System.Drawing.Size(94, 29)
        Me.btn_Cargar.TabIndex = 7
        Me.btn_Cargar.Text = "Cargar"
        Me.btn_Cargar.UseVisualStyleBackColor = True
        '
        'btn_Actualizar
        '
        Me.btn_Actualizar.Location = New System.Drawing.Point(197, 313)
        Me.btn_Actualizar.Name = "btn_Actualizar"
        Me.btn_Actualizar.Size = New System.Drawing.Size(94, 29)
        Me.btn_Actualizar.TabIndex = 8
        Me.btn_Actualizar.Text = "Actualizar"
        Me.btn_Actualizar.UseVisualStyleBackColor = True
        '
        'txtID
        '
        Me.txtID.AutoSize = True
        Me.txtID.Location = New System.Drawing.Point(201, 9)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(0, 20)
        Me.txtID.TabIndex = 9
        Me.txtID.Visible = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Location = New System.Drawing.Point(297, 313)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(94, 29)
        Me.btn_Eliminar.TabIndex = 10
        Me.btn_Eliminar.Text = "Eliminar"
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(581, 386)
        Me.Controls.Add(Me.btn_Eliminar)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.btn_Actualizar)
        Me.Controls.Add(Me.btn_Cargar)
        Me.Controls.Add(Me.dgvPersonas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtIdentifiacion)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Name = "Form1"
        Me.Text = "Proyecto_1"
        CType(Me.dgvPersonas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtIdentifiacion As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvPersonas As DataGridView
    Friend WithEvents btn_Cargar As Button
    Friend WithEvents btn_Actualizar As Button
    Friend WithEvents txtID As Label
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Apellido As DataGridViewTextBoxColumn
    Friend WithEvents Identificacion As DataGridViewTextBoxColumn
    Friend WithEvents btn_Eliminar As Button
End Class
