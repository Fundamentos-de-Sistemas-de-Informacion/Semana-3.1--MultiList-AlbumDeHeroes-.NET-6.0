namespace Semana_3._1__MultiList_AlbumDeHeroes_.NET_6._0
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
            label1 = new Label();
            groupBox1 = new GroupBox();
            label7 = new Label();
            btnLimpiarAlbum = new Button();
            btnRegistrarAlbum = new Button();
            tbAlbumNombre = new TextBox();
            tbAlbumCodigo = new TextBox();
            label2 = new Label();
            groupBox2 = new GroupBox();
            label8 = new Label();
            btnRegistrarHeroe = new Button();
            btnLimpiarHeroe = new Button();
            tbHeroePoder = new TextBox();
            tbHeroeCaracteristicas = new TextBox();
            label5 = new Label();
            label6 = new Label();
            tbHeroeNombre = new TextBox();
            tbHeroeCodigo = new TextBox();
            label4 = new Label();
            label3 = new Label();
            listViewAlbum = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            listViewHeroe = new ListView();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            groupBox3 = new GroupBox();
            lblAlbumMasHeroes = new Label();
            label11 = new Label();
            groupBox4 = new GroupBox();
            lblMenorPoder = new Label();
            lblMayorPoder = new Label();
            label9 = new Label();
            label12 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 57);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "CÓDIGO :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnLimpiarAlbum);
            groupBox1.Controls.Add(btnRegistrarAlbum);
            groupBox1.Controls.Add(tbAlbumNombre);
            groupBox1.Controls.Add(tbAlbumCodigo);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(20, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(281, 176);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(113, 23);
            label7.Name = "label7";
            label7.Size = new Size(53, 17);
            label7.TabIndex = 10;
            label7.Text = "ÁLBUM";
            // 
            // btnLimpiarAlbum
            // 
            btnLimpiarAlbum.FlatStyle = FlatStyle.Flat;
            btnLimpiarAlbum.Location = new Point(150, 130);
            btnLimpiarAlbum.Name = "btnLimpiarAlbum";
            btnLimpiarAlbum.Size = new Size(87, 28);
            btnLimpiarAlbum.TabIndex = 9;
            btnLimpiarAlbum.Text = "Limpiar";
            btnLimpiarAlbum.UseVisualStyleBackColor = true;
            btnLimpiarAlbum.Click += btnLimpiarAlbum_Click;
            // 
            // btnRegistrarAlbum
            // 
            btnRegistrarAlbum.FlatStyle = FlatStyle.Flat;
            btnRegistrarAlbum.Location = new Point(42, 130);
            btnRegistrarAlbum.Name = "btnRegistrarAlbum";
            btnRegistrarAlbum.Size = new Size(87, 28);
            btnRegistrarAlbum.TabIndex = 6;
            btnRegistrarAlbum.Text = "Registrar";
            btnRegistrarAlbum.UseVisualStyleBackColor = true;
            btnRegistrarAlbum.Click += btnRegistrarAlbum_Click;
            // 
            // tbAlbumNombre
            // 
            tbAlbumNombre.Location = new Point(88, 87);
            tbAlbumNombre.Name = "tbAlbumNombre";
            tbAlbumNombre.Size = new Size(167, 23);
            tbAlbumNombre.TabIndex = 5;
            // 
            // tbAlbumCodigo
            // 
            tbAlbumCodigo.Location = new Point(89, 53);
            tbAlbumCodigo.Name = "tbAlbumCodigo";
            tbAlbumCodigo.Size = new Size(108, 23);
            tbAlbumCodigo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 90);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "NOMBRE :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(btnRegistrarHeroe);
            groupBox2.Controls.Add(btnLimpiarHeroe);
            groupBox2.Controls.Add(tbHeroePoder);
            groupBox2.Controls.Add(tbHeroeCaracteristicas);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(tbHeroeNombre);
            groupBox2.Controls.Add(tbHeroeCodigo);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.FlatStyle = FlatStyle.System;
            groupBox2.Location = new Point(317, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(506, 176);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(223, 23);
            label8.Name = "label8";
            label8.Size = new Size(50, 17);
            label8.TabIndex = 11;
            label8.Text = "HÉROE";
            // 
            // btnRegistrarHeroe
            // 
            btnRegistrarHeroe.FlatStyle = FlatStyle.Flat;
            btnRegistrarHeroe.Location = new Point(159, 130);
            btnRegistrarHeroe.Name = "btnRegistrarHeroe";
            btnRegistrarHeroe.Size = new Size(87, 28);
            btnRegistrarHeroe.TabIndex = 7;
            btnRegistrarHeroe.Text = "Registrar";
            btnRegistrarHeroe.UseVisualStyleBackColor = true;
            btnRegistrarHeroe.Click += btnRegistrarHeroe_Click;
            // 
            // btnLimpiarHeroe
            // 
            btnLimpiarHeroe.FlatStyle = FlatStyle.Flat;
            btnLimpiarHeroe.Location = new Point(266, 130);
            btnLimpiarHeroe.Name = "btnLimpiarHeroe";
            btnLimpiarHeroe.Size = new Size(87, 28);
            btnLimpiarHeroe.TabIndex = 10;
            btnLimpiarHeroe.Text = "Limpiar";
            btnLimpiarHeroe.UseVisualStyleBackColor = true;
            btnLimpiarHeroe.Click += btnLimpiarHeroe_Click;
            // 
            // tbHeroePoder
            // 
            tbHeroePoder.Location = new Point(378, 87);
            tbHeroePoder.Name = "tbHeroePoder";
            tbHeroePoder.Size = new Size(105, 23);
            tbHeroePoder.TabIndex = 8;
            // 
            // tbHeroeCaracteristicas
            // 
            tbHeroeCaracteristicas.Location = new Point(135, 88);
            tbHeroeCaracteristicas.Name = "tbHeroeCaracteristicas";
            tbHeroeCaracteristicas.Size = new Size(160, 23);
            tbHeroeCaracteristicas.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(322, 91);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 5;
            label5.Text = "PODER :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 91);
            label6.Name = "label6";
            label6.Size = new Size(111, 15);
            label6.TabIndex = 6;
            label6.Text = "CARACTERÍSTICAS :";
            // 
            // tbHeroeNombre
            // 
            tbHeroeNombre.Location = new Point(282, 53);
            tbHeroeNombre.Name = "tbHeroeNombre";
            tbHeroeNombre.Size = new Size(201, 23);
            tbHeroeNombre.TabIndex = 4;
            // 
            // tbHeroeCodigo
            // 
            tbHeroeCodigo.Location = new Point(82, 53);
            tbHeroeCodigo.Name = "tbHeroeCodigo";
            tbHeroeCodigo.Size = new Size(108, 23);
            tbHeroeCodigo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 57);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 2;
            label4.Text = "NOMBRE :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 57);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "CÓDIGO :";
            // 
            // listViewAlbum
            // 
            listViewAlbum.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            listViewAlbum.Location = new Point(20, 198);
            listViewAlbum.Name = "listViewAlbum";
            listViewAlbum.Size = new Size(281, 215);
            listViewAlbum.TabIndex = 3;
            listViewAlbum.UseCompatibleStateImageBehavior = false;
            listViewAlbum.View = View.Details;
            listViewAlbum.SelectedIndexChanged += listViewAlbumes_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Código";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Nombre";
            columnHeader2.Width = 150;
            // 
            // listViewHeroe
            // 
            listViewHeroe.Columns.AddRange(new ColumnHeader[] { columnHeader3, columnHeader4, columnHeader5, columnHeader6 });
            listViewHeroe.Location = new Point(317, 198);
            listViewHeroe.Name = "listViewHeroe";
            listViewHeroe.Size = new Size(506, 215);
            listViewHeroe.TabIndex = 4;
            listViewHeroe.UseCompatibleStateImageBehavior = false;
            listViewHeroe.View = View.Details;
            listViewHeroe.SelectedIndexChanged += listViewHeroe_SelectedIndexChanged;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Código";
            columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Nombre";
            columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Características";
            columnHeader5.Width = 230;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Poder";
            columnHeader6.Width = 70;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblAlbumMasHeroes);
            groupBox3.Controls.Add(label11);
            groupBox3.FlatStyle = FlatStyle.System;
            groupBox3.Location = new Point(20, 417);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(281, 82);
            groupBox3.TabIndex = 11;
            groupBox3.TabStop = false;
            // 
            // lblAlbumMasHeroes
            // 
            lblAlbumMasHeroes.AutoSize = true;
            lblAlbumMasHeroes.Location = new Point(31, 50);
            lblAlbumMasHeroes.Name = "lblAlbumMasHeroes";
            lblAlbumMasHeroes.Size = new Size(12, 15);
            lblAlbumMasHeroes.TabIndex = 1;
            lblAlbumMasHeroes.Text = "-";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 23);
            label11.Name = "label11";
            label11.Size = new Size(135, 15);
            label11.TabIndex = 0;
            label11.Text = "Álbum con más héroes :";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(lblMenorPoder);
            groupBox4.Controls.Add(lblMayorPoder);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label12);
            groupBox4.FlatStyle = FlatStyle.System;
            groupBox4.Location = new Point(317, 417);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(506, 82);
            groupBox4.TabIndex = 12;
            groupBox4.TabStop = false;
            // 
            // lblMenorPoder
            // 
            lblMenorPoder.AutoSize = true;
            lblMenorPoder.Location = new Point(187, 50);
            lblMenorPoder.Name = "lblMenorPoder";
            lblMenorPoder.Size = new Size(12, 15);
            lblMenorPoder.TabIndex = 3;
            lblMenorPoder.Text = "-";
            // 
            // lblMayorPoder
            // 
            lblMayorPoder.AutoSize = true;
            lblMayorPoder.Location = new Point(187, 23);
            lblMayorPoder.Name = "lblMayorPoder";
            lblMayorPoder.Size = new Size(12, 15);
            lblMayorPoder.TabIndex = 2;
            lblMayorPoder.Text = "-";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(33, 50);
            label9.Name = "label9";
            label9.Size = new Size(140, 15);
            label9.TabIndex = 1;
            label9.Text = "Héroe con menor poder :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(33, 23);
            label12.Name = "label12";
            label12.Size = new Size(139, 15);
            label12.TabIndex = 0;
            label12.Text = "Héroe con mayor poder :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(844, 511);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(listViewHeroe);
            Controls.Add(listViewAlbum);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private TextBox tbAlbumCodigo;
        private TextBox tbHeroeCodigo;
        private Label label4;
        private TextBox tbAlbumNombre;
        private TextBox tbHeroeNombre;
        private TextBox tbHeroePoder;
        private TextBox tbHeroeCaracteristicas;
        private Label label5;
        private Label label6;
        private Button btnRegistrarAlbum;
        private Button btnRegistrarHeroe;
        private Button btnLimpiarAlbum;
        private Button btnLimpiarHeroe;
        private Label label7;
        private ListView listViewAlbum;
        private Label label8;
        private ListView listViewHeroe;
        private GroupBox groupBox3;
        private Label lblAlbumMasHeroes;
        private Label label11;
        private GroupBox groupBox4;
        private Label lblMenorPoder;
        private Label lblMayorPoder;
        private Label label9;
        private Label label12;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
    }
}