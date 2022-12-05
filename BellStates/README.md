# Bell States

## Background
Bell states (aka EPR pairs) comprise four maximally entangled quantum states of two qubit systems. Taking a 2-qubit register initialized to any combination of spins up and down, Bell states can be generated using a Hadamard'ed qubit as the control for CNOT of another. In reality, it tends to be quite difficult to manipulate the spin states of more than one qubit. Oftentimes, this necessitates looking towards exchange interactions.

In a trapped ion system, the two levels $\ket{0}$ and $\ket{1}$ are modelled in accordance with the harmonic potential associated with the trap architecture and the global oscillating electric field. For single-qubit gates, it is straightforward enough to induce rotations and precessions about the $z$-direction through laser pulses modifying the metastable state occupied by a trapped ion. 

To explain engangled states, the existance of an auxillary state $\ket{2}$ is assumed. In the following, $\ket{n, m}$ is used to denote the spin state $n$ and the excitation state $m$. Tuning a laser to precise frequencies corresponding to the auxillary states stimulates transitions between states $\ket{1, 1}$ and $\ket{2, 0}$. Applying this laser for long enough to perform an $x$-direction rotation of $2\pi$ drives the transition $\ket{1, 1} \rightarrow -\ket{1, 1}$, yielding a Controlled-Z gate. For two qubit registers, Pairing this with a SWAP (obtained similarly by inducing the exchange $\ket{0, 1} \leftrightarrow \ket{1, 0}$) and a Hadamard gate constitutes a Controlled-NOT gate. *Note: Any change in vibrational quantum number has to do with interaction shared between the targeted qubits and is not reflected in spin state measurement.

## Teleportation
An unfathomable application of entangling qubits is the concept of _teleportation_. A quantum piece of information can be transferred from one individual to another using the entanglement of an auxiliary pair shared between both. Say these individuals are Alice and Bob. Alice being the sender of information about the spin state of a particle $A$ an Bob the receiver of this information. The entangled particles shared between them are $B$ and $C$. Alice can apply a cNOT gate followed by a Hadamard gate and measurement of qubits $A$ and $B$ to obtain information of the state vector for qubit $C$. For Bob to receive the information, Alice informs him of the necessary rotation to apply. Hence, Bob will have the quantum state intended to have been sent to him.

## Guide
The following links provide adequate information to run the experiment from your computer.
https://learn.microsoft.com/en-us/azure/quantum/user-guide/host-programs?tabs=tabid-csharp
https://learn.microsoft.com/en-us/azure/quantum/how-to-submit-jobs?pivots=ide-azurecli
