using UnityEngine;

namespace Spells
{
    public class Fireball : MonoBehaviour
    {
        private void Update()
        {
            transform.position += transform.forward * Time.deltaTime * 1f;
        }
    
    }
}