#nullable enable

using System.Collections.Generic;
using System.Linq;

namespace Template.Entity;

public struct BoardEntity
{
    public int[] Cells { get; init; }
    public int RowCount { get; init; }
    public int ColCount { get; init; }
    public int CurrentMark { get; private set; }

    public const int MARK_EMPTY = 0;
    public const int MARK_X = 1;
    public const int MARK_O = 2;

    /// <summary>
    /// Create Empty Board
    /// </summary>
    public BoardEntity(int rowCount, int colCount)
    {
        Cells = new int[rowCount * colCount];
        RowCount = rowCount;
        ColCount = colCount;
        CurrentMark = MARK_EMPTY;
    }

    public BoardEntity(ref BoardEntity boardEntity)
    {
        RowCount = boardEntity.RowCount;
        ColCount = boardEntity.ColCount;
        Cells = new int[boardEntity.Cells.Length];
        CurrentMark = boardEntity.CurrentMark;
        
        for(int i = 0; i < Cells.Length; i++)
        {
            Cells[i] = boardEntity.Cells[i];
        }
    }

    public IEnumerable<int> GetRow(int row)
    {
        for(int i = 0; i < ColCount; i++)
        {
            yield return Cells[(row * ColCount) + i];
        }
    }

    public IEnumerable<int> GetCol(int col)
    {
        for (int i = 0; i < RowCount; i++)
        {
            yield return Cells[i * ColCount + col];
        }
    }

    public int GetEmptyLeft()
    {
        int emptyCount = 0;
        for(int i = 0; i < Cells.Length; ++i)
        {
            if (Cells[i] == 0)
                emptyCount++;
        }
        return emptyCount;
    }
}