using Kultie.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kultie.Battle
{
    public class GameActorDisplay : MonoBehaviour
    {
        [SerializeField]
        SpriteRenderer portraitRenderer;

        public void Init(GameCharacter gameCharacter)
        {
            portraitRenderer.sprite = gameCharacter.potrait;
        }
    }
}