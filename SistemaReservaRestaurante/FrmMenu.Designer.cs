namespace SistemaReservaRestaurante
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnservir = new System.Windows.Forms.Button();
            this.btnreservar = new System.Windows.Forms.Button();
            this.btnusuario = new System.Windows.Forms.Button();
            this.btncliente = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.btnservir);
            this.panel1.Controls.Add(this.btnreservar);
            this.panel1.Controls.Add(this.btnusuario);
            this.panel1.Controls.Add(this.btncliente);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 510);
            this.panel1.TabIndex = 9;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Black;
            this.button6.Location = new System.Drawing.Point(0, 464);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(254, 46);
            this.button6.TabIndex = 6;
            this.button6.Text = "Cerrar";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(0, 361);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(254, 46);
            this.button5.TabIndex = 5;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // btnservir
            // 
            this.btnservir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnservir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnservir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnservir.ForeColor = System.Drawing.Color.Black;
            this.btnservir.Location = new System.Drawing.Point(0, 315);
            this.btnservir.Name = "btnservir";
            this.btnservir.Size = new System.Drawing.Size(254, 46);
            this.btnservir.TabIndex = 4;
            this.btnservir.Text = "Sevir Local";
            this.btnservir.UseVisualStyleBackColor = true;
            this.btnservir.Click += new System.EventHandler(this.btnservir_Click);
            // 
            // btnreservar
            // 
            this.btnreservar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnreservar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnreservar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreservar.ForeColor = System.Drawing.Color.Black;
            this.btnreservar.Location = new System.Drawing.Point(0, 269);
            this.btnreservar.Name = "btnreservar";
            this.btnreservar.Size = new System.Drawing.Size(254, 46);
            this.btnreservar.TabIndex = 3;
            this.btnreservar.Text = "Reservar";
            this.btnreservar.UseVisualStyleBackColor = true;
            this.btnreservar.Click += new System.EventHandler(this.btnreservar_Click);
            // 
            // btnusuario
            // 
            this.btnusuario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnusuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnusuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnusuario.ForeColor = System.Drawing.Color.Black;
            this.btnusuario.Image = global::SistemaReservaRestaurante.Properties.Resources.add_user_male_30Cpx;
            this.btnusuario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnusuario.Location = new System.Drawing.Point(0, 223);
            this.btnusuario.Name = "btnusuario";
            this.btnusuario.Size = new System.Drawing.Size(254, 46);
            this.btnusuario.TabIndex = 2;
            this.btnusuario.Text = "Usuario";
            this.btnusuario.UseVisualStyleBackColor = true;
            this.btnusuario.Click += new System.EventHandler(this.btnusuario_Click);
            // 
            // btncliente
            // 
            this.btncliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncliente.ForeColor = System.Drawing.Color.Black;
            this.btncliente.Image = global::SistemaReservaRestaurante.Properties.Resources.group_35px___copia__2_;
            this.btncliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncliente.Location = new System.Drawing.Point(0, 177);
            this.btncliente.Margin = new System.Windows.Forms.Padding(3, 5, 5, 3);
            this.btncliente.Name = "btncliente";
            this.btncliente.Size = new System.Drawing.Size(254, 46);
            this.btncliente.TabIndex = 1;
            this.btncliente.Text = "Cliente";
            this.btncliente.UseVisualStyleBackColor = true;
            this.btncliente.Click += new System.EventHandler(this.btncliente_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::SistemaReservaRestaurante.Properties.Resources.lOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(254, 177);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(744, -5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(56, 54);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 510);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnservir;
        private System.Windows.Forms.Button btnreservar;
        private System.Windows.Forms.Button btnusuario;
        private System.Windows.Forms.Button btncliente;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnClose;
    }
}

