namespace 마인크래프트도우미
{
    partial class Form1
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 29);
            button1.Name = "button1";
            button1.Size = new Size(75, 100);
            button1.TabIndex = 0;
            button1.Text = "실행";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(93, 29);
            button2.Name = "button2";
            button2.Size = new Size(75, 100);
            button2.TabIndex = 1;
            button2.Text = "맵";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(174, 29);
            button3.Name = "button3";
            button3.Size = new Size(75, 100);
            button3.TabIndex = 2;
            button3.Text = "모드";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(255, 29);
            button4.Name = "button4";
            button4.Size = new Size(75, 100);
            button4.TabIndex = 3;
            button4.Text = "스크린샷";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(93, 155);
            button5.Name = "button5";
            button5.Size = new Size(75, 100);
            button5.TabIndex = 4;
            button5.Text = "로그(logs)";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(12, 155);
            button6.Name = "button6";
            button6.Size = new Size(75, 100);
            button6.TabIndex = 5;
            button6.Text = "리소스팩 설정\r\n";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(174, 155);
            button7.Name = "button7";
            button7.Size = new Size(75, 100);
            button7.TabIndex = 6;
            button7.Text = "세이더";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 273);
            label1.Name = "label1";
            label1.Size = new Size(161, 45);
            label1.TabIndex = 7;
            label1.Text = "만든이 : ghrl1121\r\n\r\n만든프로그램 : Visual Studio";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(12, 335);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(59, 15);
            linkLabel1.TabIndex = 8;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "코드 보기";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(346, 401);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            Name = "Form1";
            Text = "마인크래프트 도우미";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label1;
        private LinkLabel linkLabel1;
    }
}
