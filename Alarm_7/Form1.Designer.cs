namespace Alarm_7
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
        this.components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        this.tabControl1 = new System.Windows.Forms.TabControl();
        this.tab_main = new System.Windows.Forms.TabPage();
        this.lb_NI0403_stat = new System.Windows.Forms.Label();
        this.lb_NI0402_stat = new System.Windows.Forms.Label();
        this.lb_NI0401_stat = new System.Windows.Forms.Label();
        this.lb_SHKZ_stat = new System.Windows.Forms.Label();
        this.lb_NI0403 = new System.Windows.Forms.Label();
        this.lb_NI0402 = new System.Windows.Forms.Label();
        this.lb_NI0401 = new System.Windows.Forms.Label();
        this.lb_SHKZ = new System.Windows.Forms.Label();
        this.lb_YK2_stat = new System.Windows.Forms.Label();
        this.lb_YK1_stat = new System.Windows.Forms.Label();
        this.lb_CM7209_stat = new System.Windows.Forms.Label();
        this.lb_CM1810_stat = new System.Windows.Forms.Label();
        this.lb_UK2 = new System.Windows.Forms.Label();
        this.lb_UK1 = new System.Windows.Forms.Label();
        this.lb_CM7209 = new System.Windows.Forms.Label();
        this.lb_CM1810 = new System.Windows.Forms.Label();
        this.tab_list = new System.Windows.Forms.TabPage();
        this.bt_print = new System.Windows.Forms.Button();
        this.bt_export = new System.Windows.Forms.Button();
        this.bt_refresh_list = new System.Windows.Forms.Button();
        this.listBox1 = new System.Windows.Forms.ListBox();
        this.tab_set = new System.Windows.Forms.TabPage();
        this.cb_client = new System.Windows.Forms.CheckBox();
        this.bt_lan_connect = new System.Windows.Forms.Button();
        this.tb_port = new System.Windows.Forms.TextBox();
        this.lb_port = new System.Windows.Forms.Label();
        this.lb_ip = new System.Windows.Forms.Label();
        this.tb_ip = new System.Windows.Forms.TextBox();
        this.lb_lan_set = new System.Windows.Forms.Label();
        this.lb_com_set = new System.Windows.Forms.Label();
        this.bt_connect_set = new System.Windows.Forms.Button();
        this.bt_com_ref = new System.Windows.Forms.Button();
        this.lb_bdr = new System.Windows.Forms.Label();
        this.list_com = new System.Windows.Forms.ListBox();
        this.tb_bdr = new System.Windows.Forms.TextBox();
        this.lb_COM_port = new System.Windows.Forms.Label();
        this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
        this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
        this.timer_comport = new System.Windows.Forms.Timer(this.components);
        this.tabControl1.SuspendLayout();
        this.tab_main.SuspendLayout();
        this.tab_list.SuspendLayout();
        this.tab_set.SuspendLayout();
        this.SuspendLayout();
        // 
        // tabControl1
        // 
        this.tabControl1.Controls.Add(this.tab_main);
        this.tabControl1.Controls.Add(this.tab_list);
        this.tabControl1.Controls.Add(this.tab_set);
        this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.tabControl1.Location = new System.Drawing.Point(24, 2);
        this.tabControl1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        this.tabControl1.Name = "tabControl1";
        this.tabControl1.SelectedIndex = 0;
        this.tabControl1.Size = new System.Drawing.Size(617, 506);
        this.tabControl1.TabIndex = 0;
        // 
        // tab_main
        // 
        this.tab_main.Controls.Add(this.lb_NI0403_stat);
        this.tab_main.Controls.Add(this.lb_NI0402_stat);
        this.tab_main.Controls.Add(this.lb_NI0401_stat);
        this.tab_main.Controls.Add(this.lb_SHKZ_stat);
        this.tab_main.Controls.Add(this.lb_NI0403);
        this.tab_main.Controls.Add(this.lb_NI0402);
        this.tab_main.Controls.Add(this.lb_NI0401);
        this.tab_main.Controls.Add(this.lb_SHKZ);
        this.tab_main.Controls.Add(this.lb_YK2_stat);
        this.tab_main.Controls.Add(this.lb_YK1_stat);
        this.tab_main.Controls.Add(this.lb_CM7209_stat);
        this.tab_main.Controls.Add(this.lb_CM1810_stat);
        this.tab_main.Controls.Add(this.lb_UK2);
        this.tab_main.Controls.Add(this.lb_UK1);
        this.tab_main.Controls.Add(this.lb_CM7209);
        this.tab_main.Controls.Add(this.lb_CM1810);
        this.tab_main.Location = new System.Drawing.Point(4, 29);
        this.tab_main.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        this.tab_main.Name = "tab_main";
        this.tab_main.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
        this.tab_main.Size = new System.Drawing.Size(609, 473);
        this.tab_main.TabIndex = 0;
        this.tab_main.Text = "Сигнализация";
        this.tab_main.UseVisualStyleBackColor = true;
        // 
        // lb_NI0403_stat
        // 
        this.lb_NI0403_stat.AutoSize = true;
        this.lb_NI0403_stat.Location = new System.Drawing.Point(293, 331);
        this.lb_NI0403_stat.Name = "lb_NI0403_stat";
        this.lb_NI0403_stat.Size = new System.Drawing.Size(241, 20);
        this.lb_NI0403_stat.TabIndex = 15;
        this.lb_NI0403_stat.Text = "Отсутствует подключение!";
        // 
        // lb_NI0402_stat
        // 
        this.lb_NI0402_stat.AutoSize = true;
        this.lb_NI0402_stat.Location = new System.Drawing.Point(289, 289);
        this.lb_NI0402_stat.Name = "lb_NI0402_stat";
        this.lb_NI0402_stat.Size = new System.Drawing.Size(241, 20);
        this.lb_NI0402_stat.TabIndex = 14;
        this.lb_NI0402_stat.Text = "Отсутствует подключение!";
        // 
        // lb_NI0401_stat
        // 
        this.lb_NI0401_stat.AutoSize = true;
        this.lb_NI0401_stat.Location = new System.Drawing.Point(289, 247);
        this.lb_NI0401_stat.Name = "lb_NI0401_stat";
        this.lb_NI0401_stat.Size = new System.Drawing.Size(241, 20);
        this.lb_NI0401_stat.TabIndex = 13;
        this.lb_NI0401_stat.Text = "Отсутствует подключение!";
        // 
        // lb_SHKZ_stat
        // 
        this.lb_SHKZ_stat.AutoSize = true;
        this.lb_SHKZ_stat.Location = new System.Drawing.Point(289, 205);
        this.lb_SHKZ_stat.Name = "lb_SHKZ_stat";
        this.lb_SHKZ_stat.Size = new System.Drawing.Size(241, 20);
        this.lb_SHKZ_stat.TabIndex = 12;
        this.lb_SHKZ_stat.Text = "Отсутствует подключение!";
        // 
        // lb_NI0403
        // 
        this.lb_NI0403.AutoSize = true;
        this.lb_NI0403.Location = new System.Drawing.Point(69, 331);
        this.lb_NI0403.Name = "lb_NI0403";
        this.lb_NI0403.Size = new System.Drawing.Size(187, 20);
        this.lb_NI0403.TabIndex = 11;
        this.lb_NI0403.Text = "Состояние НИ-04-03:";
        // 
        // lb_NI0402
        // 
        this.lb_NI0402.AutoSize = true;
        this.lb_NI0402.Location = new System.Drawing.Point(69, 289);
        this.lb_NI0402.Name = "lb_NI0402";
        this.lb_NI0402.Size = new System.Drawing.Size(187, 20);
        this.lb_NI0402.TabIndex = 10;
        this.lb_NI0402.Text = "Состояние НИ-04-02:";
        // 
        // lb_NI0401
        // 
        this.lb_NI0401.AutoSize = true;
        this.lb_NI0401.Location = new System.Drawing.Point(69, 247);
        this.lb_NI0401.Name = "lb_NI0401";
        this.lb_NI0401.Size = new System.Drawing.Size(187, 20);
        this.lb_NI0401.TabIndex = 9;
        this.lb_NI0401.Text = "Состояние НИ-04-01:";
        // 
        // lb_SHKZ
        // 
        this.lb_SHKZ.AutoSize = true;
        this.lb_SHKZ.Location = new System.Drawing.Point(69, 205);
        this.lb_SHKZ.Name = "lb_SHKZ";
        this.lb_SHKZ.Size = new System.Drawing.Size(147, 20);
        this.lb_SHKZ.TabIndex = 8;
        this.lb_SHKZ.Text = "Состояние ШКЗ:";
        // 
        // lb_YK2_stat
        // 
        this.lb_YK2_stat.AutoSize = true;
        this.lb_YK2_stat.Location = new System.Drawing.Point(289, 164);
        this.lb_YK2_stat.Name = "lb_YK2_stat";
        this.lb_YK2_stat.Size = new System.Drawing.Size(241, 20);
        this.lb_YK2_stat.TabIndex = 7;
        this.lb_YK2_stat.Text = "Отсутствует подключение!";
        // 
        // lb_YK1_stat
        // 
        this.lb_YK1_stat.AutoSize = true;
        this.lb_YK1_stat.Location = new System.Drawing.Point(289, 118);
        this.lb_YK1_stat.Name = "lb_YK1_stat";
        this.lb_YK1_stat.Size = new System.Drawing.Size(241, 20);
        this.lb_YK1_stat.TabIndex = 6;
        this.lb_YK1_stat.Text = "Отсутствует подключение!";
        // 
        // lb_CM7209_stat
        // 
        this.lb_CM7209_stat.AutoSize = true;
        this.lb_CM7209_stat.Location = new System.Drawing.Point(289, 74);
        this.lb_CM7209_stat.Name = "lb_CM7209_stat";
        this.lb_CM7209_stat.Size = new System.Drawing.Size(241, 20);
        this.lb_CM7209_stat.TabIndex = 5;
        this.lb_CM7209_stat.Text = "Отсутствует подключение!";
        // 
        // lb_CM1810_stat
        // 
        this.lb_CM1810_stat.AutoSize = true;
        this.lb_CM1810_stat.Location = new System.Drawing.Point(289, 28);
        this.lb_CM1810_stat.Name = "lb_CM1810_stat";
        this.lb_CM1810_stat.Size = new System.Drawing.Size(241, 20);
        this.lb_CM1810_stat.TabIndex = 4;
        this.lb_CM1810_stat.Text = "Отсутствует подключение!";
        // 
        // lb_UK2
        // 
        this.lb_UK2.AutoSize = true;
        this.lb_UK2.Location = new System.Drawing.Point(69, 164);
        this.lb_UK2.Name = "lb_UK2";
        this.lb_UK2.Size = new System.Drawing.Size(144, 20);
        this.lb_UK2.TabIndex = 3;
        this.lb_UK2.Text = "Сотяние ШКИ-2:";
        // 
        // lb_UK1
        // 
        this.lb_UK1.AutoSize = true;
        this.lb_UK1.Location = new System.Drawing.Point(69, 118);
        this.lb_UK1.Name = "lb_UK1";
        this.lb_UK1.Size = new System.Drawing.Size(144, 20);
        this.lb_UK1.TabIndex = 2;
        this.lb_UK1.Text = "Сотяние ШКИ-1:";
        // 
        // lb_CM7209
        // 
        this.lb_CM7209.AutoSize = true;
        this.lb_CM7209.Location = new System.Drawing.Point(69, 74);
        this.lb_CM7209.Name = "lb_CM7209";
        this.lb_CM7209.Size = new System.Drawing.Size(176, 20);
        this.lb_CM7209.TabIndex = 1;
        this.lb_CM7209.Text = "Состояние СМ7209:";
        // 
        // lb_CM1810
        // 
        this.lb_CM1810.AutoSize = true;
        this.lb_CM1810.Location = new System.Drawing.Point(69, 28);
        this.lb_CM1810.Name = "lb_CM1810";
        this.lb_CM1810.Size = new System.Drawing.Size(176, 20);
        this.lb_CM1810.TabIndex = 0;
        this.lb_CM1810.Text = "Состояние СМ1810:";
        // 
        // tab_list
        // 
        this.tab_list.Controls.Add(this.bt_print);
        this.tab_list.Controls.Add(this.bt_export);
        this.tab_list.Controls.Add(this.bt_refresh_list);
        this.tab_list.Controls.Add(this.listBox1);
        this.tab_list.Location = new System.Drawing.Point(4, 29);
        this.tab_list.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        this.tab_list.Name = "tab_list";
        this.tab_list.Padding = new System.Windows.Forms.Padding(7, 6, 7, 6);
        this.tab_list.Size = new System.Drawing.Size(609, 473);
        this.tab_list.TabIndex = 1;
        this.tab_list.Text = "События";
        this.tab_list.UseVisualStyleBackColor = true;
        // 
        // bt_print
        // 
        this.bt_print.AccessibleDescription = "Будет в будущих версиях";
        this.bt_print.AutoEllipsis = true;
        this.bt_print.Enabled = false;
        this.bt_print.Location = new System.Drawing.Point(439, 432);
        this.bt_print.Name = "bt_print";
        this.bt_print.Size = new System.Drawing.Size(115, 30);
        this.bt_print.TabIndex = 3;
        this.bt_print.Text = "Печать";
        this.bt_print.UseVisualStyleBackColor = true;
        // 
        // bt_export
        // 
        this.bt_export.Location = new System.Drawing.Point(238, 432);
        this.bt_export.Name = "bt_export";
        this.bt_export.Size = new System.Drawing.Size(170, 30);
        this.bt_export.TabIndex = 2;
        this.bt_export.Text = "Экспортировать";
        this.bt_export.UseVisualStyleBackColor = true;
        this.bt_export.Click += new System.EventHandler(this.bt_export_Click);
        // 
        // bt_refresh_list
        // 
        this.bt_refresh_list.Location = new System.Drawing.Point(58, 432);
        this.bt_refresh_list.Name = "bt_refresh_list";
        this.bt_refresh_list.Size = new System.Drawing.Size(128, 31);
        this.bt_refresh_list.TabIndex = 1;
        this.bt_refresh_list.Text = "Обновить";
        this.bt_refresh_list.UseVisualStyleBackColor = true;
        this.bt_refresh_list.Click += new System.EventHandler(this.bt_refresh_list_Click);
        // 
        // listBox1
        // 
        this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.listBox1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
        this.listBox1.FormattingEnabled = true;
        this.listBox1.ItemHeight = 20;
        this.listBox1.Location = new System.Drawing.Point(0, 0);
        this.listBox1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        this.listBox1.Name = "listBox1";
        this.listBox1.ScrollAlwaysVisible = true;
        this.listBox1.Size = new System.Drawing.Size(605, 424);
        this.listBox1.TabIndex = 0;
        // 
        // tab_set
        // 
        this.tab_set.Controls.Add(this.cb_client);
        this.tab_set.Controls.Add(this.bt_lan_connect);
        this.tab_set.Controls.Add(this.tb_port);
        this.tab_set.Controls.Add(this.lb_port);
        this.tab_set.Controls.Add(this.lb_ip);
        this.tab_set.Controls.Add(this.tb_ip);
        this.tab_set.Controls.Add(this.lb_lan_set);
        this.tab_set.Controls.Add(this.lb_com_set);
        this.tab_set.Controls.Add(this.bt_connect_set);
        this.tab_set.Controls.Add(this.bt_com_ref);
        this.tab_set.Controls.Add(this.lb_bdr);
        this.tab_set.Controls.Add(this.list_com);
        this.tab_set.Controls.Add(this.tb_bdr);
        this.tab_set.Controls.Add(this.lb_COM_port);
        this.tab_set.Location = new System.Drawing.Point(4, 29);
        this.tab_set.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        this.tab_set.Name = "tab_set";
        this.tab_set.Size = new System.Drawing.Size(609, 473);
        this.tab_set.TabIndex = 2;
        this.tab_set.Text = "Настройки";
        this.tab_set.UseVisualStyleBackColor = true;
        // 
        // cb_client
        // 
        this.cb_client.AutoSize = true;
        this.cb_client.Location = new System.Drawing.Point(201, 186);
        this.cb_client.Name = "cb_client";
        this.cb_client.Size = new System.Drawing.Size(90, 24);
        this.cb_client.TabIndex = 13;
        this.cb_client.Text = "Клиент";
        this.cb_client.UseVisualStyleBackColor = true;
        this.cb_client.CheckedChanged += new System.EventHandler(this.cb_client_CheckedChanged);
        // 
        // bt_lan_connect
        // 
        this.bt_lan_connect.Location = new System.Drawing.Point(184, 148);
        this.bt_lan_connect.Name = "bt_lan_connect";
        this.bt_lan_connect.Size = new System.Drawing.Size(150, 32);
        this.bt_lan_connect.TabIndex = 12;
        this.bt_lan_connect.Text = "Подключиться";
        this.bt_lan_connect.UseVisualStyleBackColor = true;
        this.bt_lan_connect.Click += new System.EventHandler(this.bt_lan_connect_Click);
        // 
        // tb_port
        // 
        this.tb_port.Enabled = false;
        this.tb_port.Location = new System.Drawing.Point(231, 105);
        this.tb_port.Name = "tb_port";
        this.tb_port.Size = new System.Drawing.Size(60, 26);
        this.tb_port.TabIndex = 11;
        this.tb_port.Text = "58181";
        // 
        // lb_port
        // 
        this.lb_port.AutoSize = true;
        this.lb_port.Location = new System.Drawing.Point(178, 106);
        this.lb_port.Name = "lb_port";
        this.lb_port.Size = new System.Drawing.Size(47, 20);
        this.lb_port.TabIndex = 10;
        this.lb_port.Text = "Port:";
        // 
        // lb_ip
        // 
        this.lb_ip.AutoSize = true;
        this.lb_ip.Location = new System.Drawing.Point(134, 64);
        this.lb_ip.Name = "lb_ip";
        this.lb_ip.Size = new System.Drawing.Size(91, 20);
        this.lb_ip.TabIndex = 9;
        this.lb_ip.Text = "IP-adress:";
        // 
        // tb_ip
        // 
        this.tb_ip.Location = new System.Drawing.Point(231, 58);
        this.tb_ip.Name = "tb_ip";
        this.tb_ip.Size = new System.Drawing.Size(150, 26);
        this.tb_ip.TabIndex = 8;
        this.tb_ip.Text = "192.168.0.10";
        // 
        // lb_lan_set
        // 
        this.lb_lan_set.AutoSize = true;
        this.lb_lan_set.Location = new System.Drawing.Point(151, 18);
        this.lb_lan_set.Name = "lb_lan_set";
        this.lb_lan_set.Size = new System.Drawing.Size(183, 20);
        this.lb_lan_set.TabIndex = 7;
        this.lb_lan_set.Text = "Настройки сети LAN";
        // 
        // lb_com_set
        // 
        this.lb_com_set.AutoSize = true;
        this.lb_com_set.Location = new System.Drawing.Point(151, 252);
        this.lb_com_set.Name = "lb_com_set";
        this.lb_com_set.Size = new System.Drawing.Size(200, 20);
        this.lb_com_set.TabIndex = 6;
        this.lb_com_set.Text = "Настройки СОМ-порта";
        // 
        // bt_connect_set
        // 
        this.bt_connect_set.ForeColor = System.Drawing.Color.CornflowerBlue;
        this.bt_connect_set.Location = new System.Drawing.Point(184, 424);
        this.bt_connect_set.Name = "bt_connect_set";
        this.bt_connect_set.Size = new System.Drawing.Size(150, 36);
        this.bt_connect_set.TabIndex = 5;
        this.bt_connect_set.Text = "Подключиться";
        this.bt_connect_set.UseVisualStyleBackColor = true;
        this.bt_connect_set.Click += new System.EventHandler(this.bt_connect_set_Click);
        // 
        // bt_com_ref
        // 
        this.bt_com_ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.bt_com_ref.ForeColor = System.Drawing.Color.DarkCyan;
        this.bt_com_ref.Location = new System.Drawing.Point(313, 325);
        this.bt_com_ref.Name = "bt_com_ref";
        this.bt_com_ref.Size = new System.Drawing.Size(194, 29);
        this.bt_com_ref.TabIndex = 4;
        this.bt_com_ref.Text = "Обновить список портов";
        this.bt_com_ref.UseVisualStyleBackColor = true;
        this.bt_com_ref.Click += new System.EventHandler(this.bt_com_ref_Click);
        // 
        // lb_bdr
        // 
        this.lb_bdr.AutoSize = true;
        this.lb_bdr.Location = new System.Drawing.Point(177, 299);
        this.lb_bdr.Name = "lb_bdr";
        this.lb_bdr.Size = new System.Drawing.Size(48, 20);
        this.lb_bdr.TabIndex = 3;
        this.lb_bdr.Text = "BpS:";
        // 
        // list_com
        // 
        this.list_com.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.list_com.FormattingEnabled = true;
        this.list_com.ItemHeight = 20;
        this.list_com.Location = new System.Drawing.Point(231, 325);
        this.list_com.Name = "list_com";
        this.list_com.Size = new System.Drawing.Size(60, 84);
        this.list_com.TabIndex = 2;
        // 
        // tb_bdr
        // 
        this.tb_bdr.Enabled = false;
        this.tb_bdr.Location = new System.Drawing.Point(231, 293);
        this.tb_bdr.Name = "tb_bdr";
        this.tb_bdr.Size = new System.Drawing.Size(60, 26);
        this.tb_bdr.TabIndex = 1;
        this.tb_bdr.Text = "9600";
        // 
        // lb_COM_port
        // 
        this.lb_COM_port.AutoSize = true;
        this.lb_COM_port.Location = new System.Drawing.Point(127, 325);
        this.lb_COM_port.Name = "lb_COM_port";
        this.lb_COM_port.Size = new System.Drawing.Size(98, 20);
        this.lb_COM_port.TabIndex = 0;
        this.lb_COM_port.Text = "COM порт:";
        this.lb_COM_port.Click += new System.EventHandler(this.lb_COM_port_Click);
        // 
        // backgroundWorker1
        // 
        this.backgroundWorker1.WorkerReportsProgress = true;
        this.backgroundWorker1.WorkerSupportsCancellation = true;
        this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
        this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backGroundWorker1_Progress);
        // 
        // notifyIcon1
        // 
        this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
        this.notifyIcon1.Text = "notifyIcon1";
        this.notifyIcon1.Visible = true;
        this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
        // 
        // timer_comport
        // 
        this.timer_comport.Interval = 10000;
        this.timer_comport.Tick += new System.EventHandler(this.timer1_Tick);
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(662, 540);
        this.Controls.Add(this.tabControl1);
        this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
        this.MaximizeBox = false;
        this.MaximumSize = new System.Drawing.Size(670, 570);
        this.MinimumSize = new System.Drawing.Size(670, 570);
        this.Name = "Form1";
        this.Text = "Сигнализация СМ1810";
        this.Load += new System.EventHandler(this.Form1_Load);
        this.tabControl1.ResumeLayout(false);
        this.tab_main.ResumeLayout(false);
        this.tab_main.PerformLayout();
        this.tab_list.ResumeLayout(false);
        this.tab_set.ResumeLayout(false);
        this.tab_set.PerformLayout();
        this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_main;
        private System.Windows.Forms.TabPage tab_list;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TabPage tab_set;
        private System.Windows.Forms.Button bt_refresh_list;
        private System.Windows.Forms.TextBox tb_bdr;
        private System.Windows.Forms.Label lb_COM_port;
        private System.Windows.Forms.ListBox list_com;
        private System.Windows.Forms.Button bt_com_ref;
        private System.Windows.Forms.Label lb_bdr;
        private System.Windows.Forms.Button bt_connect_set;
        private System.Windows.Forms.Label lb_CM7209;
        private System.Windows.Forms.Label lb_CM1810;
        private System.Windows.Forms.Label lb_UK1;
        private System.Windows.Forms.Label lb_UK2;
        private System.Windows.Forms.Label lb_YK2_stat;
        private System.Windows.Forms.Label lb_YK1_stat;
        private System.Windows.Forms.Label lb_CM7209_stat;
        private System.Windows.Forms.Label lb_CM1810_stat;
        private System.Windows.Forms.Label lb_NI0401;
        private System.Windows.Forms.Label lb_SHKZ;
        private System.Windows.Forms.Label lb_NI0403_stat;
        private System.Windows.Forms.Label lb_NI0402_stat;
        private System.Windows.Forms.Label lb_NI0401_stat;
        private System.Windows.Forms.Label lb_SHKZ_stat;
        private System.Windows.Forms.Label lb_NI0403;
        private System.Windows.Forms.Label lb_NI0402;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label lb_lan_set;
        private System.Windows.Forms.Label lb_com_set;
        private System.Windows.Forms.CheckBox cb_client;
        private System.Windows.Forms.Button bt_lan_connect;
        private System.Windows.Forms.TextBox tb_port;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button bt_export;
        private System.Windows.Forms.Button bt_print;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer_comport;
    }
}

