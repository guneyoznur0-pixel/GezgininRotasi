using SQLite;

namespace GezginRotası2;

[Table("Places")]
public class Place
{
    [PrimaryKey, AutoIncrement]
    public int Id { get; set; }

    public string? Name { get; set; }
    public string? Location { get; set; }
    public string? Category { get; set; }
    public string? ImageUrl { get; set; }
    public string? Description { get; set; }
    public double Rating { get; set; }
}