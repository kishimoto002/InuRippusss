namespace GameRPG
{
    partial class InputName
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
            txt_Name = new TextBox();
            lbl_Name = new Label();
            btn_Kettei = new Button();
            lbl_moziLimit = new Label();
            lbl_ReLord = new Label();
            SuspendLayout();
            // 
            // txt_Name
            // 
            txt_Name.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            txt_Name.Location = new Point(153, 113);
            txt_Name.MaxLength = 8;
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(232, 39);
            txt_Name.TabIndex = 0;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_Name.Location = new Point(13, 116);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(134, 32);
            lbl_Name.TabIndex = 1;
            lbl_Name.Text = "名前入力：";
            // 
            // btn_Kettei
            // 
            btn_Kettei.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            btn_Kettei.Location = new Point(423, 111);
            btn_Kettei.Name = "btn_Kettei";
            btn_Kettei.Size = new Size(116, 43);
            btn_Kettei.TabIndex = 2;
            btn_Kettei.Text = "決定";
            btn_Kettei.UseVisualStyleBackColor = true;
            btn_Kettei.Click += btn_Kettei_Click;
            // 
            // lbl_moziLimit
            // 
            lbl_moziLimit.AutoSize = true;
            lbl_moziLimit.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_moziLimit.Location = new Point(153, 166);
            lbl_moziLimit.Name = "lbl_moziLimit";
            lbl_moziLimit.Size = new Size(232, 32);
            lbl_moziLimit.TabIndex = 3;
            lbl_moziLimit.Text = "全角8文字まで入力可";
            // 
            // lbl_ReLord
            // 
            lbl_ReLord.AutoSize = true;
            lbl_ReLord.Font = new Font("Yu Gothic UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 128);
            lbl_ReLord.Location = new Point(248, 204);
            lbl_ReLord.Name = "lbl_ReLord";
            lbl_ReLord.Size = new Size(128, 32);
            lbl_ReLord.TabIndex = 4;
            lbl_ReLord.Text = "読み込み中";
            lbl_ReLord.Visible = false;
            // 
            // InputName
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 441);
            Controls.Add(lbl_ReLord);
            Controls.Add(lbl_moziLimit);
            Controls.Add(btn_Kettei);
            Controls.Add(lbl_Name);
            Controls.Add(txt_Name);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "InputName";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += InputName_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_Name;
        private Label lbl_Name;
        private Button btn_Kettei;
        private Label lbl_moziLimit;
        private Label lbl_ReLord;
    }
}