using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LPTimer
{
    public partial class スクフェスタイマー : Form
    {

        /// <summary>
        /// LPの回復時間（分）
        /// </summary>
        readonly private int LP_LIFETIME = 6;
        
        public スクフェスタイマー()
        {
            InitializeComponent();
        }

        /// <summary>
        /// ボタン押したときの動作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_calc_Click(object sender, EventArgs e)
        {
            int nowLP = (int)this.nud_nowLP.Value;
            int maxLP = (int)this.nud_maxLP.Value;
            int tempTime = (maxLP - nowLP) * LP_LIFETIME;

            DateTime nowdatetime = System.DateTime.Now;

            TimeSpan temptimespan = new TimeSpan(0, tempTime, 0);

            DateTime outputdatetime = nowdatetime + temptimespan;

            //this.txt_lpmaxtime.Text = tempTime.ToString();
            this.txt_lpmaxtime.Text = outputdatetime.ToString();
        }

    }
}
