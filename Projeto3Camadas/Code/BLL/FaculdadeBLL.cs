using Projeto3Camadas.Code.DAL;
using Projeto3Camadas.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto3Camadas.Code.BLL
{
    class FaculdadeBLL
    {

        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_faculdade";
        public void Inserir(FaculdadeDTO facudto) 
        {

            string inserir = $"insert into {tabela} values(null,'{facudto.Nome}','{facudto.Nota}')";
            conexao.ExecutarComando(inserir);

        }
        public DataTable Listar()     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} order by id;";
            return conexao.ExecutarConsulta(sql);
        }

        public void Editar(FaculdadeDTO facudto)
        {
            string alterar = $"update {tabela} set medicamento = '{facudto.Nome}', composicao = '{facudto.Nota}' where id = '{facudto.Id}';";
            conexao.ExecutarComando(alterar);
        }


        public void Excluir(FaculdadeDTO facudto)
        {
            string excluir = $"delete from {tabela} where id = '{facudto.Id}';";
            conexao.ExecutarComando(excluir);
        }

    }
}
