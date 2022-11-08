namespace RegisterIntro {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    
    
    @EntryPoint()
    operation Draw() : Result[] {
        Message("Hello quantum world!");

        let register_size = 2; // Register size varies based on chosen hardware.
        let repetitions = 5;

        mutable results = new Result[register_size * repetitions];

        for i in 0 .. (repetitions)-1 { 
            let p = RegisterHadamard(register_size);
            for j in 0 .. register_size-1 {
                set results w/= (i*register_size)+j <- p[j];
            }
        }

        mutable output = "";

        // In my tests, this will not execute on quantum hardware. The Results
        // Type is very finnicky and it seems like we are not meant to reach
        // in and mess with the measurement.
        for i in 0 .. (register_size*repetitions)-1 {
            if (IsResultOne(results[i])) {
                set output += "1";
            } else {
                set output += "0";
            }
        }

        Message(output);

        return results;
    }

    operation RegisterHadamard(n : Int) : Result[] {
        mutable register = new Result[n];

        use qs = Qubit[n];

        ApplyToEach(H, qs);

        for index in 0 .. Length(qs) - 1 {

            set register w/= index <- M(qs[index]);

        }

        return register;
    }

}
