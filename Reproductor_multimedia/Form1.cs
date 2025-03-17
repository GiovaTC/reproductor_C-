namespace Reproductor_multimedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dialogoAbrir.ShowDialog() == DialogResult.OK)
            {
                reproductor.URL = dialogoAbrir.FileName;
                // Opcional: Mostrar el nombre del archivo
                // lblNombreArchivo.Text = dialogoAbrir.SafeFileName;
            }
        }

 /*       private void button2_Click(object sender, EventArgs e)
        {
            if (reproductor.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                reproductor.Ctlcontrols.pause();
                btnReproducir.Text = "Reproducir";
            }
            else
            {
                reproductor.Ctlcontrols.play();
                btnReproducir.Text = "Pausar";
            }
        }*/

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (dialogoAbrir.ShowDialog() == DialogResult.OK)
            {
                reproductor.URL = dialogoAbrir.FileName;
                // Opcional: Mostrar el nombre del archivo
                // lblNombreArchivo.Text = dialogoAbrir.SafeFileName;
            }
        }

        private void reproductor_Enter(object sender, EventArgs e)
        {
            if (reproductor.currentMedia != null)
            {
                // Actualizar el máximo del TrackBar de progreso
                // barraProgreso.Maximum = (int)reproductor.currentMedia.duration;
            }
        }
    }
}
