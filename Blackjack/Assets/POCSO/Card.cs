using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.POCSO
{
    public class Card
    {
        public bool FaceUp
        { get; set; } = true;

        // no default
        public Suit Suit
        { get; set; }

        public Rank Rank
        { get; set; }

        public int NumericalValue(Rank rank)
        {
            switch(rank.RankType)
            {

            }
        }
    }
}
