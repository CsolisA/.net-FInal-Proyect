namespace ProyectoFinal.Models;

public class Sale
{
    private int id;
    private string comment;
    private int userId;

    public Sale(int id, string comment, int userId)
    {
        this.id = id;
        this.comment = comment;
        this.userId = userId;
    }

    public int Id
    {
        get => id;
        set => id = value;
    }

    public string Comment
    {
        get => comment;
        set => comment = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int UserId
    {
        get => userId;
        set => userId = value;
    }
}