using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollIndexCallback1 : MonoBehaviour 
{
	public void ScrollCellIndex (GameObject gameObject, int idx) 
    {
		ScrollIndexObject1 script = gameObject.GetComponent<ScrollIndexObject1>();
		script.OnScrollCellIndex(idx);
	}
}
