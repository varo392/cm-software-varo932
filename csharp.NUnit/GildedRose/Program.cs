using System;
using System.Collections.Generic;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        ImprimirTexto("OMGHAI!");

        IList<Item> items = new List<Item>
        {
            // se cambio para que el constructor sobre cargado sea el que se use
            new Item ("+5 Dexterity Vest", 10,20),
            new Item ("Aged Brie", 2, 0),
            new Item ("Elixir of the Mongoose",5,7),
            new Item ("Sulfuras, Hand of Ragnaros",0,80),
            new Item ("Sulfuras, Hand of Ragnaros",-1, 80),
            new Item("Backstage passes to a TAFKAL80ETC concert",15,20),
            new Item("Backstage passes to a TAFKAL80ETC concert",10,49),
            new Item("Backstage passes to a TAFKAL80ETC concert",5,49),
            // this conjured item does not work properly yet
            new Item ("Conjured Mana Cake",3, 6)
        };

        GildedRose Gr = new GildedRose(items);

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var i = 0; i < days; i++)
        {
            ImprimirInicio(i);
            for (var j = 0; j < items.Count; j++)
            {
                ImprimirLinea(Gr,items[j]);
            }

            ImprimirTexto("");
            Gr.UpdateQuality();
        }
    }

    private static void ImprimirLinea(GildedRose Gr, Item It)
    {
        ImprimirTexto(Gr.ImprimirItem(It));

    }

    private static void ImprimirInicio(int i)
    {
        ImprimirTexto("-------- day " + i + " --------");
        ImprimirTexto("name, sellIn, quality");
    }

    private static void ImprimirTexto(string texto)
    {
        Console.WriteLine(texto);
    }

}