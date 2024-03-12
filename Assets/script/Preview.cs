using UnityEngine;
using UnityEngine.UI;

namespace script
{
    public class Preview : MonoBehaviour
    {
        public Text previewText;

        // private TetrominoData mData;

        public void Init(TetrominoData data)
        {
            // mData = data;
            this.previewText.text = data.tetromino.ToString();
        }
    }
}