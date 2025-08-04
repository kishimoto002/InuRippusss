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
    public partial class SyokiKyara : Form
    {
        public SyokiKyara()
        {
            InitializeComponent();
        }

        private void btn_Kettei_Click(object sender, EventArgs e)
        {
            // 選択したキャラデータの図鑑あり（に乗せる）
            Program.mPtMenbar[int.Parse(((Button)sender).Tag.ToString()) -1].zukan = "有り";
            // パーティ画像No.設定
            Player.pt1ImgNo = int.Parse(((Button)sender).Tag.ToString());
            // パーティ加入
            Player.ptNum = 1;

            Program.mMatiFlg = MatiChange.待ち受け画像を変更する;

            MatiUke mMatiUke = new();
            mMatiUke.Show();
            Hide();
        }

        private void SyokiKyara_Shown(object sender, EventArgs e)
        {
            string path1 = "..\\..\\..\\..\\" + "0SyokiData\\モンスター1.txt";
            string path2 = "..\\..\\..\\..\\" + "0SyokiData\\モンスター2.txt";
            string path3 = "..\\..\\..\\..\\" + "0SyokiData\\モンスター3.txt";

            Program.PTMenbarRead(path1, path2, path3,
                1, 2, 3, 3);

            // 初期キャラ１、初期キャラ２、初期キャラ３画像読み込み
            if (Program.mPtMenbar.Count() == 0)
            {
                return;
            }
            if (Program.mPtMenbar.Count() >= 1)
            {
                panel_Kyara1.Controls.Add(Program.mPtMenbar[0].pic);
                lbl_Zokusei1.Text = Program.mPtMenbar[0].zokusei;
                lbl_Hp1.Text = Program.mPtMenbar[0].hp.ToString();
                lbl_Mp1.Text = Program.mPtMenbar[0].mp.ToString();
                lbl_Str1.Text = Program.mPtMenbar[0].str.ToString();
                lbl_Def1.Text = Program.mPtMenbar[0].def.ToString();
                lbl_Int1.Text = Program.mPtMenbar[0].maso.ToString();
                lbl_Mdef1.Text = Program.mPtMenbar[0].mdef.ToString();
            }
            if (Program.mPtMenbar.Count() >= 2)
            {
                panel_Kyara2.Controls.Add(Program.mPtMenbar[1].pic);
                lbl_Zokusei2.Text = Program.mPtMenbar[1].zokusei;
                lbl_Hp2.Text = Program.mPtMenbar[1].hp.ToString();
                lbl_Mp2.Text = Program.mPtMenbar[1].mp.ToString();
                lbl_Str2.Text = Program.mPtMenbar[1].str.ToString();
                lbl_Def2.Text = Program.mPtMenbar[1].def.ToString();
                lbl_Int2.Text = Program.mPtMenbar[1].maso.ToString();
                lbl_Mdef2.Text = Program.mPtMenbar[1].mdef.ToString();
            }
            if (Program.mPtMenbar.Count() >= 3)
            {
                panel_Kyara3.Controls.Add(Program.mPtMenbar[2].pic);
                lbl_Zokusei3.Text = Program.mPtMenbar[2].zokusei;
                lbl_Hp3.Text = Program.mPtMenbar[2].hp.ToString();
                lbl_Mp3.Text = Program.mPtMenbar[2].mp.ToString();
                lbl_Str3.Text = Program.mPtMenbar[2].str.ToString();
                lbl_Def3.Text = Program.mPtMenbar[2].def.ToString();
                lbl_Int3.Text = Program.mPtMenbar[2].maso.ToString();
                lbl_Mdef3.Text = Program.mPtMenbar[2].mdef.ToString();
            }
        }

        private void SyokiKyara_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hide();
            Program.mTitleMenu.Show();
        }
    }
}
