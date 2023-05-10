namespace ProyectoFinal.Models;

public class SoldProduct
{
    private int id;
    private int idProduct;
    private int stock;
    private int idSale;

    public SoldProduct(int id, int idProduct, int stock, int idSale)
    {
        this.id = id;
        this.idProduct = idProduct;
        this.stock = stock;
        this.idSale = idSale;
    }


    public int Id
    {
        get => id;
        set => id = value;
    }

    public int IdProduct
    {
        get => idProduct;
        set => idProduct = value;
    }

    public int Stock
    {
        get => stock;
        set => stock = value;
    }

    public int IdSale
    {
        get => idSale;
        set => idSale = value;
    }
}