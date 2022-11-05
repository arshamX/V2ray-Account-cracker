using ThreadGun;
using System.Collections.Concurrent;
namespace V2ray_Account_cracker
{
    public partial class Form1 : Form
    {
        Constants info = new Constants();
        ThreadGun<string>? threads;
        public int good = 0;
        public static ConcurrentQueue<string> hit = new ConcurrentQueue<string>();
        private Thread? updater;
        private bool flag = true;
        public Form1()
        {
            InitializeComponent();
            Label.CheckForIllegalCrossThreadCalls = false;
            DataGridView.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFile = new OpenFileDialog())
            {
                openFile.Filter = "Text File (*.txt)|*.txt";
                openFile.Title = "Load IPs";
                if(openFile.ShowDialog() == DialogResult.OK)
                {
                    info.IPS.AddRange(File.ReadAllLines(openFile.FileName));
                    MessageBox.Show("IPS Loaded");
                    lblCount.Text = $"IPs : {info.IPS.Count}";
                }
            }
        }

        private void nudThreads_ValueChanged(object sender, EventArgs e)
        {
            info.threads = (int)(nudThreads.Value);
        }

        private void update()
        {
            while(flag)
            {
                string? newHit;
                if(hit.TryDequeue(out newHit))
                {
                    good++;
                    datagrid.Rows.Add(newHit);
                    lblGoods.Text = $"Goods : {good}";
                }

            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if(info.IPS.Count == 0)
            {
                MessageBox.Show("check your inputs");
            }
            else
            {
                flag = true;
                threads = new ThreadGun<string>(Methods.config, info.IPS, info.threads);
                threads.FillingMagazine().Start();
                lblStatus.Text = "Status : running";
                lblStatus.ForeColor = Color.Green;
                nudThreads.Enabled = false;
                btnLoad.Enabled = false;
                updater = new Thread(update);
                updater.Start();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(!flag)
            {
                flag=false;
                try
                {
                    updater.Abort();
                    lblStatus.Text = "Status : Aborted";
                    lblStatus.ForeColor = Color.Yellow;
                }
                catch
                {

                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Bye")
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}