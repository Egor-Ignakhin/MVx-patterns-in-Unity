
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
            PlayerModel modelMvvm = new PlayerModel();

            // Act.
            modelMvvm.LevelUp();

            // Assert.
            Assert.IsTrue(modelMvvm.GetLevel() == 1);

            return null;
        }
    }
}
