<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main_Page_GitHub
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
		Me.U5_GitHub_Test11 = New G1_Test_GitHub.U5_GitHub_Test1()
		Me.SuspendLayout()
		'
		'U5_GitHub_Test11
		'
		Me.U5_GitHub_Test11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
		Me.U5_GitHub_Test11.Location = New System.Drawing.Point(52, 39)
		Me.U5_GitHub_Test11.Name = "U5_GitHub_Test11"
		Me.U5_GitHub_Test11.Size = New System.Drawing.Size(220, 100)
		Me.U5_GitHub_Test11.TabIndex = 0
		'
		'Form1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(444, 236)
		Me.Controls.Add(Me.U5_GitHub_Test11)
		Me.Name = "Form1"
		Me.Text = "Main_Page GitHub"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents U5_GitHub_Test11 As U5_GitHub_Test1
End Class
