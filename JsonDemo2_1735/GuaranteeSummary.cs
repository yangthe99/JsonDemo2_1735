using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo2_1735
{
    /// <summary>
    /// 擔保單簡要
    /// </summary>
    public class GuaranteeSummary
    {
        /// <summary>
        /// 投資人帳號
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 擔保日期
        /// </summary>
        public string GuaranteeDate { get; set; }
        /// <summary>
        /// 擔保序號
        /// </summary>
        public int GuaranteeSN { get; set; }
        /// <summary>
        /// 委託日期
        /// </summary>
        public string OrderDate { get; set; }
        /// <summary>
        /// 委託序號
        /// </summary>
        public int OrderSN { get; set; }
        /// <summary>
        /// 已申報擔保總金額
        /// </summary>
        public int ReportedGuaranteeAmount { get; set; }
        /// <summary>
        /// 擔保維持率
        /// </summary>
        public decimal GuaranteeRatio { get; set; }
        /// <summary>
        /// 超過擔保規定比率總值
        /// </summary>
        public decimal ExceedingGuaranteeRatio { get; set; }
        /// <summary>
        /// 功能碼
        /// </summary>
        public string FunctionCode { get; set; }
        /// <summary>
        /// 成交狀態
        /// </summary>
        public string Transaction { get; set; }
        /// <summary>
        /// 還券狀態
        /// </summary>
        public string Repayment { get; set; }
        /// <summary>
        /// 擔保單細節
        /// </summary>
        public List<GuaranteeDetail> GuaranteeDetails { get; set; }
    }
}
