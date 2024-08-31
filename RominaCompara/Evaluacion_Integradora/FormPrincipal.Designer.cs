namespace Evaluacion_Integradora
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            dgv_personajes = new DataGridView();
            btn_agregar = new Button();
            btn_modificar = new Button();
            btn_eliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_personajes).BeginInit();
            SuspendLayout();
            // 
            // dgv_personajes
            // 
            dgv_personajes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_personajes.BackgroundColor = SystemColors.ActiveCaption;
            dgv_personajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_personajes.Location = new Point(26, 9);
            dgv_personajes.Margin = new Padding(3, 2, 3, 2);
            dgv_personajes.Name = "dgv_personajes";
            dgv_personajes.RowHeadersWidth = 51;
            dgv_personajes.Size = new Size(1202, 356);
            dgv_personajes.TabIndex = 0;
            // 
            // btn_agregar
            // 
            btn_agregar.BackColor = Color.FromArgb(255, 128, 0);
            btn_agregar.BackgroundImage = (Image)resources.GetObject("btn_agregar.BackgroundImage");
            btn_agregar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_agregar.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_agregar.ForeColor = Color.FromArgb(255, 255, 128);
            btn_agregar.Location = new Point(122, 398);
            btn_agregar.Margin = new Padding(3, 2, 3, 2);
            btn_agregar.Name = "btn_agregar";
            btn_agregar.Size = new Size(306, 75);
            btn_agregar.TabIndex = 1;
            btn_agregar.Text = "Crear Nuevo...";
            btn_agregar.UseVisualStyleBackColor = false;
            btn_agregar.Click += btn_agregar_Click;
            // 
            // btn_modificar
            // 
            btn_modificar.BackColor = Color.White;
            btn_modificar.BackgroundImage = (Image)resources.GetObject("btn_modificar.BackgroundImage");
            btn_modificar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_modificar.Font = new Font("Microsoft Sans Serif", 25.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_modificar.ForeColor = Color.Snow;
            btn_modificar.Location = new Point(484, 398);
            btn_modificar.Margin = new Padding(3, 2, 3, 2);
            btn_modificar.Name = "btn_modificar";
            btn_modificar.Size = new Size(306, 75);
            btn_modificar.TabIndex = 2;
            btn_modificar.Text = "Modificar";
            btn_modificar.UseVisualStyleBackColor = false;
            btn_modificar.Click += btn_modificar_Click;
            // 
            // btn_eliminar
            // 
            btn_eliminar.BackColor = Color.FromArgb(255, 255, 192);
            btn_eliminar.BackgroundImage = (Image)resources.GetObject("btn_eliminar.BackgroundImage");
            btn_eliminar.BackgroundImageLayout = ImageLayout.Stretch;
            btn_eliminar.Font = new Font("Microsoft Sans Serif", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_eliminar.ForeColor = SystemColors.InactiveCaptionText;
            btn_eliminar.Location = new Point(845, 398);
            btn_eliminar.Margin = new Padding(3, 2, 3, 2);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(306, 75);
            btn_eliminar.TabIndex = 3;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = false;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1240, 497);
            Controls.Add(btn_eliminar);
            Controls.Add(btn_modificar);
            Controls.Add(btn_agregar);
            Controls.Add(dgv_personajes);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mis Personajes";
            Load += FormPrincipal_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_personajes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_personajes;
        private Button btn_agregar;
        private Button btn_modificar;
        private Button btn_eliminar;
    }
}
