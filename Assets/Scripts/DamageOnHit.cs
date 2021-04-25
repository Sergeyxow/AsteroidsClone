using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class DamageOnHit : MonoBehaviour
    {
        [SerializeField] private Damage _damage;
        private void OnCollisionEnter2D(Collision2D other)
        {
            if (other.gameObject.TryGetComponent(out Damagable damagable))
            {
                damagable.TakeDamage(_damage);
            }
        }
    }
}