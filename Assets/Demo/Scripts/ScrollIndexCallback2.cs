using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollIndexCallback2 : MonoBehaviour 
{
	public void ScrollCellIndex(GameObject gameObject, int idx)
    {
		ScrollIndexObject2 script = gameObject.GetComponent<ScrollIndexObject2>();
		script.OnScrollCellIndex(idx);
	}
}
