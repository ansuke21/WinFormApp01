using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormApp01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.lgsInit();
        }
        private void lgsInit()
        {
            this.textBox起点.Text = "13102";
            this.textBox終点.Text = "27127";
            this.textBoxWebApiKey.Text = "8779c23a-527e-4cba-8a50-32969cd94470";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ClgsWebKiroTeiKyori01.ClgsWebKiroTeiKyori01 ClgsWebKiroTei = new ClgsWebKiroTeiKyori01.ClgsWebKiroTeiKyori01();
            ClgsWebKiroTei.Kiten = this.textBox起点.Text;
            ClgsWebKiroTei.Shuuten = this.textBox終点.Text;
            ClgsWebKiroTei.WebApiKey = this.textBoxWebApiKey.Text;
            // プロキシ認証がある場合は設定します
            ClgsWebKiroTei.ProxyServer = "";
            ClgsWebKiroTei.ProxyUserName = "";
            ClgsWebKiroTei.ProxyPassword = "";

            Boolean blnCond = ClgsWebKiroTei.lgsKyoriKmKeisan();
            this.textBox主要距離Km.Text = ClgsWebKiroTei.ShuyouKyoriKm.ToString();
            this.textBox最短距離Km.Text = ClgsWebKiroTei.SaitanKyoriKm.ToString();
            this.textBoxError.Text = ClgsWebKiroTei.Error;
        }


    }
}
