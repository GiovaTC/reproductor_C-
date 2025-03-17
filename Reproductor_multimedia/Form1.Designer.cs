namespace Reproductor_multimedia
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnAbrir = new Button();
            btnReproducir = new Button();
            reproductor = new AxWMPLib.AxWindowsMediaPlayer();
            dialogoAbrir = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)reproductor).BeginInit();
            SuspendLayout();
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(12, 433);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(140, 23);
            btnAbrir.TabIndex = 1;
            btnAbrir.Text = "Abrir archivo";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += button1_Click;
            // 
            // btnReproducir
            // 
            btnReproducir.Location = new Point(169, 433);
            btnReproducir.Name = "btnReproducir";
            btnReproducir.Size = new Size(140, 23);
            btnReproducir.TabIndex = 2;
            btnReproducir.Text = "Reproducir / Pausar";
            btnReproducir.UseVisualStyleBackColor = true;
            btnReproducir.Click += button2_Click;
            // 
            // reproductor
            // 
            reproductor.Enabled = true;
            reproductor.Location = new Point(0, 0);
            reproductor.Name = "reproductor";
            reproductor.OcxState = (AxHost.State)resources.GetObject("reproductor.OcxState");
            reproductor.Size = new Size(800, 427);
            reproductor.TabIndex = 3;
            reproductor.Enter += reproductor_Enter;
            // 
            // dialogoAbrir
            // 
            dialogoAbrir.FileName = "openFileDialog1";
            dialogoAbrir.FileOk += openFileDialog1_FileOk;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 468);
            Controls.Add(reproductor);
            Controls.Add(btnReproducir);
            Controls.Add(btnAbrir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)reproductor).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAbrir;
        private Button btnReproducir;
        private AxWMPLib.AxWindowsMediaPlayer reproductor;
        private OpenFileDialog dialogoAbrir;
    }
}
