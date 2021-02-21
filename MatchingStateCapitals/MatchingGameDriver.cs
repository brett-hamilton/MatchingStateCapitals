///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 5 - Matching State Capitals
//	File Name:         MatchingGameDriver.cs
//	Description:       Starts and runs the matching game program, displaying the splash screen and main
//							game form.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Wednesday, November 27, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingStateCapitals
{
	/// <summary>
	/// Displays the splash screen, then the game form that runs the matching game.
	/// </summary>
	public static class MatchingGameDriver
	{
		#region Main
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		public static void Main ( )
		{
			Application.EnableVisualStyles ( );
			Application.SetCompatibleTextRenderingDefault (false);
			Application.Run (new WelcomeSplash ( ));
			Application.Run (new GameForm ( ));
		} // end Main
		#endregion
	} // end MatchingGameDriver
}
