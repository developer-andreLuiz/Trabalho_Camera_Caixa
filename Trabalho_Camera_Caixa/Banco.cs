using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Camera_Caixa.Models;

namespace Trabalho_Camera_Caixa
{
    class Banco
    {
       
        protected static SQLiteConnection conexao { get; } = new SQLiteConnection("Data Source = Banco.db");
        public static void AbrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }
        public class Tb_registro
        {
            /// <summary>
            /// Retorna Todos os registros da Tabela
            /// </summary>
            /// <returns></returns>
            public static List<Tb_registro_Model> RetornoCompleto()
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("select * from tb_registro order by id asc", conexao);
                SQLiteDataAdapter sQLiteDataAdapter = new SQLiteDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                sQLiteDataAdapter.Fill(dtLista);
                List<Tb_registro_Model> ltFinal = new List<Tb_registro_Model>();
                foreach (DataRow dataRow in dtLista.Rows)
                {
                    Tb_registro_Model newTb_reconhecimento_Model = new Tb_registro_Model();
                    newTb_reconhecimento_Model.id = Convert.ToInt32(dataRow["id"]);
                    newTb_reconhecimento_Model.data = Convert.ToString(dataRow["data"]);
                    newTb_reconhecimento_Model.hora = Convert.ToString(dataRow["hora"]);
                    newTb_reconhecimento_Model.codigo = Convert.ToString(dataRow["codigo"]);
                    newTb_reconhecimento_Model.nome = Convert.ToString(dataRow["nome"]);

                    ltFinal.Add(newTb_reconhecimento_Model);
                }
                return ltFinal;
            }




            /// <summary>
            /// Apaga Todos os Registros da Tabela... Muito Cuidado ao utilizar esta Função
            /// </summary>
            public static void Truncate()
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                SQLiteCommand cmd = new SQLiteCommand("delete from tb_registro", conexao);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "delete from sqlite_sequence where name='tb_registro'";
                cmd.ExecuteNonQuery();
            }
        }
    }
}
