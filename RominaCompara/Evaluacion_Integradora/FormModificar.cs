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
//Formularios: crear el formulario modificar, este recibirá un personaje en su constructor y se cargará
//todos los componentes con los datos del mismo.
namespace Evaluacion_Integradora
{
    public partial class FormModificar : Form
    {
        private Personaje personaje;

        public Personaje Personaje
        {
            get
            {
                return personaje;
            }
        }
        public FormModificar(Personaje personajeObtenido)
        {
            InitializeComponent();
            this.personaje = personajeObtenido;
        }
     
        
        private void FormModificar_Load(object sender, EventArgs e)
        {
            cmb_tipoPersonaje.DataSource = new List<string>() { "Heroe", "Villano" };
            this.lst_lugarOrigen.DataSource = new List<string>() { "Asgard", "Midgard", "Xandar", "Hala", "Skrullos", "Titan", "Tierra-616" };
           
            txt_nombreReal.Text = this.personaje.NombreReal;
            cmb_tipoPersonaje.Text = this.personaje.NombreReal;
            lst_lugarOrigen.Text = this.personaje.LugarDeOrigen;
            //num_personaje.Value = this.personaje.Id;

            if (cmb_tipoPersonaje.SelectedItem!.ToString() == "Heroe")
            {
                string alianza = string.Empty;

                foreach (RadioButton rd in grp_alianza.Controls)
                {
                
                    if (rd.Checked)
                    {
                        rd.Checked = true;// Marca el RadioButton
                        break;
                    }
                }

                foreach (CheckBox chk in grp_habilidades.Controls)
                {
                    if (chk.Checked)
                    {
                        this.personaje.SetHabilidad(chk.Text);
                      
                    }
                }

            }
            else if (cmb_tipoPersonaje.SelectedItem.ToString() == "Villano")
            {
                string planMalvado = rtx_planMalvado.Text;
               

                foreach (CheckBox chk in grp_habilidades.Controls)
                {
                    if (chk.Checked)
                    {
                        this.personaje.SetHabilidad(chk.Text);
                       
                    }
                }
            }
        }

        private void cmb_tipoPersonaje_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_tipoPersonaje.SelectedItem!.ToString() == "Heroe")
            {
                grp_alianza.Enabled = true;
                grp_planMalvado.Enabled = false;
            }
            else if (cmb_tipoPersonaje.SelectedItem.ToString() == "Villano")
            {
                grp_alianza.Enabled = false;
                grp_planMalvado.Enabled = true;
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            int id = personaje.GetId();
            string nombreReal = txt_nombreReal.Text;
            string tipoPersonaje = cmb_tipoPersonaje.Text;
            string nombrePersonaje = txt_personaje.Text;
            string lugarDeOrigen = lst_lugarOrigen.SelectedItem!.ToString()!;
           
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

                this.personaje = new Heroe(nombreReal,tipoPersonaje, lugarDeOrigen, alianza);
               
                foreach (CheckBox chk in grp_habilidades.Controls)
                {
                    if (chk.Checked)
                    {
                        this.personaje.SetHabilidad(chk.Text);
                        listaConValores = true;
                    }
                }
                if (!string.IsNullOrEmpty(nombreReal) && !string.IsNullOrEmpty(nombrePersonaje) &&
                 !string.IsNullOrEmpty(lugarDeOrigen) && !string.IsNullOrEmpty(alianza) && listaConValores)
                {
                    control = true;
                }
            }
            else
            {
                if (cmb_tipoPersonaje.SelectedItem.ToString() == "Villano")
                {
                    string planMalvado = rtx_planMalvado.Text;

                    foreach (CheckBox chk in grp_habilidades.Controls)
                    {
                        if (chk.Checked)
                        {
                            this.personaje.SetHabilidad(chk.Text);
                            listaConValores = true;
                        }
                    }
                    personaje = new Villano(nombreReal, tipoPersonaje, lugarDeOrigen, planMalvado);

                    if (!string.IsNullOrEmpty(nombreReal) && !string.IsNullOrEmpty(nombrePersonaje) &&
                     !string.IsNullOrEmpty(lugarDeOrigen) && !string.IsNullOrEmpty(planMalvado) && listaConValores)
                    {
                        control = true;
                    }      
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
