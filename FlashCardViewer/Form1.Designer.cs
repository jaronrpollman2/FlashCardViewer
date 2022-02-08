namespace FlashCardViewer
{
    partial class frm_Main
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
            this.gpb_RadioButtons = new System.Windows.Forms.GroupBox();
            this.rdb_AnswerD = new System.Windows.Forms.RadioButton();
            this.rdb_AnswerC = new System.Windows.Forms.RadioButton();
            this.rdb_AnswerB = new System.Windows.Forms.RadioButton();
            this.rdb_AnswerA = new System.Windows.Forms.RadioButton();
            this.btn_Next = new System.Windows.Forms.Button();
            this.lbl_QuestionNumber = new System.Windows.Forms.Label();
            this.btn_Solution = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_PostImage = new System.Windows.Forms.Label();
            this.lbl_Panel_PrePicture = new System.Windows.Forms.Label();
            this.pic_QuestionPictureBox = new System.Windows.Forms.PictureBox();
            this.pnl_Question = new System.Windows.Forms.Panel();
            this.pnl_Buttons = new System.Windows.Forms.Panel();
            this.gpb_RadioButtons.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_QuestionPictureBox)).BeginInit();
            this.pnl_Question.SuspendLayout();
            this.pnl_Buttons.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpb_RadioButtons
            // 
            this.gpb_RadioButtons.Controls.Add(this.rdb_AnswerD);
            this.gpb_RadioButtons.Controls.Add(this.rdb_AnswerC);
            this.gpb_RadioButtons.Controls.Add(this.rdb_AnswerB);
            this.gpb_RadioButtons.Controls.Add(this.rdb_AnswerA);
            this.gpb_RadioButtons.Location = new System.Drawing.Point(6, 96);
            this.gpb_RadioButtons.Name = "gpb_RadioButtons";
            this.gpb_RadioButtons.Size = new System.Drawing.Size(447, 140);
            this.gpb_RadioButtons.TabIndex = 0;
            this.gpb_RadioButtons.TabStop = false;
            this.gpb_RadioButtons.Text = "Answers";
            this.gpb_RadioButtons.Enter += new System.EventHandler(this.gpb_RadioButtons_Enter);
            // 
            // rdb_AnswerD
            // 
            this.rdb_AnswerD.Location = new System.Drawing.Point(6, 88);
            this.rdb_AnswerD.Name = "rdb_AnswerD";
            this.rdb_AnswerD.Size = new System.Drawing.Size(85, 17);
            this.rdb_AnswerD.TabIndex = 3;
            this.rdb_AnswerD.TabStop = true;
            this.rdb_AnswerD.Text = "radioButton4";
            this.rdb_AnswerD.UseVisualStyleBackColor = true;
            // 
            // rdb_AnswerC
            // 
            this.rdb_AnswerC.Location = new System.Drawing.Point(6, 65);
            this.rdb_AnswerC.Name = "rdb_AnswerC";
            this.rdb_AnswerC.Size = new System.Drawing.Size(85, 17);
            this.rdb_AnswerC.TabIndex = 2;
            this.rdb_AnswerC.TabStop = true;
            this.rdb_AnswerC.Text = "radioButton3";
            this.rdb_AnswerC.UseVisualStyleBackColor = true;
            // 
            // rdb_AnswerB
            // 
            this.rdb_AnswerB.Location = new System.Drawing.Point(6, 42);
            this.rdb_AnswerB.Name = "rdb_AnswerB";
            this.rdb_AnswerB.Size = new System.Drawing.Size(85, 17);
            this.rdb_AnswerB.TabIndex = 1;
            this.rdb_AnswerB.TabStop = true;
            this.rdb_AnswerB.Text = "radioButton2";
            this.rdb_AnswerB.UseVisualStyleBackColor = true;
            // 
            // rdb_AnswerA
            // 
            this.rdb_AnswerA.Location = new System.Drawing.Point(6, 19);
            this.rdb_AnswerA.Name = "rdb_AnswerA";
            this.rdb_AnswerA.Size = new System.Drawing.Size(85, 17);
            this.rdb_AnswerA.TabIndex = 0;
            this.rdb_AnswerA.TabStop = true;
            this.rdb_AnswerA.Text = "radioButton1";
            this.rdb_AnswerA.UseVisualStyleBackColor = true;
            // 
            // btn_Next
            // 
            this.btn_Next.Location = new System.Drawing.Point(961, 6);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(75, 23);
            this.btn_Next.TabIndex = 1;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // lbl_QuestionNumber
            // 
            this.lbl_QuestionNumber.AutoSize = true;
            this.lbl_QuestionNumber.Location = new System.Drawing.Point(3, 11);
            this.lbl_QuestionNumber.Name = "lbl_QuestionNumber";
            this.lbl_QuestionNumber.Size = new System.Drawing.Size(62, 13);
            this.lbl_QuestionNumber.TabIndex = 3;
            this.lbl_QuestionNumber.Text = "Question: #";
            // 
            // btn_Solution
            // 
            this.btn_Solution.Location = new System.Drawing.Point(475, 6);
            this.btn_Solution.Name = "btn_Solution";
            this.btn_Solution.Size = new System.Drawing.Size(75, 23);
            this.btn_Solution.TabIndex = 4;
            this.btn_Solution.Text = "Solve";
            this.btn_Solution.UseVisualStyleBackColor = true;
            this.btn_Solution.Click += new System.EventHandler(this.btn_Solution_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.pnl_Buttons);
            this.panel1.Controls.Add(this.pnl_Question);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1242, 805);
            this.panel1.TabIndex = 5;
            // 
            // lbl_PostImage
            // 
            this.lbl_PostImage.Location = new System.Drawing.Point(3, 69);
            this.lbl_PostImage.Name = "lbl_PostImage";
            this.lbl_PostImage.Size = new System.Drawing.Size(35, 13);
            this.lbl_PostImage.TabIndex = 1;
            this.lbl_PostImage.Text = "label1";
            // 
            // lbl_Panel_PrePicture
            // 
            this.lbl_Panel_PrePicture.Location = new System.Drawing.Point(3, 0);
            this.lbl_Panel_PrePicture.Name = "lbl_Panel_PrePicture";
            this.lbl_Panel_PrePicture.Size = new System.Drawing.Size(35, 13);
            this.lbl_Panel_PrePicture.TabIndex = 0;
            this.lbl_Panel_PrePicture.Text = "label1";
            // 
            // pic_QuestionPictureBox
            // 
            this.pic_QuestionPictureBox.Location = new System.Drawing.Point(0, 16);
            this.pic_QuestionPictureBox.Name = "pic_QuestionPictureBox";
            this.pic_QuestionPictureBox.Size = new System.Drawing.Size(100, 50);
            this.pic_QuestionPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_QuestionPictureBox.TabIndex = 5;
            this.pic_QuestionPictureBox.TabStop = false;
            // 
            // pnl_Question
            // 
            this.pnl_Question.AutoScroll = true;
            this.pnl_Question.Controls.Add(this.lbl_Panel_PrePicture);
            this.pnl_Question.Controls.Add(this.lbl_PostImage);
            this.pnl_Question.Controls.Add(this.pic_QuestionPictureBox);
            this.pnl_Question.Controls.Add(this.gpb_RadioButtons);
            this.pnl_Question.Location = new System.Drawing.Point(231, 85);
            this.pnl_Question.Name = "pnl_Question";
            this.pnl_Question.Size = new System.Drawing.Size(774, 336);
            this.pnl_Question.TabIndex = 6;
            // 
            // pnl_Buttons
            // 
            this.pnl_Buttons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Buttons.Controls.Add(this.btn_Solution);
            this.pnl_Buttons.Controls.Add(this.lbl_QuestionNumber);
            this.pnl_Buttons.Controls.Add(this.btn_Next);
            this.pnl_Buttons.Location = new System.Drawing.Point(0, 0);
            this.pnl_Buttons.Name = "pnl_Buttons";
            this.pnl_Buttons.Size = new System.Drawing.Size(1238, 32);
            this.pnl_Buttons.TabIndex = 7;
            this.pnl_Buttons.Resize += new System.EventHandler(this.pnl_Buttons_Resize);
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 805);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.frm_Main_Resize);
            this.gpb_RadioButtons.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_QuestionPictureBox)).EndInit();
            this.pnl_Question.ResumeLayout(false);
            this.pnl_Question.PerformLayout();
            this.pnl_Buttons.ResumeLayout(false);
            this.pnl_Buttons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpb_RadioButtons;
        private System.Windows.Forms.RadioButton rdb_AnswerD;
        private System.Windows.Forms.RadioButton rdb_AnswerC;
        private System.Windows.Forms.RadioButton rdb_AnswerB;
        private System.Windows.Forms.RadioButton rdb_AnswerA;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.Label lbl_QuestionNumber;
        private System.Windows.Forms.Button btn_Solution;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_PostImage;
        private System.Windows.Forms.Label lbl_Panel_PrePicture;
        private System.Windows.Forms.PictureBox pic_QuestionPictureBox;
        private System.Windows.Forms.Panel pnl_Question;
        private System.Windows.Forms.Panel pnl_Buttons;
    }
}

