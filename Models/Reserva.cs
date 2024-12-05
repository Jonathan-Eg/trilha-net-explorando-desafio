namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            int quantidadePessoas = 0;
            foreach(Pessoa p in hospedes)
            {
                quantidadePessoas++;
            }
           
            if (quantidadePessoas <= Suite.Capacidade)
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("A quantidade de pessoas é maior que a capacidade do quarto");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            int numeroHospedes = 0;
            foreach(Pessoa p in Hospedes)
            {
                numeroHospedes++;
            }
            return numeroHospedes;
        }

        public decimal CalcularValorDiaria()
        {       
            decimal valor = 0;

            valor = DiasReservados * Suite.ValorDiaria;

           
            if (DiasReservados >= 10)
            {
                valor = (valor / 100) * 90;
            }

            return valor;
        }
    }
}