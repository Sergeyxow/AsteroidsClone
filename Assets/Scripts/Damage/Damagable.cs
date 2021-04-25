using UnityEngine;
using UnityEngine.Events;

namespace Asteroids
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