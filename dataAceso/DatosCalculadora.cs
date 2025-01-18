namespace dataAceso
{
    public class DatosCalculadora : IDatosCalculados
    {

        public List<string> historial { get; set; }

        public DatosCalculadora() {  historial = new List<string>(); }

        
        //para crear un historial de las operaciones
        public void AgrgarHistorial(string operation, int result)
        {
            historial.Add($"{operation} = {result}");
        }

        //para mostar el historial
        public List<string> ObtenerHistorial()
        {
            Console.WriteLine("Historial de operaciones:");
            foreach (var item in historial)
            {
                Console.WriteLine($"{item}");
            }
            return historial;
        }
    }
}
