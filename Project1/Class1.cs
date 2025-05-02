using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ESRI.ArcGIS.Client.Symbols;
using System.Windows.Media;
namespace Project1
{
    public class Project1Class1
    {
        public SimpleMarkerSymbol TargetSymbol =
         new SimpleMarkerSymbol()
         {
             Color = new SolidColorBrush(Color.FromRgb(3, 164, 241)),
             Size = 10,
             Style = SimpleMarkerSymbol.SimpleMarkerStyle.Circle,
         };

    }
}
