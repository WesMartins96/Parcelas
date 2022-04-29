namespace WFList
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
            this.lstNumero1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCriarList1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCriarList2 = new System.Windows.Forms.Button();
            this.lstNumero2 = new System.Windows.Forms.ListBox();
            this.btnTransferir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAaZ = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnZaA = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNumero1
            // 
            this.lstNumero1.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumero1.FormattingEnabled = true;
            this.lstNumero1.ItemHeight = 17;
            this.lstNumero1.Location = new System.Drawing.Point(38, 63);
            this.lstNumero1.Name = "lstNumero1";
            this.lstNumero1.Size = new System.Drawing.Size(212, 276);
            this.lstNumero1.TabIndex = 0;
            this.lstNumero1.SelectedIndexChanged += new System.EventHandler(this.lstNumero1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Criar List 1";
            // 
            // btnCriarList1
            // 
            this.btnCriarList1.Location = new System.Drawing.Point(107, 34);
            this.btnCriarList1.Name = "btnCriarList1";
            this.btnCriarList1.Size = new System.Drawing.Size(84, 23);
            this.btnCriarList1.TabIndex = 2;
            this.btnCriarList1.Text = "Criar List 1";
            this.btnCriarList1.UseVisualStyleBackColor = true;
            this.btnCriarList1.Click += new System.EventHandler(this.btnCriarList1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Criar List 2";
            // 
            // btnCriarList2
            // 
            this.btnCriarList2.Location = new System.Drawing.Point(301, 34);
            this.btnCriarList2.Name = "btnCriarList2";
            this.btnCriarList2.Size = new System.Drawing.Size(119, 23);
            this.btnCriarList2.TabIndex = 2;
            this.btnCriarList2.Text = "Criar List 2";
            this.btnCriarList2.UseVisualStyleBackColor = true;
            this.btnCriarList2.Click += new System.EventHandler(this.btnCriarList2_Click);
            // 
            // lstNumero2
            // 
            this.lstNumero2.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstNumero2.FormattingEnabled = true;
            this.lstNumero2.ItemHeight = 17;
            this.lstNumero2.Location = new System.Drawing.Point(256, 63);
            this.lstNumero2.Name = "lstNumero2";
            this.lstNumero2.Size = new System.Drawing.Size(212, 276);
            this.lstNumero2.TabIndex = 0;
            this.lstNumero2.SelectedIndexChanged += new System.EventHandler(this.lstNumero2_SelectedIndexChanged);
            // 
            // btnTransferir
            // 
            this.btnTransferir.Location = new System.Drawing.Point(498, 81);
            this.btnTransferir.Name = "btnTransferir";
            this.btnTransferir.Size = new System.Drawing.Size(192, 23);
            this.btnTransferir.TabIndex = 3;
            this.btnTransferir.Text = "Mover";
            this.btnTransferir.UseVisualStyleBackColor = true;
            this.btnTransferir.Click += new System.EventHandler(this.btnTransferir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(494, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Adicionar da List1 a List 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Remover apenas um";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(498, 168);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Remover";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(537, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Remover todos";
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(498, 251);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(192, 23);
            this.btnRemoveAll.TabIndex = 3;
            this.btnRemoveAll.Text = "RemoverAll";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Organizar de A a Z";
            // 
            // btnAaZ
            // 
            this.btnAaZ.Location = new System.Drawing.Point(12, 381);
            this.btnAaZ.Name = "btnAaZ";
            this.btnAaZ.Size = new System.Drawing.Size(192, 23);
            this.btnAaZ.TabIndex = 3;
            this.btnAaZ.Text = "Organizar";
            this.btnAaZ.UseVisualStyleBackColor = true;
            this.btnAaZ.Click += new System.EventHandler(this.btnAaZ_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(276, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Organizar de Z a A";
            // 
            // btnZaA
            // 
            this.btnZaA.Location = new System.Drawing.Point(256, 381);
            this.btnZaA.Name = "btnZaA";
            this.btnZaA.Size = new System.Drawing.Size(192, 23);
            this.btnZaA.TabIndex = 3;
            this.btnZaA.Text = "Organizar";
            this.btnZaA.UseVisualStyleBackColor = true;
            this.btnZaA.Click += new System.EventHandler(this.btnZaA_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(498, 327);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 121);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 460);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnZaA);
            this.Controls.Add(this.btnAaZ);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnTransferir);
            this.Controls.Add(this.btnCriarList2);
            this.Controls.Add(this.btnCriarList1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstNumero2);
            this.Controls.Add(this.lstNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstNumero1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCriarList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCriarList2;
        private System.Windows.Forms.ListBox lstNumero2;
        private System.Windows.Forms.Button btnTransferir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnRemoveAll;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAaZ;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnZaA;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

