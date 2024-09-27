
using MinimalApi.DTOs;

using MinimalApi.Dominio.Entidades;
using MinimalApi.Dominio.Interfaces;

namespace Test.Mocks;

public class VeiculoServicosMock : IVeiculoServico
{
    private static List<Veiculo>  veiculos = new List<Veiculo>(){
        new Veiculo{
            Marca = "Ferrari",
            Id = 1,
            Ano = 2022 },      
        };

    public void Apagar(Veiculo veiculo)
    {
        
        throw new NotImplementedException();
    }

    public void Atualizar(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }

    public Veiculo? BuscaPorId(int id)
    {
        return veiculos.Find(a => a.Id == id);
    }
/*
    public Veiculo Incluir(Veiculo veiculo)
    {
        veiculo.Id = veiculo.Count() + 1;
        veiculos.Add(veiculo);

        return veiculo;
    }
*/
    public Veiculo? Login(LoginDTO loginDTO)
    {
        return veiculos.Find(a => a.Ano == 20222 && a.Marca == "Ferrari");
    }

    public List<Veiculo> Todos(int? pagina)
    {
        return veiculos;
    }

    public List<Veiculo> Todos(int? pagina = 1, string? nome = null, string? marca = null)
    {
        throw new NotImplementedException();
    }

    void IVeiculoServico.Incluir(Veiculo veiculo)
    {
        throw new NotImplementedException();
    }
}