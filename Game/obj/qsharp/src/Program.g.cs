//------------------------------------------------------------------------------
// <auto-generated>                                                             
//     This code was generated by a tool.                                       
//     Changes to this file may cause incorrect behavior and will be lost if    
//     the code is regenerated.                                                 
// </auto-generated>                                                            
//------------------------------------------------------------------------------
#pragma warning disable 436
#pragma warning disable 162
#pragma warning disable 1591
using System;
using Microsoft.Quantum.Core;
using Microsoft.Quantum.Intrinsic;
using Microsoft.Quantum.Intrinsic.Interfaces;
using Microsoft.Quantum.Simulation.Core;

[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Game\",\"Name\":\"Moves\"},\"Attributes\":[],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Chase\\\\Documents\\\\quantum56\\\\Game\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"zero\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":17},\"Item2\":{\"Line\":1,\"Column\":21}}}]},{\"Case\":\"QsTupleItem\",\"Fields\":[{\"VariableName\":{\"Case\":\"ValidName\",\"Fields\":[\"one\"]},\"Type\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},\"InferredInformation\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Position\":{\"Case\":\"Null\"},\"Range\":{\"Item1\":{\"Line\":1,\"Column\":33},\"Item2\":{\"Line\":1,\"Column\":36}}}]}]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"TupleType\",\"Fields\":[[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]},{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Qubit\"}]}]]},\"ReturnType\":{\"Case\":\"UnitType\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Game\",\"Name\":\"Moves\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Chase\\\\Documents\\\\quantum56\\\\Game\\\\Program.qs\",\"Position\":{\"Item1\":7,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":16}},\"Documentation\":[]}")]
[assembly: CallableDeclaration("{\"Kind\":{\"Case\":\"Operation\"},\"QualifiedName\":{\"Namespace\":\"Game\",\"Name\":\"SayHello\"},\"Attributes\":[{\"TypeId\":{\"Case\":\"Value\",\"Fields\":[{\"Namespace\":\"Microsoft.Quantum.Core\",\"Name\":\"EntryPoint\",\"Range\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]}}]},\"TypeIdRange\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":2},\"Item2\":{\"Line\":1,\"Column\":12}}]},\"Argument\":{\"Item1\":{\"Case\":\"UnitValue\"},\"Item2\":[],\"Item3\":{\"Case\":\"UnitType\"},\"Item4\":{\"IsMutable\":false,\"HasLocalQuantumDependency\":false},\"Item5\":{\"Case\":\"Value\",\"Fields\":[{\"Item1\":{\"Line\":1,\"Column\":12},\"Item2\":{\"Line\":1,\"Column\":14}}]}},\"Offset\":{\"Item1\":31,\"Item2\":4},\"Comments\":{\"OpeningComments\":[],\"ClosingComments\":[]}}],\"Modifiers\":{\"Access\":{\"Case\":\"DefaultAccess\"}},\"SourceFile\":\"C:\\\\Users\\\\Chase\\\\Documents\\\\quantum56\\\\Game\\\\Program.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"SymbolRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"ArgumentTuple\":{\"Case\":\"QsTuple\",\"Fields\":[[]]},\"Signature\":{\"TypeParameters\":[],\"ArgumentType\":{\"Case\":\"UnitType\"},\"ReturnType\":{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"ArrayType\",\"Fields\":[{\"Case\":\"Result\"}]}]},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}}},\"Documentation\":[]}")]
[assembly: SpecializationDeclaration("{\"Kind\":{\"Case\":\"QsBody\"},\"TypeArguments\":{\"Case\":\"Null\"},\"Information\":{\"Characteristics\":{\"Case\":\"EmptySet\"},\"InferredInformation\":{\"IsSelfAdjoint\":false,\"IsIntrinsic\":false}},\"Parent\":{\"Namespace\":\"Game\",\"Name\":\"SayHello\"},\"Attributes\":[],\"SourceFile\":\"C:\\\\Users\\\\Chase\\\\Documents\\\\quantum56\\\\Game\\\\Program.qs\",\"Position\":{\"Item1\":32,\"Item2\":4},\"HeaderRange\":{\"Item1\":{\"Line\":1,\"Column\":11},\"Item2\":{\"Line\":1,\"Column\":19}},\"Documentation\":[]}")]
#line hidden
namespace Game
{
    [SourceLocation("C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs", OperationFunctor.Body, 8, 33)]
    public partial class Moves : Operation<(IQArray<Qubit>,IQArray<Qubit>), QVoid>, ICallable
    {
        public Moves(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(IQArray<Qubit>,IQArray<Qubit>)>, IApplyData
        {
            public In((IQArray<Qubit>,IQArray<Qubit>) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    return Qubit.Concat(((IApplyData)Data.Item1)?.Qubits, ((IApplyData)Data.Item2)?.Qubits);
                }
            }
        }

        String ICallable.Name => "Moves";
        String ICallable.FullName => "Game.Moves";
        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__H
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> Microsoft__Quantum__Intrinsic__CNOT
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        public override Func<(IQArray<Qubit>,IQArray<Qubit>), QVoid> __Body__ => (__in__) =>
        {
            var (zero,one) = __in__;
#line 11 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__H.Apply(zero[1L]);
#line 12 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__H.Apply(one[0L]);
#line 15 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__CNOT.Apply((zero[2L], one[1L]));
#line 16 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__X.Apply(one[2L]);
#line 19 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__H.Apply(zero[2L]);
#line 20 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__H.Apply(zero[1L]);
#line 23 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__X.Apply(zero[0L]);
#line 24 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__CNOT.Apply((one[2L], zero[2L]));
#line 27 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__X.Apply(zero[2L]);
#line 28 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Microsoft__Quantum__Intrinsic__X.Apply(one[1L]);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void __Init__()
        {
            this.Microsoft__Quantum__Intrinsic__H = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.H));
            this.Microsoft__Quantum__Intrinsic__CNOT = this.__Factory__.Get<IUnitary<(Qubit,Qubit)>>(typeof(global::Microsoft.Quantum.Intrinsic.CNOT));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
        }

