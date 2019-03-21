using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleSnake
{
    public sealed class Snake
    {
        private static readonly Lazy<Snake> lazy =
            new Lazy<Snake>(() => new Snake());

        public static Snake Instance { get { return lazy.Value; } }

        private Snake() { }

        private bool inUse = false;

        public bool InUse()
        {
            return inUse;
        }

        public void Initialize()
        {
            //Create variable to use for snake state
            inUse = true;
        }

        public void Clear()
        {
            //Clear all variables being used.
            inUse = false;
        }
    }
}
