///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//	Project:           Project 5 - Matching State Capitals
//	File Name:         GameForm.cs
//	Description:       Displays the main game form that handles all user interaction with the matching game,
//							including the game timer and state pictures.
//	Course:            CSCI 2210 - Data Structures	
//	Author:            Brett Hamilton, hamiltonb@etsu.edu, Dept. of Computing, East Tennessee State University
//	Created:           Wednesday, November 27, 2019
//	Copyright:         Brett Hamilton, 2019
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingStateCapitals
{
	/// <summary>
	/// Displays the game form that the user interacts with to play the game.
	/// </summary>
	/// <seealso cref="System.Windows.Forms.Form" />
	public partial class GameForm : Form
	{
		#region Fields
		private int timeRemaining = 20;     // For display; start with 20 seconds
		private int attempts = 0;			// Number of attempts completed
		private int correct = 0;			// Number of correct answers

		private GameManager game;
		private Random R = new Random ( );
		#endregion

		#region Constructor and Form Load
		/// <summary>
		/// Default constructor
		/// </summary>
		public GameForm ( )
		{
			InitializeComponent ( );
		} // end GameForm

		/// <summary>
		/// Sets up the game parameters when the form is loaded; starts the game.
		/// </summary>
		/// <param name="sender">The form sending the event</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void GameForm_Load (object sender, EventArgs e)
		{
			// Set text boxes
			tbTimeRemaining.Text = timeRemaining.ToString ( );
			tbAttempts.Text = attempts.ToString ( );
			tbCorrect.Text = correct.ToString ( );

			// Initialize the game
			game = new GameManager ( );

			// Set capitals in the list box
			string[] capitals = game.StateCapitals.Values.ToArray ( );
			Array.Sort (capitals);
			lbCapitals.DataSource = capitals;
			lbCapitals.SelectionMode = SelectionMode.One;

			NewState ( );

		} // end GameForm_Load
		#endregion

		#region Game Update Methods
		/// <summary>
		/// Responsible for randomly selecting the state for this turn.
		/// </summary>
		private void NewState ( )
		{
			// Get random state
			string[] keys = game.StateCapitals.Keys.ToArray ( );
			game.CurrentState = keys[R.Next (0, keys.Length)];

			UpdateGame ( );

		} // end NewState

		/// <summary>
		/// Updates text boxes, labels, timer, and state picture.
		/// </summary>
		private void UpdateGame ( )
		{
			// Update game information and timer
			tbState.Text = game.CurrentState;
			timeRemaining = 20;
			tbTimeRemaining.Text = "20";
			timer.Start ( );
			lbCapitals.Enabled = true;

			// Remove space from state to match picture path name
			string state = tbState.Text;
			state = state.Replace (" ", string.Empty);

			// Search for matching path
			string statePath = null;

			for (int i = 0; i < game.Paths.Length; i++)
			{
				if (game.Paths[i].Contains (state))
				{
					statePath = game.Paths[i];
					break;
				}
			}

			// Update picture to current state picture
			if (statePath != null)
				pbState.ImageLocation = statePath;
			else
				MessageBox.Show (this, "Error: Could not find state picture.", "Picture Not Found",
					MessageBoxButtons.OK, MessageBoxIcon.Error);

		} // end UpdateGame
		#endregion

		#region Timer
		/// <summary>
		/// Updates the time remaining text box with current seconds left, or ends the turn
		///		if time limit is reached.
		/// </summary>
		/// <param name="sender">The timer sending the tick event.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void timer_Tick (object sender, EventArgs e)
		{
			if (timeRemaining > 1)		// User still has time, update time text box
			{
				timeRemaining -= 1;
				tbTimeRemaining.Text = timeRemaining.ToString ( );
			}
			else						// User ran out of time
			{
				tbTimeRemaining.Text = "0";
				timer.Enabled = false;
				lbCapitals.Enabled = false;
				
				// Increment attempt counter and display
				attempts++;
				tbAttempts.Text = attempts.ToString ( );

				MessageBox.Show (this, "Time expired. Please continue to the next question.",
					"Time Expired", MessageBoxButtons.OK, MessageBoxIcon.None);
			}
		} // end timer_Tick
		#endregion

		#region Capital Selected Methods		
		/// <summary>
		/// Determines if the capital the user selected matches the current state and takes
		///		appropriate action.
		/// </summary>
		/// <param name="sender">The list box holding the state capitals.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void lbCapitals_SelectedIndexChanged (object sender, EventArgs e)
		{
			// Freeze controls so user cannot select capitals until next turn
			timer.Stop ( );
			lbCapitals.Enabled = false;
			attempts++;

			// Determine if the user answered correctly
			string selectedCapital = lbCapitals.SelectedItem.ToString ( );

			if (selectedCapital == game.StateCapitals[game.CurrentState])	// Answer is correct
			{
				correct++;
				MessageBox.Show (this, "Your answer is correct!", "Congratulations!",
					MessageBoxButtons.OK, MessageBoxIcon.None);
			}
			else		// Answer is incorrect
			{
				MessageBox.Show (this, "Sorry, that answer is incorrect.", "Incorrect Answer",
					MessageBoxButtons.OK, MessageBoxIcon.None);
			}

			// Update score text boxes
			tbAttempts.Text = attempts.ToString ( );
			tbCorrect.Text = correct.ToString ( );

		} // end lbCapitals_SelectedIndexChanged
		#endregion

		#region Click Events		
		/// <summary>
		/// Moves to the next state when user selects the "next question" button.
		/// </summary>
		/// <param name="sender">The "next question" button.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void btnNextQuestion_Click (object sender, EventArgs e)
		{
			NewState ( );
		} // end btnNextQuestion_Click

		/// <summary>
		/// Closes the form when the user selects the "end game" button.
		/// </summary>
		/// <param name="sender">The "end game" button.</param>
		/// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
		private void btnEndGame_Click (object sender, EventArgs e)
		{
			this.Close ( );
		} // end btnEndGame_Click
		#endregion

		#region Form Closing		
		/// <summary>
		/// Calculates the user's total score and displays an appropriate goodbye message
		///		displaying the score and number of attempts.
		/// </summary>
		/// <param name="sender">The form that is closing.</param>
		/// <param name="e">The <see cref="FormClosingEventArgs"/> instance containing the event data.</param>
		private void GameForm_FormClosing (object sender, FormClosingEventArgs e)
		{
			timer.Stop ( );									// Prevent timer from continuing

			double score;

			// Prevent "Divide By Zero" error
			if (attempts > 0)
				score = (double) correct / attempts;		// Calculate percentage correct
			else
				score = 0;

			string msg = $"Thank you for trying your luck at the State Capital Matching " +
				$"Game!\n\nYour score was {score:P1} on {attempts} attempts.";

			MessageBox.Show (this, msg, "Thank You!", MessageBoxButtons.OK, MessageBoxIcon.None);
		} // end GameForm_FormClosing
		#endregion
	} // end GameForm
}
