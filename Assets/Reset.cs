using UnityEngine;
using UnityEngine.UI;

public class Reset : MonoBehaviour
{
    public Button resetButton;  // Reference to the reset button
    public GameObject[] objectsToReset;  // Array of objects to reset

    private Vector3[] initialPositions;  // Array to store initial positions
    private Quaternion[] initialRotations;  // Array to store initial rotations

    void Start()
    {
        // Store the initial positions and rotations of the objects
        initialPositions = new Vector3[objectsToReset.Length];
        initialRotations = new Quaternion[objectsToReset.Length];

        for (int i = 0; i < objectsToReset.Length; i++)
        {
            initialPositions[i] = objectsToReset[i].transform.position;
            initialRotations[i] = objectsToReset[i].transform.rotation;
        }

        // Add listener for the reset button
        resetButton.onClick.AddListener(ResetPositions);
    }

    // Method to reset the objects' positions and rotations
    void ResetPositions()
    {
        for (int i = 0; i < objectsToReset.Length; i++)
        {
            objectsToReset[i].transform.position = initialPositions[i];
            objectsToReset[i].transform.rotation = initialRotations[i];
            // Optionally reset velocity if the objects have Rigidbody components
            Rigidbody rb = objectsToReset[i].GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
        }
    }
}
