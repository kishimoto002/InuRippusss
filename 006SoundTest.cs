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
    public partial class SoundTest : Form
    {
        public SoundTest()
        {
            InitializeComponent();
        }

        private void SoundTest_Shown(object sender, EventArgs e)
        {
            string[] file = { "" };
            Program.GetAllPath("..\\..\\..\\..\\" + "4sound\\se", ref file);
            for (int i = 0; i < file.Count(); i++)
            {
                cmb_SE.Items.Add(Path.GetFileName(file[i]));
            }

            string[] file2 = { "" };
            Program.GetAllPath("..\\..\\..\\..\\" + "4sound\\bgm", ref file2);
            for (int i = 0; i < file2.Count(); i++)
            {
                cmb_BGM.Items.Add(Path.GetFileName(file2[i]));
            }
        }

        private void btn_SE_Click(object sender, EventArgs e)
        {
            string file = "..\\..\\..\\..\\" + "4sound\\se\\" + cmb_SE.Text;
            Kihon.SetSoundSE(file);
            Kihon.PlaySoundSE();
        }

        private void btn_BGM_Click(object sender, EventArgs e)
        {
            string file = "..\\..\\..\\..\\" + "4sound\\bgm\\" + cmb_BGM.Text;
            Kihon.SetSoundBGM(file);
            Kihon.PlaySoundBGM();
        }

        private void SoundTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            Kihon.StopSoundBGM();
            Kihon.StopSoundSE();
        }
    }
}
