namespace MuOnline.Infrastructure.Core.Models
{
    public class ListResultDto<T> : IListResult<T>
    {
        public IReadOnlyList<T> Items
        {
            get => _items ?? (_items = new List<T>());
            set => _items = value;
        }
        private IReadOnlyList<T> _items;

        public ListResultDto()
        {
        }

        public ListResultDto(IReadOnlyList<T> items)
        {
            Items = items;
        }
    }
}
