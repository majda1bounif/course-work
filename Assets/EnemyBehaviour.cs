using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    private int state = 0;
    public GameObject canvas;
    public bool isKilling = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x - 4.5f, -1.91f, -1);
        if (isKilling)
        {
            KillPlayer();
        }
    }
    public void GoFurther()
    {
        state--;
        animator.SetInteger("State", state);
    }
    public void GoCloser()
    {
        state++;
        animator.SetInteger("State", state);
    }
    void KillPlayer()
    {
        canvas.GetComponent<CanvasManager>().GameOver();
    }
}
