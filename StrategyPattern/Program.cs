namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Learning Design Pattern");
            Console.WriteLine("Today: StrategyPattern");
            int option = 0;
            ToolPaint toolPaint = new PaintBrush();
            Sheet Sheet = Sheet.GetInstance();
            Painter painter = new Painter(toolPaint, Sheet);
            do
            {
                Console.WriteLine("What paint tool do you want? 0- Pen -1 Aerosol 2- PaintBrush -3 Exit menu");
                option = int.Parse(Console.ReadLine()!);
                switch (option)
                {
                    case 0: painter.ChangePaintTool(new Pen()); break;
                    case 1: painter.ChangePaintTool(new Aerosol()); break;
                    case 2: painter.ChangePaintTool(new PaintBrush()); break;
                    default: Environment.Exit(0); break;
                }
                painter.Paint();
            } while (true);
        }
    }
}