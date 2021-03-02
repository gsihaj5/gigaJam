using UnityEngine;

namespace Player
{
    public class PlayerAndPaddle : MonoBehaviour
    {
        [SerializeField] private GameObject paddle;
        private Transform _transform;

        private void Start()
        {
            _transform = GetComponent<Transform>();
        }

        // Update is called once per frame
        void Update()
        {
        }
    }
}