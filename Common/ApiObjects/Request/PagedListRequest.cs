using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request
{
    /// <summary>
    /// paged list which returned by betblogger api methods
    /// </summary>
    /// <typeparam name="T"> api paged list generic</typeparam>
    public class PagedListRequest
    {
        /// <summary>
        /// desired start index for PagedList items
        /// </summary>
        ///    [Required]
        [Required]
        [Range(0, 1000, ErrorMessage = "Value for {0} must be between {1} and {2}. ")]
        public int Start { get; set; }

        /// <summary>
        /// desired length of PagedList items
        /// </summary>
        [Required]
        [Range(1, 1000, ErrorMessage = "Value for {0} must be between {1} and {2}. ")]
        public int Length { get; set; }
    }
}