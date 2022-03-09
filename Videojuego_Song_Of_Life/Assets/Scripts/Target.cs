using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public ParticleSystem explosionParticle;
    private GameManager gameManagerScript;

    private AudioSource playerAudioSource;
    public AudioClip targetClip;

    

    [SerializeField] private int points; // Puntos que da el target
    private bool clickedOnGoodTarget;

    // Start is called before the first frame update
    void Start()
    {
        gameManagerScript = FindObjectOfType<GameManager>();

        playerAudioSource = GetComponent<AudioSource>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (!gameManagerScript.gameOver)
        {
            
            // Dar o quitar puntos
            gameManagerScript.UpdateScore(points);
            Instantiate(explosionParticle,
               transform.position,
               explosionParticle.transform.rotation);
            playerAudioSource.PlayOneShot(targetClip);



            if (gameObject.CompareTag("Player"))
            {
                clickedOnGoodTarget = true;
                // Musiquita de ¡bien hecho!
                
            }
           
        }
    }
}
