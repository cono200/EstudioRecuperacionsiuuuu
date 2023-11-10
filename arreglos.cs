using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EstudioRecuperacionsiuuuu
{
    public class arreglos
    {
        public void SumarTabla()
        {

            int totalVendedores = 0;
            int totalProducto = 0;
            int[,] numeros = {
            {100, 200, 300, 400},
            {150, 250, 350, 450},
            {120, 220, 320, 420},
            {180, 280, 380, 480},
            {130, 230, 330, 430}
        };


            for (int vendedores = 0; vendedores < 5; vendedores++)
            {
                for (int producto = 0; producto < 4; producto++)
                {
                    totalVendedores += numeros[vendedores, producto];

                }
                Console.WriteLine($"El vendedor{vendedores+1} gano {totalVendedores} ");
            }



            for (int producto = 0; producto < 5; producto++)
            {
                for (int vendedores = 0; vendedores < 4; vendedores++)
                {
                    totalProducto += numeros[producto, vendedores];

                }
            }

            
            Console.WriteLine("Resultado total de producto " + totalProducto);


        }

        /*
        public void PrimerEjercicio()
        {

            int[,] numeros =
            {
                {100,100,100,100 },
                {100,100,100,100},
                {100,100,100,100},
                {100,100,100,100},
                {100,100,100,100},
            };

            //I PARA VENDEDORES
            //J PARA PRODUCTO

            //PARA GANANCIA VENDEDOR
            for (int i = 0; i < 5; i++)
            {
                //SE TIENE QUE PONER AQUI PARA RENICIAR LA VARIABLE!
                int gananciaVendedor = 0;
                for (int j = 0; j < 4; j++)
                {
                    gananciaVendedor += numeros[i, j];

                }

                Console.WriteLine($"El vendedor {i + 1 } obtuvo una ganancia de {gananciaVendedor}");

            }

            //PARA PRODUCTO
            for (int j = 0; j < 5; j++)
            {
                int gananciaProducto = 0;

                for (int i = 0; i < 4; i++)
                {
                    gananciaProducto += numeros[j, i];
                }

                Console.WriteLine($"El producto {j + 1} en total se vendieron {gananciaProducto}");

            }

        }
        */

        public void PrimerEjercicio()
        {
            int[,] numeros =
            {
        {100, 100, 50, 150},
        {100, 100, 100, 260},
        {100, 100, 100, 961},
        {100, 100, 100, 115},
        {100, 100, 100, 333},
    };

            // I PARA VENDEDORES
            // J PARA PRODUCTO

            // PARA GANANCIA VENDEDOR
            for (int j = 0; j < 4; j++)
            {
                int gananciaVendedor = 0; // Reinicia la ganancia del vendedor por cada vendedor

                for (int i = 0; i < 5; i++)
                {
                    gananciaVendedor += numeros[i, j];
                }

                Console.WriteLine($"El vendedor {j + 1} obtuvo una ganancia de {gananciaVendedor}");
            }

            // PARA GANANCIA PRODUCTO
            for (int i = 0; i < 5; i++)
            {
                int gananciaProducto = 0; // Reinicia la ganancia del producto por cada producto

                for (int j = 0; j < 4; j++)
                {
                    gananciaProducto += numeros[i, j];
                }

                Console.WriteLine($"El producto {i + 1} en total se vendieron {gananciaProducto}");
            }
        }


        public void CURP()
        {
            string[] curpPersona = new string[18];

            for (int i = 0; i < curpPersona.Length; i++)
            {
                Console.WriteLine("Ingresa tu curp, letra por letra");
                curpPersona[i] = Console.ReadLine();
            }
            
            
             if (curpPersona[10] == "H" || curpPersona[10] == "h")
            {
                Console.WriteLine("Su sexo es hombre");
            }
            else if (curpPersona[10] == "M" || curpPersona[10] == "m")
            {
                Console.WriteLine("Su sexo es mujer");
            }
            else
            {
                Console.WriteLine("NO EXISTE SU GENERO");
            }

            if (curpPersona.Length >= 16)
            {
                string fechaNacimientoString = $"{curpPersona[8]}{curpPersona[9]}-{curpPersona[6]}{curpPersona[7]}-{curpPersona[4]}{curpPersona[5]}";

                if (DateTime.TryParse(fechaNacimientoString, out DateTime fechaNacimiento))
                {
                    Console.WriteLine("Fecha de nacimiento: " + fechaNacimiento.ToString("yyyy-MM-dd"));
                }
                else
                {
                    Console.WriteLine("No se pudo obtener la fecha de nacimiento.");
                }
            }
           
            


            //11


        }


        public void TercerEjercicio()
        {
            int[] numeros = new int[100];

            Random aleatorio = new Random();

            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i]=aleatorio.Next(0, 100);
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Matriz desornedada " +numeros[i]);
            }
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("--------------------------------------------------");

            //ORDENAMIENTO SELECCION
            for (int i = 0; i < numeros.Length-1; i++)
            {
                int menor = i;
                for (int j = i+1; j < numeros.Length; j++)
                {
                    if (numeros[menor] < numeros[j])
                    {
                        menor = j;
                    }
                }

                int temporal= numeros[i];
                numeros[i] = numeros[menor];
                numeros[menor] =temporal;
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("Matriz ordenada " + numeros[i]);

            }



            //BUSQUEDA BINARIA
            int inicio = 0;
            int final = numeros.Length - 1;
            int posicion = -1;
            int buscarNumero = 75;

            while (inicio <= final)
            {
                int mitad = (inicio + final) / 2;
                if (numeros[mitad] == buscarNumero)
                {
                    posicion = mitad;
                    break;
                }
                else if (numeros[mitad] < buscarNumero)
                {
                    final = mitad - 1;
                }
                else
                {
                    inicio = mitad + 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine("El número está en la posición " + posicion);
            }
            else
            {
                Console.WriteLine("No existe");
            }
            
        }




    }
}
