namespace Evaluacion_Integradora
{
    partial class FormModificar
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
            lbl_lugarDeOrigen = new Label();
            lbl_nombreReal = new Label();
            lbl_personaje = new Label();
            lst_lugarOrigen = new ListBox();
            txt_nombreReal = new TextBox();
            txt_personaje = new TextBox();
            lbl_tipo = new Label();
            grp_planMalvado = new GroupBox();
            rtx_planMalvado = new RichTextBox();
            grp_alianza = new GroupBox();
            radioButton9 = new RadioButton();
            radioButton7 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton1 = new RadioButton();
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
            btn_Modificar = new Button();
            btn_cancelar = new Button();
            cmb_tipoPersonaje = new ComboBox();
            grp_planMalvado.SuspendLayout();
            grp_alianza.SuspendLayout();
            grp_habilidades.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_lugarDeOrigen
            // 
            lbl_lugarDeOrigen.BackColor = Color.LemonChiffon;
            lbl_lugarDeOrigen.Location = new Point(190, 326);
            lbl_lugarDeOrigen.Margin = new Padding(4, 0, 4, 0);
            lbl_lugarDeOrigen.Name = "lbl_lugarDeOrigen";
            lbl_lugarDeOrigen.Size = new Size(252, 27);
            lbl_lugarDeOrigen.TabIndex = 30;
            lbl_lugarDeOrigen.Text = "Seleccione el lugar de origen";
            // 
            // lbl_nombreReal
            // 
            lbl_nombreReal.AutoEllipsis = true;
            lbl_nombreReal.BackColor = Color.LemonChiffon;
            lbl_nombreReal.Location = new Point(68, 147);
            lbl_nombreReal.Margin = new Padding(4, 0, 4, 0);
            lbl_nombreReal.Name = "lbl_nombreReal";
            lbl_nombreReal.Size = new Size(125, 27);
            lbl_nombreReal.TabIndex = 29;
            lbl_nombreReal.Text = "Nombre Real:";
            // 
            // lbl_personaje
            // 
            lbl_personaje.BackColor = Color.LemonChiffon;
            lbl_personaje.Location = new Point(68, 209);
            lbl_personaje.Margin = new Padding(4, 0, 4, 0);
            lbl_personaje.Name = "lbl_personaje";
            lbl_personaje.Size = new Size(125, 27);
            lbl_personaje.TabIndex = 28;
            lbl_personaje.Text = "Personaje:";
            // 
            // lst_lugarOrigen
            // 
            lst_lugarOrigen.BackColor = Color.FromArgb(192, 255, 255);
            lst_lugarOrigen.FormattingEnabled = true;
            lst_lugarOrigen.ItemHeight = 21;
            lst_lugarOrigen.Location = new Point(78, 371);
            lst_lugarOrigen.Margin = new Padding(4, 3, 4, 3);
            lst_lugarOrigen.Name = "lst_lugarOrigen";
            lst_lugarOrigen.Size = new Size(495, 172);
            lst_lugarOrigen.TabIndex = 27;
            // 
            // txt_nombreReal
            // 
            txt_nombreReal.BackColor = Color.FromArgb(192, 255, 255);
            txt_nombreReal.Location = new Point(230, 143);
            txt_nombreReal.Margin = new Padding(4, 3, 4, 3);
            txt_nombreReal.Name = "txt_nombreReal";
            txt_nombreReal.Size = new Size(343, 29);
            txt_nombreReal.TabIndex = 26;
            // 
            // txt_personaje
            // 
            txt_personaje.BackColor = Color.FromArgb(192, 255, 255);
            txt_personaje.Location = new Point(230, 203);
            txt_personaje.Margin = new Padding(4, 3, 4, 3);
            txt_personaje.Name = "txt_personaje";
            txt_personaje.Size = new Size(343, 29);
            txt_personaje.TabIndex = 25;
            // 
            // lbl_tipo
            // 
            lbl_tipo.BackColor = Color.LemonChiffon;
            lbl_tipo.Location = new Point(68, 80);
            lbl_tipo.Margin = new Padding(4, 0, 4, 0);
            lbl_tipo.Name = "lbl_tipo";
            lbl_tipo.Size = new Size(95, 27);
            lbl_tipo.TabIndex = 24;
            lbl_tipo.Text = "Elegir tipo:";
            // 
            // grp_planMalvado
            // 
            grp_planMalvado.BackColor = Color.Transparent;
            grp_planMalvado.Controls.Add(rtx_planMalvado);
            grp_planMalvado.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grp_planMalvado.ForeColor = Color.Black;
            grp_planMalvado.Location = new Point(860, 311);
            grp_planMalvado.Margin = new Padding(4, 3, 4, 3);
            grp_planMalvado.Name = "grp_planMalvado";
            grp_planMalvado.Padding = new Padding(4, 3, 4, 3);
            grp_planMalvado.Size = new Size(350, 232);
            grp_planMalvado.TabIndex = 23;
            grp_planMalvado.TabStop = false;
            grp_planMalvado.Text = "Plan Malvado";
            // 
            // rtx_planMalvado
            // 
            rtx_planMalvado.BackColor = Color.FromArgb(192, 255, 255);
            rtx_planMalvado.Location = new Point(21, 46);
            rtx_planMalvado.Margin = new Padding(4, 3, 4, 3);
            rtx_planMalvado.Name = "rtx_planMalvado";
            rtx_planMalvado.Size = new Size(305, 157);
            rtx_planMalvado.TabIndex = 10;
            rtx_planMalvado.Text = "";
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
            grp_alianza.Location = new Point(608, 350);
            grp_alianza.Margin = new Padding(4, 3, 4, 3);
            grp_alianza.Name = "grp_alianza";
            grp_alianza.Padding = new Padding(4, 3, 4, 3);
            grp_alianza.Size = new Size(246, 190);
            grp_alianza.TabIndex = 18;
            grp_alianza.TabStop = false;
            grp_alianza.Text = "Alianza";
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.BackColor = Color.Transparent;
            radioButton9.Location = new Point(13, 157);
            radioButton9.Margin = new Padding(4, 3, 4, 3);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(86, 24);
            radioButton9.TabIndex = 8;
            radioButton9.TabStop = true;
            radioButton9.Text = "Solitario";
            radioButton9.UseVisualStyleBackColor = false;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.BackColor = Color.Transparent;
            radioButton7.Location = new Point(13, 125);
            radioButton7.Margin = new Padding(4, 3, 4, 3);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(193, 24);
            radioButton7.TabIndex = 6;
            radioButton7.TabStop = true;
            radioButton7.Text = "Guardianes de la galaxia";
            radioButton7.UseVisualStyleBackColor = false;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.Location = new Point(13, 94);
            radioButton5.Margin = new Padding(4, 3, 4, 3);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(100, 24);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.Text = "Los X-Men";
            radioButton5.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.Location = new Point(13, 62);
            radioButton3.Margin = new Padding(4, 3, 4, 3);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(139, 24);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.Text = "Los 4 fantasticos";
            radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.BackColor = Color.Transparent;
            radioButton1.Location = new Point(13, 29);
            radioButton1.Margin = new Padding(4, 3, 4, 3);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(133, 24);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.Text = "Los vengadores";
            radioButton1.UseVisualStyleBackColor = false;
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
            grp_habilidades.Location = new Point(608, 69);
            grp_habilidades.Margin = new Padding(4, 3, 4, 3);
            grp_habilidades.Name = "grp_habilidades";
            grp_habilidades.Padding = new Padding(4, 3, 4, 3);
            grp_habilidades.Size = new Size(602, 232);
            grp_habilidades.TabIndex = 22;
            grp_habilidades.TabStop = false;
            grp_habilidades.Text = "Habilidades";
            // 
            // checkBox10
            // 
            checkBox10.AutoSize = true;
            checkBox10.BackColor = Color.Transparent;
            checkBox10.Location = new Point(309, 188);
            checkBox10.Margin = new Padding(4, 3, 4, 3);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(160, 24);
            checkBox10.TabIndex = 9;
            checkBox10.Text = "Cambio de Tamaño";
            checkBox10.UseVisualStyleBackColor = false;
            // 
            // checkBox9
            // 
            checkBox9.AutoSize = true;
            checkBox9.BackColor = Color.Transparent;
            checkBox9.Location = new Point(44, 188);
            checkBox9.Margin = new Padding(4, 3, 4, 3);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(122, 24);
            checkBox9.TabIndex = 8;
            checkBox9.Text = "Regeneración";
            checkBox9.UseVisualStyleBackColor = false;
            // 
            // checkBox8
            // 
            checkBox8.AutoSize = true;
            checkBox8.BackColor = Color.Transparent;
            checkBox8.Location = new Point(44, 155);
            checkBox8.Margin = new Padding(4, 3, 4, 3);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(111, 24);
            checkBox8.TabIndex = 7;
            checkBox8.Text = "Telequinesis";
            checkBox8.UseVisualStyleBackColor = false;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.BackColor = Color.Transparent;
            checkBox7.Location = new Point(309, 155);
            checkBox7.Margin = new Padding(4, 3, 4, 3);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(103, 24);
            checkBox7.TabIndex = 6;
            checkBox7.Text = "Elasticidad";
            checkBox7.UseVisualStyleBackColor = false;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.BackColor = Color.Transparent;
            checkBox6.Location = new Point(44, 125);
            checkBox6.Margin = new Padding(4, 3, 4, 3);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(92, 24);
            checkBox6.TabIndex = 5;
            checkBox6.Text = "Telepatía";
            checkBox6.UseVisualStyleBackColor = false;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.BackColor = Color.Transparent;
            checkBox5.Location = new Point(309, 125);
            checkBox5.Margin = new Padding(4, 3, 4, 3);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(196, 24);
            checkBox5.TabIndex = 4;
            checkBox5.Text = "Manipulación de Energía";
            checkBox5.UseVisualStyleBackColor = false;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.BackColor = Color.Transparent;
            checkBox4.Location = new Point(44, 94);
            checkBox4.Margin = new Padding(4, 3, 4, 3);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(69, 24);
            checkBox4.TabIndex = 3;
            checkBox4.Text = "Vuelo";
            checkBox4.UseVisualStyleBackColor = false;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.BackColor = Color.Transparent;
            checkBox3.Location = new Point(309, 94);
            checkBox3.Margin = new Padding(4, 3, 4, 3);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(111, 24);
            checkBox3.TabIndex = 2;
            checkBox3.Text = "Invisibilidad";
            checkBox3.UseVisualStyleBackColor = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.BackColor = Color.Transparent;
            checkBox2.Location = new Point(44, 62);
            checkBox2.Margin = new Padding(4, 3, 4, 3);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(170, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "Fuerza Sobrehumana";
            checkBox2.UseVisualStyleBackColor = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.BackColor = Color.Transparent;
            checkBox1.Location = new Point(309, 62);
            checkBox1.Margin = new Padding(4, 3, 4, 3);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(147, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Control del Clima";
            checkBox1.UseVisualStyleBackColor = false;
            // 
            // btn_Modificar
            // 
            btn_Modificar.BackColor = Color.LemonChiffon;
            btn_Modificar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_Modificar.Location = new Point(715, 587);
            btn_Modificar.Margin = new Padding(4, 3, 4, 3);
            btn_Modificar.Name = "btn_Modificar";
            btn_Modificar.Size = new Size(204, 55);
            btn_Modificar.TabIndex = 21;
            btn_Modificar.Text = "Modificar";
            btn_Modificar.UseVisualStyleBackColor = false;
            btn_Modificar.Click += btn_Modificar_Click;
            // 
            // btn_cancelar
            // 
            btn_cancelar.BackColor = Color.LemonChiffon;
            btn_cancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            btn_cancelar.Location = new Point(397, 587);
            btn_cancelar.Margin = new Padding(4, 3, 4, 3);
            btn_cancelar.Name = "btn_cancelar";
            btn_cancelar.Size = new Size(204, 55);
            btn_cancelar.TabIndex = 20;
            btn_cancelar.Text = "Cancelar";
            btn_cancelar.UseVisualStyleBackColor = false;
            btn_cancelar.Click += btn_cancelar_Click;
            // 
            // cmb_tipoPersonaje
            // 
            cmb_tipoPersonaje.BackColor = Color.FromArgb(192, 255, 255);
            cmb_tipoPersonaje.FormattingEnabled = true;
            cmb_tipoPersonaje.Location = new Point(192, 80);
            cmb_tipoPersonaje.Margin = new Padding(4, 3, 4, 3);
            cmb_tipoPersonaje.Name = "cmb_tipoPersonaje";
            cmb_tipoPersonaje.Size = new Size(381, 29);
            cmb_tipoPersonaje.TabIndex = 19;
            cmb_tipoPersonaje.SelectedIndexChanged += cmb_tipoPersonaje_SelectedIndexChanged;
            // 
            // FormModificar
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 700);
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
            Controls.Add(btn_Modificar);
            Controls.Add(btn_cancelar);
            Controls.Add(cmb_tipoPersonaje);
            Margin = new Padding(4);
            Name = "FormModificar";
            Text = "FormModificar";
            Load += FormModificar_Load;
            grp_planMalvado.ResumeLayout(false);
            grp_alianza.ResumeLayout(false);
            grp_alianza.PerformLayout();
            grp_habilidades.ResumeLayout(false);
            grp_habilidades.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_lugarDeOrigen;
        private Label lbl_nombreReal;
        private Label lbl_personaje;
        private ListBox lst_lugarOrigen;
        private TextBox txt_nombreReal;
        private TextBox txt_personaje;
        private Label lbl_tipo;
        private GroupBox grp_planMalvado;
        private RichTextBox rtx_planMalvado;
        private GroupBox grp_alianza;
        private RadioButton radioButton9;
        private RadioButton radioButton7;
        private RadioButton radioButton5;
        private RadioButton radioButton3;
        private RadioButton radioButton1;
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
        private Button btn_Modificar;
        private Button btn_cancelar;
        private ComboBox cmb_tipoPersonaje;
    }
}