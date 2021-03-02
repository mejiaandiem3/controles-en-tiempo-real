using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controles_en_tiempo_real
{
    public partial class Form1 : Form
    {
        Button boton;

        public Form1()
        {
            InitializeComponent();
            int posicion = 0;
            int indice = 0;

            while (indice < 6)
            {
                boton = new Button();
                //localizacion, nombre y el tamaño del boton
                boton.Location = new Point(posicion, posicion);
                boton.Name = "Boton a" + indice;
                boton.Size = new Size(40, 40);
                boton.Text = indice.ToString();

                boton.Click += new EventHandler(MyEventoBoton_click);
                this.Controls.Add(boton);

                indice++;
                posicion += 60;
            }


        }


        private void MyEventoBoton_click(object sender, EventArgs e)
        {

            Button myboton = sender as Button;
            MessageBox.Show("Soy el boton" + myboton.Name);
            myboton.Text = "Click" +myboton.Text;

        }

        

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    
}
