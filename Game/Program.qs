namespace Game {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    
    // This is the function to modify. At the end of the game, supply
    // moves in the order in which they were cast.
    operation Moves(zero : Qubit[], one : Qubit[]) : Unit {

        // Round 1
        

        // Round 2
        

        // Round 3
        

        // Round 4
        

        // Round 5
        

    }
    
    @EntryPoint()
    operation SayHello() : Result[][] {
        Message("This game demonstrates quantum mechanical principles!");
        Message("See instructions to learn how to play.\n");
        use player0 = Qubit[3];
        use player1 = Qubit[3];

        X(player0[2]);
        X(player1[0]);
        X(player1[1]);

        Message("Starting states\nPlayer 0: [0, 0, 1]\nPlayer 1: [1, 1, 0]\n");

        // Edit the Moves(...) function body according to chosen gates.
        Moves(player0, player1);

        mutable zeror = new Result[3];
        mutable oner = new Result[3];

        for i in 0 .. 3 - 1 {

            set zeror w/= i <- M(player0[i]);
            set oner w/= i <- M(player1[i]);

        }

        Message("Final states\n[[Player zero], [Player one]]");

        return [zeror, oner];

    }
}
