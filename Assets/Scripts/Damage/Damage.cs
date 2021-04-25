using System;

namespace Asteroids
{
    [Serializable]
    public class Damage
    {
        public float Value;
        public SenderSide Side; 

        public enum SenderSide
        {
            Player,
            Enemy,
            Neutral
        }
    }
}