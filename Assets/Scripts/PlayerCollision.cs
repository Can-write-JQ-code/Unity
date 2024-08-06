 
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   
    
    public PlayerMovement movement;
    //    Åö×²Ê±½øÈë
    private void OnCollisionEnter(Collision collision)
    {
         if(collision.collider.tag == "Obstacles")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
