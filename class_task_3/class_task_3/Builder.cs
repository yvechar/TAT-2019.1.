using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_task_3
{
    abstract class Builder
    {
        public Builder Successor { get; set; }
        public Builder(Builder builder)
        {
            Successor = builder;
        }
        public abstract Triangle Build(Point pointX, Point pointY, Point pointZ);
        protected abstract bool Check(Point pointX, Point pointY, Point pointZ);
    }
}
}
