﻿using System;

namespace InterMediate
{
    public class Point
    {
        public int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y; 
        }
        public void Move(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void Move(Point newLocation)
        {
            if (newLocation == null)
                throw new ArgumentNullException("new location error");
            Move(newLocation.x, newLocation.y);
        }
       

    }
        
}
