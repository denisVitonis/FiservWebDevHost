using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace xampCaseiro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Inicializa os TextBoxes com os caminhos padr�o
            txtApachePath.Text = @"\httpd.exe";
            txtMySQLPath.Text = @"\mysqld.exe";
            txtPHPPath.Text = @"\php.exe";

            UpdateServiceStatus();
        }

        private void UpdateServiceStatus()
        {
            lblStatusApache.Text = IsServiceRunning(txtApachePath.Text) ? "Em execu��o" : "Parado";
            lblStatusMySQL.Text = IsServiceRunning(txtMySQLPath.Text) ? "Em execu��o" : "Parado";
            lblStatusPHP.Text = IsServiceRunning(txtPHPPath.Text) ? "Em execu��o" : "Parado";
        }

        private bool IsServiceRunning(string path)
        {
            var processName = Path.GetFileNameWithoutExtension(path);
            foreach (var process in Process.GetProcessesByName(processName))
            {
                if (process.MainModule.FileName.Equals(path, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }
            return false;
        }

        private void btnStartApache_Click(object sender, EventArgs e)
        {
            StartProcess(txtApachePath.Text);
            UpdateServiceStatus();
        }

        private void btnStopApache_Click(object sender, EventArgs e)
        {
            StopProcess("httpd");
            UpdateServiceStatus();
        }

        private void btnStartMySQL_Click(object sender, EventArgs e)
        {
            string mysqlPath = txtMySQLPath.Text;

            if (string.IsNullOrEmpty(mysqlPath) || !System.IO.File.Exists(mysqlPath))
            {
                MessageBox.Show("O caminho do MySQL n�o � v�lido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mysqlDirectory = System.IO.Path.GetDirectoryName(mysqlPath);
            StartProcessMysql(mysqlDirectory, "mysqld", "--console");
            UpdateServiceStatus();
        }

        private void btnStopMySQL_Click(object sender, EventArgs e)
        {
            StopProcess("mysqld");
            UpdateServiceStatus();
        }


        private void btnStartPHP_Click(object sender, EventArgs e)
        {
            StartProcess(txtPHPPath.Text);
            UpdateServiceStatus();
        }

        private void btnStopPHP_Click(object sender, EventArgs e)
        {
            StopProcess("php");
            UpdateServiceStatus();
        }

        private void StartProcess(string fileName, string arguments = "", string workingDirectory = "")
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                };

                if (!string.IsNullOrEmpty(workingDirectory))
                {
                    startInfo.WorkingDirectory = workingDirectory;
                }

                Process process = new Process { StartInfo = startInfo };
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar o processo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void StopProcess(string processName)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName(processName))
                {
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao parar o processo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void StartProcessMysql(string? workingDirectory, string? fileName, string arguments = "")
        {
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("O nome do arquivo n�o pode ser nulo ou vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(workingDirectory))
            {
                MessageBox.Show("O diret�rio de trabalho n�o pode ser nulo ou vazio.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    FileName = fileName,
                    Arguments = arguments,
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    CreateNoWindow = true,
                    WorkingDirectory = workingDirectory // Define o diret�rio de trabalho
                };

                Process process = new Process { StartInfo = startInfo };
                process.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao iniciar o processo: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenPHPConfig_Click(object sender, EventArgs e)
        {

            string phpPath = txtPHPPath.Text;

            if (string.IsNullOrEmpty(phpPath) || !File.Exists(phpPath))
            {
                MessageBox.Show("O caminho para o execut�vel PHP n�o � v�lido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string phpDirectory = Path.GetDirectoryName(phpPath);
            if (phpDirectory == null)
            {
                MessageBox.Show("N�o foi poss�vel determinar o diret�rio do PHP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phpConfigPath = Path.Combine(phpDirectory, "php.ini");


            if (File.Exists(phpConfigPath))
            {
                try
                {

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "notepad.exe",
                        Arguments = phpConfigPath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao abrir o arquivo php.ini: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo php.ini n�o encontrado no diret�rio do PHP.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenApacheConfig_Click(object sender, EventArgs e)
        {

            string apachePath = txtApachePath.Text;

            if (string.IsNullOrEmpty(apachePath) || !File.Exists(apachePath))
            {
                MessageBox.Show("O caminho para o execut�vel Apache n�o � v�lido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string apacheBinDirectory = Path.GetDirectoryName(apachePath);
            if (apacheBinDirectory == null)
            {
                MessageBox.Show("N�o foi poss�vel determinar o diret�rio do Apache.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string apacheRootDirectory = Path.GetFullPath(Path.Combine(apacheBinDirectory, ".."));

            string apacheConfigPath = Path.Combine(apacheRootDirectory, "conf", "httpd.conf");

            if (File.Exists(apacheConfigPath))
            {
                try
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "notepad.exe",
                        Arguments = apacheConfigPath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao abrir o arquivo httpd.conf: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo httpd.conf n�o encontrado no diret�rio do Apache.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOpenMysqlConfig_Click(object sender, EventArgs e)
        {

            string mysqlPath = txtMySQLPath.Text;

            if (string.IsNullOrEmpty(mysqlPath) || !File.Exists(mysqlPath))
            {
                MessageBox.Show("O caminho para o execut�vel Mysql n�o � v�lido. Verifique e tente novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string mysqlDirectory = Path.GetDirectoryName(mysqlPath);
            if (mysqlDirectory == null)
            {
                MessageBox.Show("N�o foi poss�vel determinar o diret�rio do Mysql.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string mysqlConfigPath = Path.Combine(mysqlDirectory, "my.ini");


            if (File.Exists(mysqlConfigPath))
            {
                try
                {

                    Process.Start(new ProcessStartInfo
                    {
                        FileName = "notepad.exe",
                        Arguments = mysqlConfigPath,
                        UseShellExecute = true
                    });
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao abrir o arquivo my.ini: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Arquivo php.ini n�o encontrado no diret�rio do Mysql.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSavePaths_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter("caminhos.txt"))
                {
                    sw.WriteLine(txtApachePath.Text);
                    sw.WriteLine(txtMySQLPath.Text);
                    sw.WriteLine(txtPHPPath.Text);
                }
                MessageBox.Show("Caminhos salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar os caminhos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadPaths_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists("caminhos.txt"))
                {
                    using (StreamReader sr = new StreamReader("caminhos.txt"))
                    {
                        txtApachePath.Text = sr.ReadLine();
                        txtMySQLPath.Text = sr.ReadLine();
                        txtPHPPath.Text = sr.ReadLine();
                    }
                    MessageBox.Show("Caminhos carregados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Arquivo de caminhos n�o encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar os caminhos: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBrowseApache_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Execut�veis (*.exe)|*.exe|Todos os Arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione o execut�vel do Apache";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtApachePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowseMySQL_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Execut�veis (*.exe)|*.exe|Todos os Arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione o execut�vel do MySQL";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtMySQLPath.Text = openFileDialog.FileName;
                }
            }
        }

        private void btnBrowsePHP_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Execut�veis (*.exe)|*.exe|Todos os Arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione o execut�vel do PHP";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtPHPPath.Text = openFileDialog.FileName;
                }
            }
        }



        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void lblStatusApache_Click(object sender, EventArgs e)
        {

        }

        private void lblStatusPHP_Click(object sender, EventArgs e)
        {

        }
    }
}
