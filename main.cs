using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;
using System.Security.Permissions;


namespace SoulBackUp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            showPathtxt();
        }

        private void showPathtxt() {
          
        pathtxt.Text = $"La ruta actual es {get_path()}";

        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        public static void CopyDirectory(string sourceDir, string destDir)
        {
            // Crea la carpeta de destino
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
            catch (Exception)
            {
                MessageBox.Show("Error en la ruta para " + sourceDir,"ERROR");
                
                throw;
            }


        }

        private void changePath() {

            try
            {
                // Nombre de usuario local se toma de forma automatica
                string username = Environment.UserName;

                string rutaMisDocumentos = get_path();
                string selectedPath = rutaMisDocumentos;

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

                    }

                }

                // Crear un diccionario
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("destino", selectedPath);

                // Guardar el diccionario en un archivo de texto
                using (StreamWriter file = new StreamWriter($@"cache.txt"))
                {
                    foreach (KeyValuePair<string, string> entry in dict)
                    {
                        file.WriteLine("{0},{1}", entry.Key, entry.Value);
                    }
                }

                if (selectedPath != rutaMisDocumentos) {
                    MessageBox.Show($"Nueva ruta establecida {selectedPath}","Alerta");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error de acceso, intenta otra ruta ", "Alerta");
                throw;
            }

        }


        private void createDefaultPath()
        {

            try
            {
                // Nombre de usuario local se toma de forma automatica
                string username = Environment.UserName;

                string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string selectedPath = rutaMisDocumentos;
                

                // Crear un diccionario
                Dictionary<string, string> dict = new Dictionary<string, string>();
                dict.Add("destino", selectedPath);

                // Guardar el diccionario en un archivo de texto
                using (StreamWriter file = new StreamWriter($@"cache.txt"))
                {
                    foreach (KeyValuePair<string, string> entry in dict)
                    {
                        file.WriteLine("{0},{1}", entry.Key, entry.Value);
                    }
                }
                MessageBox.Show("Se generó el archivo cache.txt, este sirve para guardar la ruta de almacenamiento.", "Alerta");
            }
            catch (Exception)
            {
                MessageBox.Show("Error de acceso, intenta otra ruta ", "Error");
                throw;
            }

        }

        private string  get_path() {
            string username = Environment.UserName;

            string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string path = rutaMisDocumentos;
            
            if (!File.Exists($@"cache.txt")){
                createDefaultPath();
            }

            try
            {
                using (StreamReader sr = new StreamReader($@"cache.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string linea = sr.ReadLine();
                        string[] partes = linea.Split(',');
                        string clave = partes[0];
                        string valor = partes[1];
                        path = valor;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al leer archivo", "Error");
                throw;
            }

 

            return path;

        }


        private Boolean verifyPath(String path) {

            if (Directory.Exists(path))
            {
                return true;
            }
            else {
                MessageBox.Show($"Error no se cuentra la ruta {path}", "Error");
                return false;
            } 
        }

        private void backup_button_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Now;
            string date = today.ToString().Replace(":", "-");
            date = date.Replace("/", "-");

            // Nombre de usuario local se toma de forma automatica
            string username = Environment.UserName;

            string rutaMisDocumentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string rutaDestino = rutaMisDocumentos;

            rutaDestino = get_path();

            string log = "";

            try
            {

                if (darksoulscheckbox.Checked)
                {

                    string sourceDir = $@"{rutaMisDocumentos}\NBGI";
                    string destinationDir = $@"{rutaDestino}\SoulsBackUP\DarkSouls-BackUP-";
                    if (verifyPath(sourceDir))
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
                    if (verifyPath(sourceDir))
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
                    if (verifyPath(sourceDir))
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
                    if (verifyPath(sourceDir))
                    {
                        CopyDirectory(sourceDir, destinationDir + date);
                        log += " -> Sekiro ✔\n";
                    }
                    else log += " -> Sekiro ❌\n";
                }

                if (eldenringcheckbox.Checked)
                {

                    string sourceDir = $@"C:\Users\{username}\AppData\Roaming\EldenRingx";
                    string destinationDir = $@"{rutaDestino}\SoulsBackUP\EldenRing-BackUP-";
                    if (verifyPath(sourceDir))
                    {
                        CopyDirectory(sourceDir, destinationDir + date);
                        log += " -> Elden Ring ✔\n";
                    }
                    else log += " -> Elden Ring ❌\n";

                }




                MessageBox.Show(" 💾 Copia de seguridad disponible en: \n" + $@" 📁 {rutaDestino}\SoulsBackUP "+ " \n \n Log de eventos: \n" + log,"SoulsBackUP - Resultados");

            }
            catch (Exception)
            {
                MessageBox.Show("Error al generar los respaldos", "Error");
                throw;
            }


        }

        private void darksouls2checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void pathtxt_Click(object sender, EventArgs e)
        {

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
 
        }

        private void devname_Click(object sender, EventArgs e)
        {

        }

        private void darksoulscheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}