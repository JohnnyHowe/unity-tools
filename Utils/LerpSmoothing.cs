namespace JonathonOH.UnityTools
{
    public static class LerpSmoothing
    {
        /// <summary>
        /// Lerp from a to b but is consistent across different framerates (Mathf.Lerp isn't).
        /// Given a decay speed, move from a to b. As the value gets closer to b, the speed
        /// decreases to make the smooth curve we all love.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <param name="decay">Start change speed of the curve. Should be between 0 and infinity.</param>
        /// <param name="deltaTime"></param>
        /// <returns></returns>
        public float LerpSmooth(float a, float b, float decay, float deltaTime)
        {
            return b + (a - b) * Mathf.Exp(-decay * deltaTime);
        }
    }
}