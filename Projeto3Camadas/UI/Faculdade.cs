using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3Camadas
{
    public partial class Faculdade : Form
    {

        FaculdadeBLL facubll = new FaculdadeBLL();
        FaculdadeDTO facudto = new FaculdadeDTO(); 

        public Faculdade()
        {
            InitializeComponent();
        }

        private void Faculdade_Load(object sender, EventArgs e)
        {

        }

        private void btn_cadastrar_Click(object sender, EventArgs e)
        {
            facudto.Nome = txt_nome.Text;
            facudto.Nota = txt_nota.Text;

            facubll.Inserir(facudto);

            MessageBox.Show("Cadastrado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

          
            txt_id.Clear();
            txt_nome.Clear();
            txt_nota.Clear();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {

           
            facudto.Id = int.Parse(txt_id.Text);
            facudto.Nome = txt_nome.Text;
            facudto.Nota = txt_nota.Text;

            
            facubll.Editar(facudto);

           
            MessageBox.Show("Alterado com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            facubll.Listar();

            
            txt_id.Clear();
            txt_nome.Clear();
            txt_nota.Clear();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            
            facudto.Id = int.Parse(txt_id.Text);

            
            facubll.Excluir(facudto);

            
            MessageBox.Show("Excluido com sucesso!", "Medicamento", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            facubll.Listar();

            
            txt_id.Clear();
            txt_nome.Clear();
            txt_nota.Clear();
        }

        private void Frm_Medicamentos_Load(object sender, EventArgs e)
        {
            dgv_tabela.DataSource = facubll.Listar();
        }

        private void dgvMedicamentos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
       
            txt_id.Text = dgv_tabela.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_tabela.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_nota.Text = dgv_tabela.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void dgv_tabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_id.Text = dgv_tabela.Rows[e.RowIndex].Cells[0].Value.ToString();
            txt_nome.Text = dgv_tabela.Rows[e.RowIndex].Cells[1].Value.ToString();
            txt_nota.Text = dgv_tabela.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
    }
}
