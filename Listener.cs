using System;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    internal class Listener
    {
        private Socket s;

        public int Port
        {
            get;
            private set;
        }

        private IPEndPoint Server_endpoint = new IPEndPoint(IPAddress.Any, 23);

        public bool Listensing
        {
            get;
            private set;
        }

        public Socket S
        {
            get
            {
                return s;
            }

            set
            {
                s = value;
            }
        }

        public IPEndPoint Server_endpoint1
        {
            get
            {
                return Server_endpoint2;
            }

            set
            {
                Server_endpoint2 = value;
            }
        }

        public IPEndPoint Server_endpoint2
        {
            get
            {
                return Server_endpoint;
            }

            set
            {
                Server_endpoint = value;
            }
        }

        public Listener(int port)
        {
            Port = port;
            S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        }

        public void start()
        {
            if (Listensing)
                return;
            S.Bind(new IPEndPoint(IPAddress.Any, Port));
            S.Listen(100);
            S.BeginAccept(callback, null);
            Listensing = true;
        }

        public void Stop()
        {
            if (!Listensing)
                return;
            S.Close();
            S.Dispose();
            //S = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //MessageBox.Show(S.AddressFamily.ToString());
        }

        private void callback(IAsyncResult ar)
        {
            try
            {
                Socket s = this.S.EndAccept(ar);
                if (socketaccepted != null)
                {
                    socketaccepted(s);
                }
                this.S.BeginAccept(callback, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public delegate void SocketAcceptedHandler(Socket e);

        public event SocketAcceptedHandler socketaccepted;
    }
}