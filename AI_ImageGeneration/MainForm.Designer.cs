namespace AI_ImageGeneration
{
    partial class MainForm
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
            lblApiKey = new Label();
            txtApiKey = new TextBox();
            lblModel = new Label();
            cbModel = new ComboBox();
            txtUserPrompt = new TextBox();
            lblUserPrompt = new Label();
            lblGptUsedPrompt = new Label();
            txtGeneratedPrompt = new TextBox();
            pictureBox1 = new PictureBox();
            btnGenerate = new Button();
            label1 = new Label();
            btnCopyPrompt = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblApiKey
            // 
            lblApiKey.AutoSize = true;
            lblApiKey.Location = new Point(12, 15);
            lblApiKey.Name = "lblApiKey";
            lblApiKey.Size = new Size(46, 15);
            lblApiKey.TabIndex = 0;
            lblApiKey.Text = "API key";
            // 
            // txtApiKey
            // 
            txtApiKey.Location = new Point(64, 12);
            txtApiKey.Name = "txtApiKey";
            txtApiKey.Size = new Size(227, 23);
            txtApiKey.TabIndex = 1;
            // 
            // lblModel
            // 
            lblModel.AutoSize = true;
            lblModel.Location = new Point(12, 44);
            lblModel.Name = "lblModel";
            lblModel.Size = new Size(41, 15);
            lblModel.TabIndex = 2;
            lblModel.Text = "Model";
            // 
            // cbModel
            // 
            cbModel.DropDownStyle = ComboBoxStyle.DropDownList;
            cbModel.FormattingEnabled = true;
            cbModel.Location = new Point(64, 41);
            cbModel.Name = "cbModel";
            cbModel.Size = new Size(121, 23);
            cbModel.TabIndex = 3;
            // 
            // txtUserPrompt
            // 
            txtUserPrompt.Location = new Point(12, 118);
            txtUserPrompt.Multiline = true;
            txtUserPrompt.Name = "txtUserPrompt";
            txtUserPrompt.Size = new Size(310, 128);
            txtUserPrompt.TabIndex = 4;
            txtUserPrompt.Text = "Sunset. You can see the sea on the left, the mountains on the right. There is a beach at the bottom center. In the distance you can see a small boat sailing by.";
            // 
            // lblUserPrompt
            // 
            lblUserPrompt.AutoSize = true;
            lblUserPrompt.Location = new Point(12, 100);
            lblUserPrompt.Name = "lblUserPrompt";
            lblUserPrompt.Size = new Size(73, 15);
            lblUserPrompt.TabIndex = 5;
            lblUserPrompt.Text = "User prompt";
            // 
            // lblGptUsedPrompt
            // 
            lblGptUsedPrompt.AutoSize = true;
            lblGptUsedPrompt.Location = new Point(12, 291);
            lblGptUsedPrompt.Name = "lblGptUsedPrompt";
            lblGptUsedPrompt.Size = new Size(76, 15);
            lblGptUsedPrompt.TabIndex = 7;
            lblGptUsedPrompt.Text = "Used prompt";
            // 
            // txtGeneratedPrompt
            // 
            txtGeneratedPrompt.Location = new Point(12, 309);
            txtGeneratedPrompt.Multiline = true;
            txtGeneratedPrompt.Name = "txtGeneratedPrompt";
            txtGeneratedPrompt.ReadOnly = true;
            txtGeneratedPrompt.Size = new Size(310, 128);
            txtGeneratedPrompt.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(328, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(531, 425);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.DoubleClick += pictureBox1_DoubleClick;
            // 
            // btnGenerate
            // 
            btnGenerate.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGenerate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnGenerate.Location = new Point(742, 443);
            btnGenerate.Name = "btnGenerate";
            btnGenerate.Size = new Size(117, 23);
            btnGenerate.TabIndex = 9;
            btnGenerate.Text = "Generate image";
            btnGenerate.UseVisualStyleBackColor = true;
            btnGenerate.Click += btnGenerate_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            label1.Location = new Point(399, 440);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 10;
            label1.Text = "Double-click to open image";
            // 
            // btnCopyPrompt
            // 
            btnCopyPrompt.Location = new Point(144, 280);
            btnCopyPrompt.Name = "btnCopyPrompt";
            btnCopyPrompt.Size = new Size(178, 23);
            btnCopyPrompt.TabIndex = 11;
            btnCopyPrompt.Text = "Copy to \"User prompt\" field";
            btnCopyPrompt.UseVisualStyleBackColor = true;
            btnCopyPrompt.Click += btnCopyPrompt_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(871, 478);
            Controls.Add(btnCopyPrompt);
            Controls.Add(label1);
            Controls.Add(btnGenerate);
            Controls.Add(pictureBox1);
            Controls.Add(lblGptUsedPrompt);
            Controls.Add(txtGeneratedPrompt);
            Controls.Add(lblUserPrompt);
            Controls.Add(txtUserPrompt);
            Controls.Add(cbModel);
            Controls.Add(lblModel);
            Controls.Add(txtApiKey);
            Controls.Add(lblApiKey);
            MaximizeBox = false;
            MinimumSize = new Size(816, 446);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AI Image Generation";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblApiKey;
        private TextBox txtApiKey;
        private Label lblModel;
        private ComboBox cbModel;
        private TextBox txtUserPrompt;
        private Label lblUserPrompt;
        private Label lblGptUsedPrompt;
        private TextBox txtGeneratedPrompt;
        private PictureBox pictureBox1;
        private Button btnGenerate;
        private Label label1;
        private Button btnCopyPrompt;
    }
}
