using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.ImageEffects;
using UnityEngine.Audio;
using System.Collections;

public class LogicScript : MonoBehaviour {

	private bool IIS;
	private bool sceneComplete;
	//private bool Scene1b = false;
	private bool Scene1a = false;
	private bool scene2 = false;
	private bool scene2_01 = false;
	private bool scene2_02 = false;
	private bool scene2_03 = false;
	private bool scene2_04 = false;
	private bool scene2_05 = false;
	private bool scene2_06 = false;
	private bool scene2a = false;
	private bool scene2b = false;
	private bool scene3 = false; 

	private int playScene;


	private bool gameStart;

	private int click = 0;


	private GameObject textMenu;
	private GameObject mainCamera;
	private GameObject scene1textObject;


	private GameObject bangTextObject;
	private GameObject shakyTextObject;


	public GameObject babyMonitor;
	private Animator scene1textAnim;
	private Animator bangTextAnim;
	private Animator shakyTextAnim;
	private Text bangText;
	private Text scene1text;
	private Text shakyText;

	private Animator textMenuAnim;

	private GameObject scene2textObject;
	private Text scene2Text;
	private Animator scene2textAnim;

	private GameObject scene2_01textObject;
	private Text scene2_01Text;
	private Animator scene2_01textAnim;

	private GameObject scene2_02textObject;
	private Text scene2_02Text;
	private Animator scene2_02textAnim;

	private GameObject scene2_03textObject;
	private Text scene2_03Text;
	private Animator scene2_03textAnim;

	private GameObject scene2_04textObject;
	private Text scene2_04Text;
	private Animator scene2_04textAnim;


	private GameObject scene2_05textObject;
	private Text scene2_05Text;
	private Animator scene2_05textAnim;

	private GameObject scene2_06textObject;
	private Text scene2_06Text;
	private Animator scene2_06textAnim;

	public AudioMixer mixer;
	private AudioMixerSnapshot snapshot;



	// Use this for initialization
	void Start () 
	{
		IIS = true;
		sceneComplete = false;

		playScene = 0;

		textMenu = GameObject.FindGameObjectWithTag("MainMenuText");
		textMenuAnim = textMenu.GetComponent<Animator>();
		mainCamera = GameObject.FindGameObjectWithTag("MainCamera");

		scene1textObject = GameObject.Find("Scene1Text");
		scene1text = scene1textObject.GetComponent<Text>();
		scene1textAnim = scene1textObject.GetComponent<Animator>();

		scene2textObject = GameObject.Find("Scene2Text");
		scene2Text = scene2textObject.GetComponent<Text>();
		scene2textAnim = scene2textObject.GetComponent<Animator>();

		scene2_01textObject = GameObject.Find("Scene2Text_01");
		scene2_01Text = scene2_01textObject.GetComponent<Text>();
		scene2_01textAnim = scene2_01textObject.GetComponent<Animator>();


		scene2_02textObject = GameObject.Find("Scene2Text_02");
		scene2_02Text = scene2_02textObject.GetComponent<Text>();
		scene2_02textAnim = scene2_02textObject.GetComponent<Animator>();

		scene2_03textObject = GameObject.Find("Scene2Text_03");
		scene2_03Text = scene2_03textObject.GetComponent<Text>();
		scene2_03textAnim = scene2_03textObject.GetComponent<Animator>();

		scene2_04textObject = GameObject.Find("Scene2Text_04");
		scene2_04Text = scene2_04textObject.GetComponent<Text>();
		scene2_04textAnim = scene2_04textObject.GetComponent<Animator>();

		scene2_05textObject = GameObject.Find("Scene2Text_05");
		scene2_05Text = scene2_05textObject.GetComponent<Text>();
		scene2_05textAnim = scene2_05textObject.GetComponent<Animator>();

		scene2_06textObject = GameObject.Find("Scene2Text_06");
		scene2_06Text = scene2_06textObject.GetComponent<Text>();
		scene2_06textAnim = scene2_06textObject.GetComponent<Animator>();

		bangTextObject = GameObject.Find("Bang Text");
		bangText = bangTextObject.GetComponent<Text>();
		bangTextAnim = bangTextObject.GetComponent<Animator>();




		shakyTextObject = GameObject.Find("ShakyText");
		shakyText = shakyTextObject.GetComponent<Text>();
		shakyTextAnim = shakyTextObject.GetComponent<Animator>();

	


		textMenuAnim.Play("MainLongFade");

		snapshot = mixer.FindSnapshot("Fadein");


	}
	
