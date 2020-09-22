namespace Demo_Plug_Notas
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.textToken = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelToken = new System.Windows.Forms.Label();
            this.send = new System.Windows.Forms.Button();
            this.idNota = new System.Windows.Forms.TextBox();
            this.printNfe = new System.Windows.Forms.Button();
            this.responseJsonNfe = new System.Windows.Forms.RichTextBox();
            this.jsonParce = new System.Windows.Forms.RichTextBox();
            this.parcerJson = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.jsonNotaEnvia = new System.Windows.Forms.Button();
            this.jsonNota = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.emialCert = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.sendCertUpload = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.uploadCert = new System.Windows.Forms.Button();
            this.senhaCert = new System.Windows.Forms.TextBox();
            this.caminhoCert = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusReq = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ambiente";
            // 
            // textToken
            // 
            this.textToken.Location = new System.Drawing.Point(437, 30);
            this.textToken.Name = "textToken";
            this.textToken.Size = new System.Drawing.Size(314, 20);
            this.textToken.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(16, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(237, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "Selecione um Ambiente";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // labelToken
            // 
            this.labelToken.AutoSize = true;
            this.labelToken.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToken.Location = new System.Drawing.Point(434, 9);
            this.labelToken.Name = "labelToken";
            this.labelToken.Size = new System.Drawing.Size(211, 14);
            this.labelToken.TabIndex = 3;
            this.labelToken.Text = "x-api-key (Chave de Autenticação da API);";
            this.labelToken.Click += new System.EventHandler(this.labelToken_Click);
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(806, 32);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(112, 23);
            this.send.TabIndex = 5;
            this.send.Text = "Consultar";
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.button2_Click);
            // 
            // idNota
            // 
            this.idNota.Location = new System.Drawing.Point(24, 49);
            this.idNota.Name = "idNota";
            this.idNota.Size = new System.Drawing.Size(776, 20);
            this.idNota.TabIndex = 6;
            // 
            // printNfe
            // 
            this.printNfe.Location = new System.Drawing.Point(806, 62);
            this.printNfe.Name = "printNfe";
            this.printNfe.Size = new System.Drawing.Size(112, 23);
            this.printNfe.TabIndex = 7;
            this.printNfe.Text = "Imprimir Nota";
            this.printNfe.UseVisualStyleBackColor = true;
            this.printNfe.Click += new System.EventHandler(this.printNfe_Click);
            // 
            // responseJsonNfe
            // 
            this.responseJsonNfe.Location = new System.Drawing.Point(12, 530);
            this.responseJsonNfe.Name = "responseJsonNfe";
            this.responseJsonNfe.Size = new System.Drawing.Size(406, 259);
            this.responseJsonNfe.TabIndex = 8;
            this.responseJsonNfe.Text = "";
            // 
            // jsonParce
            // 
            this.jsonParce.Location = new System.Drawing.Point(542, 530);
            this.jsonParce.Name = "jsonParce";
            this.jsonParce.Size = new System.Drawing.Size(409, 259);
            this.jsonParce.TabIndex = 9;
            this.jsonParce.Text = "";
            // 
            // parcerJson
            // 
            this.parcerJson.Location = new System.Drawing.Point(424, 646);
            this.parcerJson.Name = "parcerJson";
            this.parcerJson.Size = new System.Drawing.Size(112, 23);
            this.parcerJson.TabIndex = 10;
            this.parcerJson.Text = "-- Parsear JSON -->";
            this.parcerJson.UseVisualStyleBackColor = true;
            this.parcerJson.Click += new System.EventHandler(this.parcerJson_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.idNota);
            this.panel1.Controls.Add(this.send);
            this.panel1.Controls.Add(this.printNfe);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(12, 222);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(939, 114);
            this.panel1.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 14);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID da Nota:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.jsonNotaEnvia);
            this.panel2.Controls.Add(this.jsonNota);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(12, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(939, 140);
            this.panel2.TabIndex = 12;
            // 
            // jsonNotaEnvia
            // 
            this.jsonNotaEnvia.Location = new System.Drawing.Point(806, 67);
            this.jsonNotaEnvia.Name = "jsonNotaEnvia";
            this.jsonNotaEnvia.Size = new System.Drawing.Size(112, 23);
            this.jsonNotaEnvia.TabIndex = 16;
            this.jsonNotaEnvia.Text = "Enviar Nota";
            this.jsonNotaEnvia.UseVisualStyleBackColor = true;
            this.jsonNotaEnvia.Click += new System.EventHandler(this.jsonNotaEnvia_Click);
            // 
            // jsonNota
            // 
            this.jsonNota.Location = new System.Drawing.Point(13, 28);
            this.jsonNota.Name = "jsonNota";
            this.jsonNota.Size = new System.Drawing.Size(776, 95);
            this.jsonNota.TabIndex = 19;
            this.jsonNota.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "JSON da Nota:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel3.Controls.Add(this.emialCert);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.sendCertUpload);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.uploadCert);
            this.panel3.Controls.Add(this.senhaCert);
            this.panel3.Controls.Add(this.caminhoCert);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(12, 347);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 161);
            this.panel3.TabIndex = 13;
            // 
            // emialCert
            // 
            this.emialCert.Location = new System.Drawing.Point(13, 124);
            this.emialCert.Name = "emialCert";
            this.emialCert.Size = new System.Drawing.Size(776, 20);
            this.emialCert.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 14);
            this.label8.TabIndex = 21;
            this.label8.Text = "Email";
            // 
            // sendCertUpload
            // 
            this.sendCertUpload.Location = new System.Drawing.Point(806, 72);
            this.sendCertUpload.Name = "sendCertUpload";
            this.sendCertUpload.Size = new System.Drawing.Size(117, 23);
            this.sendCertUpload.TabIndex = 20;
            this.sendCertUpload.Text = "Upload do Certificado";
            this.sendCertUpload.UseVisualStyleBackColor = true;
            this.sendCertUpload.Click += new System.EventHandler(this.sendCertUpload_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 14);
            this.label7.TabIndex = 19;
            this.label7.Text = "Senha do Certificado Digital:";
            // 
            // uploadCert
            // 
            this.uploadCert.Location = new System.Drawing.Point(705, 28);
            this.uploadCert.Name = "uploadCert";
            this.uploadCert.Size = new System.Drawing.Size(84, 23);
            this.uploadCert.TabIndex = 16;
            this.uploadCert.Text = "...";
            this.uploadCert.UseVisualStyleBackColor = true;
            this.uploadCert.Click += new System.EventHandler(this.uploadCert_Click);
            // 
            // senhaCert
            // 
            this.senhaCert.Location = new System.Drawing.Point(13, 74);
            this.senhaCert.Name = "senhaCert";
            this.senhaCert.Size = new System.Drawing.Size(776, 20);
            this.senhaCert.TabIndex = 17;
            // 
            // caminhoCert
            // 
            this.caminhoCert.Location = new System.Drawing.Point(13, 31);
            this.caminhoCert.Name = "caminhoCert";
            this.caminhoCert.Size = new System.Drawing.Size(686, 20);
            this.caminhoCert.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "Caminho do Certificado Digital:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 514);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 14);
            this.label5.TabIndex = 17;
            this.label5.Text = "Resposta das requisições";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(539, 514);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 14);
            this.label6.TabIndex = 18;
            this.label6.Text = "Resposta Formatada";
            // 
            // statusReq
            // 
            this.statusReq.AutoSize = true;
            this.statusReq.Location = new System.Drawing.Point(48, 801);
            this.statusReq.Name = "statusReq";
            this.statusReq.Size = new System.Drawing.Size(0, 13);
            this.statusReq.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 801);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Status:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 823);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.statusReq);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.parcerJson);
            this.Controls.Add(this.jsonParce);
            this.Controls.Add(this.responseJsonNfe);
            this.Controls.Add(this.labelToken);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textToken);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Demonstração NFe - Plug Notas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textToken;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label labelToken;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.TextBox idNota;
        private System.Windows.Forms.Button printNfe;
        private System.Windows.Forms.RichTextBox responseJsonNfe;
        private System.Windows.Forms.RichTextBox jsonParce;
        private System.Windows.Forms.Button parcerJson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button jsonNotaEnvia;
        private System.Windows.Forms.RichTextBox jsonNota;
        private System.Windows.Forms.Button sendCertUpload;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button uploadCert;
        private System.Windows.Forms.TextBox senhaCert;
        private System.Windows.Forms.TextBox caminhoCert;
        private System.Windows.Forms.TextBox emialCert;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label statusReq;
        private System.Windows.Forms.Label label9;
    }
}

