using UnityEngine;

namespace TowerDefense
{
    public class MainMenu : MonoBehaviour
    {
        public SceneFader sceneFader;

        public string levelToLoad = "MainLevel";

        public void Play ()
        {
            sceneFader.FadeTo(levelToLoad);
        }

        public void Quit ()
        {
            Debug.Log("Exciting...");

            Application.Quit();
        }
    }
}