using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.LongSubStr
{
  public int LengthOfLongestSubstring(string s)
        {



            List<char> charList = new List<char>();

            ;
            int sizeList = 0;


            for (int y = 0; y < s.Length; y++)
            {

                if (!charList.Contains(s[y]))
                {

                    charList.Add(s[y]);


                }

                else
                {
                    int index = charList.IndexOf(s[y]);

                    sizeList = Math.Max(sizeList, charList.Count);
                    charList.RemoveRange(0, index + 1);
                    charList.Add(s[y]);




                }



            }
            return Math.Max(sizeList, charList.Count);
        }
   
}
