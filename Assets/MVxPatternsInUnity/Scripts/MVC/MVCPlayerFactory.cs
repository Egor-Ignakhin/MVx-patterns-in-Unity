using UnityEngine;

namespace MVxPatternsInUnity.Scripts.MVC
{
    public class MvcPlayerFactory : IPlayerFactory
    {
        public void CreatePlayer()
        {
            PlayerModel model = new PlayerModel();
            PlayerView view = Object.FindObjectOfType<PlayerView>();
            PlayerController playerController = new PlayerController(model, view);
            view.OnInit(model, playerController);
        }
    }
}
