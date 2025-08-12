using UnityEngine;

public class moveright : MonoBehaviour
{
    public Animator moverightanimator;

    void Start()
    {
        //animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            //animator.SetBool("isMoving", true);
        }

        if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            //animator.SetBool("isMoving", false);
        }
    }
}
