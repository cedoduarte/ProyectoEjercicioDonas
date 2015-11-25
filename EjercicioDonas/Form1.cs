using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioDonas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            spinnerNumeroDeDonas.Minimum = 1;
            spinnerNumeroDeDonas.Maximum = 1000;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int count = (int) spinnerNumeroDeDonas.Value;
            Color colorPintura = Color.Blue;
            SolidBrush linea = null;
            Graphics g = CreateGraphics();
            int x = 0;
            int y = 0;
            int w = 0;
            int h = 0;
            var ran = new Random();
            g.Clear(Color.Gray);
            Color[] colores = { Color.Red, Color.White, Color.Purple,
                              Color.Yellow, Color.Green, Color.LightBlue,
                              Color.LightCyan, Color.LightPink,
                              Color.Pink, Color.Salmon, Color.SteelBlue};
            int[] tamanyos = { 50, 60, 70, 80, 90, 100 };
            for (int ix = 0; ix < count; ++ix)
            {
                x = ran.Next(0, Width);
                y = ran.Next(0, Height);
                w = tamanyos[ran.Next(0, tamanyos.Length - 1)];
                h = tamanyos[ran.Next(0, tamanyos.Length - 1)];
                Color c = colores[ran.Next(0, colores.Length)];
                linea = new System.Drawing.SolidBrush(c);
                g.FillEllipse(linea, x, y, w, h);
                c = colores[ran.Next(0, colores.Length)];
                linea = new System.Drawing.SolidBrush(Color.White);
                g.FillEllipse(linea, x+5, y+5, w-10, h-10);                               
            }
        }
    }
}
