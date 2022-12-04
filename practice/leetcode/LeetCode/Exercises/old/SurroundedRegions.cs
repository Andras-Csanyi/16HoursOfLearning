namespace Exercises.old;

public class SurroundedRegions
{
    private List<Coordinate> DoNotFlip = new List<Coordinate>();

    public void Solve(char[][]? board)
    {
        // collect border elements
        // check "O" elems on the border
        // check border "O" elements' neighbour
        // flip the remaining "O"
        // happiness

        if (board == null || board.Length == 0)
        {
            return;
        }

        List<Coordinate> oBorderElements = new List<Coordinate>();

        // first row and last row
        for (int i = 0; i < board[0].Length - 1; i++)
        {
            if (board[0][i].ToString() == "O")
            {
                oBorderElements.Add(new Coordinate { Horizontal = 0, Vertical = i });
                DoNotFlip.Add(new Coordinate { Horizontal = 0, Vertical = i });
            }

            if (board[board.Length - 1][i].ToString() == "O")
            {
                oBorderElements.Add(new Coordinate { Horizontal = board.Length - 1, Vertical = i });
                DoNotFlip.Add(new Coordinate { Horizontal = board.Length - 1, Vertical = i });
            }
        }

        // left and right wall - corner stuff already checked
        for (int i = 1; i < board.Length - 1; i++)
        {
            if (board[i][0].ToString() == "O")
            {
                oBorderElements.Add(new Coordinate { Horizontal = 0, Vertical = i });
                DoNotFlip.Add(new Coordinate { Horizontal = 0, Vertical = i });
            }

            if (board[i][board[i].Length - 1].ToString() == "O")
            {
                oBorderElements.Add(new Coordinate { Horizontal = board[i].Length - 1, Vertical = i });
                DoNotFlip.Add(new Coordinate { Horizontal = board[i].Length - 1, Vertical = i });
            }
        }

        // Check the neighbours of the "O" cells
        if (!oBorderElements.Any()) return;

        foreach (Coordinate oBorderElement in oBorderElements)
        {
            CheckNeighboursDFS(board, oBorderElement);
        }
    }

    private void CheckNeighboursDFS(char[][] board, Coordinate oBorderElement)
    {
        if (board[oBorderElement.Horizontal][oBorderElement.Vertical].ToString() != "O")
        {
            throw new Exception();
        }

        // Left
        if (oBorderElement.Horizontal > 1
            && board[oBorderElement.Vertical][oBorderElement.Horizontal - 1].ToString() == "O")
        {
            DoNotFlip.Add(new Coordinate
            {
                Vertical = oBorderElement.Vertical,
                Horizontal = oBorderElement.Horizontal - 1
            });
            CheckNeighboursDFS(board, new Coordinate
            {
                Vertical = oBorderElement.Vertical,
                Horizontal = oBorderElement.Horizontal - 1
            });
        }
        // right
        // up
        // down
    }

    public struct Coordinate
    {
        public int Horizontal { get; set; }
        public int Vertical { get; set; }
    }
}