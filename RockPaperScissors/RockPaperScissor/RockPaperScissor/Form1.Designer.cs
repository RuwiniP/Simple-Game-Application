namespace RockPaperScissor
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblplayer = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblComputerResult = new System.Windows.Forms.Label();
            this.lblComputer = new System.Windows.Forms.Label();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picComputer = new System.Windows.Forms.PictureBox();
            this.picPaper = new System.Windows.Forms.PictureBox();
            this.picScissor = new System.Windows.Forms.PictureBox();
            this.picRock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightYellow;
            this.label1.Location = new System.Drawing.Point(284, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose one to play";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblplayer
            // 
            this.lblplayer.AutoSize = true;
            this.lblplayer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblplayer.ForeColor = System.Drawing.Color.LightYellow;
            this.lblplayer.Location = new System.Drawing.Point(32, 542);
            this.lblplayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblplayer.Name = "lblplayer";
            this.lblplayer.Size = new System.Drawing.Size(118, 27);
            this.lblplayer.TabIndex = 5;
            this.lblplayer.Text = "Your result";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.ForeColor = System.Drawing.Color.LightYellow;
            this.lblResult.Location = new System.Drawing.Point(161, 542);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(36, 27);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = ": 0";
            // 
            // lblComputerResult
            // 
            this.lblComputerResult.AutoSize = true;
            this.lblComputerResult.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerResult.ForeColor = System.Drawing.Color.LightYellow;
            this.lblComputerResult.Location = new System.Drawing.Point(760, 542);
            this.lblComputerResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputerResult.Name = "lblComputerResult";
            this.lblComputerResult.Size = new System.Drawing.Size(36, 27);
            this.lblComputerResult.TabIndex = 8;
            this.lblComputerResult.Text = ": 0";
            // 
            // lblComputer
            // 
            this.lblComputer.AutoSize = true;
            this.lblComputer.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputer.ForeColor = System.Drawing.Color.LightYellow;
            this.lblComputer.Location = new System.Drawing.Point(579, 542);
            this.lblComputer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComputer.Name = "lblComputer";
            this.lblComputer.Size = new System.Drawing.Size(167, 27);
            this.lblComputer.TabIndex = 7;
            this.lblComputer.Text = "Computer result";
            this.lblComputer.Click += new System.EventHandler(this.lblComputer_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.InitialImage = global::RockPaperScissor.Properties.Resources.rock;
            this.picPlayer.Location = new System.Drawing.Point(37, 347);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(176, 154);
            this.picPlayer.TabIndex = 10;
            this.picPlayer.TabStop = false;
            // 
            // picComputer
            // 
            this.picComputer.InitialImage = null;
            this.picComputer.Location = new System.Drawing.Point(604, 347);
            this.picComputer.Margin = new System.Windows.Forms.Padding(4);
            this.picComputer.Name = "picComputer";
            this.picComputer.Size = new System.Drawing.Size(176, 154);
            this.picComputer.TabIndex = 9;
            this.picComputer.TabStop = false;
            // 
            // picPaper
            // 
            this.picPaper.Image = global::RockPaperScissor.Properties.Resources.paper1;
            this.picPaper.Location = new System.Drawing.Point(37, 94);
            this.picPaper.Margin = new System.Windows.Forms.Padding(4);
            this.picPaper.Name = "picPaper";
            this.picPaper.Size = new System.Drawing.Size(176, 154);
            this.picPaper.TabIndex = 2;
            this.picPaper.TabStop = false;
            this.picPaper.Click += new System.EventHandler(this.player_click);
            // 
            // picScissor
            // 
            this.picScissor.Image = global::RockPaperScissor.Properties.Resources.scissor;
            this.picScissor.Location = new System.Drawing.Point(331, 94);
            this.picScissor.Margin = new System.Windows.Forms.Padding(4);
            this.picScissor.Name = "picScissor";
            this.picScissor.Size = new System.Drawing.Size(176, 154);
            this.picScissor.TabIndex = 1;
            this.picScissor.TabStop = false;
            this.picScissor.Click += new System.EventHandler(this.player_click);
            // 
            // picRock
            // 
            this.picRock.Image = global::RockPaperScissor.Properties.Resources.hands_and_gestures__1_;
            this.picRock.Location = new System.Drawing.Point(604, 94);
            this.picRock.Margin = new System.Windows.Forms.Padding(4);
            this.picRock.Name = "picRock";
            this.picRock.Size = new System.Drawing.Size(176, 154);
            this.picRock.TabIndex = 0;
            this.picRock.TabStop = false;
            this.picRock.Click += new System.EventHandler(this.player_click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(837, 614);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.picComputer);
            this.Controls.Add(this.lblComputerResult);
            this.Controls.Add(this.lblComputer);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblplayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picPaper);
            this.Controls.Add(this.picScissor);
            this.Controls.Add(this.picRock);
            this.ForeColor = System.Drawing.Color.DarkGreen;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPaper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScissor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picRock;
        private System.Windows.Forms.PictureBox picScissor;
        private System.Windows.Forms.PictureBox picPaper;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblplayer;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblComputerResult;
        private System.Windows.Forms.Label lblComputer;
        private System.Windows.Forms.PictureBox picComputer;
        private System.Windows.Forms.PictureBox picPlayer;
    }
}

