using System;

namespace Template.Common.Pagination {
    public class Pageable : IPageable {
        public Pageable(int pageNumber, int pageSize,string filters,string order, Sort sort = null)
        {
            if (pageNumber < 0)
                throw new ArgumentNullException(nameof(pageNumber), "Page Number must not be less than zero!");

            if (pageSize < 1) throw new ArgumentNullException(nameof(pageSize), "Page Size must not be less than one!");
            Filters = filters;
            Order = order;
            PageNumber = pageNumber;
            PageSize = pageSize;
            Sort = sort ?? Sort.Unsorted;
        }

        public IPageable Previous => new Pageable(PageNumber - 1, PageSize, Filters,Order, Sort);
        public bool IsPaged => true;
        public string Filters { get; }
        public string Order { get; }
        public int PageNumber { get; }
        public int PageSize { get; }

        public int Offset => PageNumber * PageSize;
        public Sort Sort { get; }

        public IPageable Next => new Pageable(PageNumber + 1, PageSize, Filters,Order, Sort);

        public IPageable PreviousOrFirst => HasPrevious ? Previous : First;

        public IPageable First => new Pageable(0, PageSize, Filters,Order, Sort);

        public bool HasPrevious => PageNumber > 0;

        public static Pageable Of(int pageNumber, int pageSize,string filters, string order, Sort sort = null)
        {
            return new Pageable(pageNumber, pageSize, filters, order, sort);
        }

        public static Pageable Of(int pageNumber, int pageSize, string filters, string order, Direction direction, params string[] properties)
        {
            return new Pageable(pageNumber, pageSize, filters, order, new Sort(direction, properties));
        }
    }
}
