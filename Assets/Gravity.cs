using UnityEngine;
using UnityEngine.UI;

public class Gravity : MonoBehaviour
{
    public Toggle gravityToggle; // Reference to the toggle UI
    private Vector3 defaultGravity;

    void Start()
    {
        // Store the default gravity
        defaultGravity = Physics.gravity;

        // Add a listener for the toggle button
        gravityToggle.onValueChanged.AddListener(delegate { ToggleGravity(gravityToggle.isOn); });
    }

    void ToggleGravity(bool isGravityOn)
    {
        // Enable or disable gravity based on the toggle's state
        if (isGravityOn)
        {
            Physics.gravity = defaultGravity; // Enable gravity
        }
        else
        {
            Physics.gravity = Vector3.zero; // Disable gravity
        }
    }
}
