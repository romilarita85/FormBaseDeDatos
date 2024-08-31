using LibreriaDePersonajes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Evaluacion_Integradora
{
    public partial class FormCrear : Form
    {
        Personaje personaje;
       

        public Personaje Personaje { get => personaje; }

        public FormCrear()
        {
            InitializeComponent();
        }
        private void FormCrear_Load(object sender, EventArgs e)
        {
            #region NO MODIFICAR
            cmb_tipoPersonaje.DataSource = new List<string>() { "Heroe", "Villano" };
            this.lst_lugarOrigen.DataSource = new List<string>() { "Asgard", "Midgard", "Xandar", "Hala", "Skrullos", "Titan", "Tierra-616" };
            #endregion
        }
        #region NO MODIFICAR
        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipoPersonaje.SelectedItem!.ToString() == "Heroe")
            {
                grp_alianza.Enabled = true;//enabled= habilitado
                grp_planMalvado.Enabled = false;
            }
            else if (cmb_tipoPersonaje.SelectedItem.ToString() == "Villano")
            {
                grp_alianza.Enabled = false;
                grp_planMalvado.Enabled = true;
            }
        }
        #endregion


        private void btn_Crear_Click(object sender, EventArgs e)
        {
            string nombreReal = txt_nombreReal.Text;
            string nombrePersonaje = cmb_tipoPersonaje.Text;
            string lugarDeOrigen = lst_lugarOrigen.SelectedItem!.ToString()!;
            //variables de control
            bool control = false;
            bool listaConValores = false;
           
            if (cmb_tipoPersonaje.SelectedItem!.ToString() == "Heroe")
            {
                string alianza = string.Empty;

                foreach (RadioButton rd in grp_alianza.Controls)
                {
                    if (rd.Checked)
                    {
                        alianza = rd.Text;
                        
                        break;
                    }
                }

                this.personaje = new Heroe(nombreReal, nombrePersonaje, lugarDeOrigen, alianza);
                foreach (CheckBox chk in grp_habilidades.Controls)
                {
                    if (chk.Checked)
                    {
                        this.personaje.SetHabilidad(chk.Text);
                        listaConValores = true;
                    }
                }
                //Ver si las variables estan vacias o son nulas
                if (!string.IsNullOrEmpty(nombreReal) && !string.IsNullOrEmpty(nombrePersonaje) && 
                  !string.IsNullOrEmpty(lugarDeOrigen) && !string.IsNullOrEmpty(alianza)&& listaConValores)
                {
                    control = true; 
                }

            }
            else if (cmb_tipoPersonaje.SelectedItem.ToString() == "Villano")
            {
                string planMalvado = rtx_planMalvado.Text;
                this.personaje = new Villano(nombreReal, nombrePersonaje, lugarDeOrigen, planMalvado);

                foreach (CheckBox chk in grp_habilidades.Controls)
                {
                    if (chk.Checked) 
                    {
                        this.personaje.SetHabilidad(chk.Text);  
                        listaConValores = true; 
                    }
                }
                //Ver si las variables estan vacias o son nulas
                if (!string.IsNullOrEmpty(nombreReal) && !string.IsNullOrEmpty(nombrePersonaje) &&
                 !string.IsNullOrEmpty(lugarDeOrigen) && !string.IsNullOrEmpty(planMalvado) && listaConValores)
                {
                    control = true;
                }
            }

            if (control)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
               MessageBox.Show("Faltan seleccionar valores");
            }

        }
        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}