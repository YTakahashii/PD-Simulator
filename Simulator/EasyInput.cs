using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Simulator
{
    public partial class EasyInput : Form
    {
        private double[,] danborusize = {{27,20,30},{32,23,15},{35,25,20},{42,32,26},{50,35,35},{51,40,39},{52,50,38},{56,53,51},{80,60,30}};
        private double[,] lettersize = {{12,23.5,0},{9,20.5,0},{24,33.2,0},{21.6,27.7,0},{19.7,26.7,0},{19,24,0},{16.2,22.9,0}};
        private double[,] sagawasize = { { 42, 58, 40 }, { 32, 43, 25 }, { 26, 35, 19 }, { 20, 25, 15 }, { 26, 40, 13 }, { 21, 30, 10 }, { 12.4, 109.8, 10.3 }, { 12.4, 63.4, 10.3 }, { 13, 31, 5 }, { 15, 15, 49.5 }, { 15, 29.5, 49.5 }, { 19.5, 19.5, 52 }, { 13, 13, 36 }, { 13, 25, 36 }, { 14.5, 14.5, 40.5 }, { 24.5, 28.5, 40.5 }, { 11, 32, 40.5 }, { 8.5, 26, 37 }, { 11, 32, 40.5 }, { 8.2, 26, 32 }, { 17, 35, 47 }, { 41, 32, 0 }, { 32.5, 26, 0 }, { 25, 34, 0 } };
        private double[,] yamatosize = { { 35, 52, 29 }, { 32, 46, 29 }, { 27, 38, 29 }, { 23, 32, 15 }, { 20, 27, 13 }, { 16, 32, 45 }, { 12, 30, 35 }, { 10, 30, 48 }, { 8, 26, 42 }, { 6, 22, 33 }, { 17, 88, 17 }, { 12, 78, 12 }, { 14, 27, 44 }, { 14, 14, 44 }, { 13, 25, 36 }, { 13, 13, 36 }, { 46, 32, 0 }, { 35, 24, 0 } };
        private double _length1, _length2, _length3;


        public double length1
        {
            get
            {
                return _length1;
            }
        }
        public double length2
        {
            get
            {
                return _length2;
            }
        }
        public double length3
        {
            get
            {
                return _length3;
            }
        }

        public EasyInput()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _length1 = danborusize[cb_danboru.SelectedIndex, 0];
            _length2 = danborusize[cb_danboru.SelectedIndex, 1];
            _length3 = danborusize[cb_danboru.SelectedIndex, 2];
            this.Close();
        }

        private void cb_letter_SelectedIndexChanged(object sender, EventArgs e)
        {
            _length1 = lettersize[cb_letter.SelectedIndex, 0];
            _length2 = lettersize[cb_letter.SelectedIndex, 1];
            _length3 = lettersize[cb_letter.SelectedIndex, 2];
            this.Close();
        }

        private void cb_sagawa_SelectedIndexChanged(object sender, EventArgs e)
        {
            _length1 = sagawasize[cb_sagawa.SelectedIndex, 0];
            _length2 = sagawasize[cb_sagawa.SelectedIndex, 1];
            _length3 = sagawasize[cb_sagawa.SelectedIndex, 2];
            this.Close();
        }

        private void cb_yamato_SelectedIndexChanged(object sender, EventArgs e)
        {
            _length1 = yamatosize[cb_yamato.SelectedIndex, 0];
            _length2 = yamatosize[cb_yamato.SelectedIndex, 1];
            _length3 = yamatosize[cb_yamato.SelectedIndex, 2];
            this.Close();
        }

        private void EasyInput_Load(object sender, EventArgs e)
        {
            this.Top = (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2;
            this.Left = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
        }


    }
}
