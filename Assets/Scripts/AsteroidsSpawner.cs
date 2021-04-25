using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;

namespace Asteroids
{
    public class AsteroidsSpawner : MonoBehaviour
    {
        [SerializeField] private Asteroid FireablePrefab;
        [SerializeField] private float _spawnRadius;
        [SerializeField] private float _spawnDelay;

        public UnityEvent<int> AsteroidDestroyed;

        private void Start()
        {
            StartCoroutine(SpawnCycleCO());
        }

        private IEnumerator SpawnCycleCO()
        {
            while (true)
            {
                Spawn();
                yield return new WaitForSeconds(_spawnDelay);
            }
        }

        private void Spawn()
        {
            Vector2 spawnPoint = GetRandomDirection() * _spawnRadius;
            Vector2 destinationPoint = GetRandomDirection() * _spawnRadius;

            Asteroid instance = Instantiate(FireablePrefab, spawnPoint, Quaternion.identity);
            instance.SetMovementDirection((destinationPoint - spawnPoint).normalized);
            instance.Killed += i => AsteroidDestroyed?.Invoke(i);
        }

        private Vector2 GetRandomDirection()
        {
            return new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawWireSphere(transform.position, _spawnRadius);
        }
    }
}