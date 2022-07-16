using TMPro;

using UnityEngine;
using UnityEngine.UI;

namespace MVxPatternsInUnity.Scripts.MVA
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Button levelUpButton;
        [SerializeField] private TextMeshProUGUI levelText;
        private PlayerController playerController;

        public void OnInit(PlayerController playerController)
        {
            this.playerController = playerController;
        }

        private void Start()
        {
            levelUpButton.onClick.AddListener(LevelUp);
        }

        public void LevelUp()
        {
            playerController.LevelUp();
        }

        public void UpdateLevelLabel(int level)
        {
            levelText.SetText($"Current level: {level}");
        }

        private void OnDestroy()
        {
            levelUpButton.onClick.RemoveListener(LevelUp);
        }
    }
}
