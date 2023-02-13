using System.Configuration;
using System.Diagnostics;
using System.IO;


namespace SoulBackUp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            dsimage.SizeMode = PictureBoxSizeMode.StretchImage;

            string configFile = Path.Combine(AppContext.BaseDirectory, "SoulBackUp.dll.config");

            if (!File.Exists(configFile))
            {
                // Configurar valores predeterminados
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings.Add("destino", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
                config.AppSettings.Settings.Add("primera_ejecucion", "true");
                config.Save(ConfigurationSaveMode.Modified);

                // Mover el archivo de configuración a la ubicación correcta
                File.Move(config.FilePath, Path.ChangeExtension(config.FilePath, ".config"));
            }


            showPathtxt();

            //Comprobando primera vez abriendo el programa 
            if (ConfigurationManager.AppSettings["primera_ejecucion"] == "true")
            {
                var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["primera_ejecucion"].Value = "false";
                config.AppSettings.Settings["destino"].Value = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }




        }

        private void showPathtxt()
        {
            pathtxt.Text = $"La ruta actual es {ConfigurationManager.AppSettings["destino"]}";
        }

        private void CopyDirectory(string sourceDir, string destDir)
        {



            if (Directory.Exists(ConfigurationManager.AppSettings["destino"]))
            {
                Directory.CreateDirectory(destDir);

                try
                {
                    // Copia los archivos de la carpeta de origen a la carpeta de destino
                    foreach (string file in Directory.GetFiles(sourceDir))
                    {
                        string destFile = Path.Combine(destDir, Path.GetFileName(file));
                        File.Copy(file, destFile, true);
                    }

                    // Copia las subcarpetas de la carpeta de origen a la carpeta de destino
                    foreach (string subdir in Directory.GetDirectories(sourceDir))
                    {
                        string destSubDir = Path.Combine(destDir, Path.GetFileName(subdir));
                        CopyDirectory(subdir, destSubDir);
                    }
                }
                catch (IOException ex)
                {
                    throw new IOException($"Error al copiar el archivo {ex.Message}", ex);
                }
                catch (UnauthorizedAccessException ex)
                {
                    throw new UnauthorizedAccessException($"No se tiene acceso al archivo {ex.Message}", ex);
                }
            }
            else
            {
                MessageBox.Show("La ruta seleccionada previamente ya no existe. Por favor selecciona una nueva");
                changePath();

            }




        }

        private void changePath()
        {

            try
            {
                string selectedPath = ConfigurationManager.AppSettings["destino"];

                using (var dialog = new FolderBrowserDialog())
                {
                    // Configura las opciones del cuadro de diálogo
                    dialog.Description = "Selecciona una carpeta";
                    dialog.ShowNewFolderButton = true;
                    // dialog.InitialDirectory = origen;

                    // Muestra el cuadro de diálogo y verifica si se hizo clic en el botón Aceptar
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        // Obtiene la ruta seleccionada por el usuario
                        selectedPath = dialog.SelectedPath;

                        //Actualiza la ruta
                        var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                        config.AppSettings.Settings["destino"].Value = selectedPath;
                        config.Save(ConfigurationSaveMode.Modified);
                        ConfigurationManager.RefreshSection("appSettings");

                        MessageBox.Show($"Nueva ruta establecida {selectedPath}", "Alerta");

                        showPathtxt();

                    }

                }



            }
            catch (Exception)
            {

                throw;
            }

        }



        private void backup_button_Click(object sender, EventArgs e)
        {
            createBackUp();
        }


        private void createBackUp() {

            DateTime today = DateTime.Now;
            string date = today.ToString().Replace(":", "-");
            date = date.Replace("/", "-");

            // Nombre de usuario local se toma de forma automatica
            string username = Environment.UserName;

            string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            string rutaDestino = ConfigurationManager.AppSettings["destino"];

            string log = "";

            try
            {
                if (Directory.Exists(rutaDestino))
                {
                    if (darksoulscheckbox.Checked)
                    {

                        string sourceDir = $@"{rutaMisDocumentos}\NBGI";
                        string destinationDir = $@"{rutaDestino}\SoulsBackUP\DarkSouls-BackUP-";
                        if (Directory.Exists(sourceDir))
                        {
                            CopyDirectory(sourceDir, destinationDir + date);
                            log += " -> Dark Souls (Prepare to Die / Remastered) ✔\n";
                        }
                        else log += " -> Dark Souls (Prepare to Die / Remastered) ❌\n";

                    }

                    if (darksouls2checkbox.Checked)
                    {
                        string sourceDir = $@"C:\Users\{username}\AppData\Roaming\DarkSoulsII";
                        string destinationDir = $@"{rutaDestino}\SoulsBackUP\DarkSoulsII-BackUP-";
                        if (Directory.Exists(sourceDir))
                        {
                            CopyDirectory(sourceDir, destinationDir + date);
                            log += " -> Dark Souls II ✔\n";
                        }
                        else log += " -> Dark Souls II ❌\n";
                    }

                    if (darksouls3checkbox.Checked)
                    {

                        string sourceDir = $@"C:\Users\{username}\AppData\Roaming\DarkSoulsIII";
                        string destinationDir = $@"{rutaDestino}\SoulsBackUP\DarkSoulsIII-BackUP-";
                        if (Directory.Exists(sourceDir))
                        {
                            CopyDirectory(sourceDir, destinationDir + date);
                            log += " -> Dark Souls III ✔\n";
                        }
                        else log += " -> Dark Souls III ❌\n";
                    }

                    if (sekirocheckbox.Checked)
                    {

                        string sourceDir = $@"C:\Users\{username}\AppData\Roaming\Sekiro";
                        string destinationDir = $@"{rutaDestino}\SoulsBackUP\Sekiro-BackUP-";
                        if (Directory.Exists(sourceDir))
                        {
                            CopyDirectory(sourceDir, destinationDir + date);
                            log += " -> Sekiro ✔\n";
                        }
                        else log += " -> Sekiro ❌\n";
                    }

                    if (eldenringcheckbox.Checked)
                    {

                        string sourceDir = $@"C:\Users\{username}\AppData\Roaming\EldenRing";
                        string destinationDir = $@"{rutaDestino}\SoulsBackUP\EldenRing-BackUP-";
                        if (Directory.Exists(sourceDir))
                        {
                            CopyDirectory(sourceDir, destinationDir + date);
                            log += " -> Elden Ring ✔\n";
                        }
                        else log += " -> Elden Ring ❌\n";

                    }
                    if (log != "")
                    {
                        MessageBox.Show(" 💾 Copia de seguridad disponible en: \n" + $@" 📁 {rutaDestino}\SoulsBackUP " + " \n \n Log de eventos: \n" + log, "SoulsBackUP - Resultados");
                        Process.Start("explorer.exe", ConfigurationManager.AppSettings["destino"]);
                    }

                }
                else
                {
                    MessageBox.Show("La ruta seleccionada previamente ya no existe. Por favor selecciona una nueva");
                    changePath();
                    createBackUp();

                }


            }
            catch (IOException ex)
            {
                throw new IOException($"Error al copiar/mover el archivo {ex.Message}", ex);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException($"No se tiene acceso al archivo {ex.Message}", ex);
            }

        }

        private void changepathbutton_Click(object sender, EventArgs e)
        {
            //Cambia el valor de la ruta del archivo txt 
            changePath();
            //Actualiza el txt que muestra la ruta actual
            showPathtxt();
        }

        private void githublogo_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c start https://github.com/AlejandroMinor/SoulsBackUp";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
        }

        private void devname_Click(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c start https://github.com/AlejandroMinor";
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.RedirectStandardOutput = true;
            process.Start();
        }


        private void selectallcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            if (selectallcheckbox.Checked)
            {
                darksoulscheckbox.Checked = true;
                darksouls2checkbox.Checked = true;
                darksouls3checkbox.Checked = true;
                sekirocheckbox.Checked = true;
                eldenringcheckbox.Checked = true;
            }
            else
            {

                darksoulscheckbox.Checked = false;
                darksouls2checkbox.Checked = false;
                darksouls3checkbox.Checked = false;
                sekirocheckbox.Checked = false;
                eldenringcheckbox.Checked = false;
            }
        }


        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}