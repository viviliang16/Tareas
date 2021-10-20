using System;
using System.Collections.Generic;
using System.Text;

namespace Examen1VivianaLiang
{
    class Servicios
    {
        int numero = 0;
        string[] números_pagos = new string[10];
        DateTime fecha = DateTime.Now;
        DateTime tiempo = DateTime.Now;
        string[] cedula = new string[5];
        string[] nombre = new string[10];
        string[] apellido1 = new string[10];
        string[] apellido2 = new string[10];
        double[] monto_a_pagar = new double[10];
        int[] ts = new int[10];
        int[] nfactura = new int[10];
        double[] comision = new double[10];
        double[] deducido = new double[10];
        double[] vuelto = new double[10];
        double[] pago_total = new double[10];
        int suma = 0;
        int cantidadPagos = 0;              // CANTIDAD de pagos debe reducir cuando se elimina un pago y en otros lados donde agregan pagos 
        double suma1 = 0;
        int p;
        

        public Servicios()
        {
            p = 0;
        }

        public void Inicializar_Vectores()
        {
            for (int i = 0; i < cedula.Length; i++)
            {
                numero = 0;
                números_pagos[i] = "";
                cedula[i] = "";
                nombre[i] = "";
                apellido1[i] = "";
                apellido2[i] = "";
                nfactura[i] = 0;
                monto_a_pagar[i] = 0;
                ts[i] = 0;
                comision[i] = 0;
                deducido[i] = 0;
                vuelto[i] = 0;
                pago_total[i] = 0;

            }
        }
        public void Realizar_Pagos()
        {
            char opcion = 's';

            while ((opcion != 'n') && (p < 10))
                do
                {
                    Console.WriteLine("Digite su numero de pago");
                    números_pagos[p] = Console.ReadLine();
                    Console.WriteLine(fecha.ToShortDateString());
                    Console.WriteLine(tiempo.ToString("HH:mm:dd"));
                    Console.WriteLine("Digite su cedula: ");
                    cedula[p] = Console.ReadLine();
                    Console.WriteLine("Digite su nombre: ");
                    nombre[p] = Console.ReadLine();
                    Console.WriteLine("Digite su apellido: ");
                    apellido1[p] = Console.ReadLine();
                    Console.WriteLine("Digite su segundo apellido: ");
                    apellido2[p] = Console.ReadLine();
                    Console.WriteLine("Digite su numero de factura");
                    nfactura[p] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Su caja es ");
                    Random r = new Random();
                    numero = r.Next(1, 4);
                    Console.WriteLine(numero);
                    Console.WriteLine("Digite el monto a pagar");
                    monto_a_pagar[p] = Convert.ToDouble(Console.ReadLine());
               
                    Console.WriteLine("Digite que tipo desea");
                    Console.WriteLine("1- Recibo de Electricidad");
                    Console.WriteLine("2- Recibo de Telefono");
                    Console.WriteLine("3- Recibo de Agua");
                    ts[p] = Convert.ToInt32(Console.ReadLine());
                    if (ts[p] == 1) //En caso que elija el recibo de luz
                    {
                        comision[p] = monto_a_pagar[p] * 0.04; //Comision/ Deducido se necesita generar automaticamente
                        Console.WriteLine($"{comision[p]}");
                        deducido[p] = monto_a_pagar[p] - comision[p];
                        Console.WriteLine($"{deducido[p]}");
                    }

                    else if (ts[p] == 2) //En caso que se elija el recibo de telefono
                    {
                        comision[p] = monto_a_pagar[p] * 0.055; //Comision/ Deducido se necesita generar automaticamente
                        Console.WriteLine($"{comision[p]}");
                        deducido[p] = monto_a_pagar[p] - comision[p];
                        Console.WriteLine($"{deducido[p]}");
                    }

                    else
                    {
                        comision[p] = monto_a_pagar[p] * 0.065; //Comision/ Deducido se necesita generar automaticamente
                        Console.WriteLine($"{comision[p]}");
                        deducido[p] = monto_a_pagar[p] - comision[p];
                        Console.WriteLine($"{deducido[p]}");
                    }

                    Console.WriteLine("Digite la cantidad total que necesita pagar");
                    pago_total[p] = Convert.ToDouble(Console.ReadLine());
                    if (pago_total[p] >= monto_a_pagar[p] && monto_a_pagar[p] <= pago_total[p])  //PENDIENTE SI ESTA CORRECTO REFERIRSE A LA IMAGEN 1 CH
                    {
                        Console.WriteLine("El monto si alcanza para realizar la transaccion espere un momento");
                    }
                    else
                    {
                        Console.WriteLine("El monto insertado no alcanza para realizar la transacion");
                        Console.WriteLine("Digite nuevamente la cantidad que usara para pagar");
                        pago_total[p] = Convert.ToDouble(Console.ReadLine());
                    }
                    vuelto[p] = pago_total[p] - monto_a_pagar[p]; //PENDIENTE SI ESTA CORRECTO REFERIRSE A LA IMAGEN 1 CH
                    Console.WriteLine($"{vuelto[p]}");
                    p++;
                    cantidadPagos += 1;
                    Console.WriteLine("Desea agregar otro empleado s/n"); //CAMBIAR ESTO 
                    opcion = Convert.ToChar(Console.ReadLine());


                } while (opcion != 'n');

        }
        public void Consultar_Pago()
        {
            Console.WriteLine("Ingrese el numero de pago:");
            string np = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < números_pagos[i].Length; i++)
            {
                if (np.Equals(números_pagos[i]))
                {
                    Console.Clear();
                    Console.WriteLine($" {fecha} {tiempo} {cedula[i]} {nombre[i]} {apellido1[i]} {apellido2[i]}");
                    Console.WriteLine($" {numero} {ts[i]} {nfactura[i]} {monto_a_pagar[i]} {comision[i]} {deducido[i]} {pago_total[i]} {vuelto[i]}");
                    existe = true;
                }
                else if (!existe)
                {
                    Console.WriteLine("Pago no se encuentra Registrado");
                }
            }
        }

