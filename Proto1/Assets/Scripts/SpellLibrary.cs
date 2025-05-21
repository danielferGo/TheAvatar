using System.Collections.Generic;
using UnityEngine;

public class SpellLibrary : MonoBehaviour
{
    private Dictionary<(string gestureId, ElementType), SpellCommand> spellMap;
    public List<SpellCommand> spells;

    private void Start()
    {
        spellMap = new Dictionary<(string, ElementType), SpellCommand>();
        foreach (var spell in spells)
        {
            RegisterSpell(spell.GestureId, spell.ElementType, spell);
            Debug.Log("Registered spell: " + spell.SpellName);
        }
    }

    private void RegisterSpell(string gestureId, ElementType element, SpellCommand spell)
    {
        spellMap[(gestureId, element)] = spell;
    }

    public SpellCommand GetSpell(string gestureId, ElementType element)
    {
        return spellMap.GetValueOrDefault((gestureId, element));
    }
}

