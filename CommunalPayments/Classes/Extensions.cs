using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CommunalPayments
{
    public static class Extensions
    {
        /// <summary>
        /// Получает из запроса первый объект, Id которого равен заданному значению
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public static TSource ById<TSource>(this IQueryable<TSource> query, int id) where TSource : class
        {
            ParameterExpression parameter = Expression.Parameter(typeof(TSource), "x");
            Expression expression = Expression.Property(parameter, "Id");
            expression = Expression.Equal(expression, Expression.Constant(id));
            Expression<Func<TSource, bool>> resultEx = Expression.Lambda<Func<TSource, bool>>(expression, parameter);
            return query.FirstOrDefault(resultEx);
        }

        /// <summary>
        /// Returns empty string if current object is null else calls ToString()
        /// </summary>
        public static string ToSafeString(this object obj)
            => obj == null ? "" : obj.ToString();

        /// <summary>
        /// Parse to int (0 - if can't parse)
        /// </summary>
        public static int ToInt(this object obj)
        {
            if (obj is int) return (int)obj;
            if (obj is double) return Convert.ToInt32((double)obj);
            if (obj is decimal) return Convert.ToInt32((decimal)obj);
            if (obj is float) return Convert.ToInt32((float)obj);
            if (obj is bool) return (bool)obj ? 1 : 0;
            try
            {
                return int.Parse(obj.ToString());
            }
            catch
            {
                return 0;
            }
        }

        /// <summary>
        /// Parse to double (0 - if can't parse)
        /// </summary>
        public static double ToDouble(this object obj)
        {
            if (obj is int) return Convert.ToDouble((int)obj);
            if (obj is double) return (double)obj;
            if (obj is decimal) return Convert.ToDouble((decimal)obj);
            if (obj is float) return Convert.ToDouble((float)obj);
            try
            {
                return double.Parse(obj.ToString().Replace('.', ','));
            }
            catch
            {
                return 0.0;
            }
        }
    }
}
