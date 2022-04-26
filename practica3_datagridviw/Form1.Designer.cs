namespace practica3_datagridviw
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblnombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtcal = new System.Windows.Forms.TextBox();
            this.dgvcalificacion = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btncal = new System.Windows.Forms.Button();
            this.btnline = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblpromedio = new System.Windows.Forms.Label();
            this.btnlineaa = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificacion)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblnombre.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnombre.ForeColor = System.Drawing.Color.Orange;
            this.lblnombre.Location = new System.Drawing.Point(106, 55);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(70, 16);
            this.lblnombre.TabIndex = 0;
            this.lblnombre.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(106, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calificacion:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(213, 55);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 3;
            this.txtnombre.TextChanged += new System.EventHandler(this.txtnombre_TextChanged);
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // txtcal
            // 
            this.txtcal.Location = new System.Drawing.Point(213, 104);
            this.txtcal.Name = "txtcal";
            this.txtcal.Size = new System.Drawing.Size(100, 20);
            this.txtcal.TabIndex = 4;
            this.txtcal.TextChanged += new System.EventHandler(this.txtcal_TextChanged);
            this.txtcal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcal_KeyPress);
            // 
            // dgvcalificacion
            // 
            this.dgvcalificacion.BackgroundColor = System.Drawing.Color.Black;
            this.dgvcalificacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcalificacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Calificacion});
            this.dgvcalificacion.GridColor = System.Drawing.SystemColors.Control;
            this.dgvcalificacion.Location = new System.Drawing.Point(119, 134);
            this.dgvcalificacion.Name = "dgvcalificacion";
            this.dgvcalificacion.Size = new System.Drawing.Size(240, 150);
            this.dgvcalificacion.TabIndex = 5;
            // 
            // Nombre
            // 
            this.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.Nombre.DefaultCellStyle = dataGridViewCellStyle7;
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Calificacion
            // 
            this.Calificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            this.Calificacion.DefaultCellStyle = dataGridViewCellStyle8;
            this.Calificacion.HeaderText = "Calificacion";
            this.Calificacion.Name = "Calificacion";
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Black;
            this.btnlimpiar.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.ForeColor = System.Drawing.Color.Lime;
            this.btnlimpiar.Location = new System.Drawing.Point(393, 152);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpiar.TabIndex = 6;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // btncal
            // 
            this.btncal.BackColor = System.Drawing.Color.Black;
            this.btncal.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncal.ForeColor = System.Drawing.Color.Lime;
            this.btncal.Location = new System.Drawing.Point(393, 194);
            this.btncal.Name = "btncal";
            this.btncal.Size = new System.Drawing.Size(75, 23);
            this.btncal.TabIndex = 7;
            this.btncal.Text = "Calcular";
            this.btncal.UseVisualStyleBackColor = false;
            this.btncal.Click += new System.EventHandler(this.btncal_Click);
            // 
            // btnline
            // 
            this.btnline.BackColor = System.Drawing.Color.Black;
            this.btnline.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnline.ForeColor = System.Drawing.Color.Lime;
            this.btnline.Location = new System.Drawing.Point(133, 307);
            this.btnline.Name = "btnline";
            this.btnline.Size = new System.Drawing.Size(55, 23);
            this.btnline.TabIndex = 8;
            this.btnline.Text = "-----";
            this.btnline.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblpromedio);
            this.groupBox1.Controls.Add(this.btnlineaa);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnline);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(-98, -46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(628, 460);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblpromedio
            // 
            this.lblpromedio.AutoSize = true;
            this.lblpromedio.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblpromedio.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpromedio.ForeColor = System.Drawing.Color.Gold;
            this.lblpromedio.Location = new System.Drawing.Point(233, 347);
            this.lblpromedio.Name = "lblpromedio";
            this.lblpromedio.Size = new System.Drawing.Size(82, 16);
            this.lblpromedio.TabIndex = 10;
            this.lblpromedio.Text = "Promedio:";
            this.lblpromedio.Click += new System.EventHandler(this.lblpromedio_Click);
            // 
            // btnlineaa
            // 
            this.btnlineaa.BackColor = System.Drawing.Color.Black;
            this.btnlineaa.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlineaa.ForeColor = System.Drawing.Color.Lime;
            this.btnlineaa.Location = new System.Drawing.Point(119, 292);
            this.btnlineaa.Name = "btnlineaa";
            this.btnlineaa.Size = new System.Drawing.Size(75, 23);
            this.btnlineaa.TabIndex = 10;
            this.btnlineaa.Text = "------";
            this.btnlineaa.UseVisualStyleBackColor = false;
            this.btnlineaa.Click += new System.EventHandler(this.btnlineaa_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(97, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(480, 343);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("MS PGothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Lime;
            this.button1.Location = new System.Drawing.Point(491, 350);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(491, 339);
            this.Controls.Add(this.btncal);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.dgvcalificacion);
            this.Controls.Add(this.txtcal);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcalificacion)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtcal;
        private System.Windows.Forms.DataGridView dgvcalificacion;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btncal;
        private System.Windows.Forms.Button btnline;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificacion;
        private System.Windows.Forms.Button btnlineaa;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblpromedio;
        private System.Windows.Forms.Button button1;
    }
}

