﻿using Npgsql;
using System;
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
    public partial class BookingWindow : Form
    {
        public BookingWindow()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("tid", typeof(string));
            dt.Columns.Add("spelare_1", typeof(string));
            dt.Columns.Add("spelare_2", typeof(string));
            dt.Columns.Add("spelare_3", typeof(string));
            dt.Columns.Add("spelare_4", typeof(double));
            dt.Columns.Add("tävling", typeof(bool));
            dt.Columns.Add("övrigtUpptagen", typeof(bool));

            //Öppettider
            int openTime = 8;
            int closeTime = 18;

            //Nollställ time_comboBox
            time_comboBox.Items.Clear();

            //Fyll alla tider i tabellen
            for (int h = openTime; h < closeTime; h++)
            {
                for (int m = 0; m < 6; m++)
                {
                    //Ny rad
                    DataRow dr = dt.NewRow();
                    
                    //Skapa tider
                    String hour = h.ToString().PadLeft(2, '0');
                    String minute = m.ToString().PadRight(2, '0');
                    String tid = hour + ':' + minute;

                    time_comboBox.Items.Add(tid);
                    dr["tid"] = tid;

                    dt.Rows.Add(dr);
                }
            }

            //Hämta datum
            DateTime datum = new DateTime(
                monthCalendar.SelectionStart.Year,
                monthCalendar.SelectionStart.Month,
                monthCalendar.SelectionStart.Day,
                0,
                0,
                0);

            String sql = "SELECT * FROM \"bokning\" WHERE datumtid::text LIKE '" + datum.Year.ToString() + "-" + datum.Month.ToString().PadLeft(2, '0') + "-" + datum.Day.ToString().PadLeft(2, '0') + "%';";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                //dr["golfId"] = ndr["Golf-ID"];

                String filter = "tid = '" + ndr["datumtid"].ToString().Substring(10, 2) + ":" + ndr["datumtid"].ToString().Substring(13, 2) + "'";
                DataRow[] row = dt.Select(filter);
                if (row.Length > 0)
                {
                    row[0]["spelare_1"] = ndr["spelare_1"];
                    row[0]["spelare_2"] = ndr["spelare_2"];
                    row[0]["spelare_3"] = ndr["spelare_3"];
                    row[0]["spelare_4"] = ndr["spelare_4"];
                    row[0]["tävling"] = ndr["tävling_id"].ToString().Length > 0;
                    row[0]["övrigtUpptagen"] = ndr["notering"].ToString().Length > 0;
                }
            }
            ndr.Close();
        
            //dt.Columns.RemoveAt(3);

            DataView dv = new DataView(dt);
            //dv.RowFilter = "golfId LIKE '" + golfId_textBox.Text + "*' AND firstName LIKE '" + firstName_textBox.Text + "*' AND lastName LIKE '" + lastName_textBox.Text + "*'";

            //Set the component data
            dataGridView.DataSource = dv;

            //Set column header text
            dataGridView.Columns[0].HeaderText = "Tid";
            dataGridView.Columns[1].HeaderText = "Spelare 1";
            dataGridView.Columns[2].HeaderText = "Spelare 2";
            dataGridView.Columns[3].HeaderText = "Spelare 3";
            dataGridView.Columns[4].HeaderText = "Spelare 4";
            dataGridView.Columns[5].HeaderText = "Tävling";
            dataGridView.Columns[6].HeaderText = "Upptagen";
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            var bf = new BookingForm();
            bf.Date = monthCalendar.SelectionStart;
            bf.ShowDialog();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateTable();
        }
    }
}
