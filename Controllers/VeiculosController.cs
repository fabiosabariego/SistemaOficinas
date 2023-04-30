using Microsoft.AspNetCore.Mvc;
using SistemaOficinas.Models;

namespace SistemaOficinas.Controllers
{
    public class VeiculosController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            //Neste Ponto o Programa deverá acessar o Banco de Dados para consultar a Lista de Fabricantes Disponíveis

            //Simulando os dados do banco dos Veiculos Cadastrados
            var listaVeiculos = new List<VeiculosModel>();
            listaVeiculos.Add(new VeiculosModel
            {
                Id = 1,
                Fabricante = "Nissan",
                Modelo = "Kicks Advance 1.6 CVT",
                Cor = "Vermelho",
                Ano = 2020,
                Placa = "GTH-1025",
                Km = 12500,
                Obs = "Garantia de Fábrica"
            });
            listaVeiculos.Add(new VeiculosModel
            {
                Id = 2,
                Fabricante = "Chevrolet",
                Modelo = "Caravan Diplomata 4.1 6CC",
                Cor = "Preta",
                Ano = 1992,
                Placa = "CZI-9022",
                Km = 86200,
                Obs = "Convertido de Carburador para Injeção"
            });
            listaVeiculos.Add(new VeiculosModel
            {
                Id = 3,
                Fabricante = "VolksWagen",
                Modelo = "Jetta TSI 2.0 Turbo",
                Cor = "Branca",
                Ano = 2022,
                Placa = "GBA-1330",
                Km = 5600,
                Obs = "Tomar uidado com os Bancos, são muito claros"
            });

            return View(listaVeiculos);
        }


        [HttpGet]
        public IActionResult CadastroVeiculos()
        {
            //Aqui iremos consultar no Banco os Fabricantes cadastrados, para popular o DropDown list
            ViewBag.Fabricantes = new string[] { "Nissan", "Honda", "Chevrolet", "VolksWagen", "Ford", "Toyota", "Cherry" };
            ViewBag.Cor = new string[] { "Vermelho", "Azul", "Preto", "Cinza", "Verde", "Branco", "Amarelo", "Roxo" };
            return View(new VeiculosModel());
        }

        [HttpPost]
        public IActionResult CadastroVeiculos(VeiculosModel veiculosModel)
        {
            return View();
        }
    }
}
