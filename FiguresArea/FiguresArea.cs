using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea
{ 
    public static class FiguresArea
    {
        public static double GetFigureArea(IFigure figure)
        {
            return figure.Area();
        }
    }
}
