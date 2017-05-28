
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Coupon
{
    /// <summary>
    /// MinStake: number;
    ///MaxStake: number;
    ///MaxNumberOfCoupons: number;
    ///MinCouponValue: number;
    ///MaxCouponValue: number;
    ///NumberOfPredictions: number;
    /// Type: number;
    /// CouponNames: string;
    /// </summary>
    public class GenerateCouponRequest
    {
        [StringLength(50, ErrorMessage = "{0} alanı en az {2} en çok {1} karakter olmalıdır.", MinimumLength = 4)]
        [Display(Name = "Kupon Adları")]
        public string CouponNames { get; set; }

        [Range(0, 8, ErrorMessage = "Kupon tipi hatalı.")]
        public int Type { get; set; }

        [Range(1, 10, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        public int MinStake { get; set; }

        [Range(1, 10, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        public int MaxStake { get; set; }

        [Range(1, 10, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        [Display(Name = "Max Kupon Sayısı")]
        public int MaxNumberOfCoupons { get; set; }

        [Range(1, 5556, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        [Display(Name = "Min Oran")]
        public decimal MinCouponValue { get; set; }

        [Range(1, 5556, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        [Display(Name = "Max Oran")]
        public decimal MaxCouponValue { get; set; }

        [Range(1, 4, ErrorMessage = "{0}, {1} ve {2} aralığında olmalıdır. ")]
        [Display(Name = "Tahmin Sayısı")]
        public int NumberOfPredictions { get; set; }

        /// <summary>
        /// validation of request
        /// </summary>
        /// <returns></returns>
        public IEnumerable<ValidationResult> Validate()
        {
            if (MaxCouponValue < MinCouponValue)
            {
                yield return
                  new ValidationResult(errorMessage: "Max Oran, Min Orandan küçük olamaz.",
                                       memberNames: new[] { "MaxCouponValue" });
            }

            if ((MaxCouponValue - MinCouponValue) > 20)
            {
                yield return
                  new ValidationResult(errorMessage: "Oranlar arasındaki fark, en fazla 20.00 olabilir.",
                                       memberNames: new[] { "MaxCouponValue" });
            }

            if (MaxStake < MinStake)
            {
                yield return
                  new ValidationResult(errorMessage: "Max Stake, Min Stakeden küçük olamaz.",
                                       memberNames: new[] { "MaxStake" });
            }

            if ((MaxStake - MinStake) > 2)
            {
                yield return
                  new ValidationResult(errorMessage: "En fazla 3 farklı stake seçebilirsiniz.",
                                       memberNames: new[] { "MaxStake" });
            }
        }
    }
}
