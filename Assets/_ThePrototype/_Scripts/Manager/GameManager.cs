using UnityEngine;

namespace ThePrototype.Scripts.Manager
{
    public class GameManager : MonoBehaviour
    {
        public static GameManager instance;
        private int _score = 0;

        private void Awake()
        {
            instance = this;
        }

        public void AddScore(int amount)
        {
            _score += amount;
            Debug.Log("Coins: " + _score);
        }
    }
}