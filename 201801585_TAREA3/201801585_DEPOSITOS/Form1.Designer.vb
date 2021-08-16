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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbahorro = New System.Windows.Forms.RadioButton()
        Me.rdbmonPremiere = New System.Windows.Forms.RadioButton()
        Me.rdbmon = New System.Windows.Forms.RadioButton()
        Me.grbmetodo = New System.Windows.Forms.GroupBox()
        Me.txtefectivo = New System.Windows.Forms.TextBox()
        Me.txtchqOtro = New System.Windows.Forms.TextBox()
        Me.txtchqPropio = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chbefectivo = New System.Windows.Forms.CheckBox()
        Me.chbchqOtro = New System.Windows.Forms.CheckBox()
        Me.chbchqpropio = New System.Windows.Forms.CheckBox()
        Me.grbanterior = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtsaldoAnterior = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btncalcular = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lbltotalDeposito = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lblsaldoNuevo = New System.Windows.Forms.Label()
        Me.lblinteresAhorro = New System.Windows.Forms.Label()
        Me.lblsaldoAcumulado = New System.Windows.Forms.Label()
        Me.lblinterespremiere = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblsaldoAnterior = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grbmetodo.SuspendLayout()
        Me.grbanterior.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbahorro)
        Me.GroupBox1.Controls.Add(Me.rdbmonPremiere)
        Me.GroupBox1.Controls.Add(Me.rdbmon)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 112)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de depósito"
        '
        'rdbahorro
        '
        Me.rdbahorro.AutoSize = True
        Me.rdbahorro.Location = New System.Drawing.Point(7, 75)
        Me.rdbahorro.Name = "rdbahorro"
        Me.rdbahorro.Size = New System.Drawing.Size(62, 19)
        Me.rdbahorro.TabIndex = 2
        Me.rdbahorro.Text = "Ahorro"
        Me.rdbahorro.UseVisualStyleBackColor = True
        '
        'rdbmonPremiere
        '
        Me.rdbmonPremiere.AutoSize = True
        Me.rdbmonPremiere.Location = New System.Drawing.Point(7, 49)
        Me.rdbmonPremiere.Name = "rdbmonPremiere"
        Me.rdbmonPremiere.Size = New System.Drawing.Size(130, 19)
        Me.rdbmonPremiere.TabIndex = 1
        Me.rdbmonPremiere.Text = "Monetario Premiere"
        Me.rdbmonPremiere.UseVisualStyleBackColor = True
        '
        'rdbmon
        '
        Me.rdbmon.AutoSize = True
        Me.rdbmon.Location = New System.Drawing.Point(7, 23)
        Me.rdbmon.Name = "rdbmon"
        Me.rdbmon.Size = New System.Drawing.Size(80, 19)
        Me.rdbmon.TabIndex = 0
        Me.rdbmon.Text = "Monetario"
        Me.rdbmon.UseVisualStyleBackColor = True
        '
        'grbmetodo
        '
        Me.grbmetodo.BackColor = System.Drawing.Color.Transparent
        Me.grbmetodo.Controls.Add(Me.txtefectivo)
        Me.grbmetodo.Controls.Add(Me.txtchqOtro)
        Me.grbmetodo.Controls.Add(Me.txtchqPropio)
        Me.grbmetodo.Controls.Add(Me.Label4)
        Me.grbmetodo.Controls.Add(Me.Label3)
        Me.grbmetodo.Controls.Add(Me.Label2)
        Me.grbmetodo.Controls.Add(Me.Label1)
        Me.grbmetodo.Controls.Add(Me.chbefectivo)
        Me.grbmetodo.Controls.Add(Me.chbchqOtro)
        Me.grbmetodo.Controls.Add(Me.chbchqpropio)
        Me.grbmetodo.Enabled = False
        Me.grbmetodo.Location = New System.Drawing.Point(220, 13)
        Me.grbmetodo.Name = "grbmetodo"
        Me.grbmetodo.Size = New System.Drawing.Size(338, 112)
        Me.grbmetodo.TabIndex = 1
        Me.grbmetodo.TabStop = False
        Me.grbmetodo.Text = "Método de depósito"
        '
        'txtefectivo
        '
        Me.txtefectivo.Enabled = False
        Me.txtefectivo.Location = New System.Drawing.Point(172, 86)
        Me.txtefectivo.Name = "txtefectivo"
        Me.txtefectivo.Size = New System.Drawing.Size(100, 23)
        Me.txtefectivo.TabIndex = 9
        '
        'txtchqOtro
        '
        Me.txtchqOtro.Enabled = False
        Me.txtchqOtro.Location = New System.Drawing.Point(172, 61)
        Me.txtchqOtro.Name = "txtchqOtro"
        Me.txtchqOtro.Size = New System.Drawing.Size(100, 23)
        Me.txtchqOtro.TabIndex = 8
        '
        'txtchqPropio
        '
        Me.txtchqPropio.Enabled = False
        Me.txtchqPropio.Location = New System.Drawing.Point(172, 37)
        Me.txtchqPropio.Name = "txtchqPropio"
        Me.txtchqPropio.Size = New System.Drawing.Size(100, 23)
        Me.txtchqPropio.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(188, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Ingrese Monto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Q"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(149, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Q"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Q"
        '
        'chbefectivo
        '
        Me.chbefectivo.AutoSize = True
        Me.chbefectivo.Location = New System.Drawing.Point(6, 85)
        Me.chbefectivo.Name = "chbefectivo"
        Me.chbefectivo.Size = New System.Drawing.Size(68, 19)
        Me.chbefectivo.TabIndex = 2
        Me.chbefectivo.Text = "Efectivo"
        Me.chbefectivo.UseVisualStyleBackColor = True
        '
        'chbchqOtro
        '
        Me.chbchqOtro.AutoSize = True
        Me.chbchqOtro.Location = New System.Drawing.Point(6, 59)
        Me.chbchqOtro.Name = "chbchqOtro"
        Me.chbchqOtro.Size = New System.Drawing.Size(130, 19)
        Me.chbchqOtro.TabIndex = 1
        Me.chbchqOtro.Text = "Cheque Otro banco"
        Me.chbchqOtro.UseVisualStyleBackColor = True
        '
        'chbchqpropio
        '
        Me.chbchqpropio.AutoSize = True
        Me.chbchqpropio.Location = New System.Drawing.Point(6, 34)
        Me.chbchqpropio.Name = "chbchqpropio"
        Me.chbchqpropio.Size = New System.Drawing.Size(105, 19)
        Me.chbchqpropio.TabIndex = 0
        Me.chbchqpropio.Text = "Cheque propio"
        Me.chbchqpropio.UseVisualStyleBackColor = True
        '
        'grbanterior
        '
        Me.grbanterior.BackColor = System.Drawing.Color.Transparent
        Me.grbanterior.Controls.Add(Me.Label6)
        Me.grbanterior.Controls.Add(Me.txtsaldoAnterior)
        Me.grbanterior.Controls.Add(Me.Label5)
        Me.grbanterior.Enabled = False
        Me.grbanterior.Location = New System.Drawing.Point(12, 131)
        Me.grbanterior.Name = "grbanterior"
        Me.grbanterior.Size = New System.Drawing.Size(238, 76)
        Me.grbanterior.TabIndex = 2
        Me.grbanterior.TabStop = False
        Me.grbanterior.Text = "Saldo Anterior"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(16, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Q"
        '
        'txtsaldoAnterior
        '
        Me.txtsaldoAnterior.Location = New System.Drawing.Point(23, 41)
        Me.txtsaldoAnterior.Name = "txtsaldoAnterior"
        Me.txtsaldoAnterior.Size = New System.Drawing.Size(182, 23)
        Me.txtsaldoAnterior.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Ingrese Saldo anterior "
        '
        'btncalcular
        '
        Me.btncalcular.Location = New System.Drawing.Point(6, 44)
        Me.btncalcular.Name = "btncalcular"
        Me.btncalcular.Size = New System.Drawing.Size(75, 23)
        Me.btncalcular.TabIndex = 3
        Me.btncalcular.Text = "CALCULAR"
        Me.btncalcular.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.lbltotalDeposito)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.lblsaldoNuevo)
        Me.GroupBox2.Controls.Add(Me.lblinteresAhorro)
        Me.GroupBox2.Controls.Add(Me.lblsaldoAcumulado)
        Me.GroupBox2.Controls.Add(Me.lblinterespremiere)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblsaldoAnterior)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 239)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(545, 160)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "RESULTADOS"
        '
        'lbltotalDeposito
        '
        Me.lbltotalDeposito.AutoSize = True
        Me.lbltotalDeposito.BackColor = System.Drawing.Color.White
        Me.lbltotalDeposito.Location = New System.Drawing.Point(187, 66)
        Me.lbltotalDeposito.Name = "lbltotalDeposito"
        Me.lbltotalDeposito.Size = New System.Drawing.Size(0, 15)
        Me.lbltotalDeposito.TabIndex = 11
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(50, 66)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(131, 15)
        Me.Label12.TabIndex = 10
        Me.Label12.Text = "Monto total a depositar"
        '
        'lblsaldoNuevo
        '
        Me.lblsaldoNuevo.AutoSize = True
        Me.lblsaldoNuevo.BackColor = System.Drawing.Color.White
        Me.lblsaldoNuevo.Location = New System.Drawing.Point(187, 129)
        Me.lblsaldoNuevo.Name = "lblsaldoNuevo"
        Me.lblsaldoNuevo.Size = New System.Drawing.Size(0, 15)
        Me.lblsaldoNuevo.TabIndex = 9
        '
        'lblinteresAhorro
        '
        Me.lblinteresAhorro.AutoSize = True
        Me.lblinteresAhorro.BackColor = System.Drawing.Color.White
        Me.lblinteresAhorro.Location = New System.Drawing.Point(187, 110)
        Me.lblinteresAhorro.Name = "lblinteresAhorro"
        Me.lblinteresAhorro.Size = New System.Drawing.Size(0, 15)
        Me.lblinteresAhorro.TabIndex = 8
        '
        'lblsaldoAcumulado
        '
        Me.lblsaldoAcumulado.AutoSize = True
        Me.lblsaldoAcumulado.BackColor = System.Drawing.Color.White
        Me.lblsaldoAcumulado.Location = New System.Drawing.Point(187, 91)
        Me.lblsaldoAcumulado.Name = "lblsaldoAcumulado"
        Me.lblsaldoAcumulado.Size = New System.Drawing.Size(0, 15)
        Me.lblsaldoAcumulado.TabIndex = 7
        '
        'lblinterespremiere
        '
        Me.lblinterespremiere.AutoSize = True
        Me.lblinterespremiere.BackColor = System.Drawing.Color.White
        Me.lblinterespremiere.Location = New System.Drawing.Point(187, 42)
        Me.lblinterespremiere.Name = "lblinterespremiere"
        Me.lblinterespremiere.Size = New System.Drawing.Size(0, 15)
        Me.lblinterespremiere.TabIndex = 6
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(83, 129)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 15)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "SALDO NUEVO Q"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(13, 110)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(168, 15)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Interés sobre saldo acumulado"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(68, 91)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(113, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Saldo Acumulado Q"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(32, 42)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(149, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Interés sobre saldo anterior"
        '
        'lblsaldoAnterior
        '
        Me.lblsaldoAnterior.AutoSize = True
        Me.lblsaldoAnterior.BackColor = System.Drawing.Color.White
        Me.lblsaldoAnterior.Location = New System.Drawing.Point(187, 23)
        Me.lblsaldoAnterior.Name = "lblsaldoAnterior"
        Me.lblsaldoAnterior.Size = New System.Drawing.Size(0, 15)
        Me.lblsaldoAnterior.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 23)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Saldo anterior Q"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.btnsalir)
        Me.GroupBox3.Controls.Add(Me.btnlimpiar)
        Me.GroupBox3.Controls.Add(Me.btncalcular)
        Me.GroupBox3.Location = New System.Drawing.Point(257, 132)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(301, 100)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Procesos"
        '
        'btnsalir
        '
        Me.btnsalir.Location = New System.Drawing.Point(220, 44)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(75, 23)
        Me.btnsalir.TabIndex = 5
        Me.btnsalir.Text = "SALIR"
        Me.btnsalir.UseVisualStyleBackColor = True
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(112, 44)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnlimpiar.TabIndex = 4
        Me.btnlimpiar.Text = "LIMPIAR"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(580, 436)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grbanterior)
        Me.Controls.Add(Me.grbmetodo)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Cálculo de intereses y Control de Depósitos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbmetodo.ResumeLayout(False)
        Me.grbmetodo.PerformLayout()
        Me.grbanterior.ResumeLayout(False)
        Me.grbanterior.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbahorro As RadioButton
    Friend WithEvents rdbmonPremiere As RadioButton
    Friend WithEvents rdbmon As RadioButton
    Friend WithEvents grbmetodo As GroupBox
    Friend WithEvents chbefectivo As CheckBox
    Friend WithEvents chbchqOtro As CheckBox
    Friend WithEvents chbchqpropio As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtefectivo As TextBox
    Friend WithEvents txtchqOtro As TextBox
    Friend WithEvents txtchqPropio As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents grbanterior As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtsaldoAnterior As TextBox
    Friend WithEvents btncalcular As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnsalir As Button
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents lblsaldoAnterior As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblsaldoNuevo As Label
    Friend WithEvents lblinteresAhorro As Label
    Friend WithEvents lblsaldoAcumulado As Label
    Friend WithEvents lblinterespremiere As Label
    Friend WithEvents lbltotalDeposito As Label
    Friend WithEvents Label12 As Label
End Class
