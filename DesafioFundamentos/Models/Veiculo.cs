namespace DesafioFundamentos;
{
public class Veiculo
    {
        public string Placa { get; set; }
        
        public Veiculo(string placa)
        {
            this.Placa = placa;
        }

        public override string ToString()
        {
            return $"{this.Placa}";
        }
    }
}
