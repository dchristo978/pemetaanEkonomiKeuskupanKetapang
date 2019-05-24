namespace Pemetaan_Ekonomi_Ketapang.View
{
    using MetroFramework.Forms;
    using System;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="formUtama" />
    /// </summary>
    public partial class formUtama : MetroForm
    {
      
        /// <summary>
        /// Initializes a new instance of the <see cref="formUtama"/> class.
        /// </summary>
        public formUtama()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The formUtama_Load
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void formUtama_Load(object sender, EventArgs e)
        {
            IsMdiContainer = true;
            
        }

        /// <summary>
        /// The input2ToolStripMenuItem_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void input2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form_login tempForm = new form_login();
            this.Hide();
            tempForm.Show();
        }

        private void logoutAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void keluarAplikasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Peringatan!", "Apakah anda yakin ingin keluar aplikasi?", MessageBoxButtons.OKCancel);
            if(dialogResult == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
