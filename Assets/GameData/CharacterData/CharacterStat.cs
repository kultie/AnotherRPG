using System;
using System.Collections.Generic;
using UnityEngine;
namespace Kultie.Database
{
    [Serializable]
    public enum StatKey { MaxHP, MaxMP, Power, Magic, DamageReduction }
    public class CharacterStat
    {
        public Dictionary<StatKey, float> baseValue;

        public Dictionary<string, StatModifier> modifiers;
        Dictionary<StatKey, float> currentValue;
        bool isDirty;
        public void Init()
        {
            currentValue = new Dictionary<StatKey, float>(baseValue);
            if (modifiers.Count > 0)
            {
                isDirty = true;
            }
        }

        public void AddModifier(StatModifier mod)
        {
            modifiers[mod.id] = mod;
            isDirty = true;
        }

        public void RemoveModifier(string id)
        {
            modifiers.Remove(id);
            isDirty = true;
        }

        public void RemoveModifier(StatModifier mod)
        {
            modifiers.Remove(mod.id);
            isDirty = true;
        }

        public float GetStat(StatKey key)
        {
            if (isDirty)
            {
                float current = baseValue[key];
                float flat = 0;
                float mult = 0;
                foreach (var kv in modifiers)
                {
                    StatModifier mod = kv.Value;
                    flat += mod.flatValue[key];
                    mult += mod.multValue[key];
                }
                current = (current + flat) * (1 + mult);
                current = Mathf.Max(current, 0);
                isDirty = false;
                currentValue[key] = current;
            }
            return currentValue[key];
        }
    }

    public class StatModifier
    {
        public string id;
        public Dictionary<StatKey, float> flatValue;
        public Dictionary<StatKey, float> multValue;
    }
}