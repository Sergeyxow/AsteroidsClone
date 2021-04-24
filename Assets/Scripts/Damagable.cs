using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class Damagable : MonoBehaviour
    {
        private UnityEvent<float> OnDamageTaken;

        private void TakeDamage(float damage)
        {
            OnDamageTaken?.Invoke(damage);
        }
    }
}