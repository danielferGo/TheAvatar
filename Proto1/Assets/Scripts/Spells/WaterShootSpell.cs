using UnityEngine;

namespace Spells
{
    public class WaterShootSpell : SpellCommand
    {
        GameObject gameObject;

        public override void Execute(HandContext handContext)
        {
            gameObject = Instantiate(SpellPrefab, handContext.spawnPoint.position, handContext.spawnPoint.rotation);
        }

        public override void Desactivate()
        {
            Destroy(gameObject, 0.5f);
        }
    }
}