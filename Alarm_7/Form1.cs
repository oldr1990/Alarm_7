using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Net.Sockets;
using System.Net;
using Alarm_7;

namespace Alarm_7
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort;
        TcpClient client = null;
        TcpListener user;
        NetworkStream stream = null;
        Socket server_socket;

        bool comPortConnectionLosted = false;
        bool con_error = false, connected = false, tcp_error = false, connected_tcp = false, client_init = false;
        bool     if_server = false,if_client = false;
        char[] cond = {'0','0','0','0','0','0','0','0'}, buffer = {'0','0','0','0','0','0','0','0'};
        string[] message = {
                           "СМ1810  "+"\t\t"+"Не исправна", "СМ1810  "+"\t\t"+"Работает",
                           "СМ7209  "+"\t\t"+"Не исправна", "СМ7209  "+"\t\t"+"Работает",
                           "ШКИ1    "+"\t\t"+"Не работает", "ШКИ1    "+"\t\t"+"Работает",
                           "ШКИ2    "+"\t\t"+"Не работает", "ШКИ2    "+"\t\t"+"Работает",
                           "ШКЗ     "+"\t\t"+"Не работает", "ШКЗ     "+"\t\t"+"Работает",
                           "НИ-04-01"+"\t\t"+"Не работает","НИ-04-01"+"\t\t"+"Работает",
                           "НИ-04-02"+"\t\t"+"Не работает","НИ-04-02"+"\t\t"+"Работает",
                           "НИ-04-03"+"\t\t"+"Не работает","НИ-04-03"+"\t\t"+"Работает",
                           "Соединение установлено успешно:","Конец инициализации...",
                           "Подключение по LAN установлено!","СОМ соединение потеряно!",
                           "СОМ соединение востановлено!"
                           };
        public Form1()                                                              //Инициализация формы
        {
            InitializeComponent();
            ports_search();
            update_list();

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void update_list()                                                  //Обновления списка событий
        {

            if (File.Exists(Directory.GetCurrentDirectory() + "/Data.dat"))
            {
                String line;
                StreamReader sr = new StreamReader(Directory.GetCurrentDirectory()+"/Data.dat");
                line = sr.ReadLine();
                this.listBox1.Items.Clear();
                while (line != null)
                {
                    this.listBox1.Items.Add(DeCriptor(line));
                    line = sr.ReadLine();
                }
                sr.Close();
                this.listBox1.SetSelected(this.listBox1.Items.Count - 1, true);
            }
            else MessageBox.Show("Архив событий пуст или файл не найден!",
                                 "Сигнализация блока №7",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information,
                                 MessageBoxDefaultButton.Button1,
                                 MessageBoxOptions.DefaultDesktopOnly);
         }

        private void bt_refresh_list_Click(object sender, EventArgs e)              //Кнопка обновления списка событий
        {
            update_list();
        }
       
        private void connect(string com, int bud)                                   //Подключение через СОМ-порт
        {
                this._serialPort = new SerialPort(com, bud, Parity.None, 8, StopBits.One);
                this._serialPort.Handshake = Handshake.None;
                this._serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                this._serialPort.ErrorReceived += new SerialErrorReceivedEventHandler(sp_ErrorHandler);
                try
                {
                    this._serialPort.Open();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Сигнализация блока №7",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                    con_error = true;
                }
                finally
                {
                    if (!con_error)
                    {
                        MessageBox.Show("Подключено!", "Сигнализация блока №7",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information,
                                    MessageBoxDefaultButton.Button1,
                                    MessageBoxOptions.DefaultDesktopOnly);
                        this.bt_connect_set.Enabled = false;
                        cb_client.Enabled = false;
                        comPortConnectionLosted = false;
                     }
                    con_error = false;

                }

        }
        
        private void sp_ErrorHandler(object sender, SerialErrorReceivedEventArgs e) //Событие ошибки
        {
                con_error = true;
                MessageBox.Show(e.ToString(), "Сигнализация блока №7",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error,
                                MessageBoxDefaultButton.Button1,
                                MessageBoxOptions.DefaultDesktopOnly);
         }

        private delegate void SetTextDeleg(string text);                            //ОБьявление делегата

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)          //Поток приема данных с СОМ-порта
            {
            
                System.Threading.Thread.Sleep(250);
                string data = this._serialPort.ReadLine();
                this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
                
            }

        private void si_DataReceived(string data)                                   //Делегат обработчик данных с СОМ-порта
        {   
            int l = data.Length;
            if (l > 8) 
            {
            if (comPortConnectionLosted) {
                writer(20);
                comPortConnectionLosted = false;
                for (int i = 0; i < 8; i++) 
                    {
                    int k = 0;
                    if (buffer[i] == '1') k = 0;
                    if (buffer[i] == '2') k = 1;
                    stat_update(i, k); 
                    
                    }
                update_list();   
                }
            timer_comport.Stop();     
            timer_comport.Start();
                char[] arr = data.ToCharArray();
                for (int i = 0; i<8 ; i++)
                    {
                    if (arr[i] == '1'|| arr[i]=='2')
                        {
                            if (buffer[i] != arr[i]) 
                            {
                                int k = 0;
                                if (arr[i]=='1')    k =0;
                                if (arr[i] == '2')  k =1;
                                writer(i*2+k);
                                update_list();
                                buffer[i] = arr[i];
                                stat_update(i, k);
                            }
                    }
                }

                if (!connected)
                {
                    writer(17);
                    update_list();
                    connected = true;
                }
            }
        }
        
        private void stat_update(int num, int stat)                                 //Обновление статуса
        {
        String _label = "";
        Color color = Color.Gray;

            switch (stat)
                {
                case 2: _label = "Отсутствует подключение!";
                    color = Color.Gray;
                    break;
                case 0: _label = "Не исправна!";
                    color = Color.Red;
                    break;
                case 1: _label = "Работает!";
                    color = Color.Green;
                    break;
                default: break;
                }
           switch (num) { 
                case 0 : 
                        this.lb_CM1810_stat.Text = _label;
                        this.lb_CM1810_stat.ForeColor = color;
                    break;
                case 1: this.lb_CM7209_stat.Text = _label;
                        this.lb_CM7209_stat.ForeColor = color;
                    
                    break;
                case 2: this.lb_YK1_stat.Text = _label;
                        this.lb_YK1_stat.ForeColor = color;
                    break;
                case 3: 
                        this.lb_YK2_stat.Text = _label;
                        this.lb_YK2_stat.ForeColor = color;
                    break;
                case 4: 
                        this.lb_SHKZ_stat.Text = _label;
                        this.lb_SHKZ_stat.ForeColor = color;
                    break;
                case 5:
                        this.lb_NI0401_stat.Text = _label;
                        this.lb_NI0401_stat.ForeColor = color;
                    break;
                case 6:
                        this.lb_NI0402_stat.Text = _label;
                        this.lb_NI0402_stat.ForeColor = color; 
                    break;
                case 7:
                        this.lb_NI0403_stat.Text = _label;
                        this.lb_NI0403_stat.ForeColor = color;
                    break;
                default: break; 
                }
        } 


        private void writer(int p)                                                  //Запись в файл
        {
            StreamWriter writer = new StreamWriter(Directory.GetCurrentDirectory() + "/Data.dat", true, Encoding.UTF8);
            writer.WriteLine(Criptor(DateTime.Now + "  \t" + message[p]));
            writer.Close();
            if (connected) notifyIcon1.ShowBalloonTip(2000, "Сигнализация блока №7", message[p], ToolTipIcon.Warning);
        }
        
        private void lb_COM_port_Click(object sender, EventArgs e)
        {

        }

        private void bt_com_ref_Click(object sender, EventArgs e)                   //Кнопка обновления списка портов
        {
            ports_search();
        }

        private void bt_connect_set_Click(object sender, EventArgs e)               //Кнопка подключить СОМ
        {
            string com = Convert.ToString(this.list_com.SelectedItem);
            int bdr = Convert.ToInt16(this.tb_bdr.Text);
            connect(com, bdr);
            if (!con_error)
            {
                writer(16);
                update_list();
            }
            bt_connect_set.Enabled = false;
            cb_client.Enabled = false;
        }
        
        private void ports_search()                                                 //Поиск портов
        {                                               
            this.list_com.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                this.list_com.Items.Add(s);
            }
            this.list_com.SetSelected(0,true);
        }

        private void cb_client_CheckedChanged(object sender, EventArgs e)           //Переключатель клиент/сервер 
        {
            if (cb_client.Checked)
            {
                bt_connect_set.Enabled = false;
                list_com.Enabled = false;
                bt_com_ref.Enabled = false;
                tb_ip.Enabled = true;
            }
            else 
            {
                bt_connect_set.Enabled = true;
                list_com.Enabled = true;
                bt_com_ref.Enabled = true;
            }
        }

        private void bt_lan_connect_Click(object sender, EventArgs e)                     //Подключение по LAN
        {
            if(!backgroundWorker1.IsBusy)backgroundWorker1.RunWorkerAsync();
            bt_connect_set.Enabled = false;
            if (!cb_client.Checked)bt_lan_connect.Enabled = false;
        if (cb_client.Checked)
            {
            bt_connect_set.Enabled = false;
          //  AsynchronousClient.StartClient();            
            }
        else 
            {
           // AsynchronousSocketListener.StartListening();
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)             //Поток связи LAN
        {
        if (!cb_client.Checked)
            {
            var EndPoint = new IPEndPoint(IPAddress.Parse(tb_ip.Text), 58181);
            server_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            if (!connected_tcp)
                {
                server_socket.Bind(EndPoint);
                connected_tcp = true;
                }
            server_socket.Listen(1);
            }
        while (true)
            {
            BackgroundWorker worker = sender as BackgroundWorker;
            
            if (!cb_client.Checked)
                {

                    var listener = server_socket.Accept();
                    
                    if (!if_server)notifyIcon1.ShowBalloonTip(2000, "Сигнализация блока №7", "Соединение TCP установлено!", ToolTipIcon.Info);
                    if_server = true;
                    listener.Send(Encoding.UTF8.GetBytes(buffer));
                    System.Threading.Thread.Sleep(1000);
                    listener.Shutdown(SocketShutdown.Both);
                    listener.Close();
                    
                }
            else
                {
                    var client_socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    var EndPoint_cl = new IPEndPoint(IPAddress.Parse(tb_ip.Text), 58181);
                    
                    try
                        {
                        client_socket.Connect(EndPoint_cl);
                        }
                    catch (Exception ex)
                        {
                        notifyIcon1.ShowBalloonTip(2000, "Сигнализация блока №7", ex.Message, ToolTipIcon.Info);
                        con_error = true;
                        }
                    if (!if_client && !con_error)
                        {
                        notifyIcon1.ShowBalloonTip(2000, "Сигнализация блока №7", "Соединение TCP установлено!", ToolTipIcon.Info);
                        if_client = true;
                        }
                var incoming_data = new StringBuilder();
                var buffer_byte = new Byte[256];
                int data_size = 0;
                do
                    {
                    data_size = client_socket.Receive(buffer_byte);
                    incoming_data.Append(Encoding.UTF8.GetString(buffer_byte, 0, data_size));
                    }
                while (client_socket.Available > 0);
                var buf_arr = new Char[256];
                string buf_string = incoming_data.ToString();
                buf_arr = buf_string.ToCharArray(0, 8);
                for (int i = 0; i < 8; i++) buffer[i] = buf_arr[i];
                worker.ReportProgress(0);
                client_socket.Close();
                }
            }
        }
        
        private void backGroundWorker1_Progress(object sender, ProgressChangedEventArgs e) //Оброботчик потока
        {

        if (!cb_client.Checked)
            {
            writer(18);
            update_list();
            }
        else
            {
            if (!client_init) writer(16);
            for (int i = 0; i < 8; i++)
                {
                if (cond[i] != buffer[i])
                    {
                    int k = 0;
                    if (buffer[i] == '2') k = 1;
                    writer(i * 2 + k);
                    cond[i] = buffer[i];
                    stat_update(i, k);
                    update_list();
                    }
                }
            if (!client_init)
                {
                writer(17);
                client_init = true;
                connected = true;
                update_list();
                }
            
            }
        }

        private void tcp_server_init()                                                     //Инициализация Сервера
        {

            try
            {
                System.Net.IPAddress address;
                int port = 8181;
                address = System.Net.IPAddress.Parse("127.0.0.1");//LocalIPAddress();
               // bool cool = int.TryParse(tb_port.Text,out port);
                user = new TcpListener(address, port);
                user.Start();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Сигнализация блока №7",
                            MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.DefaultDesktopOnly);
                
            }

            if (!tcp_error) connected = true;
           
        }                                                   
        
        private void tcp_client_init()                                                     //Инициализация Клиента
        {
            try
            {
                System.Net.IPAddress address;
                int port;
                if (System.Net.IPAddress.TryParse(tb_ip.Text, out address))
                {
                    port = 8181;
                    //int.Parse(tb_port.Text);
                    client = new TcpClient(tb_ip.Text, port);
                    stream = client.GetStream();
                }

            }
            catch (Exception e)
            {
               MessageBox.Show(e.Message, "Сигнализация блока №7",
                             MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1,
                             MessageBoxOptions.DefaultDesktopOnly);
                tcp_error = true;

                if(stream != null)stream.Close(500);
                if (client != null)client.Close();
            }
            if (!tcp_error) connected = true;
        }
        
        private System.Net.IPAddress LocalIPAddress()                                      //Получение локального IP
        {
            if (!System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable())
            {
                return null;
            }

            System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName());

            return host
                .AddressList
                .FirstOrDefault(ip => ip.AddressFamily == AddressFamily.InterNetwork);
        }
        
        private string Criptor(string str)
        {
            char[] arr_01 = str.ToCharArray();
            char[] arr_00 = new char[str.Length];
            int i = 0, k = 0;
            foreach (char c in arr_01)
            {
                k = Convert.ToInt32(c) + 10;
                arr_00[i] = Convert.ToChar(k);
                i++;
            }
            str = new string(arr_00);
            return str;
        }       
                                                                          //Криптор
        private string DeCriptor(string str)
        {
            char[] arr_01 = str.ToCharArray();
            char[] arr_00 = new char[str.Length];
            int i = 0, k = 0;
            foreach (char c in arr_01)
            {
                k = Convert.ToInt32(c) - 10;
                if (k < 0) k = 0;
                arr_00[i] = Convert.ToChar(k);
                i++;
            }
            str = new string(arr_00);
            return str;
        }                                            //Декриптор

        private void bt_export_Click(object sender, EventArgs e)
        {
           
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.OverwritePrompt = true;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    String line;
                    StreamReader sr = new StreamReader(Directory.GetCurrentDirectory() + "/Data.dat");
                    StreamWriter wrt = new StreamWriter(saveFileDialog1.FileName);
                    
                
                    line = sr.ReadLine();
                    while (line != null)
                    {
                       wrt.WriteLine(DeCriptor(line));
                        line = sr.ReadLine();
                    }
                    sr.Close();
                    wrt.Close();
                   
                    // Code to write the stream goes here.
                    notifyIcon1.ShowBalloonTip(2000, "Сигнализация блока №7", "Завершено!", ToolTipIcon.Info);
                       
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
            {
            
            }

        private void timer1_Tick(object sender, EventArgs e)
            {
            if (!comPortConnectionLosted)
                {
                for (int i = 0; i < 8; i++) stat_update(i, 2);
                writer(19);
                update_list();
                comPortConnectionLosted = true;
                }
            } 
    }    
}
