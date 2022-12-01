using System;
using System.Collections.Generic;
using System.Text;

namespace Abstract
{
    abstract class Surface
    {

        abstract public float GetSurface(); //面積を取得する
        abstract public float GetCircumference(); //周囲の長さを取得する
        abstract public void GetBounds(out float beside,out float vertical); //周囲の長さを取得する

    }
}
