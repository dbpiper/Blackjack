using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class CardManger : MonoBehaviour
    {
        public List<GameObject> PlayerCards;
        public List<GameObject> OpponentCards;
        
        // Use this for initialization
        public void Start () {
        }
    
        // Update is called once per frame
        public void Update () {
        
        }

        public void Stand()
        {
        }

        public void Deal()
        {
            foreach (var playerCard in PlayerCards) {
                playerCard.SetActive(true);
            }
            foreach (var opponentCard in OpponentCards) {
                opponentCard.SetActive(true);
            }
        }

        public void Hit()
        {
        }
    }
}
