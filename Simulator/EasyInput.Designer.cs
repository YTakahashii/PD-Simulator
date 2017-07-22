namespace Simulator
{
    partial class EasyInput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EasyInput));
            this.cb_danboru = new System.Windows.Forms.ComboBox();
            this.cb_sagawa = new System.Windows.Forms.ComboBox();
            this.cb_letter = new System.Windows.Forms.ComboBox();
            this.cb_yamato = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cb_danboru
            // 
            this.cb_danboru.FormattingEnabled = true;
            this.cb_danboru.Items.AddRange(new object[] {
            "27×20×30cm ｜60サイズ",
            "32×23×15cm ｜70サイズ",
            "35×25×20cm ｜80サイズ",
            "42×32×26cm ｜100サイズ",
            "50×35×35cm ｜120サイズ",
            "51×40×39cm ｜130サイズ",
            "52×50×38cm ｜140サイズ",
            "56×53×51cm ｜160サイズ",
            "80×60×30cm ｜170サイズ"});
            this.cb_danboru.Location = new System.Drawing.Point(2, 2);
            this.cb_danboru.Name = "cb_danboru";
            this.cb_danboru.Size = new System.Drawing.Size(251, 20);
            this.cb_danboru.TabIndex = 0;
            this.cb_danboru.Text = "一般ダンボール";
            this.cb_danboru.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_sagawa
            // 
            this.cb_sagawa.FormattingEnabled = true;
            this.cb_sagawa.Items.AddRange(new object[] {
            "エクスプレスBOX LL",
            "エクスプレスBOX L",
            "エクスプレスBOX M",
            "エクスプレスBOX S",
            "クールBOX L",
            "クールBOX S",
            "ポスターBOX L",
            "ポスターBOX S",
            "ビジネスBOX L",
            "ビジネスBOX M",
            "ビジネスBOX S",
            "ボトルBOX 1本",
            "ボトルBOX 2本",
            "ボトルBOX化粧箱用 1本",
            "ボトルBOXハーフ 1本",
            "ボトルBOXハーフ 2本",
            "ボトルBOXハーフ化粧箱用 1本",
            "ボトルBOXハーフ化粧箱用 2本",
            "エクスプレスバッグ A-L",
            "エクスプレスバッグ A-S",
            "エクスプレスバッグ B-L",
            "エクスプレスバッグ B-S",
            "エクスプレスバッグ C",
            "エクスプレスバッグ AG-L",
            "エクスプレスバッグ AG-S",
            "ビジネスエクスプレスバッグ"});
            this.cb_sagawa.Location = new System.Drawing.Point(2, 54);
            this.cb_sagawa.Name = "cb_sagawa";
            this.cb_sagawa.Size = new System.Drawing.Size(251, 20);
            this.cb_sagawa.TabIndex = 2;
            this.cb_sagawa.Text = "佐川急便";
            this.cb_sagawa.SelectedIndexChanged += new System.EventHandler(this.cb_sagawa_SelectedIndexChanged);
            // 
            // cb_letter
            // 
            this.cb_letter.FormattingEnabled = true;
            this.cb_letter.Items.AddRange(new object[] {
            "長形3号封筒｜A4判三つ折り",
            "長形4号封筒｜B5判四つ折り",
            "角型2号封筒｜A4判",
            "角型3号封筒｜B5判",
            "角型4号封筒｜B5判",
            "角型5号封筒｜A5判",
            "角型6号封筒｜A5判"});
            this.cb_letter.Location = new System.Drawing.Point(2, 28);
            this.cb_letter.Name = "cb_letter";
            this.cb_letter.Size = new System.Drawing.Size(251, 20);
            this.cb_letter.TabIndex = 3;
            this.cb_letter.Text = "封筒";
            this.cb_letter.SelectedIndexChanged += new System.EventHandler(this.cb_letter_SelectedIndexChanged);
            // 
            // cb_yamato
            // 
            this.cb_yamato.FormattingEnabled = true;
            this.cb_yamato.Items.AddRange(new object[] {
            "ウォークスルーボックス12",
            "クロネコボックス12",
            "クロネコボックス10",
            "クロネコボックス8",
            "クロネコボックス6",
            "手さげ袋A3-1",
            "手さげ袋B4",
            "クロネコ袋A3",
            "クロネコ袋B4",
            "クロネコ袋A4",
            "三角ケースL",
            "三角ケースM",
            "酒BOX2",
            "酒BOX1",
            "ボトルBOX2",
            "ボトルBOX1",
            "クッション袋A3",
            "クッション袋A4"});
            this.cb_yamato.Location = new System.Drawing.Point(4, 80);
            this.cb_yamato.Name = "cb_yamato";
            this.cb_yamato.Size = new System.Drawing.Size(249, 20);
            this.cb_yamato.TabIndex = 4;
            this.cb_yamato.Text = "ヤマト運輸";
            this.cb_yamato.SelectedIndexChanged += new System.EventHandler(this.cb_yamato_SelectedIndexChanged);
            // 
            // EasyInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(255, 104);
            this.Controls.Add(this.cb_yamato);
            this.Controls.Add(this.cb_letter);
            this.Controls.Add(this.cb_sagawa);
            this.Controls.Add(this.cb_danboru);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EasyInput";
            this.Text = "簡単入力";
            this.Load += new System.EventHandler(this.EasyInput_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_danboru;
        private System.Windows.Forms.ComboBox cb_sagawa;
        private System.Windows.Forms.ComboBox cb_letter;
        private System.Windows.Forms.ComboBox cb_yamato;
    }
}