using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LPPA_Miwebsite.Models
{
    public class Dominio
    {
        
        private static List<Producto> productos = new List<Producto>();
        public static void Add(Producto producto)
        {
            productos.Add(producto);
        }

        public static List<Producto> Get()
        {
            return productos;
        }
    }
}