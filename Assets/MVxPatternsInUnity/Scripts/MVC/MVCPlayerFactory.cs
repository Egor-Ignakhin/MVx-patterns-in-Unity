using UnityEngine;

namespace MVxPatternsInUnity.Scripts.MVC
{
    public class MvcPlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer()
        {
            IPlayerModel model = new ConcretePlayerModelMvc();
            IPlayerView view = Object.FindObjectOfType<ConcretePlayerViewMvc>();
            IPlayerController playerController = new ConcretePlayerController(model, view);
            view.OnInit(model, playerController);

            return new MvcPlayer();
        }
    }
}
