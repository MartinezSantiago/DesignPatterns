using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    internal class Painter
    {
       private ToolPaint _toolPaint;
        private Sheet _sheet;
        public Painter(ToolPaint toolPaint,Sheet sheet)
        {
            this._toolPaint = toolPaint;
            _sheet = sheet;
        }

        public void ChangePaintTool(ToolPaint toolPaint)
        {
            _toolPaint = toolPaint;
        }
        public void Paint()
        {
            _toolPaint.Paint(_sheet);
        }
    }
}
