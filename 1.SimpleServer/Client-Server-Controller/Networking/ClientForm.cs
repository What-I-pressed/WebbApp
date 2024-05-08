using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client_Server_Controller.Networking
{
    public partial class ClientForm : Form
    {
        public string _serverIP;
        public int _serverPort;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(_serverIP), _serverPort);
                //Сокет, який буде взяємодіяти із сервером
                Socket server = new Socket(AddressFamily.InterNetwork,
                    SocketType.Stream, ProtocolType.Tcp);
                server.Connect(endPoint);
                string message = txtMessage.Text;
                byte[] data = Encoding.Unicode.GetBytes(message);
                server.Send(data); //Відправляємо дані на сервер
                //очікуємо відповідь від сервера
                data = new byte[1024];
                int bytes = 0; //розмір повідомлення від сервера
                do
                {
                    bytes = server.Receive(data); //отримати відповідь від сервера
                    MessageBox.Show("Message from server : " + Encoding.Unicode.GetString(data));
                } while (server.Available > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Щось пішло не так {0}", ex.Message);
            }
        }
    }
}
