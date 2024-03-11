using UnityEngine;

public class GameOver : MonoBehaviour
{
    public AudioClip bounce;
    public AudioClip gameover;
    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (!collision.gameObject.CompareTag("Finish"))
        {
            AudioSource.PlayClipAtPoint(bounce, transform.position);
        }
    }

    private void OnDisable()
    {
        AudioSource.PlayClipAtPoint(gameover, transform.position);
        
    }
}