using Projeto3Camadas.Code.BLL;
using Projeto3Camadas.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto3Camadas.UI
{
    public partial class Login : Form
    {

        LoginBLL loginBBL = new LoginBLL();
        LoginDTO loginDTO = new LoginDTO();
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            loginDTO.Email = txt_email.Text;
            loginDTO.Senha = txt_senha.Text;


            //Chamada do método para verificar o acesso: 
            if (loginBBL.RealizarLogin(loginDTO) == true)
            {

                Faculdade frm_faculdade = new Faculdade();
                frm_faculdade.ShowDialog();
            }
            else
            {
                //Mensagem de sucesso
                MessageBox.Show("Verifique e-mail e senha.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("phrcc102030@gmail.com", "wcujnizbbbfbizjv"),
                EnableSsl = true
            };


            loginDTO.Email = txt_email.Text;
            string senha = loginBBL.RetornarSenha(loginDTO);


            //TODO: Altere para enviar o e-mail e senha recuperados do banco
            //Send ("quem envia", "para quem envia", "assunto", "corpo");
            client.Send("michellebelli@cotemig.com.br", $"{txt_email.Text}", "Redefinição de Senha", $"Seu e-mail é {txt_email.Text} com senha {senha}");


            MessageBox.Show("E-mail e senha enviados com sucesso.", "E-mail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
