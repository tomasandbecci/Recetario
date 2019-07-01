using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecetarioBechiKminos
{
    public class Controlador
    {
        public void AgregarReceta(string Nombre, int Cantidad, int Precio, int PuntoDePedido)
        {
            Ingrediente ingrediente = new Ingrediente()
            {
                Nombre = Nombre,
                Cantidad = Cantidad,
                Precio = Precio,
                PuntoDePedido = PuntoDePedido,
            };
        }

    }
}
