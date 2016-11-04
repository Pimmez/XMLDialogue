using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ChangeButtonText : MonoBehaviour {

    [SerializeField]
    private Text uiText;

    public void ChangeText(string buttonText)
    {
        uiText.text = buttonText;
    }

}
