namespace LPTimer
{
    partial class スクフェスタイマー
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(スクフェスタイマー));
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_lpnow = new System.Windows.Forms.Label();
            this.lbl_lpmax = new System.Windows.Forms.Label();
            this.lbl_lpmaxtime = new System.Windows.Forms.Label();
            this.txt_lpmaxtime = new System.Windows.Forms.TextBox();
            this.nud_nowLP = new System.Windows.Forms.NumericUpDown();
            this.nud_maxLP = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nud_nowLP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxLP)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(122, 12);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(150, 45);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "計算";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_lpnow
            // 
            this.lbl_lpnow.AutoSize = true;
            this.lbl_lpnow.Location = new System.Drawing.Point(12, 15);
            this.lbl_lpnow.Name = "lbl_lpnow";
            this.lbl_lpnow.Size = new System.Drawing.Size(52, 12);
            this.lbl_lpnow.TabIndex = 2;
            this.lbl_lpnow.Text = "現在のLP";
            // 
            // lbl_lpmax
            // 
            this.lbl_lpmax.AutoSize = true;
            this.lbl_lpmax.Location = new System.Drawing.Point(12, 40);
            this.lbl_lpmax.Name = "lbl_lpmax";
            this.lbl_lpmax.Size = new System.Drawing.Size(52, 12);
            this.lbl_lpmax.TabIndex = 3;
            this.lbl_lpmax.Text = "最大のLP";
            // 
            // lbl_lpmaxtime
            // 
            this.lbl_lpmaxtime.AutoSize = true;
            this.lbl_lpmaxtime.Location = new System.Drawing.Point(12, 65);
            this.lbl_lpmaxtime.Name = "lbl_lpmaxtime";
            this.lbl_lpmaxtime.Size = new System.Drawing.Size(104, 12);
            this.lbl_lpmaxtime.TabIndex = 5;
            this.lbl_lpmaxtime.Text = "LPがMAXになる時間";
            // 
            // txt_lpmaxtime
            // 
            this.txt_lpmaxtime.Location = new System.Drawing.Point(122, 62);
            this.txt_lpmaxtime.Name = "txt_lpmaxtime";
            this.txt_lpmaxtime.Size = new System.Drawing.Size(150, 19);
            this.txt_lpmaxtime.TabIndex = 6;
            // 
            // nud_nowLP
            // 
            this.nud_nowLP.Location = new System.Drawing.Point(70, 13);
            this.nud_nowLP.Name = "nud_nowLP";
            this.nud_nowLP.Size = new System.Drawing.Size(46, 19);
            this.nud_nowLP.TabIndex = 7;
            // 
            // nud_maxLP
            // 
            this.nud_maxLP.Location = new System.Drawing.Point(70, 38);
            this.nud_maxLP.Name = "nud_maxLP";
            this.nud_maxLP.Size = new System.Drawing.Size(46, 19);
            this.nud_maxLP.TabIndex = 8;
            // 
            // スクフェスタイマー
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 94);
            this.Controls.Add(this.nud_maxLP);
            this.Controls.Add(this.nud_nowLP);
            this.Controls.Add(this.txt_lpmaxtime);
            this.Controls.Add(this.lbl_lpmaxtime);
            this.Controls.Add(this.lbl_lpmax);
            this.Controls.Add(this.lbl_lpnow);
            this.Controls.Add(this.btn_calc);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "スクフェスタイマー";
            this.Text = "スクフェスタイマー";
            ((System.ComponentModel.ISupportInitialize)(this.nud_nowLP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maxLP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_lpnow;
        private System.Windows.Forms.Label lbl_lpmax;
        private System.Windows.Forms.Label lbl_lpmaxtime;
        private System.Windows.Forms.TextBox txt_lpmaxtime;
        private System.Windows.Forms.NumericUpDown nud_nowLP;
        private System.Windows.Forms.NumericUpDown nud_maxLP;
    }
}

