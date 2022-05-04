using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DeskClock
{
    public class BrushColor
    {
        public String Name { get; set; }
        public SolidColorBrush Brush { get; set; }

        public BrushColor(SolidColorBrush brush, String name)
        {
            Brush = brush;
            Name = name;
        }
    }
}
