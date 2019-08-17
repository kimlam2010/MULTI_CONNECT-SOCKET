using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MAIN_FORM : Form
    {
        // khai bao cac form ở đây
        private MODIFY_SERVER modify_server = new MODIFY_SERVER();

        private Listener Listener;
        private String ipendpoint_device;
        private String CMD_devive;
        private String _data_device;
        private DataGridView user_table = new DataGridView();
        private Stack<string> stack_cmd = new Stack<string>();

        public MAIN_FORM()
        {
            InitializeComponent();

            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            richTextBox1.AppendText(hostName + "  " + "MY IP:" + myIP);
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bt_start.Enabled = true;
            bt_Stop.Enabled = false;
            bt_Send.Enabled = false;
            timer1.Enabled = false;
        }

        private void sERVERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // nó mới sinh 1 0aon5 code 0ể viết ngay cái nút nè
            modify_server.Show();
        }

        private void Bt_start_Click(object sender, EventArgs e)
        {
            string hostName = Dns.GetHostName();
            string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
            Listener = new Listener(Int32.Parse(modify_server.textBox1.Text));
            Listener.start();
            richTextBox1.AppendText("\n" + "Server begin at: " + myIP + ":" + Listener.Port.ToString());
            Bt_start.Enabled = false;
            bt_Stop.Enabled = true;
            timer1.Enabled = true;
            Listener.socketaccepted += new Listener.SocketAcceptedHandler(listener_socketaccepted);
        }

        private void listener_socketaccepted(Socket e)
        {
            client client = new client(e);
            client.Received += new client.clientreciveredhandler(Client_recivered);
            client.Disconnected -= new client.clientdisconnecthandler(client_disconected);
            //thu_disconect();
            Invoke((MethodInvoker)delegate
            {
                ListViewItem i = new ListViewItem();
                i.Text = client.endpoint.ToString();
                i.SubItems.Add(client.id);
                i.SubItems.Add("XX");
                i.SubItems.Add("XX");
                i.Tag = client;
                List_client.Items.Add(i);
            });
        }

        private void client_disconected(client sender)
        {
            Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < List_client.Items.Count; i++)
                {
                    client client = List_client.Items[i].Tag as client;

                    if (client.id == sender.id)
                    {
                        client.close();
                        List_client.Items.RemoveAt(i);

                        break;
                    }
                }
            }
          );
            //  throw new NotImplementedException();
        }

        private void Client_recivered(client sender, byte[] data)
        {
            // throw new NotImplementedException();
            Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < List_client.Items.Count; i++)
                {
                    client client = List_client.Items[i].Tag as client;
                    if (client.id == sender.id)
                    {
                        if (data.Length > 0)
                        {
                            List_client.Items[i].SubItems[2].Text = Encoding.Default.GetString(data);
                            // tien hanh xu lý lệnh gửi xuống bằng cách tạo ra 1 delegate hoặc một theard xu lý với các class có các biến sau
                            // 1: IPendpoint là gì
                            // 2: Du liệu nhận được là gì
                            // 3: Gửi trả lại dữ liệu
                        }
                    }
                }
            }
            );
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < List_client.Items.Count; i++)
                {
                    client client = List_client.Items[i].Tag as client;

                    List_client.Items.RemoveAt(i);
                    client.close();
                }
            }
         );
            Listener.Stop();
            Bt_start.Enabled = true;
            bt_Stop.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Invoke((MethodInvoker)delegate
            {
                for (int i = 0; i < List_client.Items.Count; i++)
                {
                    client client = List_client.Items[i].Tag as client;
                    try
                    {
                        bool part1 = client.Sck.Poll(1, SelectMode.SelectRead);
                        bool part2 = (client.Sck.Available == 0);

                        String _cmd_send = "TEST" + '*';
                        byte[] data1 = Encoding.ASCII.GetBytes(_cmd_send);
                        try
                        { client.Sck.BeginSend(data1, 0, data1.Length, SocketFlags.None, new AsyncCallback(sendcallback), client.Sck); }
                        catch (Exception ex)
                        {
                        }

                        List_client.Items[i].SubItems[3].Text = "";
                        if (part1 & part2)
                        {
                            richTextBox1.AppendText("ket noi da bi mat \n");
                        }
                    }
                    catch (Exception ex)
                    {
                        richTextBox1.AppendText(" \n tien hanh gui lenh khong duoc ngat ket noi thiet bi nay \n");
                        //  richTextBox1.AppendText(e.ToString());
                        client.close();
                        List_client.Items.RemoveAt(i);
                    }

                   
                }
            }
        );
        }

        private void sendcallback(IAsyncResult ar)
        {
            Socket socket = (Socket)ar.AsyncState;
            socket.EndSend(ar);
        }
    }
}