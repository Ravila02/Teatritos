using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Teatritos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox43_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox42_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox44_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Array de nombres de los GroupBox que deseas modificar
            string[] nombresGroupBox = { "groupBox2", "groupBox3", "groupBox5", "groupBox6", "groupBox8", "groupBox9", "groupBox1", "groupBox82", "groupBox105" };

            // Iterar sobre cada nombre de GroupBox
            foreach (string nombreGroupBox in nombresGroupBox)
            {
                // Buscar el GroupBox por su nombre
                GroupBox groupBox = Controls.Find(nombreGroupBox, true).FirstOrDefault() as GroupBox;

                // Verificar si el GroupBox se encontró
                if (groupBox != null)
                {
                    // Iterar sobre los controles dentro del GroupBox
                    foreach (Control control in groupBox.Controls)
                    {
                        // Verificar si el control es un PictureBox
                        if (control is PictureBox)
                        {
                            // Cambiar el color de fondo del PictureBox
                            control.BackColor = Color.Black; // Puedes cambiar el color aquí
                        }
                    }
                }
            }

        }


        private void CambiarColorFondo(PictureBox pictureBox)
        {
            if (pictureBox.BackColor == Color.Black) // Si no está seleccionado, lo seleccionamos
            {
                pictureBox.BackColor = Color.Red; // Cambiar color a rojo para indicar que está seleccionado
                Cursor = Cursors.Hand; // Cambiar el cursor a mano para indicar que se puede hacer clic
            }
            else // Si está seleccionado, lo deseleccionamos
            {
                pictureBox.BackColor = Color.Black; // Cambiar color a negro para indicar que no está seleccionado
                Cursor = Cursors.Default; // Cambiar el cursor a predeterminado
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void cmdReservar_Click(object sender, EventArgs e)
        {
            frmReserva formReserva = new frmReserva();
            if (formReserva.ShowDialog() == DialogResult.OK)
            {
                // Aquí puedes agregar la lógica para procesar la reserva si es necesario
                // Cambia el color del PictureBox seleccionado a verde
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is PictureBox)
                    {
                        PictureBox pictureBox = control as PictureBox;
                        if (pictureBox.BackColor == Color.Red)
                        {
                            pictureBox.BackColor = Color.Green;
                        }
                    }
                }
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox36_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox39_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox34_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox41_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox33_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox62_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox70_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox78_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox77_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox68_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox76_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox79_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox71_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox66_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox74_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox81_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox73_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox64_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox72_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox80_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox75_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox49_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox51_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox53_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox52_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox55_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox57_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox56_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox58_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox59_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox61_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox60_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox63_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox65_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox69_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox67_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox83_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox91_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox99_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox98_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox90_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox89_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox97_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox100_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox92_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox84_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox87_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox95_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox102_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox94_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox86_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox88_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox96_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox101_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox93_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox85_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox123_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox131_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox139_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox129_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox137_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox140_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox142_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox135_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox127_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox125_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox103_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox111_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox119_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox118_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox110_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox109_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox117_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox120_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox112_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox104_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox107_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox115_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox122_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox114_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }

        private void pictureBox106_Click(object sender, EventArgs e)
        {

            PictureBox pictureBox = sender as PictureBox;
            CambiarColorFondo(pictureBox);
        }
    }
}
