using UnityEngine;

namespace Spells
{
    public class WaterMovementSpell : SpellCommand
    {
        GameObject gameObject;

        public override void Execute(HandContext handContext)
        {
            gameObject = Instantiate(SpellPrefab, handContext.spawnPoint.position, handContext.spawnPoint.rotation);
            gameObject.transform.parent = handContext.spawnPoint.transform;
        }

        public override void Desactivate()
        {
            Destroy(gameObject);
        }
    }
}