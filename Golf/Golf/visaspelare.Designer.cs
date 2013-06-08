﻿namespace Golf
{
    partial class VisaSpelare
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
            this.label11 = new System.Windows.Forms.Label();
            this.gender_comboBox = new System.Windows.Forms.ComboBox();
            this.action_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.handicap_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.postort_textBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.postnummer_textBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adress_textBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.epost_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.telefonnummer_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fornamn_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.efternamn_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.golfid_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.val_comboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.betalt_textBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.medlemsstatus_comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(31, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 74;
            this.label11.Text = "Kön";
            // 
            // gender_comboBox
            // 
            this.gender_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gender_comboBox.FormattingEnabled = true;
            this.gender_comboBox.Items.AddRange(new object[] {
            "Man",
            "Kvinna"});
            this.gender_comboBox.Location = new System.Drawing.Point(34, 223);
            this.gender_comboBox.Name = "gender_comboBox";
            this.gender_comboBox.Size = new System.Drawing.Size(75, 21);
            this.gender_comboBox.TabIndex = 73;
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(281, 378);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(75, 23);
            this.action_button.TabIndex = 72;
            this.action_button.Text = "OK";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(362, 378);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 71;
            this.cancel_button.Text = "Avbryt";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // handicap_textBox
            // 
            this.handicap_textBox.Location = new System.Drawing.Point(34, 77);
            this.handicap_textBox.Name = "handicap_textBox";
            this.handicap_textBox.Size = new System.Drawing.Size(57, 20);
            this.handicap_textBox.TabIndex = 70;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 61);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "Handicap";
            // 
            // postort_textBox
            // 
            this.postort_textBox.Location = new System.Drawing.Point(318, 77);
            this.postort_textBox.Name = "postort_textBox";
            this.postort_textBox.Size = new System.Drawing.Size(108, 20);
            this.postort_textBox.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "Stad";
            // 
            // postnummer_textBox
            // 
            this.postnummer_textBox.Location = new System.Drawing.Point(219, 77);
            this.postnummer_textBox.Name = "postnummer_textBox";
            this.postnummer_textBox.Size = new System.Drawing.Size(93, 20);
            this.postnummer_textBox.TabIndex = 66;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(216, 61);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Postnummer";
            // 
            // adress_textBox
            // 
            this.adress_textBox.Location = new System.Drawing.Point(219, 36);
            this.adress_textBox.Name = "adress_textBox";
            this.adress_textBox.Size = new System.Drawing.Size(207, 20);
            this.adress_textBox.TabIndex = 64;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 63;
            this.label6.Text = "Address";
            // 
            // epost_textBox
            // 
            this.epost_textBox.Location = new System.Drawing.Point(219, 182);
            this.epost_textBox.Name = "epost_textBox";
            this.epost_textBox.Size = new System.Drawing.Size(207, 20);
            this.epost_textBox.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 61;
            this.label5.Text = "E-post";
            // 
            // telefonnummer_textBox
            // 
            this.telefonnummer_textBox.Location = new System.Drawing.Point(219, 141);
            this.telefonnummer_textBox.Name = "telefonnummer_textBox";
            this.telefonnummer_textBox.Size = new System.Drawing.Size(207, 20);
            this.telefonnummer_textBox.TabIndex = 60;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 59;
            this.label4.Text = "Telefonnummer";
            // 
            // fornamn_textBox
            // 
            this.fornamn_textBox.Location = new System.Drawing.Point(34, 141);
            this.fornamn_textBox.Name = "fornamn_textBox";
            this.fornamn_textBox.Size = new System.Drawing.Size(147, 20);
            this.fornamn_textBox.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 57;
            this.label3.Text = "Efternamn";
            // 
            // efternamn_textBox
            // 
            this.efternamn_textBox.Location = new System.Drawing.Point(34, 182);
            this.efternamn_textBox.Name = "efternamn_textBox";
            this.efternamn_textBox.Size = new System.Drawing.Size(147, 20);
            this.efternamn_textBox.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 55;
            this.label2.Text = "Förnamn";
            // 
            // golfid_textBox
            // 
            this.golfid_textBox.Location = new System.Drawing.Point(34, 36);
            this.golfid_textBox.Name = "golfid_textBox";
            this.golfid_textBox.Size = new System.Drawing.Size(147, 20);
            this.golfid_textBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Golf-ID";
            // 
            // val_comboBox
            // 
            this.val_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.val_comboBox.FormattingEnabled = true;
            this.val_comboBox.Items.AddRange(new object[] {
            "Visa tävlingsinformation",
            "Ändra medlem",
            "Ta bort medlem"});
            this.val_comboBox.Location = new System.Drawing.Point(34, 347);
            this.val_comboBox.Name = "val_comboBox";
            this.val_comboBox.Size = new System.Drawing.Size(121, 21);
            this.val_comboBox.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 376);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 79;
            this.button1.Text = "Utför";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(28, 331);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(63, 13);
            this.label19.TabIndex = 149;
            this.label19.Text = "Välj åtgärd: ";
            // 
            // betalt_textBox
            // 
            this.betalt_textBox.Location = new System.Drawing.Point(219, 275);
            this.betalt_textBox.Name = "betalt_textBox";
            this.betalt_textBox.Size = new System.Drawing.Size(147, 20);
            this.betalt_textBox.TabIndex = 155;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 259);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 154;
            this.label9.Text = "Betalt år: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(31, 259);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 153;
            this.label12.Text = "Medlemsstatus";
            // 
            // medlemsstatus_comboBox
            // 
            this.medlemsstatus_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.medlemsstatus_comboBox.FormattingEnabled = true;
            this.medlemsstatus_comboBox.Items.AddRange(new object[] {
            "Aktiv",
            "Vilande",
            "Greenfee",
            "Junior",
            "Ickemedlem"});
            this.medlemsstatus_comboBox.Location = new System.Drawing.Point(34, 275);
            this.medlemsstatus_comboBox.Name = "medlemsstatus_comboBox";
            this.medlemsstatus_comboBox.Size = new System.Drawing.Size(147, 21);
            this.medlemsstatus_comboBox.TabIndex = 150;
            // 
            // VisaSpelare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 405);
            this.Controls.Add(this.betalt_textBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.medlemsstatus_comboBox);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.val_comboBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gender_comboBox);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.handicap_textBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.postort_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.postnummer_textBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.adress_textBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.epost_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefonnummer_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fornamn_textBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.efternamn_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.golfid_textBox);
            this.Controls.Add(this.label1);
            this.Name = "VisaSpelare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "andraspelare";
            this.Load += new System.EventHandler(this.visaspelare_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox gender_comboBox;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox handicap_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox postort_textBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox postnummer_textBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox adress_textBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox epost_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox telefonnummer_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fornamn_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox efternamn_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox golfid_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox val_comboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox betalt_textBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox medlemsstatus_comboBox;
    }
}