using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;

namespace atvIII.Models
{
    public class Databasefaleconosco
    {
        private const string _fcData = "Database=falecnsc; Data Source=localhost; User Id=root;";
      
        public void Insert (RegistroDoassunto a){
             MySqlConnection conexao = new MySqlConnection(_fcData);
             
            conexao.Open();
           
         string sql = "INSERT INTO Assuntos (nome, telefone, Assunto, email) VALUES (@Nome, @Telefone, @Assunto, @email)";
         
         MySqlCommand com = new MySqlCommand(sql, conexao);
         
         com.Parameters.AddWithValue("@Nome",a.Nome);
         com.Parameters.AddWithValue("@Telefone",a.Telefone);
         com.Parameters.AddWithValue("@Assunto",a.Assunto);
         com.Parameters.AddWithValue("@email", a.email);
          
          com.ExecuteNonQuery();
          conexao.Close();
        }
    }
}