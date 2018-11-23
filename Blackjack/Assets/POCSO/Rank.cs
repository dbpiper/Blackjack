using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.POCSO
{
    //public class RankTypes
    //{
    //    public const string Ace = "Ace";
    //    public const string Two = "Two";
    //    public const string Three = "Three";
    //    public const string Four = "Four";
    //    public const string Five = "Five";
    //    public const string Six = "Six";
    //    public const string Seven = "Seven";
    //    public const string Eight = "Eight";
    //    public const string Nine = "Nine";
    //    public const string Ten = "Ten";
    //    public const string Jack = "Jack";
    //    public const string Queen = "Queen";
    //    public const string King = "King";
    //}

    public enum RankTypes
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    };

    public class Rank
    {
        public RankTypes RankType
        { get; set; }

        public Tuple<int, int> RankValue
        {
            get
            {
                switch(RankType)
                {
                    case RankTypes.Ace:
                        return Tuple.Create(1, 11);
                    case RankTypes.Two:
                        return Tuple.Create(2, -1);
                }

                return Tuple.Create(-1, -1);
            }
        }

        Rank(RankTypes rankType)
        {
            RankType = rankType;
        }

    }
}
