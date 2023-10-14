namespace TodoApi.Models;

/// <summary>
/// A date is a date
/// </summary>
/// <param name="Id">The id of the date</param>
/// <param name="TDate">The date</param>
/// <param name="Action">The action of the date</param>

public class Date
{
    public int Id { get; set; }
    public DateTime TDate { get; set; }
    public DateType Action { get; set; }
}

/// <summary>
/// The type of the date
/// </summary>
/// <param name="CreatedAt">The date of creation</param>
/// <param name="UpdatedAt">The date of update</param>
/// <param name="DeletedAt">The date of deletion</param>
/// <param name="CompletedAt">The date of completion</param>
public enum DateType
{
    CreatedAt,
    UpdatedAt,
    CompletedAt,
    DeletedAt
}