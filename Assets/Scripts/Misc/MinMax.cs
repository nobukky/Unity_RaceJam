using UnityEngine;

namespace Misc
{
    [System.Serializable]
    public class IntMinMax
    {
        public int min, max;
        
        /// <summary>
        /// Returns a random int value between min and max
        /// </summary>
        public int GetValue() => Random.Range(min, max - 1);
    }

    [System.Serializable]
    public class FloatMinMax
    {
        public float min, max;
        
        /// <summary>
        /// Returns a random float value between min and max
        /// </summary>
        public float GetValue() => Random.Range(min, max);
    }
}