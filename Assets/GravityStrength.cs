using UnityEngine;
using UnityEngine.UI;  // Required for UI elements like Slider

public class GravityStrength : MonoBehaviour
{
    public Slider gravitySlider;  // Reference to the slider UI
    public Text gravityValueText; // Optional: Reference to display current gravity value

    private void Start()
    {
        // Initialize gravity based on the slider value
        if (gravitySlider != null)
        {
            UpdateGravity(gravitySlider.value);

            // Add listener to update gravity when slider value changes
            gravitySlider.onValueChanged.AddListener(delegate { UpdateGravity(gravitySlider.value); });

            // Optional: Display the initial gravity value
            if (gravityValueText != null)
            {
                gravityValueText.text = $"Gravity Strength: {gravitySlider.value}";
            }
        }
        else
        {
            Debug.LogError("Gravity slider not assigned!");
        }
    }

    // Method to update gravity based on the slider value
    private void UpdateGravity(float value)
    {
        // Update the gravity strength. Adjust the multiplier as needed.
        Physics.gravity = new Vector3(0, -value, 0);

        // Optional: Update displayed value
        if (gravityValueText != null)
        {
            gravityValueText.text = $"Gravity Strength: {value}";
        }
    }
}
