using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cet58.ExercicioBalao
{
    public partial class FormBalao : Form
    {
        public Balao Balao1 { get; set; }
        public FormBalao()
        {
            InitializeComponent();
            Balao1 = new Balao();

            btn_StartStop.Enabled = true;
            groupBox_Balao.Enabled = false;
        }

        private void btn_StartStop_Click(object sender, EventArgs e)
        {
            if (Balao1.Estado)
            {
                Balao1.Stop();
                groupBox_Balao.Enabled = true;
            }
            else
            {
                Balao1.Start();
                groupBox_Balao.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_Cores.SelectedItem.ToString() == "Rosa")
            {
                pb_Balao.Image = Cet58.ExercicioBalao.Properties.Resources.ROSA;
            }

            if (comboBox_Cores.SelectedItem.ToString() == "Violeta")
            {
                pb_Balao.Image = Cet58.ExercicioBalao.Properties.Resources.VIOLETA;
            }

            if (comboBox_Cores.SelectedItem.ToString() == "Azul")
            {
                pb_Balao.Image = Cet58.ExercicioBalao.Properties.Resources.AZUL;
            }

            if (comboBox_Cores.SelectedItem.ToString() == "Amarelo")
            {
                pb_Balao.Image = Cet58.ExercicioBalao.Properties.Resources.AMARELO;
            }
        }

        private void btn_ParaCima_Click(object sender, EventArgs e)
        {
            Balao1.Altura++;
            pb_Balao.Top = pb_Balao.Top - 1;
        }

        private void btn_ParaBaixo_Click(object sender, EventArgs e)
        {
            Balao1.Altura--;
            pb_Balao.Top = pb_Balao.Top + 1;
        }

        private void btn_ParaDireita_Click(object sender, EventArgs e)
        {
            Balao1.Direcao++;
            pb_Balao.Left = pb_Balao.Left + 1;
        }

        private void btn_ParaEsquerda_Click(object sender, EventArgs e)
        {
            Balao1.Direcao++;
            pb_Balao.Left = pb_Balao.Left - 1;
        }

    }
}
