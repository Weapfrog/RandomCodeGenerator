using RandomWordGenerator.Business;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using RandomWordGenerator;

namespace RandomWordGenerator
{
    public partial class Form1 : Form
    {
        UnitOfWork _uow = new UnitOfWork();
        public Form1()
        {
            InitializeComponent();
            Setup();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        #region Functions
        public void Setup()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            backgroundWorkerWord.WorkerReportsProgress = true;
            backgroundWorkerWord.WorkerSupportsCancellation = true;
            backgroundWorkerTime.WorkerReportsProgress = true;
            backgroundWorkerTime.WorkerSupportsCancellation = true;
        }
        public string CreateWord()
        {
            string wordLabel = "";
            char[] lowerCase = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            char[] upperCase = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            ArrayList word = new ArrayList();
            Random rnd = new Random();
            int firstLetterIndex = rnd.Next(0, 2);
            if (firstLetterIndex == 0)
            {
                for (int i = 0; i < 5; i++)
                {
                    word.Add(lowerCase[rnd.Next(0, 28)]);
                    word.Add(upperCase[rnd.Next(0, 28)]);
                }

            }
            else if (firstLetterIndex == 1)
            {
                for (int i = 0; i < 5; i++)
                {
                    word.Add(upperCase[rnd.Next(0, 28)]);
                    word.Add(lowerCase[rnd.Next(0, 28)]);
                }
            }
            for (int i = 0; i < word.Count; i++)
            {
                wordLabel = wordLabel + word[i];
            }
            return wordLabel;
        }
        public void DatabaseAddWord()
        {
            string wordName = wordLabel.Text;
            var response = _uow.Insert(wordName);
        }

        #endregion

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerWord.IsBusy != true && backgroundWorkerTime.IsBusy != true)
            {
                backgroundWorkerWord.RunWorkerAsync();
                backgroundWorkerTime.RunWorkerAsync();
            }
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            if (backgroundWorkerWord.WorkerSupportsCancellation == true)
            {
                backgroundWorkerWord.CancelAsync();
                backgroundWorkerTime.CancelAsync();
            }
        }


        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    wordLabel.Text = CreateWord();
                    DatabaseAddWord();
                    Thread.Sleep(3000);
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            BackgroundWorker worker = sender as BackgroundWorker;
            while (true)
            {
                if (worker.CancellationPending == true)
                {
                    e.Cancel = true;
                    break;
                }
                else
                {
                    timerSecondsTick.Text = i.ToString() + " seconds";
                    i++;
                    Thread.Sleep(1000);
                }
            }
        }
    }
}
