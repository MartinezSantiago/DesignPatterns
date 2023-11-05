using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class PaintBrush : ToolPaint
    {
        int perimeterToPaint=5;
        public void Paint(Sheet Sheet)
        {
            Sheet.Perimeter = Sheet.Perimeter - perimeterToPaint;
        }
    }
}
