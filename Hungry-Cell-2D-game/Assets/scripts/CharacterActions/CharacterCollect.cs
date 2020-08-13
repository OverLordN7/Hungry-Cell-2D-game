using UnityEngine;

namespace CharacterActions
{
    public class CharacterCollect : MonoBehaviour
    {
        //responsible for health
        public GameHandler gameHandler;
    
    
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.gameObject.CompareTag("Food"))
            {
                Destroy(other.gameObject);
                Score.scoreAmount += 1;
                FindObjectOfType<AudioManager>().Play("CollectFood");
                gameHandler.TakeHeal(10);
            
            
            }
            if (other.gameObject.CompareTag("Poison"))
            {
                Destroy(other.gameObject);
                Score.scoreAmount += 1;
                FindObjectOfType<AudioManager>().Play("poison");
                gameHandler.TakeDamage(10);
            }
        }
    }
}
