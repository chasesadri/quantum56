# RegisterIntro

## Background
This introduces the concept of qubit registers along with methods to run
repeated simulations for fidelity-testing. The results of this experiment are 
"true random" measurements. The Hadamard Gate sets an up or down qubit into equal superposition
such that a measurement will yield a zero or one with fifty percent probability for each. In an 
ion trap, this is done with precise frequency laser delivered for specified durations and/or microwave 
pulses of particular frequencies.

$$
{\hat{H}} = \frac{1}{\sqrt{2}}

\begin{bmatrix}
1 & 1\\ 
1 & -1
\end{bmatrix}
$$

Performing matrix multiplication with states initialized to up or down will prove the equal
distribution.

$$
\begin{bmatrix}
1 & 1\\ 
1 & -1
\end{bmatrix}

\begin{bmatrix}
1 \\ 
0
\end{bmatrix}

=

\frac{\ket{0} + \ket{1}}{\sqrt{2}}
$$
$$

\begin{bmatrix}
1 & 1\\ 
1 & -1
\end{bmatrix}

\begin{bmatrix}
0 \\ 
1
\end{bmatrix}

= 

\frac{\ket{0} - \ket{1}}{\sqrt{2}}

$$

where

$$

\ket{0} = \begin{bmatrix} 1 \\ 0 \end{bmatrix}

\text{ and }

\ket{1} = \begin{bmatrix} 0 \\ 1 \end{bmatrix}

$$



Philosophically, the argument could be made that true randomness does not exist in
nature. However, it is widely agreed upon that these results comprise a more reliable
standard of randomness when compared to those that are algorithmically generated based
on an assortment of input data.

## Guide
The following links provide adequate information to run the experiment from your computer.
https://learn.microsoft.com/en-us/azure/quantum/user-guide/host-programs?tabs=tabid-csharp
https://learn.microsoft.com/en-us/azure/quantum/how-to-submit-jobs?pivots=ide-azurecli