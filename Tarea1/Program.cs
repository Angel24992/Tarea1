using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 13
            // Inicializa una variable de tipo entero con el valor predeterminado 10
            int numero = 10;
            // Inicializa una variable de tipo cadena de texto con el valor predeterminado "Hola"
            string saludo = "Hola";
            // Muestra los valores de las variables en la consola
            Console.WriteLine($"El valor de la variable entera es: {numero}");
            Console.WriteLine($"El valor de la variable cadena de texto es: {saludo}");
            Console.ReadLine();*/


            /* EJERCICIO 12
            // Vaiables de tipo entero: int, short, long, byte
            int numeroEntero = 42;
            // Variables de tipo decimal: float, double
            double numeroDecimal = 3.14159;
            // Variable de tipo carácter: char
            char letra = 'A';
            // Variable de tipo cadena de texto: string
            string texto = "Hola";
            // Declara una variable de tipo booleano (bool)
            bool esVerdadero = true;
            // Muestra los valores de las variables en la consola
            Console.WriteLine($"El valor de la variable entera es: {numeroEntero}");
            Console.WriteLine($"El valor de la variable decimal es: {numeroDecimal}");
            Console.WriteLine($"El valor de la variable carácter es: {letra}");
            Console.WriteLine($"El valor de la variable cadena de texto es: {texto}");
            Console.WriteLine($"El valor de la variable booleana es: {esVerdadero}");
            Console.ReadLine();*/


            /* EJERCICIO 11
            // Tema
            Console.WriteLine("La importancia de usar variables descriptivas");
            // Respuesta
            Console.WriteLine("Ayuda a entender de manera rápida y clara el propósito " +
                "de la variable en el contexto del programa, lo que facilita la " +
                "colaboración entre programadores y la modificación futura del código");
            Console.ReadLine();*/


            /* EJERCICIO 10
            // Declara una variable
            int numero = 5;
            // Muestra el valor inicial de la variable
            Console.WriteLine($"Valor inicial de la variable: {numero}");
            // Modifica el valor de la variable
            numero = 10;
            // Muestra el valor modificado de la variable
            Console.WriteLine($"Valor modificado de la variable: {numero}");
            Console.ReadLine(); */


            /* EJERCICIO 9
            // Variable constantante
            const int constante = 10;
            Console.WriteLine($"El valor de la variable constate es: {constante}");
            // Variable normal
            int normal = 20;
            Console.WriteLine($"El valor de la variable normal es: {normal}");
            Console.ReadLine();*/


            /* EJERCICIO 8 
            // Solicita al usuario que ingrese un número
            Console.Write("Ingrese un número: ");
            int num1 = int.Parse(Console.ReadLine());
            // Solicita al usuario que ingrese otro número
            Console.Write("Ingrese otro número: ");
            int num2 = int.Parse(Console.ReadLine());
            // Calcula el módulo (residuo) de la división entre los dos números
            int mod = num1 % num2;
            // Muestra el resultado
            Console.WriteLine($"El módulo de la división entre {num1} y {num2} es: {mod}");
            // Espera a que el usuario presione Enter antes de cerrar la consola
            Console.ReadLine(); */


            /* EJERCICIO 7
            // Solicita al usuario ingresar un número
            Console.Write("Ingrese un numero: ");
            double num1 = double.Parse(Console.ReadLine());
            // Solicita al usuario ingresar otro número
            Console.Write("Ingrese otro numero: ");
            double num2 = double.Parse(Console.ReadLine());
            // Compara si los numeros ingresados son mayor igual o menor
            if (num1 > num2)
            {
                // Muestra los resultados de mayor y menor
                Console.WriteLine($"{num1} es mayor que {num2}");
                Console.WriteLine($"{num2} es menor que {num1}");
            }
            else if (num2 > num1) {
                // Muestra los resultados de mayor y menor
                Console.WriteLine($"{num2} es mayor que {num1}");
                Console.WriteLine($"{num1} es menor que {num2}");
            } else
            {
                // Muestra que los dos números son iguales
                Console.WriteLine("Los dos números son iguales");
            }
            Console.ReadKey(); */


            /* EJERCICIO 6 
            // Solicita al usuario ingresar un número
            Console.Write("Ingrese un numero: ");
            double num1 = double.Parse(Console.ReadLine());
            // Solicita al usuario ingresar otro número
            Console.Write("Ingrese otro numero: ");
            double num2 = double.Parse(Console.ReadLine());
            // Se muestra los resultados de la suma hasta la división
            Console.WriteLine("La suma de los números es: " + (num1+ num2));
            Console.WriteLine("La resta de los números es: " + (num1 - num2));
            Console.WriteLine("La multiplicación de los números es: " + (num1 * num2));
            Console.WriteLine("La división de los números es: " + (num1 / num2));
            Console.ReadKey();*/


            /* EJERCICIO 5
            // Solicita al usuario que ingrese el radio de la esfera
            Console.Write("Ingrese el radio de la esfera: ");
            double radio = double.Parse(Console.ReadLine());
            // Calcula el área superficial de la esfera
            double areaSuperficial = 4 * Math.PI * radio * radio;
            // Calcula el volumen de la esfera
            double volumen = (4.0 / 3.0) * Math.PI * radio * radio * radio;
            // Muestra el área superficial y el volumen de la esfera
            Console.WriteLine($"El área superficial de la esfera es: {areaSuperficial}");
            Console.WriteLine($"El volumen de la esfera es: {volumen}");
            // Espera a que el usuario presione Enter antes de cerrar la consola
            Console.ReadLine();*/


            /* EJERCICIO 4 
            // Solicita al usuario que ingrese la longitud de un lado del cuadrado
            Console.Write("Ingrese la longitud de un lado del cuadrado: ");
            int lado = int.Parse(Console.ReadLine());
            // Calcula el area del cuadrado
            int area = lado * lado;
            // Calcula el perimetro del cuadrado
            int per = 4 * lado;
            // Imprime los resultados
            Console.Write($"El cuadrado tiene una area de {area}, y un perimetro de {per}");
            Console.ReadLine();*/


            /* EJERCICIO 3
            // Solicita al usuario que ingrese la temperatura
            Console.Write("Ingrese la temperatura: ");
            double temperatura = double.Parse(Console.ReadLine());
            // Solicita al usuario que ingrese la unidad (C o F)
            Console.Write("Ingrese la unidad (C para Celsius, F para Fahrenheit): ");
            string unidad = Console.ReadLine().ToUpper();
            // Inicializa las variables para la temperatura convertida y la unidad resultante
            double temperaturaConvertida = 0;
            string unidadConvertida = "";
            // Realiza la conversión según la unidad ingresada
            if (unidad == "C")
            {
                // Convertir de Celsius a Fahrenheit
                temperaturaConvertida = (temperatura * 9 / 5) + 32;
                unidadConvertida = "Fahrenheit";
            }
            else if (unidad == "F")
            {
                // Convertir de Fahrenheit a Celsius
                temperaturaConvertida = (temperatura - 32) * 5 / 9;
                unidadConvertida = "Celsius";
            }
            else
            {
                // Si la unidad no es válida, muestra un mensaje de error
                Console.WriteLine("Unidad no válida. Por favor, ingrese C para Celsius o F para Fahrenheit.");
                return;
            }
            // Muestra el resultado de la conversión
            Console.WriteLine($"La temperatura convertida es: {temperaturaConvertida} grados {unidadConvertida}.");
            Console.ReadLine(); */


            /* EJERCICIO 2 
            // Solicita al usuario que ingrese el primer número entero
            Console.Write("Ingrese el primer número entero: ");
            int num1 = int.Parse(Console.ReadLine());
            // Solicita al usuario que ingrese el segundo número entero
            Console.Write("Ingrese el segundo número entero: ");
            int num2 = int.Parse(Console.ReadLine());
            // Determina el mayor y el menor número utilizando la clase Math
            int mayor = Math.Max(num1, num2);
            int menor = Math.Min(num1, num2);
            // Sentencia if compara los 2 números
            if (num1 == num2)
            {
                // Si los números son iguales, se establece que no hay mayor ni menor
                Console.WriteLine("Ambos números son iguales.");
            }
            else
            {
                // Muestra el mayor y el menor de los dos números
                Console.WriteLine($"El número mayor es: {mayor}");
                Console.WriteLine($"El número menor es: {menor}");
            }
            // Espera a que el usuario presione Enter antes de cerrar la consola
            Console.ReadLine(); */


            /* EJERCICIO 1
            // Solicita al usuario que ingrese su nombre
            Console.Write("Escriba su nombre: ");
            // Lee lo que escribe el usuario desde la consola
            String nombre = Console.ReadLine();
            // Solicita al usuario que ingrese su edad
            Console.Write("Escriba su edad: ");
            // Lee lo que escribe el usuario desde la consola, se utiliza int para cambiar el tipo de dato
            int edad = int.Parse(Console.ReadLine());
            // Solicita al usuario que ingrese su estatura
            Console.Write("Escriba su estatura en metros: ");
            // Lee lo que escribe el usuario desde la consola, se utiliza float para cambiar el tipo de dato
            float estatura = float.Parse(Console.ReadLine());
            // Muestra el nombre, edad y estatura del usuario en un mensaje
            Console.WriteLine($"Su nombre es {nombre}, tiene {edad} años, y mide {estatura} metros");
            // Espera a que el usuario presione Enter antes de cerrar la consola,
            Console.ReadLine();*/

        }
    }
}
