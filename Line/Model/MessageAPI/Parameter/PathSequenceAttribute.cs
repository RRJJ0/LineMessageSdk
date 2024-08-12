using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line.Model.MessageAPI.Parameter
{
    public class PathSequenceAttribute : Attribute
    {
        public int Sequence { get; }

        public PathSequenceAttribute(int Sequence)
        {
            this.Sequence = Sequence;
        }
    }
}
