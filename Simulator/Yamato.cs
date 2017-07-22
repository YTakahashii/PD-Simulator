using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace Simulator
{
    public partial class Yamato
    {
        public csvReader cr;
        public int row, col;
        private string sender_text, receiver_text;
        private double sumlength, weight;
        private string errorMessage = "";
        public string name = "ヤマト宅急便　";
        private const int ERROR_NUM = 99999;
        private const string ERROR_STR = "ERROR";
        public int[] cool = { 216, 216, 324, 648,0,0 }; //60,80,100,120
        private int _charge;
        public int charge
        {
            get { return _charge; }
            set { _charge = value;}
        }
        public Yamato(string sender_comboBox, string receiver_comboBox, double sumlength_textBox, double weight_textBox)
        {
            sender_text = sender_comboBox;
            receiver_text = receiver_comboBox;
            sumlength = sumlength_textBox;
            weight = weight_textBox;
            errorMessage = "";
        }

        public bool Init(bool usecool)
        {
            int row_Length, row_Weight;
            bool errorflg = false;
            row_Length = DecisonRowLength(sumlength);
            row_Weight = DecisionRowWight(weight);

            if(row_Length > row_Weight){
                row = row_Length;
            }else{
                row = row_Weight;
            }
            col = DecisionColmun(receiver_text);


            if (DecisonRowLength(sumlength) == ERROR_NUM){
                errorMessage += "３辺の長さ, ";
                errorflg = true;
            }if(DecisionRowWight(weight) == ERROR_NUM){
                errorMessage += "重さ, ";
                errorflg = true;
            }if((DecisionTable(sender_text)) == ERROR_STR){
                errorMessage += "差出地, ";
                errorflg = true;
            }if((DecisionColmun(receiver_text)) == ERROR_NUM){
                errorMessage += "宛先県, ";
                errorflg = true;
            }
            if(errorflg){
                errorMessage += " の入力に不備があります。";
                MessageBox.Show(errorMessage);
                return true;
            }else{
                Encoding encode = Encoding.GetEncoding("shift_jis");
                string CurrentDir = Environment.CurrentDirectory;
                cr = new csvReader(CurrentDir + "/charge/YAMATO/" + DecisionTable(sender_text) + ".csv", encode);
                if(usecool){
                    _charge = int.Parse(cr.table[row, col], NumberStyles.AllowThousands) + cool[row];
                }else{
                    _charge = int.Parse(cr.table[row, col], NumberStyles.AllowThousands);
                }
                return false;
            }
        }
        
        public string getErrorMessage()
        {
            return errorMessage;
        }

        private string DecisionTable(string sender)
        {
            string result = "";
            switch (sender)
            {
                case "北海道":
                    result = "HOKKAIDO";
                    break;
                case "青森":
                    result = "KTOHOKU";
                    break;
                case "秋田":
                    result = "KTOHOKU";
                    break;
                case "岩手":
                    result = "KTOHOKU";
                    break;
                case "宮城":
                    result = "MTOHOKU";
                    break;
                case "山形":
                    result = "MTOHOKU";
                    break;
                case "福島":
                    result = "MTOHOKU";
                    break;
                case "茨城":
                    result = "KANTO";
                    break;
                case "栃木":
                    result = "KANTO";
                    break;
                case "群馬":
                    result = "KANTO";
                    break;
                case "埼玉":
                    result = "KANTO";
                    break;
                case "千葉":
                    result = "KANTO";
                    break;
                case "神奈川":
                    result = "KANTO";
                    break;
                case "東京":
                    result = "KANTO";
                    break;
                case "山梨":
                    result = "KANTO";
                    break;
                case "新潟":
                    result = "SHINETU";
                    break;
                case "長野":
                    result = "SHINETU";
                    break;
                case "静岡":
                    result = "CHUBU";
                    break;
                case "愛知":
                    result = "CHUBU";
                    break;
                case "三重":
                    result = "CHUBU";
                    break;
                case "岐阜":
                    result = "CHUBU";
                    break;
                case "富山":
                    result = "HOKURIKU";
                    break;
                case "石川":
                    result = "HOKURIKU";
                    break;
                case "福井":
                    result = "HOKURIKU";
                    break;
                case "大阪":
                    result = "KANSAI";
                    break;
                case "京都":
                    result = "KANSAI";
                    break;
                case "滋賀":
                    result = "KANSAI";
                    break;
                case "奈良":
                    result = "KANSAI";
                    break;
                case "和歌山":
                    result = "KANSAI";
                    break;
                case "兵庫":
                    result = "KANSAI";
                    break;
                case "岡山":
                    result = "CHUGOKU";
                    break;
                case "広島":
                    result = "CHUGOKU";
                    break;
                case "山口":
                    result = "CHUGOKU";
                    break;
                case "鳥取":
                    result = "CHUGOKU";
                    break;
                case "島根":
                    result = "CHUGOKU";
                    break;
                case "香川":
                    result = "SHIKOKU";
                    break;
                case "徳島":
                    result = "SHIKOKU";
                    break;
                case "愛媛":
                    result = "SHIKOKU";
                    break;
                case "高知":
                    result = "SHIKOKU";
                    break;
                case "福岡":
                    result = "KYUSYU";
                    break;
                case "佐賀":
                    result = "KYUSYU";
                    break;
                case "長崎":
                    result = "KYUSYU";
                    break;
                case "熊本":
                    result = "KYUSYU";
                    break;
                case "大分":
                    result = "KYUSYU";
                    break;
                case "宮崎":
                    result = "KYUSYU";
                    break;
                case "鹿児島":
                    result = "KYUSYU";
                    break;
                case "沖縄":
                    result = "OKINAWA";
                    break;
                default:
                    result = ERROR_STR;
                    break;
            }
            return result;
        }

        private int DecisionColmun(string receiver)
        {
            int result = 999;
            switch (receiver)
            {
                case "北海道":
                    result = 0;
                    break;
                case "青森":
                    result = 1;
                    break;
                case "秋田":
                    result = 1;
                    break;
                case "岩手":
                    result = 1;
                    break;
                case "宮城":
                    result = 2;
                    break;
                case "山形":
                    result = 2;
                    break;
                case "福島":
                    result = 2;
                    break;
                case "茨城":
                    result = 3;
                    break;
                case "栃木":
                    result = 3;
                    break;
                case "群馬":
                    result = 3;
                    break;
                case "埼玉":
                    result = 3;
                    break;
                case "千葉":
                    result = 3;
                    break;
                case "神奈川":
                    result = 3;
                    break;
                case "東京":
                    result = 3;
                    break;
                case "山梨":
                    result = 3;
                    break;
                case "新潟":
                    result = 4;
                    break;
                case "長野":
                    result = 4;
                    break;
                case "静岡":
                    result = 5;
                    break;
                case "愛知":
                    result = 5;
                    break;
                case "三重":
                    result = 5;
                    break;
                case "岐阜":
                    result = 5;
                    break;
                case "富山":
                    result = 6;
                    break;
                case "石川":
                    result = 6;
                    break;
                case "福井":
                    result = 6;
                    break;
                case "大阪":
                    result = 7;
                    break;
                case "京都":
                    result = 7;
                    break;
                case "滋賀":
                    result = 7;
                    break;
                case "奈良":
                    result = 7;
                    break;
                case "和歌山":
                    result = 7;
                    break;
                case "兵庫":
                    result = 7;
                    break;
                case "岡山":
                    result = 8;
                    break;
                case "広島":
                    result = 8;
                    break;
                case "山口":
                    result = 8;
                    break;
                case "鳥取":
                    result = 8;
                    break;
                case "島根":
                    result = 8;
                    break;
                case "香川":
                    result = 9;
                    break;
                case "徳島":
                    result = 9;
                    break;
                case "愛媛":
                    result = 9;
                    break;
                case "高知":
                    result = 9;
                    break;
                case "福岡":
                    result = 10;
                    break;
                case "佐賀":
                    result = 10;
                    break;
                case "長崎":
                    result = 10;
                    break;
                case "熊本":
                    result = 10;
                    break;
                case "大分":
                    result = 10;
                    break;
                case "宮崎":
                    result = 10;
                    break;
                case "鹿児島":
                    result = 10;
                    break;
                case "沖縄":
                    result = 11;
                    break;
                default:
                    result = ERROR_NUM;
                    break;
            }

            return result;
        }

        private int DecisonRowLength(double sumlength)
        {
            int result;
            if (sumlength <= 60)
            {
                result = 0;
            }
            else if (sumlength <= 80)
            {
                result = 1;
            }
            else if (sumlength <= 100)
            {
                result = 2;
            }
            else if (sumlength <= 120)
            {
                result = 3;
            }
            else if (sumlength <= 140)
            {
                result = 4;
            }
            else if (sumlength <= 160)
            {
                result = 5;
            }
            else
            {
                result = ERROR_NUM;
            }
            return result;
        }

        private int DecisionRowWight(double weight)
        {
            int result;
            if(weight <= 2){
                result = 0;
            }else if(weight <= 5){
                result = 1;
            }else if(weight <= 10){
                result = 2;
            }else if(weight <=15){
                result = 3;
            }else if(weight <=20){
                result = 4;
            }else if(weight <=25){
                result = 5;
            }else{
                result = ERROR_NUM;
            }
            return result;
        }
    }
}
