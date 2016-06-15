using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Global_Machine
{
    class Producto
   
    {
         private int productid;
        private string productname;
        private string productipe;
        private string betterbef;
        private string provname;
        private int productpos;
        private double productprice;

        private struct Producto
        {

            public int productid;
            public string productname;
            public string productipe;
            public string betterbef;
            public string provname;
            public int productpos;
            public double productprice;
        };

        private static Producto[] products;

    

        //constructor
        public Producto()
        {
         productid = 0;
         productname = "";
         productipe ="";
         betterbef = "";
         provname = "";
         productpos =0;
         productprice =0;

        }

        //contructor con parámetros
        public Producto(int productid, String productname, string productipe, String betterbef, String provname, int productpos, double productprice)
        {
            this.productid = productid;
            this.productname = productname;
            this.productipe = productipe;
            this.betterbef = betterbef;
            this.provname = provname;
            this.productpos = productpos;
            this.productprice = productprice;
        }

        public int getProductid()
        {
            return productid;
        }

        public void setProductid(int productid)
        {
            this.productid = productid;
        }

        public String getProductname()
        {
            return productname;
        }

        public void setProductname(String productname)
        {
            this.productname = productname;
        }

        public string getProductipe()
        {
            return productipe;
        }

        public void setProductipe(string productipe)
        {
            this.productipe = productipe;
        }

        public String getBetterbef()
        {
            return betterbef;
        }

        public void setBetterbef(String betterbef)
        {
            this.betterbef = betterbef;
        }

        public String getProvname()
        {
            return provname;
        }

        public void setProvname(String provname)
        {
            this.provname = provname;
        }

        public int getProductpos()
        {
            return productpos;
        }

        public void setProductpos(int productpos)
        {
            this.productpos = productpos;
        }

        public double getProductprice()
        {
            return productprice;
        }

        public void setProductprice(double productprice)
        {
            this.productprice = productprice;
        }

        

        public void Initdata()
        {
            //inicializar
            for (int i = 0; i < products.Length; i++)
            {

                products[i].productid = 0;
                products[i].productname = "";
                products[i].productipe = "";
                products[i].betterbef= "";
                products[i].provname= "";
                products[i].productpos = 0;
                products[i].productprice= 0;
            }
        }

       
        public bool SeekData(int record)
        {
            //buscar datos
            int i;
            for (i = 0; i < products.Length; i++)
            {
                if (products[i].productid == record)
                {
                    break;
                }
            }

            if (i < products.Length)
            {
                productid = products[i].productid;
                productname = products[i].productname;
                productipe = products[i].productipe;
                betterbef = products[i].betterbef;
                provname = products[i].provname;
                productpos = products[i].productpos;
                productprice = products[i].productprice;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool UpdateData(Producto Producto, int record)
        {
            //actualizar datos
            int i;
            for (i = 0; i < products.Length; i++)
            {
                if (products[i].productid == record)
                {
                    break;
                }
            }

            if (i < products.Length)
            {
                products[i].productid = Producto.productid;
                products[i].productname = Producto.productname;
                products[i].productipe = Producto.productipe;
                products[i].betterbef = Producto.betterbef;
                products[i].provname = Producto.provname;
                products[i].productpos = Producto.productpos;
                products[i].productprice = Producto.productprice;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteData(int record)
        {
            //borrar datos
            int i;
            for (i = 0; i < products.Length; i++)
            {
                if (products[i].productid == record)
                {
                    break;
                }
            }

            if (i < products.Length)
            {
                products[i].productid = 0;
                products[i].productname = "";
                products[i].productipe = "";
                products[i].betterbef = "";
                products[i].provname = "";
                products[i].productpos = 0;
                products[i].productprice = 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void PrintData(int pos)
        {
            //imprimir todo el registro
            productid = products[pos].productid;
            productname = products[pos].productname;
            productipe = products[pos].productipe;
            betterbef = products[pos].betterbef;
            provname = products[pos].provname;
            productpos = products[pos].productpos;
            productprice = products[pos].productprice;
        }

        // destructor
        ~Producto()
        {
        }
    

public int size { get; set; }
    }
}
    