	// Update is called once per frame
	void Update () 
	{
		if(IIS == true)
		{
			IISRunning();
		}
		Debug.Log(playScene);
		Debug.Log(sceneComplete);
		if(sceneComplete==true)
		{
			playScene++;
			sceneComplete = false;
			if(playScene == 1) 
			{
				StartCoroutine(Scene1aStart());
			}
			if(playScene == 2)
			{
				StartCoroutine(Scene1bStart());
			}
			if(playScene == 3) 
			{
				Scene2Start();
			}
			if(playScene == 4) 
			{
				StartCoroutine(Scene2_01());
			}
			if(playScene == 5)
			{
				StartCoroutine(Scene2_02());
			}
			if(playScene == 6)
			{
				StartCoroutine(Scene2_03());
			}
			if(playScene == 7)
			{
				StartCoroutine(Scene2_04());
			}
			if(playScene == 8)
			{
				StartCoroutine(Scene2_05());
			}
			if(playScene == 9)
			{
				StartCoroutine(Scene2_06());
			}
			if(playScene == 10)
			{
				StartCoroutine(Scene3Start());
			}

		}

	}

	//White Noise title scene, waiting for mouse imput
	public void IISRunning()
	{
		if(Input.GetMouseButtonDown(0))
		{
			IIS = false;
			StartIntro();
		}
	}


	public void StartIntro()
	{
		textMenu.SetActive(false);
		scene1text.enabled = true;
		mainCamera.GetComponent<NoiseAndGrain>().intensityMultiplier = 0.5f;
		scene1textAnim.Play("Main Text");
		sceneComplete = true;
	}

	//playScene == 1
	IEnumerator Scene1aStart()
	{
		//scene1text.text = "You awaken to a loud banging on your door\n \"agh, what time is it?\"\n the clock reads 11:00pm\n the banging continues as you shuffle out of bed";
		scene1text.text = "You wake suddenly, unsure of whether the\n noise you heard was real or in a dream.\n The glow from the clock face blinds you momentarily.\n Your vision sharpens, it's just past midnight. Then you hear it again.";
      	yield return new WaitForSeconds(1);
		shakyText.enabled = true;
		yield return new WaitForSeconds(1);
		bangText.enabled = true;
		bangTextAnim.Play("Main Text");
		sceneComplete = true;
	}

	//playScene == 2
	IEnumerator Scene1bStart()
	{
		//shakyTextAnim.Play("Main Text");
		while (true)
		{
			if(Input.GetMouseButtonDown(0))
			{
				sceneComplete = true;
				yield break;
			}
			yield return null;
		}
	}

	//playScene == 3
	public void Scene2Start() //
	{
		bangTextAnim.SetBool("Fadeout",true);
		shakyTextAnim.SetBool("Fadeout",true);
		bangTextObject.SetActive(false);
		shakyTextObject.SetActive(false);
		scene1textObject.SetActive(false);

		//scene1text.text = "You glance into the peep hole and see your crazy neighbor\n \"What does she want?\"\nShe rambles on about a family member in the hospital, you're barely listening.\nShe finishes her rambling and asks, \"Can you watch my baby?\"\n\nShe looks desparate but has been nice enough to you in the past...,\n you reluctantly agree and start gathering your things.";
		//scene1text.text = "Your feet hit the floor, each step toward the door pulling you further from the fog of sleep. You squint through the peep hole and see your neighbor, she looks anxious."; 
		scene2Text.enabled = true;
		scene2textAnim.Play("Main Text");
		sceneComplete = true;
	}

