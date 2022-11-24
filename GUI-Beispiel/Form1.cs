namespace GUI_Beispiel
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            this.BackColor = Color.LightGreen;

            Cbb_Auswahl.Items.Add("Servus");
        }

        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;

            this.Btn_KlickMich.Text = "Button wurde angeklickt";

            if(this.Cbx_Haken.Checked)
                (sender as Button).Left += 10;

            this.Lbl_Output.Text = Cbb_Auswahl.SelectedItem?.ToString();
        }

        private void schlieﬂenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Mˆchtest du das Fenster wirklich schlieﬂen?", "Fenster schlieﬂen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form neuesFenster = new MainWindow();

            neuesFenster.Text = "Neues Fenster";

            neuesFenster.Show();
        }

        private void neuesDialogFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form neuesFenster = new MainWindow();

            neuesFenster.Text = "Neues Dialog-Fenster";
            
            if(neuesFenster.ShowDialog() == DialogResult.OK)
            {
                Lbl_Output.Text = "Dialog hat OK gesendet";
            }
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}