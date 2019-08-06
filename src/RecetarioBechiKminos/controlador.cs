using System;
using System.Collections.Generic;
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
        }
        public static void Borrar(Ingrediente ingrediente)
        {
            ListaIngredientes.Remove(ingrediente);
        }
        public static void Modificar(Ingrediente ingrediente,string nombre, int cantidad, int precio, int puntodepedido)
        {
            ingrediente.Nombre = nombre;
            ingrediente.Cantidad = cantidad;
            ingrediente.Precio = precio;
            ingrediente.PuntoDePedido = puntodepedido;
        }
    }
}
