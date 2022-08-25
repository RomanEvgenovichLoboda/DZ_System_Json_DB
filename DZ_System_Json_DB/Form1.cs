using System.Text.RegularExpressions;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace DZ_System_Json_DB
{
    public partial class FormRegistr : Form
    {
        const int PORT = 8088;
        const string IP = "127.0.0.1";
        IPEndPoint iPEnd = new IPEndPoint(IPAddress.Parse(IP), PORT);
        Socket clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
        public FormRegistr()
        {
            InitializeComponent();
        }

        private void button_Autorisation_Click(object sender, EventArgs e)
        {
            if(textBox_Login.Text!=""&&textBox_Password.Text!="")
            {
                if (!Regex.IsMatch(textBox_Login.Text, pattern, RegexOptions.IgnoreCase)) { MessageBox.Show("Wrong email format", " ErroR !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
                else
                {
                    byte[] data = Encoding.Unicode.GetBytes(textBox_Login.Text);
                    clientSocket.Send(data);
                }
            }
        }

        private void FormRegistr_Load(object sender, EventArgs e)
        {
            clientSocket.Connect(iPEnd);
        }

        private void FormRegistr_FormClosed(object sender, FormClosedEventArgs e)
        {
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
    }
}