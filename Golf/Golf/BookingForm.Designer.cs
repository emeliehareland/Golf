﻿namespace Golf
{
    partial class BookingForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.time_comboBox = new System.Windows.Forms.ComboBox();
            this.date_textBox = new System.Windows.Forms.TextBox();
            this.action_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.player4_findPlayer = new Golf.FindPlayerComponent();
            this.player3_findPlayer = new Golf.FindPlayerComponent();
            this.player2_findPlayer = new Golf.FindPlayerComponent();
            this.player1_findPlayer = new Golf.FindPlayerComponent();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Datum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tid";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(24, 48);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 2;
            this.monthCalendar.Visible = false;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // time_comboBox
            // 
            this.time_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.time_comboBox.FormattingEnabled = true;
            this.time_comboBox.Items.AddRange(new object[] {
            "00:00",
            "00:10",
            "00:20",
            "00:30",
            "00:40",
            "00:50",
            "01:00",
            "01:10",
            "01:20",
            "01:30",
            "01:40",
            "01:50",
            "02:00",
            "02:10",
            "02:20",
            "02:30",
            "02:40",
            "02:50",
            "03:00",
            "03:10",
            "03:20",
            "03:30",
            "03:40",
            "03:50",
            "04:00",
            "04:10",
            "04:20",
            "04:30",
            "04:40",
            "04:50",
            "05:00",
            "05:10",
            "05:20",
            "05:30",
            "05:40",
            "05:50",
            "06:00",
            "06:10",
            "06:20",
            "06:30",
            "06:40",
            "06:50",
            "07:00",
            "07:10",
            "07:20",
            "07:30",
            "07:40",
            "07:50",
            "08:00",
            "08:10",
            "08:20",
            "08:30",
            "08:40",
            "08:50",
            "09:00",
            "09:10",
            "09:20",
            "09:30",
            "09:40",
            "09:50",
            "10:00",
            "10:10",
            "10:20",
            "10:30",
            "10:40",
            "10:50",
            "11:00",
            "11:10",
            "11:20",
            "11:30",
            "11:40",
            "11:50",
            "12:00",
            "12:10",
            "12:20",
            "12:30",
            "12:40",
            "12:50",
            "13:00",
            "13:10",
            "13:20",
            "13:30",
            "13:40",
            "13:50",
            "14:00",
            "14:10",
            "14:20",
            "14:30",
            "14:40",
            "14:50",
            "15:00",
            "15:10",
            "15:20",
            "15:30",
            "15:40",
            "15:50",
            "16:00",
            "16:10",
            "16:20",
            "16:30",
            "16:40",
            "16:50",
            "17:00",
            "17:10",
            "17:20",
            "17:30",
            "17:40",
            "17:50",
            "18:00",
            "18:10",
            "18:20",
            "18:30",
            "18:40",
            "18:50",
            "19:00",
            "19:10",
            "19:20",
            "19:30",
            "19:40",
            "19:50",
            "20:00",
            "20:10",
            "20:20",
            "20:30",
            "20:40",
            "20:50",
            "21:00",
            "21:10",
            "21:20",
            "21:30",
            "21:40",
            "21:50",
            "22:00",
            "22:10",
            "22:20",
            "22:30",
            "22:40",
            "22:50",
            "23:00",
            "23:10",
            "23:20",
            "23:30",
            "23:40",
            "23:50"});
            this.time_comboBox.Location = new System.Drawing.Point(189, 26);
            this.time_comboBox.Name = "time_comboBox";
            this.time_comboBox.Size = new System.Drawing.Size(62, 21);
            this.time_comboBox.TabIndex = 3;
            this.time_comboBox.SelectedIndexChanged += new System.EventHandler(this.time_comboBox_SelectedIndexChanged);
            // 
            // date_textBox
            // 
            this.date_textBox.Location = new System.Drawing.Point(24, 25);
            this.date_textBox.Name = "date_textBox";
            this.date_textBox.Size = new System.Drawing.Size(159, 22);
            this.date_textBox.TabIndex = 4;
            this.date_textBox.Enter += new System.EventHandler(this.date_textBox_Enter);
            this.date_textBox.Leave += new System.EventHandler(this.date_textBox_Leave);
            // 
            // action_button
            // 
            this.action_button.Location = new System.Drawing.Point(391, 416);
            this.action_button.Name = "action_button";
            this.action_button.Size = new System.Drawing.Size(107, 23);
            this.action_button.TabIndex = 24;
            this.action_button.Text = "Action";
            this.action_button.UseVisualStyleBackColor = true;
            this.action_button.Click += new System.EventHandler(this.action_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.Location = new System.Drawing.Point(12, 416);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(75, 23);
            this.cancel_button.TabIndex = 23;
            this.cancel_button.Text = "Avbryt";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // player4_findPlayer
            // 
            this.player4_findPlayer.GolfId = "";
            this.player4_findPlayer.Location = new System.Drawing.Point(258, 222);
            this.player4_findPlayer.Member = null;
            this.player4_findPlayer.Name = "player4_findPlayer";
            this.player4_findPlayer.Size = new System.Drawing.Size(240, 163);
            this.player4_findPlayer.TabIndex = 7;
            this.player4_findPlayer.TitleText = "Spelare 4";
            this.player4_findPlayer.Load += new System.EventHandler(this.player3_findPlayer_Load);
            // 
            // player3_findPlayer
            // 
            this.player3_findPlayer.GolfId = "";
            this.player3_findPlayer.Location = new System.Drawing.Point(12, 222);
            this.player3_findPlayer.Member = null;
            this.player3_findPlayer.Name = "player3_findPlayer";
            this.player3_findPlayer.Size = new System.Drawing.Size(240, 163);
            this.player3_findPlayer.TabIndex = 7;
            this.player3_findPlayer.TitleText = "Spelare 3";
            this.player3_findPlayer.Load += new System.EventHandler(this.player3_findPlayer_Load);
            // 
            // player2_findPlayer
            // 
            this.player2_findPlayer.GolfId = "";
            this.player2_findPlayer.Location = new System.Drawing.Point(258, 53);
            this.player2_findPlayer.Member = null;
            this.player2_findPlayer.Name = "player2_findPlayer";
            this.player2_findPlayer.Size = new System.Drawing.Size(240, 163);
            this.player2_findPlayer.TabIndex = 6;
            this.player2_findPlayer.TitleText = "Spelare 2";
            // 
            // player1_findPlayer
            // 
            this.player1_findPlayer.GolfId = "";
            this.player1_findPlayer.Location = new System.Drawing.Point(12, 53);
            this.player1_findPlayer.Member = null;
            this.player1_findPlayer.Name = "player1_findPlayer";
            this.player1_findPlayer.Size = new System.Drawing.Size(240, 163);
            this.player1_findPlayer.TabIndex = 5;
            this.player1_findPlayer.TitleText = "Spelare 1";
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 451);
            this.Controls.Add(this.action_button);
            this.Controls.Add(this.cancel_button);
            this.Controls.Add(this.player4_findPlayer);
            this.Controls.Add(this.player3_findPlayer);
            this.Controls.Add(this.player2_findPlayer);
            this.Controls.Add(this.date_textBox);
            this.Controls.Add(this.time_comboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.player1_findPlayer);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Bokning";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox time_comboBox;
        private System.Windows.Forms.TextBox date_textBox;
        private FindPlayerComponent player1_findPlayer;
        private FindPlayerComponent player2_findPlayer;
        private FindPlayerComponent player3_findPlayer;
        private FindPlayerComponent player4_findPlayer;
        private System.Windows.Forms.Button action_button;
        private System.Windows.Forms.Button cancel_button;
    }
}