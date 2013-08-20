Finish the "Poker" project given in the Visual Studio Solution "11. Test-Driven-Development-Demo+Homework.zip" using TDD.

1. Write a class Card implementing the ICard interface. Implement the properties. Write a constructor. Implement the ToString() method. Test all cases.

2. Write a class Hand implementing the IHand interface. Implement the properties. Write a constructor. Implement the ToString() method. Test all cases.

3. Write a class PokerHandsChecker (+ tests) and start implementing the IPokerHandsChecker interface. Implement the IsValidHand(IHand). A hand is valid when it consists of exactly 5 different cards.

4. Implement IPokerHandsChecker.IsFlush(IHand) method. Follow the official poker rules from Wikipedia: http://en.wikipedia.org/wiki/List_of_poker_hands

5. Implement IsFourOfAKind(IHand) method. Did you test all the scenarios?

6.* Implement the other check for poker hands: IsHighCard(IHand hand), IsOnePair(IHand hand), IsTwoPair(IHand hand), IsThreeOfAKind(IHand hand), IsFullHouse(IHand hand), IsStraight(IHand hand) and IsStraightFlush(IHand hand). Did you test all the scenarios well?

7.* Implement a card comparison logic for Poker hands (+ tests). CompareHands(�) should return -1, 0 or 1.
