using System;
using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

namespace DefaultNamespace
{
    public class AsteroidsSpawner : MonoBehaviour
    {
        [SerializeField] private Asteroid _asteroidPrefab;
        [SerializeField] private float _spawnRadius;
        [SerializeField] private float _spawnDelay;

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

            Asteroid instance = Instantiate(_asteroidPrefab, spawnPoint, Quaternion.identity);
            instance.SetMovementDirection((destinationPoint - spawnPoint).normalized);
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