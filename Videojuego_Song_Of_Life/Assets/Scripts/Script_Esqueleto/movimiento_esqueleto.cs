using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento_esqueleto : MonoBehaviour
{


    private float speed;
    
    public float MaxY = 1.2f;
    private float Totalduration = 1f;
    private Vector3 TargetPos;
    private Vector3 InitialPos;
    private bool isMovingUp;
    private bool isMovingDown;
    public int points;

    // Start is called before the first frame update
    void Start()
    {
        InitialPos = transform.position;
        TargetPos = new Vector3(InitialPos.x, MaxY, InitialPos.z);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isMovingUp && transform.position == InitialPos) 
        {
            Totalduration = Random.Range(1f, 2f);
            StartCoroutine(MoveUp(TargetPos, Totalduration));
        }

        if (!isMovingDown && transform.position == TargetPos)
        {

            Totalduration = Random.Range(1f, 2f);
            StartCoroutine(MoveDown(InitialPos, Totalduration));
        }
    }

    private void OnMouseDown()
    {
        //añadir puntos al score del GameManager
    }

    private IEnumerator MoveUp(Vector3 targetPosition, float duration)
    {
        if (isMovingUp)
        {
            yield break;
        }

        isMovingUp = true;

        yield return new WaitForSeconds(Random.Range(1f, 3f));

        speed = Vector3.Distance(transform.position, targetPosition) / duration;

        float passedTime = 0f;

        while (passedTime < duration)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            passedTime += Time.deltaTime;

            yield return null;

        }

        transform.position = targetPosition;
        isMovingUp = false;

    }

    private IEnumerator MoveDown(Vector3 targetPosition, float duration)
    {


        if (isMovingDown)
        {
            yield break;
        }

        isMovingDown = true;

        yield return new WaitForSeconds(Random.Range(1f, 3f));

       


        speed = Vector3.Distance(transform.position, targetPosition) / duration;

        float passedTime = 0f;

        while (passedTime < duration)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
            passedTime += Time.deltaTime;

            yield return null;

        }

        transform.position = targetPosition;
        isMovingDown = false;

    }

    
}
