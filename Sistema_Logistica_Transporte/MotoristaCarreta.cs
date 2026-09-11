using System;

namespace Sistema_Logistica_Transporte
{

    class MotoristaCarreta : FuncionarioTransporte
    {
        public string CategoriaCNH { get; set; }
        public string PlacaVeiculo { get; set; }
        public double CapacidadeCargaTon { get; set; }

        public MotoristaCarreta(string Funcionario, string RegistroColaborador, string categoriaCNH, string placaVeiculo, double capacidadeCargaTon)
            : base(Funcionario, RegistroColaborador)
        {
            CategoriaCNH = categoriaCNH;
            PlacaVeiculo = placaVeiculo;
            CapacidadeCargaTon = capacidadeCargaTon;
        }

        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine($"Categoria CNH: {CategoriaCNH}");
            Console.WriteLine($"Placa do Veículo: {PlacaVeiculo}");
            Console.WriteLine($"Capacidade de Carga: {CapacidadeCargaTon} toneladas");
            Console.WriteLine("---------------------------------------------");
        }
    }
}