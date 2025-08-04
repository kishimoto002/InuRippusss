namespace GameRPG
{
    partial class TitleMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel_Game = new Panel();
            btn_SoundTest = new Button();
            btn_End = new Button();
            btn_Tuzuki = new Button();
            btn_Start = new Button();
            panel_Game.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Game
            // 
            panel_Game.Controls.Add(btn_SoundTest);
            panel_Game.Controls.Add(btn_End);
            panel_Game.Controls.Add(btn_Tuzuki);
            panel_Game.Controls.Add(btn_Start);
            panel_Game.Dock = DockStyle.Fill;
            panel_Game.Location = new Point(0, 0);
            panel_Game.Name = "panel_Game";
            panel_Game.Size = new Size(624, 441);
            panel_Game.TabIndex = 0;
            // 
            // btn_SoundTest
            // 
            btn_SoundTest.Location = new Point(314, 332);
            btn_SoundTest.Name = "btn_SoundTest";
            btn_SoundTest.Size = new Size(114, 34);
            btn_SoundTest.TabIndex = 0;
            btn_SoundTest.Text = "音楽集";
            btn_SoundTest.UseVisualStyleBackColor = true;
            btn_SoundTest.Click += btn_SoundTest_Click;
            // 
            // btn_End
            // 
            btn_End.Location = new Point(434, 332);
            btn_End.Name = "btn_End";
            btn_End.Size = new Size(114, 34);
            btn_End.TabIndex = 0;
            btn_End.Text = "終了";
            btn_End.UseVisualStyleBackColor = true;
            btn_End.Click += btn_End_Click;
            // 
            // btn_Tuzuki
            // 
            btn_Tuzuki.Location = new Point(194, 332);
            btn_Tuzuki.Name = "btn_Tuzuki";
            btn_Tuzuki.Size = new Size(114, 34);
            btn_Tuzuki.TabIndex = 0;
            btn_Tuzuki.Text = "続きから";
            btn_Tuzuki.UseVisualStyleBackColor = true;
            btn_Tuzuki.Click += btn_Tuzuki_Click;
            // 
            // btn_Start
            // 
            btn_Start.Location = new Point(74, 332);
            btn_Start.Name = "btn_Start";
            btn_Start.Size = new Size(114, 34);
            btn_Start.TabIndex = 0;
            btn_Start.Text = "初めから";
            btn_Start.UseVisualStyleBackColor = true;
            btn_Start.Click += btn_Start_Click;
            // 
            // TitleMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(panel_Game);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "TitleMenu";
            StartPosition = FormStartPosition.CenterScreen;
            panel_Game.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Game;
        private Button btn_End;
        private Button btn_Tuzuki;
        private Button btn_Start;
        private Button btn_SoundTest;
    }
}
