﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Git_Test_V1
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
		Me.components = New System.ComponentModel.Container()
		Me.U_Db_Database_Access1 = New Common_All_2013_a.U_Db_Database_Access()
		Me.Button1 = New System.Windows.Forms.Button()
		Me.Button2 = New System.Windows.Forms.Button()
		Me.SuspendLayout()
		'
		'U_Db_Database_Access1
		'
		Me.U_Db_Database_Access1.BackColor = System.Drawing.Color.White
		Me.U_Db_Database_Access1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.U_Db_Database_Access1.ForeColor = System.Drawing.Color.Black
		Me.U_Db_Database_Access1.Is_DB_Create_And_Structured = False
		Me.U_Db_Database_Access1.Location = New System.Drawing.Point(118, 178)
		Me.U_Db_Database_Access1.Name = "U_Db_Database_Access1"
		Me.U_Db_Database_Access1.Nom_Complet_Fichier_Database = "C:\Test_Auto.mdb"
		Me.U_Db_Database_Access1.Nom_Complet_Fichier_Database_Reference = "NC"
		Me.U_Db_Database_Access1.Nom_Path_Fichier_Database = "NC"
		Me.U_Db_Database_Access1.Nom_Simple_Fichier_Database = "NC"
		Me.U_Db_Database_Access1.Size = New System.Drawing.Size(75, 57)
		Me.U_Db_Database_Access1.TabIndex = 0
		Me.U_Db_Database_Access1.Type_Path_Fichier_Database = Common_All_2013_a.U_Db_Database_Access.E_Type_Path_Fichier_Database.Path_Exe_Database
		Me.U_Db_Database_Access1.Use_Referenced_DB = False
		'
		'Button1
		'
		Me.Button1.Location = New System.Drawing.Point(118, 31)
		Me.Button1.Name = "Button1"
		Me.Button1.Size = New System.Drawing.Size(200, 23)
		Me.Button1.TabIndex = 1
		Me.Button1.Text = "Branch Emn Test"
		Me.Button1.UseVisualStyleBackColor = True
		'
		'Button2
		'
		Me.Button2.Location = New System.Drawing.Point(160, 60)
		Me.Button2.Name = "Button2"
		Me.Button2.Size = New System.Drawing.Size(213, 23)
		Me.Button2.TabIndex = 2
		Me.Button2.Text = "Version 2 Ajouté le 2024-04-08 PCh"
		Me.Button2.UseVisualStyleBackColor = True
		'
		'Git_Test_V1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(610, 295)
		Me.Controls.Add(Me.Button2)
		Me.Controls.Add(Me.Button1)
		Me.Controls.Add(Me.U_Db_Database_Access1)
		Me.Name = "Git_Test_V1"
		Me.Text = "Git_Test_V1"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents U_Db_Database_Access1 As Common_All_2013_a.U_Db_Database_Access
	Friend WithEvents Button1 As Button
	Friend WithEvents Button2 As Button
End Class
