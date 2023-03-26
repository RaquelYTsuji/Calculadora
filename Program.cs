class Calculadora{
    public static double Operacao (double num1, double num2, string operacao){
        double resultado = double.NaN; //not a number
        
        switch(operacao){
        case "a":
        resultado = num1+num2;
        break;
    
        case "b":
        resultado = num1-num2;
        break;
    
        case "c":
        resultado = num1*num2;;
        break;
    
        case "d":
        while (num2==0){
           Console.WriteLine("\nErro - divisão por 0");
           Console.Write("Digite o 2º número novamente e pressione enter: ");
           num2 = Convert.ToDouble(Console.ReadLine());
        }
        resultado = num1/num2;
        break;
    
        default:
        Console.WriteLine("Operação inválida");
        break;
        }
        return resultado;
    }
}

class Programa{
    static void Main(string[] args){
        bool fim = false;
        string n1="";
        string n2="";
        double num1=0;
        double num2=0;
        double resultado=0;
        string operacao;

        Console.WriteLine("Calculadora em C#");
        Console.WriteLine("-----------------\n");

        while(!fim){
            Console.Write("Digite o 1º número e pressione enter: ");
            n1 = Console.ReadLine();
            
            while(!double.TryParse(n1, out num1)){
                Console.Write("Número Inválido");
                Console.Write("\nDigite o 1º número novamente e pressione enter: ");
                n1 = Console.ReadLine();
            }

            Console.Write("Digite o 2º número e pressione enter: ");
            n2 = Console.ReadLine();
            
            while(!double.TryParse(n2, out num2)){
                Console.Write("Número Inválido");
                Console.Write("\nDigite o 2º número novamente e pressione enter: ");
                n2 = Console.ReadLine();
            }

            Console.WriteLine("\nEscolha uma das opções da lista: ");
            Console.WriteLine("\ta - Soma: ");
            Console.WriteLine("\tb - Subtração: ");
            Console.WriteLine("\tc - Multiplicação: ");
            Console.WriteLine("\td - Divisão: ");
            Console.Write("\nDigite sua opção: ");
            operacao = Console.ReadLine();

            try{
                resultado = Calculadora.Operacao(num1, num2, operacao);

                if (double.IsNaN(resultado)){
                    Console.WriteLine("Esta operação resultará em um erro matemático\n");
                }else{
                    Console.WriteLine("Seu resultado é: {0:0.####}\n", resultado);
                }
            }catch (Exception e){
                Console.WriteLine("Ocorreu uma exceção.\n-Detalhes: " + e.Message);
            }

            Console.WriteLine("Digite 'n' para fechar a aplicação ou qualquer tecla para continuar: ");
            if (Console.ReadLine() == "n"){
                fim=true;
                Console.WriteLine("\n");
            }
        }
        return;
    }
}