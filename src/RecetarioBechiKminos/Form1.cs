using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecetarioBechiKminos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Ingrediente_ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_button4_Click(object sender, EventArgs e)
        {
            Controlador.Agregar(nombre_textBox.Text, int.Parse(cantidad_textBox.Text), int.Parse(precio_textBox.Text), int.Parse(puntodepedido_textBox.Text));
            Ingrediente_ListBox.Items.Clear();
            foreach (Ingrediente ingrediente in Controlador.ListaIngredientes)
            {
                Ingrediente_ListBox.Items.Add(ingrediente);
            }
        }

        private void Eliminar_button1_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = Ingrediente_ListBox.SelectedItem as Ingrediente;
            Controlador.Borrar(ingrediente);
            Refrescar();
        }
        private void Refrescar()
        {
            Ingrediente_ListBox.Items.Clear();
            foreach (Ingrediente ingrediente in Controlador.ListaIngredientes)
            {
                Ingrediente_ListBox.Items.Add(ingrediente);
            }
        }

        private void Modificar_button2_Click(object sender, EventArgs e)
        {
            Ingrediente ingrediente = Ingrediente_ListBox.SelectedItem as Ingrediente;
            Controlador.Modificar(ingrediente, nombre_textBox.Text, int.Parse(cantidad_textBox.Text), int.Parse(precio_textBox.Text), int.Parse(puntodepedido_textBox.Text));
            Refrescar();
        }
    }
}
