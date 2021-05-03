using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Kultie.Database;
using System;

namespace Kultie.Battle
{
    public class GameParty : MonoBehaviour
    {
        [SerializeField]
        List<GameActor> actors;
        public List<GameActor> Members => actors;
        public void AddMember(GameActor actor)
        {
            actors.Add(actor);
        }

        public void RemoveActor(GameActor actor)
        {
            actors.Add(actor);
        }

        public void RemoveActor(string id)
        {
            actors.RemoveAll(r => r.Character.id == id);
        }

        public void Setup(GameActor prefab, GameCharacter[] players)
        {
            for (int i = 0; i < players.Length; i++)
            {
                var a = Instantiate(prefab);
                a.Setup(players[i], this);
                a.transform.parent = transform;
                a.transform.position = new Vector3(0, -i, 0);
                AddMember(a);
            }
        }
    }
}