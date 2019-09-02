using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetarioBechiKminos
{
    public static class Controlador
    {
        public static List<Ingrediente> ListaIngredientes { get; }

        static Controlador()
        {
            ListaIngredientes = new List<Ingrediente>();
        }

        public static void Agregar (string nombre, int cantidad, int precio, int puntodepedido)
        {
            Ingrediente ingrediente = new Ingrediente()
            {
                Nombre = nombre,
                Cantidad = cantidad,
                Precio = precio,
                PuntoDePedido = puntodepedido
            };
            ListaIngredientes.Add(ingrediente);
            Guardar();
        }
        public static void Borrar(Ingrediente ingrediente)
        {
            ListaIngredientes.Remove(ingrediente);
            Guardar();
        }

        public static void Modificar(Ingrediente ingrediente,string nombre, int cantidad, int precio, int puntodepedido)
        {
            ingrediente.Nombre = nombre;
            ingrediente.Cantidad = cantidad;
            ingrediente.Precio = precio;
            ingrediente.PuntoDePedido = puntodepedido;
            Guardar();
        }
        private static void Guardar()
        {
            using (StreamWriter escritor = new StreamWriter("Ingredientes.json"))
            {
                string ingredientesJSON = JsonConvert.SerializeObject(ListaIngredientes);
                escritor.Write(ingredientesJSON);
            }
        }
        private static void Cargar()
        {
            if (File.Exists("Ingredientes.json"))
            {
                using (StreamReader lector = new StreamReader("Ingredientes.json"))
                {
                    string ingredientesJSON = lector.ReadToEnd();
                    ListaIngredientes = JsonConvert.DeserializeObject<IList<ingrediente>>(ingredientesJSON);
                }
            }
        }
    }
}
