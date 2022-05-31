using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] Text textBox;
    [SerializeField] Text textBox2;
    void Start()
    {
        textBox.text = "";
    }

 
    public IEnumerator KeyCard()
    {
        textBox.text = "This must be an old journal record of a patient.";
        yield return new WaitForSeconds(3f);
        textBox.text = "Looks to be a from a few years before the hospital was closed";
        yield return new WaitForSeconds(3f);
        textBox.text = "";
    }

    public IEnumerator Paper()
    {
        textBox.text = "Daniella... That name sounds awfully familliar";
        yield return new WaitForSeconds(4f);
        textBox.text = "";
    }

    public IEnumerator Knife()
    {
        textBox.text = "Is that... Her?";
        yield return new WaitForSeconds(3f);
        textBox.text = "What a terrible way to die...";
        yield return new WaitForSeconds(3f);
        textBox.text = "";
    }

    public IEnumerator Death()
    {
        textBox.text = "But... She can't be dead!";
        yield return new WaitForSeconds(3f);
        textBox.text = "It must have been someone else.";
        yield return new WaitForSeconds(3f);
        textBox.text = "";
    }

    public IEnumerator Picture()
    {
        textBox.text = "Daniella... I remember now.";
        yield return new WaitForSeconds(3f);
        textBox.text = "That was the happiest day of my life...";
        yield return new WaitForSeconds(4f);
        textBox.text = "";
    }

    public IEnumerator Collection()
    {
        textBox.text = "It was me all along...";
        yield return new WaitForSeconds(3f);
        textBox.text = "It's all my fault...";
        yield return new WaitForSeconds(4f);
        textBox.text = "";
    }

    public IEnumerator LoopHover()
    {
        textBox2.text = "Curse yourself to walk these halls\n for all eternity...";
        textBox.text = "There's no hope for me anymore!";
        yield return new WaitForSeconds(3f);
    }

    public IEnumerator EscapeHover()
    {
        textBox2.text = "Escape this hellish place!\n Start your life anew...";
        textBox.text = "Maybe i can still atone for my sins.";
        yield return new WaitForSeconds(3f);
    }
}
