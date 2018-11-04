using Assets.POCSO;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using YamlDotNet.Serialization;

namespace Assets.Scripts
{
    public class CardManger : MonoBehaviour
    {
        public List<GameObject> PlayerCards;
        public List<GameObject> OpponentCards;
        //public const List<Card> Deck =
        //{
        //    new Card
        //    {
        //        FaceUp = true
        //    },
        //    new Card
        //    {
        //    }
        //};

        
        /*
         * Declarations of variables
         * -------------------------
         * Left most card position.
         * Offset of cards.
         * List of possible cards.
         * List of cards. -- pick from deck, without replacement
         * 
         * Deal
         * -------------
         * 1. Pick 2 cards
         * 2. first card pos = leftmost card pos
         * 3. rightmost card pos = first card pos + offset -- same
         * 
         * Hit
         * --------------
         * 0. Set new offset.
         * 0.1. Set new leftmost card pos
         * 0.2. Recalculate Deal steps
         * 1. Pick 1 card
         * 2. new card pos = rightmost card + offset -- same
         */
        // Use this for initialization
        public void Start ()
        {

            //foreach (var playerCard in PlayerCards) {
            //    //Debug.Log("trying to make visible");
            //    //SpriteRenderer spriteRenderer = playerCard.GetComponent<SpriteRenderer>();
            //    //spriteRenderer.SetAc
            //    playerCard.SetActive(false);
            //}
            LoadDeck();
        }
 
        // Load Yaml file into Json object
        private static dynamic LoadYaml(string file)
        {
            using (StreamReader r = new StreamReader(file))
            {
                string yamlString = r.ReadToEnd();

                var yamlObject = new DeserializerBuilder().Build().Deserialize(
                    new StringReader(yamlString)
                );

                var serializer = new Newtonsoft.Json.JsonSerializer();
                var jsonStringWriter = new StringWriter();
                serializer.Serialize(jsonStringWriter, yamlObject);
                var jsonString = jsonStringWriter.ToString();


                var jsonObject = JObject.Parse(jsonString);
                return jsonObject;
            }
        }

        private void LoadCardsFile()
        {
            const string cardsFile = @"Data\Cards.yaml";
            dynamic cards = LoadYaml(cardsFile);
        }
        private void LoadDeck()
        {
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
