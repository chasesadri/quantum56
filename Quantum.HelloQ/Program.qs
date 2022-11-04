namespace Quantum.HelloQ {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    open Microsoft.Quantum.Convert;
    
    @EntryPoint()
    operation SayHello() : Result {
        Message("Hello quantum world!");

        return RandomNumber();
    }

    operation RandomNumber() : Result {
        use q = Qubit();

        H(q);

        return M(q);
    }
}
