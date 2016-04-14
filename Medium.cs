using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortunetellertoldme
{
    class Medium:Service
    {
        //Either the medium feeling comes or not
        public virtual bool MediumFeeling { get; set; }

        //Effectiveness of medium powers
        public virtual int PercentEffective { get; set; }

        //let's make sure all of them have a name!
        public override string Name { get; set; }

        //level of expertise of being a medium 
        protected virtual string Expertise { get; set; }

        //-- "make it go now"
        public virtual void Work()
        {
            Console.WriteLine("Let me pull out my {0}", this.Name);
        }
        //showing the magical object to the user
        public virtual void Show()
        {
            Console.WriteLine("Oh, my. The {0} told me, yes, your future.", this.Name);
            Console.WriteLine(this.Result);
        }
        public virtual void StateEffectiveness()
        {
            Console.WriteLine("In case you're wondering, this method is {2} percent effective.", this.Name, this.Result, this.PercentEffective);
        }
    }
}
