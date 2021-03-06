using TMPro;

using UnityEngine;
using UnityEngine.UI;

namespace MVxPatternsInUnity.Scripts.MVVM
{
    public class PlayerView : MonoBehaviour
    {
        private PlayerViewModel playerViewModel;
        [SerializeField] private Button levelUpButton;
        [SerializeField] private TextMeshProUGUI levelText;

        public void OnInit(PlayerViewModel playerViewModel)
        {
            this.playerViewModel = playerViewModel;
            playerViewModel.Changed += PlayerViewModel_Changed;
        }

        private void Start()
        {
            levelUpButton.onClick.AddListener(LevelUp);
        }

        private void PlayerViewModel_Changed()
        {
            levelText.SetText($"Current level: {playerViewModel.GetLevel()}");
        }

        public void LevelUp()
        {
            playerViewModel.LevelUp();
        }

        private void OnDestroy()
        {
            playerViewModel.Changed -= PlayerViewModel_Changed;

            levelUpButton.onClick.RemoveListener(LevelUp);
        }
    }
}
