using System.Media;
using System.Runtime.InteropServices;
using System.Text;

namespace GameRPG
{
    enum MatiChange
    {
        �҂��󂯉摜��ύX����, �҂��󂯉摜��ύX���Ȃ�
    };

    public class Kihon
    {
        public static int volume = 000;
        public static int Write(int volume, string fileName)
        {
            if (File.Exists(fileName) == false) { return -1; }
            StreamWriter sw = new StreamWriter(fileName, false, Encoding.GetEncoding("Shift_JIS"));
            sw.WriteLine("�{�����[��:" + volume);
            sw.Close();

            return 0;
        }

        public static int Read(ref int volume, string fileName)
        {
            if (File.Exists(fileName) == false) { return -1; }
            StreamReader sr = new StreamReader("fileName", Encoding.GetEncoding("Shift_JIS"));
            string[] data;
#pragma warning disable CS8602 // null �Q�Ƃ̉\����������̂̋t�Q�Ƃł��B
            if (sr.Peek() != -1) { sr.Close(); return -1; }
            data = sr.ReadLine().Split(":");
            volume = int.Parse(data[1]);
#pragma warning restore CS8602 // null �Q�Ƃ̉\����������̂̋t�Q�Ƃł��B

            sr.Close();
            return 0;
        }

        private static SoundPlayer player1;

        public static int SetSoundBGM(string fileName)
        {
            if (Path.GetExtension(fileName).Equals(".wav", StringComparison.OrdinalIgnoreCase) == false)
            {
                return -1;
            }

            if (File.Exists(fileName) == false) 
            { 
                return -1; 
            }

            player1 = new SoundPlayer(fileName);
            player1.Load();
            return 0;
        }

        public static int PlaySoundBGM()
        {
            if (player1 == null){ return -1; }
            player1.Play();
            return 0;
        }

        public static int PlaySoundLoopBGM()
        {
            if (player1 == null) { return -1; }
            player1.PlayLooping(); // ���[�v�Đ�
            return 0;
        }

        public static int StopSoundBGM()
        {
            if (player1 == null) { return -1; }
            player1.Stop();
            return 0;
        }

        [DllImport("winmm.dll", CharSet = CharSet.Auto)]
        private static extern int mciSendString(string command, string returnValue, int returnLength, IntPtr winHandle);

        public static int SetSoundSE(string filePath)
        {
            if (Path.GetExtension(filePath).Equals(".wav", StringComparison.OrdinalIgnoreCase) == false)
            {
                return -1;
            }

            if (File.Exists(filePath) == false) 
            {
                return -1; 
            }

            // ���y�����
            mciSendString("close myMusic", null, 0, IntPtr.Zero);

            // ���y���J��
            mciSendString($"open \"{filePath}\" type waveaudio alias myMusic", null, 0, IntPtr.Zero);

            return 0;
        }

        public static void PlaySoundSE()
        {
            // �Đ�
            mciSendString("play myMusic", null, 0, IntPtr.Zero);
        }

        public static void StopSoundSE()
        {
            // ���y�����
            mciSendString("close myMusic", null, 0, IntPtr.Zero);
        }

    }

    public class Player
    {
        public static string name = "�e�X�g�v���C���[";
        public static int qest = 000;
        public static int ptNum = 0;
        public static int pt1ImgNo = -1;
        public static int pt2ImgNo = -1;
        public static int pt3ImgNo = -1;
        public static int nyuusyuMonNum = 0;
        public static int maxMonNum = 0;

        public static int Write(string fileName)
        {
            if (File.Exists(fileName) == false) { return -1; }
            StreamWriter sw = new StreamWriter(fileName);//, false, Encoding.GetEncoding("Shift_JIS"));
            sw.WriteLine("���O:" + name);
            sw.WriteLine("�N�G�X�g:" + qest);
            sw.WriteLine("�p�[�e�B��:" + ptNum);
            sw.WriteLine("pt1�摜No.:" + pt1ImgNo);
            sw.WriteLine("pt2�摜No.:" + pt2ImgNo);
            sw.WriteLine("pt3�摜No.:" + pt3ImgNo);
            sw.WriteLine("���胂���X�^�[��:" + nyuusyuMonNum);
            sw.WriteLine("�S�����X�^�[��:" + maxMonNum);

            sw.Close();
            return 0;
        }

        public static int Read(string fileName)
        {
            if (File.Exists(fileName) == false) { return -1; }
            StreamReader sr = new StreamReader(fileName);//, Encoding.GetEncoding("Shift_JIS"));
            string[] data;

#pragma warning disable CS8602 // null �Q�Ƃ̉\����������̂̋t�Q�Ƃł��B
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            name = data[1];
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            qest = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            ptNum = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            pt1ImgNo = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            pt2ImgNo = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            pt3ImgNo = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            nyuusyuMonNum = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            maxMonNum = int.Parse(data[1]);
#pragma warning restore CS8602 // null �Q�Ƃ̉\����������̂̋t�Q�Ƃł��B

            sr.Close();
            return 0;
        }
    }

    public class PtMenbar
    {
        public string name = "�e�X�g����";
        public int str = 0, def = 0, maso = 0, mdef = 0, mp = 0, hp = 0;
        public int level = 0;
        public string zokusei = "����";
        public string zukan = "����";
        public PictureBox pic = new();

