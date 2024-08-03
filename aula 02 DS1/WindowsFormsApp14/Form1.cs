using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{

    public partial class Form1 : Form
    {
        string lista;
        string pula = System.Environment.NewLine;
        public Form1()
        {
            InitializeComponent();
        }

        private void nome_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cadastrar_Click(object sender, EventArgs e)
        {
            lista = "nome " + txtnome.Text + " contrato ";
            if (btnestagio.Checked)
            {
                lista += ", estagiario";
            }
            else
            {
                lista += ", efetivo";
            }


            lista += ". experiencia: ";

            if (java.Checked) lista += java.Text + ", ";
            if (pyton.Checked) lista += pyton.Text + ", ";
            if (php.Checked) lista += php.Text + ", ";
            if (sql.Checked) lista += sql.Text + ", ";
            if (typescript.Checked) lista += typescript.Text + ", ";
            if (csharp.Checked) lista += csharp.Text + ", ";

            registro.Text += lista + pula;

        }

        private void btnefetivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void habilidade_Enter(object sender, EventArgs e)
        {

        }

        private void java_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void typescript_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lista = "";
            foreach (Control x in Form1.ActiveForm.Controls)
            {
                if (x is TextBox) ((TextBox)x).Clear();
                if (x is CheckBox) ((CheckBox)x).Checked = false;

            }

            foreach (Control x in habilidade.Controls)
            {

                if (x is CheckBox) ((CheckBox)x).Checked = false;
                if (x is RadioButton) ((RadioButton)x).Checked=false;


            }
            foreach (Control x in contratos.Controls)
            {

                if (x is RadioButton) ((RadioButton)x).Checked = false;


            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
