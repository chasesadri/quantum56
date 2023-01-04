# Game

## Background
Here's a game we can play using quantum bits and gates. You'll have to take turns gating yours and your opponents qubits. At the end, tally up the board's bits (0 or 1). The player with the most bits corresponding to their spin state after all gates have been used, wins!

## Rules
The game is played with two players (zero and one). Each player controls three qubits that are initialized in the following states.

$$
\text{Player zero: } \begin{bmatrix} 0 & 0 & 1\end{bmatrix}
$$

$$
\text{Player one : } \begin{bmatrix} 1 & 1 & 0\end{bmatrix}
$$

Zero always makes the first move and One follows. Players have access to the following gates and are allowed to use them in any order they choose.

$$
\text{Gates: } \begin{bmatrix} X & X & H & H & CNOT\end{bmatrix}
$$

$X$ gates are **defensive**. $H$ gates are **offensive** or **defensive**. The $CNOT$ gate is **offensive** and **defensive**, requiring the caster to select one of their own qubits as a control and one of their opponent's qubits as a target. 

*Defensive: Applied on the caster's side. The target should be kept secret from the other player

*Offensive: Applied on the opponent's side. Caster must specify the target.

The game is complete once both players have used all of their gates. At this point, the program will measure each side and display the final board state. It's up to each player to count results corresponding to their player. If the board has more 0s than 1s, player zero wins; and vice versa. If there's a draw, play again!

*Note: If you decide to play this on real quantum hardware, you'll receive a histogram of outcome probabilities. Use the highest probability outcome to decide the victor. If there's a tie, tally up counts from both/all results.

## How to play



## Guide
The following links will help you run the experiment from your computer at home.

- https://learn.microsoft.com/en-us/azure/quantum/user-guide/host-programs?tabs=tabid-csharp
- https://learn.microsoft.com/en-us/azure/quantum/how-to-submit-jobs?pivots=ide-azurecli
