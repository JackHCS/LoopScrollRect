using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollIndexObject3 : MonoBehaviour
{
    public Text text;

    public void OnScrollCellIndex(int idx)
    {
        string name = "Cell " + idx.ToString();
        if (text != null)
        {
            text.text = name;
        }
    }
}
