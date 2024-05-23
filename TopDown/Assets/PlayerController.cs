using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D playerRig;
    [SerializeField] private float speed = 5;
    private Vector2 movement;
    
    void Start()
    {
        playerRig = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Inputs();
    }
    void Inputs()
    {
        movement = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }
    void FixedUpdate()
    {
        if(!PauseGame.pauseGame)
        {
            //playerRig.MovePosition(playerRig.position + movement.normalized * speed * Time.fixedDeltaTime);
            //playerRig.velocity = movement.normalized * speed;
            playerRig.position += movement.normalized * speed * Time.fixedDeltaTime;
        }
    }
}
