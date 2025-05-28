using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Runtime.CompilerServices;

namespace GildedRoseKata;

public class GildedRose
{
    IList<Item> Items;

    public GildedRose(IList<Item> Items)
    {
        this.Items = Items;
    }

    public void UpdateQuality()
    {

        /// se redujeron todas las condiones anteriores en lugar de tener un for con varias consultas, 
        /// se cambio a la funciones nativas del sistemas c# de linq  quitando la interacion  con el ciclo directamente 
        
        //cubre Primer if  de ciclo anterior
        Items.Where(Item => Item.Name != "Aged Brie" && Item.Name != "Backstage passes to a TAFKAL80ETC concert" && Item.Quality > 0 && Item.Name != "Sulfuras, Hand of Ragnaros")
        .ToList()
        .ForEach(Item => { Item.Quality = Item.Quality - 1; });

        ////cubre Primer else de ciclo anterior
        Items.Where(Item => Item.Name == "Aged Brie" && Item.Name == "Backstage passes to a TAFKAL80ETC concert" && Item.Quality < 50 )
        .ToList()
        .ForEach(Item => { Item.Quality = Item.Quality + 1;});

      // cubre segundo y  tercer   else
        Items.Where(Item => Item.Name == "Aged Brie" && Item.Name == "Backstage passes to a TAFKAL80ETC concert"  && Item.SellIn < 11  && Item.Quality < 50 )
        .ToList()
        .ForEach(Item => { Item.Quality = Item.Quality + 1;});

        // Seleccionar y multiplicar por 2, creando una nueva lista
        Items.Where(Item => Item.Name != "Sulfuras, Hand of Ragnaros")
        .ToList()
        .ForEach(Item => { Item.SellIn = Item.SellIn - 1; });

        // cubre  Primer else if  
        Items.Where(Item => Item.SellIn < 0  && Item.Name != "Aged Brie" && Item.Name != "Backstage passes to a TAFKAL80ETC concert" && Item.Quality > 0 && Item.Name != "Sulfuras, Hand of Ragnaros")
        .ToList()
        .ForEach(Item => {  Item.Quality = Item.Quality - 1;});

        // cubre  Primer else if  penultimo else 
        Items.Where(Item => Item.SellIn < 0  && Item.Name != "Aged Brie" && Item.Name == "Backstage passes to a TAFKAL80ETC concert")
        .ToList()
        .ForEach(Item => {  Item.Quality = Item.Quality - Item.Quality;});

        //  cubre Primer else if  Ultimo escenario del if 
        Items.Where(Item => Item.SellIn < 0 && Item.Quality < 50 && Item.Name == "Aged Brie")
        .ToList()
        .ForEach(Item => { Item.Quality = Item.Quality + 1; });

    }
}