namespace Spells
{
    public class FireBallSpell : SpellCommand
    {
        private bool isWaiting = true;

        public override void Execute(HandContext handContext)
        {
            Instantiate(SpellPrefab, handContext.spawnPoint.position, handContext.spawnPoint.rotation);
        }

        public override void Desactivate()
        {
            isWaiting = false;
        }
    }
}