
using CSharp_Composizione_Shop;

// DEFINISCO IL MIO SHOP

Shop negozio = new Shop("Despar Teggiano", "Salerno", "Via Oronzo Caldarola", 71, "Alimentare");

// DEFINISCO I PRODOTTI CHE IL MIO SHOP TRATTA
WaterInBottle acquaNaturale = new WaterInBottle("Acqua Naturale", 1.5f, 6.8f, "Rebruant");
// DEFINISCO LE CATEGOIRE PER I MIEI PRODOTTO

Category acquaN = new Category("Acqua" , "Microbiologicamente Pura, Oligominerale, Minimamente Mineralizzata. Indicata per le diete povere di sodio. Può avere effetti diuretici.");

// ASSOCIO I PRODOTTI CON LE LORO CATEGORIE

acquaNaturale.addCategory(acquaN);
negozio.addItem(acquaNaturale);


Console.WriteLine(negozio.InfoShop() + acquaN.GetCateogriesString());

//Stampo le informazioni della mia acqua su console
Console.WriteLine("Quantità in litri: " + acquaNaturale.GetFluidQuantity());
Console.WriteLine("Sorgente di provenienza dell'acqua: "+ acquaNaturale.GetWaterSource());
Console.WriteLine("ph " + acquaNaturale.GetFluidAcidity());


//"Bevo" l'acqua e controllo quanta me ne rimane
acquaNaturale.DrinkWater(1);
Console.WriteLine(acquaNaturale.GetFluidQuantity());
//"Riempio" l'acqua e controllo che ha effettivamente cambiato la quantità
acquaNaturale.RefillWater(0.8f);
Console.WriteLine(acquaNaturale.GetFluidQuantity());
//Mi assicuro che il metodo mi impedisca di bere più di quanto c'è nella bottiglia
acquaNaturale.DrinkWater(10);
Console.WriteLine(acquaNaturale.GetFluidQuantity());
//Funziona anche il metodo per svuotare l'acqua
acquaNaturale.EmptyWater();
Console.WriteLine(acquaNaturale.GetFluidQuantity());

