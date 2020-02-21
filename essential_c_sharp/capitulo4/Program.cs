using System;
using timer1 = System.Timers.Timer;
using timer2 = System.Threading.Timer;


namespace capitulo4
{
    class Program
    {

        #region method overloading

        /*Se crea un metodo base. Se crean nuevos metodos con el mismo nombre pero que tienen distinta cantidad de 
         parametros o tipo y que tienen la misma funcionalidad base con agregados.
         Los metodos tienen que estar afuera del main.*/
        static double resta(double numero1, double numero2)
        {
            return numero1 - numero2;
        }

        static double resta(double numero1, double numero2, double numero3)
        {
            return resta(numero1, numero2) - numero3;
        }

        static double resta(int numero1, int numero2)
        {
            return resta(numero1, numero2);
        }

        #endregion

        static void Main(string[] args)
        {
            #region Expression Bodied Methods 

            //Metodos cuya redaccion esta reducida por su simplicicdad
            static string NombreCompleto(string nombre, string apellido) =>
                $"{nombre} {apellido}";

            static int suma(int numero1, int numero2) =>
                numero1 + numero2;

            Console.WriteLine(NombreCompleto("Jose", "Maria"));
            Console.WriteLine(Convert.ToString(suma(1, 1)));

            #endregion

            #region aliases

            //los aliases permiten la utilizacion de metodos del mismo nombre
            //timer1;
            //timer2;

            #endregion

            #region parametros de metodos
            int numero1 = 1;
            int numero2 = 2;
            int numero3;
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Metodo1(numero1, numero2);
            Console.WriteLine($"El primer numero es {numero1} y el segundo numero es {numero2}");

            static void Metodo1(int numero1, int numero2)
            {
                numero1 = 10;
                numero2 = 20;
            }

            /*los parametros que se pasan por referencia deben ser variables, estar inicializados y 
             * tener ref para que la llamada a la funcion ande*/
            metodo2(ref numero1, ref numero2);
            Console.WriteLine($"El primer numero es {numero1} y el segundo numero es {numero2}");

            static void metodo2(ref int numero1, ref int numero2)
            {
                numero1 = 10;
                numero2 = 20;
            }

            /*los parametros que se pasan como out deben ser variables, no hace faltan que esten inicializados
             * pero si tienen que ser inicializados dentro del metodo, deben tener out para que la 
             * llamada de la funcion ande*/
            metodo3(out numero3);
            Console.WriteLine($"El tercer numero es {numero3}");

            static void metodo3(out int numero3)
            {
                int aux = 1;

                switch (aux)
                {
                    case 1:
                        numero3 = 10;
                        break;

                    case 2:
                        numero3 = 20;
                        break;

                    default:
                        numero3 = 30;
                        break;
                }
            }

            /*params permite pasar un array al metodo pero tiene varias limitaciones.
             solo se puede pasar un array pero se pueden pasar otros tipos de elementos
             tienen que ser el ultimo parametro que se pasa*/
            metodo4(numeros);

            static void metodo4(params int[] numeros)
            {
                foreach (int numeroAux in numeros)
                {
                    Console.WriteLine($"El numero actual es {numeroAux}");
                }
            }

            #endregion

            #region parametros opcionales

            /*Se puede convertir un parametro de un metodo en opcional si en la declaracion del metodo le asigno
             un valor.
             Esto permite no escribir el parametro en la llamada.
             El valor debe ser una constante (un valor hardcodeado), no puede ser un valor generado por una funcion.
             Estos parametros tienen que estar al final.*/

            Console.WriteLine(Convert.ToString(operacionMatematica(1, 1)));

            static double operacionMatematica(double numero1, double numero2, string operando = "+")
            {
                double retorno;

                switch (operando)
                {
                    case "-":
                        retorno = numero1 - numero2;
                        break;

                    case "+":
                        retorno = numero1 + numero2;
                        break;

                    default:
                        retorno = 0;
                        break;
                }

                return retorno;
            }

            #endregion

            #region paramatros nombrados

            /*En la llamda a la funcion se puede alterar el orden de los parametros poniendo el nombre completo seguido
             por un ":"*/ 
            metodoZaraza(parametro2: "hola", parametro1: "adios");

            static void metodoZaraza(string parametro1, string parametro2)
            {
                //zaraza
            }

            #endregion

            #region excepciones manejo basico

            /*Lo que hace el  segmento try-catch-finally es intentar un codigo y si tira un error buscar en los
             catch la coincidencia. Si hay coincidencia se ejecuta el codigo del catch. Siempre se ejecuta el finally.
             Los catch no son necesasrios sis esta*/

            heyYou();

            static int heyYou()
            {
                string firstName;
                string ageText;
                int age;
                int result = 0;

                Console.Write("Enter your first name: ");
                firstName = Console.ReadLine();

                Console.Write("Enter your age: ");
                ageText = Console.ReadLine();

                try
                {
                    age = int.Parse(ageText);
                    Console.WriteLine($"Hi { firstName }! You are { age * 12 } months old.");
                }
                //los errores de conversion siempre son de formato
                catch (FormatException)
                {
                    Console.WriteLine($"The age entered, { ageText }, is not valid.");
                    result = 1;
                }
                //este es el catch generico para agarrar todas las exceptions
                catch (Exception exception)
                {
                    Console.WriteLine($"Unexpected error: { exception.Message }");
                    result = 1;
                }
                //catch general. No se suele usar porque no permite dterminar informacion de porque se genero la exception
                catch
                {
                    System.Console.WriteLine("Unexpected error!");
                    result = 1;
                }
                finally
                {
                    Console.WriteLine($"Goodbye { firstName }");
                }
                return result;
            }

            #endregion

            #region excepciones throw statement

            /*El throw lo que hace es generar una excepcion de una sin que haya un error. Luego del throw los catch 
             intengan agarrar la excepcion.
             Los catch tambien pueden tener throws*/

            metodoThrow();

            static void metodoThrow()
            {
                try
                {
                    Console.WriteLine("Begin executing");
                    Console.WriteLine("Throw exception");
                    
                    throw new Exception("Arbitrary exception");
                    Console.WriteLine("End executing");
                }
                catch (FormatException exception)
                {
                    Console.WriteLine(
                    "A FormateException was thrown");
                }
                catch (Exception exception)
                {
                    //Console.WriteLine(
                    //$"Unexpected error: { exception.Message }");
                }
                catch
                {
                    Console.WriteLine("Unexpected error!");
                }
                Console.WriteLine("Shutting down...");
            }

            #endregion

        }
    }
}
