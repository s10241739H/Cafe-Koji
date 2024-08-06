using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    private AudioSource _clicksound;

    private void Awake()
    {
        _clicksound = GetComponent<AudioSource>();
    }

    private void OnMouseDown()
    {
        StartCoroutine(PressForSeconds(0.5f));
    }

    IEnumerator PressForSeconds(float seconds)
    {
        _clicksound.Play();
        
        // Store the original position
        Vector3 originalPosition = transform.position;
        
        // Move the object slightly down
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.1f, transform.position.z);
        
        yield return new WaitForSeconds(seconds);
        
        // Move the object back to its original position
        transform.position = originalPosition;
    }
}
