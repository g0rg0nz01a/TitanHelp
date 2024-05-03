//Author: Luke Kelley
namespace TitanHelp.Controllers;

public class PaginatedList<T> : List<T>
{
    public int PageNumber { get; private set; }
    public int TotalPages { get; private set; }

    public PaginatedList(List<T> items, int count, int pageNumber, int pageSize)
    {
        PageNumber = pageNumber;
        TotalPages = (int)Math.Ceiling(count / (double)pageSize);

        AddRange(items);
    }

    public bool HasPreviousPage
    {
        get { return PageNumber > 1; }
    }

    public bool HasNextPage
    {
        get { return PageNumber < TotalPages; }
    }

    public int? PreviousPageNumber
    {
        get { return HasPreviousPage ? PageNumber - 1 : null; }
    }

    public int? NextPageNumber
    {
        get { return HasNextPage ? PageNumber + 1 : null; }
    }
}