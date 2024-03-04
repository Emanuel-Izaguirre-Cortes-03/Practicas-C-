using Practica1.Parte2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Libreria
{
    class Archivotxt
    {
        private string nombreArchivo;
        private List<Categoria> listaCategorias;

        public Archivotxt(string nombreArchivo)
        {
            this.nombreArchivo = nombreArchivo;
            this.listaCategorias = new List<Categoria>();
        }

        public void Guardar(string texto)
        {
            try
            {
                File.WriteAllText(nombreArchivo, texto);
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al guardar el archivo: " + e.Message);
            }
        }

        public List<string> Cargar()
        {
            List<string> lineas = new List<string>();
            try
            {
                lineas.AddRange(File.ReadAllLines(nombreArchivo));
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al cargar el archivo: " + e.Message);
            }
            return lineas;
        }

        public void CargarCategorias(List<string[]> categoriasString)
        {
            foreach (string[] categoriaString in categoriasString)
            {
                string idCategoria = categoriaString[0];
                string nombreCategoria = categoriaString[1];
                Categoria categoria = new Categoria(idCategoria, nombreCategoria);
                AgregarCategoria(categoria);
            }
        }

        private void AgregarCategoria(Categoria categoria)
        {
            listaCategorias.Add(categoria);
        }

    }
}
