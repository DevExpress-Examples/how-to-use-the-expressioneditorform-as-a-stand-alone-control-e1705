﻿Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.UserSkins
Imports DevExpress.Skins
Imports DevExpress.LookAndFeel

Namespace Standalone_ExpressionEditor
	Friend Module Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread>
		Sub Main()
			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)

			BonusSkins.Register()
			SkinManager.EnableFormSkins()
			UserLookAndFeel.Default.SetSkinStyle("DevExpress Style")
			Application.Run(New Form_GridControl())
		End Sub
	End Module
End Namespace
