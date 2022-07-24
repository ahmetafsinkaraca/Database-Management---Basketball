using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basketball
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dataSet11.Team' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamTableAdapter.Fill(this.dataSet11.Team);
            // TODO: Bu kod satırı 'dataSet11.Team' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamTableAdapter.Fill(this.dataSet11.Team);
            // TODO: Bu kod satırı 'dataSet1.Game' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gameTableAdapter.Fill(this.dataSet1.Game);
            // TODO: Bu kod satırı 'dataSet1.Coach' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
            // TODO: Bu kod satırı 'dataSet1.Player' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.playerTableAdapter.Fill(this.dataSet1.Player);
            // TODO: Bu kod satırı 'dataSet1.Team' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.teamTableAdapter.Fill(this.dataSet1.Team);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.teamTableAdapter.InsertQuery(textBox1.Text, textBox2.Text);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int P_ID;
            int.TryParse(textBox20.Text, out P_ID);
            if (P_ID <= 12 || P_ID >= 9)
            {
                int P_Age, T_ID;

                int.TryParse(textBox5.Text, out P_Age);
                int.TryParse(comboBox1.SelectedValue.ToString(), out T_ID);

                this.playerTableAdapter.InsertQuery(textBox3.Text, textBox4.Text, P_Age, T_ID);
                this.playerTableAdapter.Fill(this.dataSet1.Player);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int C_ID;
            int.TryParse(textBox21.Text, out C_ID);
            if (C_ID <= 3 || C_ID >= 1)
            {
                int C_Phone, T_ID;

                int.TryParse(textBox8.Text, out C_Phone);
                int.TryParse(comboBox2.SelectedValue.ToString(), out T_ID);

                this.coachTableAdapter.InsertQuery(textBox6.Text, textBox7.Text, C_Phone, textBox9.Text, T_ID);
                this.coachTableAdapter.Fill(this.dataSet1.Coach);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int G_ID;
            int.TryParse(textBox22.Text, out G_ID);
            if (G_ID <= 2 || G_ID >= 1)
            {
                int G_Date, G_Time, G_ScoreT1, G_ScoreT2, T_ID;
                int.TryParse(textBox12.Text, out G_Date);
                int.TryParse(textBox13.Text, out G_Time);
                int.TryParse(textBox14.Text, out G_ScoreT1);
                int.TryParse(textBox15.Text, out G_ScoreT2);
                int.TryParse(comboBox3.SelectedValue.ToString(), out T_ID);

                this.gameTableAdapter.InsertQuery(textBox10.Text, textBox11.Text, G_Date, G_Time, G_ScoreT1, G_ScoreT2, T_ID);
                this.gameTableAdapter.Fill(this.dataSet1.Game);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int T_ID;
            int.TryParse(textBox16.Text, out T_ID);

            this.teamTableAdapter.DeleteQuery(T_ID);
            this.teamTableAdapter.Fill(this.dataSet1.Team);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int P_ID;
            int.TryParse(textBox17.Text, out P_ID);

            this.playerTableAdapter.DeleteQuery(P_ID);
            this.playerTableAdapter.Fill(this.dataSet1.Player);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int C_ID;
            int.TryParse(textBox18.Text, out C_ID);

            this.coachTableAdapter.DeleteQuery(C_ID);
            this.coachTableAdapter.Fill(this.dataSet1.Coach);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int G_ID;
            int.TryParse(textBox19.Text, out G_ID);

            this.gameTableAdapter.DeleteQuery(G_ID);
            this.gameTableAdapter.Fill(this.dataSet1.Game);
        }
    }
}
