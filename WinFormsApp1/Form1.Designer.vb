<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculadora
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Calculadora))
        operaciones = New TextBox()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        Division = New Button()
        Multiplicacion = New Button()
        Resta = New Button()
        Numero7 = New Button()
        Numero8 = New Button()
        Numero9 = New Button()
        Numero4 = New Button()
        Numero5 = New Button()
        Numero6 = New Button()
        Numero1 = New Button()
        Numero2 = New Button()
        Numero3 = New Button()
        Numero0 = New Button()
        Coma = New Button()
        FlowLayoutPanel2 = New FlowLayoutPanel()
        Suma = New Button()
        Borrar = New Button()
        Igual = New Button()
        FlowLayoutPanel1.SuspendLayout()
        FlowLayoutPanel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' operaciones
        ' 
        operaciones.AccessibleRole = AccessibleRole.Equation
        operaciones.BackColor = SystemColors.MenuText
        operaciones.BorderStyle = BorderStyle.None
        operaciones.Font = New Font("Segoe UI", 35F)
        operaciones.ForeColor = SystemColors.Window
        operaciones.Location = New Point(0, 0)
        operaciones.Multiline = True
        operaciones.Name = "operaciones"
        operaciones.RightToLeft = RightToLeft.Yes
        operaciones.Size = New Size(364, 82)
        operaciones.TabIndex = 0
        operaciones.Text = "0"
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.BackColor = SystemColors.WindowText
        FlowLayoutPanel1.Controls.Add(Division)
        FlowLayoutPanel1.Controls.Add(Multiplicacion)
        FlowLayoutPanel1.Controls.Add(Resta)
        FlowLayoutPanel1.Controls.Add(Numero7)
        FlowLayoutPanel1.Controls.Add(Numero8)
        FlowLayoutPanel1.Controls.Add(Numero9)
        FlowLayoutPanel1.Controls.Add(Numero4)
        FlowLayoutPanel1.Controls.Add(Numero5)
        FlowLayoutPanel1.Controls.Add(Numero6)
        FlowLayoutPanel1.Controls.Add(Numero1)
        FlowLayoutPanel1.Controls.Add(Numero2)
        FlowLayoutPanel1.Controls.Add(Numero3)
        FlowLayoutPanel1.Controls.Add(Numero0)
        FlowLayoutPanel1.Controls.Add(Coma)
        FlowLayoutPanel1.Location = New Point(0, 130)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(273, 286)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Division
        ' 
        Division.BackColor = Color.DodgerBlue
        Division.Font = New Font("Segoe UI", 20F)
        Division.ForeColor = SystemColors.Window
        Division.Location = New Point(3, 3)
        Division.Name = "Division"
        Division.Size = New Size(85, 50)
        Division.TabIndex = 0
        Division.Text = "/"
        Division.UseVisualStyleBackColor = False
        ' 
        ' Multiplicacion
        ' 
        Multiplicacion.BackColor = Color.DodgerBlue
        Multiplicacion.Font = New Font("Segoe UI", 20F)
        Multiplicacion.ForeColor = SystemColors.Window
        Multiplicacion.Location = New Point(94, 3)
        Multiplicacion.Name = "Multiplicacion"
        Multiplicacion.Size = New Size(85, 50)
        Multiplicacion.TabIndex = 1
        Multiplicacion.Text = "X"
        Multiplicacion.UseVisualStyleBackColor = False
        ' 
        ' Resta
        ' 
        Resta.BackColor = Color.DodgerBlue
        Resta.Font = New Font("Segoe UI", 20F)
        Resta.ForeColor = SystemColors.Window
        Resta.Location = New Point(185, 3)
        Resta.Name = "Resta"
        Resta.Size = New Size(85, 50)
        Resta.TabIndex = 2
        Resta.Text = "-"
        Resta.UseVisualStyleBackColor = False
        ' 
        ' Numero7
        ' 
        Numero7.BackColor = SystemColors.WindowFrame
        Numero7.Font = New Font("Segoe UI", 20F)
        Numero7.ForeColor = SystemColors.Window
        Numero7.Location = New Point(3, 59)
        Numero7.Name = "Numero7"
        Numero7.Size = New Size(85, 50)
        Numero7.TabIndex = 3
        Numero7.Text = "7"
        Numero7.UseVisualStyleBackColor = False
        ' 
        ' Numero8
        ' 
        Numero8.BackColor = SystemColors.WindowFrame
        Numero8.Font = New Font("Segoe UI", 20F)
        Numero8.ForeColor = SystemColors.Window
        Numero8.Location = New Point(94, 59)
        Numero8.Name = "Numero8"
        Numero8.Size = New Size(85, 50)
        Numero8.TabIndex = 4
        Numero8.Text = "8"
        Numero8.UseVisualStyleBackColor = False
        ' 
        ' Numero9
        ' 
        Numero9.BackColor = SystemColors.WindowFrame
        Numero9.Font = New Font("Segoe UI", 20F)
        Numero9.ForeColor = SystemColors.Window
        Numero9.Location = New Point(185, 59)
        Numero9.Name = "Numero9"
        Numero9.Size = New Size(85, 50)
        Numero9.TabIndex = 5
        Numero9.Text = "9"
        Numero9.UseVisualStyleBackColor = False
        ' 
        ' Numero4
        ' 
        Numero4.BackColor = SystemColors.WindowFrame
        Numero4.Font = New Font("Segoe UI", 20F)
        Numero4.ForeColor = SystemColors.Window
        Numero4.Location = New Point(3, 115)
        Numero4.Name = "Numero4"
        Numero4.Size = New Size(85, 50)
        Numero4.TabIndex = 6
        Numero4.Text = "4"
        Numero4.UseVisualStyleBackColor = False
        ' 
        ' Numero5
        ' 
        Numero5.BackColor = SystemColors.WindowFrame
        Numero5.Font = New Font("Segoe UI", 20F)
        Numero5.ForeColor = SystemColors.Window
        Numero5.Location = New Point(94, 115)
        Numero5.Name = "Numero5"
        Numero5.Size = New Size(85, 50)
        Numero5.TabIndex = 7
        Numero5.Text = "5"
        Numero5.UseVisualStyleBackColor = False
        ' 
        ' Numero6
        ' 
        Numero6.BackColor = SystemColors.WindowFrame
        Numero6.Font = New Font("Segoe UI", 20F)
        Numero6.ForeColor = SystemColors.Window
        Numero6.Location = New Point(185, 115)
        Numero6.Name = "Numero6"
        Numero6.Size = New Size(85, 50)
        Numero6.TabIndex = 8
        Numero6.Text = "6"
        Numero6.UseVisualStyleBackColor = False
        ' 
        ' Numero1
        ' 
        Numero1.BackColor = SystemColors.WindowFrame
        Numero1.Font = New Font("Segoe UI", 20F)
        Numero1.ForeColor = SystemColors.Window
        Numero1.Location = New Point(3, 171)
        Numero1.Name = "Numero1"
        Numero1.Size = New Size(85, 50)
        Numero1.TabIndex = 9
        Numero1.Text = "1"
        Numero1.UseVisualStyleBackColor = False
        ' 
        ' Numero2
        ' 
        Numero2.BackColor = SystemColors.WindowFrame
        Numero2.Font = New Font("Segoe UI", 20F)
        Numero2.ForeColor = SystemColors.Window
        Numero2.Location = New Point(94, 171)
        Numero2.Name = "Numero2"
        Numero2.Size = New Size(85, 50)
        Numero2.TabIndex = 10
        Numero2.Text = "2"
        Numero2.UseVisualStyleBackColor = False
        ' 
        ' Numero3
        ' 
        Numero3.BackColor = SystemColors.WindowFrame
        Numero3.Font = New Font("Segoe UI", 20F)
        Numero3.ForeColor = SystemColors.Window
        Numero3.Location = New Point(185, 171)
        Numero3.Name = "Numero3"
        Numero3.Size = New Size(85, 50)
        Numero3.TabIndex = 11
        Numero3.Text = "3"
        Numero3.UseVisualStyleBackColor = False
        ' 
        ' Numero0
        ' 
        Numero0.BackColor = SystemColors.WindowFrame
        Numero0.Font = New Font("Segoe UI", 20F)
        Numero0.ForeColor = SystemColors.Window
        Numero0.Location = New Point(3, 227)
        Numero0.Name = "Numero0"
        Numero0.Size = New Size(176, 50)
        Numero0.TabIndex = 12
        Numero0.Text = "0"
        Numero0.UseVisualStyleBackColor = False
        ' 
        ' Coma
        ' 
        Coma.BackColor = SystemColors.WindowFrame
        Coma.Font = New Font("Segoe UI", 20F)
        Coma.ForeColor = SystemColors.Window
        Coma.Location = New Point(185, 227)
        Coma.Name = "Coma"
        Coma.Size = New Size(85, 50)
        Coma.TabIndex = 13
        Coma.Text = ","
        Coma.UseVisualStyleBackColor = False
        ' 
        ' FlowLayoutPanel2
        ' 
        FlowLayoutPanel2.BackColor = SystemColors.WindowText
        FlowLayoutPanel2.Controls.Add(Suma)
        FlowLayoutPanel2.Controls.Add(Borrar)
        FlowLayoutPanel2.Controls.Add(Igual)
        FlowLayoutPanel2.Location = New Point(273, 130)
        FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        FlowLayoutPanel2.Size = New Size(91, 286)
        FlowLayoutPanel2.TabIndex = 12
        ' 
        ' Suma
        ' 
        Suma.BackColor = Color.DodgerBlue
        Suma.Font = New Font("Segoe UI", 20F)
        Suma.ForeColor = SystemColors.Window
        Suma.Location = New Point(3, 3)
        Suma.Name = "Suma"
        Suma.Size = New Size(85, 50)
        Suma.TabIndex = 11
        Suma.Text = "+"
        Suma.UseVisualStyleBackColor = False
        ' 
        ' Borrar
        ' 
        Borrar.BackColor = Color.DarkOrange
        Borrar.Font = New Font("Segoe UI", 20F)
        Borrar.ForeColor = SystemColors.Window
        Borrar.Location = New Point(3, 59)
        Borrar.Name = "Borrar"
        Borrar.Size = New Size(85, 106)
        Borrar.TabIndex = 12
        Borrar.Text = "AC"
        Borrar.UseVisualStyleBackColor = False
        ' 
        ' Igual
        ' 
        Igual.BackColor = Color.LimeGreen
        Igual.Font = New Font("Segoe UI", 20F)
        Igual.ForeColor = SystemColors.Window
        Igual.Location = New Point(3, 171)
        Igual.Name = "Igual"
        Igual.Size = New Size(85, 106)
        Igual.TabIndex = 13
        Igual.Text = "="
        Igual.UseVisualStyleBackColor = False
        ' 
        ' Calculadora
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(364, 410)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(operaciones)
        Controls.Add(FlowLayoutPanel2)
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "Calculadora"
        Text = "Calculadora"
        FlowLayoutPanel1.ResumeLayout(False)
        FlowLayoutPanel2.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents operaciones As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Division As Button
    Friend WithEvents Multiplicacion As Button
    Friend WithEvents Resta As Button
    Friend WithEvents Numero7 As Button
    Friend WithEvents Numero8 As Button
    Friend WithEvents Numero9 As Button
    Friend WithEvents Numero4 As Button
    Friend WithEvents Numero5 As Button
    Friend WithEvents Numero6 As Button
    Friend WithEvents Numero1 As Button
    Friend WithEvents Numero2 As Button
    Friend WithEvents Numero3 As Button
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Numero0 As Button
    Friend WithEvents Coma As Button
    Friend WithEvents Suma As Button
    Friend WithEvents Borrar As Button
    Friend WithEvents Igual As Button

End Class
