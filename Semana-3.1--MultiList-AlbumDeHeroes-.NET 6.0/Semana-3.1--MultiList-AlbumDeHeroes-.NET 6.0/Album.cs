using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_3._1__MultiList_AlbumDeHeroes_.NET_6._0
{
    internal class Album
    {
        public Album() { }

        public String Codigo { get; set; }

        public String Nombre { get; set; }

        public List<Heroe> Heroes { get; set; }
    }
}
