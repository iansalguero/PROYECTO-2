using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto2_Album
{
    class Estampa
    {
        public string Categoria;
        public string Codigo;
        public int Estado; // 0: faltante, 1: marcada, 2: repetida

        public Estampa(string UnCategoria, int UnNumero)
        {
            Categoria = UnCategoria;
            Codigo = UnCategoria + Convert.ToString(UnNumero);
            Estado = 0;
        }

        public void Marcar()
        {
            Estado = 1;
        }

        public void Repetir()
        {
            Estado = 2;
        }

        public void Faltar()
        {
            Estado = 0;
        }
    }
}