        public int Write(string fileName)
        {
            if (File.Exists(fileName) == false) { return -1; }

            StreamWriter sw = new StreamWriter(fileName);//, false, Encoding.GetEncoding("Shift_JIS"));
            sw.WriteLine("���O:" + name);
            sw.WriteLine("Str:" + str);
            sw.WriteLine("Def:" + def);
            sw.WriteLine("Int:" + maso);
            sw.WriteLine("Mdef:" + mdef);
            sw.WriteLine("Mp:" + mp);
            sw.WriteLine("Hp:" + hp);
            sw.WriteLine("Lv:" + level);
            sw.WriteLine("����:" + zokusei);
            sw.WriteLine("�}��:" + zukan);
            sw.Close();

            return 0;
        }

        public int Read(string fileName)
        {
            if (File.Exists(fileName) == false) { return -1; }

            StreamReader sr = new StreamReader(fileName);//, Encoding.GetEncoding("Shift_JIS"));
            string[] data;

#pragma warning disable CS8602 // null �Q�Ƃ̉\����������̂̋t�Q�Ƃł��B
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            name = data[1];
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            str = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            def = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            maso = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            mdef = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            mp = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            hp = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            level = int.Parse(data[1]);
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            zokusei = data[1];
            data = sr.ReadLine().Split(":");
            if (data[0] == "") { sr.Close(); return -1; }
            zukan = data[1];
#pragma warning restore CS8602 // null �Q�Ƃ̉\����������̂̋t�Q�Ƃł��B
            sr.Close();

            return 0;
        }

        public int ReadImg(string fileName)
        {
            if (File.Exists(fileName) == false) { return -1; }
            pic = new();
            pic.Image = Image.FromFile(fileName);
            return 0;
        }
    }

    internal static class Program
    {
        public static void PTMenbarWrite(string path1, string path2, string path3)
        {
            int errPt = -1;

            for (int i = 0; i < mPtMenbar.Count(); i++)
            {
            retryPt:
                if (i == 0)
                {
                    errPt = mPtMenbar[i].Read(path1);
                }
                else if (i == 1)
                {
                    errPt = mPtMenbar[i].Read(path2);
                }
                else if (i == 2)
                {
                    errPt = mPtMenbar[i].Read(path3);
                }

                if (errPt == -1)
                {
                    Thread.Sleep(1000);
                    goto retryPt;
                }
            }
        }

        public static void PTMenbarRead(string path1, string path2, string path3, 
            int pt1ImgNo, int pt2ImgNo, int pt3ImgNo, int ptNum)
        {
            mPtMenbar.Clear();

            string currentDirectory = Environment.CurrentDirectory;
            Console.WriteLine("Current Directory: " + currentDirectory);

            PtMenbar ptMenbar;
            string pathImg1 = "", pathImg2 = "", pathIng3 = "";
            int errPt = -1, errPt1 = -1, errPt2 = -1, errPt3 = -1;

            pathImg1 = "3monImg\\�����X�^�[" + (pt1ImgNo) + ".png";
            pathImg2 = "3monImg\\�����X�^�[" + (pt2ImgNo) + ".png";
            pathIng3 = "3monImg\\�����X�^�[" + (pt3ImgNo) + ".png";

            for (int i = 0; i < ptNum; i++)
            {
            retryPt:
                ptMenbar = new();
                if (i == 0)
                {
                    errPt = ptMenbar.Read(path1);
                }
                else if (i == 1)
                {
                    errPt = ptMenbar.Read(path2);
                }
                else if (i == 2)
                {
                    errPt = ptMenbar.Read(path3);
                }

                if (errPt == -1)
                {
                    Thread.Sleep(1000);
                    goto retryPt;
                }
                // �����X�^�[�摜�ǂݍ���
            retryPtImg:
                if (i == 0)
                {
                    errPt1 = ptMenbar.ReadImg(pathImg1);
                    if (errPt1 == 0)
                    {
                        mPtMenbar.Add(ptMenbar);
                    }
                    else if (Player.pt1ImgNo == -1)
                    {
                    }
                    else if (errPt1 == -1)
                    {
                        Thread.Sleep(1000);
                        goto retryPtImg;
                    }
                }
                else if(i == 1)
                {
                    errPt2 = ptMenbar.ReadImg(pathImg2);
                    if (errPt2 == 0)
                    {
                        mPtMenbar.Add(ptMenbar);
                    }
                    else if (Player.pt2ImgNo == -1)
                    {
                    }
                    else if (errPt2 == -1)
                    {
                        Thread.Sleep(1000);
                        goto retryPtImg;
                    }
                }
                else if (i == 2)
                {
                    errPt3 = ptMenbar.ReadImg(pathIng3);
                    if (errPt3 == 0)
                    {
                        mPtMenbar.Add(ptMenbar);
                    }
                    else if (Player.pt3ImgNo == -1)
                    {
                    }
                    else if (errPt3 == -1)
                    {
                        Thread.Sleep(1000);
                        goto retryPtImg;
                    }
                }
            }
        }

        public static int GetAllPath(string folderPath, ref string[] files)
        {
            if (Directory.Exists(folderPath) == false) { return -1; }
            files = Directory.GetFiles(folderPath);
            return 0;
        }

        public static TitleMenu mTitleMenu;  // �Q�[���I�[�o�[�̎��Ƀ^�C�g���ɖ߂�
        public static MatiChange mMatiFlg = MatiChange.�҂��󂯉摜��ύX���Ȃ�;

        public static List<PtMenbar> mPtMenbar = new();

                /// <summary>
                ///  The main entry point for the application.
                /// </summary>
                [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new TitleMenu());
        }
    }
}