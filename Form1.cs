using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.IO;

namespace SoulBackUp
{
    public partial class Main : Form
    {
        public Main()
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