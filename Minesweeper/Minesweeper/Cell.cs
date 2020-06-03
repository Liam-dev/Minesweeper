using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Minesweeper
{
    public partial class Cell : UserControl
    {
        public Point Position { get; set; }
        public bool Mined { get; set; }
        public bool Flagged { get; set; }   
        public bool Uncovered { get; set; }

        public delegate void UncoverEventHandler(object sender, UncoverEventArgs e);
        public event UncoverEventHandler Uncover;

        public Cell(Point position)
        {
            InitializeComponent();

            this.Position = position;

            if (Global.Rnd.NextDouble() > 0.9)
            {
                Mined = true;
            }
        }

        private void Cell_Load(object sender, EventArgs e)
        {
            mine.Hide();
            marker.Hide();
            label.Hide();
            label.Text = "3";
        }

        protected virtual void OnUncovered()
        {
            if (Uncover != null)
            {
                Uncover(this, new UncoverEventArgs(Position));
            }
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            if (e is MouseEventArgs click)
            {
                switch (click.Button)
                {
                    case MouseButtons.Left:
                        Mine();
                        break;

                    case MouseButtons.Right:
                        Flag();
                        break;
                }
            }
        }

        protected void Mine()
        {
            if (!Uncovered)
            {
                if (Flagged)
                {
                    UnFlag();
                }
                else
                {
                    if (Mined)
                    {
                        mine.Show();
                    }
                    else
                    {
                        OnUncovered();
                    }

                    Uncovered = true;
                }            
            }  
        }

        protected void Flag()
        {
            if (!Uncovered)
            {
                if (Flagged)
                {
                    UnFlag();
                }
                else
                {
                    marker.Show();
                    Flagged = true;
                }               
            }
        }

        protected void UnFlag()
        {
            if (!Uncovered)
            {
                marker.Hide();
                Flagged = false;
            }
        }

        public void ShowNumber(int number)
        {   
            label.Text = number.ToString();
            label.Show();
        }
    }
}
