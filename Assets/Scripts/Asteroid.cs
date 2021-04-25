using System;
using UnityEngine;

namespace Asteroids
{
    public class Asteroid : Fireable
    {
        [SerializeField] private int _scorePerKill;
        public event Action<int> Killed;

        public void Kill(Damage damage)
        {
            int score = damage.Side == Damage.SenderSide.Player ? _scorePerKill : 0; 
            Killed?.Invoke(score);
            Killed = null;
        }
    }
}