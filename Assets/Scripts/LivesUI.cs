using UnityEngine;
using UnityEngine.UI;

namespace TowerDefense
{
    public class LivesUI : MonoBehaviour
    {
        public Text livesText;

        // Update is called once per frame
        void Update ()
        {
            livesText.text = PlayerStats.Lives.ToString() + " LIVES";
        }
    }
}