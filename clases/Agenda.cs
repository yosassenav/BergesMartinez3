using System;
using System.Collections.Generic;

namespace Proyecto{
    public class Agenda{	
	    // Atributo de la clase Agenda
	    //List<Recordatorio> recordatorios = new List<Recordatorio>();
        private List<Recordatorio> Lista; 
          public List<Recordatorio> MostrarLista{
            get{ return Lista;
                //return (from i in Lista select i).ToList();
                }
            }
	    //Métodos
	    public void AgregarRecordatorio(){
             Recordatorio item = new Recordatorio();
            
            // Solicitando valores en la terminal
            /*
            Console.Write("Ingrese tipo de recordatorio (Tarea o Examen): "); 
            item.Tipo = Console.ReadLine(); 

            Console.Write("Materia: "); 
            item.Materia = Console.ReadLine(); 

            Console.Write($"Título de{rec.Tipo}: "); 
            item.Titulo = Console.ReadLine();

            Console.Write("Descripción: "); 
            item.Descripcion = Console.ReadLine(); 

            Console.Write("Estado (Pendiente): "); 
            item.Estado = Console.ReadLine(); 

            Console.Write("Prioridad (1, 2 o 3): "); 
            item.Prioridad = Convert.ToInt32(Console.ReadLine()); 

            //Console.Write("Fecha de entrega o realización: ");
            //DateTime dateTime = Convert.ToDateTime(Console.ReadLine());
            item.Fecha = Convert.ToDateTime("2019-01-10");

            Console.Write("Hora de entrega o realización "); 
            item.Hora = Console.ReadLine();
            */

            //Lista.Add(item);
        }

        public void EliminarRecordatorio(string titulo){
            //if (){//si existe un recordatorio con ese título
                //Lista.Remove(item);  
            //}
            
        }

        public void ModificarRecordatorio(){

        }
        //Constructor de la clase Agenda
	    public Agenda(){
            Lista = new List<Recordatorio>();
        }
    }
}
