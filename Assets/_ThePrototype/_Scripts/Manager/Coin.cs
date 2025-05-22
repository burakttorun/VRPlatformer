using UnityEngine;

namespace ThePrototype.Scripts.Manager
{
    public class Coin : MonoBehaviour
    {
        public int coinValue = 1;
        public float floatSpeed = 1f;
        public float floatHeight = 0.2f;

        private Vector3 _startPos;

        private void Start()
        {
            _startPos = transform.position;
        }

        private void Update()
        {
            transform.position = _startPos + new Vector3(0, Mathf.Sin(Time.time * floatSpeed) * floatHeight, 0);
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player"))
            {
                GameManager.instance.AddScore(coinValue);
                Destroy(gameObject);
            }
        }
    }
}