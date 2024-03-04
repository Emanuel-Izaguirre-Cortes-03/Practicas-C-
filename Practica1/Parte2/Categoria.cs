using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica1.Parte2
{
    class Categoria
    {
        private string idcategoria;
        private string categoria;
    }
    public Categoria(string idcategoria, string categoria)
    {
        this.Idcategoria = idcategoria;
        this.CategoriaName = categoria;
    }

    public string Idcategoria
    {
        get { return idcategoria; }
        set { idcategoria = value; }
    }

    public string CategoriaName
    {
        get { return categoria; }
        set { categoria = value; }
    }

    public override string ToString()
    {
        return CategoriaName;
    }

}
