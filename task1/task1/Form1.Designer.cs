using System.Windows.Forms;

namespace task1
{
    partial class Form1
    {
        ///  Required designer variable.
        private System.ComponentModel.IContainer components = null;
        private object label;
        private TextBox textBox;
        ///  Clean up any resources being used.
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            textBox1 = new TextBox();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label4 = new Label();
            label2 = new Label();
            tabPage2 = new TabPage();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            radioButton4 = new RadioButton();
            radioButton1 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 81);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1055, 558);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DarkViolet;
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1047, 530);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            // 
            // label4
            // 
            label4.BackColor = Color.DarkOrchid;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Millimeter);
            label4.ForeColor = Color.PaleGoldenrod;
            label4.ImageAlign = ContentAlignment.BottomCenter;
            label4.Location = new Point(48, 181);
            label4.Name = "label4";
            label4.Size = new Size(900, 300);
            label4.TabIndex = 3;
            label4.Text = "This a introducciont label to choose the best pic from stormlight";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.MediumOrchid;
            label2.Font = new Font("Segoe UI", 45F);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(26, 23);
            label2.Name = "label2";
            label2.Size = new Size(1000, 100);
            label2.TabIndex = 2;
            label2.Text = "Introduction to voting";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // tabPage2
            // 
            tabPage2.AutoScroll = true;
            tabPage2.BackColor = Color.MediumPurple;
            tabPage2.Controls.Add(pictureBox5);
            tabPage2.Controls.Add(pictureBox4);
            tabPage2.Controls.Add(radioButton4);
            tabPage2.Controls.Add(radioButton1);
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(radioButton2);
            tabPage2.Controls.Add(pictureBox1);
            tabPage2.Controls.Add(pictureBox2);
            tabPage2.Controls.Add(label3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(1047, 530);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(18, 6);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(210, 243);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.Image = Properties.Resources.p6eSPnu;
            pictureBox4.Location = new Point(18, 270);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(210, 243);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // radioButton4
            // 
            radioButton4.AccessibleDescription = "";
            radioButton4.AccessibleName = "Button";
            radioButton4.ForeColor = SystemColors.ActiveCaptionText;
            radioButton4.Location = new Point(265, 403);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(100, 50);
            radioButton4.TabIndex = 12;
            radioButton4.TabStop = true;
            radioButton4.Text = "Jasnah Kholin";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AccessibleDescription = "";
            radioButton1.AccessibleName = "Button";
            radioButton1.ForeColor = SystemColors.ActiveCaptionText;
            radioButton1.Location = new Point(265, 111);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(100, 50);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Hijo vallano";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AccessibleDescription = "";
            radioButton3.AccessibleName = "Button";
            radioButton3.BackColor = Color.Transparent;
            radioButton3.ForeColor = SystemColors.ActiveCaptionText;
            radioButton3.Location = new Point(610, 403);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(100, 50);
            radioButton3.TabIndex = 9;
            radioButton3.TabStop = true;
            radioButton3.Text = "Shallan";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton2
            // 
            radioButton2.AccessibleDescription = "";
            radioButton2.AccessibleName = "Button";
            radioButton2.ForeColor = SystemColors.ActiveCaptionText;
            radioButton2.Location = new Point(610, 111);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(100, 50);
            radioButton2.TabIndex = 8;
            radioButton2.TabStop = true;
            radioButton2.Text = "Kaladin";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(775, 270);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(210, 243);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.Location = new Point(775, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(210, 243);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 6;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 45F);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(342, 204);
            label3.Name = "label3";
            label3.Size = new Size(270, 100);
            label3.TabIndex = 3;
            label3.Text = "Voting";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 561);
            Controls.Add(tabControl1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            ForeColor = SystemColors.ActiveBorder;
            Name = "Form1";
            Text = "FormLooser";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        public void Label()
        {
            Label label = new Label
            {
                Text = "Label1",
                Location = new System.Drawing.Point(10, 10),
                Size = new System.Drawing.Size(200, 30)
            };
            this.Controls.Add(label);
        }

        private void PictureBox()
        {
            PictureBox pictureBox = new PictureBox
            {
                Text = "Picture Box",
                Location = new System.Drawing.Point(20, 20),
                Size = new System.Drawing.Size(100, 30)

            };
            pictureBox.BackColor = Color.BlueViolet;
            this.Controls.Add(pictureBox);
        }
        private void RobotTexto()
        {
            TextBox text = new TextBox()
            {
                Text = "TextBox Example",
                Location = new System.Drawing.Point(10,50),
                Size = new System.Drawing.Size(50, 30)
            };
            text.BackColor = Color.BlueViolet;
            this.Controls.Add(text);
        }
        private void BarraTool()
        {
            Label mainContentLabel = new Label
            {
                Text = "Tool Bar",
                Location = new System.Drawing.Point(10, 50),
                Size = new System.Drawing.Size(200, 30)
            };

            this.Controls.Add(mainContentLabel);
        }

        private void Pestaña()
        {
            String title = "Pestaña 1 ";
            TabControl tabControl = new TabControl();
            tabControl.Name = title;
            tabControl.BackColor = Color.BlueViolet;
            tabControl.Font = new Font("Georgia", 16);
            tabControl.Width = 50;
            tabControl.Height = 12;


            TabPage button = new TabPage();
            button.Name = title;
            button.Text = "Text de ejemplo";
            button.BackColor = Color.BlueViolet;
            button.Font = new Font("Georgia", 16);
            button.Width = 50;
            button.Height = 12;

            tabControl.Controls.Add(button);

        }

        private void RadioButtons()
        {
            Label mainContentLabel = new Label
            {
                Text = "Main Content Area",
                Location = new System.Drawing.Point(10, 50),
                Size = new System.Drawing.Size(200, 30)
            };

            this.Controls.Add(mainContentLabel);
        }

        private void ComboBox() //Edit box
        {
            Label mainContentLabel = new Label
            {
                Text = "Main Content Area",
                Location = new System.Drawing.Point(10, 50),
                Size = new System.Drawing.Size(200, 30)
            };

            this.Controls.Add(mainContentLabel);
        }

        private Label label1;
        private TextBox textBox1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Label label3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Label label4;
        private PictureBox pictureBox4;
        private RadioButton radioButton4;
        private RadioButton radioButton1;
        private PictureBox pictureBox5;
    }
}
