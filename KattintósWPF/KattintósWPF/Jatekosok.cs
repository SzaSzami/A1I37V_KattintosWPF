using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KattintósWPF
{
    class Jatekosok
    {
        private string playername;
        private int score;

        public string PlayerName
        {
            get
            {
                return playername;
            }
            set
            {
                if (value.Length == 0)
                {
                    playername = "defaultPlayer";
                }
                else
                {
                    playername = value;
                }
            }
        }

        public int Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }
    }
}
