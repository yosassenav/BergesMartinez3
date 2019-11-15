using System;
using System.Globalization;


class Program {
//Función que valida el formato de fecha ingresado por el usuario, solo aceptando como correcto: dd/mm/aaaa
  public void ValidarFecha(string fecha){
    DateTime formato;

    if (DateTime.TryParseExact(fecha, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out formato)){
           Console.WriteLine("Formato de fecha válido. ");
      
    }

    else{
	    Console.WriteLine("Formato de fecha inválido");
      
    }
  }
 
//Función que calcula la diferencia de tiempo entre la fecha actual y la ingresada por el usuario
  public void CalcularTiempo(string fecha){
    CultureInfo MyCultureInfo = new CultureInfo("es-MX");
    DateTime d1 = DateTime.Parse(fecha, MyCultureInfo);
    DateTime d2 = DateTime.Now;
    
    TimeSpan ts = d1 - d2;
    if(ts < TimeSpan.Zero){
      Console.WriteLine("ERROR: NO SE ACEPTAN FECHAS PASADAS A LA ACTUAL NI LA ACTUAL");
    }
    else{
    	DateTime d = DateTime.MinValue + ts;
 
    	int dias = d.Day - 1;
    	int meses = d.Month - 1;
    	int años = d.Year - 1;
 
    	Console.WriteLine(string.Format("Faltan: {0} años, {1} meses, {2} días", años.ToString(), meses.ToString(), dias.ToString()));
    }
    

  }

  public static void Main (string[] args) {
    Program p = new Program();
    string fecha;

    Console.Write("Ingrese una fecha válida (dd/mm/aaaa): ");
    fecha = Console.ReadLine();

    p.ValidarFecha(fecha);
    Console.Write("--------------------------\n");
    p.CalcularTiempo(fecha);
  }
}

