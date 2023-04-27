using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Composizione_Shop
{
    public class itemShop
    {
        private protected string name;
        private protected List<Category> categories;
        // COSTRUTTORE

        public itemShop(string name)
        {
            this.name = name;
            this.categories = new List<Category>();
        }

        // GETTERS 

        public string GetName()
        {
            return this.name;
        }

        public List<Category> GetCategoriesList()
        {
            return this.categories;
        }


        public string GetItemString()
        {
            string rapprString = "Nome prodotto: " + this.name + "\n";
            rapprString += "\t Categorie prodotto: \n";
            foreach (Category categoriaScansionata in categories)
            {
                rapprString += "\t - " + categoriaScansionata.GetName() + "\n";
            }

            return rapprString;

        }

        public void addCategory(Category newCategory)
        {
            this.categories.Add(newCategory);
        }

        internal bool GetFluidSource()
        {
            throw new NotImplementedException();
        }
    }
    class WaterInBottle : itemShop
    {
        private protected float quantity = 1.3f;
        private protected float acidityPH;
        private protected string sorgente = "";

        public WaterInBottle(string name, float quantity, float acidityPH, string sorgente) : base(name)
        {
            name = "";
            this.quantity = quantity;
            this.acidityPH = acidityPH;
            this.quantity = quantity;
            this.sorgente = sorgente;


        }

        public static float ConvertToGallons ()
        {
            float quantityUSGal = 0f;
            quantityUSGal = quantity / 3.785;
            return quantityUSGal;

        }


        public float GetFluidQuantity()
        {
            return this.quantity;

        }

        public float GetFluidAcidity()
        {
            return this.acidityPH;

        }

        public string GetWaterSource()
        {
            return this.sorgente;
        }

        public float DrinkWater(float x)
        {
            if (x > this.quantity) {
                Console.WriteLine("Non puoi bere più acqua di quella contenuta nella bottiglia!");
            } else

            this.quantity = this.quantity - x;
            return this.quantity;
        }

        public float RefillWater(float y) {

            this.quantity = this.quantity + y;
            if (this.quantity <= 1.5)
            {
                return this.quantity;
            }
            else this.quantity = 1.5f;
            return this.quantity;
    
        
        }
        
        public float EmptyWater()
        {
            this.quantity = 0;
            return this.quantity;
        }

      




    }

}
