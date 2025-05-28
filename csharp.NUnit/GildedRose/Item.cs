using System.Data;

namespace GildedRoseKata;

public class Item
{
    /// <summary>
    /// / todos los metodos se cambian a privados 
    /// para que solo se puedan acceder con la clase. 
    /// </summary>
    public string Name { get; set; }
    public int SellIn { get; set; }
    public int Quality { get; set; }

    /// es necesario el metodo contructor sobre cargado para pasar valores
    public Item(string name, int sellIn, int quality)
    {
        this.Name = name;
        this.SellIn = sellIn;
        this.Quality = quality;
    }

    // son necesarios los metodos por defecto 
    // para limpiar basura de la memoria
    public Item()
    {
        this.Name = "";
        this.SellIn = 0;
        this.Quality = 0;
    }
    
}