using UnityEngine;
using System.Collections;

public class ARCameraController : MonoBehaviour
{
	private Texture2D backgroundTexture;
	public Material backgroundMat;

	void Start ()
	{
		QCARRenderer.Instance.DrawVideoBackground = false;

		backgroundTexture = new Texture2D(0, 0, TextureFormat.RGB565, false);
		backgroundTexture.filterMode = FilterMode.Point;
		backgroundTexture.wrapMode = TextureWrapMode.Repeat;

		QCARRenderer.Instance.SetVideoBackgroundTexture(backgroundTexture);

		backgroundMat.mainTexture = backgroundTexture;
	}
}
