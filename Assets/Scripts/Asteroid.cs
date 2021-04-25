using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class Asteroid : Fireable
    {
        [SerializeField] private int _scorePerKill;
        public event Action<int> Killed;

        public void Kill()
        {
            Killed?.Invoke(_scorePerKill);
            Killed = null;
        }
    }
}