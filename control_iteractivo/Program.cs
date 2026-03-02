
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
        double suma = 0;

        foreach (int calificacion in calificaciones)
        {
            suma += calificacion;     
        }

        promedio = suma / calificaciones.Length;

        Console.WriteLine("Suma: " + suma);
        Console.WriteLine("Promedio: " + promedio);
       

        Console.WriteLine("===POSICIONES PARES===");
        for (int i = 1; i < calificaciones.Length; i += 2)
        {
            Console.WriteLine("Estudiante " + (i + 1) + ": " + calificaciones[i]);
        }

        Console.WriteLine("Sección 2 — While y Do-While: Validación y juego interactivo");
        Console.WriteLine("===CONTROL DE ACCESO===");

        string clave = "sena2025";
        string ingreso = "";
        int intentos = 0;

        while (ingreso != clave && intentos < 3)
        {
            Console.WriteLine("Ingrese la clave:");
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
            return;
        }

        Console.WriteLine("===MENU PRINCIPAL===");
        int opcion = 0;

        do
        {
    Console.WriteLine("1. Ver Promedio del Grupo");
    Console.WriteLine("2. Ver Calificación Más Alta");
    Console.WriteLine("3. Salir");
    Console.WriteLine("Elige una opción:");

    bool esNumero = int.TryParse(Console.ReadLine(), out opcion);

    if (!esNumero)
    {
        opcion = 0;
    }

    switch (opcion)
    {
        case 1:
            Console.WriteLine("El Promedio del Grupo es: " + promedio);
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 2:
            Console.WriteLine("La Calificación Más Alta es: " + calificaciones[0]);
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;

        case 3:
            Console.WriteLine("Saliendo del programa...");
            break;

        default:
            Console.WriteLine("Opción no válida. Intente nuevamente.");
            Console.WriteLine("Presiona una tecla para continuar...");
            Console.ReadKey();
            break;
    }

            } while (opcion != 3);

            Console.WriteLine("===PRIMERA CALIFICACION REPROBATORIA===");
            bool reprobado = false;
            for(int i = 0; i < calificaciones.Length; i++){
                if(calificaciones[i] < 60)
                {
                Console.WriteLine("primera calificacion reprobatoria: " + calificaciones[i]);
                Console.WriteLine("posicion:" + i );
                reprobado = true;
                break;   
                    
                }
            }
            Console.WriteLine("===ESTUIDANTES APROBADOS===");
            int aprobados = 0;
            foreach(int calificacion in calificaciones)
        {
            if (calificacion < 60)
            {
                continue;
            }else
            {
                Console.WriteLine("aprobados " + calificacion);
                aprobados++;
            }
            

        }
            
        
            
        }
           
            
   
    }

