using System;
using UnityEngine;

namespace Asteroids
{
    public class DestroyOnHit : MonoBehaviour
    {
        private void OnCollisionEnter2D(Collision2D other)
        {
            Destroy(other.gameObject);
        }
    }
}