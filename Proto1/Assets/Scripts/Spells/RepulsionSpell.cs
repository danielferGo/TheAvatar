using UnityEngine;

namespace Spells
{
    public class RepulsionSpell : SpellCommand
    {
        private bool _isCasting;
        private GameObject repulsionSpell;

        public override void Execute(HandContext handContext)
        {
            if (_isCasting) return;
            var repulsion = Instantiate(SpellPrefab, handContext.spawnPoint.position, handContext.spawnPoint.rotation);
            repulsion.transform.parent = handContext.spawnPoint.transform;
            repulsionSpell = repulsion;
            _isCasting = true;
        }

        public override void Desactivate()
        {
            _isCasting = false;
            Destroy(repulsionSpell);
        }
    }
}