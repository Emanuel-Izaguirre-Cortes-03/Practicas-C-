using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Practica1.Parte2
{
    class ListaCategorias
    {
        private List<Categoria> categorias;
        public ListaCategorias()
        {
            this.categorias = new List<Categoria>();
        }

        public void AgregarCategoria(Categoria categoria)
        {
            if (BuscarCategoriaPorId(categoria.Idcategoria) == null)
            {
                categorias.Add(categoria);
            }
        }

        public void EliminarCategoria(string id)
        {
            Categoria categoria = BuscarCategoriaPorId(id);
            if (categoria != null)
            {
                categorias.Remove(categoria);
            }
        }

        public string ToLinea()
        {
            string resultado = "";
            foreach (Categoria categoria in categorias)
            {
                resultado += categoria.ToString() + "\n";
            }
            return resultado;
        }

        private Categoria BuscarCategoriaPorId(string id)
        {
            foreach (Categoria categoria in categorias)
            {
                if (categoria.Idcategoria.Equals(id))
                {
                    return categoria;
                }
            }
            return null;
        }

        public string BuscarCategoria(string id)
        {
            Categoria categoria = BuscarCategoriaPorId(id);
            return categoria != null ? categoria.CategoriaName : null;
        }

        public ComboBox AgregarCategoriasAComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            foreach (Categoria categoria in categorias)
            {
                comboBox.Items.Add(categoria);
            }
            return comboBox;
        }

        public object[] CategoriaArreglo()
        {
            return categorias.ToArray();
        }


    }

}
