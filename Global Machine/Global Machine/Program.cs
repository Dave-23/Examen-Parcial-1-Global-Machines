using System;
using System.IO;
using System.Text;

namespace Global_Machine
{
    class Program
    {
        static Producto pro = new Producto();
        static int option = 0;
        static int size = 10;
        static int desc = 0;
        static void AddProducts()
        {
            int r = 0, i= 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < size)
                {
                    Console.WriteLine("*-* Global Machine  *-*");
                    Console.WriteLine("Ingreso de Productos.             ");
                    Console.Write("Digite el ID:                  ");
                    pro.setProductid(int.Parse(Console.ReadLine()));
                    Console.Write("Digite el nombre del producto:    ");
                    pro.setProductname(Console.ReadLine());
                    Console.Write("Digite el tipo de producto:     ");
                    pro.setProductipe(Console.ReadLine());
                    Console.Write("Digite la fecha de vencimineto del  producto:     ");
                    pro.setProductipe(Console.ReadLine());
                    Console.Write("Digite el nombre del proveedor del producto:     ");
                    pro.setProductipe(Console.ReadLine());
                    Console.Write("Seleccione la posicion en el estante del producto del numero 1 al 10:     ");
                    pro.setProductipe(Console.ReadLine());
                    Console.ReadLine();
                    Console.WriteLine("digite el precio del producto:       ");
                    pro.setProductprice(int.Parse(Console.ReadLine()));
                
                    Console.WriteLine("Desea agregar otro Producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de productos lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }


        static void ShowProducts()
        {
            //listar libros
            int reg = 0, i;
            Console.Clear();
            Console.WriteLine("-* Global Machine  *-*");
            Console.WriteLine("Listado de productos.             ");
            for (i = 0; i < pro.size; i++)
            {
                pro.PrintData(i);
                reg = i + 1;
                Console.WriteLine("Registro: " + reg);
                Console.WriteLine("ID:       " + pro.getProductid());
                Console.WriteLine("Nombre:   " + pro.getProductname());
                Console.WriteLine("Tipo:     " + pro.getProductipe());
                Console.WriteLine("Fecha de vencimiento:  " + pro.getBetterbef());
                Console.WriteLine("Nombre de proveedor:   " + pro.getProvname());
                Console.WriteLine("Posicion  en estante:  " + pro.getProductpos());
                Console.WriteLine("Precio:   " + pro.getProductprice());
            }
            Console.ReadKey();
        }

        static void modifyproducts()
        {
            int ID = 0 , reg =0;
            int d = 0;
            int r = 0, i = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < 10)
                {
                    Console.WriteLine("*-* Global Machine  *-*");
                    Console.WriteLine("Modificacion de Productos.             ");
                    Console.WriteLine("");
                    Console.WriteLine("Digite el ID del libro a buscar");
                    ID = int.Parse(Console.ReadLine());
                    if (pro.SeekData(ID) == true)
                    {
                        reg = ID;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("ID:       " + pro.getProductid());
                        Console.WriteLine("Nombre:   " + pro.getProductname());
                        Console.WriteLine("Tipo:     " + pro.getProductipe());
                        Console.WriteLine("Fecha de vencimiento:  " + pro.getBetterbef());
                        Console.WriteLine("Nombre de proveedor:   " + pro.getProvname());
                        Console.WriteLine("Posicion  en estante:  " + pro.getProductpos());
                        Console.WriteLine("Precio:   " + pro.getProductprice());
                    }
                    else
                        Console.WriteLine("No se encontro ese ID");
                    Console.Write("");
                    Console.Write("Edite el nombre del producto:    ");
                    pro.setProductname(Console.ReadLine());
                    Console.Write("Edite el tipo de producto:     ");
                    pro.setProductipe(Console.ReadLine());
                    Console.Write("Edite la fecha de vencimineto del  producto:     ");
                    pro.setProductipe(Console.ReadLine());
                    Console.Write("Edite el nombre del proveedor del producto:     ");
                    pro.setProductipe(Console.ReadLine());
                    Console.Write("Seleccione la posicion en el estante del producto del numero 1 al 10:     ");
                    pro.setProductipe(Console.ReadLine());
                    Console.ReadLine();
                    Console.WriteLine("Edite el precio del producto:       ");
                    pro.setProductprice(int.Parse(Console.ReadLine()));
                    Console.WriteLine("");
                    Console.WriteLine("Desea aplicar descuento al producto 1-Si 2-No");
                    d = int.Parse(Console.ReadLine());
                    if (d == 1)
                    {
                        desc++;
                    }

                    Console.WriteLine("Desea editar otro producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de productos actualizado..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }
        static void eraseproducts()
        {
            int ID = 0, reg = 0, r = 0;

            while (r != 1)

            Console.Clear();
            Console.WriteLine("*-* Global Machine  *-*");
            Console.WriteLine("Eliminador de Productos.           ");
            Console.WriteLine("Digite el ID del producto a buscar");
            ID = int.Parse(Console.ReadLine());
            if (pro.SeekData(ID) == true)
            {
                reg = ID;
                Console.WriteLine("Registro: " + null);
                Console.WriteLine("ID:       " + null);
                Console.WriteLine("Nombre:   " + null);
                Console.WriteLine("Tipo:     " + null);
                Console.WriteLine("Fecha de vencimiento:  " + null);
                Console.WriteLine("Nombre de proveedor:   " + null);
                Console.WriteLine("Posicion  en estante:  " + null);
                Console.WriteLine("Precio:   " +null);
                Console.WriteLine("Limpiado de registro.  ");

            }
            else
             Console.WriteLine("No se encontro ese ID");
             Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
             r = int.Parse(Console.ReadLine());
            Console.WriteLine();
        }

        static void Seekproducts()
        {
            int ID = 0, reg = 0, r = 0;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machine  *-*");
                Console.WriteLine("Búsquedad de Productos.           ");
                Console.WriteLine("Digite el ID del producto a buscar");
                ID = int.Parse(Console.ReadLine());
                if (pro.SeekData(ID) == true)
                {
                    reg = ID;
                    Console.WriteLine("Registro: " + reg);
                    Console.WriteLine("ID:       " + pro.getProductid());
                    Console.WriteLine("Nombre:   " + pro.getProductname());
                    Console.WriteLine("Tipo:     " + pro.getProductipe());
                    Console.WriteLine("Fecha de vencimiento:  " + pro.getBetterbef());
                    Console.WriteLine("Nombre de proveedor:   " + pro.getProvname());
                    Console.WriteLine("Posicion  en estante:  " + pro.getProductpos());
                    Console.WriteLine("Precio:   " + pro.getProductprice());
                }
                else
                    Console.WriteLine("No se encontro ese ID");
                Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }
       
        static void Main(string[] args)
        {
         do
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines  *-*");
                Console.WriteLine("1. Ingreso de productos.");
                Console.WriteLine("2. Modificación de Productos.");
                Console.WriteLine("3. Eliminación de Productos.");
                Console.WriteLine("4. Búsquedas de productos.");
                Console.WriteLine("5. Listado de productos.");
                Console.WriteLine("6. Venta de porductos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AddProducts();
                            break;
                        }
                    case 2:
                        {
                            modifyproducts();
                            break;
                        }
                    case 3:
                        {
                            eraseproducts();
                            break;
                        }
                    case 4:
                        {
                            Seekproducts();
                            break;
                        }
                    case 5:
                        {
                            ShowProducts();
                            break;
                        }
                    case 6:
                        {
                            
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccion inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}