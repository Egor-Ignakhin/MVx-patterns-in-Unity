using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace MVxPatternsInUnity.Scripts.MVC
{
    public class ConcretePlayerViewMvc : MonoBehaviour, IPlayerView
    {
        private IPlayerModel model;
        private IPlayerController playerController;

        [SerializeField] private Button levelUpButton;
        [SerializeField] private TextMeshProUGUI levelText;

        private void Start()
        {
            levelUpButton.onClick.AddListener(LevelUp);
        }

        public void OnInit(IPlayerModel m, IPlayerController c)
        {
            model = m;
            playerController = c;

            model.Changed += OnModelChanged;
        }

        public void LevelUp()
        {
            playerController.LevelUp();
        }

        public void OnModelChanged()
        {
            levelText.SetText($"Current level: {model.GetLevel()}");
        }

        private void OnDestroy()
        {
            levelUpButton.onClick.RemoveListener(LevelUp);
            model.Changed -= OnModelChanged;
        }
    }
}
