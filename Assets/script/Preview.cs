using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace script
{
    public class Preview : MonoBehaviour
    {
        public Text previewText;

        // public TetrominoData data;

        public void Init(List<TetrominoData> datas)
        {
            // this.data = data;

            var allPreviewText = string.Join("\n",datas.Select(data => data.tetromino.ToString()));

            // this.previewText.text = data.tetromino.ToString();
            this.previewText.text = allPreviewText;
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