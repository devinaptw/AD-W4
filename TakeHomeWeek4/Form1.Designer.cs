namespace TakeHomeWeek4
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
            this.lbPlayer = new System.Windows.Forms.ListBox();
            this.comboAddPlayer = new System.Windows.Forms.ComboBox();
            this.newTeamName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.newPlayerName = new System.Windows.Forms.TextBox();
            this.comboListTeam = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cbPlayerName = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rmPlayer = new System.Windows.Forms.Button();
            this.comboDeleteTeam = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.newPlayerNum = new System.Windows.Forms.TextBox();
            this.newPlayerPos = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPlayer
            // 
            this.lbPlayer.FormattingEnabled = true;
            this.lbPlayer.ItemHeight = 16;
            this.lbPlayer.Location = new System.Drawing.Point(379, 14);
            this.lbPlayer.Name = "lbPlayer";
            this.lbPlayer.Size = new System.Drawing.Size(298, 116);
            this.lbPlayer.TabIndex = 0;
            // 
            // comboAddPlayer
            // 
            this.comboAddPlayer.FormattingEnabled = true;
            this.comboAddPlayer.Location = new System.Drawing.Point(107, 39);
            this.comboAddPlayer.Name = "comboAddPlayer";
            this.comboAddPlayer.Size = new System.Drawing.Size(144, 24);
            this.comboAddPlayer.TabIndex = 1;
            // 
            // newTeamName
            // 
            this.newTeamName.Location = new System.Drawing.Point(107, 10);
            this.newTeamName.Name = "newTeamName";
            this.newTeamName.Size = new System.Drawing.Size(144, 22);
            this.newTeamName.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.newTeamName);
            this.panel1.Location = new System.Drawing.Point(12, 194);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 45);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(560, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Team";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.newPlayerPos);
            this.panel2.Controls.Add(this.newPlayerNum);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.newPlayerName);
            this.panel2.Controls.Add(this.comboAddPlayer);
            this.panel2.Location = new System.Drawing.Point(12, 274);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(690, 103);
            this.panel2.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Team";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(560, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Add Player";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // newPlayerName
            // 
            this.newPlayerName.Location = new System.Drawing.Point(379, 10);
            this.newPlayerName.Name = "newPlayerName";
            this.newPlayerName.Size = new System.Drawing.Size(139, 22);
            this.newPlayerName.TabIndex = 3;
            // 
            // comboListTeam
            // 
            this.comboListTeam.FormattingEnabled = true;
            this.comboListTeam.Location = new System.Drawing.Point(107, 14);
            this.comboListTeam.Name = "comboListTeam";
            this.comboListTeam.Size = new System.Drawing.Size(139, 24);
            this.comboListTeam.TabIndex = 7;
            this.comboListTeam.SelectedIndexChanged += new System.EventHandler(this.comboListTeam_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Add New Team";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Add Player to Team";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.lbPlayer);
            this.panel3.Controls.Add(this.comboListTeam);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(690, 145);
            this.panel3.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(278, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 16);
            this.label10.TabIndex = 8;
            this.label10.Text = "List of Player";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Select Team";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 390);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(173, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Delete Player From a Team";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel4.Controls.Add(this.cbPlayerName);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.rmPlayer);
            this.panel4.Controls.Add(this.comboDeleteTeam);
            this.panel4.Location = new System.Drawing.Point(13, 416);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(690, 45);
            this.panel4.TabIndex = 7;
            // 
            // cbPlayerName
            // 
            this.cbPlayerName.FormattingEnabled = true;
            this.cbPlayerName.Location = new System.Drawing.Point(379, 9);
            this.cbPlayerName.Name = "cbPlayerName";
            this.cbPlayerName.Size = new System.Drawing.Size(139, 24);
            this.cbPlayerName.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(275, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Player Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "Select Team";
            // 
            // rmPlayer
            // 
            this.rmPlayer.Location = new System.Drawing.Point(561, 10);
            this.rmPlayer.Name = "rmPlayer";
            this.rmPlayer.Size = new System.Drawing.Size(116, 23);
            this.rmPlayer.TabIndex = 4;
            this.rmPlayer.Text = "Remove Player";
            this.rmPlayer.UseVisualStyleBackColor = true;
            this.rmPlayer.Click += new System.EventHandler(this.rmPlayer_Click);
            // 
            // comboDeleteTeam
            // 
            this.comboDeleteTeam.FormattingEnabled = true;
            this.comboDeleteTeam.Location = new System.Drawing.Point(106, 10);
            this.comboDeleteTeam.Name = "comboDeleteTeam";
            this.comboDeleteTeam.Size = new System.Drawing.Size(144, 24);
            this.comboDeleteTeam.TabIndex = 1;
            this.comboDeleteTeam.SelectedIndexChanged += new System.EventHandler(this.comboDeleteTeam_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(275, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 16);
            this.label11.TabIndex = 7;
            this.label11.Text = "Player Num";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(275, 71);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 16);
            this.label12.TabIndex = 8;
            this.label12.Text = "Player Pos";
            // 
            // newPlayerNum
            // 
            this.newPlayerNum.Location = new System.Drawing.Point(379, 40);
            this.newPlayerNum.Name = "newPlayerNum";
            this.newPlayerNum.Size = new System.Drawing.Size(139, 22);
            this.newPlayerNum.TabIndex = 9;
            // 
            // newPlayerPos
            // 
            this.newPlayerPos.Location = new System.Drawing.Point(380, 68);
            this.newPlayerPos.Name = "newPlayerPos";
            this.newPlayerPos.Size = new System.Drawing.Size(139, 22);
            this.newPlayerPos.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(715, 471);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPlayer;
        private System.Windows.Forms.ComboBox comboAddPlayer;
        private System.Windows.Forms.TextBox newTeamName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox newPlayerName;
        private System.Windows.Forms.ComboBox comboListTeam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbPlayerName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button rmPlayer;
        private System.Windows.Forms.ComboBox comboDeleteTeam;
        private System.Windows.Forms.TextBox newPlayerPos;
        private System.Windows.Forms.TextBox newPlayerNum;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

