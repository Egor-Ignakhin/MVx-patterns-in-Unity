using System.Collections;
using MVxPatternsInUnity.Scripts.MVA;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.TestTools;

namespace MVxPatternsInUnity.Scripts.Tests.PlayMode
{
    public class MvaTests : MonoBehaviour
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
