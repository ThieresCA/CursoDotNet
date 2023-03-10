using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Api.Data.Context
{
    //classe que vai criar a conexão com o banco de dados, vai nos prover as tabelas em tempo de execução
    public class ContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        //criando a connection string para acessar o banco de dados
        public ApplicationContext CreateDbContext(string[] args)
        {
            // usado para criar as migrações
            var connectionString = "server=localhost;database=dbApi;Integrated Security=true;";
            var optionBuilder = new DbContextOptionsBuilder<ApplicationContext>();
            optionBuilder.UseSqlServer(connectionString);
            return new ApplicationContext(optionBuilder.Options);
        }
    }
}