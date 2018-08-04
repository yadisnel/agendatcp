using System;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Windows.Input;
using System.Windows.Xps.Packaging;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.IO;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Windows.Resources;


namespace Agenda.ModuloAyudaXps.Herramientas
{
  
    public partial class VentanaVisorAyuda : Window
    {

        #region Constructors
        public VentanaVisorAyuda()
            : base()
        {
            InitializeComponent();
            //_gestorXps = new GestorXps(Directory.GetCurrentDirectory());

            //Loaded += VentanaPrincipal_Loaded;
            //ControlBarraTitulo.MouseLeftButtonDown += ControlBarraTitulo_MouseLeftButtonDown;
            //ControlBarraTitulo.ClickCerrar += ControlBarraTitulo_ClickCerrar;
            //ControlBarraTitulo.ClickMaximizar += ControlBarraTitulo_ClickMaximizar;
            //ControlBarraTitulo.ClickMinimizar += ControlBarraTitulo_ClickMinimizar;
            
        }
        #endregion

        //#region Miembros privados
        //private XpsDocument  _documentoXps;
        //private GestorXps _gestorXps;
        //private string _nombreArchivo;
        //private bool EsMaximizado = false;
        //#endregion  Miembros privados

        //#region Private Methods 
        //void ControlBarraTitulo_ClickMinimizar(object sender, RoutedEventArgs e)
        //{
        //    WindowState = WindowState.Minimized;
        //}

        //void ControlBarraTitulo_ClickMaximizar(object sender, RoutedEventArgs e)
        //{
        //    var AnchoPantalla = SystemParameters.PrimaryScreenWidth;
        //    var AltoPantalla = SystemParameters.PrimaryScreenHeight;
        //    GridRaiz.Width = AnchoPantalla;
        //    GridRaiz.Height = AltoPantalla;

        //    if (!EsMaximizado)
        //    {
        //        EsMaximizado = true;
        //        WindowState = WindowState.Normal;
        //        GridRaiz.Width = AnchoPantalla;
        //        GridRaiz.Height = AltoPantalla;
        //        Top = 0;
        //        Left = 0;
        //    }
        //    else
        //    {
        //        EsMaximizado = false;
        //        WindowState = WindowState.Normal;
        //        GridRaiz.Width = AnchoPantalla - 50;
        //        GridRaiz.Height = AltoPantalla - 50;
        //        Top = (AltoPantalla - GridRaiz.Height) / 2;
        //        Left = (AnchoPantalla - GridRaiz.Width) / 2;
        //    }
        //}
        //void ControlBarraTitulo_ClickCerrar(object sender, RoutedEventArgs e)
        //{
        //    if (_documentoXps != null)
        //    {
        //        _documentoXps.Close();
        //    }
        //   DialogResult = true;           
        //}
        //void RecalcularTamano()
        //{
        //    var AnchoPantalla = SystemParameters.PrimaryScreenWidth;
        //    var AltoPantalla = SystemParameters.PrimaryScreenHeight;
        //    GridRaiz.Width = AnchoPantalla - 50;
        //    GridRaiz.Height = AltoPantalla - 50;
        //}
        //void VentanaPrincipal_Loaded(object sender, RoutedEventArgs e)
        //{
        //   RecalcularTamano();
        //}
        //void ControlBarraTitulo_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        //{
        //    DragMove();
        //}
        //public void AbrirDocumentoXps(string nombreFichero)
        //{            
        //    if (_documentoXps != null)
        //    {
        //        _documentoXps.Close();
        //    }
        //    try
        //    {
        //        _documentoXps = new  XpsDocument(nombreFichero, System.IO.FileAccess.ReadWrite);
        //    }
        //    catch (UnauthorizedAccessException)
        //    {
        //        System.Windows.MessageBox.Show(String.Format("No se puede acceder a {0}.",nombreFichero) );
        //        return;
        //    }                
        //    docViewer.Document = _documentoXps.GetFixedDocumentSequence();
        //    _nombreArchivo = nombreFichero;                      
        //}
        //public void AbrirDocumentoXpsDesdeStream(string nombreFichero)
        //{            
        //    if (_documentoXps != null)
        //    {
        //        _documentoXps.Close();
        //    }
        //    try
        //    {
        //        byte [] arreglo =  global::Bcf.ModuloAyudaXps.Resource1.ejemplo;
        //        //Uri uri = new Uri(@"pack://application:,,,/carpeta/ejemplo.xps");
        //        //StreamResourceInfo ri = System.Windows.Application.GetContentStream(uri);
        //        MemoryStream ms = new MemoryStream();
        //        ms.Write(arreglo, 0, arreglo.Length);
        //        //Stream source = MemoryStream;

        //        FileStream fs = new FileStream("tmp.xpstmp", FileMode.Create);
        //        fs.Write(arreglo, 0, arreglo.Length);
        //        fs.Close();
        //        _documentoXps = new XpsDocument("tmp.xpstmp", System.IO.FileAccess.ReadWrite);               
                
        //    }
        //    catch (UnauthorizedAccessException)
        //    {
        //        System.Windows.MessageBox.Show(String.Format("No se puede acceder a {0}.",nombreFichero) );
        //        return;
        //    }                
        //    docViewer.Document = _documentoXps.GetFixedDocumentSequence();
        //    _nombreArchivo = nombreFichero;                     
        //}
        //#endregion Private Methods
    }// end:partial class Window1

}