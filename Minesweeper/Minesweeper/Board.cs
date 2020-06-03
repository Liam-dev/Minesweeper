using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minesweeper
{
    public partial class Board : UserControl
    {
        Size dimensions;
        Cell[,] cells;

        public Board()
        {
            InitializeComponent();
            dimensions = new Size(16, 16);
            cells = new Cell[dimensions.Width, dimensions.Height];
        }

        public void Fill()
        {
            for (int i = 0; i < dimensions.Width; i++)
            {
                for (int j = 0; j < dimensions.Height; j++)
                {
                    Cell cell = new Cell(new Point(i, j));
                    cell.Location = new Point(29 * i, 29 * j);
                    cells[i, j] = cell;
                    this.Controls.Add(cell);
                    cell.Uncover += OnCellUncovered;
                }
            }
        }

        private void Board_Load(object sender, EventArgs e)
        {
            Fill();
        }

        public void OnCellUncovered(object source, UncoverEventArgs e)
        {
            Cell cell = cells[e.Position().X, e.Position().Y];

            //Console.WriteLine(cell.Position.X + " " + cell.Position.Y);

            int cellNumber = GetCellNumber(cell);

            if (cellNumber > 0)
            {
                cell.ShowNumber(cellNumber);
            }
            else
            {
                GetEmptyNeighbours(new List<Cell>() {cell});
            }            
        }

        protected void GetEmptyNeighbours(List<Cell> cells)
        {
            foreach (Cell cell in cells)
            { 
                if (GetCellNumber(cell) == 0)
                {
                    List<Cell> neighbours = GetNeighbours(cell);
                    List<Cell> empty = neighbours.FindAll(c => !c.Uncovered && GetCellNumber(c) == 0);
                    
                    neighbours.Add(cell);
                    UncoverCells(neighbours);

                    GetEmptyNeighbours(empty);
                }
            }
        }

        protected void UncoverCells(List<Cell> cells)
        {
            foreach (Cell cell in cells)
            {
                Console.WriteLine(cell.Position.X + " " + cell.Position.Y);
                cell.ShowNumber(GetCellNumber(cell));
                cell.Uncovered = true;
            }
        }

        protected int GetCellNumber(Cell cell)
        {
            List<Cell> neighbours = GetNeighbours(cell);

            int count = 0;

            foreach (Cell neighbour in neighbours)
            {
                if (neighbour.Mined)
                {
                    count++;
                }
            }

            return count;
        }

        protected List<Cell> GetNeighbours(Cell cell)
        {
            List<Cell> neighbours = new List<Cell>();

            int x = cell.Position.X;
            int y = cell.Position.Y;

            for (int i = -1 + x; i <= 1 + x; i++)
            {
                for (int j = -1 + y; j <= 1 + y; j++)
                {
                    bool outOfBounds = (i < 0 || j < 0 || i >= dimensions.Width || j >= dimensions.Height);
                    if (!outOfBounds)
                    {
                        neighbours.Add(cells[i, j]);
                    }                  
                }
            }

            neighbours.Remove(cell);         
            return neighbours;
        }
    }
}
