namespace BookStore.Helpers.Common
{
    public class FilterClass:Paginator
    {
        public string BookGenre { get; set; } = string.Empty;
        public decimal MinPrice { get; set; }
        public decimal MaxPrice { get; set; }

        public string Title { get; set; } = string.Empty;
    }
}
