using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Parte2
{
    class Insumo
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public string IdCategoria { get; set; }
        public Insumo(string id, string nombre, string idCategoria)
        {
            Id = id;
            Nombre = nombre;
            IdCategoria = idCategoria;
        }

        public override string ToString()
        {
            return $"ID: {Id}, Nombre: {Nombre}, Categoría: {IdCategoria}";
        }
    }

    public class ListaInsumos
    {
        private List<Insumo> insumos;

        public ListaInsumos()
        {
            insumos = new List<Insumo>();
        }

        public bool AgregarInsumo( Insumo insumo)
        {
            insumos.Add(insumo);
            return true;
        }

        public bool EliminarInsumoPorId(string id)
        {
            var insumo = insumos.Find(i => i.Id == id);
            if (insumo != null)
            {
                insumos.Remove(insumo);
                return true;
            }
            return false;
        }

        public string BuscarInsumo(string id)
        {
            var insumo = insumos.Find(i => i.Id == id);
            return insumo != null ? insumo.ToString() : null;
        }

        public string[] IdInsumos()
        {
            List<string> ids = new List<string>();
            foreach (var insumo in insumos)
            {
                ids.Add(insumo.Id);
            }
            return ids.ToArray();
        }

        public override string ToString()
        {
            string resultado = "";
            foreach (Insumo insumo in insumos)
            {
                resultado += insumo.ToString() + "\n";
            }
            return resultado;
        }

    }
}
