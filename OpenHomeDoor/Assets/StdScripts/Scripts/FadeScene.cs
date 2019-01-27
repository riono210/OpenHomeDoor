using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeScene : SingletonMonoBehaviour<FadeScene> {

	private bool isFadeIn;
	private bool isFadeOut;
	private bool isMove;
	private bool isDelegate;

	private bool isStartFade;

	// フェードアウトマスク
	public Image fadeImage;
	public Image startFadeImage;

	// フェイドインアウトするスピード
	private float fadeSpeed = 0.02f;
	private float startFadeSpeed = 0.02f;
	// マスクの色
	private float red,
	green,
	blue,
	alfa;

	private float redS,
	greenS,
	blueS,
	alfaS;

	// シーンの名前
	private string sceneName;

	// デリゲート
	public delegate void DelegateMethod ();
	private DelegateMethod loadMethod;

	// 初期化
	protected override void Awake () {
		Debug.Log ("init!");
		base.Awake ();
	}

	// Use this for initialization
	void Start () {
		//DontDestroyOnLoad (this.gameObject);
		isFadeOut = false;
		isMove = false;
		isFadeIn = false;

		isStartFade = true;

		//fadeImage = this.GetComponent<Image> ();
		Debug.Log (fadeImage);
		red = fadeImage.color.r;
		green = fadeImage.color.g;
		blue = fadeImage.color.b;
		alfa = fadeImage.color.a;

		// redS = startFadeImage.color.r;
		// greenS = startFadeImage.color.g;
		// blueS = startFadeImage.color.b;
		// alfaS = startFadeImage.color.a;
	}

	// Update is called once per frame
	void Update () {
		//SFadeIn ();

		NomalFade ();
	}

	// フェードイン
	private void FadeIn () {
		alfa -= fadeSpeed;
		setAlfa ();

		if (alfa <= 0) {
			isFadeIn = false;
			fadeImage.enabled = false;

		}
	}

	// フェードアウト
	private void FadeOut () {
		fadeImage.enabled = true;
		alfa += fadeSpeed;
		setAlfa ();

		if (alfa >= 1) {
			isFadeOut = false;
			// シーン移動時
			if (!isDelegate) {
				isMove = true;
			} else {  // デリゲート時
				ExecutionMethod ();
			}
		}
	}

	private void setAlfa () {
		fadeImage.color = new Color (red, green, blue, alfa);
	}

	// シーンの移動外部関数
	public void LoadScene (string scene) {
		isFadeOut = true;
		// 行き先を指定
		sceneName = scene;
	}

	// シーンの移動内部
	private void MoveScene () {
		SceneManager.LoadScene (sceneName);
		sceneName = null;
		isMove = false;
		isFadeIn = true;
	}

	// デリゲート外部関数
	public void LoadFade (DelegateMethod method) {
		isFadeOut = true;
		isDelegate = true;
		loadMethod = method;
	}

	// デリゲート内部処理
	private void ExecutionMethod () {
		loadMethod ();
		loadMethod = null;
		isDelegate = false;
		isFadeIn = true;
	}

	// 通常のfade Update管理
	private void NomalFade () {
		if (isFadeOut) {
			FadeOut ();
		}

		if (isFadeIn) {
			FadeIn ();
		}

		if (isMove) {
			MoveScene ();
		}
	}

	// スタート時フェードイン
	private void SFadeIn () {
		if (isStartFade) {
			alfaS -= startFadeSpeed;
			setStartAlfa ();

			if (alfaS <= 0) {
				isStartFade = false;
				startFadeImage.enabled = false;

			}
		}
	}

	private void setStartAlfa () {
		startFadeImage.color = new Color (redS, greenS, blueS, alfaS);
	}
}