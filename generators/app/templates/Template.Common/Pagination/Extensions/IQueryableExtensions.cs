using System;
using System.Linq;
using System.Threading.Tasks;
using Template.Common.Pagination.Binders;
using System.Linq.Dynamic.Core;
using System.Collections.Generic;

namespace Template.Common.Pagination.Extensions
{
    public static class QueryableExtensions
    {
        public static IPage<TEntity> UsePageable<TEntity>(this IQueryable<TEntity> receiver, IPageable pageable)
            where TEntity : class
        {
            var filter = DoFilter(receiver, pageable);
            var order = SetOrder(filter, pageable);
            var entities = order.Skip(pageable.Offset)
                .Take(Math.Min(pageable.PageSize, PageableBinderConfig.DefaultMaxPageSize));
            return new Page<TEntity>(entities.ToList(), pageable, order.Count());
        }

        public static async Task<IPage<TEntity>> UsePageableAsync<TEntity>(this IQueryable<TEntity> receiver, IPageable pageable)
          where TEntity : class
        {
            return await Task.Run(() =>
              {
                  var filter = DoFilter(receiver, pageable);
                  var order = SetOrder(filter, pageable);
                  var entities = order.Skip(pageable.Offset)
                      .Take(Math.Min(pageable.PageSize, PageableBinderConfig.DefaultMaxPageSize));
                  return new Page<TEntity>(entities.ToList(), pageable, order.Count());
              }
              );
        }

        #region Filter
        private static IQueryable<TEntity> DoFilter<TEntity>(IQueryable<TEntity> receiver, IPageable pageable)
        {
            if (pageable.Filters != null && pageable.Filters != "")
            {
                var Conditions = getConditions(pageable.Filters);
                int i = 0;
                string con = "";
                string[] value = new string[Conditions.Count];
                foreach (var item in Conditions)
                {
                    con += item.Key + "" + item.Value.ConditionType + " (@" + i + ")" + (i == Conditions.Count() - 1 ? "" : " and ");
                    value[i] = item.Value.value;
                    i++;
                }
                return receiver.Where(con, value);
            }
            return receiver;
        }

        private static Dictionary<string, Condition> getConditions(string Conditions)
        {
            Dictionary<string, Condition> keyValueCondition = new Dictionary<string, Condition>();
            var Fields = Conditions.Split('&');
            foreach (var field in Fields)
            {

                if (field.Contains("♥"))
                {
                    var keyvalue = field.Split('♥');
                    keyValueCondition.Add(keyvalue[0], new Condition() { value = keyvalue[1], ConditionType = "==" });
                }
                else if (field.Contains("$"))
                {
                    var keyvalue = field.Split('$');
                    keyValueCondition.Add(keyvalue[0], new Condition() { value = keyvalue[1], ConditionType = ".Contains" });
                }


            }

            return keyValueCondition;
        }

        public class Condition
        {
            public string value { get; set; }
            public string ConditionType { get; set; }
        }
        #endregion

        #region Order
        private static IQueryable<TEntity> SetOrder<TEntity>(IQueryable<TEntity> receiver, IPageable pageable)
        {
            if (pageable.Order != null && pageable.Order != "")
            {
                var property = pageable.Order.Split(':');
                if (property[1] == "ASC")
                {
                    return receiver.OrderBy(property[0]);
                }
                else
                {
                    return receiver.OrderBy(property[0] + " descending");
                }


            }
            return receiver;
        }

        #endregion
    }
}
