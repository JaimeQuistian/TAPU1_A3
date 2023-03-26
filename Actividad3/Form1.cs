//   Topicos Avanzados de Programación
//   Unidad 1 Interfaz Gráfica de Usuario
//   Objetivo: DESARROLLAR UNA APLICACIÓN PARA FORMS, CON EL LENGUAJE DE PROGRAMACIÓN C# Y HACIENDO USO DEL IDE VISUAL STUDIO
//             COMMUNITY EDITION, QUE IMPLEMENTE DIFERENTES TIPOS DE EVENTOS. 
//   Docente: Ulises Martínez Rodríguez
//   Alumno: Jaime Emanuel Quistián Sánchez
//   Actividad 2 Eventos
//   Clave actividad TAPU1_A3

//Librerias de .Net Frameworks
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Nombre del código creado
namespace Actividad3
//Llave de inicio del código
{
    //Cominenzo de la clase Form llamada frmAcesso para poder trabajar con ella por medio del Desinger
    public partial class frmAcceso : Form
    //Llave de inicio de la clase frnAcceso
    {
        //Variable global de tipo bool llamada 'accionPermitida' que se le dará uso mas adelante
        bool accionPermitida;
        //Constructor de la clase frmAcceso
        public frmAcceso()
        { //Llave de inicio del constructor
            InitializeComponent(); //Método necesario para admitir el Diseñador
        } //Llave de cierre del constructor

        //------- 1er Evento CheckedChanged asociado a los controles "rbOpcion1, rbopcion2, cbColorFondo, cbColorLetra" -------

        //Creación y especificaiones del evento CheckedChanged para el control rbOpcion1
        private void rbOpcion1_CheckedChanged(object sender, EventArgs e)
        {//Llave de inicio del evento
            //Secuencia comparatriva que evaluará si rbOpcion1 esta activado
            if (rbOpcion1.Checked == true)
            {//Llave de inicio del if
                //Mostrar una caja de mensaje con la leyenda "Listo, intenta alcanzar la imagen", tendra como titulo "Mensaje",
                //mostrará un boton que dirá "Aceptar" y antes de la leyenda mostrará un icono de Información
                MessageBox.Show("Listo, intenta alcanzar la imagen", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Asignación de un valor a la variable 'accionPermitida' de tipo true
                accionPermitida = true;
            }//Llave de cierre del if
        }//Llave de cierre del evento

        //Creación y especificaiones del evento CheckedChanged para el control rbOpcion2
        private void rbOpcion2_CheckedChanged(object sender, EventArgs e)
        {//Lave de inicio del evento
            //Secuencia comparativa que evaluará si rbopcion2 esta activo
            if (rbOpcion2.Checked == true)
            {//Lave de inicio del if
                //Mostrar una caja de mensaje con la leyenda "Listo, la imagen ya no se moverá", tendra como titulo "Mensaje",
                //mostrará un boton que dirá "Aceptar" y antes de la leyenda mostrará un icono de Información
                MessageBox.Show("Listo, la imagen ya no se moverá", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                accionPermitida = false;
            }//Lave de cierre del if
        }//Lave de cierre del evento

        //------- 2do Evento MouseMove asociado al control "pbImagenCuasar" --------

        //Creación y especificaiones del evento MouseMove para el control pbImagenCuasar
        private void pbImagenCuasar_MouseMove(object sender, MouseEventArgs e)
        {//Lave de inicio del evento
            //Secuencia comparativa que evaluará si la variable 'accionPermitida' es verdadera y cuyo valor fue definido por
            //medio de los controles radioButtom anteriores
            if (accionPermitida == true)
            {//Lave de inicio del if
                //Instanciación de la clase Random para crear numeros aleatorios
                Random randomX = new Random();
                Random randomY = new Random();
                //Declaracion de 2 variables de tipo Int llamadas 'coordenadaX y coordenadaY'
                int coordenadaX, coordenadaY;
                //Asignación de un valor aleatorio en una coordenada X o Y para el movimiento de la imagen
                //.Next evita los valores negativos  ||  ClientSize. es el ultimo valor que ocupa el form  ||  se le resta el 
                //tamaño de la imagen para evitar que se pierda
                coordenadaX = randomX.Next(0, ClientSize.Width - pbImagenCuasar.Width);
                coordenadaY = randomY.Next(0, ClientSize.Height - pbImagenCuasar.Height);
                //Asignar el nuevo valor para la propiedad con la nueva coordenada para la imagen
                pbImagenCuasar.Location = new Point(coordenadaX, coordenadaY);
            }//Lave de cierre del if
        }//Lave de cierre del evento

        //Creación y especificaiones del evento CheckedChanged para el control cbColorFondo
        private void cbColorFondo_CheckedChanged(object sender, EventArgs e)
        {//Lave de inicio del evento
            //Secuencia comparativa que evaluará si 'cbColorFondo' es verdadera para realizar las siguientes acciones
            if (cbColorFondo.Checked == true)
            {//Lave de inicio del if
                //Instanciación de de la clase ColorDialog para mortrar una caja de mensaje con las especificaiones de los
                //colores que se quieren modificar
                ColorDialog colorDialog = new ColorDialog();
                //Mostrar la caja de mensaje
                colorDialog.ShowDialog();
                //Uso del apuntador this para definir que el cambio será dentro de estre form
                this.BackColor = colorDialog.Color;
            }//Lave de cierre del if
        }//Lave de cierre del evento

        //Creación y especificaiones del evento CheckedChanged para el control cbColorLetra
        private void cbColorLetra_CheckedChanged(object sender, EventArgs e)
        {//Lave de inicio del evento
            //Secuencia comparativa que evaluará si 'cbColorLetra' es verdadera para realizar las siguientes acciones
            if (cbColorLetra.Checked == true)
            {//Lave de inicio del if
                //Instanciación de de la clase ColorDialog para mortrar una caja de mensaje con las especificaiones de los
                //colores que se quieren modificar
                ColorDialog colorDialog = new ColorDialog();
                //Mostrar la caja de mensaje
                colorDialog.ShowDialog();
                //Uso del apuntador this para definir que el cambio será dentro de estre form
                this.ForeColor = colorDialog.Color;
            }//Lave de cierre del if
        }//Lave de cierre del evento

        //------- 3er Evento Click asociado a los controles "btnRestablecer, txtRespuesta, btnCerrar" --------

        //Creación y especificaiones del evento Click para el control btnRestablecer
        private void btnRestablecer_Click(object sender, EventArgs e)
        {//Lave de inicio del evento
            //Uso del apuntador this para definir que el cambio del color de fondo y letra será dentro de estre form
            this.BackColor = Color.Silver;
            this.ForeColor = Color.Black;
        }//Lave de cierre del evento

        //Creación y especificaiones del evento Click para el control txtRespuesta
        private void txtRespuesta_Click(object sender, EventArgs e)
        {//Lave de inicio del evento
            //Al contol txtRespuesta se le asocia con el método Clear para borrar lo que esté dentro del mismo
            txtRespuesta.Clear();
        }//Lave de cierre del evento

        //------- 4to Evento TextChanged asociado al control "txtRespuesta" --------

        //Creación y especificaiones del evento TextChanged para el control txtRespuesta
        private void txtRespuesta_TextChanged(object sender, EventArgs e)
        {//Lave de inicio del evento
            //Secuencia comparativa que evaluara la propiedad text del control txtRespuesta si es igual a la palabra cuasar
            if (txtRespuesta.Text == "cuasar")
            {//Lave de inicio del if
                //Mostrar una caja de mensaje con la leyenda "Correcto", tendra como titulo "Respuesta", mostrará un boton que
                //dirá "Aceptar" y antes de la leyenda mostrará un icono de Información
                MessageBox.Show("Correcto", "Respuesta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }//Lave de cierre del if
        }//Lave de cierre del evento

        //Creación y especificaiones del evento Click para el control btnCerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {//Lave de inicio del evento
            //Uso del apuntador this para especificar que será este form que que se cerrará haciendo uso del método Close
            this.Close();
        }//Lave de cierre del evento

        //------- 5to Evento Load asociado al control "frmAcceso" --------

        //Creación y especificaiones del evento Load para el control frmAcceso
        private void frmAcceso_Load(object sender, EventArgs e)
        {//Lave de inicio del evento
            //Mostrar una caja de mensaje con la leyenda "Bienvenido", tendra como titulo "Acceso", mostrará dos botones que
            //dirá "Aceptar" y antes de la leyenda mostrará un icono de Información
            MessageBox.Show("Bienvenido", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }//Lave de cierre del evento

        //Llave de cierre de la clase frmAcceso
    }
    //Llave de cierre del código
}