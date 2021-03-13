namespace Template.Common.Pagination.Binders {
    public class PageableBinderConfig {
        public const string DefaultPageParameter = "page";

        public const string DefaultSizeParameter = "size";

        public const string DefaultFilterParameter = "filter";
        public const string DefaultOrderParameter = "order";

        public const string DefaultPrefix = "";

        public const string DefaultQualifierDelimiter = "_";

        public const int DefaultMaxPageSize = 2000;

        public static readonly IPageable DefaultPageable = Pageable.Of(0, 20,"","");

        public IPageable FallbackPageable { get; set; } = DefaultPageable;
        public string PageParameterName { get; set; } = DefaultPageParameter;

        public string FilterParameterName { get; set; } = DefaultFilterParameter;
        public string OrderParameterName { get; set; } = DefaultOrderParameter;
        public string SizeParameterName { get; set; } = DefaultSizeParameter;
        public string Prefix { get; set; } = DefaultPrefix;
        public string QualifierDelimiter { get; set; } = DefaultQualifierDelimiter;
        public int MaxPageSize { get; set; } = DefaultMaxPageSize;
    }
}
