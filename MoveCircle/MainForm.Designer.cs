namespace MoveCircle
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
            components = new System.ComponentModel.Container();
            splitContainer = new SplitContainer();
            label5 = new Label();
            textTimer = new TextBox();
            label4 = new Label();
            restartButton = new Button();
            selectPictureBox = new PictureBox();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            textHunt = new TextBox();
            mainPictureBox = new PictureBox();
            timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)selectPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 0);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(label5);
            splitContainer.Panel1.Controls.Add(textTimer);
            splitContainer.Panel1.Controls.Add(label4);
            splitContainer.Panel1.Controls.Add(restartButton);
            splitContainer.Panel1.Controls.Add(selectPictureBox);
            splitContainer.Panel1.Controls.Add(label3);
            splitContainer.Panel1.Controls.Add(label1);
            splitContainer.Panel1.Controls.Add(label2);
            splitContainer.Panel1.Controls.Add(textHunt);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(mainPictureBox);
            splitContainer.Size = new Size(1184, 761);
            splitContainer.SplitterDistance = 70;
            splitContainer.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(944, 27);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 7;
            label5.Text = "秒";
            // 
            // textTimer
            // 
            textTimer.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textTimer.Location = new Point(808, 17);
            textTimer.Name = "textTimer";
            textTimer.Size = new Size(130, 36);
            textTimer.TabIndex = 1;
            textTimer.TextAlign = HorizontalAlignment.Right;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(759, 27);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 6;
            label4.Text = "記録：";
            // 
            // restartButton
            // 
            restartButton.Location = new Point(653, 17);
            restartButton.Name = "restartButton";
            restartButton.Size = new Size(100, 35);
            restartButton.TabIndex = 5;
            restartButton.Text = "再スタート";
            restartButton.UseVisualStyleBackColor = true;
            restartButton.Click += restartButton_Click;
            // 
            // selectPictureBox
            // 
            selectPictureBox.BackColor = Color.White;
            selectPictureBox.Location = new Point(372, 12);
            selectPictureBox.Name = "selectPictureBox";
            selectPictureBox.Size = new Size(275, 50);
            selectPictureBox.TabIndex = 4;
            selectPictureBox.TabStop = false;
            selectPictureBox.MouseClick += selectPictureBox_MouseClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 37);
            label3.Name = "label3";
            label3.Size = new Size(259, 15);
            label3.TabIndex = 3;
            label3.Text = "↓下のエリアをクリックするとボールの位置が変わります";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 27);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 1;
            label1.Text = "を探せ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 17);
            label2.Name = "label2";
            label2.Size = new Size(257, 15);
            label2.TabIndex = 2;
            label2.Text = "下の背景に表示された漢字と同じ色の円をクリック→";
            // 
            // textHunt
            // 
            textHunt.Font = new Font("Yu Gothic UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 128);
            textHunt.Location = new Point(12, 17);
            textHunt.Name = "textHunt";
            textHunt.Size = new Size(45, 36);
            textHunt.TabIndex = 0;
            // 
            // mainPictureBox
            // 
            mainPictureBox.BackColor = Color.White;
            mainPictureBox.Dock = DockStyle.Fill;
            mainPictureBox.Location = new Point(0, 0);
            mainPictureBox.Name = "mainPictureBox";
            mainPictureBox.Size = new Size(1184, 687);
            mainPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            mainPictureBox.TabIndex = 5;
            mainPictureBox.TabStop = false;
            // 
            // timer
            // 
            timer.Interval = 20;
            timer.Tick += timer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(splitContainer);
            Name = "MainForm";
            Text = "間違いボール探し";
            Load += MainForm_Load;
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel1.PerformLayout();
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)selectPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer;
        private TextBox textHunt;
        private PictureBox selectPictureBox;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button restartButton;
        private Label label5;
        private TextBox textTimer;
        private PictureBox mainPictureBox;
        private System.Windows.Forms.Timer timer;
    }
}
