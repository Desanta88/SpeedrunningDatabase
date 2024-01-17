namespace SpeedrunningDatabase
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SpeedrunnersButton = new System.Windows.Forms.Button();
            this.SpeedrunnersTable = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.VideogamesButton = new System.Windows.Forms.Button();
            this.VideogamesTable = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonG = new System.Windows.Forms.Button();
            this.buttonR = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SpeedrunCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SpeedrunsButton = new System.Windows.Forms.Button();
            this.SpeedrunsTable = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonVG = new System.Windows.Forms.Button();
            this.buttonYear = new System.Windows.Forms.Button();
            this.comboBoxVG = new System.Windows.Forms.ComboBox();
            this.textBoxVG = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedrunnersTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideogamesTable)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedrunsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SpeedrunnersButton);
            this.tabPage1.Controls.Add(this.SpeedrunnersTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Speedrunners";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // SpeedrunnersButton
            // 
            this.SpeedrunnersButton.Location = new System.Drawing.Point(427, 363);
            this.SpeedrunnersButton.Name = "SpeedrunnersButton";
            this.SpeedrunnersButton.Size = new System.Drawing.Size(75, 23);
            this.SpeedrunnersButton.TabIndex = 1;
            this.SpeedrunnersButton.Text = "Load data";
            this.SpeedrunnersButton.UseVisualStyleBackColor = true;
            this.SpeedrunnersButton.Click += new System.EventHandler(this.SpeedrunnersButton_Click);
            // 
            // SpeedrunnersTable
            // 
            this.SpeedrunnersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpeedrunnersTable.Location = new System.Drawing.Point(205, 17);
            this.SpeedrunnersTable.Name = "SpeedrunnersTable";
            this.SpeedrunnersTable.Size = new System.Drawing.Size(534, 340);
            this.SpeedrunnersTable.TabIndex = 0;
            this.SpeedrunnersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxVG);
            this.tabPage2.Controls.Add(this.comboBoxVG);
            this.tabPage2.Controls.Add(this.buttonYear);
            this.tabPage2.Controls.Add(this.buttonVG);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.VideogamesButton);
            this.tabPage2.Controls.Add(this.VideogamesTable);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Videogames";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // VideogamesButton
            // 
            this.VideogamesButton.Location = new System.Drawing.Point(488, 371);
            this.VideogamesButton.Name = "VideogamesButton";
            this.VideogamesButton.Size = new System.Drawing.Size(75, 23);
            this.VideogamesButton.TabIndex = 1;
            this.VideogamesButton.Text = "Load data";
            this.VideogamesButton.UseVisualStyleBackColor = true;
            this.VideogamesButton.Click += new System.EventHandler(this.VideogamesButton_Click);
            // 
            // VideogamesTable
            // 
            this.VideogamesTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VideogamesTable.Location = new System.Drawing.Point(300, 6);
            this.VideogamesTable.Name = "VideogamesTable";
            this.VideogamesTable.Size = new System.Drawing.Size(465, 343);
            this.VideogamesTable.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonG);
            this.tabPage3.Controls.Add(this.buttonR);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.SpeedrunCombo);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.SpeedrunsButton);
            this.tabPage3.Controls.Add(this.SpeedrunsTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Speedruns";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonG
            // 
            this.buttonG.Location = new System.Drawing.Point(26, 102);
            this.buttonG.Name = "buttonG";
            this.buttonG.Size = new System.Drawing.Size(75, 23);
            this.buttonG.TabIndex = 7;
            this.buttonG.Text = "Esegui";
            this.buttonG.UseVisualStyleBackColor = true;
            this.buttonG.Click += new System.EventHandler(this.buttonG_Click);
            // 
            // buttonR
            // 
            this.buttonR.Location = new System.Drawing.Point(26, 186);
            this.buttonR.Name = "buttonR";
            this.buttonR.Size = new System.Drawing.Size(75, 23);
            this.buttonR.TabIndex = 6;
            this.buttonR.Text = "Riordina";
            this.buttonR.UseVisualStyleBackColor = true;
            this.buttonR.Click += new System.EventHandler(this.buttonR_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(20, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "riordina la classifica";
            // 
            // SpeedrunCombo
            // 
            this.SpeedrunCombo.FormattingEnabled = true;
            this.SpeedrunCombo.Location = new System.Drawing.Point(23, 60);
            this.SpeedrunCombo.Name = "SpeedrunCombo";
            this.SpeedrunCombo.Size = new System.Drawing.Size(121, 21);
            this.SpeedrunCombo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "filtra per il gioco";
            // 
            // SpeedrunsButton
            // 
            this.SpeedrunsButton.Location = new System.Drawing.Point(503, 366);
            this.SpeedrunsButton.Name = "SpeedrunsButton";
            this.SpeedrunsButton.Size = new System.Drawing.Size(75, 23);
            this.SpeedrunsButton.TabIndex = 1;
            this.SpeedrunsButton.Text = "Load data";
            this.SpeedrunsButton.UseVisualStyleBackColor = true;
            this.SpeedrunsButton.Click += new System.EventHandler(this.SpeedrunsButton_Click);
            // 
            // SpeedrunsTable
            // 
            this.SpeedrunsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SpeedrunsTable.Location = new System.Drawing.Point(295, 6);
            this.SpeedrunsTable.Name = "SpeedrunsTable";
            this.SpeedrunsTable.Size = new System.Drawing.Size(467, 354);
            this.SpeedrunsTable.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(3, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Obtain all the games of a certain publisher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label4.Location = new System.Drawing.Point(6, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(288, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Obtain all the games released on a certain year";
            // 
            // buttonVG
            // 
            this.buttonVG.Location = new System.Drawing.Point(32, 104);
            this.buttonVG.Name = "buttonVG";
            this.buttonVG.Size = new System.Drawing.Size(75, 23);
            this.buttonVG.TabIndex = 4;
            this.buttonVG.Text = "Filtra";
            this.buttonVG.UseVisualStyleBackColor = true;
            this.buttonVG.Click += new System.EventHandler(this.buttonVG_Click);
            // 
            // buttonYear
            // 
            this.buttonYear.Location = new System.Drawing.Point(32, 254);
            this.buttonYear.Name = "buttonYear";
            this.buttonYear.Size = new System.Drawing.Size(75, 23);
            this.buttonYear.TabIndex = 5;
            this.buttonYear.Text = "Filtra";
            this.buttonYear.UseVisualStyleBackColor = true;
            this.buttonYear.Click += new System.EventHandler(this.buttonYear_Click);
            // 
            // comboBoxVG
            // 
            this.comboBoxVG.FormattingEnabled = true;
            this.comboBoxVG.Location = new System.Drawing.Point(9, 56);
            this.comboBoxVG.Name = "comboBoxVG";
            this.comboBoxVG.Size = new System.Drawing.Size(121, 26);
            this.comboBoxVG.TabIndex = 6;
            // 
            // textBoxVG
            // 
            this.textBoxVG.Location = new System.Drawing.Point(9, 200);
            this.textBoxVG.Name = "textBoxVG";
            this.textBoxVG.Size = new System.Drawing.Size(100, 24);
            this.textBoxVG.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedrunnersTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VideogamesTable)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SpeedrunsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView SpeedrunnersTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView VideogamesTable;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView SpeedrunsTable;
        private System.Windows.Forms.Button SpeedrunnersButton;
        private System.Windows.Forms.Button VideogamesButton;
        private System.Windows.Forms.Button SpeedrunsButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox SpeedrunCombo;
        private System.Windows.Forms.Button buttonR;
        private System.Windows.Forms.Button buttonG;
        private System.Windows.Forms.TextBox textBoxVG;
        private System.Windows.Forms.ComboBox comboBoxVG;
        private System.Windows.Forms.Button buttonYear;
        private System.Windows.Forms.Button buttonVG;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

