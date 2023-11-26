using System;
using UnityEngine;

namespace game.Scripts
{
    public class AsteroidDespawner : MonoBehaviour
    {
        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(0.5f, 0.5f, 0, 0.5f); 
            Gizmos.DrawCube(transform.position, new Vector3(1400,700,1));
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag(Constants.Asteroid))
            {
                Destroy(other.gameObject);
                Debug.Log("Astroid despawned");
            }
        }
    }
}
