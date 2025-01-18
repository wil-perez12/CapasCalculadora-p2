using dataAceso;
namespace logicNegocio
{
    public class negocio : INegocioCalcular, INegocioMostrarHistorial
    {
        DatosCalculadora datos = new DatosCalculadora();

        public int numero1 { get; set; }
        public int numero2 { get; set; }
        public int resultado { get; set; }

        public negocio(){}

        //inicializo en 0 los valores que seran de entrada
        public negocio( int resultado, int numeo1 = 0, int numeo2 = 0)
        {
            this.numero1 = numeo1;
            this.numero2 = numeo2;
            this.resultado = resultado;
        }


        //suma los dos valores de entrada y agrega la operacion a el historial 
        public void sumar(int a, int b)
        {
            numero1 = a;
            numero2 = b;

            resultado = numero1 + numero2;
            Console.WriteLine($"La suma de {numero1} + {numero2} = {resultado}");

            //almacena la operacion en el historial
            datos.AgrgarHistorial($"{a} + {b}", resultado);

        }

        //resta los numeros y agrega la operacion a el historial 
        public void restar(int a, int b)
        {
            numero1 = a;
            numero2 = b;

            resultado = numero1 - numero2;
            Console.WriteLine($"La resta de {numero1} - {numero2} = {resultado}");

            //almacena la operacion en el historial
            datos.AgrgarHistorial($"{a} - {b}", resultado);
        }

        //multiplica los numeros y agrega la operacion a el historial 
        public void multiplicar(int a, int b)
        {
            numero1 = a;
            numero2 = b;

            resultado = numero1 * numero2;
            Console.WriteLine($"La multiplicacion de {numero1} * {numero2} = {resultado}");

            //almacena la operacion en el historial
            datos.AgrgarHistorial($"{a} x {b}", resultado);
        }

        //divide los numeros y agrega la operacion a el historial 
        public void dividir(int a, int b)
        {
            //cambio la inicializacion en 0 del numero 2 en caso de dejarlo vacio
            b = 1;

            numero1 = a;
            numero2 = b;

            //evalua que el numero 2 sea diferente 0
            if (numero2 != 0)
            {
               resultado = numero1 / numero2;
                Console.WriteLine($"La division de {numero1} / {numero2} = {resultado}");
            }
            else
            {
                Console.WriteLine("La división con divisor cero es igual a ∞");
            }
            //almacena la operacion en el historial
            datos.AgrgarHistorial($"{a} / {b}", resultado); ;
        }

        //Obtiene la lista del historial de las operaciones
        public void MostarHistorial()
        {
            datos.ObtenerHistorial();
        }
    }
}
