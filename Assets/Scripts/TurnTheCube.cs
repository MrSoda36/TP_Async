using System.Collections;
using UnityEngine;

public class TurnTheCube : MonoBehaviour
{
    private void Start()
    {
        //StartCoroutine(TurnCube());
    }

    public void StartSpin()
    {
        StartCoroutine(TurnCube());
    }

    public IEnumerator TurnCube()
    {
        float passedTime = 0;
        while (passedTime < 5f)
        {
            transform.Rotate(0, 45 * passedTime, 0);
            passedTime += Time.deltaTime;
            yield return null;
        }
    }

    public void StopCube()
    {
        StopAllCoroutines();
    }
}
