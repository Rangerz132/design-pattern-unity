using System.Collections.Generic;
using System;

namespace StateDesignPattern
{
    public class GenericStateMachineManager<EState, TEntity> where EState : Enum
    {
        protected Dictionary<EState, GenericBaseState<EState>> states = new Dictionary<EState, GenericBaseState<EState>>();
        protected GenericBaseState<EState> previousState;
        protected GenericBaseState<EState> currentState;

        public TEntity Entity { get; private set; }

        // Constructor
        public GenericStateMachineManager(TEntity entity)
        {
            Entity = entity;
        }

        public void Initialize(EState stateKey)
        {
            previousState = states[stateKey];
            currentState = states[stateKey];
            currentState.EnterState();
        }

        public void UpdateState()
        {
            currentState.UpdateState();
        }

        public void ChangeState(EState stateKey)
        {
            currentState.ExitState();
            previousState = currentState;
            currentState = states[stateKey];
            currentState.EnterState();
        }
    }
}

