namespace Entities.RequestParameters
{
    public class CategoryRequestParameters : RequestParameters
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public CategoryRequestParameters() : this(1, 6)
        {
        }

        public CategoryRequestParameters(int pageNumber = 1, int pageSize = 6)
        {
            PageNumber = pageNumber;
            PageSize = pageSize;
        }
    }
}