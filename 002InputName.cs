using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRPG
{
    public partial class InputName : Form
    {
        public InputName()
        {
            InitializeComponent();
        }

        private void btn_Kettei_Click(object sender, EventArgs e)
        {
            if (txt_Name.Text == "" || txt_Name.Text == " " || txt_Name.Text == "　")
            {
                return;
            }
            lbl_ReLord.Visible = true;

            SyokiKyara mSyokiKyara = new();

            // 初期データ読み込み
            string fileName = "0SyokiData\\プレイヤー.txt";
        retryPtImg:
            int playerFlg = Player.Read(fileName);
            Player.name = txt_Name.Text;

            if (playerFlg == 0)
            {
            }
            else if (playerFlg == -1)
            {
                txt_Name.Visible = false;
                btn_Kettei.Visible = false;
                lbl_moziLimit.Visible = false;
                lbl_Name.Visible = false;

                Thread.Sleep(1000);
                goto retryPtImg;
            }
            lbl_ReLord.Visible = false;

            // 画面遷移
            mSyokiKyara.Show(this);
            Hide();
        }

        private void InputName_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Program.mTitleMenu.Show();
        }
    }
}
