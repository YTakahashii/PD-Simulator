using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Simulator
{
    public class Info
    {
        private string filepath = "SearchHistry.csv";
        private Encoding encode = Encoding.GetEncoding("shift_jis");
        private csvReader cr;

        public Info(DateTime dt)
        {
            datetime = dt;
        }

        public void SaveHistry()
        {
            cr = new csvReader(@filepath, encode);
            if(isCool){
                optionText = "クール便";
            }else{
                optionText = "通常";
            }
            line = new string[] { datetime.ToString(), sender, receiver, length1, length2, length3, weight, optionText};
            string[,] newTable = cr.AppendLine(cr.table, line, @filepath, encode);
            cr.Writecsv(newTable, @filepath, encode);
        }
        private string[] line = {"","",""};
        public DateTime datetime;
        public string sender{get; set;}
        public string receiver{get; set;}
        public string length1{get; set;}
        public string length2{get; set;}
        public string length3{get; set;}
        public string weight{get; set;}
        public bool isCool{get; set;}
        private string optionText = "";
    }
}
