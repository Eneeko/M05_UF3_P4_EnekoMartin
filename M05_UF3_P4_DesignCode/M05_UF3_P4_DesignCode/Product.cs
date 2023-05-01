using System.ComponentModel;
using System.Reflection.Emit;
using static System.Net.Mime.MediaTypeNames;

public class Product
{
    private string ID;
    private string Name;
    private string Description;
    private string Brand;
    private float BasePrice;
    private float Discount;
    private CategoryAttribute Category;
    private Label label;
    //private static Image imagen  //Me da un error al incluir la variable Image por eso esta comentada.
}
