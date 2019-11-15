using System;
using System.IO;

namespace Proyecto
{
    //Clase Singleton
    public class LoggerSingleton
    {
        //Instancia única del singleton
        private static LoggerSingleton instancia = null;
        private static string Path = @".\";
        //static int contador = 0;  
        //Constructor privado para negar la creación de una instancia de esta clase afuera
        private LoggerSingleton() {
            //Para comprobar la cantidad de instancias que se pueden crear (1)
            //contador++;  
            //Console.WriteLine("Instancia " + contador); 
        }
        
        //Para crear una única instancia
        public static LoggerSingleton Instanciar() {
            if (instancia == null) {
                instancia = new LoggerSingleton();
            }
            return instancia;
        }
        
        public void Guardar(string mensaje){   
           CreateDirectory();
            string cadena = "";
            cadena += $"[{DateTime.Now}]: {mensaje }";

            StreamWriter sw = new StreamWriter(Path + "/" + "log.txt", true);
            sw.WriteLine(cadena); 
            sw.Close(); 

        }
        private void CreateDirectory(){
            try
            {
                if (!Directory.Exists(Path))
                    Directory.CreateDirectory(Path);

            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);

            }
        }
         public void EstablecerNivel(int nivel){ 
            string niv = "";
            
            switch (nivel){
                case 1: // CRITICO
                        niv += $"{"CRITICO" }";  

                    break;
                case 2: // ADVERTENCIA
                        niv += $"{"ADVERTENCIA" }"; 

                    break;
                case 3: // INFORMATIVO
                        niv += $"{"INFORMATIVO" }"; 

                    break;
                default: //ERROR
                    Console.WriteLine("Error. Solo se aceptan valores del 1 al 3.");
                    break;
            }
            StreamWriter sw = new StreamWriter(Path + "/" + "log.txt", true);
            sw.WriteLine(niv); 
            sw.Close(); 
        }
    }

    
}

