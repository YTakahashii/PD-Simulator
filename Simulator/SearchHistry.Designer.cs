namespace Simulator
{
    partial class SearchHistry
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Length3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isCool = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Search = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateTime,
            this.Sender,
            this.Receiver,
            this.Length1,
            this.Length2,
            this.Length3,
            this.weight,
            this.isCool,
            this.Search});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(995, 437);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // DateTime
            // 
            this.DateTime.Frozen = true;
            this.DateTime.HeaderText = "検索日時";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Width = 150;
            // 
            // Sender
            // 
            this.Sender.Frozen = true;
            this.Sender.HeaderText = "差出地";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            // 
            // Receiver
            // 
            this.Receiver.Frozen = true;
            this.Receiver.HeaderText = "宛先地";
            this.Receiver.Name = "Receiver";
            this.Receiver.ReadOnly = true;
            // 
            // Length1
            // 
            this.Length1.Frozen = true;
            this.Length1.HeaderText = "縦の長さ";
            this.Length1.Name = "Length1";
            this.Length1.ReadOnly = true;
            // 
            // Length2
            // 
            this.Length2.Frozen = true;
            this.Length2.HeaderText = "横の長さ";
            this.Length2.Name = "Length2";
            this.Length2.ReadOnly = true;
            // 
            // Length3
            // 
            this.Length3.Frozen = true;
            this.Length3.HeaderText = "高さ";
            this.Length3.Name = "Length3";
            this.Length3.ReadOnly = true;
            // 
            // weight
            // 
            this.weight.Frozen = true;
            this.weight.HeaderText = "重さ";
            this.weight.Name = "weight";
            this.weight.ReadOnly = true;
            // 
            // isCool
            // 
            this.isCool.Frozen = true;
            this.isCool.HeaderText = "オプション";
            this.isCool.Name = "isCool";
            this.isCool.ReadOnly = true;
            // 
            // Search
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.NullValue = "検索";
            this.Search.DefaultCellStyle = dataGridViewCellStyle3;
            this.Search.HeaderText = "この条件で検索";
            this.Search.Name = "Search";
            this.Search.ReadOnly = true;
            this.Search.Text = "検索";
            this.Search.UseColumnTextForButtonValue = true;
            // 
            // SearchHistry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 437);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SearchHistry";
            this.Text = "検索履歴";
            this.Load += new System.EventHandler(this.SearchHistry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length3;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn isCool;
        private System.Windows.Forms.DataGridViewButtonColumn Search;
    }
}