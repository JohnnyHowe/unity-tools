using UnityEngine;
using UnityEngine.UI;

namespace JonathonOH.UnityExtensions
{
    public static class GraphicSetAlpha
    {
        public static void SetAlpha(this Graphic graphic, float newAlpha)
        {
            Color c = graphic.color;
            c.a = newAlpha;
            graphic.color = c;
        }
    }
}
