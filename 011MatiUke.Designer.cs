namespace GameRPG
{
    partial class MatiUke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panel_Game = new Panel();
            btn_MonGatya = new Button();
            btn_SoubiGatya = new Button();
            btn_Qest = new Button();
            btn_KyaraItiran = new Button();
            btn_Save = new Button();
            btn_SoubiItiran = new Button();
            btn_PtHensei = new Button();
            lbl_ReWrite = new Label();
            timer_Effect = new System.Windows.Forms.Timer(components);
            panel_Game.SuspendLayout();
            SuspendLayout();
            // 
            // panel_Game
            // 
            panel_Game.Controls.Add(btn_MonGatya);
            panel_Game.Controls.Add(btn_SoubiGatya);
            panel_Game.Controls.Add(btn_Qest);
            panel_Game.Controls.Add(btn_KyaraItiran);
            panel_Game.Controls.Add(btn_Save);
            panel_Game.Controls.Add(btn_SoubiItiran);
            panel_Game.Controls.Add(btn_PtHensei);
            panel_Game.Controls.Add(lbl_ReWrite);
            panel_Game.Dock = DockStyle.Fill;
            panel_Game.Location = new Point(0, 0);
            panel_Game.Name = "panel_Game";
            panel_Game.Size = new Size(624, 441);
            panel_Game.TabIndex = 0;
            // 
            // btn_MonGatya
            // 
            btn_MonGatya.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_MonGatya.Location = new Point(502, 242);
            btn_MonGatya.Name = "btn_MonGatya";
            btn_MonGatya.Size = new Size(119, 28);
            btn_MonGatya.TabIndex = 4;
            btn_MonGatya.Text = "モンスターガチャ";
            btn_MonGatya.UseVisualStyleBackColor = true;
            btn_MonGatya.Click += btn_MonGatya_Click;
            // 
            // btn_SoubiGatya
            // 
            btn_SoubiGatya.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_SoubiGatya.Location = new Point(513, 276);
            btn_SoubiGatya.Name = "btn_SoubiGatya";
            btn_SoubiGatya.Size = new Size(99, 28);
            btn_SoubiGatya.TabIndex = 4;
            btn_SoubiGatya.Text = "装備ガチャ";
            btn_SoubiGatya.UseVisualStyleBackColor = true;
            btn_SoubiGatya.Click += btn_SoubiGatya_Click;
            // 
            // btn_Qest
            // 
            btn_Qest.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_Qest.Location = new Point(265, 410);
            btn_Qest.Name = "btn_Qest";
            btn_Qest.Size = new Size(99, 28);
            btn_Qest.TabIndex = 4;
            btn_Qest.Text = "クエスト";
            btn_Qest.UseVisualStyleBackColor = true;
            btn_Qest.Click += btn_Qest_Click;
            // 
            // btn_KyaraItiran
            // 
            btn_KyaraItiran.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_KyaraItiran.Location = new Point(388, 410);
            btn_KyaraItiran.Name = "btn_KyaraItiran";
            btn_KyaraItiran.Size = new Size(99, 28);
            btn_KyaraItiran.TabIndex = 4;
            btn_KyaraItiran.Text = "キャラ一覧";
            btn_KyaraItiran.UseVisualStyleBackColor = true;
            btn_KyaraItiran.Click += btn_KyaraItiran_Click;
            // 
            // btn_Save
            // 
            btn_Save.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_Save.Location = new Point(506, 410);
            btn_Save.Name = "btn_Save";
            btn_Save.Size = new Size(99, 28);
            btn_Save.TabIndex = 4;
            btn_Save.Text = "セーブ";
            btn_Save.UseVisualStyleBackColor = true;
            btn_Save.Click += btn_Save_Click;
            // 
            // btn_SoubiItiran
            // 
            btn_SoubiItiran.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_SoubiItiran.Location = new Point(141, 410);
            btn_SoubiItiran.Name = "btn_SoubiItiran";
            btn_SoubiItiran.Size = new Size(99, 28);
            btn_SoubiItiran.TabIndex = 4;
            btn_SoubiItiran.Text = "装備一覧";
            btn_SoubiItiran.UseVisualStyleBackColor = true;
            btn_SoubiItiran.Click += btn_SoubiItiran_Click;
            // 
            // btn_PtHensei
            // 
            btn_PtHensei.Font = new Font("Yu Gothic UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_PtHensei.Location = new Point(16, 410);
            btn_PtHensei.Name = "btn_PtHensei";
            btn_PtHensei.Size = new Size(99, 28);
            btn_PtHensei.TabIndex = 4;
            btn_PtHensei.Text = "パーティ編成";
            btn_PtHensei.UseVisualStyleBackColor = true;
            btn_PtHensei.Click += btn_PtHensei_Click;
            // 
            // lbl_ReWrite
            // 
            lbl_ReWrite.AutoSize = true;
            lbl_ReWrite.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_ReWrite.Location = new Point(232, 189);
            lbl_ReWrite.Name = "lbl_ReWrite";
            lbl_ReWrite.Size = new Size(125, 32);
            lbl_ReWrite.TabIndex = 3;
            lbl_ReWrite.Text = "書き込み中";
            lbl_ReWrite.Visible = false;
            // 
            // timer_Effect
            // 
            timer_Effect.Tick += timer_Effect_Tick;
            // 
            // MatiUke
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(panel_Game);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "MatiUke";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += MatiUke_FormClosing;
            Shown += MatiUke_Shown;
            panel_Game.ResumeLayout(false);
            panel_Game.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Game;
        private System.Windows.Forms.Timer timer_Effect;
        private Label lbl_ReWrite;
        private Button btn_SoubiItiran;
        private Button btn_PtHensei;
        private Button btn_MonGatya;
        private Button btn_SoubiGatya;
        private Button btn_Qest;
        private Button btn_KyaraItiran;
        private Button btn_Save;
    }
}