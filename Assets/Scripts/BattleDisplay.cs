using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kultie.Battle
{
    public class BattleDisplay : MonoBehaviour
    {
        private static BattleDisplay Instance;
        [SerializeField]
        SpriteRenderer[] renderers;
        private void Awake()
        {
            Instance = this;
        }

        public static void CreatePortrait()
        {
            var party = BattleManager.PlayerParty;
            for (int i = 0; i < party.Members.Count; i++)
            {
                Instance.renderers[i].sprite = party.Members[i].Character.potrait;
            }
        }

    }
}