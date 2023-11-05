using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Pen : ToolPaint
    {
        int PerimeterAPaint=1;
        public void Paint(Sheet Sheet)
        {
            Sheet.Perimeter= Sheet.Perimeter-PerimeterAPaint;
        }
    }
}
