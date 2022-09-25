using MuOnline.Infrastructure.Core.Models;
using System.Linq.Expressions;

namespace MuOnline.Infrastructure.Core.Extensions
{
    public static class QueryableExtensions
    {
        public static IQueryable<T> PageBy<T>(this IQueryable<T> query, int skipCount, int maxResultCount)
        {
            if (query == null)
            {
                throw new ArgumentNullException(nameof(query));
            }

            return query.Skip(skipCount).Take(maxResultCount);
        }

        public static IQueryable<T> PageBy<T>(this IQueryable<T> query, IPagedResultRequest pagedResultRequest)
        {
            return query.PageBy(pagedResultRequest.SkipCount, pagedResultRequest.MaxResultCount);
        }

        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate)
        {
            return condition
                ? query.Where(predicate)
                : query;
        }

        public static IQueryable<T> WhereIf<T>(this IQueryable<T> query, bool condition, Expression<Func<T, int, bool>> predicate)
        {
            return condition
                ? query.Where(predicate)
                : query;
        }

        public static IQueryable<TEntity> ApplyPaging<TEntity, TInput>(this IQueryable<TEntity> query, TInput input)
            where TEntity : class
        {
            // Try to use paging if available
            if (input is IPagedResultRequest pagedInput)
            {
                return query.PageBy(pagedInput);
            }

            // Try to limit query result if available
            if (input is ILimitedResultRequest limitedInput)
            {
                return query.Take(limitedInput.MaxResultCount);
            }

            // No paging
            return query;
        }
    }
}
