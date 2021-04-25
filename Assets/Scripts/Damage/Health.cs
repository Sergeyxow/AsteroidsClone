using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class Health : MonoBehaviour
    {
        public UnityEvent<float> OnHealthChanged;
        public UnityEvent OnHealthIsOut;
        
        public float Amount => _health;
        [SerializeField] private float _health;
        [SerializeField] private float _maxHealth;

        public void ChangeHealth(float value)
        {
            _health = Mathf.Clamp(_health, 0f, _maxHealth);
        }

        public void IncreaseHealth(float value)
        {
            ChangeHealth(value);
        }

        public void DecreaseHealth(float value)
        {
            ChangeHealth(-value);
        }
    }
}