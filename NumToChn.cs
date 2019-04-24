using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChnNumProc
{
    class NumToChn
    {
        private readonly string[] _chnNumChar =  new string []{"零","一", "二", "三", "四", "五", "六", "七", "八", "九"};
        private readonly string[] _chnUnitSection = new string []{"", "万", "亿", "万亿"};
        private readonly string[] _chnUnitChar = new string []{"", "十", "百", "千"};
        public string NumberToChinese(int num)
        {
            int unitPos = 0;
            string strIns = "";
            bool needZero = false;
            string chnStr = "";
            while (num > 0) 
            {
                int section = num % 10000;
                if (needZero)
                {
                    chnStr =chnStr.Insert(0, _chnNumChar[0]);
                }
                strIns = SectionToChinese(section);
                //是否需要节权位
                strIns += (section != 0) ? _chnUnitSection[unitPos] : _chnUnitSection[0];
                chnStr = chnStr.Insert(0, strIns);
                //千位是0需要在下一个section补零
                needZero = (section < 1000) && (section > 0);
                num = num / 10000;
                unitPos++;
            }

            return chnStr;
        }

        public string SectionToChinese(int section)
        {
            
            string strIns;
            int unitPos = 0;
            bool zero = true;
            string chnStr = "";
            while (section > 0)
            {
                int v = section % 10;
                if (v == 0)
                {
                    if ((section == 0) || !zero)
                    {
                        zero = true;
                        chnStr= chnStr.Insert(0, _chnNumChar[v]);

                    }
                }
                else
                {
                    zero = false;
                    strIns = _chnNumChar[v];
                    strIns += _chnUnitChar[unitPos];
                    chnStr = chnStr.Insert(0, strIns);
                }

                unitPos++;
                section = section / 10;
            }

            return chnStr;
        }
    }
}
