using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchivosVisual
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {



            AddE();

            Clear();

            ShowE();
        

        }

        private void AddE()
        {
            FileStream mArchivoEscritor = new FileStream("datos.dat", FileMode.OpenOrCreate, FileAccess.Write);
            using (BinaryWriter Escritor = new BinaryWriter(mArchivoEscritor))
            {
                try
                {
                    string nombre = tbName.Text;
                    int edad = int.Parse(tbAge.Text);
                    int nota = int.Parse(tbGrade.Text);
                    char genero = cmbGen.SelectedItem.ToString()[0];

                    Escritor.Write(nombre.Length);
                    Escritor.Write(nombre.ToCharArray());
                    Escritor.Write(edad);
                    Escritor.Write(nota);
                    Escritor.Write(genero);


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void ShowE()
        {
            FileStream mArchivoLector = new FileStream("datos.dat", FileMode.Open, FileAccess.Read);
            using (BinaryReader Lector = new BinaryReader(mArchivoLector))
            {
                while (mArchivoLector.Position != mArchivoLector.Length)
                {
                    int longitud = Lector.ReadInt32();
                    char[] nombre = Lector.ReadChars(longitud);
                    string nombreS = new string(nombre);
                    int edad = Lector.ReadInt32();
                    int nota = Lector.ReadInt32();
                    char genero = Lector.ReadChar();

                    lbShow.Items.Add($"Nombre: {nombreS}");
                    lbShow.Items.Add($"Edad: {edad}");
                    lbShow.Items.Add($"Nota: {nota}");
                    lbShow.Items.Add($"Genero: {genero}");
                    lbShow.Items.Add("**************");
                }

            }

        }

        private void Clear()
        {

            tbName.Clear();
            tbAge.Clear();
            tbGrade.Clear();
            cmbGen.SelectedIndex = -1;
            tbName.Focus();
        }


    }
}
