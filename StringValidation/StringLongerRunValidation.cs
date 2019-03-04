using System;
using System.Collections.Generic;
using System.Linq;

namespace StringValidation
{
    public class StringLongerRunValidation
    {
        public List<LongerRun> GetLongerRun(string _text)
        {
            List<LongerRun> _lstLongerRun = new List<LongerRun>();

            for (int i = 0; i < _text.Length; i++)
            {
                LongerRun longerRun = new LongerRun();
                int idx = _lstLongerRun.Count - 1;

                if (_lstLongerRun.Count > 0 && (_lstLongerRun[idx].character == _text.Substring(i, 1).ToString()))
                {
                    _lstLongerRun[idx].qty += 1;
                }
                else
                {
                    longerRun.character = _text.Substring(i, 1).ToString();
                    longerRun.qty = 1;

                    _lstLongerRun.Add(longerRun);
                }
            }
            return _lstLongerRun.OrderByDescending(i => i.qty).ToList();
        }
    }

    public class LongerRun
    {
        public string character { get; set; }
        public int qty { get; set; }
    }
}
