namespace MatchingStateCapitals
{
	partial class GameForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose (bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose ( );
			}
			base.Dispose (disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent ( )
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
			this.labelQuestion = new System.Windows.Forms.Label();
			this.labelTimeRemaining = new System.Windows.Forms.Label();
			this.labelAttempts = new System.Windows.Forms.Label();
			this.labelCorrect = new System.Windows.Forms.Label();
			this.labelSelectCapital = new System.Windows.Forms.Label();
			this.tbState = new System.Windows.Forms.TextBox();
			this.tbTimeRemaining = new System.Windows.Forms.TextBox();
			this.pbState = new System.Windows.Forms.PictureBox();
			this.lbCapitals = new System.Windows.Forms.ListBox();
			this.tbAttempts = new System.Windows.Forms.TextBox();
			this.tbCorrect = new System.Windows.Forms.TextBox();
			this.btnNextQuestion = new System.Windows.Forms.Button();
			this.btnEndGame = new System.Windows.Forms.Button();
			this.timer = new System.Windows.Forms.Timer(this.components);
			((System.ComponentModel.ISupportInitialize)(this.pbState)).BeginInit();
			this.SuspendLayout();
			// 
			// labelQuestion
			// 
			this.labelQuestion.AutoSize = true;
			this.labelQuestion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelQuestion.Location = new System.Drawing.Point(12, 34);
			this.labelQuestion.Name = "labelQuestion";
			this.labelQuestion.Size = new System.Drawing.Size(176, 23);
			this.labelQuestion.TabIndex = 0;
			this.labelQuestion.Text = "What is the capital of:";
			// 
			// labelTimeRemaining
			// 
			this.labelTimeRemaining.AutoSize = true;
			this.labelTimeRemaining.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTimeRemaining.Location = new System.Drawing.Point(35, 93);
			this.labelTimeRemaining.Name = "labelTimeRemaining";
			this.labelTimeRemaining.Size = new System.Drawing.Size(131, 23);
			this.labelTimeRemaining.TabIndex = 3;
			this.labelTimeRemaining.Text = "Time Remaining";
			// 
			// labelAttempts
			// 
			this.labelAttempts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelAttempts.AutoSize = true;
			this.labelAttempts.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelAttempts.Location = new System.Drawing.Point(60, 289);
			this.labelAttempts.Name = "labelAttempts";
			this.labelAttempts.Size = new System.Drawing.Size(81, 23);
			this.labelAttempts.TabIndex = 6;
			this.labelAttempts.Text = "Attempts";
			// 
			// labelCorrect
			// 
			this.labelCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.labelCorrect.AutoSize = true;
			this.labelCorrect.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelCorrect.Location = new System.Drawing.Point(264, 289);
			this.labelCorrect.Name = "labelCorrect";
			this.labelCorrect.Size = new System.Drawing.Size(67, 23);
			this.labelCorrect.TabIndex = 7;
			this.labelCorrect.Text = "Correct";
			// 
			// labelSelectCapital
			// 
			this.labelSelectCapital.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.labelSelectCapital.AutoSize = true;
			this.labelSelectCapital.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelSelectCapital.Location = new System.Drawing.Point(432, 34);
			this.labelSelectCapital.Name = "labelSelectCapital";
			this.labelSelectCapital.Size = new System.Drawing.Size(140, 23);
			this.labelSelectCapital.TabIndex = 2;
			this.labelSelectCapital.Text = "Select the Capital";
			// 
			// tbState
			// 
			this.tbState.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbState.Location = new System.Drawing.Point(198, 30);
			this.tbState.Name = "tbState";
			this.tbState.ReadOnly = true;
			this.tbState.Size = new System.Drawing.Size(199, 31);
			this.tbState.TabIndex = 1;
			this.tbState.TabStop = false;
			this.tbState.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbTimeRemaining
			// 
			this.tbTimeRemaining.BackColor = System.Drawing.Color.White;
			this.tbTimeRemaining.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbTimeRemaining.ForeColor = System.Drawing.Color.Red;
			this.tbTimeRemaining.Location = new System.Drawing.Point(50, 124);
			this.tbTimeRemaining.Name = "tbTimeRemaining";
			this.tbTimeRemaining.ReadOnly = true;
			this.tbTimeRemaining.Size = new System.Drawing.Size(100, 66);
			this.tbTimeRemaining.TabIndex = 5;
			this.tbTimeRemaining.TabStop = false;
			this.tbTimeRemaining.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// pbState
			// 
			this.pbState.Location = new System.Drawing.Point(198, 82);
			this.pbState.Name = "pbState";
			this.pbState.Size = new System.Drawing.Size(199, 180);
			this.pbState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbState.TabIndex = 3;
			this.pbState.TabStop = false;
			// 
			// lbCapitals
			// 
			this.lbCapitals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbCapitals.FormattingEnabled = true;
			this.lbCapitals.ItemHeight = 19;
			this.lbCapitals.Location = new System.Drawing.Point(424, 74);
			this.lbCapitals.Name = "lbCapitals";
			this.lbCapitals.SelectionMode = System.Windows.Forms.SelectionMode.None;
			this.lbCapitals.Size = new System.Drawing.Size(156, 346);
			this.lbCapitals.TabIndex = 4;
			this.lbCapitals.SelectedIndexChanged += new System.EventHandler(this.lbCapitals_SelectedIndexChanged);
			// 
			// tbAttempts
			// 
			this.tbAttempts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tbAttempts.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbAttempts.Location = new System.Drawing.Point(67, 322);
			this.tbAttempts.Name = "tbAttempts";
			this.tbAttempts.ReadOnly = true;
			this.tbAttempts.Size = new System.Drawing.Size(66, 31);
			this.tbAttempts.TabIndex = 8;
			this.tbAttempts.TabStop = false;
			this.tbAttempts.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbCorrect
			// 
			this.tbCorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.tbCorrect.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tbCorrect.Location = new System.Drawing.Point(264, 322);
			this.tbCorrect.Name = "tbCorrect";
			this.tbCorrect.ReadOnly = true;
			this.tbCorrect.Size = new System.Drawing.Size(66, 31);
			this.tbCorrect.TabIndex = 9;
			this.tbCorrect.TabStop = false;
			this.tbCorrect.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnNextQuestion
			// 
			this.btnNextQuestion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnNextQuestion.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNextQuestion.Location = new System.Drawing.Point(30, 373);
			this.btnNextQuestion.Name = "btnNextQuestion";
			this.btnNextQuestion.Size = new System.Drawing.Size(158, 39);
			this.btnNextQuestion.TabIndex = 10;
			this.btnNextQuestion.Text = "&Next Question";
			this.btnNextQuestion.UseVisualStyleBackColor = true;
			this.btnNextQuestion.Click += new System.EventHandler(this.btnNextQuestion_Click);
			// 
			// btnEndGame
			// 
			this.btnEndGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnEndGame.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEndGame.Location = new System.Drawing.Point(218, 373);
			this.btnEndGame.Name = "btnEndGame";
			this.btnEndGame.Size = new System.Drawing.Size(158, 39);
			this.btnEndGame.TabIndex = 11;
			this.btnEndGame.Text = "&End Game";
			this.btnEndGame.UseVisualStyleBackColor = true;
			this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
			// 
			// timer
			// 
			this.timer.Interval = 1000;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// GameForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(605, 432);
			this.Controls.Add(this.btnEndGame);
			this.Controls.Add(this.btnNextQuestion);
			this.Controls.Add(this.lbCapitals);
			this.Controls.Add(this.pbState);
			this.Controls.Add(this.tbTimeRemaining);
			this.Controls.Add(this.tbCorrect);
			this.Controls.Add(this.tbAttempts);
			this.Controls.Add(this.tbState);
			this.Controls.Add(this.labelSelectCapital);
			this.Controls.Add(this.labelCorrect);
			this.Controls.Add(this.labelAttempts);
			this.Controls.Add(this.labelTimeRemaining);
			this.Controls.Add(this.labelQuestion);
			this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.Name = "GameForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Matching State Capitals  | Brett Hamilton";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
			this.Load += new System.EventHandler(this.GameForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.pbState)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelQuestion;
		private System.Windows.Forms.Label labelTimeRemaining;
		private System.Windows.Forms.Label labelAttempts;
		private System.Windows.Forms.Label labelCorrect;
		private System.Windows.Forms.Label labelSelectCapital;
		private System.Windows.Forms.TextBox tbState;
		private System.Windows.Forms.TextBox tbTimeRemaining;
		private System.Windows.Forms.PictureBox pbState;
		private System.Windows.Forms.ListBox lbCapitals;
		private System.Windows.Forms.TextBox tbAttempts;
		private System.Windows.Forms.TextBox tbCorrect;
		private System.Windows.Forms.Button btnNextQuestion;
		private System.Windows.Forms.Button btnEndGame;
		private System.Windows.Forms.Timer timer;
	}
}

