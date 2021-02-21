///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 5 - Matching State Capitals
//	File Name:         GameManager.cs
//	Description:       Handles the game events, gets the state information/pictures, and controls the
//							sorted dictionary.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Wednesday, November 27, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingStateCapitals
{
	/// <summary>
	/// Manages the game, gets state information from directories, handles the sorted dictionary, used
	///		in the main game Form.
	/// </summary>
	public class GameManager
	{
		#region Fields
		private string pathData = @"..\..\State Data\states.txt";   // Path for state data
		private string pathPictures = @"..\..\State Pictures";      // Path for state pictures
		#endregion

		#region Properties		
		/// <summary>
		/// Gets or sets the current state that the user is trying to match.
		/// </summary>
		/// <value>
		/// The current state that is in question.
		/// </value>
		public string CurrentState { get; set; }
		/// <summary>
		/// Gets or sets the sorted dictionary of states and state capitals.
		/// </summary>
		/// <value>
		/// The key/value pairings of states and capitals, respectively.
		/// </value>
		public SortedDictionary<string, string> StateCapitals { get; set; }
		/// <summary>
		/// Gets or sets the array of picture paths for states.
		/// </summary>
		/// <value>
		/// The paths to the picture files.
		/// </value>
		public string[] Paths { get; set; }
		#endregion

		#region Constructor
		/// <summary>
		/// Default constructor; Calls supporting methods to set up game.
		/// </summary>
		public GameManager ( )
		{
			FillDictionary ( );
			GetPictures ( );
		} // end GameManager
		#endregion

		#region Fill Dictionary and Picture Paths		
		/// <summary>
		/// Fills the sorted dictionary of state/capital pairings for use in the game form to
		///		find correct answer.
		/// </summary>
		private void FillDictionary ( )
		{
			StateCapitals = new SortedDictionary<string, string> ( );

			StreamReader rdr = null;
			string line = string.Empty;
			string[] fields;
			string capital, state;

			// Attempt to fill sorted dictionary with information from state file
			try
			{
				rdr = new StreamReader (pathData);

				while (rdr.Peek ( ) != -1)
				{
					line = rdr.ReadLine ( );
					fields = line.Split (',');			// Comma-delimited
					capital = fields[0].Trim ( );
					state = fields[1].Trim ( );

					StateCapitals[state] = capital;		// Add state/capital to dictionary
				}
			}
			catch (Exception)
			{
				MessageBox.Show ("Error: Could not read State Data.", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				if (rdr != null)
					rdr.Close ( );
			}
		} // end FillDictionary

		/// <summary>
		/// Use LINQ to extract the picture paths with file names to an array.
		/// </summary>
		private void GetPictures( )
		{
			// LINQ statement to select all files in State Pictures folder
			var pictures = from file in Directory.GetFiles (pathPictures)
						   orderby file
						   select file;

			// Create and sort array of paths
			Paths = pictures.ToArray ( );
			Array.Sort (Paths);

		} // end GetPictures
		#endregion
	} // end GameManager
}
