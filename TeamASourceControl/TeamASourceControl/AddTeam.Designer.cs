namespace TeamASourceControl
{
    partial class AddTeam
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCoachName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 53);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Team";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(184, 236);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 53);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(116, 44);
            this.txtTeamName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(155, 20);
            this.txtTeamName.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Team Name";
            // 
            // txtCoachName
            // 
            this.txtCoachName.Location = new System.Drawing.Point(116, 87);
            this.txtCoachName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.Size = new System.Drawing.Size(155, 20);
            this.txtCoachName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Coach";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(116, 162);
            this.txtContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(155, 20);
            this.txtContact.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Contact Number";
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(116, 121);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(155, 20);
            this.txtLocation.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Location";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(42, 294);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 47);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update Team";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(184, 294);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 47);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete Team";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // AddTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 365);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCoachName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTeamName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddTeam";
            this.Text = "AddTeam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCoachName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}