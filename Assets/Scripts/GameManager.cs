using UnityEngine;

namespace TowerDefense
{
    public class GameManager : MonoBehaviour
    {
        public GameObject gameOverUI;
        public GameObject completeLevelUI;

        public static bool GameIsOver;

        // Use this for initialization
        void Start ()
        {
            GameIsOver = false;
        }

        // Update is called once per frame
        void Update ()
        {
            if (GameIsOver)
                return;

            if (PlayerStats.Lives <= 0)
            {
                EndGame();
            }
        }

        void EndGame ()
        {
            GameIsOver = true;

            gameOverUI.SetActive(true);
        }

        public void WinLevel ()
        {
            GameIsOver = true;

            completeLevelUI.SetActive(true);
        }
    }
}