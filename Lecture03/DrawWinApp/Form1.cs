using System.Drawing;
using System.Windows.Forms;
using Base.WinForms;
using BaseLib;
using ShapeLib;
using static BaseLib.MathFunctions;

namespace DrawWinApp
{
    public partial class Form1 : Form
    {
        Shape _Shape;
        
        public Form1()
        {
            InitializeComponent();

            drawControl.MinX = -1;
            drawControl.MaxX = 1;
            drawControl.MinY = -1;
            drawControl.MaxY = 1;

            drawControl.DrawEvent += DrawControl_DrawEvent;

            //_Shape = new Circle
            //{
            //    Center = vec2(0,0),
            //    Radius = 0.25
            //};

            _Shape = new Triangle(
                vec2(-0.15, -0.25), 
                vec2(-0.25, 0.25), 
                vec2(0.25, 0.25) )
            {
                Center = vec2(0, 0),
            };

        }

        void DrawControl_DrawEvent(object sender, Base.WinForms.DrawControl.DrawEventArgs e)
        {
            DrawContext dc = e.DrawContext;

            //dc.PointSize = 37;
            //dc.FillColor = Color.Red;

            //dc.DrawPoints(vec2(0,0), vec2(0.5, -0.5));

            //dc.LineWidth = 5;
            //dc.LineColor = Color.Blue;


            //dc.DrawLines(vec2(0, 0), vec2(0.5, -0.5));

            dc.LineColor = Color.BlueViolet;
            dc.FillColor = Color.BlueViolet;
            dc.LineWidth = 5;
            _Shape.Draw(dc);

            dc.PointSize = 37;
            dc.FillColor = Color.Red;
            dc.DrawPoints(vec2(0, 0), vec2(0.5, -0.5));
        }
    }
}
