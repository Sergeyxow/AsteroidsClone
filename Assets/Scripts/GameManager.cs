using System;
using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class GameManager : MonoBehaviour
    {
        [SerializeField] private int _lives;
        [SerializeField] private Spaceship _spaceship;
        
        private int _score = 0;
        
        public UnityEvent<int> ScoreUpdated;
        public UnityEvent<int> LivesUpdated;
        public UnityEvent GameIsOver;

        private void Start()
        {
            ScoreUpdated?.Invoke(_score);
            LivesUpdated?.Invoke(_lives);
        }

        public void ChangeScore(int value)
        {
            _score += value;
            ScoreUpdated?.Invoke(_score);
        }

        public void ChangeLives(int value)
        {
            _lives += value;
            LivesUpdated?.Invoke(_lives);
            
            if (_lives <= 0)
            {
                GameIsOver?.Invoke();
                Debug.Log("YOU LOSE!");
                return;
            }

            if (value < 0)
            {
                _spaceship.Respawn();
            }
        }
    }
}