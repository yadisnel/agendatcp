using System;
using System.Collections;
using System.Windows;
using System.Windows.Controls;

namespace Agenda.Controles
{
    /// <summary>
    /// Interaction logic for BarraTitulo.xaml
    /// </summary>
    public class MenuElementArgs : EventArgs
    {
        private string _idElemento;

        public string IdElemento
        {
            get
            {
                return _idElemento;
            }

            set
            {
                _idElemento = value;
            }
        }
    }
    public partial class MenuAplicacion : UserControl
    {
        public event EventHandler ClickElemento;       

        Hashtable menus = new Hashtable();

        void onClickElemento(object sender, RoutedEventArgs e)
        {   
            BotonMenu bm = (BotonMenu)sender;
            MenuElementArgs args = new MenuElementArgs();
            args.IdElemento = bm.IdElemento;
            SeleccionarElemento(bm.IdElemento);
            if(ClickElemento != null)this.ClickElemento(this, args);
        }

        public void AdicionarMenu(string id, string Titulo)
        {
            if (!menus.ContainsKey(id))
            {
                BotonMenu bm = new BotonMenu();
                bm.HorizontalAlignment = HorizontalAlignment.Stretch;
                bm.VerticalAlignment = VerticalAlignment.Stretch;
                bm.Titulo = Titulo;
                bm.IdElemento = id;

                if (StackPanelContenedor.Children.Count > 0)
                {
                    bm.Margin = new Thickness(0, 0, 10, 0);
                }
                else
                {
                    bm.Margin = new Thickness(0, 0, 5, 0);
                }
                menus[id] = bm;
                StackPanelContenedor.Children.Add(bm);
                bm.Click += onClickElemento;
            }
        }

        private void DeseleccionarTodos()
        {
            foreach (string key in menus.Keys)
            {
                BotonMenu bm = (BotonMenu)menus[key];
                bm.EstaSeleccionado = false;
            }
        }

        public void SeleccionarElemento(string id)
        {
            foreach (string key in menus.Keys)
            {
                BotonMenu bm = (BotonMenu)menus[key];
                if (key.Equals(id))
                {
                    bm.EstaSeleccionado = true;
                }
                else
                {
                    bm.EstaSeleccionado = false;
                }
            }
        }
        public void DeseleccionarElemento(string id)
        {
            BotonMenu bm = (BotonMenu)menus[id];
            if(bm != null) bm.EstaSeleccionado = false;
        }
        
        public MenuAplicacion()
        {  
            InitializeComponent();                             
        }
    }
}
