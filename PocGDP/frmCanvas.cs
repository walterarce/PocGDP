using System;
using System.Drawing;
using System.Windows.Forms;

namespace PocGDP
{
    public partial class frmCanvas : Form
    {
        public Figura figuraSeleccionada;
        public Figura nuevafigura;
        public Estados estado_canvas { get; set; }
        private Punto p1_actual;
        public Figura figura { get; set; } 
        public frmCanvas()
        {
            InitializeComponent();
        }
        public Figura SeleccionaFigura(Punto x, Punto y)
        {
            for (int i = listafigura.Count - 1; i >= 0; i--)
            {
                if (listafigura[i].FiguraContenida(x, y))
                    return listafigura[i];
            }
            return null;
        }

        private void botonCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPintar_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
        }


        public void Redibujar()
        {
            Graphics grp = canvas.CreateGraphics();
            grp.Clear(SystemColors.Control);
           
            foreach (var figura in listafigura)
            {
                figura.Dibujar(canvas);
            }
            grp.Dispose();
        }

        //presionando y manteniendo
        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (figura != null && estado_canvas == Estados.Dibujando)
            {
                //aca fabrico el objeto que seleccione, y aplico un nombre con su codigo hash de objeto, 
                // asimismo le asigno el punto de la punta izquierda superior
                nuevafigura = (Figura)FiguraFactory.FabricarObjeto(figura.ToString());
                nuevafigura.colorRelleno = ((frmExplorer)Application.OpenForms["frmExplorer"]).colorFondo.Color;
                nuevafigura.anchoLapicera = ((frmExplorer)Application.OpenForms["frmExplorer"]).anchoLinea.Value;
                nuevafigura.NombreFigura = nuevafigura.GetType().Name + nuevafigura.GetHashCode();
                p1_actual = new Punto(e.X, e.Y);
                nuevafigura.punto1 = p1_actual;
                if (nuevafigura is StringPic)
                {
                    ((StringPic)nuevafigura).Texto = ((StringPic)figura).Texto;
                    ((StringPic)nuevafigura).SizeTexto = ((StringPic)figura).SizeTexto;
                    ((StringPic)nuevafigura).FuenteTexto = ((StringPic)figura).FuenteTexto;
                    ((StringPic)nuevafigura).colorRelleno = ((StringPic)figura).colorRelleno;
                }
                if (nuevafigura is Imagen)
                {
                    ((Imagen)nuevafigura).ImagenSelect = ((Imagen)figura).ImagenSelect;
                }
            }
            if (figuraSeleccionada != null && estado_canvas == Estados.Escalando)
            {
                foreach (var item in listafigura)
                {
                    if (item == figuraSeleccionada)
                    {
                        item.punto1 = figuraSeleccionada.punto1;
                        item.Dibujar(canvas);
                    }
                }

            }
            if (figuraSeleccionada != null && estado_canvas == Estados.Moviendo)
            {
                var figuraSeleccionadaVarXAnt = figuraSeleccionada.punto1.X;
                var figuraSeleccionadaVarYAnt = figuraSeleccionada.punto1.Y;
                figuraSeleccionada.punto1 = new Punto(e.X, e.Y);
                foreach (var item in listafigura)
                {
                    if (item == figuraSeleccionada)
                    {
                        item.punto1 = figuraSeleccionada.punto1;
                        var varX = (e.X + (figuraSeleccionada.punto2.X- figuraSeleccionadaVarXAnt));
                        var varY = (e.Y + (figuraSeleccionada.punto2.Y- figuraSeleccionadaVarYAnt));
                        item.punto2 = new Punto(varX, varY);
                        item.Dibujar(canvas);
                        this.Redibujar(item);
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = null;
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = this.listafigura;
                    }
                }
            }
        }

        //sin soltar
        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {

            labelSeleccion.Text = String.Format($"x:{e.X}, y:{e.Y}");
            lblEstado.Text = this.estado_canvas.ToString();
            if (e.Button == MouseButtons.Left && estado_canvas == Estados.Dibujando) 
            {
                if (nuevafigura is Linea)
                {
                    //grp.DrawLine(new Pen(ColorLinea, AnchoLinea), inicial, e.Location);
                    ((Linea)nuevafigura).AgregarPunto(e.Location);
                    ((Linea)nuevafigura).Dibujar(canvas);// Dibujo.Add(ln);
                }

            }
            if (figuraSeleccionada != null && estado_canvas == Estados.Escalando)
            {
                foreach (var item in listafigura)
                {
                    if (item == figuraSeleccionada)
                    {
                        item.punto1 = figuraSeleccionada.punto1;
                        item.punto2 = new Punto(e.X, e.Y);
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = null;
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = this.listafigura;
                        item.Dibujar(canvas);
                        this.Redibujar();
                    }
                }
            }
            if (figuraSeleccionada != null && estado_canvas == Estados.Moviendo)
            {
                var figuraSeleccionadaVarXAnt = figuraSeleccionada.punto1.X;
                var figuraSeleccionadaVarYAnt = figuraSeleccionada.punto1.Y;
                Console.WriteLine($"x{figuraSeleccionadaVarXAnt} y {figuraSeleccionadaVarYAnt}");
                figuraSeleccionada.punto1 = new Punto(e.X, e.Y);
                foreach (var item in listafigura)
                {
                    if (item == figuraSeleccionada)
                    {
                        item.punto1 = figuraSeleccionada.punto1;
                        var varX = (e.X + (figuraSeleccionada.punto2.X - figuraSeleccionadaVarXAnt));
                        var varY = (e.Y + (figuraSeleccionada.punto2.Y - figuraSeleccionadaVarYAnt));
                        item.punto2 = new Punto(varX, varY);
                        item.Dibujar(canvas);
                        this.Redibujar();
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = null;
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = this.listafigura;
                    }
                }
            }
        }

        //soltando mouse
        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            labelSeleccion.Text = String.Format($"x:{e.X}, y:{e.Y}");
            // cuando libero soltando el mouse, le doy el resto de las propiedades al objeto
            // como ser colores de linea y fondo, y ancho , tambien genero un nuevo punto para la esquina inferior derecha
            // lo dibujo en this, es decir en el form que es lo que el metodo espera en la implementacion de cada objeto
            // me lo llevo a una coleccion y asigno la coleccion a la lista visual
            
            if (figura != null && estado_canvas == Estados.Dibujando)
            {
            
                nuevafigura.colorContorno = ((frmExplorer)Application.OpenForms["frmExplorer"]).colorline.Color;
                nuevafigura.punto2 = new Punto(e.X, e.Y);
                nuevafigura.Dibujar(canvas);
                listafigura.Add(nuevafigura);
                if (Application.OpenForms["frmExplorer"] != null)
                {
                    nuevafigura.colorRelleno = ((frmExplorer)Application.OpenForms["frmExplorer"]).colorFondo.Color;
                    ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = null;
                    ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = this.listafigura;
                    ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.SelectedIndex = ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.Items.Count - 1;
                }
                
            }

            if (figuraSeleccionada != null && estado_canvas == Estados.Escalando)
            {
                figuraSeleccionada.punto2 = new Punto(e.X, e.Y);
                foreach (var item in listafigura)
                {
                    if (item == figuraSeleccionada)
                    {
                        item.punto1 = figuraSeleccionada.punto1;
                        item.punto2 = new Punto(e.X, e.Y);
                        if (e.Button == MouseButtons.Left)
                        {
                            
                            item.Dibujar(canvas);
                            ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = null;
                            ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = this.listafigura;
                            this.estado_canvas = Estados.Seleccionando;
                            this.Redibujar();
                        }
                    }
                }
                 
            }
            if (figuraSeleccionada != null && estado_canvas == Estados.Moviendo)
            {
                var figuraSeleccionadaVarXAnt = figuraSeleccionada.punto1.X;
                var figuraSeleccionadaVarYAnt = figuraSeleccionada.punto1.Y;

                foreach (var item in listafigura)
                {
                    if (item == figuraSeleccionada)
                    {
                        item.punto1 = figuraSeleccionada.punto1;
                        var varX = (e.X + (figuraSeleccionada.punto2.X - figuraSeleccionadaVarXAnt));
                        var varY = (e.Y + (figuraSeleccionada.punto2.Y - figuraSeleccionadaVarYAnt));
                        item.punto2 = new Punto(varX, varY);
                        item.Dibujar(canvas);
                        this.Redibujar(item);
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = null;
                        ((frmExplorer)Application.OpenForms["frmExplorer"]).listadeobjetos.DataSource = this.listafigura;
                        this.estado_canvas = Estados.Seleccionando;
                        this.Redibujar();
                    }
                }
            }

        }

        
        private void frmCanvas_Load(object sender, EventArgs e)
        {
           
        }

        private void canvas_Paint(object sender, PaintEventArgs e)
        {
            this.Redibujar();
        }

        public void Redibujar(Figura selectedItem)
        {
            if (selectedItem != null)
            {
                Graphics grp = canvas.CreateGraphics();
                grp.Clear(SystemColors.Control);
            
                selectedItem.Dibujar(canvas);
                grp.Dispose();
            }
        }
    }
}
