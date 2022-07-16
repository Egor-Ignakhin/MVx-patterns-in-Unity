using MVxPatternsInUnity.Scripts.MVC;
using MVxPatternsInUnity.Scripts.MVP;
using MVxPatternsInUnity.Scripts.MVVM;

using System;

using UnityEngine;

namespace MVxPatternsInUnity.Scripts
{
    public class Client : MonoBehaviour
    {
        [SerializeField] private Patterns pattern;
        [SerializeField] private Transform patternsContainer;

        private void Start()
        {
            IPlayerFactory playerFactory = CreatePlayerFactory(pattern);
            playerFactory.CreatePlayer();
        }

        private IPlayerFactory CreatePlayerFactory(Patterns pattern)
        {
            switch (pattern)
            {
                case Patterns.Mvc:
                    return new MvcPlayerFactory();

                case Patterns.Mvp:
                    return new MvpPlayerFactory();

                case Patterns.Mvvm:
                    return new MvvmPlayerFactory();

                default:
                    throw new Exception(pattern + " is unknown pattern.");
            }
        }

        private void OnValidate()
        {
            for (int i = 0; i < patternsContainer.childCount; i++)
            {
                var child = patternsContainer.GetChild(i);
                child.gameObject.SetActive((int)pattern == child.GetSiblingIndex());
            }
        }
    }
}
