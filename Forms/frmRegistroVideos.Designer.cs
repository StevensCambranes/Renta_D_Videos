namespace Renta_De_Videos.Forms
{
    partial class frmRegistroVideos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.msNavegacion = new System.Windows.Forms.MenuStrip();
            this.pagoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtNombreVideo = new System.Windows.Forms.TextBox();
            this.lblNombreVideo = new System.Windows.Forms.Label();
            this.lblFormatoVideo = new System.Windows.Forms.Label();
            this.cboFormatoVideo = new System.Windows.Forms.ComboBox();
            this.txtDescripcionVideo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuracionVideo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLanzamientoVideo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtClasificacionEdadVideo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDirector = new System.Windows.Forms.TextBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCodigoVideo = new System.Windows.Forms.Label();
            this.txtCodVideo = new System.Windows.Forms.TextBox();
            this.btnAgregarVideo = new System.Windows.Forms.Button();
            this.cboGeneroVideo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.msNavegacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // msNavegacion
            // 
            this.msNavegacion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pagoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.msNavegacion.Location = new System.Drawing.Point(0, 0);
            this.msNavegacion.Name = "msNavegacion";
            this.msNavegacion.Size = new System.Drawing.Size(800, 24);
            this.msNavegacion.TabIndex = 5;
            // 
            // pagoToolStripMenuItem
            // 
            this.pagoToolStripMenuItem.Name = "pagoToolStripMenuItem";
            this.pagoToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.pagoToolStripMenuItem.Text = "Menu";
            this.pagoToolStripMenuItem.Click += new System.EventHandler(this.pagoToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // txtNombreVideo
            // 
            this.txtNombreVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreVideo.Location = new System.Drawing.Point(232, 149);
            this.txtNombreVideo.Name = "txtNombreVideo";
            this.txtNombreVideo.Size = new System.Drawing.Size(297, 26);
            this.txtNombreVideo.TabIndex = 6;
            // 
            // lblNombreVideo
            // 
            this.lblNombreVideo.AutoSize = true;
            this.lblNombreVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreVideo.Location = new System.Drawing.Point(229, 127);
            this.lblNombreVideo.Name = "lblNombreVideo";
            this.lblNombreVideo.Size = new System.Drawing.Size(135, 20);
            this.lblNombreVideo.TabIndex = 7;
            this.lblNombreVideo.Text = "Nombre del Video";
            // 
            // lblFormatoVideo
            // 
            this.lblFormatoVideo.AutoSize = true;
            this.lblFormatoVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatoVideo.Location = new System.Drawing.Point(229, 176);
            this.lblFormatoVideo.Name = "lblFormatoVideo";
            this.lblFormatoVideo.Size = new System.Drawing.Size(114, 20);
            this.lblFormatoVideo.TabIndex = 8;
            this.lblFormatoVideo.Text = "Formato Video";
            // 
            // cboFormatoVideo
            // 
            this.cboFormatoVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboFormatoVideo.FormattingEnabled = true;
            this.cboFormatoVideo.Items.AddRange(new object[] {
            "DVD",
            "BlueRay",
            "VHS",
            "4K Ultra HD"});
            this.cboFormatoVideo.Location = new System.Drawing.Point(232, 198);
            this.cboFormatoVideo.Name = "cboFormatoVideo";
            this.cboFormatoVideo.Size = new System.Drawing.Size(121, 28);
            this.cboFormatoVideo.TabIndex = 10;
            // 
            // txtDescripcionVideo
            // 
            this.txtDescripcionVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcionVideo.Location = new System.Drawing.Point(366, 303);
            this.txtDescripcionVideo.Name = "txtDescripcionVideo";
            this.txtDescripcionVideo.Size = new System.Drawing.Size(392, 26);
            this.txtDescripcionVideo.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Descripcion de Video";
            // 
            // txtDuracionVideo
            // 
            this.txtDuracionVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDuracionVideo.Location = new System.Drawing.Point(231, 251);
            this.txtDuracionVideo.Name = "txtDuracionVideo";
            this.txtDuracionVideo.Size = new System.Drawing.Size(121, 26);
            this.txtDuracionVideo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Duracion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(228, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Año Lanzamiento";
            // 
            // txtLanzamientoVideo
            // 
            this.txtLanzamientoVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLanzamientoVideo.Location = new System.Drawing.Point(231, 303);
            this.txtLanzamientoVideo.Name = "txtLanzamientoVideo";
            this.txtLanzamientoVideo.Size = new System.Drawing.Size(121, 26);
            this.txtLanzamientoVideo.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(363, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Clasificacion por Edad";
            // 
            // txtClasificacionEdadVideo
            // 
            this.txtClasificacionEdadVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClasificacionEdadVideo.Location = new System.Drawing.Point(366, 251);
            this.txtClasificacionEdadVideo.Name = "txtClasificacionEdadVideo";
            this.txtClasificacionEdadVideo.Size = new System.Drawing.Size(163, 26);
            this.txtClasificacionEdadVideo.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(364, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 20);
            this.label5.TabIndex = 18;
            this.label5.Text = "Director@";
            // 
            // txtDirector
            // 
            this.txtDirector.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDirector.Location = new System.Drawing.Point(367, 199);
            this.txtDirector.Name = "txtDirector";
            this.txtDirector.Size = new System.Drawing.Size(162, 26);
            this.txtDirector.TabIndex = 17;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Ingles (US)",
            "Español (LATAM)",
            "Español (España)",
            "Portugues (Br)"});
            this.checkedListBox1.Location = new System.Drawing.Point(571, 149);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(187, 84);
            this.checkedListBox1.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(568, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Idiomas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(227, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(358, 46);
            this.label7.TabIndex = 23;
            this.label7.Text = "Registro de Videos";
            // 
            // lblCodigoVideo
            // 
            this.lblCodigoVideo.AutoSize = true;
            this.lblCodigoVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigoVideo.Location = new System.Drawing.Point(228, 75);
            this.lblCodigoVideo.Name = "lblCodigoVideo";
            this.lblCodigoVideo.Size = new System.Drawing.Size(129, 20);
            this.lblCodigoVideo.TabIndex = 25;
            this.lblCodigoVideo.Text = "Codigo del Video";
            // 
            // txtCodVideo
            // 
            this.txtCodVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodVideo.Location = new System.Drawing.Point(232, 98);
            this.txtCodVideo.Name = "txtCodVideo";
            this.txtCodVideo.Size = new System.Drawing.Size(526, 26);
            this.txtCodVideo.TabIndex = 24;
            // 
            // btnAgregarVideo
            // 
            this.btnAgregarVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarVideo.Location = new System.Drawing.Point(366, 351);
            this.btnAgregarVideo.Name = "btnAgregarVideo";
            this.btnAgregarVideo.Size = new System.Drawing.Size(128, 43);
            this.btnAgregarVideo.TabIndex = 26;
            this.btnAgregarVideo.Text = "Agregar Video";
            this.btnAgregarVideo.UseVisualStyleBackColor = true;
            this.btnAgregarVideo.Click += new System.EventHandler(this.btnAgregarVideo_Click);
            // 
            // cboGeneroVideo
            // 
            this.cboGeneroVideo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGeneroVideo.FormattingEnabled = true;
            this.cboGeneroVideo.Items.AddRange(new object[] {
            "Accion",
            "Comedia",
            "Drama",
            "Terror"});
            this.cboGeneroVideo.Location = new System.Drawing.Point(79, 199);
            this.cboGeneroVideo.Name = "cboGeneroVideo";
            this.cboGeneroVideo.Size = new System.Drawing.Size(121, 28);
            this.cboGeneroVideo.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(76, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 20);
            this.label8.TabIndex = 28;
            this.label8.Text = "Formato Video";
            // 
            // frmRegistroVideos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cboGeneroVideo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAgregarVideo);
            this.Controls.Add(this.lblCodigoVideo);
            this.Controls.Add(this.txtCodVideo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtClasificacionEdadVideo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDirector);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLanzamientoVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDuracionVideo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDescripcionVideo);
            this.Controls.Add(this.cboFormatoVideo);
            this.Controls.Add(this.lblFormatoVideo);
            this.Controls.Add(this.lblNombreVideo);
            this.Controls.Add(this.txtNombreVideo);
            this.Controls.Add(this.msNavegacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegistroVideos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegistroVideos";
            this.msNavegacion.ResumeLayout(false);
            this.msNavegacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msNavegacion;
        private System.Windows.Forms.ToolStripMenuItem pagoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.TextBox txtNombreVideo;
        private System.Windows.Forms.Label lblNombreVideo;
        private System.Windows.Forms.Label lblFormatoVideo;
        private System.Windows.Forms.ComboBox cboFormatoVideo;
        private System.Windows.Forms.TextBox txtDescripcionVideo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuracionVideo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLanzamientoVideo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClasificacionEdadVideo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDirector;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCodigoVideo;
        private System.Windows.Forms.TextBox txtCodVideo;
        private System.Windows.Forms.Button btnAgregarVideo;
        private System.Windows.Forms.ComboBox cboGeneroVideo;
        private System.Windows.Forms.Label label8;
    }
}