using UnityEngine;

public abstract class SpellCommand : MonoBehaviour
{
    [SerializeField] private string spellName;
    [SerializeField] private string gestureId;
    [SerializeField] private ElementType elementType;
    [SerializeField] private GameObject spellPrefab;
    [SerializeField] private float cooldownTime;
    [SerializeField] private float manaCost;
    [SerializeField] private float castTime;
    [SerializeField] private float range;
    [SerializeField] private float damage;
    [SerializeField] private float areaOfEffect;


    public string SpellName => spellName;
    public string GestureId => gestureId;
    public ElementType ElementType => elementType;
    
    public GameObject SpellPrefab => spellPrefab;
    public abstract void Execute(HandContext handContext);
    public abstract void Desactivate();
}