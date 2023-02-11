using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace SoulBackUp
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje al hacer clic en el bot�n");
            

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje al hacer clic en el bot�n");
        }

        public static void CopyDirectory(string sourceDir, string destDir)
        {
            // Crea la carpeta de destino
            Directory.CreateDirectory(destDir);

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

        private void backup_button_Click(object sender, EventArgs e)
        {

            DateTime today = DateTime.Now;
            string date = today.ToString().Replace(":", "-");
            date = date.Replace("/", "-");

            // Nombre de usuario local
            string username = Environment.UserName;

            try
            {
                if (darksouls2checkbox.Checked)
                {
                    string sourceDir = $@"C:\Users\{username}\AppData\Roaming\DarkSoulsII";
                    string destinationDir = $@"C:\Users\{username}\Desktop\SoulsBackUP\DarkSoulsII-BackUP-";
                    CopyDirectory(sourceDir, destinationDir + date);
                }

                if (darksouls3checkbox.Checked)
                {

                    string sourceDir = $@"C:\Users\{username}\AppData\Roaming\DarkSoulsIII";
                    string destinationDir = $@"C:\Users\{username}\Desktop\SoulsBackUP\DarkSoulsIII-BackUP-";
                    CopyDirectory(sourceDir, destinationDir + date);
                }

                if (sekirocheckbox.Checked)
                {

                    string sourceDir = $@"C:\Users\{username}\AppData\Roaming\Sekiro";
                    string destinationDir = $@"C:\Users\{username}\Desktop\SoulsBackUP\Sekiro-BackUP-";
                    CopyDirectory(sourceDir, destinationDir + date);
                }

                if (eldenringcheckbox.Checked)
                {

                    string sourceDir = $@"C:\Users\{username}\AppData\Roaming\EldenRing";
                    string destinationDir = $@"C:\Users\{username}\Desktop\SoulsBackUP\EldenRing-BackUP-";
                    CopyDirectory(sourceDir, destinationDir + date);
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al generar los respaldos");
                throw;
            }





            //MessageBox.Show(fechaHoy.ToShortDateString());

            //using (var dialog = new FolderBrowserDialog())
            //{
            //    // Configura las opciones del cuadro de di�logo
            //    dialog.Description = "Selecciona una carpeta";
            //    dialog.ShowNewFolderButton = true;
            //    dialog.InitialDirectory = origen;

            //    // Muestra el cuadro de di�logo y verifica si se hizo clic en el bot�n Aceptar
            //    if (dialog.ShowDialog() == DialogResult.OK)
            //    {
            //        // Obtiene la ruta seleccionada por el usuario
            //        string selectedPath = dialog.SelectedPath;
            //        MessageBox.Show(selectedPath);
            //        // Usa la ruta seleccionada como sea necesario
            //        // Por ejemplo, puedes mostrar la ruta en un cuadro de texto

            //    }
            //}
        }

        private void darksouls2checkbox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}