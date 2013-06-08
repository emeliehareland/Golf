﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; 

namespace Golf
{
    public partial class SeAlla : Form
    {
        public SeAlla()
        {
            InitializeComponent();
            uppdateralista(); 
        }

        private void sealla_Load(object sender, EventArgs e)
        {
        }

        public void uppdateralista()
        {
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("golf_id", typeof(string));
            dt.Columns.Add("förnamn", typeof(string));
            dt.Columns.Add("efternamn", typeof(string));
            dt.Columns.Add("handicap", typeof(string));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("betaltÅr", typeof(string));
            dt.Columns.Add("adress", typeof(string));
            dt.Columns.Add("stad", typeof(string));
            dt.Columns.Add("telefonnummer", typeof(string));
            dt.Columns.Add("epost", typeof(string));

            String sql = "select    medlem.golf_id,     medlem.\"förnamn\",     medlem.efternamn,   medlem.handicap,    status.namn,   medlem.\"betaltÅr\",      medlem.adress,      medlem.stad,    medlem.postnummer,      medlem.telefonnummer,    medlem.epost    from    medlem, status    where   medlem.status_id = status.status_id;";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader drv = command.ExecuteReader();

            while (drv.Read())
            {
                DataRow row = dt.NewRow();
                row["golf_id"] = drv["golf_id"].ToString();
                row["förnamn"] = drv["förnamn"].ToString();
                row["efternamn"] = drv["efternamn"].ToString();
                row["handicap"] = drv["handicap"].ToString();
                row["status"] = drv["namn"].ToString();
                row["betaltÅr"] = drv["betaltÅr"].ToString();
                row["adress"] = drv["adress"].ToString();
                row["stad"] = drv["stad"].ToString();
                row["telefonnummer"] = drv["telefonnummer"].ToString();
                row["epost"] = drv["epost"].ToString();

                dt.Rows.Add(row);
            }
            drv.Close();

            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
        }



        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int nummer = dataGridView1.CurrentRow.Index; 
            MessageBox.Show(Convert.ToString(nummer));

            String sql = "select golf_id from medlem;";
            NpgsqlCommand command3 = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader drg = command3.ExecuteReader();

            string idet = "";
            int raknare = 0; 
            while (drg.Read())
            {
                if (raknare == nummer)
                {
                    idet = drg["golf_id"].ToString();
                }
                raknare = raknare + 1;
            }

            drg.Close();

            MessageBox.Show(idet);


            String sql2 = "delete from medlem where golf_id = '" + idet + "';";
            NpgsqlCommand command4 = new NpgsqlCommand(sql2, GolfReception.conn);
            command4.ExecuteNonQuery();

            uppdateralista(); 


        }


    }
}
