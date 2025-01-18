using logicNegocio;


negocio servicio = new negocio();

int opcion;

do {

    Console.WriteLine("Elija una opcion");
    Console.WriteLine("1. sumar");
    Console.WriteLine("2. restar");
    Console.WriteLine("3. multiplicar");
    Console.WriteLine("4. divir");
    Console.WriteLine("5. Ver historial de operaciones");
    Console.WriteLine("6. salir");

    opcion = int.Parse(Console.ReadLine());

    if (opcion != 5 && opcion !=6 && opcion < 6)
    {
        Console.WriteLine("ingrese el primer numero");
        servicio.numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("ingrese el segundo numero");
        servicio.numero2 = int.Parse(Console.ReadLine());
    }

   
   

    switch (opcion)
    {
        case 1:
            servicio.sumar(servicio.numero1, servicio.numero2);
            Console.WriteLine("---------------------------------------------------");
            break;

        case 2:
            servicio.restar(servicio.numero1, servicio.numero2);
            Console.WriteLine("---------------------------------------------------");
            break;

        case 3:
            servicio.multiplicar(servicio.numero1, servicio.numero2);
            Console.WriteLine("---------------------------------------------------");
            break;
        
        case 4:
            servicio.dividir(servicio.numero1, servicio.numero2);
            Console.WriteLine("---------------------------------------------------");
            break;

        case 5:
            servicio.MostarHistorial();
            Console.WriteLine("---------------------------------------------------");
            break;

        case 6:
            Console.WriteLine("Saliendoo....");
            Console.WriteLine("---------------------------------------------------");
            break;

        default:
            Console.WriteLine("Opción invalida. Vuelva a intentar!");
            Console.WriteLine("---------------------------------------------------");
            break;
    }

} while (opcion != 6);