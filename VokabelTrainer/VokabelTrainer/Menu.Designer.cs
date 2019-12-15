namespace VokabelTrainer
{
    partial class Menu
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtPfadUser = new System.Windows.Forms.TextBox();
            this.btnUserOpen = new MaterialSkin.Controls.MaterialFlatButton();
            this.lblUserEinlesen = new MaterialSkin.Controls.MaterialLabel();
            this.btnVokOpen = new MaterialSkin.Controls.MaterialFlatButton();
            this.pnlSound = new System.Windows.Forms.Panel();
            this.rbtnSoundOff = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnSoundOn = new MaterialSkin.Controls.MaterialRadioButton();
            this.pnlTexture = new System.Windows.Forms.Panel();
            this.rbtnDark = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbtnLight = new MaterialSkin.Controls.MaterialRadioButton();
            this.lblSound = new MaterialSkin.Controls.MaterialLabel();
            this.btnNext0 = new MaterialSkin.Controls.MaterialFlatButton();
            this.txtPfadCSV = new System.Windows.Forms.TextBox();
            this.lblDesignMode = new MaterialSkin.Controls.MaterialLabel();
            this.lblEinlesen = new MaterialSkin.Controls.MaterialLabel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBoxUser = new System.Windows.Forms.ComboBox();
            this.lblUserAbfrage = new MaterialSkin.Controls.MaterialLabel();
            this.comboBoxThemen = new System.Windows.Forms.ComboBox();
            this.lblThemen = new MaterialSkin.Controls.MaterialLabel();
            this.btnBack1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnNext1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnNextGame = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnCorrectAnswer = new MaterialSkin.Controls.MaterialFlatButton();
            this.pictureBoxThumbs = new System.Windows.Forms.PictureBox();
            this.txtLang2 = new System.Windows.Forms.TextBox();
            this.txtLang1 = new System.Windows.Forms.TextBox();
            this.lblLang2 = new MaterialSkin.Controls.MaterialLabel();
            this.lblLang1 = new MaterialSkin.Controls.MaterialLabel();
            this.btnMatch = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnBack2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.btnStart = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.materialTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.pnlSound.SuspendLayout();
            this.pnlTexture.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbs)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Location = new System.Drawing.Point(-2, 106);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(803, 349);
            this.materialTabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtPfadUser);
            this.tabPage1.Controls.Add(this.btnUserOpen);
            this.tabPage1.Controls.Add(this.lblUserEinlesen);
            this.tabPage1.Controls.Add(this.btnVokOpen);
            this.tabPage1.Controls.Add(this.pnlSound);
            this.tabPage1.Controls.Add(this.pnlTexture);
            this.tabPage1.Controls.Add(this.lblSound);
            this.tabPage1.Controls.Add(this.btnNext0);
            this.tabPage1.Controls.Add(this.txtPfadCSV);
            this.tabPage1.Controls.Add(this.lblDesignMode);
            this.tabPage1.Controls.Add(this.lblEinlesen);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(795, 323);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Menu";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtPfadUser
            // 
            this.txtPfadUser.Location = new System.Drawing.Point(48, 199);
            this.txtPfadUser.Name = "txtPfadUser";
            this.txtPfadUser.Size = new System.Drawing.Size(329, 20);
            this.txtPfadUser.TabIndex = 19;
            this.txtPfadUser.Text = "C:\\Users\\Felix\\Documents\\GitHub\\Vokabeltrainer\\UserListe.csv";
            // 
            // btnUserOpen
            // 
            this.btnUserOpen.AutoSize = true;
            this.btnUserOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnUserOpen.Depth = 0;
            this.btnUserOpen.Location = new System.Drawing.Point(48, 228);
            this.btnUserOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnUserOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnUserOpen.Name = "btnUserOpen";
            this.btnUserOpen.Primary = false;
            this.btnUserOpen.Size = new System.Drawing.Size(150, 36);
            this.btnUserOpen.TabIndex = 18;
            this.btnUserOpen.Text = "Öffnen/Bearbeiten";
            this.btnUserOpen.UseVisualStyleBackColor = true;
            this.btnUserOpen.Click += new System.EventHandler(this.btnUserOpen_Click);
            // 
            // lblUserEinlesen
            // 
            this.lblUserEinlesen.AutoSize = true;
            this.lblUserEinlesen.Depth = 0;
            this.lblUserEinlesen.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUserEinlesen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserEinlesen.Location = new System.Drawing.Point(44, 169);
            this.lblUserEinlesen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserEinlesen.Name = "lblUserEinlesen";
            this.lblUserEinlesen.Size = new System.Drawing.Size(206, 19);
            this.lblUserEinlesen.TabIndex = 16;
            this.lblUserEinlesen.Text = "Einlesen der User Datei (csv):";
            // 
            // btnVokOpen
            // 
            this.btnVokOpen.AutoSize = true;
            this.btnVokOpen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnVokOpen.Depth = 0;
            this.btnVokOpen.Location = new System.Drawing.Point(48, 107);
            this.btnVokOpen.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnVokOpen.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnVokOpen.Name = "btnVokOpen";
            this.btnVokOpen.Primary = false;
            this.btnVokOpen.Size = new System.Drawing.Size(150, 36);
            this.btnVokOpen.TabIndex = 15;
            this.btnVokOpen.Text = "Öffnen/Bearbeiten";
            this.btnVokOpen.UseVisualStyleBackColor = true;
            this.btnVokOpen.Click += new System.EventHandler(this.btnVokOpen_Click);
            // 
            // pnlSound
            // 
            this.pnlSound.Controls.Add(this.rbtnSoundOff);
            this.pnlSound.Controls.Add(this.rbtnSoundOn);
            this.pnlSound.Location = new System.Drawing.Point(592, 107);
            this.pnlSound.Name = "pnlSound";
            this.pnlSound.Size = new System.Drawing.Size(200, 81);
            this.pnlSound.TabIndex = 14;
            // 
            // rbtnSoundOff
            // 
            this.rbtnSoundOff.AutoSize = true;
            this.rbtnSoundOff.Depth = 0;
            this.rbtnSoundOff.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnSoundOff.Location = new System.Drawing.Point(5, 42);
            this.rbtnSoundOff.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSoundOff.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSoundOff.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSoundOff.Name = "rbtnSoundOff";
            this.rbtnSoundOff.Ripple = true;
            this.rbtnSoundOff.Size = new System.Drawing.Size(53, 30);
            this.rbtnSoundOff.TabIndex = 12;
            this.rbtnSoundOff.TabStop = true;
            this.rbtnSoundOff.Text = "Aus";
            this.rbtnSoundOff.UseVisualStyleBackColor = true;
            // 
            // rbtnSoundOn
            // 
            this.rbtnSoundOn.AutoSize = true;
            this.rbtnSoundOn.Checked = true;
            this.rbtnSoundOn.Depth = 0;
            this.rbtnSoundOn.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnSoundOn.Location = new System.Drawing.Point(5, 6);
            this.rbtnSoundOn.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnSoundOn.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnSoundOn.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnSoundOn.Name = "rbtnSoundOn";
            this.rbtnSoundOn.Ripple = true;
            this.rbtnSoundOn.Size = new System.Drawing.Size(46, 30);
            this.rbtnSoundOn.TabIndex = 11;
            this.rbtnSoundOn.TabStop = true;
            this.rbtnSoundOn.Text = "An";
            this.rbtnSoundOn.UseVisualStyleBackColor = true;
            // 
            // pnlTexture
            // 
            this.pnlTexture.Controls.Add(this.rbtnDark);
            this.pnlTexture.Controls.Add(this.rbtnLight);
            this.pnlTexture.Location = new System.Drawing.Point(592, 25);
            this.pnlTexture.Name = "pnlTexture";
            this.pnlTexture.Size = new System.Drawing.Size(197, 76);
            this.pnlTexture.TabIndex = 13;
            // 
            // rbtnDark
            // 
            this.rbtnDark.AutoSize = true;
            this.rbtnDark.Depth = 0;
            this.rbtnDark.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnDark.Location = new System.Drawing.Point(5, 40);
            this.rbtnDark.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnDark.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnDark.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnDark.Name = "rbtnDark";
            this.rbtnDark.Ripple = true;
            this.rbtnDark.Size = new System.Drawing.Size(71, 30);
            this.rbtnDark.TabIndex = 7;
            this.rbtnDark.TabStop = true;
            this.rbtnDark.Text = "Dunkel";
            this.rbtnDark.UseVisualStyleBackColor = true;
            this.rbtnDark.Click += new System.EventHandler(this.rbtnDark_Click);
            // 
            // rbtnLight
            // 
            this.rbtnLight.AutoSize = true;
            this.rbtnLight.Checked = true;
            this.rbtnLight.Depth = 0;
            this.rbtnLight.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbtnLight.Location = new System.Drawing.Point(5, 5);
            this.rbtnLight.Margin = new System.Windows.Forms.Padding(0);
            this.rbtnLight.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbtnLight.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbtnLight.Name = "rbtnLight";
            this.rbtnLight.Ripple = true;
            this.rbtnLight.Size = new System.Drawing.Size(53, 30);
            this.rbtnLight.TabIndex = 6;
            this.rbtnLight.TabStop = true;
            this.rbtnLight.Text = "Hell";
            this.rbtnLight.UseVisualStyleBackColor = true;
            this.rbtnLight.Click += new System.EventHandler(this.rbtnLight_Click);
            // 
            // lblSound
            // 
            this.lblSound.AutoSize = true;
            this.lblSound.Depth = 0;
            this.lblSound.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblSound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSound.Location = new System.Drawing.Point(486, 118);
            this.lblSound.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblSound.Name = "lblSound";
            this.lblSound.Size = new System.Drawing.Size(89, 19);
            this.lblSound.TabIndex = 11;
            this.lblSound.Text = "Ton Modus:";
            // 
            // btnNext0
            // 
            this.btnNext0.AutoSize = true;
            this.btnNext0.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext0.Depth = 0;
            this.btnNext0.Location = new System.Drawing.Point(667, 262);
            this.btnNext0.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext0.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext0.Name = "btnNext0";
            this.btnNext0.Primary = false;
            this.btnNext0.Size = new System.Drawing.Size(46, 36);
            this.btnNext0.TabIndex = 8;
            this.btnNext0.Text = "NEXT";
            this.btnNext0.UseVisualStyleBackColor = true;
            this.btnNext0.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // txtPfadCSV
            // 
            this.txtPfadCSV.Location = new System.Drawing.Point(48, 75);
            this.txtPfadCSV.Name = "txtPfadCSV";
            this.txtPfadCSV.Size = new System.Drawing.Size(329, 20);
            this.txtPfadCSV.TabIndex = 7;
            this.txtPfadCSV.Text = "C:\\Users\\Felix\\Documents\\GitHub\\Vokabeltrainer\\VokListe.csv";
            // 
            // lblDesignMode
            // 
            this.lblDesignMode.AutoSize = true;
            this.lblDesignMode.Depth = 0;
            this.lblDesignMode.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblDesignMode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDesignMode.Location = new System.Drawing.Point(487, 35);
            this.lblDesignMode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDesignMode.Name = "lblDesignMode";
            this.lblDesignMode.Size = new System.Drawing.Size(88, 19);
            this.lblDesignMode.TabIndex = 4;
            this.lblDesignMode.Text = "Farb Modus";
            // 
            // lblEinlesen
            // 
            this.lblEinlesen.AutoSize = true;
            this.lblEinlesen.Depth = 0;
            this.lblEinlesen.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblEinlesen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEinlesen.Location = new System.Drawing.Point(44, 35);
            this.lblEinlesen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblEinlesen.Name = "lblEinlesen";
            this.lblEinlesen.Size = new System.Drawing.Size(185, 19);
            this.lblEinlesen.TabIndex = 1;
            this.lblEinlesen.Text = "Einlesen der Tabelle (csv):";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.comboBoxUser);
            this.tabPage2.Controls.Add(this.lblUserAbfrage);
            this.tabPage2.Controls.Add(this.comboBoxThemen);
            this.tabPage2.Controls.Add(this.lblThemen);
            this.tabPage2.Controls.Add(this.btnBack1);
            this.tabPage2.Controls.Add(this.btnNext1);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(795, 323);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Themenauswahl";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBoxUser
            // 
            this.comboBoxUser.FormattingEnabled = true;
            this.comboBoxUser.Location = new System.Drawing.Point(51, 164);
            this.comboBoxUser.Name = "comboBoxUser";
            this.comboBoxUser.Size = new System.Drawing.Size(141, 21);
            this.comboBoxUser.TabIndex = 7;
            // 
            // lblUserAbfrage
            // 
            this.lblUserAbfrage.AutoSize = true;
            this.lblUserAbfrage.Depth = 0;
            this.lblUserAbfrage.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblUserAbfrage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserAbfrage.Location = new System.Drawing.Point(47, 127);
            this.lblUserAbfrage.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserAbfrage.Name = "lblUserAbfrage";
            this.lblUserAbfrage.Size = new System.Drawing.Size(125, 19);
            this.lblUserAbfrage.TabIndex = 6;
            this.lblUserAbfrage.Text = "Wer lernt gerade?";
            // 
            // comboBoxThemen
            // 
            this.comboBoxThemen.FormattingEnabled = true;
            this.comboBoxThemen.Location = new System.Drawing.Point(51, 63);
            this.comboBoxThemen.Name = "comboBoxThemen";
            this.comboBoxThemen.Size = new System.Drawing.Size(141, 21);
            this.comboBoxThemen.TabIndex = 4;
            this.comboBoxThemen.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxThemen_MouseClick);
            // 
            // lblThemen
            // 
            this.lblThemen.AutoSize = true;
            this.lblThemen.Depth = 0;
            this.lblThemen.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblThemen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblThemen.Location = new System.Drawing.Point(47, 27);
            this.lblThemen.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblThemen.Name = "lblThemen";
            this.lblThemen.Size = new System.Drawing.Size(310, 19);
            this.lblThemen.TabIndex = 3;
            this.lblThemen.Text = "Bitte wählen SIe ein zu lernendes Thema aus:";
            // 
            // btnBack1
            // 
            this.btnBack1.AutoSize = true;
            this.btnBack1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack1.Depth = 0;
            this.btnBack1.Location = new System.Drawing.Point(81, 262);
            this.btnBack1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack1.Name = "btnBack1";
            this.btnBack1.Primary = false;
            this.btnBack1.Size = new System.Drawing.Size(47, 36);
            this.btnBack1.TabIndex = 2;
            this.btnBack1.Text = "Back";
            this.btnBack1.UseVisualStyleBackColor = true;
            this.btnBack1.Click += new System.EventHandler(this.btnBack1_Click);
            // 
            // btnNext1
            // 
            this.btnNext1.AutoSize = true;
            this.btnNext1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNext1.Depth = 0;
            this.btnNext1.Location = new System.Drawing.Point(665, 262);
            this.btnNext1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNext1.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNext1.Name = "btnNext1";
            this.btnNext1.Primary = false;
            this.btnNext1.Size = new System.Drawing.Size(46, 36);
            this.btnNext1.TabIndex = 1;
            this.btnNext1.Text = "NEXT";
            this.btnNext1.UseVisualStyleBackColor = true;
            this.btnNext1.Click += new System.EventHandler(this.btnNext1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(235, 198);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnNextGame);
            this.tabPage3.Controls.Add(this.btnCorrectAnswer);
            this.tabPage3.Controls.Add(this.pictureBoxThumbs);
            this.tabPage3.Controls.Add(this.txtLang2);
            this.tabPage3.Controls.Add(this.txtLang1);
            this.tabPage3.Controls.Add(this.lblLang2);
            this.tabPage3.Controls.Add(this.lblLang1);
            this.tabPage3.Controls.Add(this.btnMatch);
            this.tabPage3.Controls.Add(this.btnBack2);
            this.tabPage3.Controls.Add(this.btnStart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(795, 323);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Los geht..";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnNextGame
            // 
            this.btnNextGame.AutoSize = true;
            this.btnNextGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNextGame.Depth = 0;
            this.btnNextGame.Location = new System.Drawing.Point(383, 158);
            this.btnNextGame.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnNextGame.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnNextGame.Name = "btnNextGame";
            this.btnNextGame.Primary = false;
            this.btnNextGame.Size = new System.Drawing.Size(137, 36);
            this.btnNextGame.TabIndex = 11;
            this.btnNextGame.Text = "Nächste Vokabel";
            this.btnNextGame.UseVisualStyleBackColor = true;
            this.btnNextGame.Visible = false;
            this.btnNextGame.Click += new System.EventHandler(this.btnNextGame_Click);
            // 
            // btnCorrectAnswer
            // 
            this.btnCorrectAnswer.AutoSize = true;
            this.btnCorrectAnswer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCorrectAnswer.Depth = 0;
            this.btnCorrectAnswer.Location = new System.Drawing.Point(302, 206);
            this.btnCorrectAnswer.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnCorrectAnswer.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCorrectAnswer.Name = "btnCorrectAnswer";
            this.btnCorrectAnswer.Primary = false;
            this.btnCorrectAnswer.Size = new System.Drawing.Size(142, 36);
            this.btnCorrectAnswer.TabIndex = 10;
            this.btnCorrectAnswer.Text = "Richtige Antwort";
            this.btnCorrectAnswer.UseVisualStyleBackColor = true;
            this.btnCorrectAnswer.Visible = false;
            this.btnCorrectAnswer.Click += new System.EventHandler(this.btnCorrectAnswer_Click);
            // 
            // pictureBoxThumbs
            // 
            this.pictureBoxThumbs.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxThumbs.Location = new System.Drawing.Point(562, 53);
            this.pictureBoxThumbs.Name = "pictureBoxThumbs";
            this.pictureBoxThumbs.Size = new System.Drawing.Size(186, 177);
            this.pictureBoxThumbs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxThumbs.TabIndex = 9;
            this.pictureBoxThumbs.TabStop = false;
            // 
            // txtLang2
            // 
            this.txtLang2.Location = new System.Drawing.Point(383, 111);
            this.txtLang2.Name = "txtLang2";
            this.txtLang2.Size = new System.Drawing.Size(100, 20);
            this.txtLang2.TabIndex = 8;
            // 
            // txtLang1
            // 
            this.txtLang1.Location = new System.Drawing.Point(261, 111);
            this.txtLang1.Name = "txtLang1";
            this.txtLang1.Size = new System.Drawing.Size(100, 20);
            this.txtLang1.TabIndex = 7;
            // 
            // lblLang2
            // 
            this.lblLang2.AutoSize = true;
            this.lblLang2.Depth = 0;
            this.lblLang2.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLang2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLang2.Location = new System.Drawing.Point(398, 70);
            this.lblLang2.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLang2.Name = "lblLang2";
            this.lblLang2.Size = new System.Drawing.Size(66, 19);
            this.lblLang2.TabIndex = 6;
            this.lblLang2.Text = "Englisch";
            // 
            // lblLang1
            // 
            this.lblLang1.AutoSize = true;
            this.lblLang1.Depth = 0;
            this.lblLang1.Font = new System.Drawing.Font("Roboto", 11F);
            this.lblLang1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblLang1.Location = new System.Drawing.Point(273, 70);
            this.lblLang1.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblLang1.Name = "lblLang1";
            this.lblLang1.Size = new System.Drawing.Size(64, 19);
            this.lblLang1.TabIndex = 5;
            this.lblLang1.Text = "Deutsch";
            // 
            // btnMatch
            // 
            this.btnMatch.AutoSize = true;
            this.btnMatch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMatch.Depth = 0;
            this.btnMatch.Location = new System.Drawing.Point(259, 158);
            this.btnMatch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnMatch.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnMatch.Name = "btnMatch";
            this.btnMatch.Primary = false;
            this.btnMatch.Size = new System.Drawing.Size(102, 36);
            this.btnMatch.TabIndex = 4;
            this.btnMatch.Text = "Vergleichen";
            this.btnMatch.UseVisualStyleBackColor = true;
            this.btnMatch.Visible = false;
            this.btnMatch.Click += new System.EventHandler(this.btnMatch_Click);
            // 
            // btnBack2
            // 
            this.btnBack2.AutoSize = true;
            this.btnBack2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack2.Depth = 0;
            this.btnBack2.Location = new System.Drawing.Point(81, 262);
            this.btnBack2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack2.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack2.Name = "btnBack2";
            this.btnBack2.Primary = false;
            this.btnBack2.Size = new System.Drawing.Size(47, 36);
            this.btnBack2.TabIndex = 3;
            this.btnBack2.Text = "Back";
            this.btnBack2.UseVisualStyleBackColor = true;
            this.btnBack2.Click += new System.EventHandler(this.btnBack2_Click);
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnStart.Depth = 0;
            this.btnStart.Location = new System.Drawing.Point(56, 53);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnStart.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnStart.Name = "btnStart";
            this.btnStart.Primary = false;
            this.btnStart.Size = new System.Drawing.Size(72, 36);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Starten";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Location = new System.Drawing.Point(-2, 61);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(65535, 39);
            this.materialTabSelector1.TabIndex = 1;
            this.materialTabSelector1.Text = "materialTabSelector1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "Menu";
            this.Text = "VokTrainer";
            this.materialTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.pnlSound.ResumeLayout(false);
            this.pnlSound.PerformLayout();
            this.pnlTexture.ResumeLayout(false);
            this.pnlTexture.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxThumbs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialFlatButton btnStart;
        private MaterialSkin.Controls.MaterialFlatButton btnNext1;
        private MaterialSkin.Controls.MaterialFlatButton btnBack1;
        private MaterialSkin.Controls.MaterialFlatButton btnBack2;
        private MaterialSkin.Controls.MaterialLabel lblThemen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxThemen;
        private System.Windows.Forms.TabPage tabPage1;
        private MaterialSkin.Controls.MaterialLabel lblSound;
        private MaterialSkin.Controls.MaterialFlatButton btnNext0;
        private System.Windows.Forms.TextBox txtPfadCSV;
        private MaterialSkin.Controls.MaterialLabel lblDesignMode;
        private MaterialSkin.Controls.MaterialLabel lblEinlesen;
        private System.Windows.Forms.Panel pnlTexture;
        private MaterialSkin.Controls.MaterialRadioButton rbtnDark;
        private MaterialSkin.Controls.MaterialRadioButton rbtnLight;
        private System.Windows.Forms.Panel pnlSound;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSoundOff;
        private MaterialSkin.Controls.MaterialRadioButton rbtnSoundOn;
        private System.Windows.Forms.TextBox txtLang2;
        private System.Windows.Forms.TextBox txtLang1;
        private MaterialSkin.Controls.MaterialLabel lblLang2;
        private MaterialSkin.Controls.MaterialLabel lblLang1;
        private MaterialSkin.Controls.MaterialFlatButton btnMatch;
        private MaterialSkin.Controls.MaterialFlatButton btnVokOpen;
        private MaterialSkin.Controls.MaterialFlatButton btnUserOpen;
        private MaterialSkin.Controls.MaterialLabel lblUserEinlesen;
        private System.Windows.Forms.TextBox txtPfadUser;
        private System.Windows.Forms.ComboBox comboBoxUser;
        private MaterialSkin.Controls.MaterialLabel lblUserAbfrage;
        private System.Windows.Forms.PictureBox pictureBoxThumbs;
        private System.Windows.Forms.ImageList imageList1;
        private MaterialSkin.Controls.MaterialFlatButton btnNextGame;
        private MaterialSkin.Controls.MaterialFlatButton btnCorrectAnswer;
    }
}

