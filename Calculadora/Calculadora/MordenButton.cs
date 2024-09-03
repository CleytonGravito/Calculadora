using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace MorderButton
{
    public class MordenButtonCalculater : Button
    {
        //Campos
        private int borderSize = 0;
        private int borderRadius = 50;
        private Color borderColor = Color.Transparent;

        //Propriedades
        public int BorderSize 
        {
            get => borderSize;
            set { borderSize = value; Invalidate(); }
        }
        public int BorderRadius
        {
            get => borderRadius;
            set { borderRadius = (value <= Height)? value: Height; Invalidate(); }
        } 
        public Color BackgroundColor
        {
            get => BackColor; set { BackColor = value; }
        }
        public Color TextColor
        {
            get => ForeColor; set { ForeColor = value; }
        }

        //Construtor
        public MordenButtonCalculater() 
        {
            Size = new Size(200, 100);
            FlatAppearance.BorderSize = 0;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.DodgerBlue;
            ForeColor = Color.White;

            Resize += new EventHandler(Button_Resize);

        }

        private void Button_Resize(object sender, EventArgs e)
        {
            if (BorderRadius > Height) borderRadius = Height;
        }

        //Metodos
        private GraphicsPath GetConfigurePath(RectangleF rectangle, float radius)
        {
            GraphicsPath graphicsPath = new GraphicsPath();
            graphicsPath.StartFigure();

            // Primeiro arco (canto superior esquerdo)
            graphicsPath.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);

            // Segundo arco (canto superior direito)
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);

            // Terceiro arco (canto inferior direito)
            graphicsPath.AddArc(rectangle.Width - radius, rectangle.Height - radius, radius, radius, 0, 90);

            // Quarto arco (canto inferior esquerdo)
            graphicsPath.AddArc(rectangle.X, rectangle.Height - radius, radius, radius, 90, 90);

            graphicsPath.CloseFigure();

            return graphicsPath;
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectangleSurface = new RectangleF(0, 0, Width, Height);
            RectangleF rectangleBorder = new  RectangleF(1, 1, Width - 0.5F, Height - 1);

            if (borderRadius > 1) 
            {
                using (GraphicsPath graphicsPathSurface = GetConfigurePath(rectangleSurface, borderRadius))
                using (GraphicsPath graphicsPathBorder = GetConfigurePath(rectangleBorder, borderRadius - 1F))
                using (Pen penSurface = new Pen(Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    Region = new Region(graphicsPathSurface);
                    pevent.Graphics.DrawPath(penBorder, graphicsPathSurface);


                    if (borderSize >= 1)
                        pevent.Graphics.DrawPath(penBorder, graphicsPathBorder);
                }
            }
            else
            {
                Region = new Region(rectangleSurface);
                if (borderSize >= 1)
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        pevent.Graphics.DrawRectangle(penBorder, 0 , 0, Width -1, Height - 1);
                    }
            }
        }
        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
        private void Container_BackColorChanged(object sender, EventArgs e) 
        {
            if (DesignMode) Invalidate();
        }
    }
}
