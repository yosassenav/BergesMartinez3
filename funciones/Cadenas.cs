using System;

class Program{
  public void ConvetirAMinusculas(){
    string Materia;
    string Profesor;

    Console.Write("Nombre de la materia: ");
  	Materia = Console.ReadLine(); 
  	Console.Write("Nombre del profesor: ");
  	Profesor = Console.ReadLine(); 
  
    // string converted to lower case 
    Console.WriteLine(Materia.ToLower()); 
    Console.WriteLine(Profesor.ToLower());
  }

  public void VerificarLongitud(){
    string Materia;
    string Profesor;

    Console.Write("Nombre de la materia: ");
  	Materia = Console.ReadLine(); 
  	Console.Write("Nombre del profesor: ");
  	Profesor = Console.ReadLine();

    int MateriaTam = Materia.Length;
	  int ProfesorTam = Profesor.Length;

	  if (MateriaTam > 20){
       Console.WriteLine("El nombre " + Materia + " es muy largo");
    	}
	  else{
		  Console.WriteLine("Nombre Válido");
	    }

  	if (ProfesorTam > 20){
       Console.WriteLine("El nombre " + Profesor + " es muy largo");
	    }
	  else{
		Console.WriteLine("Nombre Válido");
	  }
  }

  public static void Main (string[] args){
     Program p = new Program();
     p.ConvetirAMinusculas();
     p.VerificarLongitud();
    }
}
