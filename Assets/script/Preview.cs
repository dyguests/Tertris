using UnityEngine;
using UnityEngine.UI;

namespace script
{
    public class Preview : MonoBehaviour
    {
        public Text previewText;

        // public TetrominoData data;

        public void Init(TetrominoData data)
        {
            // this.data = data;
            this.previewText.text = data.tetromino.ToString();
        }
    }
}

class Aaa
{
    public int bbb;

    public void Ccc()
    {
        var i = this.bbb;
    }
}

class Test
{
    void Testt()
    {
        var a1 = new Aaa();
        var bbb = a1.bbb;
        a1.Ccc();

        var a2 = new Aaa();
        a2.Ccc();
    }
}