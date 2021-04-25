using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class GameManager : MonoBehaviour
    {
        public UnityEvent<int> ScoreUpdated;
        
        private int _score = 0;

        private void Start()
        {
            ScoreUpdated?.Invoke(_score);
        }

        public void IncreaseScore(int value)
        {
            _score += value;
            ScoreUpdated?.Invoke(_score);
        }
    }
}