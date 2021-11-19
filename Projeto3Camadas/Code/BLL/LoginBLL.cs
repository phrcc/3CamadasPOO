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
    class LoginBLL
    {
        //Objeto para acesso ao banco de dados
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tbl_login";

        public bool RealizarLogin(LoginDTO login)     //Requer: using System.Data;
        {
            string sql = $"select * from {tabela} where email='{login.Email}' and senha='{login.Senha}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return true;
            else
                return false;
        }

        public string RetornarSenha(LoginDTO login)    
        {
            string sql = $"select * from {tabela} where email='{login.Email}'";
            DataTable dt = conexao.ExecutarConsulta(sql);

            if (dt.Rows.Count > 0)
                return dt.Rows[0]["senha"].ToString();
            else
                return "false";
        }

    }
}