using UnityEngine;

namespace JonathonOH.UnityTools
{
    public static class UnsafeLerp
    {
        public static Vector2 UnclampedLerp(Vector2 v1, Vector2 v2, float t)
        {
            Vector2 direction = v2 - v1;
            return v1 + direction * t;
        }

        public static Vector3 UnclampedLerp(Vector3 v1, Vector3 v2, float t)
        {
            Vector3 direction = v2 - v1;
            return v1 + direction * t;
        }
    }
}
