using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InterviewTask
{
    internal interface IStack
    {
        void Push<TElement>(TElement item);
        TElement Pop<TElement>();
    }
}
