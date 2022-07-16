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
            PlayerModelMvvm modelMvvm = new PlayerModelMvvm();

            // Act.
            modelMvvm.LevelUp();

            // Assert.
            Assert.IsTrue(modelMvvm.GetLevel() == 1);

            return null;
        }
    }
}
