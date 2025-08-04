namespace GameRPG
{
    partial class Tuduki
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
            btn_Yes = new Button();
            btn_No = new Button();
            lbl_SaveDataRead = new Label();
            lbl_NoSaveData = new Label();
            lbl_PlayerName = new Label();
            lbl_QestClear = new Label();
            lbl_PlayerNameText = new Label();
            lbl_QestClearText = new Label();
            lbl_ReLord = new Label();
            lbl_NyuusyuMon = new Label();
            lbl_NyuusyuMonText = new Label();
            SuspendLayout();
            // 
            // btn_Yes
            // 
            btn_Yes.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_Yes.Location = new Point(22, 38);
            btn_Yes.Name = "btn_Yes";
            btn_Yes.Size = new Size(98, 40);
            btn_Yes.TabIndex = 0;
            btn_Yes.Text = "はい";
            btn_Yes.UseVisualStyleBackColor = true;
            btn_Yes.Click += btn_Yes_Click;
            // 
            // btn_No
            // 
            btn_No.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_No.Location = new Point(22, 84);
            btn_No.Name = "btn_No";
            btn_No.Size = new Size(98, 40);
            btn_No.TabIndex = 1;
            btn_No.Text = "いいえ";
            btn_No.UseVisualStyleBackColor = true;
            btn_No.Click += btn_No_Click;
            // 
            // lbl_SaveDataRead
            // 
            lbl_SaveDataRead.AutoSize = true;
            lbl_SaveDataRead.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_SaveDataRead.Location = new Point(160, 9);
            lbl_SaveDataRead.Name = "lbl_SaveDataRead";
            lbl_SaveDataRead.Size = new Size(307, 32);
            lbl_SaveDataRead.TabIndex = 2;
            lbl_SaveDataRead.Text = "セーブデータを読み込みますか？";
            // 
            // lbl_NoSaveData
            // 
            lbl_NoSaveData.AutoSize = true;
            lbl_NoSaveData.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_NoSaveData.Location = new Point(160, 84);
            lbl_NoSaveData.Name = "lbl_NoSaveData";
            lbl_NoSaveData.Size = new Size(230, 32);
            lbl_NoSaveData.TabIndex = 2;
            lbl_NoSaveData.Text = "セーブデータがありません";
            lbl_NoSaveData.Visible = false;
            // 
            // lbl_PlayerName
            // 
            lbl_PlayerName.AutoSize = true;
            lbl_PlayerName.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_PlayerName.Location = new Point(160, 128);
            lbl_PlayerName.Name = "lbl_PlayerName";
            lbl_PlayerName.Size = new Size(148, 32);
            lbl_PlayerName.TabIndex = 3;
            lbl_PlayerName.Text = "プレイヤー名：";
            // 
            // lbl_QestClear
            // 
            lbl_QestClear.AutoSize = true;
            lbl_QestClear.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_QestClear.Location = new Point(145, 160);
            lbl_QestClear.Name = "lbl_QestClear";
            lbl_QestClear.Size = new Size(163, 32);
            lbl_QestClear.TabIndex = 3;
            lbl_QestClear.Text = "クエストクリア：";
            // 
            // lbl_PlayerNameText
            // 
            lbl_PlayerNameText.AutoSize = true;
            lbl_PlayerNameText.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_PlayerNameText.Location = new Point(303, 128);
            lbl_PlayerNameText.Name = "lbl_PlayerNameText";
            lbl_PlayerNameText.Size = new Size(134, 32);
            lbl_PlayerNameText.TabIndex = 4;
            lbl_PlayerNameText.Text = "　　　　　";
            // 
            // lbl_QestClearText
            // 
            lbl_QestClearText.AutoSize = true;
            lbl_QestClearText.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_QestClearText.Location = new Point(303, 160);
            lbl_QestClearText.Name = "lbl_QestClearText";
            lbl_QestClearText.Size = new Size(134, 32);
            lbl_QestClearText.TabIndex = 4;
            lbl_QestClearText.Text = "　　　　　";
            // 
            // lbl_ReLord
            // 
            lbl_ReLord.AutoSize = true;
            lbl_ReLord.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_ReLord.Location = new Point(160, 42);
            lbl_ReLord.Name = "lbl_ReLord";
            lbl_ReLord.Size = new Size(128, 32);
            lbl_ReLord.TabIndex = 2;
            lbl_ReLord.Text = "読み込み中";
            lbl_ReLord.Visible = false;
            // 
            // lbl_NyuusyuMon
            // 
            lbl_NyuusyuMon.AutoSize = true;
            lbl_NyuusyuMon.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_NyuusyuMon.Location = new Point(111, 192);
            lbl_NyuusyuMon.Name = "lbl_NyuusyuMon";
            lbl_NyuusyuMon.Size = new Size(197, 32);
            lbl_NyuusyuMon.TabIndex = 3;
            lbl_NyuusyuMon.Text = "入手モンスター数：";
            // 
            // lbl_NyuusyuMonText
            // 
            lbl_NyuusyuMonText.AutoSize = true;
            lbl_NyuusyuMonText.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_NyuusyuMonText.Location = new Point(303, 192);
            lbl_NyuusyuMonText.Name = "lbl_NyuusyuMonText";
            lbl_NyuusyuMonText.Size = new Size(134, 32);
            lbl_NyuusyuMonText.TabIndex = 4;
            lbl_NyuusyuMonText.Text = "　　　　　";
            // 
            // Tuduki
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 261);
            Controls.Add(lbl_NyuusyuMonText);
            Controls.Add(lbl_QestClearText);
            Controls.Add(lbl_PlayerNameText);
            Controls.Add(lbl_NyuusyuMon);
            Controls.Add(lbl_QestClear);
            Controls.Add(lbl_PlayerName);
            Controls.Add(lbl_NoSaveData);
            Controls.Add(lbl_ReLord);
            Controls.Add(lbl_SaveDataRead);
            Controls.Add(btn_No);
            Controls.Add(btn_Yes);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "Tuduki";
            StartPosition = FormStartPosition.CenterScreen;
            Shown += Tuduki_Shown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Yes;
        private Button btn_No;
        private Label lbl_SaveDataRead;
        private Label lbl_NoSaveData;
        private Label lbl_PlayerName;
        private Label lbl_QestClear;
        private Label lbl_PlayerNameText;
        private Label lbl_QestClearText;
        private Label lbl_ReLord;
        private Label lbl_NyuusyuMon;
        private Label lbl_NyuusyuMonText;
    }
}