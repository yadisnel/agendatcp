using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Agenda.ModuloExc.Excepciones;

namespace Agenda.Controles
{
    public partial class ControlPestanas : UserControl
    {       
        public ControlPestanas()
        {           
           
            InitializeComponent();
            
        }
        public void AdicionarPestana(string nombre,string titulo, string icono)
        {
            ControlSeparador cs = new ControlSeparador();
            cs.Visibility = System.Windows.Visibility.Hidden;
            if (StackPanelContenedorPestanas.Children.Count > 0)
            {
                StackPanelContenedorPestanas.Children.Add(cs);
            }
            BotonPestana bp = new BotonPestana();
            bp.Name = nombre;
            bp.Titulo = titulo;
            bp.Icono = (Image)this.FindResource(icono);
            bp.Click += new RoutedEventHandler(bp_Click);
            StackPanelContenedorPestanas.Children.Add(bp);
        }
        public void AdicionarPestana(string nombre, string titulo)
        {
            ControlSeparador cs = new ControlSeparador();
            cs.Visibility = System.Windows.Visibility.Hidden;
            if (StackPanelContenedorPestanas.Children.Count > 0)
            {
                StackPanelContenedorPestanas.Children.Add(cs);
            }
            BotonPestana bp = new BotonPestana();
            bp.Name = nombre;
            bp.Titulo = titulo;          
            bp.Click += new RoutedEventHandler(bp_Click);
            StackPanelContenedorPestanas.Children.Add(bp);
        }

        void bp_Click(object sender, RoutedEventArgs e)
        {
            UIElementCollection Coleccion = StackPanelContenedorPestanas.Children;
            foreach (UIElement uie in Coleccion)
            {
                if (uie is BotonPestana)
                {
                    BotonPestana bo = uie as BotonPestana;
                    if (!bo.Name.Equals(((BotonPestana)sender).Name))
                    {
                        bo.EstaSeleccionado = false;
                    }                    
                }
            }       
        }
        public BotonPestana ObtenerPestana(string nombre)
        {
            UIElementCollection Coleccion = StackPanelContenedorPestanas.Children;
            foreach (UIElement uie in Coleccion)
            {
                if (uie is BotonPestana)
                {
                    if (((BotonPestana)uie).Name == nombre)
                    {
                        return (BotonPestana)uie;
                    }
                }
            }
            throw new EObjetoNoEncontrado(nombre);
        }
    }
}
