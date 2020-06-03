using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    public class UncoverEventArgs : EventArgs
    {
        private Point position;

        public UncoverEventArgs(Point position)
        {
            this.position = position;
        }

        public Point Position()
        {
            return position;
        }
    }
}
