using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScrollIndexCallback3 : MonoBehaviour
{
	public void ScrollCellIndex(GameObject gameObject, int idx)
	{
		ScrollIndexObject3 script = gameObject.GetComponent<ScrollIndexObject3>();
		script.OnScrollCellIndex(idx);
	}
}
