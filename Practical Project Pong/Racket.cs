public class Racket
{
    private int _x, _initialX;
    private readonly int _y;
    private readonly int _length;
    private readonly char _tile;

    public Racket(int x, int y, int length, char tile)
    {
        _x = _initialX = x;
        _y = y;
        _length = length;
        _tile = tile;
    }

    public void Draw(Field field)
    {
        for (int i = 0; i < _length; i++)
            field.Set(_x + i, _y, _tile);
    }

    public void MoveUp(Field field)
    {
        if (field.Get(_x - 1, _y) == ' ') 
        {
            field.Set(_x + _length - 1, _y, ' ');
            _x--;
            field.Set(_x, _y, _tile);
        }
    }

    public void MoveDown(Field field)
    {
        if (field.Get(_x + _length, _y) == ' ')
        {
            field.Set(_x, _y, ' ');
            _x++;
            field.Set(_x + _length - 1, _y, _tile);
        }
    }

    public int Y => _y;
    public void Reset(Field field)
    {
        for (int i = 0; i < _length; i++)
            field.Set(_x + i, _y, ' ');

        _x = _initialX;
        Draw(field);
    }
}
