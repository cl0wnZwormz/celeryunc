using CeleryAPI;

namespace CelerySkidded
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ExploitApi exploitApi = new ExploitApi();

        // Remove 'async' modifier if no asynchronous operations are performed
        private void button1_Click(object sender, EventArgs e)
        {
            ExploitApi.Inject();
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            // Await the asynchronous call to ensure it completes before continuing
            await ExploitApi.Execute(textBox1.Text, useCustomUnc: false);
        }
    }
}
