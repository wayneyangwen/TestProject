///using 盡量在namespace上面
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

///一個檔案一個namespace
namespace TestProject.CodeStyle
{
    /// <summary>
    /// 避免多個Class在一個檔案
    /// 多利用註解public, protected and internal的地方
    /// </summary>
    public class CodeStyleClass
    { //大括弧必須在新的一行
        public CodeStyleClass()
        {
        }

        public void main()
        {
            string test = string.Empty; //Tab 空格為4格

            var shortVar = new short(); //使用short不要用 System.Int16
            var intVar = new int();     //不要使用System.Int32
            var longVar = new long();   //不要使用System.Int64, 只有在int過大得時候使用.
            var stringVar = string.Empty;   //不要使用System.String
            var floatVar = new float(); //只有在double or decimal不夠用的時候才能使用
        }

        //不要不宣告存取範圍 ex: void writeEvent(string messge)
        private void writeEvent(string message)
        {
        }
    }
}
