using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCardViewer
{
    public partial class frm_Main : Form
    {
        private List<bool> selected = new List<bool>();
        private Questions questions;
        private int questionNumber = 1;
        private Stack<Question> previousQuestions = new Stack<Question>();
        private Random rand = new Random();
        private int element = -1;


        public frm_Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            questions = JsonInput.DeserializeData();
            selected.AddRange(new bool[]{false,false,false,false});
            
            //Load Questions
            element = rand.Next(1, questions.QuestionsList.Count);
            
            FormatQuestionToForm((Question)questions.QuestionsList[element]);
            lbl_QuestionNumber.Text = "Question: " + questionNumber.ToString();
            //Load Answers
            //Set correct answer
        }

        #region Button Action Listeners
        private void btn_Next_Click(object sender, EventArgs e)
        {
            rdb_AnswerA.BackColor= Color.White;
            rdb_AnswerB.BackColor = Color.White;
            rdb_AnswerC.BackColor= Color.White;
            rdb_AnswerD.BackColor= Color.White;

            rdb_AnswerA.Enabled = true;
            rdb_AnswerB.Enabled = true;
            rdb_AnswerC.Enabled = true;
            rdb_AnswerD.Enabled = true;

            questionNumber++;
            lbl_QuestionNumber.Text = "Question: " + questionNumber.ToString();
            previousQuestions.Push((Question)questions.QuestionsList[element]);
            ResetControlSize();
            FormatQuestionToForm((Question)questions.QuestionsList[element]);
        }

        private void btn_Solution_Click(object sender, EventArgs e)
        {
            Question current = (Question)questions.QuestionsList[element];
            switch (current.Answer)
            {
                case 0:
                    rdb_AnswerA.BackColor = Color.Green;
                    rdb_AnswerB.Enabled = false;
                    rdb_AnswerC.Enabled = false;
                    rdb_AnswerD.Enabled = false;
                    break;
                case 1:
                    rdb_AnswerB.BackColor = Color.Green;
                    rdb_AnswerA.Enabled = false;
                    rdb_AnswerC.Enabled = false;
                    rdb_AnswerD.Enabled = false;
                    break;
                case 2:
                    rdb_AnswerC.BackColor = Color.Green;
                    rdb_AnswerB.Enabled = false;
                    rdb_AnswerA.Enabled = false;
                    rdb_AnswerD.Enabled = false;
                    break;
                case 3:
                    rdb_AnswerD.BackColor = Color.Green;
                    rdb_AnswerB.Enabled = false;
                    rdb_AnswerC.Enabled = false;
                    rdb_AnswerA.Enabled = false;
                    break;
            }
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            
        }
        #endregion

        private void FormatQuestionToForm(Question quest)
        {
            if(questionNumber == questions.QuestionsList.Count)
            {
                MessageBox.Show("No more questions, exiting program");
                //TODO: Exit form
                return;
            }
            else if(quest.Used)
            {
                element = rand.Next(0, questions.QuestionsList.Count);
                FormatQuestionToForm((Question)questions.QuestionsList[element]);
                return;
            }

            quest.QuestionNumber = questionNumber;
            quest.Used = true;
            string[] textSplit = SplitString(quest.QuestionText);

            Size picBoxSize = new Size(panel1.Width,0);

            rdb_AnswerA.Appearance = Appearance.Button;
            rdb_AnswerB.Appearance = Appearance.Button;
            rdb_AnswerC.Appearance = Appearance.Button;
            rdb_AnswerD.Appearance = Appearance.Button;

            rdb_AnswerA.AutoSize = true;
            rdb_AnswerB.AutoSize = true;
            rdb_AnswerC.AutoSize = true;
            rdb_AnswerD.AutoSize = true;

            if (!quest.Images[1].Equals(" "))
            {
                //Transform Radio button and add image
                rdb_AnswerA.Image = Image.FromFile(quest.Images[1]);
                rdb_AnswerB.Image = Image.FromFile(quest.Images[2]);
                rdb_AnswerC.Image = Image.FromFile(quest.Images[3]);
                rdb_AnswerD.Image = Image.FromFile(quest.Images[4]);

            }
            
            //Add Method
            if (!quest.Images[0].Equals(" "))
            {
                pic_QuestionPictureBox.Image = Image.FromFile(quest.Images[0]);
                picBoxSize = pic_QuestionPictureBox.Size;
            }
            else
            {
                pic_QuestionPictureBox.Image = null;
                pic_QuestionPictureBox.Size = new Size(0, 0);
            }

            SetControlSizes();
            SetControlLocations(picBoxSize);
            SetControlText(quest, textSplit);

        }
        private void SetControlSizes()
        {

            //Sizing
            pnl_Buttons.Size = new Size(panel1.Width, btn_Next.Height + 20);
            pnl_Question.Size = new Size(panel1.Size.Width, panel1.Size.Height - (pnl_Buttons.Height + 10)); //Subtract size of rest of controls
            lbl_Panel_PrePicture.Size = new Size(pnl_Buttons.Width, 50);
            lbl_PostImage.Size = new Size(pnl_Buttons.Width, 50);
            gpb_RadioButtons.Size = new Size(panel1.Width, ((rdb_AnswerA.Height + rdb_AnswerA.Padding.Vertical) + (rdb_AnswerB.Height + rdb_AnswerB.Padding.Vertical) +
                (rdb_AnswerC.Height + rdb_AnswerC.Padding.Vertical) + (rdb_AnswerD.Height + rdb_AnswerD.Padding.Vertical)) * 2);
        }
        private void SetControlLocations(Size picBoxSize)
        {
            //location
            pnl_Question.Location = new Point(0, pnl_Buttons.Location.Y + pnl_Buttons.Height + 10);
            if (pic_QuestionPictureBox != null)
            {
                pic_QuestionPictureBox.Location = new Point(0, lbl_Panel_PrePicture.Location.Y + lbl_Panel_PrePicture.Size.Height);
                lbl_PostImage.Location = new Point(0, pic_QuestionPictureBox.Location.Y + picBoxSize.Height + 20);
            }

            rdb_AnswerB.Location = new Point(rdb_AnswerA.Location.X, rdb_AnswerA.Location.Y + rdb_AnswerA.Size.Height + 10);
            rdb_AnswerC.Location = new Point(rdb_AnswerB.Location.X, rdb_AnswerB.Location.Y + rdb_AnswerB.Size.Height + 10);
            rdb_AnswerD.Location = new Point(rdb_AnswerC.Location.X, rdb_AnswerC.Location.Y + rdb_AnswerC.Size.Height + 10);

            gpb_RadioButtons.Location = new Point(lbl_PostImage.Location.X, lbl_PostImage.Location.Y + lbl_PostImage.Height + 10);
        }
        private void SetControlText(Question quest, string[] textSplit)
        {
            //Set Text
            lbl_Panel_PrePicture.Text = textSplit[0];
            lbl_PostImage.Text = textSplit[1];
            rdb_AnswerA.Text = quest.AnswerText[0];
            rdb_AnswerB.Text = quest.AnswerText[1];
            rdb_AnswerC.Text = quest.AnswerText[2];
            rdb_AnswerD.Text = quest.AnswerText[3];
        }
        private void ResetControlSize()
        {
            pnl_Buttons.Size = new Size();
            pnl_Question.Size = new Size();
            lbl_Panel_PrePicture.Size = new Size();
            lbl_PostImage.Size = new Size();
            gpb_RadioButtons.Size = new Size();

            rdb_AnswerA.Text = " ";
            rdb_AnswerA.Image = null;
            rdb_AnswerB.Text = " ";
            rdb_AnswerB.Image = null;
            rdb_AnswerC.Text = " ";
            rdb_AnswerC.Image = null;
            rdb_AnswerD.Text = " ";
            rdb_AnswerD.Image = null;
        }
        private string[] SplitString(string original)
        {
            string[] result = new string[2];
            try
            {
                result[1] = original.Substring(original.LastIndexOf('>') + 1);
                result[0] = original.Substring(0,(original.LastIndexOf('<')));
            }
            catch(ArgumentOutOfRangeException)
            {
                return new string[]{ original,""};
            }

            return result;
        }

        private void gpb_RadioButtons_Enter(object sender, EventArgs e)
        {

        }

        private void frm_Main_Resize(object sender, EventArgs e)
        {
            pnl_Buttons.Size = new Size(panel1.Width, pnl_Buttons.Height);
            pnl_Question.Size = new Size(panel1.Width, pnl_Question.Height);
        }

        private void pnl_Buttons_Resize(object sender, EventArgs e)
        {
            btn_Next.Location = new Point(pnl_Buttons.Width - btn_Next.Padding.Right - btn_Next.Width, btn_Next.Location.Y);
            btn_Solution.Location = new Point(pnl_Buttons.Width / 2 - (btn_Solution.Width / 2));
        }
    }
}
