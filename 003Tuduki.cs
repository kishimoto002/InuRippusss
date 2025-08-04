using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameRPG
{
    public partial class Tuduki : Form
    {
        public Tuduki()
        {
            InitializeComponent();
        }

        private void btn_Yes_Click(object sender, EventArgs e)
        {
            Program.mTitleMenu.Hide();
        }

        private void btn_No_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Tuduki_Shown(object sender, EventArgs e)
        {
            btn_Yes.Visible = true;
            btn_No.Visible = true;

            lbl_NoSaveData.Visible = false;
            lbl_SaveDataRead.Visible = true;
            lbl_PlayerName.Visible = true;
            lbl_QestClear.Visible = true;
            lbl_NyuusyuMon.Visible = true;
            lbl_ReLord.Visible = true;

            string path01 = "..\\..\\..\\..\\" + "1SaveData\\プレイヤー.txt";
            int playerFlg = Player.Read(path01);

            if (playerFlg == 0)
            {
                lbl_PlayerNameText.Text = Player.name;
                lbl_QestClearText.Text = Player.qest.ToString();
                lbl_NyuusyuMonText.Text = Player.nyuusyuMonNum.ToString();

                string path1 = "..\\..\\..\\..\\" + "1SaveData\\パーティー" + (1) + "人目.txt";
                string path2 = "..\\..\\..\\..\\" + "1SaveData\\パーティー" + (2) + "人目.txt";
                string path3 = "..\\..\\..\\..\\" + "1SaveData\\パーティー" + (3) + "人目.txt";

                Program.PTMenbarRead(path1,path2,path3,
                    Player.pt1ImgNo, Player.pt2ImgNo, Player.pt3ImgNo, Player.ptNum);

                lbl_ReLord.Visible = false;
            }
            else if (playerFlg == -1)
            {
                btn_Yes.Visible = false;
                btn_No.Visible = false;

                lbl_NoSaveData.Visible = true;
                lbl_SaveDataRead.Visible = false;
                lbl_PlayerName.Visible = false;
                lbl_QestClear.Visible = false;
                lbl_NyuusyuMon.Visible = false;
                lbl_ReLord.Visible = false;
            }
        }
    }
}
