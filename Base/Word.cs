using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MEC;

[System.Serializable]
public class Word : MonoBehaviour
{
    protected WordEventHandler eventHandler;

    [SerializeField]
    protected string word = "";
    protected Vector3 vectorToMove = -Vector3.forward;
    [SerializeField]
    protected int currentChar = 0;
    protected int wordLenght = 0;
    [SerializeField]
    protected int correctChars = 0;

    [SerializeField]
    protected int wordID = 0;
    protected static int wordIDCounter = 0;

    protected Vector3 startPos;
    protected Vector3 endPos;

    //==================================================//

    public string WordString { get { return word; } }
    public int WordLength { get { return wordLenght; } }
    public int WordID { get { return wordID; } }

    //==================================================//

    private void Awake()
    {
        wordID = wordIDCounter;
        wordIDCounter++;
    }

    // Start is called before the first frame update
    protected void Start()
    {
        if (eventHandler == null) eventHandler = new WordEventHandler();
    }

    //===========================================================================//

    protected virtual void OnEnable()
    {
        //InputEventHandler.RegisterToKeyboardCharPressed(CheckKeyboardInput);
    }

    protected virtual void OnDisable()
    {
        InputEventHandler.UnRegisterToKeyboardCharPressed(CheckKeyboardInput);
    }

    //===========================================================================//

    // Update is called once per frame
    protected void Update()
    {
        transform.position += vectorToMove * StaticData.TankData.CurrentTankSpeed;
    }

    protected virtual IEnumerator<float> CheckWordStatus()
    {
        while (gameObject.activeSelf)
        {

            for (int i = currentChar; i < transform.childCount; i++)
            {
                if(Vector3.Distance(endPos , transform.GetChild(i).position) < 0.5f)
                {
                    CheckKeyboardInput('`');
                }
            }

            //Counting typed letters

            //Disabling each letter after disable treeshold
            /*
            for (int i = 0; i < currentChar; i++)
            {
                if (transform.GetChild(i).gameObject.activeSelf)
                {
                    transform.GetChild(i).gameObject.SetActive(false);
                }
            }
            */

            yield return Timing.WaitForSeconds(Timing.DeltaTime);
        }
    }

    //---------------------------------------------------------------------------//

    public virtual void InitializeWordSetup(string word, Vector3 startPos, Vector3 endPos)
    {
        this.word = WordHelper.InitCharsWord(this.gameObject, word);
        wordLenght = word.Length;

        this.startPos = startPos;
        this.endPos = endPos;

        Timing.RunCoroutine(CheckWordStatus().CancelWith(gameObject));
    }

    public virtual void InitializeWordSetup(Vector3 startPos, Vector3 endPos)
    {
        this.word = WordHelper.InitRandomCharsWord(this.gameObject);
        wordLenght = word.Length;

        this.startPos = startPos;
        this.endPos = endPos;

        Timing.RunCoroutine(CheckWordStatus().CancelWith(gameObject));
    }

    //---------------------------------------------------------------------------//

    public virtual void InitializeWordTyping()
    {
        InputEventHandler.RegisterToKeyboardCharPressed(CheckKeyboardInput);
        transform.GetChild(currentChar).GetComponent<Renderer>().material = StaticData.WordData.CurrentLetterMat;
    }

    public virtual void DeInitializeWordTyping()
    {
        InputEventHandler.UnRegisterToKeyboardCharPressed(CheckKeyboardInput);
    }

    //--------------------------------------------------------------------------//

    protected virtual void CheckKeyboardInput(char letter)
    {
        char capitalLetter = char.ToUpper(letter);
        if (word[currentChar] == capitalLetter)
        {
            transform.GetChild(currentChar).GetComponent<Renderer>().material = StaticData.WordData.CorrectLetterMat;
            correctChars++;
        }
        else
        {
            //Debug.Log("Tried: " + (char)((int)letter + 32));
            transform.GetChild(currentChar).GetComponent<Renderer>().material = StaticData.WordData.WrongLetterMat;
        }
        currentChar++;

        if (currentChar >= wordLenght)
        {
            eventHandler.InvokeWordTyped(this, new WordResult(word, correctChars, wordLenght));
            //Here wordTyped, word all letters typed
            DeInitializeWordTyping();
            Timing.RunCoroutine(gameObject.DelayDisableDestroy(StaticData.UtilityData.DisableDelay, StaticData.UtilityData.DestroyDelay));
            //Timing.RunCoroutine(DeInitializeWordSetup(3f));
            return;
            //Destroy(this.gameObject);
        }

        transform.GetChild(currentChar).GetComponent<Renderer>().material = StaticData.WordData.CurrentLetterMat;
    }

    //===========================================================================//

    protected virtual IEnumerator<float> DeInitializeWordSetup(float delay)
    {
        yield return Timing.WaitForSeconds(delay);

        this.gameObject.SetActive(false);

        yield return Timing.WaitForSeconds(delay);

        Destroy(this.gameObject);
    }

    //===========================================================================//

    public override bool Equals(object other)
    {
        var item = other as Word;

        if (item == null) return false;

        return this.wordID.Equals(item.wordID);
    }

    public override int GetHashCode()
    {
        return this.wordID.GetHashCode();
    }

    //============================================================================//
}
