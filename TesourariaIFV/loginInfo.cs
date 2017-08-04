using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace TesourariaIFV
{
    class loginInfo
    {
        public static string nome = "";
        public static string senha = "";
        public static string igreja = "";
        public static string role = "";
        public static string cidade = "";
        public static string estado = "";
        public static string regiao = "";


        public void SetNome(string text)
        {
            nome = text;
        }

        public void SetSenha(string text)
        {
            senha = text;
        }
        public void SetIgreja(string text)
        {
            igreja = text;
        }
        public void SetRole(string text)
        {
            role = text;
        }
        
        public void SetCidade(string text)
        {
            cidade = text;
        }
        public void SetEstado(string text)
        {
            estado = text;
        }
        public void SetRegiao(string text)
        {
            regiao = text;
        }
        public string GetNome()
        {
            return nome;
        }

        public string GetSenha()
        {
            return senha;

        }
        public string GetIgreja()
        {
            return igreja;
        }
        public string GetRole()
        {
            return role;
        }
        
        public string GetCidade()
        {
            return cidade;
        }
        public string GetEstado()
        {
            return estado;
        }
        public string GetRegiao()
        {
            return regiao;
        }
        

        public string GetStringConnection()
        {
            //return "Data Source=(LocalDB)\\v11.0;AttachDbFilename=|DataDirectory|\\TesourariaIFV.mdf;Integrated Security=True";
            return "Data Source = dbsq0004.whservidor.com; Initial Catalog = igrejafont11; Persist Security Info = True; User ID = igrejafont11; Password = Fre1del.";
        }


    }
}
