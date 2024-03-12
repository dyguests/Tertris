using UnityEngine;
using UnityEngine.UI;

namespace script
{
    public class Preview : MonoBehaviour
    {
        public Text previewText;

        public TetrominoData data;

        public void Init(TetrominoData data)
        {
            this.data = data;
            this.previewText.text = data.tetromino.ToString();
        }
    }
}