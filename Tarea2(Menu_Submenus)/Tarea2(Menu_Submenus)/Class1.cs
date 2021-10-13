using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Menu_Submenus_
{
    class Estudiantes
    {
        string[] cedula = new string[3];
        string[] nombre = new string[10];
        int[] promedio= new int[10];
        string[] condicion= new string[10];
        string modinombre="";
        int modipromedio = 0; //Pendiente 
        string temp = "";
        string modicondicion = "";

        int p;
       public Estudiantes()
        {
            p = 0;
        }
        public void Inicializar_Vectores()
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                cedula[i] = "";
                nombre[i] = "";
                promedio[i]=0 ;
                condicion[i]="";
            }
        }

        public void Incluir_Estudiantes()
        
        {
                for (int i = 0; i < cedula.Length; i++)
            {
                Console.WriteLine("Digite su nombre");
                nombre[p] = Console.ReadLine();
                Console.WriteLine("Digite su cedula");
                cedula[p] = Console.ReadLine();
                Console.WriteLine("Digite su nota");
                promedio[p] =Convert.ToInt32(Console.ReadLine());

                if (promedio[p] >= 70)
                {
                    condicion[p] = "APROBADO";
                }
                else if (promedio[p] > 60 && promedio[p] <= 70)
                {
                    condicion[p] = "APLAZADOS";
                }
                else
                {
                    condicion[p]="REPROBADO";
                }
                p++;
            }
            
        }
        public void Consultar_Estudiantes()
        {
            Console.WriteLine("Ingresa la cedula:");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < cedula.Length; i++)
            {
                if (ced.Equals(cedula[i].ToString()))
                {
                    Console.WriteLine($"{nombre[i]} {promedio[i]} {condicion[i]}" ); //Interpolacion se pone las variables unidas
                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("El estudiante no existe");
            }
        }
        public void Modificar_Estudiante() //NO SE COMPLETO
        {                                  //Solo funciona el cambio de nombre y condicion         
            Console.WriteLine("Digite su cedula");
            string ced  = Console.ReadLine();
            Console.WriteLine("Digite la nueva informacion");
            modinombre = Console.ReadLine();
            temp =Console.ReadLine();

            for (int i = 0; i < cedula.Length; i++)
            {  
                if (cedula[i]== ced)
                {
                    nombre[i] = modinombre; //nombre[i]; //Aqui lo que esta haciendo es que guarda el valor de cedula en la variable nombre y permanece asi
                    modipromedio = Int32.Parse(temp);
                    promedio[i] = modipromedio; //Falta pendiente la conversion de string a int
                        if (modipromedio >= 70)
                        {
                            modicondicion = "APROBADO";
                        }
                        else if (modipromedio > 60 && modipromedio <= 70)
                        {
                            modicondicion = "APLAZADOS";
                        }
                        else
                        {
                            modicondicion = "REPROBADO";
                        }
                    
                    //Console.WriteLine($" {nombre[i]}  {promedio[i]}  {modicondicion} "); No funciona esto el cual deberia solo funciona el de abajo
                    p++;
                    
                }
                
            }
            
        }
        
        public void Eliminar_Estudiante()
        {
            Console.WriteLine("Digite su cedula");
            string ced = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < cedula.Length; i++)
            {
                if (cedula[i]==ced)
                {
                    cedula[i] = "";
                    existe = true;
                }
            }
            if (!existe)
            {
                Console.WriteLine("No se encuentra el estudiante");    
            }
        }
        public void ReporteTotal() //Muestra el reporte completo de los estudiantes 
        {
            {
                Console.WriteLine("Cedula    Nombre       Promedio     Condicion");
                Console.WriteLine("=============================================");
                for (int i = 0; i < cedula.Length; i++)
                {
                    Console.WriteLine($"{cedula[i]}        {nombre[i]}         {promedio[i]}        {condicion[i]}");

                }
                Console.WriteLine("=============================================");
                Console.WriteLine("   <PULSE CUALQUIER TECLA PARA ABANDONAR>      ");

            }
        }
        public void Reporte_Condicion() 
        {
            for (byte i = 0; i < condicion.Length; i++) //Saca los datos de la cedula y luego evalua
            {
                if (condicion[p]=="APROBADO")
                {

                    Console.WriteLine("Cedula    Nombre       Promedio     Condicion");
                    Console.WriteLine("=============================================");
                    Console.WriteLine($"{cedula[i]}        {nombre[i]}         {promedio[i]}        {condicion[i]}");
                    Console.WriteLine("=============================================");
                    Console.WriteLine("   <PULSE CUALQUIER TECLA PARA ABANDONAR>      ");
                    Console.WriteLine("");
                }

                else if (condicion[p]=="APLAZADO")
                {

                    Console.WriteLine("Cedula    Nombre       Promedio     Condicion");
                    Console.WriteLine("=============================================");
                    Console.WriteLine($"{cedula[i]}        {nombre[i]}         {promedio[i]}        {condicion[i]}");
                    Console.WriteLine("=============================================");
                    Console.WriteLine("   <PULSE CUALQUIER TECLA PARA ABANDONAR>      ");
                    Console.WriteLine("");
                }

                else
                {
                    Console.WriteLine("Cedula    Nombre       Promedio     Condicion");
                    Console.WriteLine("=============================================");
                    Console.WriteLine($"{cedula[i]}        {nombre[i]}         {promedio[i]}        {condicion[i]}");
                    Console.WriteLine("=============================================");
                    Console.WriteLine("   <PULSE CUALQUIER TECLA PARA ABANDONAR>      ");
                    Console.WriteLine("");
                }
            }
        }
    }

  }

