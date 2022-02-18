
using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Vendas;

namespace Vendas {
    public class DaoBD
    {
        
        public static void Main()
        {
             Maquina eric = new Maquina();
             eric.inicioDoUsuario();
        }
    }
}