using UnityEngine;
using UnityEngine.UI;  // Required for UI elements like Button

public class Randomize : MonoBehaviour
{
    public Button randomizeButton;  // Reference to the randomize button
    public GameObject[] objectsToRandomize;  // Array of objects to randomize

    void Start()
    {
        // Ensure the randomize button is assigned and set up the listener
        if (randomizeButton != null)
        {
            randomizeButton.onClick.AddListener(RandomizePositions);
        }
        else
        {
            Debug.LogError("Randomize button not assigned!");
        }
    }

    // Method to randomize positions and orientations of objects
    void RandomizePositions()
    {
        foreach (GameObject obj in objectsToRandomize)
        {
            // Randomize position within a range
            obj.transform.position = new Vector3(
                Random.Range(-10f, 10f),
                Random.Range(-10f, 10f),
                Random.Range(-10f, 10f)
            );

            // Randomize rotation
            obj.transform.rotation = Quaternion.Euler(
                Random.Range(0f, 360f),
                Random.Range(0f, 360f),
                Random.Range(0f, 360f)
            );
        }
    }
}
