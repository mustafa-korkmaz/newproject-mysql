
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Common.ApiObjects.Request.Coupon
{
    /// <summary>
    ///SetCouponApprovalStatusRequest
    /// </summary>
    public class SetCouponApprovalStatusRequest
    {
        public bool ApprovalStatus { get; set; }

        public int CouponId { get; set; }
    }
}