        public override IApplyData __DataIn__((IQArray<Qubit>,IQArray<Qubit>) data) => new In(data);
        public override IApplyData __DataOut__(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, IQArray<Qubit> zero, IQArray<Qubit> one)
        {
            return __m__.Run<Moves, (IQArray<Qubit>,IQArray<Qubit>), QVoid>((zero, one));
        }
    }

    [SourceLocation("C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs", OperationFunctor.Body, 33, -1)]
    public partial class SayHello : Operation<QVoid, IQArray<IQArray<Result>>>, ICallable
    {
        public SayHello(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "SayHello";
        String ICallable.FullName => "Game.SayHello";
        public static EntryPointInfo<QVoid, IQArray<IQArray<Result>>> Info => new EntryPointInfo<QVoid, IQArray<IQArray<Result>>>(typeof(SayHello));
        protected ICallable<String, QVoid> Message__
        {
            get;
            set;
        }

        protected Allocate Allocate__
        {
            get;
            set;
        }

        protected Release Release__
        {
            get;
            set;
        }

        protected IUnitary<Qubit> Microsoft__Quantum__Intrinsic__X
        {
            get;
            set;
        }

        protected ICallable<(IQArray<Qubit>,IQArray<Qubit>), QVoid> Moves__
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> Microsoft__Quantum__Intrinsic__M
        {
            get;
            set;
        }

        public override Func<QVoid, IQArray<IQArray<Result>>> __Body__ => (__in__) =>
        {
#line 34 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Message__.Apply("This game demonstrates quantum mechanical principles!");
#line 35 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
            Message__.Apply("See instructions to learn how to play.\n");
#line hidden
            {
#line 36 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                var player0 = Allocate__.Apply(3L);
#line hidden
                bool __arg1__ = true;
                try
                {
#line hidden
                    {
#line 37 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                        var player1 = Allocate__.Apply(3L);
#line hidden
                        bool __arg2__ = true;
                        try
                        {
#line 39 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            Microsoft__Quantum__Intrinsic__X.Apply(player0[2L]);
#line 40 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            Microsoft__Quantum__Intrinsic__X.Apply(player1[0L]);
#line 41 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            Microsoft__Quantum__Intrinsic__X.Apply(player1[1L]);
#line 43 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            Message__.Apply("Starting states\nPlayer 0: [0, 0, 1]\nPlayer 1: [1, 1, 0]\n");
#line 46 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            Moves__.Apply((player0, player1));
#line 48 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            var zeror = QArray<Result>.Create(3L);
#line 49 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            var oner = QArray<Result>.Create(3L);
#line 51 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            foreach (var i in new QRange(0L, (3L - 1L)))
#line hidden
                            {
#line 53 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                                zeror.Modify(i, Microsoft__Quantum__Intrinsic__M.Apply(player0[i]));
#line 54 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                                oner.Modify(i, Microsoft__Quantum__Intrinsic__M.Apply(player1[i]));
                            }

#line 58 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            Message__.Apply("Final states\n[[Player zero], [Player one]]");
#line 60 "C:\\Users\\Chase\\Documents\\quantum56\\Game\\Program.qs"
                            return new QArray<IQArray<Result>>(zeror?.Copy(), oner?.Copy());
                        }
#line hidden
                        catch
                        {
                            __arg2__ = false;
                            throw;
                        }
#line hidden
                        finally
                        {
                            if (__arg2__)
                            {
#line hidden
                                Release__.Apply(player1);
                            }
                        }
                    }
                }
#line hidden
                catch
                {
                    __arg1__ = false;
                    throw;
                }
#line hidden
                finally
                {
                    if (__arg1__)
                    {
#line hidden
                        Release__.Apply(player0);
                    }
                }
            }
        }

        ;
        public override void __Init__()
        {
            this.Message__ = this.__Factory__.Get<ICallable<String, QVoid>>(typeof(global::Microsoft.Quantum.Intrinsic.Message));
            this.Allocate__ = this.__Factory__.Get<Allocate>(typeof(global::Microsoft.Quantum.Intrinsic.Allocate));
            this.Release__ = this.__Factory__.Get<Release>(typeof(global::Microsoft.Quantum.Intrinsic.Release));
            this.Microsoft__Quantum__Intrinsic__X = this.__Factory__.Get<IUnitary<Qubit>>(typeof(global::Microsoft.Quantum.Intrinsic.X));
            this.Moves__ = this.__Factory__.Get<ICallable<(IQArray<Qubit>,IQArray<Qubit>), QVoid>>(typeof(Moves));
            this.Microsoft__Quantum__Intrinsic__M = this.__Factory__.Get<ICallable<Qubit, Result>>(typeof(global::Microsoft.Quantum.Intrinsic.M));
        }

        public override IApplyData __DataIn__(QVoid data) => data;
        public override IApplyData __DataOut__(IQArray<IQArray<Result>> data) => data;
        public static System.Threading.Tasks.Task<IQArray<IQArray<Result>>> Run(IOperationFactory __m__)
        {
            return __m__.Run<SayHello, QVoid, IQArray<IQArray<Result>>>(QVoid.Instance);
        }
    }
}