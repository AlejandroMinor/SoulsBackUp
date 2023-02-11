using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace SoulBackUp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje al hacer clic en el botón");
            

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje al hacer clic en el botón");
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

            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToShortDateString().Replace("/", "-");

            string username = Environment.UserName;
            string sourceDir = $@"C:\Users\{username}\AppData\Roaming\Prueba";
            string destinationDir = $@"C:\Users\{username}\Desktop\Prueba";

            // Copiar carpeta dark souls y pegar en escritorio

            //File.Copy(origen, destino, true);

            CopyDirectory(sourceDir, destinationDir+fecha);

            MessageBox.Show(fechaHoy.ToShortDateString());

            //using (var dialog = new FolderBrowserDialog())
            //{
            //    // Configura las opciones del cuadro de diálogo
            //    dialog.Description = "Selecciona una carpeta";
            //    dialog.ShowNewFolderButton = true;
            //    dialog.InitialDirectory = origen;

            //    // Muestra el cuadro de diálogo y verifica si se hizo clic en el botón Aceptar
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
    }
}