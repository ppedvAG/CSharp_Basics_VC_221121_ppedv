namespace GUI_Beispiel
{
    partial class MainWindow
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
            this.Btn_KlickMich = new System.Windows.Forms.Button();
            this.Cbx_Haken = new System.Windows.Forms.CheckBox();
            this.Cbb_Auswahl = new System.Windows.Forms.ComboBox();
            this.Lbl_Output = new System.Windows.Forms.Label();
            this.Tbx_Input = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öffenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesFensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neuesDialogFensterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schließenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Ok = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_KlickMich
            // 
            this.Btn_KlickMich.Location = new System.Drawing.Point(0, 46);
            this.Btn_KlickMich.Name = "Btn_KlickMich";
            this.Btn_KlickMich.Size = new System.Drawing.Size(208, 114);
            this.Btn_KlickMich.TabIndex = 0;
            this.Btn_KlickMich.Text = "Klick Mich";
            this.Btn_KlickMich.UseVisualStyleBackColor = true;
            this.Btn_KlickMich.Click += new System.EventHandler(this.Btn_KlickMich_Click);
            // 
            // Cbx_Haken
            // 
            this.Cbx_Haken.AutoSize = true;
            this.Cbx_Haken.Checked = true;
            this.Cbx_Haken.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Cbx_Haken.Location = new System.Drawing.Point(510, 224);
            this.Cbx_Haken.Name = "Cbx_Haken";
            this.Cbx_Haken.Size = new System.Drawing.Size(197, 36);
            this.Cbx_Haken.TabIndex = 1;
            this.Cbx_Haken.Text = "Bewegegung?";
            this.Cbx_Haken.UseVisualStyleBackColor = true;
            // 
            // Cbb_Auswahl
            // 
            this.Cbb_Auswahl.FormattingEnabled = true;
            this.Cbb_Auswahl.Items.AddRange(new object[] {
            "Hallo",
            "Moin",
            "Ciao"});
            this.Cbb_Auswahl.Location = new System.Drawing.Point(171, 318);
            this.Cbb_Auswahl.Name = "Cbb_Auswahl";
            this.Cbb_Auswahl.Size = new System.Drawing.Size(242, 40);
            this.Cbb_Auswahl.TabIndex = 2;
            // 
            // Lbl_Output
            // 
            this.Lbl_Output.AutoSize = true;
            this.Lbl_Output.Location = new System.Drawing.Point(440, 87);
            this.Lbl_Output.Name = "Lbl_Output";
            this.Lbl_Output.Size = new System.Drawing.Size(195, 32);
            this.Lbl_Output.TabIndex = 3;
            this.Lbl_Output.Text = "Ich bin ein String";
            // 
            // Tbx_Input
            // 
            this.Tbx_Input.AcceptsReturn = true;
            this.Tbx_Input.Location = new System.Drawing.Point(616, 356);
            this.Tbx_Input.Multiline = true;
            this.Tbx_Input.Name = "Tbx_Input";
            this.Tbx_Input.Size = new System.Drawing.Size(200, 174);
            this.Tbx_Input.TabIndex = 4;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(974, 40);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.öffenToolStripMenuItem,
            this.schließenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(90, 36);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // öffenToolStripMenuItem
            // 
            this.öffenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.neuesFensterToolStripMenuItem,
            this.neuesDialogFensterToolStripMenuItem});
            this.öffenToolStripMenuItem.Name = "öffenToolStripMenuItem";
            this.öffenToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.öffenToolStripMenuItem.Text = "Öffen";
            // 
            // neuesFensterToolStripMenuItem
            // 
            this.neuesFensterToolStripMenuItem.Name = "neuesFensterToolStripMenuItem";
            this.neuesFensterToolStripMenuItem.Size = new System.Drawing.Size(379, 44);
            this.neuesFensterToolStripMenuItem.Text = "Neues Fenster";
            this.neuesFensterToolStripMenuItem.Click += new System.EventHandler(this.neuesFensterToolStripMenuItem_Click);
            // 
            // neuesDialogFensterToolStripMenuItem
            // 
            this.neuesDialogFensterToolStripMenuItem.Name = "neuesDialogFensterToolStripMenuItem";
            this.neuesDialogFensterToolStripMenuItem.Size = new System.Drawing.Size(379, 44);
            this.neuesDialogFensterToolStripMenuItem.Text = "Neues Dialog-Fenster";
            this.neuesDialogFensterToolStripMenuItem.Click += new System.EventHandler(this.neuesDialogFensterToolStripMenuItem_Click);
            // 
            // schließenToolStripMenuItem
            // 
            this.schließenToolStripMenuItem.Name = "schließenToolStripMenuItem";
            this.schließenToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.schließenToolStripMenuItem.Text = "Schließen";
            this.schließenToolStripMenuItem.Click += new System.EventHandler(this.schließenToolStripMenuItem_Click);
            // 
            // Btn_Ok
            // 
            this.Btn_Ok.Location = new System.Drawing.Point(133, 449);
            this.Btn_Ok.Name = "Btn_Ok";
            this.Btn_Ok.Size = new System.Drawing.Size(150, 46);
            this.Btn_Ok.TabIndex = 6;
            this.Btn_Ok.Text = "OK";
            this.Btn_Ok.UseVisualStyleBackColor = true;
            this.Btn_Ok.Click += new System.EventHandler(this.Btn_Ok_Click);
            // 
            // MainWindow
            // 
            this.AcceptButton = this.Btn_KlickMich;
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSalmon;
            this.ClientSize = new System.Drawing.Size(974, 584);
            this.Controls.Add(this.Btn_Ok);
            this.Controls.Add(this.Tbx_Input);
            this.Controls.Add(this.Lbl_Output);
            this.Controls.Add(this.Cbb_Auswahl);
            this.Controls.Add(this.Cbx_Haken);
            this.Controls.Add(this.Btn_KlickMich);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainWindow";
            this.Text = "Mein Fenster";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button Btn_KlickMich;
        private CheckBox Cbx_Haken;
        private ComboBox Cbb_Auswahl;
        private Label Lbl_Output;
        private TextBox Tbx_Input;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dateiToolStripMenuItem;
        private ToolStripMenuItem öffenToolStripMenuItem;
        private ToolStripMenuItem neuesFensterToolStripMenuItem;
        private ToolStripMenuItem neuesDialogFensterToolStripMenuItem;
        private ToolStripMenuItem schließenToolStripMenuItem;
        private Button Btn_Ok;
    }
}