using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Client_Server_Controller.Networking
{
    public partial class ServerForm : Form
    {
        public int _port;
        IPAddress _IP;
        Socket _socket;
        IPEndPoint _IPEndPoint;

        public ServerForm()
        {
            InitializeComponent();
        }

        private void WriteToListBox(string message)
        {
            if(lbMessages.InvokeRequired == true)
            {
                lbMessages.Invoke(new Action<string>(WriteToListBox), message) ;
            }
            else {
                lbMessages.Items.Add(message);
                lbMessages.Update();
            }
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {
            var hostName = Dns.GetHostName();
            _IP = Dns.GetHostEntry(hostName).AddressList[1];
            // This is the IP address of the local machine;
            _IPEndPoint = new IPEndPoint(_IP, _port);
            _socket = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
        }

        private void StartListen(object sender, EventArgs e)
        {
            try
            {
                //Привязка до IP адреси і порта машини
                _socket.Bind(_IPEndPoint);
                _socket.Listen(10); //початок прослуховання запитів від клієнтів
                WriteToListBox($"Server start listening to {_IP} IP");
                Task.Run((Func<Task?>)(() =>
                {
                    while (true)
                    {
                        Socket client = _socket.Accept(); //На даному блоці ми зупинилися і чекамємо клієнтів
                        int bytes = 0; //кількість байт повідомлення від клієнта
                        byte[] data = new byte[1024]; //масив для збеірігання даних у запиті
                        do
                        {
                            bytes = client.Receive(data);
                            WriteToListBox(Encoding.Unicode.GetString(data) + "   from " + client.RemoteEndPoint);
                        } while (client.Available > 0); //цикл продожуємо доки не досягли кінця повідомлення 
                        string message = "Дякую. Ваш запит прийнято " + DateTime.Now;
                        data = Encoding.Unicode.GetBytes(message);
                        client.Send(data); // клієнту назад відпавляю повідомлення
                        client.Shutdown(SocketShutdown.Both);
                        client.Close();
                    }
                }));
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Smth went wrong " + ex.Message);
                btnStart.Enabled = true;
            }
        }

        private void lbMessages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
