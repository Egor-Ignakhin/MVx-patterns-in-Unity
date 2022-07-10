using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVxPatternsInUnity.Scripts.MVP
{
    public class ConcretePlayerViewMvp : MonoBehaviour, IPlayerView
    {
        [SerializeField] private Button levelUpButton;
        [SerializeField] private TextMeshProUGUI levelText;
        private IPlayerPresenter presenter;

        public void OnInit(IPlayerPresenter presenter)
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
