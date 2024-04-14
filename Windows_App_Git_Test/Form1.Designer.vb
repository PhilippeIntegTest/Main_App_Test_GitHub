<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
		Me.U_Memo_Check_Branch_U5_Write = New Common_All_2013_a.U_Memo_Check_Mirror()
		Me.SuspendLayout()
		'
		'U_Db_Database_Access1
		'
		Me.U_Db_Database_Access1.BackColor = System.Drawing.Color.White
		Me.U_Db_Database_Access1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
		Me.U_Db_Database_Access1.ForeColor = System.Drawing.Color.Black
		Me.U_Db_Database_Access1.Is_DB_Create_And_Structured = False
		Me.U_Db_Database_Access1.Location = New System.Drawing.Point(49, 137)
		Me.U_Db_Database_Access1.Name = "U_Db_Database_Access1"
		Me.U_Db_Database_Access1.Nom_Complet_Fichier_Database = "C:\Test_Auto.mdb"
		Me.U_Db_Database_Access1.Nom_Complet_Fichier_Database_Reference = "NC"
		Me.U_Db_Database_Access1.Nom_Path_Fichier_Database = "NC"
		Me.U_Db_Database_Access1.Nom_Simple_Fichier_Database = "NC"
		Me.U_Db_Database_Access1.Size = New System.Drawing.Size(147, 107)
		Me.U_Db_Database_Access1.TabIndex = 0
		Me.U_Db_Database_Access1.Type_Path_Fichier_Database = Common_All_2013_a.U_Db_Database_Access.E_Type_Path_Fichier_Database.Path_Exe_Database
		Me.U_Db_Database_Access1.Use_Referenced_DB = False
		'
		'U_Memo_Check_Branch_U5_Write
		'
		Me.U_Memo_Check_Branch_U5_Write.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.U_Memo_Check_Branch_U5_Write.Checked = False
		Me.U_Memo_Check_Branch_U5_Write.Design_Appli_Path = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Design_Current_Mode = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Design_First_Init_Design = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Design_Ident_Date = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Design_Ident_Double = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Design_Me_Name = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Design_Parent_Name = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Location = New System.Drawing.Point(49, 25)
		Me.U_Memo_Check_Branch_U5_Write.Mirrored_Control = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Mirrored_Control_Exits = False
		Me.U_Memo_Check_Branch_U5_Write.Mode_Memo = False
		Me.U_Memo_Check_Branch_U5_Write.Mode_Mirror = False
		Me.U_Memo_Check_Branch_U5_Write.Name = "U_Memo_Check_Branch_U5_Write"
		Me.U_Memo_Check_Branch_U5_Write.Original_Control = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Parent_Name = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Parent_Parent_Name = Nothing
		Me.U_Memo_Check_Branch_U5_Write.Size = New System.Drawing.Size(147, 17)
		Me.U_Memo_Check_Branch_U5_Write.TabIndex = 1
		Me.U_Memo_Check_Branch_U5_Write.Text_Memo_Check = "Branch_U5_Write"
		Me.U_Memo_Check_Branch_U5_Write.UControl_Text_Font = New System.Drawing.Font("Comic Sans MS", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.U_Memo_Check_Branch_U5_Write.UCtl_Text_BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.U_Memo_Check_Branch_U5_Write.UCtl_Text_Color = System.Drawing.SystemColors.ControlText
		'
		'Git_Test_V1
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
		Me.ClientSize = New System.Drawing.Size(554, 281)
		Me.Controls.Add(Me.U_Memo_Check_Branch_U5_Write)
		Me.Controls.Add(Me.U_Db_Database_Access1)
		Me.Name = "Git_Test_V1"
		Me.Text = "Git_Test_V1"
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents U_Db_Database_Access1 As Common_All_2013_a.U_Db_Database_Access
	Friend WithEvents U_Memo_Check_Branch_U5_Write As Common_All_2013_a.U_Memo_Check_Mirror
End Class
