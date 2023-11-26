using UnityEngine;

namespace game.Scripts
{
    public class AsteroidMovement : MonoBehaviour
    {
        [Header("Travel speed")] 
        public float travelMaxSpeed; 
        public float travelMinSpeed;
    
        [Header("Rotational speed")] 
        public float rotationMaxSpeed; 
        public float rotationMinSpeed;

        public Vector3 movementDirection;

        // related to upper setting
        private float rotationalSpeed;
        private float astroidSpeed; 
        private float xAngle, yAngle, zAngle;

        private Vector3 rollAxis;
        private float rotationSpeed;
        private Vector3 rotationDirection; 


        // Start is called before the first frame update
        void Start()
        {
            astroidSpeed = Random.Range(travelMinSpeed, travelMaxSpeed);
            rotationalSpeed = Random.Range(rotationMinSpeed, rotationMaxSpeed);
            xAngle = Random.Range(0, 360);
            yAngle = Random.Range(0, 360);
            zAngle = Random.Range(0, 360);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = new Color(1, 0, 0, 0.5f); 
            Gizmos.DrawCube(transform.position, new Vector3(5,5,5));
        }
        
        // Update is called once per frame
        void Update()
        {
            transform.Translate(movementDirection * Time.deltaTime * astroidSpeed, Space.World);
        }
    }
}
