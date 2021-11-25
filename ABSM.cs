using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TP9_ABMS
{
    public partial class ABSM : Form
    {
        private string nombreArchivo = "/archivo.txt";
        private string nombreAuxiliar = "/auxiliar.txt";

        public ABSM()
        {
            InitializeComponent();
            Listar();
        }

        private void Listar()
        {
            listado.Items.Clear();

            using (FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivo, FileMode.Open))
            {
                using (StreamReader lector = new StreamReader(archivo))
                {
                    while (!lector.EndOfStream)
                    {
                        string registro = lector.ReadLine();

                        if (registro != null)
                        {
                            string Legajo = registro.Split(',')[0];
                            string Categoria = registro.Split(',')[1];
                            string Nombre = registro.Split(',')[2];

                            listado.Items.Add(Legajo + " - " + Categoria + " - " + Nombre);
                        }
                    }
                }
            }
        }

        private void AltaAlumno()
        {
            using (FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivo, FileMode.Append))
            {
                using (StreamWriter escritor = new StreamWriter(archivo))
                {
                    string registro = legajo.Text + "," + categoria.Text + "," + apellidoYnombre.Text;
                    escritor.WriteLine(registro);
                }

                legajo.Text = "";
                categoria.Text = "";
                apellidoYnombre.Text = "";

                legajo.Focus();
            }

            Listar();
        }

        private void BajaAlumno()
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivo, FileMode.Open);
            FileStream auxiliar = new FileStream(Directory.GetCurrentDirectory() + nombreAuxiliar, FileMode.Create);

            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(auxiliar);

            string Legajo = legajo.Text;
            string Registro;

            while (!lector.EndOfStream)
            {
                Registro = lector.ReadLine();

                if (Registro != null)
                {
                    if (Registro.Split(',')[0] != Legajo)
                    {
                        escritor.WriteLine(Registro);
                    }
                }
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            auxiliar.Close();

            File.Delete(Directory.GetCurrentDirectory() + nombreArchivo);
            File.Move(Directory.GetCurrentDirectory() + nombreAuxiliar, Directory.GetCurrentDirectory() + nombreArchivo);

            legajo.Text = "";
            apellidoYnombre.Text = "";
            categoria.Text = "";

            legajo.Focus();

            Listar();
        }

        private void ModificarAlumno()
        {
            FileStream archivo = new FileStream(Directory.GetCurrentDirectory() + nombreArchivo, FileMode.Open);
            FileStream auxiliar = new FileStream(Directory.GetCurrentDirectory() + nombreAuxiliar, FileMode.Create);

            StreamReader lector = new StreamReader(archivo);
            StreamWriter escritor = new StreamWriter(auxiliar);

            string Legajo = legajo.Text;
            string Registro;

            while (!lector.EndOfStream)
            {
                Registro = lector.ReadLine();

                if (Registro != null)
                {
                    if (Registro.Split(',')[0] == Legajo)
                    {
                        Registro = legajo.Text + "," + apellidoYnombre.Text + "," + categoria.Text;
                    }

                    escritor.WriteLine(Registro);
                }
            }

            lector.Close();
            escritor.Close();
            archivo.Close();
            auxiliar.Close();

            File.Delete(Directory.GetCurrentDirectory() + nombreArchivo);
            File.Move(Directory.GetCurrentDirectory() + nombreAuxiliar, Directory.GetCurrentDirectory() + nombreArchivo);

            legajo.Text = "";
            apellidoYnombre.Text = "";
            categoria.Text = "";

            legajo.Focus();

            Listar();
        }

        private void alta_Click(object sender, EventArgs e)
        {
            AltaAlumno();
        }

        private void baja_Click(object sender, EventArgs e)
        {
            BajaAlumno();
        }

        private void modificar_Click(object sender, EventArgs e)
        {
            ModificarAlumno();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
