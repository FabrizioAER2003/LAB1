using System;

namespace LAB1
{
    internal class Program
    {
        // 1.- 	Desarrollar los ejercicios prácticos de la semana 11 y enviar el código.
        static void Menu()
        {
            Console.WriteLine(" ----------------- MENÚ DE OPCIONES ----------------- ");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|             1.- Ejercicio 1 Semana 11              |");
            Console.WriteLine("|             2.- Ejercicio 2 Semana 11              |");
            Console.WriteLine("|             3.- Ejercicio 3 Semana 11              |");
            Console.WriteLine("|             4.- Ejercicio 4 Semana 11              |");
            Console.WriteLine("|             5.- Ejercicio 5 Semana 11              |");
            Console.WriteLine("|             6.- Ejercicio 6 Semana 11              |");
            Console.WriteLine("|             0.-         Salir                      |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine(" ---------------------------------------------------- \n");
        }
        static void EJ1()
        {
            int[] numero = new int[5] { 1, 2, 3, 45, 123124 };
            foreach (int i in numero) { Console.WriteLine(i); }

            for (int i = 0; i < numero.Length; i++) { Console.WriteLine(numero[i]); }
        }
        static void EJ2()
        {
            Random rnd = new Random(); int N;
            Console.Write("Ingrese el valor de N: "); N = int.Parse(Console.ReadLine());

            int[] Numero = new int[N];

            for (int i = 0; i < Numero.Length; i++) { Numero[i] = rnd.Next(0, 51); Console.WriteLine(i + " -> " + Numero[i]); }
        }
        static void EJ3()
        {
            int[] numero = new int[4] { 4, 8, 10, 25 };
            Console.WriteLine("Lista original:");
            foreach (int i in numero) { Console.WriteLine(i); }
            Console.WriteLine("\nLista modificada:");
            numero[2] = 36;
            foreach (int i in numero) { Console.WriteLine(i); }
        }
        static void EJ4()
        {
            string[] Nombres = new string[4] { "Jose", "Oscar", "Carmen", "Alexa" };
            foreach (string S in Nombres) Console.WriteLine(S);

            Console.Write("\nIngrese un nombre a buscar: "); string buscar = Console.ReadLine();

            int Indice = Array.IndexOf(Nombres, buscar);

            if (Indice != -1) { Console.WriteLine($"{buscar} está en la posicion {Indice + 1}"); }
            else { Console.WriteLine("No existe"); }
        }
        static void EJ5()
        {
            char[] Vocales = new char[] { 'A', 'E', 'I', 'O', 'U' };
            char nuevo;
            Console.WriteLine("Lista original:");
            foreach (char V in Vocales) { Console.WriteLine(V); }
            Console.WriteLine("Ingrese caracter a modificar: "); char Modificacion = char.Parse(Console.ReadLine());

            int Indice = Array.IndexOf(Vocales, Modificacion);
            if (Indice != -1)
            {
                Console.Write("Ingrese el nuevo caracter: "); nuevo = char.Parse(Console.ReadLine()); Vocales[Indice] = nuevo; Console.WriteLine("\nLista modificada: ");
                foreach (char V in Vocales) { Console.WriteLine(V); }
            }

            else { Console.WriteLine("\nNo se puede modificar porque el caracter no existe"); }
        }
        static void EJ6()
        {
            int[] N = new int[0]; char Opcion;
            int Num, Posicion = 0;
            do
            {
                Console.Write("\nIngrese numero entero: ");
                while (!int.TryParse(Console.ReadLine(), out Num)) { Console.WriteLine("[ERROR] INGRESE DE NUEVO EL NUMERO [ERROR]"); }
                Array.Resize(ref N, N.Length + 1); N[Posicion] = Num; Posicion++;

                do { Console.Write("¿Desea continuar registrando? (S/N) -> "); Opcion = char.ToUpper(Console.ReadKey().KeyChar); } while (Opcion != 'S' && Opcion != 'N');
            } while (Opcion == 'S');
            Console.WriteLine("\nLista de numeros registrados: ");
            foreach (int i in N) { Console.WriteLine(i); }
        }
        static void Main(string[] args)
        {
            byte opcion;
            char regresar;
            do
            {
                Menu();
                Console.Write("Ingrese una opción -> ");
                while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 6) { Console.Write("[ERROR] Ingrese la opcion nuevamente -> "); }
                switch (opcion)
                {
                    case 0: Environment.Exit(0); break;
                    case 1: EJ1(); break;
                    case 2: EJ2(); break;
                    case 3: EJ3(); break;
                    case 4: EJ4(); break;
                    case 5: EJ5(); break;
                    case 6: EJ6(); break;
                }
                Console.Write("\t\n¿Desea regresar al MENÚ? [S/N]  "); regresar = char.ToUpper(Console.ReadKey().KeyChar); Console.Clear();
            } while (regresar == 'S');
        }
    }
}