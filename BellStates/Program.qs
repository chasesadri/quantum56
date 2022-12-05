namespace BellStates {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert;

    // Set a pair of qubits in maximally entangled state.
    operation GenerateBellState(pair : Qubit[]) : Unit {

        H(pair[0]);
        CNOT(pair[0], pair[1]);

    }

    // Encode two classical bits in a single qubit.
    operation Encode(q : Qubit, message : Bool[]) : Unit {

        // CNOT using classical bit as control.
        if (message[1]) {
            X(q);
        }

        // Controlled-Z using classical bit as control.
        if (message[0]) {
            Z(q);
        }

    }

    // Decode the two classical bits stored in a single
    // qubit.
    operation Decode(pair : Qubit[]) : Result[] {

        CNOT(pair[0], pair[1]);
        H(pair[0]);

        return [M(pair[0]), M(pair[1])];

    }

    @EntryPoint()
    operation Main() : Result[] {

        // Generate an entangled pair that's to be shared 
        // between Bob and Alice.
        use pair = Qubit[2];
        GenerateBellState(pair);

        // Alice encodes two classical bits of information
        // in a single qubit that's to be sent to Bob.
        // Alice's bits are represented as a boolean pair.
        let message = [false, false];
        Encode(pair[0], message);

        // Bob decodes the information to interpret the
        // two bits of information sent by Alice.
        let r = Decode(pair);

        // In conclusion, Alice only needs to send a
        // single qubit to transmit two classical bits.
        return r;

    }
    
}
