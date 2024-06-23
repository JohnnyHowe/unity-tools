using UnityEngine;

namespace JonathonOH.UnityExtensions
{
    public static class LayerMaskContains
    {
        public static bool Contains(this LayerMask layerMask, int layer)
        {
            return layerMask == (layerMask | (1 << layer));
        }
    }
}
