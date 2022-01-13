using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteRadius : MonoBehaviour
{
    public GameObject damageRadius;
    private float waitTime = .5f;
    private void Start()
    {
        StartCoroutine(Wait());

        IEnumerator Wait()
        {
            yield return new WaitForSeconds(waitTime);
            Destroy(damageRadius);
        }
    }

}