        public void Modificar_Pago()
        {
            DateTime modiA = DateTime.Now;
            DateTime modiB = DateTime.Now;
            string modiC = "";
            string modiD = "";
            string modiE = "";
            string modiF = "";
            int modiG = 0;
            int modiH = 0;
            double modiI = 0;
            Boolean encontrado = false;
            Console.WriteLine("Digite su numero de pago");
            string np = Console.ReadLine();
            ConsoleKeyInfo op;
            for (int i = 0; i < números_pagos.Length; i++)
            {
                if (np.Equals(números_pagos[i]))
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Elija el espacio que desea modificar");
                        Console.WriteLine("A - Fecha");
                        Console.WriteLine("B - Hora");
                        Console.WriteLine("C - Cedula");
                        Console.WriteLine("D - Nombre");
                        Console.WriteLine("E - Apellido1");
                        Console.WriteLine("F - Apellido2");
                        Console.WriteLine("G - Tipo de Servicio");
                        Console.WriteLine("H - Número de Factura");
                        Console.WriteLine("I - Paga con Vuelto");
                        Console.WriteLine("Elige una de las opciones");
                        Console.WriteLine("Seleccione una opcion");
                        op = Console.ReadKey(false); //true no muestra la tecla señalada
                        Console.WriteLine("");

                        switch (op.Key)
                        {
                            case ConsoleKey.A:
                                Console.WriteLine("Digite la nueva fecha");
                                modiA = fecha;
                                fecha = modiA; //modiA seria sustituido en fecha
                                Console.WriteLine(fecha.ToShortDateString());
                                break;
                            case ConsoleKey.B:

                                Console.WriteLine("Digite el nuevo tiempo");
                                modiB = tiempo;
                                tiempo = modiB; //modiB seria sustituido en tiempo
                                Console.WriteLine(tiempo.ToString("HH:mm:dd"));
                                break;

                            case ConsoleKey.C:
                                Console.WriteLine("Digite nuevamente su cedula");
                                modiC = Console.ReadLine();
                                cedula[i] = modiC; //modiC seria sustituido en cedula
                                break;

                            case ConsoleKey.D:
                                Console.WriteLine("Digite su nombre");
                                modiD = Console.ReadLine();
                                nombre[i] = modiD; //modiD seria sustituido en nombre

                                break;
                            case ConsoleKey.E:
                                Console.WriteLine("Digite su primer apellido");
                                modiE = Console.ReadLine();
                                apellido1[i] = modiE; //modiE seria sustituido en apellido1
                                break;

                            case ConsoleKey.F:
                                Console.WriteLine("Digite su segundo apellido");
                                modiF = Console.ReadLine();
                                apellido2[i] = modiF; //modiF seria sustituido en apellido2
                                break;

                            case ConsoleKey.G:
                                Console.WriteLine("1- Recibo de Electricidad");
                                Console.WriteLine("2- Recibo de Telefono");
                                Console.WriteLine("3- Recibo de Agua");
                                Console.WriteLine("Digite cual servicio desea");
                                modiG = Convert.ToInt32(Console.ReadLine());
                                ts[i] = modiG; //modiG seria sustituido en tipo de servicio
                                if (ts[i] == 1) //En caso que eliga el recibo de luz
                                {
                                    comision[i] = monto_a_pagar[i] * 0.04; //Comision/ Deducido se necesita generar automaticamente
                                    Console.WriteLine($"{comision[i]}");
                                    deducido[i] = monto_a_pagar[i] - comision[i];
                                    Console.WriteLine($"{deducido[i]}");
                                }

                                else if (ts[i] == 2)
                                {
                                    comision[i] = monto_a_pagar[i] * 0.055; //Comision/ Deducido se necesita generar automaticamente
                                    Console.WriteLine($"{comision[i]}");
                                    deducido[i] = monto_a_pagar[i] - comision[i];
                                    Console.WriteLine($"{deducido[i]}");
                                }

                                else
                                {
                                    comision[p] = monto_a_pagar[i] * 0.065; //Comision/ Deducido se necesita generar automaticamente
                                    Console.WriteLine($"{comision[i]}");
                                    deducido[i] = monto_a_pagar[i] - comision[i];
                                    Console.WriteLine($"{deducido[i]}");
                                }
                                break;

                            case ConsoleKey.H:
                                Console.WriteLine("Digite nuevamente el numero de factura ");
                                modiH = Convert.ToInt32(Console.ReadLine());
                                nfactura[i] = modiH; //modiH seria sustituido en numero de factura
                                break;

                            case ConsoleKey.I:
                                Console.WriteLine("Digite nuevamente el pago total");
                                modiI = Convert.ToDouble(Console.ReadLine());

                                if (números_pagos[i] == np)
                                    pago_total[i] = modiI; //modiI seria sustituido en pago con vuelto

                                Console.WriteLine("Digite la cantidad total que necesita pagar");
                                pago_total[i] = Convert.ToDouble(Console.ReadLine());
                                if (pago_total[i] >= monto_a_pagar[i] && monto_a_pagar[i] <= pago_total[i]) //PENDIENTE SI ESTA CORRECTO REFERIRSE A LA IMAGEN 1 CH
                                {
                                    Console.WriteLine("El monto si alcanza para realizar la transaccion espere un momento");
                                }
                                else
                                {
                                    Console.WriteLine("El monto insertado no alcanza para realizar la transacion");
                                    Console.WriteLine("Digite nuevamente la cantidad que usara para pagar");
                                    pago_total[i] = Convert.ToDouble(Console.ReadLine());
                                }
                                vuelto[i] = pago_total[i] - monto_a_pagar[i]; //PENDIENTE SI ESTA CORRECTO REFERIRSE A LA IMAGEN 1 CH
                                Console.WriteLine($"{vuelto[i]}");
                                break;

                            default:
                                break;

                        }
                        encontrado = true;

                    } while (op.Key != ConsoleKey.Escape);
                }
                if (!encontrado)
                {
                    Console.WriteLine("“Pago no se encuentra Registrado”.");
                }
            }

        }

        public void Eliminar_Pago() //PENDIENTE EL ORDEN NO ES CORRECTO REVISAR IMAGEN 2
        {
            Console.WriteLine("Digite su numero de pago");
            string np = Console.ReadLine();
            Boolean existe = false;
            for (int i = 0; i < números_pagos.Length; i++)
            {
                if (números_pagos[i] == np)
                {
                    char opcion = 'n';
                    Console.Clear();
                    Console.WriteLine("Esta seguro de eliminar el dato s/n?");
                    opcion = Convert.ToChar(Console.ReadLine());
                    if (opcion == 's') 
       
                    {
                        //Console.Clear();
                        números_pagos[i] = "";


                        //Console.WriteLine("Esta seguro de eliminar el dato s/n?");
                        //opcion = Convert.ToChar(Console.ReadLine());
                        Console.WriteLine("La informacion ya fue eliminada");
                        existe = true;
                        opcion = 'n';
                    }
                    else { Console.WriteLine("La informacion no fue eliminada"); existe = true; }



                }
                //else { Console.WriteLine("La informacion no fue eliminada"); }
                
            }
            if (!existe)
            {
                Console.WriteLine("Pago no se encuentra registrado");
            }

        }

        static int opcion = 0;
        public void Pagos_por_Tipo_de_Servicio()
        {
            suma = 0;
            do
            {
                Console.WriteLine("Digite el tipo de servicio que desea ");
                Console.WriteLine("1- Recibo de Electricidad");
                Console.WriteLine("2- Recibo de Telefono");
                Console.WriteLine("3- Recibo de Agua");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("#Pago         Fecha/ Hora Pago                Cedula            Nombre             Apellido1          Apellido 2         Monto Recibo");
                        Console.WriteLine();
                        Console.WriteLine("=============================================================================================================================================");
                        Console.WriteLine();
                        for (int i = 0; i < números_pagos.Length; i++)
                        {
                      
                            if (ts[i].Equals(1))
                            {
                                suma1 += monto_a_pagar[i];
                                suma = suma + ts[i];
                               
                                Console.WriteLine($" {números_pagos[i]}            {fecha}           {cedula[i]}              {nombre[i]}            {apellido1[i]}           {apellido2[i]}                 {monto_a_pagar[i]} ");
                                
                                
                            }
                            

                            //EL CALCULO NO SALE CORRECTAMENTE
                            //REFERIRSE A LA IMAGEN 3
                        }
                        Console.WriteLine();
                        Console.WriteLine($" Total de Registros: {suma}                      Monto Total {suma1}");
                        Console.WriteLine();
                        break;
                    case 2:
                        for (int i = 0; i < números_pagos.Length; i++)
                        {
                            if (ts[i].Equals(2))
                            {
                                Console.WriteLine("#Pago  Fecha/ Hora Pago Cedula Nombre Apellido1 Aoellido 2 Monto Recibo");
                                Console.WriteLine($" {números_pagos[i]} {fecha} {tiempo} {cedula[i]} {nombre[i]} {vuelto[i]} ");
                            }
                            suma = suma + ts[i]; suma1 = suma1 + vuelto[i];

                            Console.WriteLine($" Total de Registros: {suma}                      Monto Total {suma1}"); //EL CALCULO NO SALE CORRECTAMENTE CH
                                                                                                                        //REFERIRSE A LA IMAGEN 3 CH 
                        }
                        break;
                    case 3:
                        for (int i = 0; i < números_pagos.Length; i++)
                        {
                            if (ts[i].Equals(3))
                            {
                                Console.WriteLine("#Pago  Fecha/ Hora Pago Cedula Nombre Apellido1 Aoellido 2 Monto Recibo");
                                Console.WriteLine($" {números_pagos[i]} {fecha} {tiempo} {cedula[i]} {nombre[i]} {vuelto[i]} ");

                                suma = suma + ts[i]; suma1 = suma1 + vuelto[i];
                            }
                            
                        }
                        Console.WriteLine($" Total de Registros: {suma}                      Monto Total {suma1}"); //EL CALCULO NO SALE CORRECTAMENTE
                                                                                                                    //REFERIRSE A LA IMAGEN 3
                        break;
                    default:
                        break;
                }
                
            }while(opcion!=4);
        }

        public void Pagos_por_Codigo_de_Caja()
        {
            do
            {
                Console.WriteLine("Digite el tipo de servicio que desea ");
                Console.WriteLine("1- Recibo de Electricidad");
                Console.WriteLine("2- Recibo de Telefono");
                Console.WriteLine("3- Recibo de Agua");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        for (int i = 0; i < números_pagos.Length; i++)
                        {
                            if (numero.Equals(1))
                            {
                                Console.WriteLine("#Pago  Fecha/ Hora Pago Cedula Nombre Apellido1 Aoellido 2 Monto Recibo");
                                Console.WriteLine($" {números_pagos[i]} {fecha} {tiempo} {cedula[i]} {nombre[i]} {vuelto[i]} ");
                            }
                            suma = suma + ts[i]; suma1 = suma1 + vuelto[i];

                            Console.WriteLine($" Total de Registros: {suma}                      Monto Total {suma1}"); //EL CALCULO NO SALE CORRECTAMENTE
                                                                                                                        //REFERIRSE A LA IMAGEN 3
                        }
                        break;
                    case 2:
                        for (int i = 0; i < números_pagos.Length; i++)
                        {
                            if (numero.Equals(2))
                            {
                                Console.WriteLine("#Pago  Fecha/ Hora Pago Cedula Nombre Apellido1 Aoellido 2 Monto Recibo");
                                Console.WriteLine($" {números_pagos[i]} {fecha} {tiempo} {cedula[i]} {nombre[i]} {vuelto[i]} ");
                            }
                            suma = suma + ts[i]; suma1 = suma1 + vuelto[i];

                            Console.WriteLine($" Total de Registros: {suma}                      Monto Total {suma1}"); //EL CALCULO NO SALE CORRECTAMENTE
                                                                                                                        //REFERIRSE A LA IMAGEN 3
                        }
                        break;

                    case 3:
                        for (int i = 0; i < números_pagos.Length; i++)
                        {
                            if (numero.Equals(3))
                            {
                                Console.WriteLine("#Pago  Fecha/ Hora Pago Cedula Nombre Apellido1 Aoellido 2 Monto Recibo");
                                Console.WriteLine($" {números_pagos[i]} {fecha} {tiempo} {cedula[i]} {nombre[i]} {vuelto[i]} ");
                            }
                            suma = suma + ts[i]; suma1 = suma1 + vuelto[i];

                            Console.WriteLine($" Total de Registros: {suma}                      Monto Total {suma1}"); //EL CALCULO NO SALE CORRECTAMENTE
                                                                                                                        //REFERIRSE A LA IMAGEN 3
                        }
                        break;

                    default:
                        break;
                }
            } while (opcion!=4);
        }

        public void Dinero_Comisionado_por_servidos() //NO PUDE HACERLO DEBERIA QUEDAR COMO IMAGEN 4 CH
        {
            Console.WriteLine("Reporte Dinero Comisionado- Desglose por Tipo de Servicio");
            Console.WriteLine("===========================================================================================================================================================================================");
            Console.WriteLine("ITEM                          Cant.Transacciones                  Total Comisionado ");
            int transaccionesElect = 0;
            double comisionElect = 0; 
            for(int i=0;i < cantidadPagos; i++)
            {
                if (ts[i].Equals(1))
                {
                    transaccionesElect += 1;
                    comisionElect += comision[i];

                }

            }
            Console.WriteLine("===========================================================================================================================================================================================");
            Console.WriteLine($" {1}    {transaccionesElect}      {comisionElect}        ");
        }
        public void Reporte_Todos_los_Pagos() //SALE ALGO EXTRAÑO CUANDO LO PRUEBO CH
        {
            Console.WriteLine("Numero de pagos    Cedula       Nombre     Primer Apellido    Segundo Apellido    Numero de factura    Monto a pagar     Tipo de servicio    Comision     Deducido     Vuelto    Pago Total");
            Console.WriteLine("===========================================================================================================================================================================================");
            for (int i = 0; i < cantidadPagos; i++)
            {
                try
                {
                    Console.WriteLine($" {fecha}  {números_pagos[i]}     {cedula[i]}     {nombre[i]}     {apellido1[i]}  {apellido2[i]}  {numero}    ");
                    Console.WriteLine($" {nfactura[i]}    {monto_a_pagar[i]}      {ts[i]}        {comision[i]}     {deducido[i]}   {vuelto[i]}   {pago_total[i]}");
                    Console.WriteLine("============================================================================================================================================================================================");
                    Console.WriteLine("   <PULSE CUALQUIER TECLA PARA ABANDONAR>      ");
                }
                catch
                {
                    Console.WriteLine("   <Espacio Vacio>      ");
                }
            }

        }

    }
}

