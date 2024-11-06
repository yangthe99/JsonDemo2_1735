using System;
using System.Linq;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Transactions;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;


namespace JsonDemo2_1735
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 序列化成json格式
            #region
            Guarantee guarantee = new Guarantee
            {
                SearchBar = new SearchBar
                {
                    Date = "2024/11/06",
                    Account = "1735",
                    Transaction = "success",
                    Repayment = ""
                },
                GuaranteeList = new List<GuaranteeList>
                {
                    new GuaranteeList
                    {
                       Account="1735",
                       GuaranteeSN = 1,
                       GuaranteeDate= "20241106",
                       GuaranteeSummaries = new List<GuaranteeSummary>
                       {
                          new GuaranteeSummary
                          {
                              Account="1735",
                              GuaranteeDate="2024/11/06",
                              GuaranteeSN=1,
                              OrderDate="2024/11/05",
                              OrderSN=1,
                              ReportedGuaranteeAmount=1000000,
                              GuaranteeRatio =110,
                              ExceedingGuaranteeRatio = 0,
                              FunctionCode ="A",
                              Transaction = "success",
                              Repayment = "success",
                              GuaranteeDetails = new List<GuaranteeDetail>
                              {
                                  new GuaranteeDetail 
                                  {
                                  }
                              }
                          }
                       }
                    },
                    new GuaranteeList
                    {
                       Account="1735",
                       GuaranteeSN = 2,
                       GuaranteeDate= "20241106",
                       GuaranteeSummaries = new List<GuaranteeSummary>
                       {
                          new GuaranteeSummary
                          {
                              Account="1735",
                              GuaranteeDate="2024/11/06",
                              GuaranteeSN=2,
                              OrderDate="2024/11/05",
                              OrderSN=2,
                              ReportedGuaranteeAmount=2000000,
                              GuaranteeRatio =110,
                              ExceedingGuaranteeRatio = 0,
                              FunctionCode ="A",
                              Transaction = "success",
                              Repayment = "processing",
                              GuaranteeDetails = new List<GuaranteeDetail>
                              {
                                  new GuaranteeDetail
                                  {
                                  }
                              }
                          }
                       }
                    }

                }
            };

            // JsonConvert.SerializeObject：將物件序列化、轉成JSON格式的字串。
            // Formatting.Indented：讓輸出的JSON更具可讀性（縮排格式）。
            string jsonString = JsonConvert.SerializeObject(guarantee, Formatting.Indented);
            Console.WriteLine("序列化的 JSON 資料：");
            Console.WriteLine(jsonString);
            #endregion


            // 反序列化
            #region
            // JsonConvert.DeserializeObject<>
            // 是 Newtonsoft.Json 提供的一個方法，用來將 JSON 字串轉換為<指定類型>的物件。
            //                                                          <Guarantee>

            //  如果 JSON 中缺少必須的屬性，且目標類型中的屬性是 null 或有預設值，反序列化會使用預設值
            Guarantee deserializedGuarantee = JsonConvert.DeserializeObject<Guarantee>(jsonString);
            Console.WriteLine("\n反序列化後的物件(搜尋的部分)：");
            Console.WriteLine($"擔保品日期: {deserializedGuarantee.SearchBar.Date}");
            Console.WriteLine($"投資人帳號: {deserializedGuarantee.SearchBar.Account}");
            Console.WriteLine($"成交狀態: {deserializedGuarantee.SearchBar.Transaction}");
            Console.WriteLine($"還券狀態: {deserializedGuarantee.SearchBar.Repayment}");

            Console.ReadLine();
            #endregion

        }
    }
}
