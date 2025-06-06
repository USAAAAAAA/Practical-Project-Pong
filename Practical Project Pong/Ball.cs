public class Ball
{
    private int _x, _y;
    private readonly int _initialX, _initialY;
    private readonly char _tile;
    private bool _isGoingDown = true;
    private bool _isGoingRight = true;

    public Ball(int x, int y, char tile)
    {
        _x = _initialX = x;
        _y = _initialY = y;
        _tile = tile;
    }

    public void Draw(Field field)
    {
        field.Set(_x, _y, _tile);
    }

    public void CalculateTrajectory(Field field, Racket left, Racket right)
    {
        field.Set(_x, _y, ' ');

        if (_isGoingDown)
        {
            if (field.Get(_x + 1, _y) == '-')
                _isGoingDown = false;
        }
        else
        {
            if (field.Get(_x - 1, _y) == '-')
                _isGoingDown = true;
        }

        if (_isGoingRight)
        {
            if (field.Get(_x, _y + 1) == '|')
                _isGoingRight = false;
        }
        else
        {
            if (field.Get(_x, _y - 1) == '|')
                _isGoingRight = true;
        }

        _x += _isGoingDown ? 1 : -1;
        _y += _isGoingRight ? 1 : -1;

        Draw(field);
    }

    public int CheckForGoal(Field field)
    {
        if (_y == 0) return 1; 
        if (_y == field.Cols - 1) return 0; 
        return -1;
    }

    public void Reset(Field field)
    {
        field.Set(_x, _y, ' ');
        _x = _initialX;
        _y = _initialY;
        Draw(field);
    }
}
