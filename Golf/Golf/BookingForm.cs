﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf
{
    public partial class BookingForm : Form
    {
        public DateTime Date
        {
            get { return monthCalendar.SelectionStart; }
            set 
            { 
                monthCalendar.SetDate(value);
                DateChanged();
            }
        }

        public String Time
        {
            get { return time_comboBox.Items[time_comboBox.SelectedIndex].ToString(); }
            set
            {
                for (int i = 0; i < time_comboBox.Items.Count; i++)
                {
                    if (time_comboBox.Items[i].ToString().Equals(value))
                    {
                        time_comboBox.SelectedIndex = i;
                    }
                }
            }
        }

        public BookingForm()
        {
            InitializeComponent();
        }


        private void player3_findPlayer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void date_textBox_Enter(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
        }

        private void date_textBox_Leave(object sender, EventArgs e)
        {
            monthCalendar.Visible = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateChanged();
        }

        private void DateChanged()
        {
            date_textBox.Text = monthCalendar.SelectionStart.ToLongDateString();
            monthCalendar.Visible = false;
        }

        private void time_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
