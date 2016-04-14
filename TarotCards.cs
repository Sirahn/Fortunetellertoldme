using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortunetellertoldme
{
    
        class TarotCards : Magic
        {
            public override string Name { get; set; } = "TarotCards";
            public override void Work()
            {
                base.Work();
                this.Result = PickACard();
            }
            private string PickACard()
            {
                return "You picked the High Priestess";

            }
            public TarotCards()
            {
                this.Expertise = "beginner";
                this.Price = 65.00M;
                this.PercentEffective = 40;
                this.BlackMagic = true;
            }
        }
    }

