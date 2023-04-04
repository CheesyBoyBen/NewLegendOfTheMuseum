using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounce : MonoBehaviour
{
    public float bounceHeight = 1f;     // The height to which the object should bounce
    public float bounceDuration = 1f;   // The duration of the bounce animation

    private bool isActive = false;      // A flag indicating whether the object is active
    private Vector3 initialPosition;  // The initial position of the object

    public int counter = 0;

    public GameObject cbc; //charge box cover

    private void Start()
    {
        // Store the initial position of the object
        initialPosition = transform.position;
    }

    private void Update()
    {
        // If the object becomes active, start the bounce animation
        if (!isActive && gameObject.activeSelf  && counter == 3)
        {
            isActive = true;
            StartCoroutine(BounceAnimation());
            cbc.SetActive(false);

        }
    }

    public void Add()
    {
        counter++;
    }

    private IEnumerator BounceAnimation()
    {
        // Calculate the target position for the bounce animation
        Vector3 targetPosition = initialPosition + Vector3.up * bounceHeight;

        // Animate the object's position over the specified duration
        float elapsedTime = 0f;
        while (elapsedTime < bounceDuration)
        {
            transform.position = Vector3.Lerp(initialPosition, targetPosition, elapsedTime / bounceDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Reverse the animation to return the object to its initial position
        elapsedTime = 0f;
        while (elapsedTime < bounceDuration)
        {
            transform.position = Vector3.Lerp(targetPosition, initialPosition, elapsedTime / bounceDuration);
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        // Reset the object's position and the active flag
        transform.position = initialPosition;
        isActive = false;
    }
}