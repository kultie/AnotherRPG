using Sirenix.OdinInspector;
using System.Collections.Generic;
using UnityEngine;
namespace Kultie.Database
{
    public enum CharacterType { Power, Magic, Balance }
    [CreateAssetMenu(fileName = "Character", menuName = "Data/Characters", order = 1)]

    public class GameCharacter : SerializedScriptableObject
    {
        string _id;
        public string id
        {
            get
            {
                if (string.IsNullOrEmpty(_id))
                {
                    _id = System.Guid.NewGuid().ToString();
                }
                return _id;
            }
        }
        public CharacterType type;
        public string name;
        public CharacterStat stats;
        public Sprite potrait;
        public Skill[] skills;

        public void Init()
        {
            stats.Init();
        }
    }
}