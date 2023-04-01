using UnityEngine;
using UnityEngine.UI;

public class Selection : MonoBehaviour
{
    public Image[] selectionArray;
    public GameObject selectedIndicator;
    public Camera mainCamera;
    int currentlySelected = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            BackButton();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            NextButton();
        }
        
        if (Input.GetKeyDown(KeyCode.Space)) {
            SubmitButton();
        }
    }

    public void NextButton()
    {
        if (currentlySelected < selectionArray.Length - 1)
        {
            currentlySelected++;
            Vector3 p = selectionArray[currentlySelected].transform.localPosition;
            p.x -= 75f;
            selectedIndicator.transform.localPosition = p;
        }
    }

    public void BackButton()
    {
        if (currentlySelected > 0)
        {
            currentlySelected--;
            Vector3 p = selectionArray[currentlySelected].transform.localPosition;
            p.x -= 75f;
            selectedIndicator.transform.localPosition = p;
        }
    }

    public void SubmitButton()
    {
        mainCamera.backgroundColor = selectionArray[currentlySelected].color;
    }
}
