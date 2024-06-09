using NUnit.Framework;
using System.Linq;

namespace Template.Entity.Tests;

public class BoardTests
{
    private BoardEntity boardEntity;

    [SetUp]
    public void SetUp()
    {
        boardEntity = new BoardEntity(5, 3);
        for (int i = 0; i < 15; i++)
        {
            boardEntity.Cells[i] = i;
        }
    }

    [Test]
    public void GetRowTest()
    {
        var row0 = boardEntity.GetRow(0).ToArray();
        var row1 = boardEntity.GetRow(1).ToArray();
        var row2 = boardEntity.GetRow(2).ToArray();
        var row3 = boardEntity.GetRow(3).ToArray();
        var row4 = boardEntity.GetRow(4).ToArray();

        Assert.That(row0, Is.EquivalentTo(new[] { 0, 1, 2 }));
        Assert.That(row1, Is.EquivalentTo(new[] { 3, 4, 5 }));
        Assert.That(row2, Is.EquivalentTo(new[] { 6, 7, 8 }));
        Assert.That(row3, Is.EquivalentTo(new[] { 9, 10, 11 }));
        Assert.That(row4, Is.EquivalentTo(new[] { 12, 13, 14 }));
    }

    [Test]
    public void GetColTest()
    {
        var col0 = boardEntity.GetCol(0).ToArray();
        var col1 = boardEntity.GetCol(1).ToArray();
        var col2 = boardEntity.GetCol(2).ToArray();

        Assert.That(col0, Is.EquivalentTo(new[] { 0, 3, 6, 9, 12 }));
        Assert.That(col1, Is.EquivalentTo(new[] { 1, 4, 7, 10, 13 }));
        Assert.That(col2, Is.EquivalentTo(new[] { 2, 5, 8, 11, 14 }));
    }
}
