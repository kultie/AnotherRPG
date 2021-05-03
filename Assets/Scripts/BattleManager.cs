using Kultie.Database;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kultie.Battle
{
    public class BattleManager : MonoBehaviour
    {
        private static BattleManager Instance;
        [SerializeField]
        GameParty playerParty;
        [SerializeField]
        GameParty enemyParty;

        [SerializeField]
        GameCharacter[] players;

        [SerializeField]
        GameActor prefab;

        public static GameParty PlayerParty => Instance.playerParty;
        public static GameParty EnemyParty => Instance.enemyParty;
        private void Awake()
        {
            Instance = this;
        }

        private void Start()
        {
            Init(players, null);
        }


        public static void Init(GameCharacter[] players, GameCharacter[] enemies)
        {
            Instance.playerParty.Setup(Instance.prefab, players);
            //Instance.enemyParty.Setup(enemies);
            //BattleDisplay.CreatePortrait();
        }
    }
}