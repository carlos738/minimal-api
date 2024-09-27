using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Servicos;
using MinimalApi.Infraestrutura.Db;

namespace Test.Domain.Servicos{
[TestClass]

    public class VeiculoServiçoTest
    {
        private DbContexto CriarContextTeste(){
            var assemblyPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var path = Path.GetFullPath(Path.Combine(assemblyPath ?? "","..","..",".."));


            var builder = new ConfigurationBuilder()
                .SetBasePath(path ?? Directory.GetCurrentDirectory())
                .AddJsonFile("appsetting.json",optional: false,reloadOnChange: true)
                .AddEnvironmentVariables();

                var configuration = builder.Build();
                return new DbContexto(configuration);

        }
        [TestMethod]
        public void TestandoSalvarVeiculo(){
            // ARRANGE
            var context = CriarContextTeste();
            context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

            var veiculo = new Veiculo();
            veiculo.Nome = "Uno";
            veiculo.Marca = "Fiat";
            veiculo.Ano = 1999;

            var veiculoServico = new VeiculoServico(context);

            // ACTION
            veiculoServico.Incluir(veiculo);
            // ASSERT
            Assert.AreEqual(2,veiculoServico.Todos(2).Count());
            

        }
        [TestMethod]
        public void TestandoBuscarPorId(){
            // ARRANGE
             var context = CriarContextTeste();
        context.Database.ExecuteSqlRaw("TRUNCATE TABLE Veiculos");

        var veiculo = new Veiculo();
        veiculo.Nome = "Uno";
        veiculo.Marca = "Fiat";
        veiculo.Ano = 1999;

        var veiculoServico = new VeiculoServico(context);

        // Action
        veiculoServico.Incluir(veiculo);
        var veiculoDoBanco = veiculoServico.BuscaPorId(veiculo.Id);

        // Assert
        Assert.AreEqual(2, veiculoDoBanco?.Id);

        }
    }
}