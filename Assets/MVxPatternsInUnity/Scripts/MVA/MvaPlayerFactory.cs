using UnityEngine;

namespace MVxPatternsInUnity.Scripts.MVA
{
    public class MvaPlayerFactory : IPlayerFactory
    {
        public void CreatePlayer()
        {
            PlayerModel playerModel = new PlayerModel();
            PlayerView playerView = Object.FindObjectOfType<PlayerView>();
            PlayerController playerController = new PlayerController(playerModel, playerView);
            playerView.OnInit(playerController);
        }
    }
}
