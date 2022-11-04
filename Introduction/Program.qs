namespace QuantumArt {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    
    @EntryPoint()
    operation Draw() : Result[] {
        Message("Hello quantum world!");

        let size = 1000;

        mutable r = new Result[size];

        for i in 0 .. (size/10)-1 { 
            let p = Superpose(10);
            for j in 0 .. 10-1 {
                set r w/= (i*10)+j <- p[j];
            }
        }

        mutable output = "";

        for i in 0 .. size-1 {
            if (IsResultOne(r[i])) {
                set output += "1";
            } else {
                set output += "0";
            }
        }

        Message(output);

        return r;
    }

    operation Superpose(n : Int) : Result[] {
        mutable r = new Result[n];

        use qs = Qubit[n];

        ApplyToEach(H, qs);

        for index in 0 .. Length(qs) - 1 {

            set r w/= index <- M(qs[index]);

        }

        return r;
    }

}