	//playScene == 4
	IEnumerator Scene2_01()
	{
		yield return new WaitForSeconds(2);
		scene2textObject.SetActive(false);
		scene2_01Text.enabled = true;
		scene2_01textAnim.Play("Main Text");
		sceneComplete = true;
	}

	IEnumerator Scene2_02()
	{
		yield return new WaitForSeconds(2);
		//scene1text.text = "\"What does she want?\" you mumble under your breath as you turn the lock. Your hand hesitates on the handle...";
		scene2_01textObject.SetActive(false);
		scene2_02Text.enabled = true;
		scene2_02textAnim.Play("Main Text");
		sceneComplete = true;
	}
	IEnumerator Scene2_03()
	{
		yield return new WaitForSeconds(2);
		//scene1text.text = "as if some instinctive part of your brain is trying to tell you to turn back..."; 
		scene2_02textObject.SetActive(false);
		scene2_03Text.enabled = true;
		scene2_03textAnim.Play("Main Text");
		sceneComplete = true;
	}
	IEnumerator Scene2_04()
	{
		yield return new WaitForSeconds(2);
		//scene1text.text = "pretend you don\'t hear her…"; 
		scene2_03textObject.SetActive(false);
		scene2_04Text.enabled = true;
		scene2_04textAnim.Play("Main Text");
		sceneComplete = true;
	}

	//You sigh as you open the door
	//playScene ==
	IEnumerator Scene2_05()
	{
		yield return new WaitForSeconds(2);
		//scene1text.text = "You sigh as you pull the door open. Her head snaps up and she immediately starts rambling. You catch words like, \"elderly aunt\" and \"hospital,\" but she’s speaking so rapidly that you have trouble discerning the details. Her ponytail is wild and her clothes are mismatched, though that’s pretty much on par with her day to day appearance. As you begin to wonder this has to do with you, she stops and takes a deep breath. \"Can you watch my son? He’s sleeping, I just need someone there while I’m out.\"";
		scene2_04textObject.SetActive(false);
		scene2_05Text.enabled = true;
		scene2_05textAnim.Play("Main Text");
		sceneComplete = true;
	}
	IEnumerator Scene2_06()
	{
		yield return new WaitForSeconds(2);
		while (true)
		{
			if(Input.GetMouseButtonDown(0))
			{
				scene2_05textObject.SetActive(false);
				scene2_06Text.enabled = true;
				//scene2Text.text = "You're in her apartment now, as she leaves, she hands you an old looking baby monitor, it feels heavy in your hand and sounds like TV static playing from it. She mutters something about white noise keeps it quiet and disappears";
				scene2Text.text = "Her desperation is palpable. You don’t owe her anything, you two could hardly be considered acquaintances. Yet her pleading eyes are locked on to your face, and she’s already handing you an ancient looking baby monitor that is emitting a noise like TV static.\"Yeah…yes, of course. Let me get my shoes,\" you reluctantly reply.";
				scene2textAnim.Play("Main Text");
				yield return new WaitForSeconds(2);
				babyMonitor.SetActive(true);
				snapshot.TransitionTo(2);scene3 = true;
				sceneComplete = true;
				yield break;
			}
			yield return null;
		}
	}

	IEnumerator Scene3Start()
	{
		//scene2Text.text = "The living room is filled with pictures and various knickknacks, you sit on the couch and settle in, baby monitor by your side. The noise makes you sleepy, guess it works";
		scene2_06Text.enabled = false;
		scene2textObject.SetActive(true);
		scene2Text.text = "She leads you down the hall to her apartment door, the hefty baby monitor dragging your arm toward the floor. \"It’s a white noise machine,\" she explains, \"that noise you hear, it helps him sleep, it should play all night, I'll be back before the morning.\" With that, she turns and rushes out the door leaving you alone in the cluttered living room. You step over toys as you pick your way toward the couch. The walls are lined with clutter- knick knacks on shelves, family photos in thick frames, their occupants staring down at you as you sit in the quiet room. The only sound you hear is the roar of the white noise. It only takes a few moments before your eyelids are drooping, you decide to lay on the couch.";
		scene2textAnim.Play("Main Text");
		yield return new WaitForSeconds(2);

	}


}
