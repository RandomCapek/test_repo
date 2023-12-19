using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheGameProject
{
    class Program
    {
        static void Main()
        {
            Game pokerGame = new Game();
            pokerGame.StartGame();
            Console.ReadKey();
        }
    }

    class Card
    {
        public string Suit { get; }
        public string Rank { get; }

        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        public override string ToString()
        {
            return $"{Rank} of {Suit}";
        }
    }

    class Deck
    {
        private List<Card> cards;

        public Deck()
        {
            InitializeDeck();
            Shuffle();
        }

        private void InitializeDeck()
        {
            cards = new List<Card>();
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

            foreach (var suit in suits)
            {
                foreach (var rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        public void Shuffle()
        {
            Random random = new Random();
            cards = cards.OrderBy(card => random.Next()).ToList();
        }

        public Card DealCard()
        {
            if (cards.Count > 0)
            {
                Card dealtCard = cards[0];
                cards.RemoveAt(0);
                return dealtCard;
            }
            else
            {
                Console.WriteLine("No more cards in the deck.");
                return null;
            }
        }
    }

    class Player
    {
        public string Name { get; }
        public List<Card> Hand { get; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public void AddCardToHand(Card card)
        {
            Hand.Add(card);
        }

        public void ShowHand()
        {
            Console.WriteLine($"{Name}'s hand:");
            foreach (var card in Hand)
            {
                Console.WriteLine(card);
            }
        }
    }

    class Game
    {
        private Deck deck;
        private List<Player> players;

        public Game()
        {
            deck = new Deck();
            players = new List<Player>
    {
        new Player("Player 1"),
        new Player("Player 2")
        // Add more players if needed
    };
        }

        public void StartGame()
        {
            DealInitialCards();
            DisplayHands();

            // Implement game logic here

            // Example: Compare hands to determine the winner
            Player winner = CompareHands();
            Console.WriteLine($"{winner.Name} wins!");

            // Other game logic can be added here
        }

        private void DealInitialCards()
        {
            foreach (var player in players)
            {
                for (int i = 0; i < 5; i++)
                {
                    Card dealtCard = deck.DealCard();
                    if (dealtCard != null)
                    {
                        player.AddCardToHand(dealtCard);
                    }
                }
            }
        }

        private void DisplayHands()
        {
            foreach (var player in players)
            {
                player.ShowHand();
                Console.WriteLine();
            }
        }

        private Player CompareHands()
        {
            // Simplified logic: Just compare the total values of the hands
            // You may need to implement more complex rules for a real poker game
            Player winner = players[0];
            foreach (var player in players)
            {
                if (CalculateHandValue(player.Hand) > CalculateHandValue(winner.Hand))
                {
                    winner = player;
                }
            }
            return winner;
        }

        private int CalculateHandValue(List<Card> hand)
        {
            // Simplified logic: Just sum the ranks of the cards in the hand
            // You may need to implement more complex rules for a real poker game
            return hand.Sum(card => GetCardValue(card.Rank));
        }

        private int GetCardValue(string rank)
        {
            // Simplified logic: Assign values based on ranks
            // You may need to implement more complex rules for a real poker game
            switch (rank)
            {
                case "Jack":
                    return 11;
                case "Queen":
                    return 12;
                case "King":
                    return 13;
                case "Ace":
                    return 14;
                default:
                    return int.Parse(rank);
            }
        }
    }
}
