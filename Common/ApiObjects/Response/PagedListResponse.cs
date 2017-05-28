
using System.Collections.Generic;
using System.Linq;

namespace Common.ApiObjects.Response
{
    /// <summary>
    /// paged list which returned by betblogger api methods
    /// </summary>
    /// <typeparam name="T"> api paged list generic</typeparam>
    public class PagedListResponse<T> : IPagedList
    {
        /// <summary>
        /// Paged list items
        /// </summary>
        public IEnumerable<T> Items { get; set; }

        /// <summary>
        /// Returns if the result in the first page or not
        /// </summary>
        public bool isFirstPage => Start == 0;

        /// <summary>
        /// Returns if the result in the last page or not
        /// </summary>
        public bool isLastPage
        {
            get
            {
                if (Items == null)
                {
                    return true;
                }

                return Items.Count() < Length;
            }
        }

        public int Start { get; set; }
        public int Length { get; set; }
        public int RecordsTotal { get; set; }
    }

    public interface IPagedList
    {
        /// <summary>
        /// Requested start index of paged list
        /// </summary>
        int Start { get; set; }

        /// <summary>
        /// Returned length of paged list
        /// </summary>
        int Length { set; get; }

        /// <summary>
        /// Total records of paged list items
        /// </summary>
        int RecordsTotal { get; set; }
    }
}
