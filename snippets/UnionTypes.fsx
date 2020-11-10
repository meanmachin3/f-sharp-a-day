// ---------------------------------------------------------------
//         Union types
// ---------------------------------------------------------------

module UnionTypes =

    /// Represents the suit of a playing card
    type Suit =
        | Hearts
        | Clubs
        | Diamonds
        | Spades

    /// Represents the rank of a playing card
    type Rank =
        /// Represents the rank of cards 2 .. 10
        | Value of int
        | Ace
        | King
        | Queen
        | Jack

        static member GetAllRanks() =
            [ yield Ace
              for i in 2 .. 10 do yield Value i
              yield Jack
              yield Queen
              yield King ]

    type Card =  { Suit: Suit; Rank: Rank }

    /// Returns a list representing all the cards in the deck

    let fullDeck =
        [ for suit in [ Hearts; Diamonds; Clubs; Spades] do
              for rank in Rank.GetAllRanks() do
                  yield { Suit=suit; Rank=rank } ]

    /// Converts a 'Card' object to a string
    let showCard c =
        let rankString =
            match c.Rank with
            | Ace -> "Ace"
            | King -> "King"
            | Queen -> "Queen"
            | Jack -> "Jack"
            | Value n -> string n

        let suitString =
            match c.Suit with
            | Clubs -> "clubs"
            | Diamonds -> "diamonds"
            | Spades -> "spades"
            | Hearts -> "hearts"

        rankString  + " of " + suitString

    let printAllCards() =
        for card in fullDeck do
            printfn "%s" (showCard card)

