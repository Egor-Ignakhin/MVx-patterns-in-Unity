
using MVxPatternsInUnity.Scripts.MVC;

using System.Collections;

using UnityEngine.Assertions;
using UnityEngine.TestTools;

namespace MVxPatternsInUnity.Scripts.Tests.PlayMode
{
    public class MvcTests
    {
        [UnityTest]
        public IEnumerator WhenPlayerLevelIsZero_AndPlayerLevelUp_ThenPlayerLevelIsOne()
        {
            // Arrange.
            PlayerModel model = new PlayerModel();

            // Act.
            model.LevelUp();

            // Assert.
            Assert.IsTrue(model.GetLevel() == 1);

            return null;
        }
    }
}
