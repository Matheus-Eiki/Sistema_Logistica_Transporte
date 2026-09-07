namespace Sistema_Logistica_Transporte
{
    class EntregadorMoto : FuncionarioTransporte
    {
        private string placa;
        private string categoriaCnh;

        public string Placa
        {
            get { return placa; }
            set { placa = value; }
        }

        public string CategoriaCnh
        {
            get { return categoriaCnh; }
            set { categoriaCnh = value; }
        }

        public EntregadorMoto(string funcionario, string registrocolaborador, string placa, string categoriaCnh)
            : base(funcionario, registrocolaborador)
        {
            Placa = placa;
            CategoriaCnh = categoriaCnh;
        }

        public override void MostrarDetalhes()
        {
            base.MostrarDetalhes();
            Console.WriteLine("Funcao: Entregador de Moto");
            Console.WriteLine("Placa da moto: " + Placa);
            Console.WriteLine("Categoria da CNH: " + CategoriaCnh);
        }
    }
}
