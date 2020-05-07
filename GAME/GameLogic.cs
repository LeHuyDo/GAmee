using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GAME
{
    /// <summary>
    /// Lớp phục vụ các sự kiện logic của trò chơi
    /// </summary>
    class GameLogic
    {
        static private int distance = 10;

        //  Lấy tọa độ trung tâm của đối tượng control
        public static Point CenterOfControl(Point locationOfControl, Size sizeOfControl)
        {
            Point center = new Point();
            center.X = locationOfControl.X + sizeOfControl.Width / 2;
            center.Y = locationOfControl.Y + sizeOfControl.Height / 2;

            return center;
        }

        //  Đúng nếu point nằm trong area
        public static bool IsInArea(Point point, Point locationArea, Size sizeOfArea)
        {
            if (point.X > locationArea.X + distance && point.X < locationArea.X + sizeOfArea.Width - distance)
                if (point.Y > locationArea.Y + distance && point.Y < locationArea.Y + sizeOfArea.Height - distance)
                    return true;

            return false;
        }
    }
}
