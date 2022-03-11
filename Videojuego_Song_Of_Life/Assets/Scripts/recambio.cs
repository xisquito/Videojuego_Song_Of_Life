using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recambio : MonoBehaviour
{


    private bool isAnimating;
    private Animator anim;
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        isAnimating = anim.GetBool("animacion");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("PULSANDO");
            isAnimating = !isAnimating;
            anim.SetBool("animacion", isAnimating);
        }
       
    }
}
