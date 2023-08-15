using ClinicaOdontologica.Entidades;
using ClinicaOdontologica.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaOdontologica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt_agendar_Click(object sender, EventArgs e)
        {
            Cadastro a = new Cadastro();

            a.Nome = tx_nome.Text;
            a.Email = tx_email.Text;
            a.Telefone = tx_telefone.Text;
            

            Tratamento tratamento = new Tratamento();
            tratamento.Show();
        }
    }
}
