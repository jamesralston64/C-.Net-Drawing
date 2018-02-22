namespace TicTacToeDrawing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.player1 = new System.Windows.Forms.Button();
            this.player2 = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.headsOrTails = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.playerOne = new System.Windows.Forms.Label();
            this.playerTwo = new System.Windows.Forms.Label();
            this.p1Score = new System.Windows.Forms.Label();
            this.p2Score = new System.Windows.Forms.Label();
            this.playerTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(12, 904);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(120, 45);
            this.player1.TabIndex = 0;
            this.player1.Text = "1 Player Vs. PC";
            this.player1.UseVisualStyleBackColor = true;
            this.player1.Click += new System.EventHandler(this.player1_Click);
            // 
            // player2
            // 
            this.player2.Location = new System.Drawing.Point(138, 904);
            this.player2.Name = "player2";
            this.player2.Size = new System.Drawing.Size(120, 45);
            this.player2.TabIndex = 1;
            this.player2.Text = "2 Players";
            this.player2.UseVisualStyleBackColor = true;
            this.player2.Click += new System.EventHandler(this.player2_Click);
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(264, 904);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(120, 45);
            this.reset.TabIndex = 2;
            this.reset.Text = "Reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // headsOrTails
            // 
            this.headsOrTails.AutoSize = true;
            this.headsOrTails.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headsOrTails.ForeColor = System.Drawing.Color.Red;
            this.headsOrTails.Location = new System.Drawing.Point(625, 10);
            this.headsOrTails.Name = "headsOrTails";
            this.headsOrTails.Size = new System.Drawing.Size(0, 38);
            this.headsOrTails.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 637);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 67);
            this.label1.TabIndex = 4;
            this.label1.Text = "TIC-TAC-TOE";
            // 
            // playerOne
            // 
            this.playerOne.AutoSize = true;
            this.playerOne.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerOne.Location = new System.Drawing.Point(625, 153);
            this.playerOne.Name = "playerOne";
            this.playerOne.Size = new System.Drawing.Size(133, 40);
            this.playerOne.TabIndex = 5;
            this.playerOne.Text = "Player 1";
            // 
            // playerTwo
            // 
            this.playerTwo.AutoSize = true;
            this.playerTwo.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTwo.Location = new System.Drawing.Point(764, 153);
            this.playerTwo.Name = "playerTwo";
            this.playerTwo.Size = new System.Drawing.Size(133, 40);
            this.playerTwo.TabIndex = 6;
            this.playerTwo.Text = "Player 2";
            // 
            // p1Score
            // 
            this.p1Score.AutoSize = true;
            this.p1Score.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1Score.ForeColor = System.Drawing.Color.Red;
            this.p1Score.Location = new System.Drawing.Point(680, 202);
            this.p1Score.Name = "p1Score";
            this.p1Score.Size = new System.Drawing.Size(0, 33);
            this.p1Score.TabIndex = 7;
            // 
            // p2Score
            // 
            this.p2Score.AutoSize = true;
            this.p2Score.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2Score.ForeColor = System.Drawing.Color.Red;
            this.p2Score.Location = new System.Drawing.Point(815, 202);
            this.p2Score.Name = "p2Score";
            this.p2Score.Size = new System.Drawing.Size(0, 33);
            this.p2Score.TabIndex = 8;
            // 
            // playerTurn
            // 
            this.playerTurn.AutoSize = true;
            this.playerTurn.Font = new System.Drawing.Font("Comic Sans MS", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerTurn.ForeColor = System.Drawing.Color.Red;
            this.playerTurn.Location = new System.Drawing.Point(625, 899);
            this.playerTurn.Name = "playerTurn";
            this.playerTurn.Size = new System.Drawing.Size(0, 41);
            this.playerTurn.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.playerTurn);
            this.Controls.Add(this.p2Score);
            this.Controls.Add(this.p1Score);
            this.Controls.Add(this.playerTwo);
            this.Controls.Add(this.playerOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.headsOrTails);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.player2);
            this.Controls.Add(this.player1);
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimumSize = new System.Drawing.Size(1000, 1000);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button player1;
        private System.Windows.Forms.Button player2;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label headsOrTails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label playerOne;
        private System.Windows.Forms.Label playerTwo;
        private System.Windows.Forms.Label p1Score;
        private System.Windows.Forms.Label p2Score;
        private System.Windows.Forms.Label playerTurn;
    }
}

