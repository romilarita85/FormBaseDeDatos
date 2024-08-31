using LibreriaDePersonajes;

namespace Evaluacion_Integradora
{
    public partial class FormPrincipal : Form
    {
        //private List<Personaje> personajes;
    
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            dgv_personajes.RowHeadersVisible = false;//para ocultar la linea q aparece en el data
            ActualizarLista();
         
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            FormCrear formCrear = new FormCrear();
            formCrear.ShowDialog();
            if (formCrear.DialogResult == DialogResult.OK)
            {
                Personaje_Ado.Escribir(formCrear.Personaje);
                ActualizarLista();
                //personajes.Add(formCrear.Personaje);
                //CargarDgv();
            }
        }
       
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            ////Obtener el objeto Computadora seleccionado en el DataGridView.
            //Personaje personajeEditar = (Personaje)dgv_personajes.CurrentRow.DataBoundItem;

            //FormModificar modificar = new FormModificar(personajeEditar);//paso personaje Editar al constructor
            //modificar.ShowDialog();
            ////Abrir un formulario para modificar la computadora seleccionada(FormModificar).
            //if (modificar.DialogResult == DialogResult.OK)
            //{//Una vez modificada, buscar la computadora en la lista original y actualizar.
            //    //Buscar numero de personaje-
            //    int index = -1;//si es distinto de -1 significa q lo puedo encontrar.
            //    foreach (Personaje item in personajes)
            //    {
            //        if (item.GetId() == modificar.Personaje.GetId())
            //        {
            //            index = personajes.IndexOf(item);
            //        }
            //        if (index != -1) //para decirle a mi personaje q guarde ese indice del personaje
            //        {//q modifique
            //            personajes[index] = modificar.Personaje;
            //        }
            //    }
            //    ActualizarLista();

            //}
            Personaje personajeSeleccionado = this.dgv_personajes.CurrentRow.DataBoundItem as Personaje;
            FormModificar modificar = new FormModificar(personajeSeleccionado);
            modificar.ShowDialog();
            if (modificar.DialogResult == DialogResult.OK)
            {
                Personaje_Ado.Modificar(modificar.Personaje);
            }

            ActualizarLista();
        }
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            ////Obtener personaje seleccionado en el DataGridView.
            
            //Personaje personajeEliminar = (Personaje)dgv_personajes.CurrentRow.DataBoundItem as Personaje;
           
            ////Mostrar un cuadro de diálogo de confirmación antes de eliminar la computadora de la lista
            //DialogResult rta = MessageBox.Show($"Esta seguro que desea eliminar el numero de personaje  {personajeEliminar.GetId}" +
            //    $"Esta accion es irreversible",
            //    "ELIMINAR", MessageBoxButtons.OKCancel);

            //if (rta == DialogResult.OK)
            //{
            //    personajes.Remove(personajeEliminar);
            //}
            //ActualizarLista(); 
            Personaje psj = dgv_personajes.CurrentRow.DataBoundItem as Personaje;

            DialogResult result = MessageBox.Show($"SEGURO que desea eliminar a\n{psj}\n??¡¡ESTE PROCESO ES IRREVERSIBLE!!", "ELIMINACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                if (Personaje_Ado.Eliminar(psj.GetId()))
                {
                    MessageBox.Show("Eliminacion exitosa");
                }
                else
                {
                    MessageBox.Show("Fallo la conexion con la base de datos");
                }
            }
            else
            {
                MessageBox.Show("Eliminacion cancelada");
            }

            ActualizarLista();

        }
        
        //private void CargarDgv()
        //{
        //    dgv_personajes.DataSource = null;
        //    dgv_personajes.DataSource = personajes;
        //}
        private void ActualizarLista() 
        {//lee la base de datos y lo guarda
            //this.personajes = Personaje_Ado.LeerTodos();//leertodos me devuelve una lista instanciada o//this.personajes = new List<Personaje>();
            dgv_personajes.DataSource = null;
            dgv_personajes.DataSource = Personaje_Ado.LeerTodos();
        }
    }

}
