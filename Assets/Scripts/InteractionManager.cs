using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionManager : MonoBehaviour
{
    public Camera playerCamera; // Reference to the player's camera
    public float interactionDistance = 5f; // Maximum distance for interaction
    public string clickableTag = "Clickable"; // Tag for clickable objects

    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // Detect mouse button click
        {
            Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, interactionDistance))
            {
                if (hit.collider.CompareTag(clickableTag))
                {
                    // Call the OnClick method on the clicked object
                    ClickableObject clickable = hit.collider.GetComponent<ClickableObject>();
                    if (clickable != null)
                    {
                        clickable.OnClick();
                    }
                }
            }
        }
    }
}
