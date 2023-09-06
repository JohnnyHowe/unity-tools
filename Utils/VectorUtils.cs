using UnityEngine;

namespace JonathonOH.ExtraUnityUtils
{
    public static class VectorUtils
    {
        public static Vector2 UnsafeLerp(Vector2 v1, Vector2 v2, float t)
        {
            Vector2 direction = v2 - v1;
            return v1 + direction * t;
        }

        public static Vector3 UnsafeLerp(Vector3 v1, Vector3 v2, float t)
        {
            Vector3 direction = v2 - v1;
            return v1 + direction * t;
        }
    }
}
