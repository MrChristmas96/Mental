using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    [SerializeField] Text textBox;
    void Start()
    {
        textBox.text = "";
    }

 
    public IEnumerator KeyCard()
    {
        textBox.text = "A Keycard! This could be useful";
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
}
