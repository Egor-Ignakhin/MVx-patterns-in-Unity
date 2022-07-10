using UnityEngine;

namespace MVxPatternsInUnity.Scripts.MVP
{
    public class MvpPlayerFactory : IPlayerFactory
    {
        public IPlayer CreatePlayer()
        {
            IPlayerModel model = new ConcretePlayerModelMvp();
            var concretePlayerView = Object.FindObjectOfType<ConcretePlayerViewMvp>();
            IPlayerPresenter playerPresenter = new ConcretePlayerPresenterMvp(model, concretePlayerView);
            concretePlayerView.OnInit(playerPresenter);

            return new MvpPlayer(concretePlayerView);
        }
    }
}
