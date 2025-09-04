namespace Automove{
    public class Carro{
        public string Marca{get; set;}
        public string Modelo{get; set;}
        public string Motor {get; set;}
        public int Quilometro{get; set;}//Exemplo: O carro rodou 50 km hoje.
        public int Quilometragem {get; set;}// valor total desde da fabricação

        public Carro(){}

        public Carro(string marca, string modelo, string motor, int quilometro,int quilometragem){
            this.Marca = marca;
            this.Modelo = modelo;
            this.Motor = motor;
            this.Quilometro = quilometro;
            this.Quilometragem = quilometragem;
        }

        public double KmPercorrido(){
            
            return Quilometragem += Quilometro;
        }

        public override string ToString(){
            return $"Marca do veiculo: {Marca}\n"+
            $"Modelo do veiculo: {Modelo}\n"+
            $"Potencia do motor: {Motor}\n"+
            $"Quilometro rodade: {Quilometro}\n"+
            $"Qulimetragem desde a fabricação{Quilometragem}"; 
        }
    }    
}