    public class Moradia
    {
        public int temperatura=20;
        public bool ligado;
        public void receber_endereço(string endereço, string referencia){
            Console.WriteLine("seu endereço é: "+endereço+"sua referência é: "+referencia);
        }
        public void ligarAr(){
            ligado =true;
            if (ligado==true){
                Console.WriteLine("Ar ligado");
            }
            Console.WriteLine("digite a para aumentar a temperatura\n d para diminuir a temperatura\n c para desligar \n s para sair");
            string i="";
            while(i!="s"){
            switch(i=Convert.ToString(Console.ReadLine())){
            case "a":
                temperatura=aumentar(temperatura);
                Console.WriteLine("temperatura atual: "+temperatura);
                break;
        case "d":
            temperatura=diminuir(temperatura);
            Console.WriteLine("temperatura atual: "+temperatura);
            break;
        case "c":
            ligado=desliga(ligado);
            break;
        case "s":
            Console.WriteLine("saindo do controlhe do ar");
            break;
        default:
            Console.WriteLine("opção errada, digite outra");
            break;
            }
            }
     int aumentar(int temperatura){
            if(temperatura>29){
                Console.WriteLine("temperatura no máximo");
                return temperatura;
            }
            else{
                temperatura=temperatura+1;
                return temperatura;
            }
        }
        int diminuir(int temperatura){
            if (temperatura<17){
                Console.WriteLine("temperatura mímina");
                return temperatura;
            }
            else {
                temperatura=temperatura-1;
                return temperatura;
            }
        }
        bool desliga(bool ligado){
            Console.WriteLine("ar desligado");
            return ligado=false;
        }
    }
    }