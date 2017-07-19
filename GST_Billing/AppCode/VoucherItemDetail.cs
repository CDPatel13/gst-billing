using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GaneshLogistics.AppCode
{
    public class VoucherItemDetail
    {
        int _SrNo;
        int _ExpenseId;
        string _ExpenseName;
        string _ItemName;
        int _Rs;
        int _Ps;

        public int SrNo
        {
            get
            {
                return _SrNo;
            }

            set
            {
                _SrNo = value;
            }
        }

        public int ExpenseId
        {
            get
            {
                return _ExpenseId;
            }

            set
            {
                _ExpenseId = value;
            }
        }

        public string ExpenseName
        {
            get
            {
                return _ExpenseName;
            }

            set
            {
                _ExpenseName = value;
            }
        }

        public string ItemName
        {
            get
            {
                return _ItemName;
            }

            set
            {
                _ItemName = value;
            }
        }

        public int Rs
        {
            get
            {
                return _Rs;
            }

            set
            {
                _Rs = value;
            }
        }

        public int Ps
        {
            get
            {
                return _Ps;
            }

            set
            {
                _Ps = value;
            }
        }
    }
}
