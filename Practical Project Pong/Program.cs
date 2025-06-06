using System;
using System.Threading;

class Program
{
    static void Main()
    {
        Field field = new Field(51, 15, '-');
        Console.SetWindowSize(field.Cols, field.Rows + 2);
        Console.CursorVisible = false;

        Racket left = new Racket(6, 2, 4, '|');
        Racket right = new Racket(6, 48, 4, '|');
        Ball ball = new Ball(7, 25, 'o');

        left.Draw(field);
        right.Draw(field);
        ball.Draw(field);

        int leftScore = 0, rightScore = 0;
        int frame = 0;

        void DrawScore()
        {
            Console.SetCursorPosition(0, field.Rows);
            Console.WriteLine($"Left: {leftScore}  Right: {rightScore}     ");
        }

        void ReadInput()
        {
            if (!Console.KeyAvailable) return;

            var key = Console.ReadKey(true).Key;
            switch (key)
            {
                case ConsoleKey.W: left.MoveUp(field); break;
                case ConsoleKey.S: left.MoveDown(field); break;
                case ConsoleKey.UpArrow: right.MoveUp(field); break;
                case ConsoleKey.DownArrow: right.MoveDown(field); break;
            }
        }

        DrawScore();
        while (true)
        {
            ReadInput();

            if (frame % 2 == 0)
            {
                int result = ball.CheckForGoal(field);
                if (result != -1)
                {
                    if (result == 0) leftScore++;
                    else rightScore++;

                    DrawScore();
                    left.Reset(field);
                    right.Reset(field);
                    ball.Reset(field);
                }

                ball.CalculateTrajectory(field, left, right);
            }

            field.Draw();
            Thread.Sleep(10);
            frame++;
        }
    }
}
