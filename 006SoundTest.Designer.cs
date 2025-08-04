namespace GameRPG
{
    partial class SoundTest
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
            cmb_SE = new ComboBox();
            cmb_BGM = new ComboBox();
            btn_SE = new Button();
            btn_BGM = new Button();
            SuspendLayout();
            // 
            // cmb_SE
            // 
            cmb_SE.FormattingEnabled = true;
            cmb_SE.Location = new Point(12, 34);
            cmb_SE.Name = "cmb_SE";
            cmb_SE.Size = new Size(368, 23);
            cmb_SE.TabIndex = 0;
            // 
            // cmb_BGM
            // 
            cmb_BGM.FormattingEnabled = true;
            cmb_BGM.Location = new Point(12, 104);
            cmb_BGM.Name = "cmb_BGM";
            cmb_BGM.Size = new Size(368, 23);
            cmb_BGM.TabIndex = 0;
            // 
            // btn_SE
            // 
            btn_SE.Location = new Point(386, 29);
            btn_SE.Name = "btn_SE";
            btn_SE.Size = new Size(55, 31);
            btn_SE.TabIndex = 1;
            btn_SE.Text = "SE再生";
            btn_SE.UseVisualStyleBackColor = true;
            btn_SE.Click += btn_SE_Click;
            // 
            // btn_BGM
            // 
            btn_BGM.Location = new Point(386, 99);
            btn_BGM.Name = "btn_BGM";
            btn_BGM.Size = new Size(66, 31);
            btn_BGM.TabIndex = 1;
            btn_BGM.Text = "BGM再生";
            btn_BGM.UseVisualStyleBackColor = true;
            btn_BGM.Click += btn_BGM_Click;
            // 
            // SoundTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(464, 201);
            Controls.Add(btn_BGM);
            Controls.Add(btn_SE);
            Controls.Add(cmb_BGM);
            Controls.Add(cmb_SE);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "SoundTest";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += SoundTest_FormClosing;
            Shown += SoundTest_Shown;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cmb_SE;
        private ComboBox cmb_BGM;
        private Button btn_SE;
        private Button btn_BGM;
    }
}