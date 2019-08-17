using System;
using System.Net;
using System.Net.Sockets;

namespace WindowsFormsApp1
{
    internal class client
    {
        public string id
        {
            get;
            private set;
        }

        public IPEndPoint endpoint
        {
            get;
            private set;
        }

        public Socket Sck
        {
            get
            {
                return sck;
            }

            set
            {
                sck = value;
            }
        }

        public IAsyncResult Close_k
        {
            get
            {
                return close_k;
            }

            set
            {
                close_k = value;
            }
        }

        private Socket sck;
        private IAsyncResult close_k;

        public client(Socket accepted)
        {
            Sck = accepted;
            id = Guid.NewGuid().ToString();
            endpoint = (IPEndPoint)Sck.RemoteEndPoint;
            Sck.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
        }

        private void callback(IAsyncResult ar)
        {
            try
            {
                Sck.EndReceive(ar);
                byte[] buf = new byte[8192];
                int rec = Sck.Receive(buf, buf.Length, 0);
                if (rec > 0)
                {
                    if (rec < buf.Length)
                    {
                        Array.Resize<byte>(ref buf, rec);
                    }
                    if (Received != null)
                    {
                        Received(this, buf);
                    }
                    Sck.BeginReceive(new byte[] { 0 }, 0, 0, 0, callback, null);
                }
                else
                {
                    close();
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
                close();
                //if(Disconnected!=null)
                //{
                //    Disconnected(this);
                //}
            }
        }

        public void close()
        {
            //Sck.Shutdown(SocketShutdown.Both);
            Sck.Close();Sck.Dispose();
        }

        public delegate void clientreciveredhandler(client sender, byte[] data);

        public delegate void clientdisconnecthandler(client sender);

        public event clientreciveredhandler Received;

        public event clientdisconnecthandler Disconnected;
    }
}