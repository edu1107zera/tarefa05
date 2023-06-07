using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string  nome1;
            string nome2;
            string endereco;
            string cidade;
            string bairro;
            string estado;
          
            string cupom;
            string sesim;

            int vpassa;
            int vatual;

           
            
            
            
            Console.WriteLine("\nBem-vindo a empresa de viagens do Eduzito");
            Console.Write("Por favor digite seu primeiro nome:");
            nome1 = Console.ReadLine();

            Console.Write("Digite seu segundo nome:");
            nome2 = Console.ReadLine();

            Console.WriteLine( "\n");
            Console.WriteLine($"Ola Sr.(a) {nome1+" "+ nome2} , vamos continuar seu cadastro...");
            Console.WriteLine("Por favor para seguir com o cadastro responda as questoes abaixo:");
            Console.WriteLine("-----------------------------");
            Console.Write("Digite seu endereço(ex:(rua....):");
          endereco = Console.ReadLine();

            Console.WriteLine(  "\n");

            Console.Write("Digite seu bairro:");
          bairro =  Console.ReadLine();

            Console.WriteLine( "\n");

            Console.Write("Digite sua cidade:");
          cidade =  Console.ReadLine();

            Console.WriteLine( "\n");
          
            Console.Write("Digite seu estado:");
          estado =   Console.ReadLine();

           
            Console.WriteLine("\n");
            
            Console.WriteLine("Perfil de cadastro:");
            Console.WriteLine($" O Sr.{nome2} mora na cidade de {cidade}-{estado},no endereço {endereco},localizado no bairro {bairro}"  );
            
            Console.WriteLine("\n");

            Console.WriteLine($"OTIMO! seja bem-vindo Sr.(a){nome2}...para proceguir informe as questoes solicitadas abaixo:");
            Console.Write("Informe o numero de viagens realizadas ano passado...(por nossa agencia):");
           vpassa = Int32.Parse(Console.ReadLine());
           
            Console.Write("Informe o numero de viagens planejadas para esse ano...(por nossa agencia):");
           vatual = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\n");
            Console.WriteLine($"Total de viagens contabilizadas dentro dos 2 anos(passado e atual): {vpassa+vatual} viagens");
            Console.WriteLine($"!!!Faltam {10 - (vpassa+vatual)} viagens para completar 10 viagens realizadas!!!!");
            Console.WriteLine($"Media de viagens realizada:{(vpassa+vatual)/2} viagens.");
            Console.WriteLine($"Intervalo de tempo entre cada viagem:{12 /  vatual} meses");
           
            Console.WriteLine("\n");

            Console.WriteLine($"Obrigado Sr.(a){nome1+" "+nome2}, o seu cadastro esta completo e foi realizado com sucesso!!");

            Console.WriteLine(  "Caso tenha um cupom de desconto insira abaixo para que seja aplicado:");
            Console.WriteLine( "Digite seu cupom de desconto:");
           cupom =  Console.ReadLine();
            
            if(cupom=="Conradito10")
            {
                Console.WriteLine("!PARABENS!,voce recebeu 10% de desconto na sua proxima viagem!");

            }
            
            else
            {
                Console.WriteLine("ATENÇAO:Esse cupom nao existe");

            }

            Console.WriteLine("Voce gosta de receber PROMOÇOES em seu EMAIL?");
            sesim = Console.ReadLine();
            if (sesim=="sim") 
            {
                Console.WriteLine($"Obrigado {nome1} por se registrar,voce recebera novos e-mails em breve.");
                Console.WriteLine("Volte sempre!");
            }
            else
            {
                Console.WriteLine("OK,voce nao recebera nossos e-mails.");
                Console.WriteLine("Obrigado e volte sempre!");
            }




            Main(null);
           Console.ReadKey();
           
            
            
            
            
        }
    }
}
