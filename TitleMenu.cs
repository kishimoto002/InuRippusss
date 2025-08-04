using System.DirectoryServices.ActiveDirectory;
using System.Runtime.Intrinsics.X86;

namespace GameRPG
{
    public partial class TitleMenu : Form
    {
        public TitleMenu()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            Program.mTitleMenu = this;
            InputName mInputName = new();
            mInputName.Show(this);
            Hide();
        }

        private void btn_Tuzuki_Click(object sender, EventArgs e)
        {
            Program.mTitleMenu = this;
            Tuduki mTuduki = new();
            mTuduki.ShowDialog(this);           
        }

        private void btn_SoundTest_Click(object sender, EventArgs e)
        {
            SoundTest mSoundTest = new();
            mSoundTest.ShowDialog(this);
            //Hide();
        }

        private void btn_End_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
