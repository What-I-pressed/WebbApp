using Client_Server_Controller.Networking;

namespace Client_Server_Controller
{
    public partial class PrimalForm : Form
    {
        public PrimalForm()
        {
            InitializeComponent();
        }

        private void btnStartClient_Click(object sender, EventArgs e)
        {
            ClientForm clientForm = new ClientForm();
            clientForm._serverIP = txtServerIP.Text;
            clientForm._serverPort = int.Parse(txtServerPort.Text);
            new Thread(() => clientForm.ShowDialog()).Start();
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            ServerForm serverForm = new ServerForm();
            serverForm._port = int.Parse(txtPortServerWorkWith.Text);
            new Thread(() => serverForm.ShowDialog()).Start();
        }
    }
}
