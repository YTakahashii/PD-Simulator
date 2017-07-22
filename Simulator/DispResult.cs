using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Simulator
{
    public partial class DispResult : Form
    {
        private string _sender, _receiver;
        private bool _cool = false;
        public DispResult(int yamato, int sagawa, int yupack, string sender, string receiver, bool cool)
        {
            InitializeComponent();

            tb_yamato.Text = yamato.ToString();
            tb_sagawa.Text = sagawa.ToString();
            tb_yupack.Text = yupack.ToString();
            _sender = sender;
            _receiver = receiver;
            _cool = cool;
        }

        private void DispResult_Load(object sender, EventArgs e)
        {
        }

        private void テキストファイルに保存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            using (Stream fileStream = saveFileDialog1.OpenFile())
            using (StreamWriter sr = new StreamWriter(fileStream)) {
                string message = "";
                if(_cool){
                    message += "クール便" + Environment.NewLine;
                }else{
                    message += "通常配達" + Environment.NewLine;
                }
                message += _sender + " から " + _receiver + " まで " + Environment.NewLine;
                message += "ヤマト運輸：" + tb_yamato.Text + "円" + Environment.NewLine;
                message += "飛脚宅配便：" + tb_sagawa.Text + "円" + Environment.NewLine;
                message += "ゆうパック：" + tb_yupack.Text + "円" + Environment.NewLine;
                sr.Write(message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_yamato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
