using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2_Menu_Submenus_
{
    class Menu
    {
        static int opcion;
        static Estudiantes estudiantes = new Estudiantes(); //Llama a la clase estudiantes

        public Menu()
        {
            opcion = 0;
        }

        public Menu(int op)  // constructores
        {
            opcion = op;
        }
        public static void principal()
        {
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("1. Inciailizar Vectores");
                Console.WriteLine("2. Incluir Estudiantes");
                Console.WriteLine("3. Consultar Estudiantes");
                Console.WriteLine("4. Modificar Estudiantes");
                Console.WriteLine("5. Eliminar Estudiantes");
                Console.WriteLine("6. Submenu Reportes");
                Console.WriteLine("7. Salir");
                Console.WriteLine("Digite la opcion que desea");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        estudiantes.Inicializar_Vectores();
                        break;
                    case 2:
                        estudiantes.Incluir_Estudiantes();
                        break;
                    case 3:
                        estudiantes.Consultar_Estudiantes();
                        break;
                    case 4: estudiantes.Modificar_Estudiante(); //Pendiente
                        break;
                    case 5: estudiantes.Eliminar_Estudiante();
                        break;
                    case 6:
                        SubMenu();
                        break;
                    
                    default: break;
                }
            } while (opcion != 7);

        }

        static void SubMenu()
        {
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("1. Reporte Estudiantes por Condición");
                Console.WriteLine("2. Reporte Todos los datos");
                Console.WriteLine("3. Regresar Menu Principal");
                Console.WriteLine("Digite la opcion que desea");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: estudiantes.Reporte_Condicion();
                        break;
                    case 2: estudiantes.ReporteTotal();
                        break;
                    case 3: principal();
                        break;
                    default:
                        break;
                }

            } while (opcion != 7);

        }
    }
            
   }


