using System;
using System.Collections.Generic;
namespace Proyecto{
        public class Recordatorio{
   
        // Atributos de la clase Recordatorio
                public string  Tipo; //Examen o Tarea
                public string GetSetTipo{
                        get { return Tipo; }
                        set { Tipo = value; }
                }
                public string  Titulo;
                public string GetSetTitulo{
                        get { return Titulo; }
                        set { Titulo = value; }
                }
                public string  Materia;
                public string GetSetMateria{
                        get { return Materia; }
                        set { Materia = value; }
                }
                public string  Estado;
                public string GetSetEstado{
                        get { return Estado; }
                        set { 
                                if (value.ToLower()== "pendiente" || value.ToLower() == "terminado")
                                        Estado = value;
                                else{Console.WriteLine("Valor de Estado no permitido");}
                                
                        }
                }
                 public string  Descripcion;
                public string GetSetDescripcion{
                        get { return Descripcion; }
                        set { Descripcion = value; }
                }
                public int Prioridad;
                public int GetSetPrioridad{
                        get { return Prioridad; }
                        set { 
                                if (value >=1 && value <= 3)
                                        Prioridad = value; 
                                else{Console.WriteLine("Valor de Prioridad no permitido.");}             
                           }
                }
                public string Fecha;
                public string  GetSetFecha{
                        get { return Fecha; }
                        set { Fecha  = value; }
                }
                public string Hora;
                public string  GetSetHora{
                        get { return Hora; }
                        set { Hora  = value; }
                }

                //Sobrecarga de método ToString()
                public override string ToString(){
                        string prioridad = "";
                        switch (Prioridad){
                                case 1: prioridad = "Baja";
                                        break;
                                case 2: prioridad = "Media";
                                        break;
                                case 3: prioridad = "Alta";
                                        break;
                                default: Console.WriteLine("Valor de Prioridad no permitido");
                                        break;           
                        }    
                        //string s = Materia +"\n" + Tipo +"\n" + "Para el día: " + Fecha.ToString("d/M/yyyy")  + " a  las " + Hora +"\n"+ "Título: " + Titulo + "\n" + "Prioridad: " + prioridad + "\n"+"Descripcion: " + Descripcion + "\n" +"Estado: " + Estado;
                        string s = Tipo+"'"+","+"'"+Titulo+"'"+","+"'"+Materia+"'"+","+"'"+Descripcion+"'"+","+"'"+Estado+"'"+","+"'"+prioridad+"'"+","+"'"+Fecha+"'" +","+"'"+Hora;
                        return s;

                }
    
                 //Constructor de la clase
            public Recordatorio(){
                }

    

        }
}
