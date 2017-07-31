namespace TeamASourceControl
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
            this.cboPlayer = new System.Windows.Forms.ComboBox();
            this.cboTeam = new System.Windows.Forms.ComboBox();
            this.btnAddPlayer = new System.Windows.Forms.Button();
            this.btnAddTeam = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnRegisterPlayer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdatePlayer = new System.Windows.Forms.Button();
            this.btnDeleteRegistration = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Player";
            // 
            // cboPlayer
            // 
            this.cboPlayer.FormattingEnabled = true;
            this.cboPlayer.Location = new System.Drawing.Point(223, 85);
            this.cboPlayer.Name = "cboPlayer";
            this.cboPlayer.Size = new System.Drawing.Size(327, 33);
            this.cboPlayer.TabIndex = 2;
            // 
            // cboTeam
            // 
            this.cboTeam.FormattingEnabled = true;
            this.cboTeam.Location = new System.Drawing.Point(223, 176);
            this.cboTeam.Name = "cboTeam";
            this.cboTeam.Size = new System.Drawing.Size(327, 33);
            this.cboTeam.TabIndex = 3;
            // 
            // btnAddPlayer
            // 
            this.btnAddPlayer.Location = new System.Drawing.Point(67, 290);
            this.btnAddPlayer.Name = "btnAddPlayer";
            this.btnAddPlayer.Size = new System.Drawing.Size(221, 93);
            this.btnAddPlayer.TabIndex = 4;
            this.btnAddPlayer.Text = "Add Player";
            this.btnAddPlayer.UseVisualStyleBackColor = true;
            // 
            // btnAddTeam
            // 
            this.btnAddTeam.Location = new System.Drawing.Point(333, 290);
            this.btnAddTeam.Name = "btnAddTeam";
            this.btnAddTeam.Size = new System.Drawing.Size(208, 93);
            this.btnAddTeam.TabIndex = 5;
            this.btnAddTeam.Text = "Add Team";
            this.btnAddTeam.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(320, 554);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 93);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnRegisterPlayer
            // 
            this.btnRegisterPlayer.Location = new System.Drawing.Point(67, 418);
            this.btnRegisterPlayer.Name = "btnRegisterPlayer";
            this.btnRegisterPlayer.Size = new System.Drawing.Size(221, 93);
            this.btnRegisterPlayer.TabIndex = 6;
            this.btnRegisterPlayer.Text = "Register Player";
            this.btnRegisterPlayer.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Team";
            // 
            // btnUpdatePlayer
            // 
            this.btnUpdatePlayer.Location = new System.Drawing.Point(320, 418);
            this.btnUpdatePlayer.Name = "btnUpdatePlayer";
            this.btnUpdatePlayer.Size = new System.Drawing.Size(221, 93);
            this.btnUpdatePlayer.TabIndex = 8;
            this.btnUpdatePlayer.Text = "Update Registration";
            this.btnUpdatePlayer.UseVisualStyleBackColor = true;
            // 
            // btnDeleteRegistration
            // 
            this.btnDeleteRegistration.Location = new System.Drawing.Point(67, 554);
            this.btnDeleteRegistration.Name = "btnDeleteRegistration";
            this.btnDeleteRegistration.Size = new System.Drawing.Size(221, 93);
            this.btnDeleteRegistration.TabIndex = 9;
            this.btnDeleteRegistration.Text = "Delete Registration";
            this.btnDeleteRegistration.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 722);
            this.Controls.Add(this.btnDeleteRegistration);
            this.Controls.Add(this.btnUpdatePlayer);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRegisterPlayer);
            this.Controls.Add(this.btnAddTeam);
            this.Controls.Add(this.btnAddPlayer);
            this.Controls.Add(this.cboTeam);
            this.Controls.Add(this.cboPlayer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPlayer;
        private System.Windows.Forms.ComboBox cboTeam;
        private System.Windows.Forms.Button btnAddPlayer;
        private System.Windows.Forms.Button btnAddTeam;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnRegisterPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUpdatePlayer;
        private System.Windows.Forms.Button btnDeleteRegistration;
    }
}

