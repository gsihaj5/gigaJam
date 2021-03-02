using UnityEngine;
using UnityEngine.SceneManagement;

namespace MainMenu
{
    public class Routing : MonoBehaviour
    {
        public void PlayGame()
        {
            SceneManager.LoadScene("Level1");
        }

        public void ExitGame()
        {
        }
    }
}