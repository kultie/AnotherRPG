using Kultie.Database;
using UnityEngine;
namespace Kultie.Battle
{
    [RequireComponent(typeof(GameActorDisplay))]
    public class GameActor : MonoBehaviour
    {
        public GameParty Party { private set; get; }
        public GameActorDisplay display;

        public GameCharacter Character { private set; get; }
        public void Setup(GameCharacter gameCharacter, GameParty party)
        {
            Character = Instantiate(gameCharacter);
            Character.Init();
            Party = party;
            display.Init(gameCharacter);
        }
    }
}