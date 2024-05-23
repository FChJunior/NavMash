using UnityEngine;
using UnityEngine.AI;

public class Inimigo : MonoBehaviour
{
    public NavMeshAgent inimigo;
    public Transform player;
    public float distance = 0;

    void Start()
    {
        inimigo = GetComponent<NavMeshAgent>();
        inimigo.updateRotation = false;
        inimigo.updateUpAxis = false;
    }

    void Update()
    {
        distance = Vector2.Distance(player.position, transform.position);

        if(distance <= 10)
        {
            if(!PauseGame.pauseGame)inimigo.SetDestination(player.position);
            else inimigo.SetDestination(transform.position);
        }
        else inimigo.SetDestination(transform.position);
        
    }
}
