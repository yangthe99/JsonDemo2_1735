using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemo2_1735
{
    /// <summary>
    /// 擔保品資料申報
    /// </summary>
    public class Guarantee
    {
        /// <summary>
        /// 搜尋
        /// </summary>
        public SearchBar SearchBar { get; set; }
        /// <summary>
        ///  (搜尋結果)投資人擔保清單
        /// </summary>
        public List<GuaranteeList>? GuaranteeList { get; set; }
    }
}
