using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class Damagable : MonoBehaviour
    {
        private UnityEvent<float> OnDamageTaken;

        public void TakeDamage(float damage)
        {
            OnDamageTaken?.Invoke(damage);
        }
    }
}