using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Microsoft.VisualBasic;
using System.Globalization;
using System.IO;
using System.Diagnostics;

namespace Simulator
{
    public partial class Form1 : Form
    {
        private Yamato yamato;
        private Sagawa sagawa;
        private Yupack yupack;
        private DispResult dr;
        private Info info;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            Form2 fm2 = new Form2();
            fm2.ShowDialog();
            fm2.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sumlength, weight;
            try{
                sumlength = double.Parse(tb_length1.Text) + double.Parse(tb_length2.Text) + double.Parse(tb_length3.Text);
            }catch{
                MessageBox.Show("3辺の長さを入力してください。","入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try{
                weight = double.Parse(tb_weight.Text);
            }catch{
                MessageBox.Show("重さを入力してください","入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            /*各会社のインスタンス*/
            yamato = new Yamato(comboBox1.Text, comboBox2.Text, sumlength, weight);
            sagawa = new Sagawa(comboBox1.Text, comboBox2.Text, sumlength, weight);
            yupack = new Yupack(comboBox1.Text, comboBox2.Text, sumlength, weight);

            if (yamato.Init(rb_cool.Checked)){
                textBox1.Text += yamato.name + yamato.getErrorMessage() + Environment.NewLine;
            }else{
                if (checkBoxYamato.Checked){
                    textBox1.Text += yamato.name + yamato.charge.ToString() +Environment.NewLine;
                }
            }

            if (sagawa.Init(rb_cool.Checked)){
                textBox1.Text += sagawa.name + sagawa.getErrorMessage() + Environment.NewLine;
            }else{
                if(checkBoxHikyaku.Checked) textBox1.Text += sagawa.name + sagawa.charge.ToString() + Environment.NewLine;
            }

            if (yupack.Init(rb_cool.Checked)){
                textBox1.Text += yupack.name + yupack.getErrorMessage() + Environment.NewLine;
            }else{
                if(checkBoxYupack.Checked) textBox1.Text += yupack.name + yupack.charge.ToString() + Environment.NewLine;
            }
            SaveLog();
            dr = new DispResult(yamato.charge, sagawa.charge, yupack.charge,comboBox1.Text,comboBox2.Text,rb_cool.Checked);
            dr.ShowDialog(this);
            dr.Dispose();
        }

        private void SaveLog()
        {
            info = new Info(DateTime.Now);
            info.sender = comboBox1.Text;
            info.receiver = comboBox2.Text;
            info.length1 = tb_length1.Text;
            info.length2 = tb_length2.Text;
            info.length3 = tb_length3.Text;
            info.weight = tb_weight.Text;
            info.isCool = rb_cool.Checked;
            info.SaveHistry();
        }

        public void setData(string sender, string receiver, string length1, string length2, string length3, string weight, string option)
        {
            comboBox1.Text = sender;
            comboBox2.Text = receiver;
            tb_length1.Text = length1;
            tb_length2.Text = length2;
            tb_length3.Text = length3;
            tb_weight.Text = weight;
            if(option == "クール便"){
                rb_cool.Checked = true;
                rb_normal.Checked = false;
            }else{
                rb_cool.Checked = false;
                rb_normal.Checked = true;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBoxHikyaku_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void かんたん設定ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EasyInput ei = new EasyInput();
            ei.ShowDialog();
            ei.Dispose();
            tb_length1.Text = ei.length1.ToString();
            tb_length2.Text = ei.length2.ToString();
            tb_length3.Text = ei.length3.ToString();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void 終了XToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr;

            dr = MessageBox.Show("終了してよろしいですか？", "終了確認", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Environment.Exit(0);
        }

        private void readmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try{
                Process.Start("NotePad", @"readme.txt");
            }catch{
                MessageBox.Show("readme.txtを参照できません。","エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void 過去ログを表示ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchHistry sh = new SearchHistry(this);
            sh.ShowDialog();
            sh.Dispose();
        }
    }
}

