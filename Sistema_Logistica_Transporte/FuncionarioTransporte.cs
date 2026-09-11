namespace Sistema_Logistica_Transporte
{
    class FuncionarioTransporte
    {
        private string funcionario;
        private string registrocolaborador;
        public string Funcionario
        {
            get { return funcionario; }
            set { funcionario = value; }
        }
        public string RegistroColaborador
        {
            get { return registrocolaborador; }
            set { registrocolaborador = value; }
        }
        public FuncionarioTransporte(string funcionario, string registrocolaborador)

        {
            Funcionario = funcionario;
            RegistroColaborador = registrocolaborador;
        }
        public virtual void MostrarDetalhes()
        {
            Console.WriteLine("Funcionario: " + Funcionario);
            Console.WriteLine("Registro do Colaborador: " + RegistroColaborador);
        }
    }
}
