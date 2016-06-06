﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace TesourariaIFV.Forms
{
    public partial class LoginForm : Form
    {
        //private igrejafont11DataSet.UsuariosRow userData;

        public LoginForm()
        {
            InitializeComponent();
            versionLabel.Text = "Version: " +Application.ProductVersion;
        }


        private void TrocaSenhaUser()
        {
            label3.Visible = true;
            label4.Visible = true;
            formLoginNewPwTextBox.Visible = true;
            formLoginNewPw2TextBox.Visible = true;
            loginFormUserTextBox.ReadOnly = true;
            loginFormPasswordTextBox.ReadOnly = true;
            
        }
       
        private void loginFormCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

         private void loginFormPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Enter)
            {
                ExecuteLogin();
            }
        }

        private void ExecuteLogin()
        {
            loginInfo info = new loginInfo();

            if (formLoginNewPwTextBox.Visible == false)
            {
                igrejafont11DataSet igrejafont11DataSet = new igrejafont11DataSet();
                SqlDataReader usrRdr = null;
                String firstLogin = "no";


                SqlConnection conn = new SqlConnection(info.GetStringConnection());
                conn.Open();

                SqlCommand comm1 = new SqlCommand("SELECT * FROM usuarios WHERE Nome = @usuario", conn);
                comm1.Parameters.Add("@usuario", SqlDbType.VarChar).Value = loginFormUserTextBox.Text;
                usrRdr = comm1.ExecuteReader();

                if (usrRdr.HasRows)
                {
                    while (usrRdr.Read())
                    {
                        info.SetNome(usrRdr.GetString(0));
                        info.SetSenha(usrRdr.GetString(1));
                        info.SetIgreja(usrRdr.GetString(2));
                        info.SetRole(usrRdr.GetString(3));
                        info.SetIsLogged(usrRdr.GetString(4));
                        if (usrRdr.GetString(5) != null) firstLogin = usrRdr.GetString(5);
                        info.SetCidade(usrRdr.GetString(6));
                        info.SetEstado(usrRdr.GetString(7));
                    }
                }

                if ((info.GetNome().ToLower() == loginFormUserTextBox.Text.ToLower()) && (info.GetSenha() == loginFormPasswordTextBox.Text))
                {
                    if (firstLogin.Contains("yes"))
                    {
                        TrocaSenhaUser();
                    }
                    else
                    {
                        //if (info.GetIsLogged() == "yes")
                        //{
                        //    MessageBox.Show("Usuário já está logado. Tente com outro usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //}
                        //else
                        //{
                        info.SetLoggedToYes();
                        DialogResult = DialogResult.OK;
                        Close();
                        //}
                    }
                }
                else
                {
                    MessageBox.Show("Senha ou usuário inválidos, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loginFormPasswordTextBox.Text = "";
                }
            }
            else
            {
                if (formLoginNewPwTextBox.Text == formLoginNewPw2TextBox.Text)
                {
                    SqlConnection conn = new SqlConnection(info.GetStringConnection());
                    conn.Open();

                    SqlCommand comm1 = new SqlCommand("update Usuarios set Senha=@Senha where nome=@Nome", conn);
                    comm1.Parameters.Add("@Senha", SqlDbType.VarChar).Value = formLoginNewPwTextBox.Text;
                    comm1.Parameters.Add("@Nome", SqlDbType.VarChar).Value = loginFormUserTextBox.Text;

                    comm1.ExecuteReader();

                    SqlConnection conn1 = new SqlConnection(info.GetStringConnection());
                    conn1.Open();

                    SqlCommand comm2 = new SqlCommand("update Usuarios set FirstLogin=@No where nome=@Nome", conn1);
                    comm2.Parameters.Add("@No", SqlDbType.VarChar).Value = "No";
                    comm2.Parameters.Add("@Nome", SqlDbType.VarChar).Value = loginFormUserTextBox.Text;

                    comm2.ExecuteReader();

                    MessageBox.Show("Senha alterada com sucesso!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    info.SetLoggedToYes();

                    DialogResult = DialogResult.OK;
                    Close();
                }

                else
                {
                    MessageBox.Show("As senhas digitadas não são idênticas!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    formLoginNewPwTextBox.Text = "";
                    formLoginNewPw2TextBox.Text = "";
                }
            }

        }

        private void loginFormOkButton_Click(object sender, EventArgs e)
        {
            ExecuteLogin();

            //loginInfo info = new loginInfo();
            //if (formLoginNewPwTextBox.Visible == false)
            //{
            //    igrejafont11DataSet igrejafont11DataSet = new igrejafont11DataSet();
            //    SqlDataReader usrRdr = null;
            //    String firstLogin = "no";

            //    SqlConnection conn = new SqlConnection(info.GetStringConnection());
            //    conn.Open();

            //    SqlCommand comm1 = new SqlCommand("SELECT * FROM usuarios WHERE Nome = @usuario", conn);
            //    comm1.Parameters.Add("@usuario", SqlDbType.VarChar).Value = loginFormUserTextBox.Text;
            //    usrRdr = comm1.ExecuteReader();

            //    if (usrRdr.HasRows)
            //    {
            //        while (usrRdr.Read())
            //        {
            //            info.SetNome(usrRdr.GetString(0));
            //            info.SetSenha(usrRdr.GetString(1));
            //            info.SetIgreja(usrRdr.GetString(2));
            //            info.SetRole(usrRdr.GetString(3));
            //            info.SetIsLogged(usrRdr.GetString(4));
            //            if (usrRdr.GetString(5) != null) firstLogin = usrRdr.GetString(5);
            //            info.SetCidade(usrRdr.GetString(6));
            //            info.SetEstado(usrRdr.GetString(7));
            //        }
            //    }

            //    if ((info.GetNome().ToLower() == loginFormUserTextBox.Text.ToLower()) && (info.GetSenha() == loginFormPasswordTextBox.Text))
            //    {
            //        if (firstLogin.Contains("yes"))
            //        {
            //            TrocaSenhaUser();
            //        }

            //        else
            //        {
            //            if (info.GetIsLogged() == "yes")
            //            {
            //                MessageBox.Show("Usuário já está logado. Tente com outro usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //            else
            //            {
            //                info.SetLoggedToYes();
            //                DialogResult = DialogResult.OK;
            //                Close();
            //            }
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("Senha ou usuário inválidos, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        loginFormPasswordTextBox.Text = "";
            //    }
            //}

            //else
            // {
            //    if (formLoginNewPwTextBox.Text == formLoginNewPw2TextBox.Text)
            //    {
            //        SqlConnection conn = new SqlConnection(info.GetStringConnection());
            //        conn.Open();

            //        SqlCommand comm1 = new SqlCommand("update Usuarios set Senha=@Senha where nome=@Nome", conn);
            //        comm1.Parameters.Add("@Senha", SqlDbType.VarChar).Value = formLoginNewPwTextBox.Text;
            //        comm1.Parameters.Add("@Nome", SqlDbType.VarChar).Value = loginFormUserTextBox.Text;

            //        comm1.ExecuteReader();

            //        SqlConnection conn1 = new SqlConnection(info.GetStringConnection());
            //        conn1.Open();

            //        SqlCommand comm2 = new SqlCommand("update Usuarios set FirstLogin=@No where nome=@Nome", conn1);
            //        comm2.Parameters.Add("@No", SqlDbType.VarChar).Value = "No";
            //        comm2.Parameters.Add("@Nome", SqlDbType.VarChar).Value = loginFormUserTextBox.Text;

            //        comm2.ExecuteReader();

            //        MessageBox.Show("Senha alterada com sucesso!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        info.SetLoggedToYes();

            //        DialogResult = DialogResult.OK;
            //        Close();
            //    }

            //    else
            //    {
            //        MessageBox.Show("As senhas digitadas não são idênticas!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        formLoginNewPwTextBox.Text = "";
            //        formLoginNewPw2TextBox.Text = "";
            //    }
            //}
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'igrejafont11DataSet.Usuarios' table. You can move, or remove it, as needed.
            //this.usuariosTableAdapter.Fill(this.igrejafont11DataSet.Usuarios);

        }
    }
}
