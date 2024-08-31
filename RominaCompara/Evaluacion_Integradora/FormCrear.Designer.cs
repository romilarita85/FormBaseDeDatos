namespace Evaluacion_Integradora
{
    partial class FormCrear
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCrear));
            cmb_tipoPersonaje = new ComboBox();
            btn_cancelar = new Button();
            btn_Crear = new Button();
            grp_habilidades = new GroupBox();
            checkBox10 = new CheckBox();
            checkBox9 = new CheckBox();
            checkBox8 = new CheckBox();
            checkBox7 = new CheckBox();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            grp_alianza = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
            rtx_planMalvado = new RichTextBox();
            grp_planMalvado = new GroupBox();
            lbl_tipo = new Label();
            txt_personaje = new TextBox();
            txt_nombreReal = new TextBox();
            lst_lugarOrigen = new ListBox();
            lbl_personaje = new Label();
            lbl_nombreReal = new Label();
            lbl_lugarDeOrigen = new Label();
            grp_habilidades.SuspendLayout();
            grp_alianza.SuspendLayout();
            grp_planMalvado.SuspendLayout();
            SuspendLayout();
            // 
            // cmb_tipoPersonaje
            // 
            cmb_tipoPersonaje.BackColor = Color.FromArgb(192, 255, 255);
            cmb_tipoPersonaje.FormattingEnabled = true;
            cmb_tipoPersonaje.Location = new Point(116, 30);
            cmb_tipoPersonaje.Margin = new Padding(3, 2, 3, 2);
            cmb_tipoPersonaje.Name = "cmb_tipoPersonaje";
            cmb_tipoPersonaje.Size = new Size(297, 23);
            cmb_tipoPersonaje.TabIndex = 0;
            cmb_tipoPersonaje.SelectedIndexChanged += ComboBox1_SelectedIndexChanged;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.LemonChiffon;
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_cancelar.Location = new Point(276, 392);
            btn_cancelar.Margin = new Padding(3, 2, 3, 2);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(159, 39);
            btn_cancelar.TabIndex = 1;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // btn_Crear
            // 
            btn_Crear.BackColor = Color.LemonChiffon;
            btn_Crear.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_Crear.Location = new Point(523, 392);
            btn_Crear.Margin = new Padding(3, 2, 3, 2);
            btn_Crear.Name = "btn_Crear";
            btn_Crear.Size = new Size(159, 39);
            btn_Crear.TabIndex = 2;
            btn_Crear.Text = "Crear";
            btn_Crear.UseVisualStyleBackColor = false;
            btn_Crear.Click += btn_Crear_Click;
            // 
            // grp_habilidades
            // 
            grp_habilidades.BackColor = Color.FromArgb(192, 255, 255);
            grp_habilidades.Controls.Add(checkBox10);
            grp_habilidades.Controls.Add(checkBox9);
            grp_habilidades.Controls.Add(checkBox8);
            grp_habilidades.Controls.Add(checkBox7);
            grp_habilidades.Controls.Add(checkBox6);
            grp_habilidades.Controls.Add(checkBox5);
            grp_habilidades.Controls.Add(checkBox4);
            grp_habilidades.Controls.Add(checkBox3);
            grp_habilidades.Controls.Add(checkBox2);
            grp_habilidades.Controls.Add(checkBox1);
            grp_habilidades.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_habilidades.ForeColor = Color.Black;
            grp_habilidades.Location = new Point(440, 22);
            grp_habilidades.Margin = new Padding(3, 2, 3, 2);
            grp_habilidades.Name = "grp_habilidades";
            grp_habilidades.Padding = new Padding(3, 2, 3, 2);
            grp_habilidades.Size = new Size(468, 166);
            grp_habilidades.TabIndex = 3;
            grp_habilidades.TabStop = false;
            grp_habilidades.Text = "Habilidades";
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.BackColor = Color.Transparent;
            checkBox10.Location = new Point(240, 135);
            checkBox10.Margin = new Padding(3, 2, 3, 2);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(129, 19);
            checkBox10.TabIndex = 9;
            checkBox10.Text = "Cambio de Tamaño";
            checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.BackColor = Color.Transparent;
            checkBox9.Location = new Point(34, 135);
            checkBox9.Margin = new Padding(3, 2, 3, 2);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(98, 19);
            checkBox9.TabIndex = 8;
            checkBox9.Text = "Regeneración";
            checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.BackColor = Color.Transparent;
            checkBox8.Location = new Point(34, 112);
            checkBox8.Margin = new Padding(3, 2, 3, 2);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(89, 19);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "Telequinesis";
            checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackColor = Color.Transparent;
            checkBox7.Location = new Point(240, 112);
            checkBox7.Margin = new Padding(3, 2, 3, 2);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(82, 19);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Elasticidad";
            checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = Color.Transparent;
            checkBox6.Location = new Point(34, 90);
            checkBox6.Margin = new Padding(3, 2, 3, 2);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(72, 19);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Telepatía";
            checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Transparent;
            checkBox5.Location = new Point(240, 90);
            checkBox5.Margin = new Padding(3, 2, 3, 2);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(157, 19);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Manipulación de Energía";
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Transparent;
            checkBox4.Location = new Point(34, 68);
            checkBox4.Margin = new Padding(3, 2, 3, 2);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(56, 19);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Vuelo";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Location = new Point(240, 68);
            checkBox3.Margin = new Padding(3, 2, 3, 2);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(89, 19);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Invisibilidad";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Location = new Point(34, 45);
            checkBox2.Margin = new Padding(3, 2, 3, 2);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(137, 19);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Fuerza Sobrehumana";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(240, 45);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(119, 19);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Control del Clima";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // grp_alianza
            // 
            grp_alianza.BackColor = Color.FromArgb(192, 255, 255);
            grp_alianza.Controls.Add(radioButton9);
            grp_alianza.Controls.Add(radioButton7);
            grp_alianza.Controls.Add(radioButton5);
            grp_alianza.Controls.Add(radioButton3);
            grp_alianza.Controls.Add(radioButton1);
            grp_alianza.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grp_alianza.ForeColor = Color.Black;
            grp_alianza.Location = new Point(440, 223);
            grp_alianza.Margin = new Padding(3, 2, 3, 2);
            grp_alianza.Name = "grp_alianza";
            grp_alianza.Padding = new Padding(3, 2, 3, 2);
            grp_alianza.Size = new Size(191, 136);
            grp_alianza.TabIndex = 0;
            grp_alianza.TabStop = false;
            grp_alianza.Text = "Alianza";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.BackColor = Color.Transparent;
            radioButton9.Location = new Point(10, 113);
            radioButton9.Margin = new Padding(3, 2, 3, 2);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(68, 19);
            radioButton9.TabIndex = 8;
            radioButton9.TabStop = true;
            radioButton9.Text = "Solitario";
            radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.BackColor = Color.Transparent;
            radioButton7.Location = new Point(10, 90);
            radioButton7.Margin = new Padding(3, 2, 3, 2);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(152, 19);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "Guardianes de la galaxia";
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.Location = new Point(10, 68);
            radioButton5.Margin = new Padding(3, 2, 3, 2);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(82, 19);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "Los X-Men";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Location = new Point(10, 45);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(112, 19);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Los 4 fantasticos";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(10, 22);
            radioButton1.Margin = new Padding(3, 2, 3, 2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(107, 19);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Los vengadores";
            radioButton1.UseVisualStyleBackColor = false;
            // 
            // rtx_planMalvado
            // 
            rtx_planMalvado.BackColor = Color.FromArgb(192, 255, 255);
            rtx_planMalvado.Location = new Point(16, 33);
            rtx_planMalvado.Margin = new Padding(3, 2, 3, 2);
            rtx_planMalvado.Name = "rtx_planMalvado";
            rtx_planMalvado.Size = new Size(238, 113);
            rtx_planMalvado.TabIndex = 10;
            rtx_planMalvado.Text = "";
            // 
            // grp_planMalvado
            // 
            grp_planMalvado.BackColor = Color.Transparent;
            grp_planMalvado.Controls.Add(rtx_planMalvado);
            grp_planMalvado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grp_planMalvado.ForeColor = Color.Black;
            grp_planMalvado.Location = new Point(636, 195);
            grp_planMalvado.Margin = new Padding(3, 2, 3, 2);
            grp_planMalvado.Name = "grp_planMalvado";
            grp_planMalvado.Padding = new Padding(3, 2, 3, 2);
            grp_planMalvado.Size = new Size(272, 166);
            grp_planMalvado.TabIndex = 10;
            grp_planMalvado.TabStop = false;
            grp_planMalvado.Text = "Plan Malvado";
            // 
            // lbl_tipo
            // 
            lbl_tipo.BackColor = Color.LemonChiffon;
            lbl_tipo.Location = new Point(20, 30);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(74, 19);
            lbl_tipo.TabIndex = 11;
            lbl_tipo.Text = "Elegir tipo:";
            // 
            // txt_personaje
            // 
            txt_personaje.BackColor = Color.FromArgb(192, 255, 255);
            txt_personaje.Location = new Point(145, 148);
            txt_personaje.Margin = new Padding(3, 2, 3, 2);
            txt_personaje.Name = "txt_personaje";
            txt_personaje.Size = new Size(268, 23);
            txt_personaje.TabIndex = 12;
            // 
            // txt_nombreReal
            // 
            txt_nombreReal.BackColor = Color.FromArgb(192, 255, 255);
            txt_nombreReal.Location = new Point(145, 104);
            txt_nombreReal.Margin = new Padding(3, 2, 3, 2);
            txt_nombreReal.Name = "txt_nombreReal";
            txt_nombreReal.Size = new Size(268, 23);
            txt_nombreReal.TabIndex = 13;
            // 
            // lst_lugarOrigen
            // 
            lst_lugarOrigen.BackColor = Color.FromArgb(192, 255, 255);
            lst_lugarOrigen.FormattingEnabled = true;
            lst_lugarOrigen.ItemHeight = 15;
            lst_lugarOrigen.Location = new Point(28, 238);
            lst_lugarOrigen.Margin = new Padding(3, 2, 3, 2);
            lst_lugarOrigen.Name = "lst_lugarOrigen";
            lst_lugarOrigen.Size = new Size(386, 124);
            lst_lugarOrigen.TabIndex = 14;
            // 
            // lbl_personaje
            // 
            lbl_personaje.BackColor = Color.LemonChiffon;
            lbl_personaje.Location = new Point(20, 149);
            lbl_personaje.Name = "lbl_personaje";
            lbl_personaje.Size = new Size(97, 19);
            lbl_personaje.TabIndex = 15;
            lbl_personaje.Text = "Personaje:";
            // 
            // lbl_nombreReal
            // 
            lbl_nombreReal.AutoEllipsis = true;
            lbl_nombreReal.BackColor = Color.LemonChiffon;
            lbl_nombreReal.Location = new Point(20, 103);
            lbl_nombreReal.Name = "lbl_nombreReal";
            lbl_nombreReal.Size = new Size(97, 19);
            lbl_nombreReal.TabIndex = 16;
            lbl_nombreReal.Text = "Nombre Real:";
            // 
            // lbl_lugarDeOrigen
            // 
            lbl_lugarDeOrigen.BackColor = Color.LemonChiffon;
            lbl_lugarDeOrigen.Location = new Point(115, 206);
            lbl_lugarDeOrigen.Name = "lbl_lugarDeOrigen";
            lbl_lugarDeOrigen.Size = new Size(196, 19);
            lbl_lugarDeOrigen.TabIndex = 17;
            lbl_lugarDeOrigen.Text = "Seleccione el lugar de origen";
            // 
            // FormCrear
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(928, 440);
            Controls.Add(lbl_lugarDeOrigen);
            Controls.Add(lbl_nombreReal);
            Controls.Add(lbl_personaje);
            Controls.Add(lst_lugarOrigen);
            Controls.Add(txt_nombreReal);
            Controls.Add(txt_personaje);
            Controls.Add(lbl_tipo);
            Controls.Add(grp_planMalvado);
            Controls.Add(grp_alianza);
            Controls.Add(grp_habilidades);
            Controls.Add(btn_Crear);
            Controls.Add(btn_cancelar);
            Controls.Add(cmb_tipoPersonaje);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormCrear";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear";
            Load += FormCrear_Load;
            grp_habilidades.ResumeLayout(false);
            grp_habilidades.PerformLayout();
            grp_alianza.ResumeLayout(false);
            grp_alianza.PerformLayout();
            grp_planMalvado.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb_tipoPersonaje;
        private Button btn_cancelar;
        private Button btn_Crear;
        private GroupBox grp_habilidades;
        private CheckBox checkBox10;
        private CheckBox checkBox9;
        private CheckBox checkBox8;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private GroupBox grp_alianza;
        private RadioButton radioButton9;
        private RadioButton radioButton7;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
        private RichTextBox rtx_planMalvado;
        private GroupBox grp_planMalvado;
        private Label lbl_tipo;
        private TextBox txt_personaje;
        private TextBox txt_nombreReal;
        private ListBox lst_lugarOrigen;
        private Label lbl_personaje;
        private Label lbl_nombreReal;
        private Label lbl_lugarDeOrigen;
    }
}