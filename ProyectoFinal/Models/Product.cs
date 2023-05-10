namespace ProyectoFinal.Models;

public class Product
{

   private int id;
   private string description;
   private double price;
   private double stockPrice;
   private int stock;
   private int idUser;

   public Product(int id, string description, double price, double stockPrice, int stock, int idUser)
   {
      this.id = id;
      this.description = description;
      this.price = price;
      this.stockPrice = stockPrice;
      this.stock = stock;
      this.idUser = idUser;
   }


   public int Id
   {
      get => id;
      set => id = value;
   }

   public string Description
   {
      get => description;
      set => description = value ?? throw new ArgumentNullException(nameof(value));
   }

   public double Price
   {
      get => price;
      set => price = value;
   }

   public double StockPrice
   {
      get => stockPrice;
      set => stockPrice = value;
   }

   public int Stock
   {
      get => stock;
      set => stock = value;
   }

   public int IdUser
   {
      get => idUser;
      set => idUser = value;
   }
}