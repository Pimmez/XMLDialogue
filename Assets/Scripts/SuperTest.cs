using UnityEngine;
using System.Collections;

public class SuperTest : MonoBehaviour {

    private XMLReader xmlReader = new XMLReader();

    [SerializeField]
    private GameObject button;

    [SerializeField]
    private string file;

    [SerializeField]
    private string path;

    [SerializeField]
    private string node;

    [SerializeField]
    private int id;

    // Use this for initialization
    void Start () {
        xmlReader.READXML(file, path, node, id);
        Debug.Log(xmlReader.READXML(file, path, node, id));
        //xmlReader.ReadSubnodes(file, path, id);
        //Debug.Log(xmlReader.ReadSubnodes(file, path, id));

        string[] choices = xmlReader.ReadSubnodes(file, path, id);

        for (int i = 0; i < xmlReader.ReadSubnodes(file, path + "/Greetings", id).Length; i++)
        {
            var choiceButton = (GameObject)Instantiate(button, new Vector3(0,i * 40,0), Quaternion.identity);
            ChangeButtonText textChange = choiceButton.GetComponent<ChangeButtonText>();
            choiceButton.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform,false);
            textChange.ChangeText(xmlReader.ReadSubnodes(file, path + "/Greetings", id)[i]);
            Debug.Log(xmlReader.ReadSubnodes(file, path + "/Greetings", id)[i]);
        }

    }
	
}
