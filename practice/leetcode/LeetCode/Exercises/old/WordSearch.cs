namespace Exercises.old;

using System.Text;

public class WordSearch
{
    Dictionary<int, List<int>> alreadyVisited = new Dictionary<int, List<int>>();

    public bool Exist(char[][] board, string word)
    {
        for (int i = 0; i < board.Length; i++)
        {
            alreadyVisited.Add(i, new List<int>());
        }

        bool result = false;
        for (int row = 0; row < board.Length - 1; row++)
        {
            for (int column = 0; column < board[row].Length; column++)
            {
                if (!alreadyVisited[row].Contains(column))
                {
                    alreadyVisited[row].Add(column);
                    result = Search(board, row, column, word, new StringBuilder(), new Dictionary<int, List<int>>());
                    if (result)
                    {
                        return result;
                    }
                }
            }
        }

        return result;
    }

    public bool Search(char[][] board, int row, int col, string word, StringBuilder builder,
        Dictionary<int, List<int>> searchAlreadyVisited)
    {
        if (searchAlreadyVisited.Count == 0)
        {
            for (int i = 0; i < board.Length; i++)
            {
                searchAlreadyVisited.Add(i, new List<int>());
            }
        }
        
        builder.Append(board[row][col]);
        if (builder.ToString().Length > word.Length)
        {
            searchAlreadyVisited[row].Add(col);
            return false;
        }

        
        if (builder.ToString() == word)
        {
            return true;
        }

        searchAlreadyVisited[row].Add(col);
        // Map adjacent fields
        Dictionary<int, List<int>> map = MapAdjacentFields(board, row, col, searchAlreadyVisited);
        foreach (KeyValuePair<int, List<int>> keyValuePair in map)
        {
            if (keyValuePair.Value.Any())
            {
                for (int i = 0; i < keyValuePair.Value.Count; i++)
                {
                    bool result = Search(board, keyValuePair.Key, keyValuePair.Value[i], word, builder,
                        searchAlreadyVisited);
                    if (result)
                    {
                        return result;
                    }

                    builder.Remove(builder.Length - 1, 1);
                    searchAlreadyVisited[row].Remove(keyValuePair.Value[i]);
                }
            }
        }


        return false;
    }

    public Dictionary<int, List<int>> MapAdjacentFields(char[][] board, int row, int col,
        Dictionary<int, List<int>> searchAlreadyVisited)
    {
        Dictionary<int, List<int>> adjacentFieldsToBeVisited = new Dictionary<int, List<int>>();
        // left
        if (row <= board.Length - 1
            && col + 1 <= board[row].Length - 1
            && !alreadyVisited[row].Contains(col + 1)
            && !searchAlreadyVisited[row].Contains(col + 1)
           )
        {
            if (!adjacentFieldsToBeVisited.ContainsKey(row))
            {
                adjacentFieldsToBeVisited.Add(row, new List<int>());
            }

            adjacentFieldsToBeVisited[row].Add(col + 1);
        }

        // right
        if (row <= board.Length - 1
            && col - 1 >= 0
            && col - 1 <= board[row].Length - 1
            && !alreadyVisited[row].Contains(col - 1)
            && !searchAlreadyVisited[row].Contains(col - 1)
           )
        {
            if (!adjacentFieldsToBeVisited.ContainsKey(row))
            {
                adjacentFieldsToBeVisited.Add(row, new List<int>());
            }

            adjacentFieldsToBeVisited[row].Add(col - 1);
        }

        // down
        if (row + 1 <= board.Length - 1
            && col <= board[row].Length - 1
            && !alreadyVisited[row + 1].Contains(col)
            && !searchAlreadyVisited[row + 1].Contains(col)
           )
        {
            if (!adjacentFieldsToBeVisited.ContainsKey(row + 1))
            {
                adjacentFieldsToBeVisited.Add(row + 1, new List<int>());
            }

            adjacentFieldsToBeVisited[row + 1].Add(col);
        }

        // up
        if (row - 1 >= 0
            && row - 1 <= board.Length - 1
            && col <= board[row].Length - 1
            && !alreadyVisited[row - 1].Contains(col)
            && !searchAlreadyVisited[row - 1].Contains(col)
           )
        {
            if (!adjacentFieldsToBeVisited.ContainsKey(row - 1))
            {
                adjacentFieldsToBeVisited.Add(row - 1, new List<int>());
            }

            adjacentFieldsToBeVisited[row - 1].Add(col);
        }

        return adjacentFieldsToBeVisited;
    }
}