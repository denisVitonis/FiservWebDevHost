namespace xampCaseiro
{
    partial class Form1
    {
        //private System.ComponentModel.IContainer components = null;
        private Label lblStatusApache;
        private Label lblStatusMySQL;
        private Label lblStatusPHP;
        private Button btnStartApache;
        private Button btnStopApache;
        private Button btnStartMySQL;
        private Button btnStopMySQL;
        private Button btnStartPHP;
        private Button btnStopPHP;
        private PictureBox pictureBox1;
        private TextBox txtApachePath;
        private TextBox txtMySQLPath;
        private TextBox txtPHPPath;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnSavePaths;
        private Button btnLoadPaths;

        private Button btnBrowseApache;
        private Button btnBrowseMySQL;
        private Button btnBrowsePHP;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblStatusApache = new Label();
            lblStatusMySQL = new Label();
            lblStatusPHP = new Label();
            btnStartApache = new Button();
            btnStopApache = new Button();
            btnStartMySQL = new Button();
            btnStopMySQL = new Button();
            btnStartPHP = new Button();
            btnStopPHP = new Button();
            pictureBox1 = new PictureBox();
            txtApachePath = new TextBox();
            txtMySQLPath = new TextBox();
            txtPHPPath = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnOpenPHPConfig = new Button();
            ConfigMysqlBtn = new Button();
            btnSavePaths = new Button();
            btnLoadPaths = new Button();
            btnBrowseApache = new Button();
            btnBrowseMySQL = new Button();
            btnBrowsePHP = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox5 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // lblStatusApache
            // 
            lblStatusApache.AutoSize = true;
            lblStatusApache.Font = new Font("Tahoma", 12F);
            lblStatusApache.ForeColor = Color.Red;
            lblStatusApache.Location = new Point(532, 23);
            lblStatusApache.Name = "lblStatusApache";
            lblStatusApache.Size = new Size(150, 24);
            lblStatusApache.TabIndex = 0;
            lblStatusApache.Text = "Status Apache: ";
            lblStatusApache.Click += lblStatusApache_Click;
            // 
            // lblStatusMySQL
            // 
            lblStatusMySQL.AutoSize = true;
            lblStatusMySQL.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusMySQL.ForeColor = Color.Red;
            lblStatusMySQL.Location = new Point(532, 23);
            lblStatusMySQL.Name = "lblStatusMySQL";
            lblStatusMySQL.Size = new Size(145, 24);
            lblStatusMySQL.TabIndex = 1;
            lblStatusMySQL.Text = "Status MySQL: ";
            // 
            // lblStatusPHP
            // 
            lblStatusPHP.AutoSize = true;
            lblStatusPHP.Font = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStatusPHP.ForeColor = Color.Red;
            lblStatusPHP.Location = new Point(532, 23);
            lblStatusPHP.Name = "lblStatusPHP";
            lblStatusPHP.Size = new Size(121, 24);
            lblStatusPHP.TabIndex = 2;
            lblStatusPHP.Text = "Status PHP: ";
            lblStatusPHP.Click += lblStatusPHP_Click;
            // 
            // btnStartApache
            // 
            btnStartApache.Location = new Point(17, 25);
            btnStartApache.Name = "btnStartApache";
            btnStartApache.Size = new Size(123, 41);
            btnStartApache.TabIndex = 3;
            btnStartApache.Text = "Iniciar Apache";
            btnStartApache.UseVisualStyleBackColor = true;
            btnStartApache.Click += btnStartApache_Click;
            // 
            // btnStopApache
            // 
            btnStopApache.Location = new Point(167, 25);
            btnStopApache.Name = "btnStopApache";
            btnStopApache.Size = new Size(123, 41);
            btnStopApache.TabIndex = 4;
            btnStopApache.Text = "Parar Apache";
            btnStopApache.UseVisualStyleBackColor = true;
            btnStopApache.Click += btnStopApache_Click;
            // 
            // btnStartMySQL
            // 
            btnStartMySQL.Location = new Point(16, 27);
            btnStartMySQL.Name = "btnStartMySQL";
            btnStartMySQL.Size = new Size(123, 41);
            btnStartMySQL.TabIndex = 5;
            btnStartMySQL.Text = "Iniciar MySQL";
            btnStartMySQL.UseVisualStyleBackColor = true;
            btnStartMySQL.Click += btnStartMySQL_Click;
            // 
            // btnStopMySQL
            // 
            btnStopMySQL.Location = new Point(166, 27);
            btnStopMySQL.Name = "btnStopMySQL";
            btnStopMySQL.Size = new Size(123, 41);
            btnStopMySQL.TabIndex = 6;
            btnStopMySQL.Text = "Parar MySQL";
            btnStopMySQL.UseVisualStyleBackColor = true;
            btnStopMySQL.Click += btnStopMySQL_Click;
            // 
            // btnStartPHP
            // 
            btnStartPHP.Location = new Point(15, 35);
            btnStartPHP.Name = "btnStartPHP";
            btnStartPHP.Size = new Size(123, 41);
            btnStartPHP.TabIndex = 7;
            btnStartPHP.Text = "Iniciar PHP";
            btnStartPHP.UseVisualStyleBackColor = true;
            btnStartPHP.Click += btnStartPHP_Click;
            // 
            // btnStopPHP
            // 
            btnStopPHP.Location = new Point(165, 35);
            btnStopPHP.Name = "btnStopPHP";
            btnStopPHP.Size = new Size(123, 41);
            btnStopPHP.TabIndex = 8;
            btnStopPHP.Text = "Parar PHP";
            btnStopPHP.UseVisualStyleBackColor = true;
            btnStopPHP.Click += btnStopPHP_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // txtApachePath
            // 
            txtApachePath.Location = new Point(17, 103);
            txtApachePath.Name = "txtApachePath";
            txtApachePath.Size = new Size(426, 27);
            txtApachePath.TabIndex = 10;
            // 
            // txtMySQLPath
            // 
            txtMySQLPath.Location = new Point(16, 111);
            txtMySQLPath.Name = "txtMySQLPath";
            txtMySQLPath.Size = new Size(426, 27);
            txtMySQLPath.TabIndex = 11;
            // 
            // txtPHPPath
            // 
            txtPHPPath.Location = new Point(15, 104);
            txtPHPPath.Name = "txtPHPPath";
            txtPHPPath.Size = new Size(426, 27);
            txtPHPPath.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 80);
            label1.Name = "label1";
            label1.Size = new Size(166, 20);
            label1.TabIndex = 13;
            label1.Text = "Inserir Caminho Apache";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 88);
            label2.Name = "label2";
            label2.Size = new Size(162, 20);
            label2.TabIndex = 14;
            label2.Text = "Inserir Caminho MySQL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 81);
            label3.Name = "label3";
            label3.Size = new Size(143, 20);
            label3.TabIndex = 15;
            label3.Text = "Inserir Caminho PHP";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 7F);
            label4.Location = new Point(72, 23);
            label4.Name = "label4";
            label4.Size = new Size(248, 15);
            label4.TabIndex = 16;
            label4.Text = "© DEV TEAM - Fiserv-WebDevHost V.1.7-2024";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(296, 28);
            button1.Name = "button1";
            button1.Size = new Size(147, 34);
            button1.TabIndex = 17;
            button1.Text = "Config Apache";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnOpenApacheConfig_Click;
            // 
            // button2
            // 
            button2.Location = new Point(295, 27);
            button2.Name = "button2";
            button2.Size = new Size(147, 34);
            button2.TabIndex = 18;
            button2.Text = "Admin Mysql";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnOpenPHPConfig
            // 
            btnOpenPHPConfig.Location = new Point(294, 38);
            btnOpenPHPConfig.Name = "btnOpenPHPConfig";
            btnOpenPHPConfig.Size = new Size(147, 34);
            btnOpenPHPConfig.TabIndex = 19;
            btnOpenPHPConfig.Text = "Php ini";
            btnOpenPHPConfig.UseVisualStyleBackColor = true;
            btnOpenPHPConfig.Click += btnOpenPHPConfig_Click;
            // 
            // ConfigMysqlBtn
            // 
            ConfigMysqlBtn.Location = new Point(307, 66);
            ConfigMysqlBtn.Name = "ConfigMysqlBtn";
            ConfigMysqlBtn.Size = new Size(120, 34);
            ConfigMysqlBtn.TabIndex = 20;
            ConfigMysqlBtn.Text = "Config Mysql";
            ConfigMysqlBtn.UseVisualStyleBackColor = true;
            ConfigMysqlBtn.Click += btnStartMySQL_ClickAsync;
            // 
            // btnSavePaths
            // 
            btnSavePaths.Location = new Point(180, 12);
            btnSavePaths.Name = "btnSavePaths";
            btnSavePaths.Size = new Size(175, 30);
            btnSavePaths.TabIndex = 0;
            btnSavePaths.Text = "Salvar Caminhos";
            btnSavePaths.UseVisualStyleBackColor = true;
            btnSavePaths.Click += btnSavePaths_Click;
            // 
            // btnLoadPaths
            // 
            btnLoadPaths.Location = new Point(180, 48);
            btnLoadPaths.Name = "btnLoadPaths";
            btnLoadPaths.Size = new Size(175, 30);
            btnLoadPaths.TabIndex = 1;
            btnLoadPaths.Text = "Carregar Caminhos";
            btnLoadPaths.UseVisualStyleBackColor = true;
            btnLoadPaths.Click += btnLoadPaths_Click;
            // 
            // btnBrowseApache
            // 
            btnBrowseApache.Location = new Point(449, 101);
            btnBrowseApache.Name = "btnBrowseApache";
            btnBrowseApache.Size = new Size(75, 29);
            btnBrowseApache.TabIndex = 0;
            btnBrowseApache.Text = "Buscar";
            btnBrowseApache.UseVisualStyleBackColor = true;
            btnBrowseApache.Click += btnBrowseApache_Click;
            // 
            // btnBrowseMySQL
            // 
            btnBrowseMySQL.Location = new Point(448, 110);
            btnBrowseMySQL.Name = "btnBrowseMySQL";
            btnBrowseMySQL.Size = new Size(76, 28);
            btnBrowseMySQL.TabIndex = 1;
            btnBrowseMySQL.Text = "Buscar";
            btnBrowseMySQL.UseVisualStyleBackColor = true;
            btnBrowseMySQL.Click += btnBrowseMySQL_Click;
            // 
            // btnBrowsePHP
            // 
            btnBrowsePHP.Location = new Point(447, 103);
            btnBrowsePHP.Name = "btnBrowsePHP";
            btnBrowsePHP.Size = new Size(77, 29);
            btnBrowsePHP.TabIndex = 2;
            btnBrowsePHP.Text = "Buscar";
            btnBrowsePHP.UseVisualStyleBackColor = true;
            btnBrowsePHP.Click += btnBrowsePHP_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlLight;
            groupBox1.Controls.Add(btnStartApache);
            groupBox1.Controls.Add(btnStopApache);
            groupBox1.Controls.Add(lblStatusApache);
            groupBox1.Controls.Add(txtApachePath);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnBrowseApache);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(12, 166);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(683, 144);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "APACHE";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonShadow;
            groupBox2.Controls.Add(btnStartMySQL);
            groupBox2.Controls.Add(btnStopMySQL);
            groupBox2.Controls.Add(lblStatusMySQL);
            groupBox2.Controls.Add(txtMySQLPath);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(btnBrowseMySQL);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(ConfigMysqlBtn);
            groupBox2.Location = new Point(12, 317);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(683, 144);
            groupBox2.TabIndex = 22;
            groupBox2.TabStop = false;
            groupBox2.Text = "MYSQL";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ControlLight;
            groupBox3.Controls.Add(groupBox4);
            groupBox3.Controls.Add(btnStartPHP);
            groupBox3.Controls.Add(btnStopPHP);
            groupBox3.Controls.Add(lblStatusPHP);
            groupBox3.Controls.Add(txtPHPPath);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnBrowsePHP);
            groupBox3.Controls.Add(btnOpenPHPConfig);
            groupBox3.Location = new Point(12, 470);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(683, 154);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "PHP";
            // 
            // groupBox4
            // 
            groupBox4.Location = new Point(282, 173);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(220, 56);
            groupBox4.TabIndex = 23;
            groupBox4.TabStop = false;
            groupBox4.Text = "groupBox4";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.FromArgb(242, 88, 26);
            groupBox5.Controls.Add(label4);
            groupBox5.ForeColor = SystemColors.ButtonHighlight;
            groupBox5.Location = new Point(363, 656);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(326, 43);
            groupBox5.TabIndex = 23;
            groupBox5.TabStop = false;
            groupBox5.Text = "FTS LATAM - Monitoring Tools ";
            // 
            // Form1
            // 
            ClientSize = new Size(720, 723);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSavePaths);
            Controls.Add(btnLoadPaths);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Fiserv-WebDevHost V.1.7 - Status dos Serviços";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        private Label label4;
        private Button button1;
        private Button button2;
        private Button btnOpenPHPConfig;
        private Button ConfigMysqlBtn;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
    }
}
