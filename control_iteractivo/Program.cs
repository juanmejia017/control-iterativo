using System;



class Program

{

    static void Main()

    {

        Console.WriteLine("Sección 1 — For y Foreach: Registro y análisis de calificaciones");

        int[] calificaciones = { 72, 85, 91, 60, 43, 78, 95, 55, 88, 67 };



        Console.WriteLine("===REGISTRO DE CALIFICACIONES===");

        for (int i = 0; i < calificaciones.Length; i++)

        {

            Console.WriteLine("Estudiante " + (i + 1) + ": " + calificaciones[i]);

        }



        Console.WriteLine("===ORDEN DESCENDENTE===");

        Array.Sort(calificaciones);

        Array.Reverse(calificaciones);

        for (int i = 0; i < calificaciones.Length; i++)

        {

            Console.WriteLine("Estudiante " + (i + 1) + ": " + calificaciones[i]);

        }

        Console.WriteLine("=== PROMEDIO DEL GRUPO ===");

        double promedio = 0;



        foreach (int calificacion in calificaciones)

         {

          promedio += calificacion;

         }

        promedio /= calificaciones.Length;

        Console.WriteLine("Promedio: " + promedio);



    Console.WriteLine("===POSICIONES PARES===");

        for (int i = 0; i < calificaciones.Length; i += 2)

        {

            Console.WriteLine("Estudiante " + i + ": " + calificaciones[i]);

        }

        Console.WriteLine("Sección 2 — While y Do-While: Validación y juego interactivo");

        Console.WriteLine("===CONTROL DE ACCESO===");

        string clave = "sena2025";

        string ingreso = "";

        int intentos = 0;

        while (ingreso != clave && intentos < 3)

        {

            Console.WriteLine ("Ingrese la clave");

            ingreso = Console.ReadLine();

            intentos++;

            if (ingreso != clave && intentos < 3)

            {

                Console.WriteLine("Clave incorrecta. Intentos restantes: " + (3 - intentos));

            }

           

        }



        if (ingreso == clave)

        {

            Console.WriteLine("Acceso concedido");

        }

        else

        {

            Console.WriteLine("Acceso denegado");

        }

        Console.WriteLine("===MENU PRINCIPAL===");

        int opcion = 0;

        do

        {

            Console.WriteLine("1. Ver Promedio del Grupo");

            Console.WriteLine("2. Ver Calificación Más Alta");

            Console.WriteLine("3. Salir");

            Console.WriteLine("Elige una Opcion:");

            opcion = tryparse(Console.ReadLine(), out opcion) ? opcion : 0;



            switch (opcion)

            {
                case 1:
                    Console.WriteLine("El Promedio del Grupo es: " + promedio);
                    break;

                case 2: 
                    Console.WriteLine("La Calificación Más Alta es: " + calificaciones[0]);
                    break;
                case 3:
                    Console.WriteLine("Saliendo del programa...");
                    break;

                default:
                    Console.WriteLine("Opción no válida. Intente nuevamente.");

            
            }
    }while (opcion != 3);

    }
}

      


        


      
        




