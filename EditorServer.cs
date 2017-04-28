using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_Texto___Server
{
    public partial class EditorServer : Form
    {
        Int32 port = 11000;
        UdpClient udpCliente = new UdpClient(11000);
        UdpClient udpCliente2 = new UdpClient(11001);
        Thread thread;


        public EditorServer()
        {
            InitializeComponent();
        }

        public void SaveFile()
        {
            while (true)
            {
                IPEndPoint remoteIPEndPoint = new IPEndPoint(IPAddress.Any, 11000);
                IPEndPoint remoteIPEndPoint2 = new IPEndPoint(IPAddress.Any, 11001);
                byte[] content = udpCliente.Receive(ref remoteIPEndPoint);
                byte[] content2 = udpCliente2.Receive(ref remoteIPEndPoint2);

                if(content.Length > 0)
                {
                    string message = Encoding.ASCII.GetString(content);

                    //System.IO.StreamWriter sw = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\teste1.txt");
                    System.IO.StreamWriter sw = new System.IO.StreamWriter("C:\\Users\\FRED\\Desktop\\teste1.txt");
                    sw.Write(message);
                    sw.Close();
                }

                if (content2.Length > 0)
                {
                    string message2 = Encoding.ASCII.GetString(content2);

                    //System.IO.StreamWriter sw_aux = new System.IO.StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "\\teste1_format.txt");
                    System.IO.StreamWriter sw_aux = new System.IO.StreamWriter("C:\\Users\\FRED\\Desktop\\teste1_format.txt");
                    sw_aux.Write(message2);
                    sw_aux.Close();
                }
            }
        }

        private void EditorServer_Load(object sender, EventArgs e)
        {
            thread = new Thread(new ThreadStart(SaveFile));
            thread.IsBackground = true;
            thread.Start();

            Hide();
            notifyIcon_Server.ShowBalloonTip(100, "Informação", "Servidor ativo.", ToolTipIcon.Info);
        }
    }
}
