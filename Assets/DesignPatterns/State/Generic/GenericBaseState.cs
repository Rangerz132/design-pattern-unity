using System;

namespace StateDesignPattern {
    public abstract class GenericBaseState<EState> where EState : Enum
    {
        public GenericBaseState(EState stateKey)
        {
            StateKey = stateKey;
        }

        public EState StateKey { get; protected set; }

        public abstract void EnterState();
        public abstract void UpdateState();
        public abstract void FixedUpdateState();
        public abstract void ExitState();
    }
}
