using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MinimalApi.Dominio.Entidades;

namespace Test.Domain.Entidades
{
    public class VeiculoTest
    {
        public void VeiculoTestGetSet(){
            // Arrange
            var veiculo = new Veiculo();

            // action
            veiculo.Id =1;
            veiculo.Nome = "Ferrari";
            veiculo.Marca = "Ferrari";
            veiculo.Ano = 2022;

            // assert
            Assert.AreEqual(2,veiculo.Id);
            Assert.AreEqual("Ferrari",veiculo.Nome);
            Assert.AreEqual("Ferrari",veiculo.Marca);
            Assert.AreEqual(2022,veiculo.Ano);
        }
    }
}