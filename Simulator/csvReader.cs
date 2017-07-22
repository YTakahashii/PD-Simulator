using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.VisualBasic.FileIO;
using System.IO;

namespace Simulator
{
    public partial class csvReader
    {
        public string[,] table;
        public int col=0, row=0;

        public csvReader(string FileName, Encoding encode)
        {
            TextFieldParser parser = new TextFieldParser(FileName, encode);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");
            
            //要素数の決定
            while(!parser.EndOfData){
                int colcnt = 0;
                string[] line = parser.ReadFields();
                row++;
                foreach(string tmp in line){
                    colcnt++;
                }
                if( colcnt > col){
                    col = colcnt;
                }
            }
            table = new string[row,col];

            {
                //ここから2次元配列に格納
                int r=0, c=0;
                string[] line2;
                parser = new TextFieldParser(FileName, encode);
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while(!parser.EndOfData){
                    //1行ずつね
                    line2 = parser.ReadFields();
                    c=0;
                    foreach(string tmp in line2){
                        table[r,c] = tmp;
                        c++;
                    }
                    for(; c<this.col; c++){
                        table[r,c] = string.Empty;
                    }
                    r++;
                }
            }
        }
        public void Writecsv(string[,] saveTable ,string FilePath, Encoding encode)
        {
            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Write, FileShare.ReadWrite);
            StreamWriter sw = new StreamWriter(fs,encode);
            
            for(int i=0; i < saveTable.GetLength(0); i++){
                for(int j=0; j < saveTable.GetLength(1); j++){
                    sw.Write("{0}",saveTable[i,j]);
                    sw.Write(",");
                }
                sw.WriteLine();
            }
            sw.Dispose();
            sw.Close();
        }

        //追加する行を受け取り配列を再度確保する
        public string[,] AppendLine(string[,] apTable, string[] append_line, string FilePath, Encoding encode){
            FileStream fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
            TextFieldParser parser = new TextFieldParser(fs, encode);
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            row = 0;
            //要素数の決定
            while(!parser.EndOfData){
                int colcnt = 0;
                string[] line = parser.ReadFields();
                row++;
                foreach(string tmp in line){
                    colcnt++;
                }
                if( colcnt > col){
                    col = colcnt;
                }
            }
            apTable = new string[row+1,col];

            {
                //ここから2次元配列に格納
                int r=0, c=0;
                string[] line2;
                parser = new TextFieldParser(FilePath, encode);
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");
                while(!parser.EndOfData){
                    //1行ずつね
                    line2 = parser.ReadFields();
                    c=0;
                    foreach(string tmp in line2){
                        apTable[r,c] = tmp;
                        c++;
                    }
                    for(; c<this.col; c++){
                        apTable[r,c] = string.Empty;
                    }
                    r++;
                }
                
                for(int i=0; i<append_line.Length; i++){
                    apTable[r,i] = append_line[i];
                }
            }
            parser.Dispose();
            parser.Close();
            return apTable;
        }
    }
}
