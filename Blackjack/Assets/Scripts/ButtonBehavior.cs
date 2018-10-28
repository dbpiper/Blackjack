using Boo.Lang;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ButtonBehavior : MonoBehaviour
    {
        private static class ButtonTypes
        {
            public const string Hit = "Hit Button";
            public const string Deal = "Deal Button";
            public const string Stand = "Stand Button";
        }

        public CardManger CardManagerRef;
        
        // Use this for initialization
        public void Start () {
        }
     
        // Update is called once per frame
        public void Update () {
        
        }

        public void ButtonClicked(GameObject button)
        {
             
            switch (button.name) {
            case ButtonTypes.Hit:
                CardManagerRef.Hit();
                break;
            case ButtonTypes.Deal:
                CardManagerRef.Deal();
                break;
            case ButtonTypes.Stand:
                CardManagerRef.Stand();
                break;
            default:
                Debug.Log($"invalid button name {button.name} clicked!");
                break;
            }
        }
    }
}
