using MVxPatternsInUnity.Scripts.MVP;

using NUnit.Framework;

using System.Collections;
using System.Reflection;

using TMPro;

using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace MVxPatternsInUnity.Scripts.Tests.PlayMode
{
    public class MvpTests
    {
        private IPlayerPresenter playerPresenter;
        private IPlayerModel playerModel;
        private IPlayerView view;

        [UnitySetUp]
        public IEnumerator Setup()
        {
            playerModel = new ConcretePlayerModelMvp();

            view = new GameObject().AddComponent<ConcretePlayerViewMvp>();

            Button levelUpButton = new GameObject().AddComponent<Button>();
            FieldInfo levelUpButtonFI = typeof(ConcretePlayerViewMvp).GetField("levelUpButton",
                BindingFlags.NonPublic | BindingFlags.Instance);
            levelUpButtonFI.SetValue(view, levelUpButton);

            TextMeshProUGUI currentLevelText = new GameObject().AddComponent<TextMeshProUGUI>();
            FieldInfo currentLevelTextFI = typeof(ConcretePlayerViewMvp).GetField("levelText",
                BindingFlags.NonPublic | BindingFlags.Instance);
            currentLevelTextFI.SetValue(view, currentLevelText);

            playerPresenter = new ConcretePlayerPresenterMvp(playerModel, view);

            yield return new EnterPlayMode();
        }

        [UnityTest]
        public IEnumerator WhenPlayerLevelIsZero_AndPlayerLevelUp_ThenPlayerLevelIsOne()
        {
            // Arrange.

            // Act.
            playerPresenter.LevelUp();

            // Assert.
            Assert.IsTrue(playerModel.GetLevel() == 1);

            return null;
        }

        [UnityTearDown]
        public IEnumerator TearDown()
        {

            yield return new ExitPlayMode();
        }
    }
}
