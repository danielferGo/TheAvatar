using UnityEngine;

namespace Spells
{
    public class GroundElevationSpell : SpellCommand
    {
        GameObject gameObject;

        public override void Execute(HandContext handContext)
        {
            gameObject = Instantiate(SpellPrefab, handContext.spawnPoint.position, handContext.spawnPoint.rotation);
            Destroy(gameObject, 1.5f);

        }

        public override void Desactivate()
        {
            Destroy(gameObject);
        }
    }
}