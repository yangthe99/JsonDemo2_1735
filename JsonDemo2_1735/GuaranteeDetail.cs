using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo2_1735
{
    /// <summary>
    /// 擔保細節
    /// </summary>
    public class GuaranteeDetail
    {
        /// <summary>
        /// 擔保日期
        /// </summary>
        public string GuaranteeDate { get; set; }
        /// <summary>
        /// 擔保序號(SerialNumber=SN)
        /// </summary>
        public string GuaranteeSN { get; set; }
        /// <summary>
        /// 擔保種類
        /// </summary>
        public string GuaranteeType { get; set; }
        /// <summary>
        /// 央債/銀行保證序號
        /// </summary>
        public string GovtBondBankGuaranteeSN { get; set; }
        /// <summary>
        /// 證券來源-券商
        /// </summary>
        public string BrokerSecurities { get; set; }
        /// <summary>
        /// 證券來源-帳號
        /// </summary>
        public string AccountSecurities { get; set; }
        /// <summary>
        /// 異動數量/金額
        /// </summary>
        public string Changed { get; set; }
        /// <summary>
        /// 剩餘數量
        /// </summary>
        public string Remaining { get; set; }
    }
}
