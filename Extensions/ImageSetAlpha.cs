using UnityEngine;
using UnityEngine.UI;

namespace JonathonOH.UnityExtensions
{
    public static class ImageSetAlpha
    {
        public static void SetAlpha(this MaskableGraphic graphic, float newAlpha)
        {
            Color c = graphic.color;
            c.a = newAlpha;
            graphic.color = c;
        }
    }
}
