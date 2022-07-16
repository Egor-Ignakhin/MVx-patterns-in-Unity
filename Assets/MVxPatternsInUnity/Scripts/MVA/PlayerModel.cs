using System;
using UnityEngine;

namespace MVxPatternsInUnity.Scripts.MVA
{
    public class PlayerModel : MonoBehaviour
    {
        public event Action Changed;
        private int level;

        public void LevelUp()
        {
            level++;

            Changed?.Invoke();
        }

        public int GetLevel()
        {
            return level;
        }
    }
}
