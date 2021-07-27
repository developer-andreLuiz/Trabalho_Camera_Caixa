using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trabalho_Camera_Caixa.Models;

namespace Trabalho_Camera_Caixa
{
    class Banco
    {
        #region Caminho Banco
        public static string caminhoLocal = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = C:\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";
        public static string caminhoRede = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source =  \\MAINSERVIDOR-PC\Arquivos Sistema Valendo\Banco_Dados\Soft.mdb;Jet OLEDB:Database Password = 'Soft';";
        #endregion
        public static OleDbConnection conexao { get; } = new OleDbConnection(caminhoRede);
        public static void AbrirConexao()
        {
            if (conexao.State == ConnectionState.Closed)
            {
                conexao.Open();
            }
        }

        public class Tb_itens_pedidos
        {
            public static List<Tb_itens_pedidos_Model> RetornoCompletoData(double dia)
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                OleDbCommand cmd = new OleDbCommand("select * from itens_pedidos where datal =" + dia + " order by Controle asc", conexao);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                dataAdapter.Fill(dtLista);
                List<Tb_itens_pedidos_Model> ltFinal = new List<Tb_itens_pedidos_Model>();
                foreach (DataRow dataRow in dtLista.Rows)
                {
                    Tb_itens_pedidos_Model newObj_Model = new Tb_itens_pedidos_Model();

                    object Codigo_funcionario = dataRow["Codigo_funcionario"];
                    object datal = dataRow["datal"];
                    object Hora = dataRow["Hora"];
                    object codigo = dataRow["codigo"];

                    if (string.IsNullOrEmpty(Codigo_funcionario.ToString()) == false)
                    {
                        newObj_Model.Codigo_funcionario = Convert.ToString(Codigo_funcionario);
                    }
                    if (string.IsNullOrEmpty(datal.ToString()) == false)
                    {
                        newObj_Model.datal = Convert.ToString(datal);
                    }
                    if (string.IsNullOrEmpty(Hora.ToString()) == false)
                    {
                        //30/30/2000 11:11:11
                        

                        newObj_Model.Hora = Hora.ToString().Substring(11);
                    }
                    if (string.IsNullOrEmpty(codigo.ToString()) == false)
                    {
                        newObj_Model.codigo = Convert.ToString(codigo);
                    }

                    ltFinal.Add(newObj_Model);
                }
                return ltFinal;
            }

        }
        public class Tb_Funcionario
        {
            public static List<Tb_Funcionario_Model> RetornoCompletoHabilitado()
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                OleDbCommand cmd = new OleDbCommand("select * from Funcionario where Habilitado = true order by Nome asc", conexao);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                dataAdapter.Fill(dtLista);
                List<Tb_Funcionario_Model> ltFinal = new List<Tb_Funcionario_Model>();
                foreach (DataRow dataRow in dtLista.Rows)
                {
                    Tb_Funcionario_Model newObj_Model = new Tb_Funcionario_Model();

                    object Codigo= dataRow["Codigo"];
                    object Nome = dataRow["Nome"];
                 

                    if (string.IsNullOrEmpty(Codigo.ToString()) == false)
                    {
                        newObj_Model.Codigo = Convert.ToString(Codigo);
                    }
                    if (string.IsNullOrEmpty(Nome.ToString()) == false)
                    {
                        newObj_Model.Nome = Convert.ToString(Nome);
                    }
                 

                    ltFinal.Add(newObj_Model);
                }
                return ltFinal;
            }

        }
        public class Tb_Produtos
        {
            public static List<Tb_Produtos_Model> RetornoCompleto()
            {
                if (conexao.State == ConnectionState.Closed)
                {
                    conexao.Open();
                }
                OleDbCommand cmd = new OleDbCommand("select * from Produtos order by Codigo asc", conexao);
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmd);
                DataTable dtLista = new DataTable();
                dataAdapter.Fill(dtLista);
                List<Tb_Produtos_Model> ltFinal = new List<Tb_Produtos_Model>();
                foreach (DataRow dataRow in dtLista.Rows)
                {
                    Tb_Produtos_Model newObj_Model = new Tb_Produtos_Model();

                    object Codigo = dataRow["Codigo"];
                    object nome_camera = dataRow["nome_camera"];

                    if (string.IsNullOrEmpty(Codigo.ToString()) == false)
                    {
                        newObj_Model.Codigo = Convert.ToString(Codigo);
                    }
                    if (string.IsNullOrEmpty(nome_camera.ToString()) == false)
                    {
                        newObj_Model.nome_camera = Convert.ToString(nome_camera);
                    }
                    ltFinal.Add(newObj_Model);
                }
                return ltFinal;
            }
        }


    }  
}
