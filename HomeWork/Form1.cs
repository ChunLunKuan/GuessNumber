using GameLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Form1 : Form
    {
        private Home home = new Home();
        private string inputText;
        private int inputNumber;
        public List<int> userInput = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        private void From1_load(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            home.answer = home.CreateNumbers();
            ResultLabel.Text = "";
            UserAnswerLabel.Text = "";
            userInput.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(7);
            userInput.Add(7);
        }

        public void buttonReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void UpdateUserAnswerLabel(int number)
        {
            this.inputText = UserAnswerLabel.Text + number.ToString();
            int.TryParse(this.inputText, out this.inputNumber);
            UserAnswerLabel.Text = this.inputNumber.ToString();
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(8);
            userInput.Add(8);
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(9);
            userInput.Add(9);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(4);
            userInput.Add(4);
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(5);
            userInput.Add(5);
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(6);
            userInput.Add(6);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(1);
            userInput.Add(1);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(2);
            userInput.Add(2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(3);
            userInput.Add(3);
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            UpdateUserAnswerLabel(0);
            userInput.Add(0);
        }

        public void ButtonC_Click(object sender, EventArgs e)
        {
            UserAnswerLabel.Text = "";
            userInput.Clear();
        }

        public void ButtonEnter_Click(object sender, EventArgs e)
        {
            if (inputText.Length > 4)
                MessageBox.Show("請輸入四碼數字");
            else if (inputText.Length < 4)
                MessageBox.Show("請輸入四碼數字");
            else
                ResultLabel.Text += home.GetResult(userInput);
            UserAnswerLabel.Text = "";
            userInput.Clear();
        }

        private void ButtonAns_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game Answer: " + home.ConvertNumbersToString(home.answer));
        }

        private void ButtonAuto_Click(object sender, EventArgs e)
        {
            if (inputText.Length > 4)
                MessageBox.Show("請輸入四碼數字");
            else if (inputText.Length < 4)
                MessageBox.Show("請輸入四碼數字");
            else
                home.answer = userInput;
            ResultLabel.Text += home.GetResultAuto(home.PcCreateNumbers());
        }
    }
}