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
        private PlayerPresenter presenter;
        private PlayerModel model;
        private PlayerView view;

        [UnitySetUp]
        public IEnumerator Setup()
        {
            model = new PlayerModel();

            view = new GameObject().AddComponent<PlayerView>();

            Button levelUpButton = new GameObject().AddComponent<Button>();
            FieldInfo levelUpButtonFI = typeof(PlayerView).GetField("levelUpButton",
                BindingFlags.NonPublic | BindingFlags.Instance);
            levelUpButtonFI.SetValue(view, levelUpButton);

            TextMeshProUGUI currentLevelText = new GameObject().AddComponent<TextMeshProUGUI>();
            FieldInfo currentLevelTextFI = typeof(PlayerView).GetField("levelText",
                BindingFlags.NonPublic | BindingFlags.Instance);
            currentLevelTextFI.SetValue(view, currentLevelText);

            presenter = new PlayerPresenter(view, model);

            yield return new EnterPlayMode();
        }

        [UnityTest]
        public IEnumerator WhenPlayerLevelIsZero_AndPlayerLevelUp_ThenPlayerLevelIsOne()
        {
            // Arrange.

            // Act.
            presenter.LevelUp();

            // Assert.
            Assert.IsTrue(model.GetLevel() == 1);

            return null;
        }

        [UnityTearDown]
        public IEnumerator TearDown()
        {

            yield return new ExitPlayMode();
        }
    }
}
