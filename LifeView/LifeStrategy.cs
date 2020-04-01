using System.Linq;

namespace LifeView
{
    class LifeStrategy
    {
        public Field GetNextGeneration(Field field)
        {
            Field newField = new Field();
            for (int x = 0; x < field.countColumns; x++)
            {
                for (int y = 0; y < field.countRows; y++)
                {
                    newField.ChangeState(x, y, field[x, y].isAlive);
                    var state = new StateOfNeighboringCells(field);
                    state.CreateState(y, x);
                    var aliveNeighboringCount = state.neighboringStateList.Where(i => i == true).Count();
                    if (field[x,y].isAlive == false && aliveNeighboringCount == 3)
                    {
                        newField.ChangeState(x, y, true);
                    }
                    if (field[x, y].isAlive == true && (aliveNeighboringCount == 3 || aliveNeighboringCount == 2))
                    {
                        newField.ChangeState(x, y, true);
                    }
                    if (field[x, y].isAlive == true && (aliveNeighboringCount > 3 || aliveNeighboringCount < 2))
                    {
                        newField.ChangeState(x, y, false);
                    }

                }
            }
            return newField;
        }
    }
}
