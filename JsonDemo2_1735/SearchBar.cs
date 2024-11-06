using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo2_1735
{
    /// <summary>
    /// 搜尋
    /// </summary>
    public class SearchBar
    {
        /// <summary>
        /// 擔保品日期
        /// </summary>
        public string Date { get; set; }
        /// <summary>
        /// 投資人帳號
        /// </summary>
        public string? Account { get; set; }
        /// <summary>
        /// 成交狀態
        /// </summary>
        public string? Transaction { get; set; }
        /// <summary>
        /// 還券狀態
        /// </summary>
        public string? Repayment { get; set; }
    }
}
