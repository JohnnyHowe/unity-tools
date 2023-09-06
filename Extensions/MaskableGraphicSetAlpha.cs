using UnityEngine;
using UnityEngine.UI;

namespace JonathonOH.Drifto.UI.Extensions
{
    public static class MaskableGraphicSetAlpha
    {
        public static void SetAlpha(this MaskableGraphic graphic, float newAlpha)
        {
            Color c = graphic.color;
            c.a = newAlpha;
            graphic.color = c;
        }
    }
}
