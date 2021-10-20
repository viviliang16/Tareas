using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1VivianaLiang
{
    class Menu
    {
        static int opcion;
        static Servicios servicio = new Servicios(); //Llama a la clase servicios
        public Menu()
        {
            opcion = 0;
        }

        public Menu(int op)  // constructores
        {
            opcion = op;
        }
        public static void principal() //Menu Principal
        {
            do
            {
                Console.WriteLine("***************************************");
                Console.WriteLine("1. Inciailizar Vectores");
                Console.WriteLine("2. Realizar_Pagos");
                Console.WriteLine("3. Consultar_Pagos");
                Console.WriteLine("4. Modificar_Pagos");
                Console.WriteLine("5. Eliminar_Pagos");
                Console.WriteLine("6. Submenu Reportes");
                Console.WriteLine("7. Salir");
                Console.WriteLine("Digite la opcion que desea");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        servicio.Inicializar_Vectores();
                        break;
                    case 2:
                        servicio.Realizar_Pagos();
                        break;
                    case 3:
                        servicio.Consultar_Pago();
                        break;
                    case 4:
                        servicio.Modificar_Pago(); 
                        break;
                    case 5:
                        servicio.Eliminar_Pago();
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
                Console.WriteLine("1.Ver todos los Pagos");
                Console.WriteLine("2.Ver Pagos por tipo de Servicio");
                Console.WriteLine("3.Ver Pagos por código de caja");
                Console.WriteLine("4.Ver Dinero Comisionado por servicios");
                Console.WriteLine("5.Regresar Menú Principal");
                Console.WriteLine("Digite la opcion que desea");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                       servicio.Reporte_Todos_los_Pagos();
                        break;
                    case 2:
                        servicio.Pagos_por_Tipo_de_Servicio();
                        break;
                    case 3:
                        servicio.Pagos_por_Codigo_de_Caja();
                        break;
                    case 4:
                        servicio.Dinero_Comisionado_por_servidos();
                        break;

                    case 5:
                        principal();
                        break;
                    default:
                        break;
                }

            } while (opcion != 7);

        }
    }
}
