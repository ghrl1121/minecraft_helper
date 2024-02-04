namespace 마인크래프트도우미
{
    partial class Form2
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
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 28);
            button1.Name = "button1";
            button1.Size = new Size(91, 71);
            button1.TabIndex = 0;
            button1.Text = "리소스팩";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(115, 28);
            button2.Name = "button2";
            button2.Size = new Size(91, 71);
            button2.TabIndex = 1;
            button2.Text = "서버 리소스팩\r\n초기화\r\n";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(218, 114);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form2";
            Text = "리소스팩";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
    }
}