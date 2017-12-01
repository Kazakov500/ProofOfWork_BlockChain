using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfOfWork_BlockChain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Task[] tasks;
        private async void btn_Start_Click(object sender, EventArgs e)
        {


            rtb_Log.Clear();
            //Get_Number_For_Block();

            //Thread t = new Thread(Get_Number_For_Block);
            //t.Start(new string[] { rtb_Message.Text, tb_Zeros.Text });


            List<int> result;

            var watch = System.Diagnostics.Stopwatch.StartNew();

            try
            {
                var progress = new Progress<string>(update =>
                {
                    rtb_Log.AppendText(update);
                    rtb_Log.AppendText(Environment.NewLine);
                    rtb_Log.Refresh();
                });
                var progress_num = new Progress<string>(update =>
                {
                    tb_Current_Number.Text = update;
                });
                string[] vars = new string[] { rtb_Message.Text, tb_Zeros.Text };

                int count_of_iterations = Convert.ToInt32(tb_CountOfIterations.Text);
                int count_of_threads = 4;
                int fold_size = count_of_iterations / count_of_threads;

                //10 thr
                //1000 iter
                //100 fold
                tasks = new Task[count_of_threads];
                for (int i = 0; i < count_of_threads; i++)
                {
                    //await Task.Run(() => Get_Number_For_Block(i * fold_size, (i * fold_size) + fold_size, vars, progress, progress_num));
                    tasks[i] = Task.Factory.StartNew(() => Get_Number_For_Block(i * fold_size, (i * fold_size) + fold_size, vars, progress, progress_num));
                    rtb_Log.AppendText(i.ToString() + "thread created\n");
                }
                Task.WaitAll(tasks);

            }
            catch (InvalidOperationException ex) { };



            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;
            rtb_Log.AppendText(elapsedMs.ToString() + " ms\n");

            /*string[] vars = new string[] { rtb_Message.Text, tb_Zeros.Text };

            List<int> result = await Task.Run(() =>
            {
                //return Get_Number_For_Block(vars);
            });*/

            //foreach (var item in result)
            //    rtb_Log.AppendText(item.ToString() + " " + "\n");


        }

        private async void CreateThread(int cot)
        {

        }


        private void Get_Number_For_Block(int start, int end, object str_arr, IProgress<string> progress, IProgress<string>  progress_num)
        {
            string Message = ((string[])(str_arr))[0];
            string First_Zeros = ((string[])(str_arr))[1];
            string Hash;
            //List<int> list = new List<int>(); 

            for (int i = start; i < end; i++)
            {

                string block = Message + "\n" + i.ToString();
                Hash = hash(block);

                string ss = (Hash.Substring(0, tb_Zeros.Text.Length));
                bool ss_b = ss.Equals(tb_Zeros.Text);

                if ((Hash.Substring(0, tb_Zeros.Text.Length)).Equals(tb_Zeros.Text))
                {
                    //list.Add(i);
                    progress.Report(i.ToString());
                    //progress_num.Report(i.ToString());
                }
                if ((i % 1000) == 0)
                {
                    progress_num.Report(i.ToString());
                }
            }
            //progress.Report("Finish");
            //return list;
        }


        private void Get_Hash(int Num)
        {
            string Message = rtb_Message.Text;
            string First_Zeros = tb_Zeros.Text;
            string Hash;
            



            string block = Message + "\n" + Num.ToString();
            Hash = hash(block);
            rtb_Hash.Text = Hash;



        }


        private string hash(string text)
        {
            byte[] data = Encoding.Default.GetBytes(text);
            byte[] result = new SHA256Managed().ComputeHash(data);

            return string.Join("", result.Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));
        }

        private void btn_GetCurrHash_Click(object sender, EventArgs e)
        {
            rtb_Hash.Clear();
            Get_Hash(Convert.ToInt32(tb_Num.Text));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_Current_Number.Refresh();
            rtb_Hash.Refresh();
            rtb_Log.Refresh();
        }
    }
}
