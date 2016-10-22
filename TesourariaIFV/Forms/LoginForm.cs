using System;
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
            float widthRatio = Screen.PrimaryScreen.Bounds.Width / 1366F;
            float heightRatio = Screen.PrimaryScreen.Bounds.Height / 768F;
            SizeF scale = new SizeF(widthRatio, heightRatio);
            this.Scale(scale);
            foreach (Control control in this.Controls)
            {
                control.Font = new Font("Microsoft Sans Serif", control.Font.SizeInPoints * heightRatio * widthRatio);
            }
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
                LoginWithBinding();
                //ExecuteLogin();
            }
        }

        private void loginFormOkButton_Click(object sender, EventArgs e)
        {
            LoginWithBinding();
            //ExecuteLogin();
        }

        private void LoginWithBinding()
        {
            if (formLoginNewPwTextBox.Visible)
            {
                String login = loginFormUserTextBox.Text;
                String pw1 = formLoginNewPwTextBox.Text;
                String pw2 = formLoginNewPw2TextBox.Text;

                if (pw1.Equals(pw2))
                {
                    int pos = usuariosBindingSource.Find("Nome", login);
                    DataRowView row = (DataRowView)usuariosBindingSource.Current;

                    row["Senha"] = pw1;
                    row["FirstLogin"] = "No";
                    usuariosBindingSource.EndEdit();
                    usuariosTableAdapter.Update(this.igrejafont11DataSet);

                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    MessageBox.Show("Senhas não coincidem, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    formLoginNewPwTextBox.Text = "";
                    formLoginNewPw2TextBox.Text = "";

                }
            }
            else
            {

                String login = loginFormUserTextBox.Text;
                String pw = loginFormPasswordTextBox.Text;
                int pos = usuariosBindingSource.Find("Nome", login);
                                
                if (pos < 0) MessageBox.Show("Usuário Inválido, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    usuariosBindingSource.Position = pos;
                    DataRowView row = (DataRowView)usuariosBindingSource.Current;
                    if (row["Senha"].ToString().Equals(pw))
                    {
                        loginInfo info = new loginInfo();
                        info.SetNome(row["Nome"].ToString());
                        info.SetSenha(row["Senha"].ToString());
                        info.SetIgreja(row["Igreja"].ToString());
                        info.SetRole(row["Role"].ToString());
                        info.SetCidade(row["Cidade"].ToString());
                        info.SetEstado(row["Estado"].ToString());

                        estadosBindingSource.Position = estadosBindingSource.Find("Sigla", row["Estado"].ToString());
                        DataRowView row1 = (DataRowView)estadosBindingSource.Current;
                        info.SetRegiao(row1["Regiao"].ToString());

                        if (row["FirstLogin"].ToString().Contains("y"))
                        {
                            TrocaSenhaUser();
                        }
                        else
                        {                         
                            DialogResult = DialogResult.OK;
                            Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Senha Inválida, tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }





        private void ExecuteLogin()
        {
            loginInfo info = new loginInfo();

            if (formLoginNewPwTextBox.Visible == false)
            {
                String firstLogin = SetInfo();
                SetRegiao();

                if ((info.GetNome().ToLower() == loginFormUserTextBox.Text.ToLower()) && (info.GetSenha() == loginFormPasswordTextBox.Text))
                {
                    if (firstLogin.Contains("yes"))
                    {
                        TrocaSenhaUser();
                    }
                    else
                    {
                        DialogResult = DialogResult.OK;
                        Close();
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
                    string temp = SetInfo();
                    SetRegiao();

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

                    //info.SetLoggedToYes();

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

        private String SetInfo()
        {
            loginInfo info = new loginInfo();
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
            return firstLogin;

        }

        private void SetRegiao()
        {
            loginInfo info = new loginInfo();
            SqlDataReader usrRdr = null;
            
            SqlConnection conn = new SqlConnection(info.GetStringConnection());
            conn.Open();

            SqlCommand comm1 = new SqlCommand("SELECT * FROM Estados WHERE Sigla = @estado", conn);
            comm1.Parameters.Add("@estado", SqlDbType.VarChar).Value = info.GetEstado();
            usrRdr = comm1.ExecuteReader();

            if (usrRdr.HasRows)
            {
                while (usrRdr.Read())
                {
                    info.SetRegiao(usrRdr.GetString(2));                    
                }
            }
        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {            
            this.usuariosTableAdapter.Fill(this.igrejafont11DataSet.Usuarios);
            this.estadosTableAdapter.Fill(this.igrejafont11DataSet.Estados);
        }
    }
}
