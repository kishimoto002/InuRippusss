using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRPG
{
    public partial class MatiUke : Form
    {
        public MatiUke()
        {
            InitializeComponent();
        }

        // 敵の画像
        private PictureBox _pbImgEnemy;

        private void timer_Effect_Tick(object sender, EventArgs e)
        {
            if (Program.mMatiFlg == MatiChange.待ち受け画像を変更する)
            {
                if (Program.mPtMenbar.Count() >= 1)
                {
                    _pbImgEnemy = Program.mPtMenbar[0].pic;
                }
                Program.mMatiFlg = MatiChange.待ち受け画像を変更しない;
            }

            _pbImgEnemy.Location = new Point(0, 0);
            _pbImgEnemy.Size = new Size(640, 480);

            panel_Game.Controls.Add(_pbImgEnemy);
        }

        private void MatiUke_Shown(object sender, EventArgs e)
        {
            _pbImgEnemy = new();
            // タイマーのスタート
            timer_Effect.Enabled = true;
        }

        private void MatiUke_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Program.mTitleMenu.Show();
        }

        private void btn_PtHensei_Click(object sender, EventArgs e)
        {

        }

        private void btn_SoubiItiran_Click(object sender, EventArgs e)
        {

        }

        private void btn_Qest_Click(object sender, EventArgs e)
        {

        }

        private void btn_KyaraItiran_Click(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            lbl_ReWrite.Visible = true;
            string fileName = "0SyokiData\\プレイヤー.txt";
        retryPtImg:
            int playerFlg = Player.Write(fileName);

            if (playerFlg == 0)
            {
            }
            else if (playerFlg == -1)
            {
                Thread.Sleep(1000);
                goto retryPtImg;
            }

            string path1 = "1SaveData\\パーティー" + (1) + "人目.txt";
            string path2 = "1SaveData\\パーティー" + (2) + "人目.txt";
            string path3 = "1SaveData\\パーティー" + (3) + "人目.txt";

            Program.PTMenbarWrite(path1, path2, path3);
            lbl_ReWrite.Visible = false;
        }

        private void btn_MonGatya_Click(object sender, EventArgs e)
        {

        }

        private void btn_SoubiGatya_Click(object sender, EventArgs e)
        {

        }
    }
}
