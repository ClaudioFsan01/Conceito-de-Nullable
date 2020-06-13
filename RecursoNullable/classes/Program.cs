/*
 Nullable
• É um recurso de C# para que dados de tipo valor(tipos primitivos) structs(caixas) possam
receber o valor null
• Uso comum:
• Campos de banco de dados que podem valer nulo (data de nascimento,
algum valor numérico, etc.).(campos em um formulario que não são obrigatorios)
• Dados e parâmetros opcionais.
ex:
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursoNullable
{
    class Program
    {
        static void Main(string[] args)
        {
            //double a = null;

            Nullable<double> a = null;

            // ou
            // double? a = null;

            double? x = 10.2;

            /*
              • Métodos:
           • GetValueOrDefault
           • HasValue
           • Value (lança uma exceção se não houver valor)
           • Um nullable não pode ser atribuído para um struct comum*/
            try
            {
                Console.Write(a.GetValueOrDefault()); // GetValueOrDefault() Recupera o valor do atual objeto ou o valor padrão do objeto
                Console.Write("\n");
                Console.Write(x.GetValueOrDefault());
                Console.Write("\n");
                Console.WriteLine(a.HasValue); // HasValue obtem um valor que indica se o objeto tem um valor valido do seu tipo subjacente caso sim retorna true caso contrario false
                Console.Write("\n");
                Console.WriteLine(x.HasValue);
                Console.Write("\n");
                // a.Value obtem o valor do objeto atual valido se a ele foi atribuido um valor subjacente valido  caso contrario lança uma exceção
                if (a.HasValue)
                {
                    Console.Write(a.Value);
                    Console.Write("\n");
                }
                else
                {
                    Console.WriteLine(a.HasValue);
                }

                if (x.HasValue)
                {
                    Console.Write(x.Value);
                }
                else
                {
                    Console.WriteLine(x.HasValue);
                }

                /*Operador de coalescência nula -> (??)
                No nosso exemplo a seguir temos uma variavel z que foi iniciada como Nullable mas pode receber um outro valor.
                Temos uma variavel w que não é Nullable mas queremos atribuir a essa variavel o valor da variavel z mas caso 
                o valor de z seja nullo queremos atribuir um outro valor que estiver apos o operador ??. Para isso usamos o operador de coalescência nula -> (??).
                ex:
                */
                double? z = null;
                double w = z ?? 5.0;

                Console.WriteLine(w);

                double? k = 15.3;
                double j = k ?? 5;
                
                Console.WriteLine(j);

                Console.ReadLine();

            }
            catch (InvalidOperationException e)
            {
                Console.Write(e.Message);
            }
           
        }
    }
}
