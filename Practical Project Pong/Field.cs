public class Field
{
    private readonly char[,] _field;
    private readonly char _tile;

    public Field(int width, int height, char tile)
    {
        _tile = tile;
        _field = new char[height, width];
        Rows = height;
        Cols = width;

        for (int y = 0; y < Rows; y++)
            for (int x = 0; x < Cols; x++)
                _field[y, x] = ' ';

        for (int x = 0; x < Cols; x++)
        {
            _field[0, x] = _tile;
            _field[Rows - 1, x] = _tile;
        }
    }

    public int Rows { get; }
    public int Cols { get; }

    public char Get(int y, int x) => _field[y, x];
    public void Set(int y, int x, char value) => _field[y, x] = value;

    public void Draw()
    {
        Console.SetCursorPosition(0, 0);
        for (int y = 0; y < Rows; y++)
        {
            for (int x = 0; x < Cols; x++)
                Console.Write(_field[y, x]);
            Console.WriteLine();
        }
    }
}
