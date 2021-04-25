using UnityEngine;
using UnityEngine.Events;

namespace DefaultNamespace
{
    public class Damagable : MonoBehaviour
    {
        public UnityEvent<Damage> OnDamageTaken;

        public void TakeDamage(Damage damage)
        {
            OnDamageTaken?.Invoke(damage);
        }
    }
}