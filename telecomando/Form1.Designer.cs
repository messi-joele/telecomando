namespace telecomando
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
            this.laccensione = new System.Windows.Forms.Label();
            this.accensione = new System.Windows.Forms.Button();
            this.textBoxProd = new System.Windows.Forms.TextBox();
            this.textBoxfunz = new System.Windows.Forms.TextBox();
            this.textBoxmodello = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PROD = new System.Windows.Forms.Button();
            this.modello = new System.Windows.Forms.Button();
            this.funz = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxcanale = new System.Windows.Forms.TextBox();
            this.canale = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxCORR = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CORR = new System.Windows.Forms.Button();
            this.volume = new System.Windows.Forms.Label();
            this.alza = new System.Windows.Forms.Button();
            this.abbassa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // laccensione
            // 
            this.laccensione.AutoSize = true;
            this.laccensione.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laccensione.Location = new System.Drawing.Point(189, 55);
            this.laccensione.Name = "laccensione";
            this.laccensione.Size = new System.Drawing.Size(120, 29);
            this.laccensione.TabIndex = 0;
            this.laccensione.Text = "SPENTO";
            // 
            // accensione
            // 
            this.accensione.Location = new System.Drawing.Point(394, 62);
            this.accensione.Name = "accensione";
            this.accensione.Size = new System.Drawing.Size(75, 23);
            this.accensione.TabIndex = 1;
            this.accensione.Text = "ON/OFF";
            this.accensione.UseVisualStyleBackColor = true;
            this.accensione.Click += new System.EventHandler(this.accensione_Click);
            // 
            // textBoxProd
            // 
            this.textBoxProd.Location = new System.Drawing.Point(157, 193);
            this.textBoxProd.Name = "textBoxProd";
            this.textBoxProd.Size = new System.Drawing.Size(100, 20);
            this.textBoxProd.TabIndex = 2;
            // 
            // textBoxfunz
            // 
            this.textBoxfunz.Location = new System.Drawing.Point(157, 291);
            this.textBoxfunz.Name = "textBoxfunz";
            this.textBoxfunz.Size = new System.Drawing.Size(100, 20);
            this.textBoxfunz.TabIndex = 3;
            // 
            // textBoxmodello
            // 
            this.textBoxmodello.Location = new System.Drawing.Point(157, 241);
            this.textBoxmodello.Name = "textBoxmodello";
            this.textBoxmodello.Size = new System.Drawing.Size(100, 20);
            this.textBoxmodello.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "PRODUTTORE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "FUNZIONAMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "MODELLO";
            // 
            // PROD
            // 
            this.PROD.Location = new System.Drawing.Point(307, 197);
            this.PROD.Name = "PROD";
            this.PROD.Size = new System.Drawing.Size(75, 23);
            this.PROD.TabIndex = 8;
            this.PROD.Text = "GET";
            this.PROD.UseVisualStyleBackColor = true;
            this.PROD.Click += new System.EventHandler(this.PROD_Click);
            // 
            // modello
            // 
            this.modello.Location = new System.Drawing.Point(307, 239);
            this.modello.Name = "modello";
            this.modello.Size = new System.Drawing.Size(75, 23);
            this.modello.TabIndex = 9;
            this.modello.Text = "GET";
            this.modello.UseVisualStyleBackColor = true;
            this.modello.Click += new System.EventHandler(this.modello_Click);
            // 
            // funz
            // 
            this.funz.Location = new System.Drawing.Point(307, 284);
            this.funz.Name = "funz";
            this.funz.Size = new System.Drawing.Size(75, 23);
            this.funz.TabIndex = 10;
            this.funz.Text = "GET";
            this.funz.UseVisualStyleBackColor = true;
            this.funz.Click += new System.EventHandler(this.funz_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 336);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "CANALE";
            // 
            // textBoxcanale
            // 
            this.textBoxcanale.Location = new System.Drawing.Point(157, 332);
            this.textBoxcanale.Name = "textBoxcanale";
            this.textBoxcanale.Size = new System.Drawing.Size(100, 20);
            this.textBoxcanale.TabIndex = 12;
            // 
            // canale
            // 
            this.canale.Location = new System.Drawing.Point(307, 329);
            this.canale.Name = "canale";
            this.canale.Size = new System.Drawing.Size(75, 23);
            this.canale.TabIndex = 13;
            this.canale.Text = "SET";
            this.canale.UseVisualStyleBackColor = true;
            this.canale.Click += new System.EventHandler(this.canale_Click);
            // 
            // textBoxCORR
            // 
            this.textBoxCORR.Location = new System.Drawing.Point(157, 382);
            this.textBoxCORR.Name = "textBoxCORR";
            this.textBoxCORR.Size = new System.Drawing.Size(100, 20);
            this.textBoxCORR.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 382);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "CANALE CORR-";
            // 
            // CORR
            // 
            this.CORR.Location = new System.Drawing.Point(307, 382);
            this.CORR.Name = "CORR";
            this.CORR.Size = new System.Drawing.Size(75, 23);
            this.CORR.TabIndex = 16;
            this.CORR.Text = "GET";
            this.CORR.UseVisualStyleBackColor = true;
            this.CORR.Click += new System.EventHandler(this.button6_Click);
            // 
            // volume
            // 
            this.volume.AutoSize = true;
            this.volume.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume.Location = new System.Drawing.Point(243, 460);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(25, 25);
            this.volume.TabIndex = 17;
            this.volume.Text = "0";
            // 
            // alza
            // 
            this.alza.Location = new System.Drawing.Point(275, 461);
            this.alza.Name = "alza";
            this.alza.Size = new System.Drawing.Size(75, 23);
            this.alza.TabIndex = 18;
            this.alza.Text = "+";
            this.alza.UseVisualStyleBackColor = true;
            this.alza.Click += new System.EventHandler(this.alza_Click);
            // 
            // abbassa
            // 
            this.abbassa.Location = new System.Drawing.Point(157, 460);
            this.abbassa.Name = "abbassa";
            this.abbassa.Size = new System.Drawing.Size(75, 23);
            this.abbassa.TabIndex = 19;
            this.abbassa.Text = "-";
            this.abbassa.UseVisualStyleBackColor = true;
            this.abbassa.Click += new System.EventHandler(this.abbassa_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 520);
            this.Controls.Add(this.abbassa);
            this.Controls.Add(this.alza);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.CORR);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxCORR);
            this.Controls.Add(this.canale);
            this.Controls.Add(this.textBoxcanale);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.funz);
            this.Controls.Add(this.modello);
            this.Controls.Add(this.PROD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxmodello);
            this.Controls.Add(this.textBoxfunz);
            this.Controls.Add(this.textBoxProd);
            this.Controls.Add(this.accensione);
            this.Controls.Add(this.laccensione);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laccensione;
        private System.Windows.Forms.Button accensione;
        private System.Windows.Forms.TextBox textBoxProd;
        private System.Windows.Forms.TextBox textBoxfunz;
        private System.Windows.Forms.TextBox textBoxmodello;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button PROD;
        private System.Windows.Forms.Button modello;
        private System.Windows.Forms.Button funz;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxcanale;
        private System.Windows.Forms.Button canale;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxCORR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button CORR;
        private System.Windows.Forms.Label volume;
        private System.Windows.Forms.Button alza;
        private System.Windows.Forms.Button abbassa;
    }
}

