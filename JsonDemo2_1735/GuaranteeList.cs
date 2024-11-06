using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo2_1735
{
    /// <summary>
    /// (搜尋結果)投資人擔保清單
    /// </summary>
    public class GuaranteeList
    {
        /// <summary>
        /// 投資人帳號
        /// </summary>
        public string Account { get; set; }
        /// <summary>
        /// 擔保序號
        /// </summary>
        public int GuaranteeSN { get; set; }
        /// <summary>
        /// 擔保日期
        /// </summary>
        public string GuaranteeDate { get; set; }
        /// <summary>
        /// 擔保單簡要
        /// </summary>
        public List<GuaranteeSummary> GuaranteeSummaries { get; set; }
    }
}
