void menu(){
    Console.WriteLine("bem vindo ao seu assistente de imóveis");
    string nome="";
    int i=0;
Console.WriteLine("digite seu nome");
Console.WriteLine("digite s para saír");
nome=Console.ReadLine();
while(nome!="s"){
Console.WriteLine(nome+", digite c: para casa \n a: para apartamento \n e s para saír.");
switch(nome=Console.ReadLine()){
    case "c":
        casa();
    break;
    case "a":
apartamento();
    break;
    case "s":
    Console.WriteLine("saindo do programa");
    break;
    default:
        Console.WriteLine("opção errada, por favor digite outra.");
        break;
}
}
}
void casa(){
    Console.WriteLine("bem vindo a sua casa");
    string i="";
    Casa casa=new Casa();
while(i!="s"){
Console.WriteLine("digite ligar, para ligar seu ar");
Console.WriteLine("digite mostrar para ver seu endereço e sua referência");
Console.WriteLine("digite cão: para  alimentar seu cachorro");
Console.WriteLine("digite s: para saír");
switch(i=Convert.ToString(Console.ReadLine())){
    case "ligar":
    casa.ligarAr();
    break;
    case "mostrar":
    casa.receber_endereço("rua: chão batido, número: 1010","mercado teste");
    break;
    case "cão":
    casa.tratar();
        break;
        case "s":
            Console.WriteLine("voltando ao menú principal");
            menu();
            break;
        default:
            Console.WriteLine("opção errada.");
            break;
}
}

}
void apartamento(){
 Apartamento apt=new Apartamento();
Console.WriteLine("bem vindo ao seu apartamento");
string i="";
while(i!="s"){
Console.WriteLine("digite ligar, para ligar seu ar");
Console.WriteLine("digite mostrar para ver seu endereço e sua referência");
Console.WriteLine("digite elevador: para chamar seu elevador");
Console.WriteLine("digite s: para saír");
switch(i=Convert.ToString(Console.ReadLine())){
    case "ligar":
    apt.ligarAr();
    break;
    case "mostrar":
    apt.receber_endereço("rua: chão batido, número: 1010, bloco: b","mercado teste");
    break;
    case "elevador":
        apt.elevador();
        break;
        case "s":
            Console.WriteLine("voltando ao menú principal");
            menu();
            break;
        default:
            Console.WriteLine("opção errada.");
            break;
}
}
}
menu();