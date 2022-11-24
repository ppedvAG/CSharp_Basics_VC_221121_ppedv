namespace GUI_Beispiel
{
    //Bsp-Enum
    enum Test { Test1, Test2 }

    //PARTIAL besagt, dass diese Klasse in mehrere Teile (Dateien) aufgeteilt ist
    public partial class MainWindow : Form
    {
        //Konstruktor f�r das Form (Fenster)
        public MainWindow()
        {
            //Diese Methode initialisiert alle im Designer definierten Objekte. Sie sollte die erste Methode im Konstruktor sein
            InitializeComponent();

            //Neuzuweisung einer Property des Forms
            this.BackColor = Color.LightGreen;

            for (int i = 0; i < Enum.GetValues(typeof(Test)).Length; i++)
            {
                //Bef�llung der ComboBox mit Enum-Elementen
                Cbb_Auswahl.Items.Add((Test)i);
            }
        }

        //EventHandler-Methoden

        //EventHandler, welche auf einen Klick auf den Button 'OK# reagiert
        private void Btn_KlickMich_Click(object sender, EventArgs e)
        {
            //Neuzuweisung einer Eigenschaft des Forms
            this.BackColor = Color.DarkOrange;

            //Neuzuweisung einer Eigenschaft des Buttons
            this.Btn_KlickMich.Text = "Button wurde angeklickt";

            //Pr�fung, ob in der ComboBox ein Element angew�hlt wurde
            if (this.Cbx_Haken.Checked)
                //Neuzuweisung einer Eigenschaft des Buttons �ber den sender-Parameter
                (sender as Button).Left += 10;

            //Pr�fung, ob in der ComboBox ein Element angew�hlt wurde
            if (Cbb_Auswahl.SelectedItem != null)
                //�bertrag des Elements in das Label
                this.Lbl_Output.Text = Cbb_Auswahl.SelectedItem?.ToString();
        }

        private void schlie�enToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Aufruf einer MessageBox
            DialogResult result = MessageBox.Show("M�chtest du wirklich das Programm beenden?", "Beenden", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //Pr�fung des geklickten Buttons
            if (result == DialogResult.Yes)
                //Schlie�end des Fensters
                this.Close();

            //Schlie�end der Applikation
            //Application.Exit();
        }

        private void neuesFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form neuesFenster = new MainWindow();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            neuesFenster.Text = "Neues Fenster";
            //�ffnen des Forms als gleichberechtigtes Fenster
            neuesFenster.Show();
        }

        private void neuesDialogFensterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanziieren eines neuen Forms
            Form neuesFenster = new MainWindow();
            //Neuzuweisung einer Eigenschaft des neuen Fensters
            neuesFenster.Text = "Neues Dialog-Fenster";
            //�ffen des Forms als Dialogfenster (muss exklusiv bearbeitet werden) und �berpr�fung des zur�ckgegebenen DialogResults (s.u.)
            if (neuesFenster.ShowDialog() == DialogResult.OK)
            {
                Lbl_Output.Text = "Dialog hat OK gesendet";
            }
        }

        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            //Setzen des DialogResults des DialogFensters (wird von ShowDialog zur�ckgegeben)
            this.DialogResult = DialogResult.OK;
        }
    }
}