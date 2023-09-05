namespace Semana_3._1__MultiList_AlbumDeHeroes_.NET_6._0
{
    public partial class Form1 : Form
    {
        List<Album> albumes = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void mostrarAlbumes(List<Album> lista)
        {
            listViewAlbum.Items.Clear();

            foreach (Album album in lista)
            {
                ListViewItem fila = new(album.Codigo);
                fila.SubItems.Add(album.Nombre);
                listViewAlbum.Items.Add(fila);
            }

            //Obtener el album con más héroes
            Album? albumMasHeroes = lista.MaxBy(elemento => elemento.Heroes.Count);
            if (albumMasHeroes != null) lblAlbumMasHeroes.Text = albumMasHeroes.Nombre;
        }

        private void btnRegistrarAlbum_Click(object sender, EventArgs e)
        {
            //Validacion
            if (tbAlbumCodigo.Text == "" || tbAlbumNombre.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos del álbum");
                return;
            }

            //Verificación de código repetido
            bool exists =
                albumes.Exists(elemento => elemento.Codigo.Equals(tbAlbumCodigo.Text));
            if (exists)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            //Crear el objeto
            Album album = new()
            {
                Codigo = tbAlbumCodigo.Text,
                Nombre = tbAlbumNombre.Text,
                Heroes = new()
            };

            //Agregarlo a la lista
            albumes.Add(album);

            //Mostrar en el ListView
            mostrarAlbumes(albumes);
        }

        private void btnLimpiarAlbum_Click(object sender, EventArgs e)
        {
            //Mostrar en el ListView
            mostrarAlbumes(albumes);
        }

        private void mostrarHeroes(List<Heroe> lista)
        {
            listViewHeroe.Items.Clear();

            foreach (Heroe heroe in lista)
            {
                ListViewItem fila = new(heroe.Codigo);
                fila.SubItems.Add(heroe.Nombre);
                fila.SubItems.Add(heroe.Caracteristicas);
                fila.SubItems.Add(heroe.Poder.ToString());
                listViewHeroe.Items.Add(fila);
            }

            //Héroes con mayor y menor poder
            Heroe? heroeMayorPoder = lista.MaxBy(elemento => elemento.Poder);
            Heroe? heroeMenorPoder = lista.MinBy(elemento => elemento.Poder);
            if (heroeMayorPoder != null) lblMayorPoder.Text = heroeMayorPoder.Nombre;
            if (heroeMenorPoder != null) lblMenorPoder.Text = heroeMenorPoder.Nombre;
        }

        private void btnRegistrarHeroe_Click(object sender, EventArgs e)
        {
            //Validacion
            bool seleccionado = listViewAlbum.SelectedItems.Count != 0;
            if (!seleccionado || tbHeroeCodigo.Text == "" || tbHeroeNombre.Text == "" || tbHeroeCaracteristicas.Text == "" || tbHeroePoder.Text == "")
            {
                MessageBox.Show("Ingrese todos los campos del álbum");
                return;
            }

            //Encontrar el album selecionado
            String codigo = listViewAlbum.SelectedItems[0].Text;
            Album? albumSeleccionado = albumes.Find(elemento => elemento.Codigo.Equals(codigo));
            if (albumSeleccionado == null) return;

            //Hallamos la lista de héroes del álbum
            List<Heroe> heroes = albumSeleccionado.Heroes;

            //Verificación de código repetido
            bool existe =
                heroes.Exists(elemento => elemento.Codigo.Equals(tbHeroeCodigo.Text));
            if (existe)
            {
                MessageBox.Show("El código ya existe");
                return;
            }

            //Crear el objeto
            Heroe heroe = new()
            {
                Codigo = tbHeroeCodigo.Text,
                Nombre = tbHeroeNombre.Text,
                Caracteristicas = tbHeroeCaracteristicas.Text,
                Poder = double.Parse(tbHeroePoder.Text),
            };

            //Agregarlo a la lista de Héroes del album
            albumSeleccionado.Heroes.Add(heroe);

            //Mostrar en el ListView
            mostrarHeroes(albumSeleccionado.Heroes);
        }

        private void listViewAlbumes_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validación
            bool seleccionado = listViewAlbum.SelectedItems.Count != 0;
            if (!seleccionado) return;

            //Hallar el álbum
            String codigo = listViewAlbum.SelectedItems[0].Text;
            Album? albumSeleccionado = albumes.Find(elemento => elemento.Codigo.Equals(codigo));
            if (albumSeleccionado == null) return;

            mostrarHeroes(albumSeleccionado.Heroes);
        }

        private void btnLimpiarHeroe_Click(object sender, EventArgs e)
        {
            //Mostrar en el ListView
            mostrarHeroes(new List<Heroe>());
        }

        private void listViewHeroe_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Validación
            bool seleccionado = listViewHeroe.SelectedItems.Count != 0;
            if (!seleccionado) return;

            //Hallar el código del héroe
            String codigo = listViewHeroe.SelectedItems[0].Text;

            //Buscar los álbumes que tengan el héroe con ese código
            List<Album> albumesTmp = new();
            foreach (Album album in albumes)
            {
                bool existe = album.Heroes.Exists(elemento => elemento.Codigo.Equals(codigo));
                if (existe) albumesTmp.Add(album);
            }

            //Mostrar álbumes
            mostrarAlbumes(albumesTmp);
        }
    }
}