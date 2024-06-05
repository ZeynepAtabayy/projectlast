namespace Project
{
    partial class Form4
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
            textBox1 = new TextBox();
            btnCancel = new Button();
            richTextBox1 = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtYouTubeId = new TextBox();
            txtYouTubeLink = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 0);
            textBox1.Margin = new Padding(2, 2, 2, 2);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(1240, 58);
            textBox1.TabIndex = 0;
            textBox1.Text = "Update Video";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(1102, 10);
            btnCancel.Margin = new Padding(2, 2, 2, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(90, 27);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.BackColor = Color.FromArgb(255, 192, 192);
            richTextBox1.Location = new Point(174, 81);
            richTextBox1.Margin = new Padding(2, 2, 2, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.ReadOnly = true;
            richTextBox1.Size = new Size(827, 371);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 193);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 3;
            label1.Text = "Youtube Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(268, 264);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 20);
            label2.TabIndex = 4;
            label2.Text = "Youtube Link";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(268, 343);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 5;
            label3.Text = "Youtube Describtion";
            // 
            // txtYouTubeId
            // 
            txtYouTubeId.Location = new Point(476, 193);
            txtYouTubeId.Margin = new Padding(2, 2, 2, 2);
            txtYouTubeId.Name = "txtYouTubeId";
            txtYouTubeId.Size = new Size(438, 27);
            txtYouTubeId.TabIndex = 6;
            // 
            // txtYouTubeLink
            // 
            txtYouTubeLink.Location = new Point(476, 264);
            txtYouTubeLink.Margin = new Padding(2, 2, 2, 2);
            txtYouTubeLink.Name = "txtYouTubeLink";
            txtYouTubeLink.Size = new Size(438, 27);
            txtYouTubeLink.TabIndex = 7;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(476, 343);
            txtDescription.Margin = new Padding(2, 2, 2, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(438, 27);
            txtDescription.TabIndex = 8;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(624, 403);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(90, 27);
            btnSave.TabIndex = 9;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1249, 527);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtYouTubeLink);
            Controls.Add(txtYouTubeId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(richTextBox1);
            Controls.Add(btnCancel);
            Controls.Add(textBox1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form4";
            Text = "Video Update";
            Load += Form4_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button btnCancel;
        private RichTextBox richTextBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtYouTubeId;
        private TextBox txtYouTubeLink;
        private TextBox txtDescription;
        private Button btnSave;
    }
}