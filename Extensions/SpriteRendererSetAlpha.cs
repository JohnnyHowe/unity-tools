using UnityEngine;

namespace JonathonOH.UnityExtensions
{
    public static class SpriteRendererSetAlpha
    {
        public static void SetAlpha(this SpriteRenderer graphic, float newAlpha)
        {
            Color c = graphic.color;
            c.a = newAlpha;
            graphic.color = c;
        }
    }
}
