using System.Collections;
using MVxPatternsInUnity.Scripts.MVVM;
using UnityEngine.Assertions;
using UnityEngine.TestTools;

namespace MVxPatternsInUnity.Scripts.Tests.PlayMode
{
    public class MvvmTests
    {
        [UnityTest]
        public IEnumerator WhenPlayerLevelIsZero_AndPlayerLevelUp_ThenPlayerLevelIsOne()
        {
            // Arrange.
            PlayerModelMvvm model = new PlayerModelMvvm();

            // Act.
            model.LevelUp();

            // Assert.
            Assert.IsTrue(model.GetLevel() == 1);

            return null;
        }
    }
}
