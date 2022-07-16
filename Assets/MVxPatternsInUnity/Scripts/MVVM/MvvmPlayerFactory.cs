using UnityEngine;

namespace MVxPatternsInUnity.Scripts.MVVM
{
    public class MvvmPlayerFactory : IPlayerFactory
    {
        public void CreatePlayer()
        {
            PlayerModelMvvm model = new PlayerModelMvvm();
            var concretePlayerView = Object.FindObjectOfType<PlayerViewMvvm>();
            PlayerViewModelMvvm playerViewModel = new PlayerViewModelMvvm(model);
            model.SetPlayerViewModel(playerViewModel);
            concretePlayerView.OnInit(playerViewModel);
        }
    }
}
