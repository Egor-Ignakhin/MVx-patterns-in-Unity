using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVxPatternsInUnity.Scripts.MVP
{
    public class PlayerView : MonoBehaviour
    {
        [SerializeField] private Button levelUpButton;
        [SerializeField] private TextMeshProUGUI levelText;
        private PlayerPresenter presenter;

        public void OnInit(PlayerPresenter presenter)
        {
            this.presenter = presenter;
        }

        private void Start()
        {
            levelUpButton.onClick.AddListener(LevelUp);
        }

        public void LevelUp()
        {
            presenter.LevelUp();
        }

        private void OnDestroy()
        {
            levelUpButton.onClick.RemoveListener(LevelUp);
        }

        public void UpdateLevelLabel(int level)
        {
            levelText.SetText($"Current level: {level}");
        }
    }
}
