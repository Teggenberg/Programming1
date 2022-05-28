using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7A
{
    public class Circle
    {

        float mX;
        float mY;
        float mRadius;

        public Circle()
        {
            mX = 0;
            mY = 0;
            mRadius = 0;
        }

        public Circle(float mx, float my, float mradius)
        {
            mX = mx;
            mY = my;
            mRadius = mradius;
        }

        public float GetX()
        {
            return mX;
        }
        public void SetX(float x)
        {
            mX = x;
        }

        public float GetY()
        {
            return mY;
        }
        public void SetY(float y)
        {
            mY = y;
        }

        public float GetRadius()
        {
            return mRadius;
        }
        public void SetRadius(float r)
        {
            mRadius = r;
        }

        public float GetArea()
        {
            return (float)Math.PI * (mRadius * mRadius);

        }

        public bool Contains(float px, float py)
        {
            if(Math.Sqrt(Math.Pow(mX - px, 2) + Math.Pow(mY - py, 2)) <= mRadius)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public float GetCircumference()
        {
            return (float)Math.PI * 2 * mRadius;
        }
    }
}
